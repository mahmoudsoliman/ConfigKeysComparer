namespace ConfigKeyComparer
{
    partial class Form1
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
            this.oldConfigTextBox = new System.Windows.Forms.TextBox();
            this.oldConfigDialogBtn = new System.Windows.Forms.Button();
            this.newConfigDialogBtn = new System.Windows.Forms.Button();
            this.newCongigTextBox = new System.Windows.Forms.TextBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // oldConfigTextBox
            // 
            this.oldConfigTextBox.Location = new System.Drawing.Point(195, 23);
            this.oldConfigTextBox.Multiline = true;
            this.oldConfigTextBox.Name = "oldConfigTextBox";
            this.oldConfigTextBox.Size = new System.Drawing.Size(353, 20);
            this.oldConfigTextBox.TabIndex = 0;
            // 
            // oldConfigDialogBtn
            // 
            this.oldConfigDialogBtn.Location = new System.Drawing.Point(570, 23);
            this.oldConfigDialogBtn.Name = "oldConfigDialogBtn";
            this.oldConfigDialogBtn.Size = new System.Drawing.Size(93, 23);
            this.oldConfigDialogBtn.TabIndex = 1;
            this.oldConfigDialogBtn.Text = "Old Config File";
            this.oldConfigDialogBtn.UseVisualStyleBackColor = true;
            this.oldConfigDialogBtn.Click += new System.EventHandler(this.oldConfigDialogBtn_Click);
            // 
            // newConfigDialogBtn
            // 
            this.newConfigDialogBtn.Location = new System.Drawing.Point(570, 59);
            this.newConfigDialogBtn.Name = "newConfigDialogBtn";
            this.newConfigDialogBtn.Size = new System.Drawing.Size(93, 23);
            this.newConfigDialogBtn.TabIndex = 3;
            this.newConfigDialogBtn.Text = "New Config File";
            this.newConfigDialogBtn.UseVisualStyleBackColor = true;
            this.newConfigDialogBtn.Click += new System.EventHandler(this.newConfigDialogBtn_Click);
            // 
            // newCongigTextBox
            // 
            this.newCongigTextBox.Location = new System.Drawing.Point(195, 59);
            this.newCongigTextBox.Multiline = true;
            this.newCongigTextBox.Name = "newCongigTextBox";
            this.newCongigTextBox.Size = new System.Drawing.Size(353, 20);
            this.newCongigTextBox.TabIndex = 2;
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(369, 104);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(93, 35);
            this.compareBtn.TabIndex = 4;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.OldValue,
            this.NewValue,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 251);
            this.dataGridView1.TabIndex = 5;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.Width = 150;
            // 
            // OldValue
            // 
            this.OldValue.HeaderText = "Old Value";
            this.OldValue.Name = "OldValue";
            this.OldValue.Width = 350;
            // 
            // NewValue
            // 
            this.NewValue.HeaderText = "New Value";
            this.NewValue.Name = "NewValue";
            this.NewValue.Width = 350;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.newConfigDialogBtn);
            this.Controls.Add(this.newCongigTextBox);
            this.Controls.Add(this.oldConfigDialogBtn);
            this.Controls.Add(this.oldConfigTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldConfigTextBox;
        private System.Windows.Forms.Button oldConfigDialogBtn;
        private System.Windows.Forms.Button newConfigDialogBtn;
        private System.Windows.Forms.TextBox newCongigTextBox;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

