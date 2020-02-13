namespace Jogo_da_velha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.mensagem = new System.Windows.Forms.Label();
            this.vez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(70, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 83);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogo da Velha";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(156, 41);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 83);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(242, 41);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 83);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(242, 130);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 83);
            this.btn6.TabIndex = 0;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(156, 130);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 83);
            this.btn5.TabIndex = 0;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(70, 219);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 83);
            this.btn7.TabIndex = 0;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(70, 130);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 83);
            this.btn4.TabIndex = 0;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(156, 219);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 83);
            this.btn8.TabIndex = 0;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(242, 219);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 83);
            this.btn9.TabIndex = 0;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // mensagem
            // 
            this.mensagem.AutoSize = true;
            this.mensagem.Location = new System.Drawing.Point(115, 373);
            this.mensagem.Name = "mensagem";
            this.mensagem.Size = new System.Drawing.Size(0, 13);
            this.mensagem.TabIndex = 2;
            // 
            // vez
            // 
            this.vez.AutoSize = true;
            this.vez.Location = new System.Drawing.Point(118, 329);
            this.vez.Name = "vez";
            this.vez.Size = new System.Drawing.Size(0, 13);
            this.vez.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 424);
            this.Controls.Add(this.vez);
            this.Controls.Add(this.mensagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "jogo da velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label mensagem;
        private System.Windows.Forms.Label vez;
    }
}

