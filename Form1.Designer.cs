namespace LeitorArquivos
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
            this.txtMostraTextos = new System.Windows.Forms.TextBox();
            this.txtGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMostraTextos
            // 
            this.txtMostraTextos.Location = new System.Drawing.Point(12, 12);
            this.txtMostraTextos.Multiline = true;
            this.txtMostraTextos.Name = "txtMostraTextos";
            this.txtMostraTextos.Size = new System.Drawing.Size(260, 108);
            this.txtMostraTextos.TabIndex = 0;
            // 
            // txtGravar
            // 
            this.txtGravar.Location = new System.Drawing.Point(95, 189);
            this.txtGravar.Name = "txtGravar";
            this.txtGravar.Size = new System.Drawing.Size(75, 23);
            this.txtGravar.TabIndex = 1;
            this.txtGravar.Text = "Gravar";
            this.txtGravar.UseVisualStyleBackColor = true;
            this.txtGravar.Click += new System.EventHandler(this.txtGravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtGravar);
            this.Controls.Add(this.txtMostraTextos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMostraTextos;
        private System.Windows.Forms.Button txtGravar;
    }
}

