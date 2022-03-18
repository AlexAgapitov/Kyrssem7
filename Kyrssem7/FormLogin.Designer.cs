namespace Kyrssem7
{
    partial class FormLogin
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
            this.buttonDecan = new System.Windows.Forms.Button();
            this.buttonZamDecana = new System.Windows.Forms.Button();
            this.buttonUserDecanata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDecan
            // 
            this.buttonDecan.Location = new System.Drawing.Point(12, 25);
            this.buttonDecan.Name = "buttonDecan";
            this.buttonDecan.Size = new System.Drawing.Size(139, 23);
            this.buttonDecan.TabIndex = 0;
            this.buttonDecan.Text = "Декан";
            this.buttonDecan.UseVisualStyleBackColor = true;
            this.buttonDecan.Click += new System.EventHandler(this.buttonDecan_Click);
            // 
            // buttonZamDecana
            // 
            this.buttonZamDecana.Location = new System.Drawing.Point(12, 54);
            this.buttonZamDecana.Name = "buttonZamDecana";
            this.buttonZamDecana.Size = new System.Drawing.Size(139, 23);
            this.buttonZamDecana.TabIndex = 1;
            this.buttonZamDecana.Text = "Заместитель декана";
            this.buttonZamDecana.UseVisualStyleBackColor = true;
            this.buttonZamDecana.Click += new System.EventHandler(this.buttonZamDecana_Click);
            // 
            // buttonUserDecanata
            // 
            this.buttonUserDecanata.Location = new System.Drawing.Point(12, 83);
            this.buttonUserDecanata.Name = "buttonUserDecanata";
            this.buttonUserDecanata.Size = new System.Drawing.Size(139, 23);
            this.buttonUserDecanata.TabIndex = 2;
            this.buttonUserDecanata.Text = "Работник деканата";
            this.buttonUserDecanata.UseVisualStyleBackColor = true;
            this.buttonUserDecanata.Click += new System.EventHandler(this.buttonUserDecanata_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Войти как";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUserDecanata);
            this.Controls.Add(this.buttonZamDecana);
            this.Controls.Add(this.buttonDecan);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecan;
        private System.Windows.Forms.Button buttonZamDecana;
        private System.Windows.Forms.Button buttonUserDecanata;
        private System.Windows.Forms.Label label1;
    }
}