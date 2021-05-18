
namespace Igra
{
    partial class OknoNastavitve
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
            this.gmBspremeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_levo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.gmBspremeni.Location = new System.Drawing.Point(513, 322);
            this.gmBspremeni.Name = "button1";
            this.gmBspremeni.Size = new System.Drawing.Size(188, 65);
            this.gmBspremeni.TabIndex = 0;
            this.gmBspremeni.Text = "Shrani nastavitve";
            this.gmBspremeni.UseVisualStyleBackColor = true;
            this.gmBspremeni.Click += new System.EventHandler(this.spremeni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "levo";
            // 
            // textBox1
            // 
            this.tB_levo.Location = new System.Drawing.Point(120, 65);
            this.tB_levo.Name = "textBox1";
            this.tB_levo.Size = new System.Drawing.Size(102, 26);
            this.tB_levo.TabIndex = 2;
            // 
            // OknoNastavitve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tB_levo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmBspremeni);
            this.Name = "OknoNastavitve";
            this.Text = "Nastavitve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gmBspremeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_levo;
    }
}