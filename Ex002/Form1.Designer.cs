namespace Ex002
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
            this.lblMeu = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblBrasil = new System.Windows.Forms.Label();
            this.lblBrasileiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMeu
            // 
            this.lblMeu.AutoSize = true;
            this.lblMeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeu.Location = new System.Drawing.Point(77, 86);
            this.lblMeu.Name = "lblMeu";
            this.lblMeu.Size = new System.Drawing.Size(48, 20);
            this.lblMeu.TabIndex = 0;
            this.lblMeu.Text = "MEU";
            this.lblMeu.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(175, 183);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblBrasil
            // 
            this.lblBrasil.AutoSize = true;
            this.lblBrasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrasil.Location = new System.Drawing.Point(171, 86);
            this.lblBrasil.Name = "lblBrasil";
            this.lblBrasil.Size = new System.Drawing.Size(74, 20);
            this.lblBrasil.TabIndex = 0;
            this.lblBrasil.Text = "BRASIL";
            this.lblBrasil.Visible = false;
            // 
            // lblBrasileiro
            // 
            this.lblBrasileiro.AutoSize = true;
            this.lblBrasileiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrasileiro.Location = new System.Drawing.Point(268, 86);
            this.lblBrasileiro.Name = "lblBrasileiro";
            this.lblBrasileiro.Size = new System.Drawing.Size(118, 20);
            this.lblBrasileiro.TabIndex = 0;
            this.lblBrasileiro.Text = "BRASILEIRO";
            this.lblBrasileiro.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 288);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblBrasileiro);
            this.Controls.Add(this.lblBrasil);
            this.Controls.Add(this.lblMeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Brasil Brasileiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeu;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblBrasil;
        private System.Windows.Forms.Label lblBrasileiro;
    }
}

