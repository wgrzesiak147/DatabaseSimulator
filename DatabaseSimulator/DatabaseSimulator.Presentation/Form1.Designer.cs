namespace DatabaseSimulator
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
            this.UserPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEntity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnPerformNoSql = new System.Windows.Forms.Button();
            this.cmbId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.UserPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbId)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserPanel.Controls.Add(this.label5);
            this.UserPanel.Controls.Add(this.cmbId);
            this.UserPanel.Controls.Add(this.label4);
            this.UserPanel.Controls.Add(this.cmbDatabase);
            this.UserPanel.Controls.Add(this.label3);
            this.UserPanel.Controls.Add(this.cmbEntity);
            this.UserPanel.Controls.Add(this.label2);
            this.UserPanel.Controls.Add(this.cmbCommand);
            this.UserPanel.Controls.Add(this.flowLayoutPanel1);
            this.UserPanel.Controls.Add(this.label1);
            this.UserPanel.Controls.Add(this.cmbQuantity);
            this.UserPanel.Controls.Add(this.btnPerformNoSql);
            this.UserPanel.Location = new System.Drawing.Point(3, 1);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(831, 550);
            this.UserPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Items.AddRange(new object[] {
            "MSSQL 2012",
            "MongoDB"});
            this.cmbDatabase.Location = new System.Drawing.Point(185, 41);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(180, 24);
            this.cmbDatabase.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Entity";
            // 
            // cmbEntity
            // 
            this.cmbEntity.FormattingEnabled = true;
            this.cmbEntity.Items.AddRange(new object[] {
            "Product",
            "Blog"});
            this.cmbEntity.Location = new System.Drawing.Point(185, 158);
            this.cmbEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEntity.Name = "cmbEntity";
            this.cmbEntity.Size = new System.Drawing.Size(180, 24);
            this.cmbEntity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Command";
            // 
            // cmbCommand
            // 
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "Insert",
            "GetByID",
            "GetAll",
            "Clean"});
            this.cmbCommand.Location = new System.Drawing.Point(185, 99);
            this.cmbCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(180, 24);
            this.cmbCommand.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtOutput);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 411);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 135);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(3, 2);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(820, 132);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.Location = new System.Drawing.Point(185, 233);
            this.cmbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbQuantity.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(180, 22);
            this.cmbQuantity.TabIndex = 2;
            // 
            // btnPerformNoSql
            // 
            this.btnPerformNoSql.Location = new System.Drawing.Point(308, 342);
            this.btnPerformNoSql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPerformNoSql.Name = "btnPerformNoSql";
            this.btnPerformNoSql.Size = new System.Drawing.Size(133, 39);
            this.btnPerformNoSql.TabIndex = 0;
            this.btnPerformNoSql.Text = "Perform Test";
            this.btnPerformNoSql.UseVisualStyleBackColor = true;
            this.btnPerformNoSql.Click += new System.EventHandler(this.btnPerformNoSql_Click);
            // 
            // cmbId
            // 
            this.cmbId.Location = new System.Drawing.Point(185, 275);
            this.cmbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbId.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(180, 22);
            this.cmbId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 548);
            this.Controls.Add(this.UserPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Database Simulator";
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button btnPerformNoSql;
        private System.Windows.Forms.NumericUpDown cmbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEntity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cmbId;
    }
}

