namespace OverwatchTracker
{
    partial class Form_EditData
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
            this.label_SR = new System.Windows.Forms.Label();
            this.textBox_SR = new System.Windows.Forms.TextBox();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.textBox_WL = new System.Windows.Forms.TextBox();
            this.label_WL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_SR
            // 
            this.label_SR.AutoSize = true;
            this.label_SR.Location = new System.Drawing.Point(12, 7);
            this.label_SR.Name = "label_SR";
            this.label_SR.Size = new System.Drawing.Size(60, 13);
            this.label_SR.TabIndex = 0;
            this.label_SR.Text = "Skill Rating";
            // 
            // textBox_SR
            // 
            this.textBox_SR.Location = new System.Drawing.Point(15, 23);
            this.textBox_SR.Name = "textBox_SR";
            this.textBox_SR.Size = new System.Drawing.Size(57, 20);
            this.textBox_SR.TabIndex = 1;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(119, 7);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(116, 64);
            this.button_Confirm.TabIndex = 2;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // textBox_WL
            // 
            this.textBox_WL.Location = new System.Drawing.Point(15, 60);
            this.textBox_WL.Name = "textBox_WL";
            this.textBox_WL.Size = new System.Drawing.Size(57, 20);
            this.textBox_WL.TabIndex = 4;
            // 
            // label_WL
            // 
            this.label_WL.AutoSize = true;
            this.label_WL.Location = new System.Drawing.Point(12, 46);
            this.label_WL.Name = "label_WL";
            this.label_WL.Size = new System.Drawing.Size(53, 13);
            this.label_WL.TabIndex = 3;
            this.label_WL.Text = "Win/Loss";
            // 
            // Form_EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 83);
            this.Controls.Add(this.textBox_WL);
            this.Controls.Add(this.label_WL);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.textBox_SR);
            this.Controls.Add(this.label_SR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_EditData";
            this.Text = "EditData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SR;
        private System.Windows.Forms.TextBox textBox_SR;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.TextBox textBox_WL;
        private System.Windows.Forms.Label label_WL;
    }
}