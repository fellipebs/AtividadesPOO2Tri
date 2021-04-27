namespace Conservadora
{
    partial class FrmServicos
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gridCategoria = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.lblValorHoraVIP = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtValorHoraVIP = new System.Windows.Forms.TextBox();
            this.txtTempoMin = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(363, 350);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(243, 349);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 40;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(125, 349);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(7, 349);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Gravar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gridCategoria
            // 
            this.gridCategoria.BackgroundColor = System.Drawing.Color.White;
            this.gridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategoria.Location = new System.Drawing.Point(7, 184);
            this.gridCategoria.Name = "gridCategoria";
            this.gridCategoria.Size = new System.Drawing.Size(468, 160);
            this.gridCategoria.TabIndex = 37;
            this.gridCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategoria_CellClick_1);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(104, 31);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(371, 20);
            this.txtDescricao.TabIndex = 36;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(4, 38);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 35;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(104, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(369, 20);
            this.txtID.TabIndex = 34;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "ID:";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Location = new System.Drawing.Point(4, 69);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(76, 13);
            this.lblValorHora.TabIndex = 42;
            this.lblValorHora.Text = "Valor por hora:";
            // 
            // lblValorHoraVIP
            // 
            this.lblValorHoraVIP.AutoSize = true;
            this.lblValorHoraVIP.Location = new System.Drawing.Point(4, 100);
            this.lblValorHoraVIP.Name = "lblValorHoraVIP";
            this.lblValorHoraVIP.Size = new System.Drawing.Size(96, 13);
            this.lblValorHoraVIP.TabIndex = 43;
            this.lblValorHoraVIP.Text = "Valor por hora VIP:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(4, 130);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(88, 13);
            this.lblTempo.TabIndex = 44;
            this.lblTempo.Text = "Tempo (minutos):";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(4, 159);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 45;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(104, 62);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(369, 20);
            this.txtValorHora.TabIndex = 46;
            // 
            // txtValorHoraVIP
            // 
            this.txtValorHoraVIP.Location = new System.Drawing.Point(104, 93);
            this.txtValorHoraVIP.Name = "txtValorHoraVIP";
            this.txtValorHoraVIP.Size = new System.Drawing.Size(369, 20);
            this.txtValorHoraVIP.TabIndex = 47;
            // 
            // txtTempoMin
            // 
            this.txtTempoMin.Location = new System.Drawing.Point(104, 123);
            this.txtTempoMin.Name = "txtTempoMin";
            this.txtTempoMin.Size = new System.Drawing.Size(369, 20);
            this.txtTempoMin.TabIndex = 48;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(104, 149);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(369, 21);
            this.cmbCategoria.TabIndex = 49;
            // 
            // FrmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 389);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtTempoMin);
            this.Controls.Add(this.txtValorHoraVIP);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblValorHoraVIP);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gridCategoria);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblId);
            this.Name = "FrmServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Serviços";
            this.Load += new System.EventHandler(this.FrmServicos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView gridCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.Label lblValorHoraVIP;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtValorHoraVIP;
        private System.Windows.Forms.TextBox txtTempoMin;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}