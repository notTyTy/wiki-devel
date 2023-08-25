namespace Wiki_devel
{
    public partial class Form1 : Form
    {
        Data data = new Data();


        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        int arrayPosition = 0;
        private void add_Click(object sender, EventArgs e) //9.2 Create an add button that will store the information from the 4 text boxes into the 2D array

        {
            if (arrayPosition < 12)
            {
                if (data.dataSet[arrayPosition, 0] == "" || data.dataSet[arrayPosition, 1] == "" || data.dataSet[arrayPosition, 2] == "" || data.dataSet[arrayPosition, 3] == "")
                {
                    arrayPosition++;
                }
                else
                {
                    if(nameTextbox.Text == "" | structureTextbox.Text == "" | categoryTextbox.Text == "" | definitionTextbox.Text == "")
                    {
                        MessageBox.Show("Please fill out all fields before adding to the Dictionary");
                    }
                    else
                    {
                        data.dataSet[arrayPosition, 0] = nameTextbox.Text.ToLower(); // Adds name data to the array
                        nameListbox.Items.Add(data.dataSet[arrayPosition, 0]); // Adds textbox data to the listbox

                        data.dataSet[arrayPosition, 1] = categoryTextbox.Text; // Adds category data to the array
                        categoryListbox.Items.Add(data.dataSet[arrayPosition, 1].ToUpper()); // adds textbox data to the listbox

                        data.dataSet[arrayPosition, 2] = structureTextbox.Text; // Adds structure data to the array
                        data.dataSet[arrayPosition, 3] = definitionTextbox.Text; // Adds definition data to the array


                        arrayPosition++;
                    }

                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchTextbox != null)
            {
                // searchTextbox 
            }
        }
    }
}
