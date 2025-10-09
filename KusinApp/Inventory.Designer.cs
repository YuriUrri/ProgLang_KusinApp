namespace KusinApp
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            inventorySearch = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            Search = new Label();
            Name = new Label();
            label3 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(320, 353);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(227, 555);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 7;
            button3.Text = "Search Recipes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(17, 555);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 6;
            button2.Text = "Personal Recipes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(146, 555);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inventorySearch
            // 
            inventorySearch.Location = new Point(64, 10);
            inventorySearch.Margin = new Padding(2, 1, 2, 1);
            inventorySearch.Name = "inventorySearch";
            inventorySearch.Size = new Size(146, 23);
            inventorySearch.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 426);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 426);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 447);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(17, 18);
            Search.Name = "Search";
            Search.Size = new Size(42, 15);
            Search.TabIndex = 12;
            Search.Text = "Search";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(17, 410);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 13;
            Name.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 410);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 14;
            label3.Text = "Quantity";
            // 
            // button4
            // 
            button4.Location = new Point(126, 487);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 590);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(Name);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(inventorySearch);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            //Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox inventorySearch;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label Search;
        private Label Name;
        private Label label3;
        private Button button4;
    }
}