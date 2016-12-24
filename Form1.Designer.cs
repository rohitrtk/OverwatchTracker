namespace OverwatchTracker
{
    partial class Form_MainForm
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
            this.textBox_SaveDir = new System.Windows.Forms.TextBox();
            this.label_SaveDir = new System.Windows.Forms.Label();
            this.label_ReadDir = new System.Windows.Forms.Label();
            this.textBox_ReadDir = new System.Windows.Forms.TextBox();
            this.button_AddData = new System.Windows.Forms.Button();
            this.listBox_Display = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_SaveDir
            // 
            this.textBox_SaveDir.Location = new System.Drawing.Point(95, 38);
            this.textBox_SaveDir.Name = "textBox_SaveDir";
            this.textBox_SaveDir.Size = new System.Drawing.Size(170, 20);
            this.textBox_SaveDir.TabIndex = 0;
            // 
            // label_SaveDir
            // 
            this.label_SaveDir.AutoSize = true;
            this.label_SaveDir.Location = new System.Drawing.Point(12, 41);
            this.label_SaveDir.Name = "label_SaveDir";
            this.label_SaveDir.Size = new System.Drawing.Size(77, 13);
            this.label_SaveDir.TabIndex = 1;
            this.label_SaveDir.Text = "Save Directory";
            // 
            // label_ReadDir
            // 
            this.label_ReadDir.AutoSize = true;
            this.label_ReadDir.Location = new System.Drawing.Point(12, 15);
            this.label_ReadDir.Name = "label_ReadDir";
            this.label_ReadDir.Size = new System.Drawing.Size(78, 13);
            this.label_ReadDir.TabIndex = 4;
            this.label_ReadDir.Text = "Read Directory";
            // 
            // textBox_ReadDir
            // 
            this.textBox_ReadDir.Location = new System.Drawing.Point(95, 12);
            this.textBox_ReadDir.Name = "textBox_ReadDir";
            this.textBox_ReadDir.Size = new System.Drawing.Size(170, 20);
            this.textBox_ReadDir.TabIndex = 3;
            // 
            // button_AddData
            // 
            this.button_AddData.Location = new System.Drawing.Point(95, 64);
            this.button_AddData.Name = "button_AddData";
            this.button_AddData.Size = new System.Drawing.Size(75, 23);
            this.button_AddData.TabIndex = 5;
            this.button_AddData.Text = "Add Data";
            this.button_AddData.UseVisualStyleBackColor = true;
            this.button_AddData.Click += new System.EventHandler(this.button_AddData_Click);
            // 
            // listBox_Display
            // 
            this.listBox_Display.FormattingEnabled = true;
            this.listBox_Display.Location = new System.Drawing.Point(271, 12);
            this.listBox_Display.Name = "listBox_Display";
            this.listBox_Display.Size = new System.Drawing.Size(335, 264);
            this.listBox_Display.TabIndex = 7;
            // 
            // Form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 291);
            this.Controls.Add(this.listBox_Display);
            this.Controls.Add(this.button_AddData);
            this.Controls.Add(this.label_ReadDir);
            this.Controls.Add(this.textBox_ReadDir);
            this.Controls.Add(this.label_SaveDir);
            this.Controls.Add(this.textBox_SaveDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_MainForm";
            this.Text = "Overwatch Skill Rating Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SaveDir;
        private System.Windows.Forms.Label label_SaveDir;
        private System.Windows.Forms.Label label_ReadDir;
        private System.Windows.Forms.TextBox textBox_ReadDir;
        private System.Windows.Forms.Button button_AddData;
        private System.Windows.Forms.ListBox listBox_Display;
    }
}

