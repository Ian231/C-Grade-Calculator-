namespace GradeCalculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseTitle = new System.Windows.Forms.Label();
            this.addlevel6Module = new System.Windows.Forms.Button();
            this.addlevel5Module = new System.Windows.Forms.Button();
            this.addlevel4Module = new System.Windows.Forms.Button();
            this.Level6_label = new System.Windows.Forms.Label();
            this.Level5_label = new System.Windows.Forms.Label();
            this.Level4_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.level4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Level5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Level6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reCalculate = new System.Windows.Forms.Button();
            this.summaryL6 = new System.Windows.Forms.TextBox();
            this.summaryL5 = new System.Windows.Forms.TextBox();
            this.summaryL4 = new System.Windows.Forms.TextBox();
            this.predictedGrade = new System.Windows.Forms.Label();
            this.predictedTitle = new System.Windows.Forms.Label();
            this.best56 = new System.Windows.Forms.Label();
            this.best2Title = new System.Windows.Forms.Label();
            this.best6 = new System.Windows.Forms.Label();
            this.best1Title = new System.Windows.Forms.Label();
            this.lvl6Label = new System.Windows.Forms.Label();
            this.lvl5Label = new System.Windows.Forms.Label();
            this.lvl4Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 667);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Controls.Add(this.courseTitle);
            this.tabPage1.Controls.Add(this.addlevel6Module);
            this.tabPage1.Controls.Add(this.addlevel5Module);
            this.tabPage1.Controls.Add(this.addlevel4Module);
            this.tabPage1.Controls.Add(this.Level6_label);
            this.tabPage1.Controls.Add(this.Level5_label);
            this.tabPage1.Controls.Add(this.Level4_label);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1243, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Module";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1237, 35);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // courseTitle
            // 
            this.courseTitle.AutoSize = true;
            this.courseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitle.Location = new System.Drawing.Point(6, 67);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(102, 37);
            this.courseTitle.TabIndex = 7;
            this.courseTitle.Text = "label2";
            // 
            // addlevel6Module
            // 
            this.addlevel6Module.Location = new System.Drawing.Point(555, 456);
            this.addlevel6Module.Name = "addlevel6Module";
            this.addlevel6Module.Size = new System.Drawing.Size(130, 33);
            this.addlevel6Module.TabIndex = 6;
            this.addlevel6Module.Text = "Add";
            this.addlevel6Module.UseVisualStyleBackColor = true;
            this.addlevel6Module.Click += new System.EventHandler(this.addlevel6Module_Click);
            // 
            // addlevel5Module
            // 
            this.addlevel5Module.Location = new System.Drawing.Point(555, 392);
            this.addlevel5Module.Name = "addlevel5Module";
            this.addlevel5Module.Size = new System.Drawing.Size(130, 33);
            this.addlevel5Module.TabIndex = 5;
            this.addlevel5Module.Text = "Add";
            this.addlevel5Module.UseVisualStyleBackColor = true;
            this.addlevel5Module.Click += new System.EventHandler(this.addlevel5Module_Click);
            // 
            // addlevel4Module
            // 
            this.addlevel4Module.Location = new System.Drawing.Point(555, 330);
            this.addlevel4Module.Name = "addlevel4Module";
            this.addlevel4Module.Size = new System.Drawing.Size(130, 33);
            this.addlevel4Module.TabIndex = 4;
            this.addlevel4Module.Text = "Add";
            this.addlevel4Module.UseVisualStyleBackColor = true;
            this.addlevel4Module.Click += new System.EventHandler(this.addlevel4Module_Click);
            // 
            // Level6_label
            // 
            this.Level6_label.AutoSize = true;
            this.Level6_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level6_label.Location = new System.Drawing.Point(354, 460);
            this.Level6_label.Name = "Level6_label";
            this.Level6_label.Size = new System.Drawing.Size(90, 29);
            this.Level6_label.TabIndex = 3;
            this.Level6_label.Text = "Level 6";
            // 
            // Level5_label
            // 
            this.Level5_label.AutoSize = true;
            this.Level5_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level5_label.Location = new System.Drawing.Point(354, 396);
            this.Level5_label.Name = "Level5_label";
            this.Level5_label.Size = new System.Drawing.Size(90, 29);
            this.Level5_label.TabIndex = 2;
            this.Level5_label.Text = "Level 5";
            // 
            // Level4_label
            // 
            this.Level4_label.AutoSize = true;
            this.Level4_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level4_label.Location = new System.Drawing.Point(354, 330);
            this.Level4_label.Name = "Level4_label";
            this.Level4_label.Size = new System.Drawing.Size(90, 29);
            this.Level4_label.TabIndex = 1;
            this.Level4_label.Text = "Level 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Module Information";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.level4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1243, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Level 4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // level4
            // 
            this.level4.AutoSize = true;
            this.level4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level4.Location = new System.Drawing.Point(497, 33);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(170, 26);
            this.level4.TabIndex = 0;
            this.level4.Text = "Level 4 Modules";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Level5);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1243, 634);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Level 5";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Level5
            // 
            this.Level5.AutoSize = true;
            this.Level5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level5.Location = new System.Drawing.Point(496, 31);
            this.Level5.Name = "Level5";
            this.Level5.Size = new System.Drawing.Size(170, 26);
            this.Level5.TabIndex = 1;
            this.Level5.Text = "Level 5 Modules";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Level6);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1243, 634);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Level 6";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Level6
            // 
            this.Level6.AutoSize = true;
            this.Level6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level6.Location = new System.Drawing.Point(494, 33);
            this.Level6.Name = "Level6";
            this.Level6.Size = new System.Drawing.Size(170, 26);
            this.Level6.TabIndex = 1;
            this.Level6.Text = "Level 6 Modules";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reCalculate);
            this.tabPage5.Controls.Add(this.summaryL6);
            this.tabPage5.Controls.Add(this.summaryL5);
            this.tabPage5.Controls.Add(this.summaryL4);
            this.tabPage5.Controls.Add(this.predictedGrade);
            this.tabPage5.Controls.Add(this.predictedTitle);
            this.tabPage5.Controls.Add(this.best56);
            this.tabPage5.Controls.Add(this.best2Title);
            this.tabPage5.Controls.Add(this.best6);
            this.tabPage5.Controls.Add(this.best1Title);
            this.tabPage5.Controls.Add(this.lvl6Label);
            this.tabPage5.Controls.Add(this.lvl5Label);
            this.tabPage5.Controls.Add(this.lvl4Label);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.summaryLabel);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1243, 634);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Summary";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reCalculate
            // 
            this.reCalculate.Location = new System.Drawing.Point(776, 511);
            this.reCalculate.Name = "reCalculate";
            this.reCalculate.Size = new System.Drawing.Size(164, 43);
            this.reCalculate.TabIndex = 30;
            this.reCalculate.Text = "Re-Calculate";
            this.reCalculate.UseVisualStyleBackColor = true;
            this.reCalculate.Click += new System.EventHandler(this.reCalculate_Click);
            // 
            // summaryL6
            // 
            this.summaryL6.Location = new System.Drawing.Point(495, 361);
            this.summaryL6.Margin = new System.Windows.Forms.Padding(2);
            this.summaryL6.Name = "summaryL6";
            this.summaryL6.Size = new System.Drawing.Size(44, 26);
            this.summaryL6.TabIndex = 29;
            // 
            // summaryL5
            // 
            this.summaryL5.Location = new System.Drawing.Point(495, 289);
            this.summaryL5.Margin = new System.Windows.Forms.Padding(2);
            this.summaryL5.Name = "summaryL5";
            this.summaryL5.Size = new System.Drawing.Size(44, 26);
            this.summaryL5.TabIndex = 28;
            // 
            // summaryL4
            // 
            this.summaryL4.Location = new System.Drawing.Point(495, 215);
            this.summaryL4.Margin = new System.Windows.Forms.Padding(2);
            this.summaryL4.Name = "summaryL4";
            this.summaryL4.Size = new System.Drawing.Size(44, 26);
            this.summaryL4.TabIndex = 27;
            // 
            // predictedGrade
            // 
            this.predictedGrade.AutoSize = true;
            this.predictedGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedGrade.Location = new System.Drawing.Point(790, 386);
            this.predictedGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.predictedGrade.Name = "predictedGrade";
            this.predictedGrade.Size = new System.Drawing.Size(64, 25);
            this.predictedGrade.TabIndex = 26;
            this.predictedGrade.Text = "Mark";
            // 
            // predictedTitle
            // 
            this.predictedTitle.AutoSize = true;
            this.predictedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedTitle.Location = new System.Drawing.Point(790, 359);
            this.predictedTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.predictedTitle.Name = "predictedTitle";
            this.predictedTitle.Size = new System.Drawing.Size(103, 25);
            this.predictedTitle.TabIndex = 25;
            this.predictedTitle.Text = "Predicted";
            // 
            // best56
            // 
            this.best56.AutoSize = true;
            this.best56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best56.Location = new System.Drawing.Point(790, 313);
            this.best56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.best56.Name = "best56";
            this.best56.Size = new System.Drawing.Size(64, 25);
            this.best56.TabIndex = 24;
            this.best56.Text = "Mark";
            // 
            // best2Title
            // 
            this.best2Title.AutoSize = true;
            this.best2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best2Title.Location = new System.Drawing.Point(790, 286);
            this.best2Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.best2Title.Name = "best2Title";
            this.best2Title.Size = new System.Drawing.Size(324, 25);
            this.best2Title.TabIndex = 23;
            this.best2Title.Text = "Best 105 Credits at level 5 and 6";
            // 
            // best6
            // 
            this.best6.AutoSize = true;
            this.best6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best6.Location = new System.Drawing.Point(790, 241);
            this.best6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.best6.Name = "best6";
            this.best6.Size = new System.Drawing.Size(64, 25);
            this.best6.TabIndex = 22;
            this.best6.Text = "Mark";
            // 
            // best1Title
            // 
            this.best1Title.AutoSize = true;
            this.best1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best1Title.Location = new System.Drawing.Point(790, 214);
            this.best1Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.best1Title.Name = "best1Title";
            this.best1Title.Size = new System.Drawing.Size(264, 25);
            this.best1Title.TabIndex = 21;
            this.best1Title.Text = "Best 105 Credits at level 6";
            // 
            // lvl6Label
            // 
            this.lvl6Label.AutoSize = true;
            this.lvl6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl6Label.Location = new System.Drawing.Point(293, 361);
            this.lvl6Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl6Label.Name = "lvl6Label";
            this.lvl6Label.Size = new System.Drawing.Size(174, 25);
            this.lvl6Label.TabIndex = 20;
            this.lvl6Label.Text = "Average Level 6:";
            // 
            // lvl5Label
            // 
            this.lvl5Label.AutoSize = true;
            this.lvl5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl5Label.Location = new System.Drawing.Point(293, 288);
            this.lvl5Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl5Label.Name = "lvl5Label";
            this.lvl5Label.Size = new System.Drawing.Size(174, 25);
            this.lvl5Label.TabIndex = 19;
            this.lvl5Label.Text = "Average Level 5:";
            // 
            // lvl4Label
            // 
            this.lvl4Label.AutoSize = true;
            this.lvl4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl4Label.Location = new System.Drawing.Point(293, 216);
            this.lvl4Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl4Label.Name = "lvl4Label";
            this.lvl4Label.Size = new System.Drawing.Size(174, 25);
            this.lvl4Label.TabIndex = 18;
            this.lvl4Label.Text = "Average Level 4:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1018, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "You can also choose to predict your grades and see the outcome\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.Location = new System.Drawing.Point(352, 16);
            this.summaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(392, 38);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "Summary of your Grades ";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(30, 686);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(151, 49);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit Module";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 761);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addlevel6Module;
        private System.Windows.Forms.Button addlevel5Module;
        private System.Windows.Forms.Button addlevel4Module;
        private System.Windows.Forms.Label Level6_label;
        private System.Windows.Forms.Label Level5_label;
        private System.Windows.Forms.Label Level4_label;
        private System.Windows.Forms.Label courseTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label level4;
        private System.Windows.Forms.Label Level5;
        private System.Windows.Forms.Label Level6;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox summaryL6;
        private System.Windows.Forms.TextBox summaryL5;
        private System.Windows.Forms.TextBox summaryL4;
        private System.Windows.Forms.Label predictedGrade;
        private System.Windows.Forms.Label predictedTitle;
        private System.Windows.Forms.Label best56;
        private System.Windows.Forms.Label best2Title;
        private System.Windows.Forms.Label best6;
        private System.Windows.Forms.Label best1Title;
        private System.Windows.Forms.Label lvl6Label;
        private System.Windows.Forms.Label lvl5Label;
        private System.Windows.Forms.Label lvl4Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Button reCalculate;


    }
}

