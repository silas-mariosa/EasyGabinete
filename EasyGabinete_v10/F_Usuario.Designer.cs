namespace EasyGabinete_v10
{
    partial class F_Usuario
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
            this.tb_nomeResponsavel = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_nomeResponsavel
            // 
            this.tb_nomeResponsavel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nomeResponsavel.Location = new System.Drawing.Point(289, 277);
            this.tb_nomeResponsavel.Name = "tb_nomeResponsavel";
            this.tb_nomeResponsavel.PlaceholderText = "Login";
            this.tb_nomeResponsavel.Size = new System.Drawing.Size(196, 35);
            this.tb_nomeResponsavel.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(289, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.PlaceholderText = "Senha";
            this.textBox1.Size = new System.Drawing.Size(196, 35);
            this.textBox1.TabIndex = 34;
            // 
            // F_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_nomeResponsavel);
            this.Name = "F_Usuario";
            this.Text = "F_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_nomeResponsavel;
        private TextBox textBox1;
    }
}