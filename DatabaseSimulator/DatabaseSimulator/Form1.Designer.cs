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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnPerformSql = new System.Windows.Forms.Button();
            this.btnPerformNoSql = new System.Windows.Forms.Button();
            this.UserPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserPanel.Controls.Add(this.label2);
            this.UserPanel.Controls.Add(this.comboBox1);
            this.UserPanel.Controls.Add(this.flowLayoutPanel1);
            this.UserPanel.Controls.Add(this.label1);
            this.UserPanel.Controls.Add(this.cmbQuantity);
            this.UserPanel.Controls.Add(this.btnPerformSql);
            this.UserPanel.Controls.Add(this.btnPerformNoSql);
            this.UserPanel.Location = new System.Drawing.Point(3, 1);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(615, 458);
            this.UserPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Command";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select",
            "Insert",
            "GetAll",
            "GetById"});
            this.comboBox1.Location = new System.Drawing.Point(101, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtOutput);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 319);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(611, 135);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(608, 132);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.Location = new System.Drawing.Point(101, 89);
            this.cmbQuantity.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(180, 22);
            this.cmbQuantity.TabIndex = 2;
            // 
            // btnPerformSql
            // 
            this.btnPerformSql.Location = new System.Drawing.Point(173, 26);
            this.btnPerformSql.Name = "btnPerformSql";
            this.btnPerformSql.Size = new System.Drawing.Size(133, 39);
            this.btnPerformSql.TabIndex = 1;
            this.btnPerformSql.Text = "Perform SQL";
            this.btnPerformSql.UseVisualStyleBackColor = true;
            this.btnPerformSql.Click += new System.EventHandler(this.btnPerformSql_Click);
            // 
            // btnPerformNoSql
            // 
            this.btnPerformNoSql.Location = new System.Drawing.Point(22, 26);
            this.btnPerformNoSql.Name = "btnPerformNoSql";
            this.btnPerformNoSql.Size = new System.Drawing.Size(133, 39);
            this.btnPerformNoSql.TabIndex = 0;
            this.btnPerformNoSql.Text = "Perform NoSQL";
            this.btnPerformNoSql.UseVisualStyleBackColor = true;
            this.btnPerformNoSql.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 458);
            this.Controls.Add(this.UserPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button btnPerformNoSql;
        private System.Windows.Forms.Button btnPerformSql;
        private System.Windows.Forms.NumericUpDown cmbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

