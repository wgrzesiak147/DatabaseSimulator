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
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.btnPerform = new System.Windows.Forms.Button();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Location = new System.Drawing.Point(0, 358);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(620, 100);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // UserPanel
            // 
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserPanel.Controls.Add(this.btnPerform);
            this.UserPanel.Location = new System.Drawing.Point(3, 1);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(615, 351);
            this.UserPanel.TabIndex = 3;
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(32, 44);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(110, 39);
            this.btnPerform.TabIndex = 0;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 458);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.UserPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

