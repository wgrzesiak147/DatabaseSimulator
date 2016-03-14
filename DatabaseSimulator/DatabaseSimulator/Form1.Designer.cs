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
            this.Output = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Controls.Add(this.txtOutput);
            this.Output.Location = new System.Drawing.Point(0, 360);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(619, 100);
            this.Output.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(619, 100);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 458);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Output.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Output;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

