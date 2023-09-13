using System.CodeDom.Compiler;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace Wiki_devel
{
    public partial class Form1 : Form
    {
        public string[,] dataSet;
        static int rows = 12;
        static int columns = 4;

        public Form1()
        {
            InitializeComponent();
            dataSet = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataSet[i, j] = ""; // Creates the default string values in the 2D array as ""
                }
            }
        }
        //9.2 Create an add button that will store the information from the 4 text boxes into the 2D array
        private void add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dataSet[0, 0])) // Empty String is sorted to the beginning of the array
            {
                MessageBox.Show("The array is full!", "Full Array", MessageBoxButtons.OK);
            }
            for (int i = 0; i < rows; i++)
            {
                if (String.IsNullOrEmpty(dataSet[i, 0]))
                {
                    if (nameTextbox.Text == "" | structureTextbox.Text == "" | categoryTextbox.Text == "" | definitionTextbox.Text == "")
                    {
                        MessageBox.Show("Please fill out all fields before adding to the Dictionary", "Empty Fields", MessageBoxButtons.OK);
                        break;
                    }
                    else
                    {
                        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                        dataSet[i, 0] = textInfo.ToTitleCase(nameTextbox.Text); // Adds name data to the array
                        dataSet[i, 1] = textInfo.ToTitleCase(categoryTextbox.Text); // Adds category data to the array
                        dataSet[i, 2] = textInfo.ToTitleCase(structureTextbox.Text); // Adds structure data to the array
                        dataSet[i, 3] = definitionTextbox.Text; // Adds definition data to the array

                        //9.8 Create a display method that will show the following information in a listview, Name and category
                        RefreshData();
                        Clear();
                        return;
                    }
                }
            }
        }
        // 9.9 Create a method so the user can select a definition (Name) from the Listview and all the information is displayed in the appropriate textboxes
        private void nameListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameListview.MultiSelect = false;
            ListViewItem selectedItem = nameListview.SelectedItems.Count > 0 ? nameListview.SelectedItems[0] : null;
            if (selectedItem != null)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (dataSet[i, 0] == selectedItem.Text)
                    {
                        nameTextbox.Text = dataSet[i, 0];
                        categoryTextbox.Text = dataSet[i, 1];
                        structureTextbox.Text = dataSet[i, 2];
                        definitionTextbox.Text = dataSet[i, 3];
                        break;
                    }
                }
            }
        }
        // 9.4 Create a delete button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (nameListview.SelectedItems.Count != 0 | nameTextbox.Text != "" | structureTextbox.Text != "" | categoryTextbox.Text != "" | definitionTextbox.Text != "")
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete these values?", "Delete Confirmation", MessageBoxButtons.YesNo);
                switch (confirmation)
                {
                    case DialogResult.Yes:

                        nameListview.MultiSelect = false;
                        int selectedIndex = nameListview.SelectedIndices[0];
                        ListViewItem selectedItem = nameListview.SelectedItems.Count > 0 ? nameListview.SelectedItems[0] : null;
                        if (selectedItem != null)
                        {
                            for (int i = 0; i < rows; i++)
                            {
                                if (dataSet[i, 0] == selectedItem.Text)
                                {
                                    dataSet[i, 0] = "";
                                    dataSet[i, 1] = "";
                                    dataSet[i, 2] = "";
                                    dataSet[i, 3] = "";
                                    nameListview.Items.RemoveAt(selectedIndex);
                                    Clear();
                                    break;
                                }
                            }
                        }
                        RefreshData();
                        break;
                    case DialogResult.No:
                        return;
                }
            }
            else
            {
                MessageBox.Show("There is no data selected! Please select data from the list", "No Data Selected", MessageBoxButtons.OK);
            }
        }
        // 9.3 Create an Edit button that will allow the user to modify any information from the four text boxes into the 2D array
        private void editBtn_Click_1(object sender, EventArgs e)
        {
            if (nameListview.SelectedItems.Count == 0)
            {
                MessageBox.Show("There is no data selected!", "Edit error", MessageBoxButtons.OK);
            }
            else if (nameTextbox.Text == "" | structureTextbox.Text == "" | categoryTextbox.Text == "" | definitionTextbox.Text == "")
            {
                MessageBox.Show("Please fill out all fields before adding to the Dictionary");
            }
            else
            {
                int nameIndex = nameListview.SelectedIndices[0];

                dataSet[nameIndex, 0] = nameTextbox.Text;
                dataSet[nameIndex, 1] = categoryTextbox.Text;
                dataSet[nameIndex, 2] = structureTextbox.Text;
                dataSet[nameIndex, 3] = definitionTextbox.Text;
                // 9.8 Create a display method that will show the following information in a listview, Name and category
                RefreshData();
                Clear();
                nameListview.SelectedItems.Clear(); // Deselects current value in the nameListview
            }
        }
        // 9.5 Create a clear method to clear the four text boxes so a new definition can be added
        private void clearField_Click(object sender, EventArgs e)
        {
            Clear();
            nameListview.SelectedItems.Clear(); // Deselects current value in the nameListview
        }
        // 9.10 Create a save button so information from the 2D array can be written into a binary file called definitions.dat
        // which is sorted by Name, ensure the user has the option to save it as an alternative file.
        // Use a file stream and BinaryWriter to create this file.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog(); // Opens windows directory
            saveFile.Filter = "dat files (*.dat)|*.dat";
            saveFile.Title = "Save File";
            saveFile.FileName = "definitions.dat"; // binary file definitons.dat

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFile.FileName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                bw.Write(dataSet[i, j]);
                            }
                        }
                    }
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex.Message}", "Error", MessageBoxButtons.OK);
                }
            }
        }
        // 9.11 Create a load button that will read information from a binary file called definitions.dat into the 2D array
        // ensure the user has the option to select an alternative file. Use a file stream and BinaryReader to complete this task.
        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "dat files (*.dat)|*.dat";
            openFile.Title = "Open File";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    nameListview.Items.Clear();
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataSet[i, j] = br.ReadString();
                        }
                    }
                    RefreshData();
                    br.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex.Message}", "Error", MessageBoxButtons.OK); // Displays error if opening file fails
                }
            }
        }
        // 9.7 Write code for a Binary search for the Name in the 2D array and display the information in the other textboxes when found
        // Add suitable feedback if the search failed, and clear the search textbox (Do not use built in array methods)
        private void search_Click(object sender, EventArgs e)
        {
            searchTextbox.Focus(); // Focuses the textbox after every search

            if (!string.IsNullOrEmpty(searchTextbox.Text))
            {
                Clear();

                bool found = false; // If true, breaks out of the while loop
                int min = 0;
                int max = 11;

                string key = searchTextbox.Text.ToLower();

                while (!found && min <= max)
                {
                    int mid = (min + max) / 2;
                    if (key == dataSet[mid, 0].ToLower())
                    {
                        found = true;
                        nameTextbox.Text = dataSet[mid, 0];
                        categoryTextbox.Text = dataSet[mid, 1];
                        structureTextbox.Text = dataSet[mid, 2];
                        definitionTextbox.Text = dataSet[mid, 3];
                        searchTextbox.Clear();
                        break;
                    }
                    else if (key.CompareTo(dataSet[mid, 0]) > 0) // compares only if dataSet[i, 0] != searchInput.Text
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Value not found", "Not Found");
                    searchTextbox.Clear();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please input a value to search", "Empty Search Value", MessageBoxButtons.OK);
            }
        }
        // 9.6 Write code for a Bubble sort method to sort the 2D array by name ascending order
        // ensure to use a seperate swap method that passes the array element to be swapped
        // Do not use any built-in array methods.
        private void bubbleSort() // Iterates through the first column of my dataset and compares string values
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - 1; j++)
                {
                    if (string.Compare(dataSet[j, 0], dataSet[j + 1, 0]) > 0)
                    {
                        Swap(j);
                    }
                }
            }
        }
        private void Swap(int row) // Simple swap method to sort strings alphabetically
        {
            for (int i = 0; i < columns; i++)
            {
                string temp = dataSet[row, i];
                dataSet[row, i] = dataSet[row + 1, i];
                dataSet[row + 1, i] = temp;
            }
        }
        private void RefreshData() // Loops through the array updating the listview with updated array data
        {
            bubbleSort();
            nameListview.Clear();
            nameListview.Columns.Add("Name", 95, HorizontalAlignment.Left);
            nameListview.Columns.Add("Category", 95, HorizontalAlignment.Left);

            for (int i = 0; i < rows; i++)
            {
                if (!String.IsNullOrEmpty(dataSet[i, 0]))
                {
                    ListViewItem item = new ListViewItem(dataSet[i, 0]);
                    item.SubItems.Add(dataSet[i, 1]);
                    nameListview.Items.Add(item);

                }
            }
        }
        private void Clear() // Clears the Text fields so new data can be added or viewed
        {
            nameTextbox.Clear();
            categoryTextbox.Clear();
            structureTextbox.Clear();
            definitionTextbox.Clear();
        }
    }
}