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
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            searchTextbox = new TextBox();
            search = new Button();
            saveFileDialog1 = new SaveFileDialog();
            categoryListbox = new ListBox();
            nameTextbox = new TextBox();
            structureTextbox = new TextBox();
            categoryTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            saveBtn = new Button();
            openBtn = new Button();
            nameListbox = new ListBox();
            definitionTextbox = new TextBox();
            saveFileDialog2 = new SaveFileDialog();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 317);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(552, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(443, 24);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(362, 24);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.AccessibleName = "Add";
            addBtn.Location = new Point(281, 24);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += add_Click;
            // 
            // searchTextbox
            // 
            searchTextbox.Location = new Point(31, 24);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(144, 23);
            searchTextbox.TabIndex = 9;
            searchTextbox.DoubleClick += searchTextbox_DoubleClick;
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
            // categoryListbox
            // 
            categoryListbox.FormattingEnabled = true;
            categoryListbox.ItemHeight = 15;
            categoryListbox.Location = new Point(138, 68);
            categoryListbox.Name = "categoryListbox";
            categoryListbox.Size = new Size(108, 244);
            categoryListbox.TabIndex = 15;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(353, 53);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(165, 23);
            nameTextbox.TabIndex = 16;
            // 
            // structureTextbox
            // 
            structureTextbox.Location = new Point(353, 82);
            structureTextbox.Name = "structureTextbox";
            structureTextbox.Size = new Size(165, 23);
            structureTextbox.TabIndex = 17;
            // 
            // categoryTextbox
            // 
            categoryTextbox.Location = new Point(353, 111);
            categoryTextbox.Name = "categoryTextbox";
            categoryTextbox.Size = new Size(165, 23);
            categoryTextbox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 56);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 20;
            label1.Text = "Name";
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
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(443, 291);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 24;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(362, 291);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(75, 23);
            openBtn.TabIndex = 25;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = true;
            // 
            // nameListbox
            // 
            nameListbox.FormattingEnabled = true;
            nameListbox.ItemHeight = 15;
            nameListbox.Location = new Point(31, 68);
            nameListbox.Name = "nameListbox";
            nameListbox.Size = new Size(108, 244);
            nameListbox.TabIndex = 27;
            nameListbox.SelectedIndexChanged += nameListbox_SelectedIndexChanged;
            // 
            // definitionTextbox
            // 
            definitionTextbox.Location = new Point(281, 158);
            definitionTextbox.Multiline = true;
            definitionTextbox.Name = "definitionTextbox";
            definitionTextbox.Size = new Size(237, 122);
            definitionTextbox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 50);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 28;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 50);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 29;
            label6.Text = "Category";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 339);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(nameListbox);
            Controls.Add(definitionTextbox);
            Controls.Add(openBtn);
            Controls.Add(saveBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categoryTextbox);
            Controls.Add(structureTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(categoryListbox);
            Controls.Add(search);
            Controls.Add(searchTextbox);
            Controls.Add(addBtn);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Wiki Devel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Button editBtn;
        private Button deleteBtn;
        public Button addBtn;
        private TextBox searchTextbox;
        private Button search;
        private SaveFileDialog saveFileDialog1;
        private ListBox categoryListbox;
        private TextBox nameTextbox;
        private TextBox structureTextbox;
        private TextBox categoryTextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button saveBtn;
        private Button openBtn;
        private ListBox nameListbox;
        private TextBox definitionTextbox;
        private SaveFileDialog saveFileDialog2;
        private Label label5;
        private Label label6;
    }
}