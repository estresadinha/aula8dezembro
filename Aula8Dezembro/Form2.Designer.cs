﻿namespace Aula8Dezembro
{
    partial class Form2
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
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTexto
            // 
            this.inputTexto.Location = new System.Drawing.Point(44, 12);
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(100, 20);
            this.inputTexto.TabIndex = 1;
            this.inputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.Location = new System.Drawing.Point(569, 48);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(99, 38);
            this.botaoLimpar.TabIndex = 2;
            this.botaoLimpar.Text = "limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.click);
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(44, 61);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela.Size = new System.Drawing.Size(494, 338);
            this.tela.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.inputTexto);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTexto;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox tela;
    }
}