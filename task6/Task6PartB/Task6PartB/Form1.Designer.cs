namespace Task6PartB
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            TBCode = new TextBox();
            textBox1 = new TextBox();
            TBDescription = new TextBox();
            TBPrice = new TextBox();
            TBFilter = new TextBox();
            btnDelete = new Button();
            btnInsert = new Button();
            btnCancelFilter = new Button();
            btnFilter = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(470, 229);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(TBCode);
            groupBox1.Location = new Point(24, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 179);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delete Item";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnInsert);
            groupBox2.Controls.Add(TBPrice);
            groupBox2.Controls.Add(TBDescription);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(210, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 179);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insert Item";
            // 
            // TBCode
            // 
            TBCode.Location = new Point(27, 58);
            TBCode.Name = "TBCode";
            TBCode.Size = new Size(125, 30);
            TBCode.TabIndex = 0;
            TBCode.Text = "Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 1;
            textBox1.Text = "Code";
            // 
            // TBDescription
            // 
            TBDescription.Location = new Point(153, 29);
            TBDescription.Name = "TBDescription";
            TBDescription.Size = new Size(125, 30);
            TBDescription.TabIndex = 2;
            TBDescription.Text = "Description";
            // 
            // TBPrice
            // 
            TBPrice.Location = new Point(79, 65);
            TBPrice.Name = "TBPrice";
            TBPrice.Size = new Size(125, 30);
            TBPrice.TabIndex = 3;
            TBPrice.Text = "Price";
            // 
            // TBFilter
            // 
            TBFilter.Location = new Point(516, 12);
            TBFilter.Name = "TBFilter";
            TBFilter.Size = new Size(272, 30);
            TBFilter.TabIndex = 4;
            TBFilter.Text = "Above the price for filtering";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(6, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ButtonFace;
            btnInsert.Location = new Point(51, 126);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(168, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnCancelFilter
            // 
            btnCancelFilter.BackColor = SystemColors.ButtonFace;
            btnCancelFilter.Location = new Point(516, 79);
            btnCancelFilter.Name = "btnCancelFilter";
            btnCancelFilter.Size = new Size(117, 91);
            btnCancelFilter.TabIndex = 4;
            btnCancelFilter.Text = "Cancel Filter";
            btnCancelFilter.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = SystemColors.ButtonFace;
            btnFilter.Location = new Point(671, 79);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(117, 91);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(578, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 91);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Database";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnFilter);
            Controls.Add(btnCancelFilter);
            Controls.Add(TBFilter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TBCode;
        private TextBox textBox1;
        private Button btnDelete;
        private TextBox TBPrice;
        private TextBox TBDescription;
        private TextBox TBFilter;
        private Button btnInsert;
        private Button btnCancelFilter;
        private Button btnFilter;
        private Button btnUpdate;
    }
}
