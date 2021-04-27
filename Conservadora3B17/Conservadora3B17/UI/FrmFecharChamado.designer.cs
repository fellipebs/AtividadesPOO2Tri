namespace Conservadora
{
    partial class FrmFecharChamado
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
            this.dtgChamados = new System.Windows.Forms.DataGridView();
            this.lblIdChamado = new System.Windows.Forms.Label();
            this.txtIdChamado = new System.Windows.Forms.TextBox();
            this.btnFecharChamado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgChamados
            // 
            this.dtgChamados.BackgroundColor = System.Drawing.Color.White;
            this.dtgChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChamados.Location = new System.Drawing.Point(2, 0);
            this.dtgChamados.Name = "dtgChamados";
            this.dtgChamados.Size = new System.Drawing.Size(801, 263);
            this.dtgChamados.TabIndex = 0;
            // 
            // lblIdChamado
            // 
            this.lblIdChamado.AutoSize = true;
            this.lblIdChamado.Location = new System.Drawing.Point(287, 280);
            this.lblIdChamado.Name = "lblIdChamado";
            this.lblIdChamado.Size = new System.Drawing.Size(229, 13);
            this.lblIdChamado.TabIndex = 1;
            this.lblIdChamado.Text = "Informe o código do CHAMADO a ser fechada:";
            // 
            // txtIdChamado
            // 
            this.txtIdChamado.Location = new System.Drawing.Point(522, 277);
            this.txtIdChamado.Name = "txtIdChamado";
            this.txtIdChamado.Size = new System.Drawing.Size(142, 20);
            this.txtIdChamado.TabIndex = 0;
            // 
            // btnFecharChamado
            // 
            this.btnFecharChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFecharChamado.Location = new System.Drawing.Point(670, 269);
            this.btnFecharChamado.Name = "btnFecharChamado";
            this.btnFecharChamado.Size = new System.Drawing.Size(133, 34);
            this.btnFecharChamado.TabIndex = 3;
            this.btnFecharChamado.Text = "ENCERRAR Chamdo";
            this.btnFecharChamado.UseVisualStyleBackColor = false;
            this.btnFecharChamado.Click += new System.EventHandler(this.btnFecharChamado_Click);
            // 
            // FrmFecharChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 309);
            this.Controls.Add(this.btnFecharChamado);
            this.Controls.Add(this.txtIdChamado);
            this.Controls.Add(this.lblIdChamado);
            this.Controls.Add(this.dtgChamados);
            this.Name = "FrmFecharChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Chamado";
            this.Load += new System.EventHandler(this.FrmFecharChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgChamados;
        private System.Windows.Forms.Label lblIdChamado;
        private System.Windows.Forms.TextBox txtIdChamado;
        private System.Windows.Forms.Button btnFecharChamado;
    }
}