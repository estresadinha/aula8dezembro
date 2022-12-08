namespace Aula8Dezembro
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mensagemfinal = new System.Windows.Forms.Label();
            this.botaoenviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(260, 121);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(226, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um nome";
            // 
            // Mensagemfinal
            // 
            this.Mensagemfinal.AutoSize = true;
            this.Mensagemfinal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mensagemfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagemfinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mensagemfinal.Location = new System.Drawing.Point(210, 245);
            this.Mensagemfinal.Name = "Mensagemfinal";
            this.Mensagemfinal.Size = new System.Drawing.Size(227, 25);
            this.Mensagemfinal.TabIndex = 2;
            this.Mensagemfinal.Text = "o  nome digitado foi:";
            // 
            // botaoenviar
            // 
            this.botaoenviar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.botaoenviar.Location = new System.Drawing.Point(274, 168);
            this.botaoenviar.Name = "botaoenviar";
            this.botaoenviar.Size = new System.Drawing.Size(75, 23);
            this.botaoenviar.TabIndex = 3;
            this.botaoenviar.Text = "enviar";
            this.botaoenviar.UseVisualStyleBackColor = false;
            this.botaoenviar.Click += new System.EventHandler(this.botaoenviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoenviar);
            this.Controls.Add(this.Mensagemfinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mensagemfinal;
        private System.Windows.Forms.Button botaoenviar;
    }
}

