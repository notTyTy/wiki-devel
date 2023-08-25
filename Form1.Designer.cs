namespace Wiki_devel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            delete = new Button();
            edit = new Button();
            add = new Button();
            searchTextBox = new TextBox();
            search = new Button();
            saveFileDialog1 = new SaveFileDialog();
            Name = new ListBox();
            Category = new ListBox();
            nameAdd = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            save = new Button();
            open = new Button();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 317);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(552, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // delete
            // 
            delete.Location = new Point(443, 24);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Location = new Point(362, 24);
            edit.Name = "edit";
            edit.Size = new Size(75, 23);
            edit.TabIndex = 3;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(281, 24);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 4;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(31, 24);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(144, 23);
            searchTextBox.TabIndex = 9;
            // 
            // search
            // 
            search.Location = new Point(181, 24);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 10;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            Name.FormattingEnabled = true;
            Name.ItemHeight = 15;
            Name.Location = new Point(31, 53);
            Name.Name = "Name";
            Name.Size = new Size(108, 259);
            Name.TabIndex = 14;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.ItemHeight = 15;
            Category.Location = new Point(138, 53);
            Category.Name = "Category";
            Category.Size = new Size(108, 259);
            Category.TabIndex = 15;
            // 
            // nameAdd
            // 
            nameAdd.Location = new Point(353, 53);
            nameAdd.Name = "nameAdd";
            nameAdd.Size = new Size(165, 23);
            nameAdd.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(353, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 18;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(281, 161);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(237, 122);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 56);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 20;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 86);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 21;
            label2.Text = "Structure";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 113);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 22;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 140);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 23;
            label4.Text = "Definition";
            label4.Click += label4_Click;
            // 
            // save
            // 
            save.Location = new Point(443, 291);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 24;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            open.Location = new Point(362, 291);
            open.Name = "open";
            open.Size = new Size(75, 23);
            open.TabIndex = 25;
            open.Text = "Open";
            open.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 339);
            Controls.Add(open);
            Controls.Add(save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(nameAdd);
            Controls.Add(Category);
            Controls.Add(Name);
            Controls.Add(search);
            Controls.Add(searchTextBox);
            Controls.Add(add);
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(statusStrip1);
            Text = "Category Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Button edit;
        private Button delete;
        private Button edot;
        private Button add;
        private ListBox listBox2;
        private TextBox searchTextBox;
        private Button search;
        private SaveFileDialog saveFileDialog1;
        private ListBox Name;
        private ListBox Category;
        private TextBox nameAdd;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button save;
        private Button open;
    }
}