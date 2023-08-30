namespace Wiki_devel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int arrayRows = data.dataSet.GetLength(0);
            int arrayColumns = data.dataSet.GetLength(1);
            for (int i = 0; i < arrayRows; i++)
            {
                for (int j = 0; j < arrayColumns; j++)
                {
                    data.dataSet[i, j] = "~"; // Creates the default string values in the 2D array as "~"
                }
            }
        }
        Data data = new Data();
        int arraySize = 12;

        //9.2 Create an add button that will store the information from the 4 text boxes into the 2D array
        private void add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arraySize; i++)
            {
                if (data.dataSet[i, 0] == "~")
                {

                    if (nameTextbox.Text == "" | structureTextbox.Text == "" | categoryTextbox.Text == "" | definitionTextbox.Text == "")
                    {
                        MessageBox.Show("Please fill out all fields before adding to the Dictionary");
                        break;
                    }
                    else
                    {
                        data.dataSet[i, 0] = nameTextbox.Text.ToLower(); // Adds name data to the array
                        data.dataSet[i, 1] = categoryTextbox.Text; // Adds category data to the array
                        data.dataSet[i, 2] = structureTextbox.Text; // Adds structure data to the array
                        data.dataSet[i, 3] = definitionTextbox.Text; // Adds definition data to the array

                        //9.8 Create a display method that will show the following information in a listview, Name and category
                        nameListbox.Items.Add(data.dataSet[i, 0]);
                        categoryListbox.Items.Add(data.dataSet[i, 1].ToUpper());

                        // Resets the Textbox fields so new data can be added
                        nameTextbox.Clear();
                        categoryTextbox.Clear();
                        structureTextbox.Clear();
                        definitionTextbox.Clear();
                        break;
                    }
                }

            }
        }
        // 9.9 Create a method so the user can select a definition (Name) from the Listview and all the information is displayed in the appropriate textboxes
        private void nameListbox_SelectedIndexChanged(object sender, EventArgs e) // Lists the items from nameListbox to the add fields, can't be edited
        {
            if (nameListbox.SelectedItem != null)
            {
                var nameString = nameListbox.SelectedItem;
                for (int i = 0; i < arraySize; i++)
                {
                    if (data.dataSet[i, 0] == (string)nameString)
                    {
                        // Gives the index of the nameListbox - needed as we have a 2D array
                        //Displays the information in the categorised Textboxes
                        nameTextbox.Text = data.dataSet[i, 0];
                        categoryTextbox.Text = data.dataSet[i, 1];
                        structureTextbox.Text = data.dataSet[i, 2];
                        definitionTextbox.Text = data.dataSet[i, 3];
                    }
                }
            }
        }
        // 9.4 Create a delete button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text != "" | structureTextbox.Text != "" | categoryTextbox.Text != "" | definitionTextbox.Text != "")
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete these values?", "Delete confirmation", MessageBoxButtons.YesNo);
                switch (confirmation)
                {
                    case DialogResult.Yes:
                        if (nameListbox.SelectedIndex > -1)
                        {
                            int selectedIndex = nameListbox.SelectedIndex;
                            categoryListbox.Items.RemoveAt(nameListbox.SelectedIndex);
                            nameListbox.Items.RemoveAt(nameListbox.SelectedIndex);

                            nameTextbox.Text = "";
                            categoryTextbox.Text = "";
                            structureTextbox.Text = "";
                            definitionTextbox.Text = "";

                            data.dataSet[selectedIndex, 0] = "~";
                            data.dataSet[selectedIndex, 1] = "~";
                            data.dataSet[selectedIndex, 2] = "~";
                            data.dataSet[selectedIndex, 3] = "~";
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
        // 9.3 Create an Edit button that will allow the user to modify any information from the four text boxes into the 2D array
        private void editBtn_Click(object sender, EventArgs e)
        {
            int nameIndex = nameListbox.SelectedIndex;

            data.dataSet[nameIndex, 0] = nameTextbox.Text;
            data.dataSet[nameIndex, 1] = categoryTextbox.Text;
            data.dataSet[nameIndex, 2] = structureTextbox.Text;
            data.dataSet[nameIndex, 3] = definitionTextbox.Text;

            // 9.8 Create a display method that will show the following information in a listview, Name and category
            nameListbox.Items[nameIndex] = nameTextbox.Text.ToLower();
            categoryListbox.Items[nameIndex] = categoryTextbox.Text.ToLower();

            nameTextbox.Text = "";
            categoryTextbox.Text = "";
            structureTextbox.Text = "";
            definitionTextbox.Text = "";
        }

        // 9.5 Create a clear method to clear the four text boxes so a new definition can be added
        private void clearField_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = "";
            categoryTextbox.Text = "";
            structureTextbox.Text = "";
            definitionTextbox.Text = "";
        }
        private void searchTextbox_DoubleClick(object sender, EventArgs e)
        {
            // Clears the current fields by double clicking "searchTextbox"
            nameTextbox.Text = "";
            categoryTextbox.Text = "";
            structureTextbox.Text = "";
            definitionTextbox.Text = "";
        }
        // 9.10 Create a save button so information from the 2D array can be written into a binary file called definitions.dat
        // which is sorted by Name, ensure the user has the option to save it as an alternative file.
        // Use a file stream and BinaryWriter to create this file.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            int arrayRows = 12;
            int arrayColumns = 4;

            SaveFileDialog saveFile = new SaveFileDialog(); // Opens windows directory
            saveFile.Filter = "dat files (*.dat)|*.dat";
            saveFile.Title = "Save File";
            saveFile.FileName = "definitions.dat"; // binary file definitons.dat

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFile.FileName;

                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        int rows = data.dataSet.GetLength(0);
                        int columns = data.dataSet.GetLength(1);

                        bw.Write(rows);
                        bw.Write(columns);

                        for (int i = 0; i < arrayRows; i++)
                        {
                            for (int j = 0; j < arrayColumns; j++)
                            {
                                bw.Write(data.dataSet[i, j]);
                            }
                        }
                    }
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
            int arrayRows = 12;
            int arrayColumns = 4;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "dat files (*.dat)|*.dat";
            openFile.Title = "Open File";

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                // Clears all currently filled fields 
                nameListbox.Items.Clear();
                categoryListbox.Items.Clear();

                searchTextbox.Clear();

                nameTextbox.Clear();
                categoryTextbox.Clear();
                structureTextbox.Clear();
                definitionTextbox.Clear();

                string filePath = openFile.FileName;

                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    using (BinaryReader br = new BinaryReader(fs))
                    {

                        for (int i = 0; i < arrayRows; i++)
                        {
                            for (int j = 0; j < arrayColumns; j++)
                            {
                                data.dataSet[i, j] = br.ReadString();
                            }
                            if (data.dataSet[i, 0] == "~") // skips our default string value
                            {
                                continue;
                            }
                            else
                            {
                                //9.8 Create a display method that will show the following information in a listview, Name and category
                                nameListbox.Items.Add(data.dataSet[i, 0]);
                                categoryListbox.Items.Add(data.dataSet[i, 1]);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has occured: {ex.Message}", "Error", MessageBoxButtons.OK); // displays error if opening file fails
                }

            }
        }
        // 9.7 Write code for a Binary search for the Name in the 2D array and display the information in the other textboxes when found
        // Add suitable feedback if the search failed, and clear the search textbox (Do not use built in array methods)
        private void search_Click(object sender, EventArgs e)
        {

        }
        // 9.6 Write code for a Bubble sort method to sort the 2D array by name ascending order
        // ensure to use a seperate swap method that passes the array element to be swapped
        // Do not use any built-in array methods.
    }
}