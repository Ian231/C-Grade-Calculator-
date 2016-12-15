namespace GradeCalculator
{
    partial class selectEditModule
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
            this.selectTitle = new System.Windows.Forms.Label();
            this.modulePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // selectTitle
            // 
            this.selectTitle.AutoSize = true;
            this.selectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTitle.Location = new System.Drawing.Point(293, 20);
            this.selectTitle.Name = "selectTitle";
            this.selectTitle.Size = new System.Drawing.Size(281, 32);
            this.selectTitle.TabIndex = 1;
            this.selectTitle.Text = "Select module to edit";
            // 
            // modulePanel
            // 
            this.modulePanel.BackColor = System.Drawing.SystemColors.Control;
            this.modulePanel.Location = new System.Drawing.Point(40, 87);
            this.modulePanel.Name = "modulePanel";
            this.modulePanel.Size = new System.Drawing.Size(881, 699);
            this.modulePanel.TabIndex = 2;
            // 
            // selectEditModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(964, 814);
            this.Controls.Add(this.modulePanel);
            this.Controls.Add(this.selectTitle);
            this.Name = "selectEditModule";
            this.Text = "selectEditModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectTitle;
        private System.Windows.Forms.Panel modulePanel;
    }
}