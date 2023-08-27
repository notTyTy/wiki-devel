using System.Xml;
using System.Globalization;

namespace Wiki_devel
{
    public partial class Form1 : Form
    {
        Data data = new Data();



        public Form1()
        {
            InitializeComponent();
        }

        int arraySize = 12;

        private void add_Click(object sender, EventArgs e) //9.2 Create an add button that will store the information from the 4 text boxes into the 2D array
        {
            for (int i = 0; i < arraySize; i++)
            {
                if (data.dataSet[i, 0] == default(string))
                    if (nameTextbox.Text != "" | structureTextbox.Text != "" | categoryTextbox.Text != "" | definitionTextbox.Text != "")
                    {
                        data.dataSet[i, 0] = nameTextbox.Text.ToLower(); // Adds name data to the array
                        nameListbox.Items.Add(data.dataSet[i, 0]); // Adds textbox data to the listbox


                        data.dataSet[i, 1] = categoryTextbox.Text; // Adds category data to the array
                        categoryListbox.Items.Add(data.dataSet[i, 1].ToUpper()); // adds textbox data to the listbox

                        data.dataSet[i, 2] = structureTextbox.Text; // Adds structure data to the array
                        data.dataSet[i, 3] = definitionTextbox.Text; // Adds definition data to the array


                        // Resets the Textbox fields so new data can be added
                        nameTextbox.ResetText();
                        categoryTextbox.ResetText();
                        structureTextbox.ResetText();
                        definitionTextbox.ResetText();
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Please fill out all fields before adding to the Dictionary");
                        break;
                    }
            }

        }
        // 9.3 Create an Edit button that will allow the user to modify any information from the four text boxes into the 2D array



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

                        // Makes the textboxes ReadOnly so that the edit button needs to be invoked

                    }
                }
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (nameListbox.SelectedIndex > -1)
            {
                int selectedIndex = nameListbox.SelectedIndex;
                categoryListbox.Items.RemoveAt(nameListbox.SelectedIndex);
                nameListbox.Items.RemoveAt(nameListbox.SelectedIndex);

                nameTextbox.Text = default;
                categoryTextbox.Text = default;
                structureTextbox.Text = default;
                definitionTextbox.Text = default;

                data.dataSet[selectedIndex, 0] = default;
                data.dataSet[selectedIndex, 1] = default;
                data.dataSet[selectedIndex, 2] = default;
                data.dataSet[selectedIndex, 3] = default;

                nameTextbox.ReadOnly = false;
                categoryTextbox.ReadOnly = false;
                structureTextbox.ReadOnly = false;
                definitionTextbox.ReadOnly = false;
            }

        }

        private void searchTextbox_DoubleClick(object sender, EventArgs e)

        {
            // Clears the current fields by double clicking "searchTextbox"
            nameTextbox.Text = default;
            categoryTextbox.Text = default;
            structureTextbox.Text = default;
            definitionTextbox.Text = default;

            // Re-enables the ability to add new parameters. 
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            int nameIndex = nameListbox.SelectedIndex;

            data.dataSet[nameIndex, 0] = nameTextbox.Text;
            data.dataSet[nameIndex, 1] = categoryTextbox.Text;
            data.dataSet[nameIndex, 2] = structureTextbox.Text;
            data.dataSet[nameIndex, 3] = definitionTextbox.Text;

            nameListbox.Items[nameIndex] = nameTextbox.Text.ToLower();
            categoryListbox.Items[nameIndex] = categoryTextbox.Text.ToLower();

            nameTextbox.Text = default;
            categoryTextbox.Text = default;
            structureTextbox.Text = default;
            definitionTextbox.Text = default;

        }
    }
}


