namespace Conservadora
{
    partial class FrmListarChamados
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtIdChamado = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.pnlChamado = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpDtAbertura = new System.Windows.Forms.DateTimePicker();
            this.lblDtAbertura = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblPrestador = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblDtServico = new System.Windows.Forms.Label();
            this.cmbPrestador = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.NumericUpDown();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.NumericUpDown();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.chkVip = new System.Windows.Forms.CheckBox();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.dtpDtServico = new System.Windows.Forms.DateTimePicker();
            this.dtgChamado = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlChamado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(106, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Chamado:";
            // 
            // txtIdChamado
            // 
            this.txtIdChamado.Location = new System.Drawing.Point(178, 10);
            this.txtIdChamado.Name = "txtIdChamado";
            this.txtIdChamado.Size = new System.Drawing.Size(152, 20);
            this.txtIdChamado.TabIndex = 0;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnExibir.Location = new System.Drawing.Point(354, 9);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(135, 23);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "EXIBIR";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // pnlChamado
            // 
            this.pnlChamado.BackColor = System.Drawing.Color.White;
            this.pnlChamado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChamado.Controls.Add(this.lblStatus);
            this.pnlChamado.Controls.Add(this.dtpDtAbertura);
            this.pnlChamado.Controls.Add(this.lblDtAbertura);
            this.pnlChamado.Controls.Add(this.txtEndereco);
            this.pnlChamado.Controls.Add(this.lblEndereco);
            this.pnlChamado.Controls.Add(this.lblPrestador);
            this.pnlChamado.Controls.Add(this.lblCliente);
            this.pnlChamado.Controls.Add(this.lblTipoServico);
            this.pnlChamado.Controls.Add(this.lblComentarios);
            this.pnlChamado.Controls.Add(this.lblDescricao);
            this.pnlChamado.Controls.Add(this.lblHoras);
            this.pnlChamado.Controls.Add(this.lblComplemento);
            this.pnlChamado.Controls.Add(this.lblNumero);
            this.pnlChamado.Controls.Add(this.lblCEP);
            this.pnlChamado.Controls.Add(this.lblDtServico);
            this.pnlChamado.Controls.Add(this.cmbPrestador);
            this.pnlChamado.Controls.Add(this.cmbCliente);
            this.pnlChamado.Controls.Add(this.txtcomentario);
            this.pnlChamado.Controls.Add(this.txtdescricao);
            this.pnlChamado.Controls.Add(this.txtHoras);
            this.pnlChamado.Controls.Add(this.txtcomplemento);
            this.pnlChamado.Controls.Add(this.txtnumero);
            this.pnlChamado.Controls.Add(this.txtcep);
            this.pnlChamado.Controls.Add(this.chkVip);
            this.pnlChamado.Controls.Add(this.cmbServico);
            this.pnlChamado.Controls.Add(this.dtpDtServico);
            this.pnlChamado.Enabled = false;
            this.pnlChamado.Location = new System.Drawing.Point(9, 185);
            this.pnlChamado.Name = "pnlChamado";
            this.pnlChamado.Size = new System.Drawing.Size(719, 402);
            this.pnlChamado.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(544, 352);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 74;
            this.lblStatus.Text = "Status";
            // 
            // dtpDtAbertura
            // 
            this.dtpDtAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtAbertura.Location = new System.Drawing.Point(581, 10);
            this.dtpDtAbertura.Name = "dtpDtAbertura";
            this.dtpDtAbertura.Size = new System.Drawing.Size(117, 20);
            this.dtpDtAbertura.TabIndex = 73;
            // 
            // lblDtAbertura
            // 
            this.lblDtAbertura.AutoSize = true;
            this.lblDtAbertura.Location = new System.Drawing.Point(484, 10);
            this.lblDtAbertura.Name = "lblDtAbertura";
            this.lblDtAbertura.Size = new System.Drawing.Size(91, 13);
            this.lblDtAbertura.TabIndex = 72;
            this.lblDtAbertura.Text = "Data da Abertura:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(164, 43);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(346, 20);
            this.txtEndereco.TabIndex = 71;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 43);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 70;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblPrestador
            // 
            this.lblPrestador.AutoSize = true;
            this.lblPrestador.Location = new System.Drawing.Point(6, 374);
            this.lblPrestador.Name = "lblPrestador";
            this.lblPrestador.Size = new System.Drawing.Size(55, 13);
            this.lblPrestador.TabIndex = 69;
            this.lblPrestador.Text = "Prestador:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 344);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 68;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Location = new System.Drawing.Point(6, 317);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(85, 13);
            this.lblTipoServico.TabIndex = 67;
            this.lblTipoServico.Text = "Tipo de Serviço:";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(6, 241);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(68, 13);
            this.lblComentarios.TabIndex = 66;
            this.lblComentarios.Text = "Comentários:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 140);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(143, 13);
            this.lblDescricao.TabIndex = 65;
            this.lblDescricao.Text = "Breve Descrição do Serviço:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(6, 107);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(98, 13);
            this.lblHoras.TabIndex = 64;
            this.lblHoras.Text = "Horas Contratadas:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 77);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 63;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(531, 45);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 62;
            this.lblNumero.Text = "Numero:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(544, 77);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 61;
            this.lblCEP.Text = "CEP:";
            // 
            // lblDtServico
            // 
            this.lblDtServico.AutoSize = true;
            this.lblDtServico.Location = new System.Drawing.Point(6, 10);
            this.lblDtServico.Name = "lblDtServico";
            this.lblDtServico.Size = new System.Drawing.Size(87, 13);
            this.lblDtServico.TabIndex = 60;
            this.lblDtServico.Text = "Data do Serviço:";
            // 
            // cmbPrestador
            // 
            this.cmbPrestador.FormattingEnabled = true;
            this.cmbPrestador.Location = new System.Drawing.Point(164, 371);
            this.cmbPrestador.Name = "cmbPrestador";
            this.cmbPrestador.Size = new System.Drawing.Size(311, 21);
            this.cmbPrestador.TabIndex = 59;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(164, 344);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(311, 21);
            this.cmbCliente.TabIndex = 58;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(164, 241);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(534, 70);
            this.txtcomentario.TabIndex = 57;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(164, 137);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(534, 98);
            this.txtdescricao.TabIndex = 56;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(164, 107);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(120, 20);
            this.txtHoras.TabIndex = 55;
            this.txtHoras.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(164, 77);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(230, 20);
            this.txtcomplemento.TabIndex = 54;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(581, 43);
            this.txtnumero.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(120, 20);
            this.txtnumero.TabIndex = 53;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(581, 74);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(120, 20);
            this.txtcep.TabIndex = 52;
            // 
            // chkVip
            // 
            this.chkVip.AutoSize = true;
            this.chkVip.Location = new System.Drawing.Point(547, 321);
            this.chkVip.Name = "chkVip";
            this.chkVip.Size = new System.Drawing.Size(78, 17);
            this.chkVip.TabIndex = 51;
            this.chkVip.Text = "Cliente VIP";
            this.chkVip.UseVisualStyleBackColor = true;
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(164, 317);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(311, 21);
            this.cmbServico.TabIndex = 50;
            // 
            // dtpDtServico
            // 
            this.dtpDtServico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtServico.Location = new System.Drawing.Point(164, 10);
            this.dtpDtServico.Name = "dtpDtServico";
            this.dtpDtServico.Size = new System.Drawing.Size(120, 20);
            this.dtpDtServico.TabIndex = 49;
            // 
            // dtgChamado
            // 
            this.dtgChamado.BackgroundColor = System.Drawing.Color.White;
            this.dtgChamado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChamado.Location = new System.Drawing.Point(10, 38);
            this.dtgChamado.Name = "dtgChamado";
            this.dtgChamado.Size = new System.Drawing.Size(718, 141);
            this.dtgChamado.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.Location = new System.Drawing.Point(504, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 23);
            this.btnSair.TabIndex = 42;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmListarChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 597);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtgChamado);
            this.Controls.Add(this.pnlChamado);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtIdChamado);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmListarChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Chamados";
            this.Load += new System.EventHandler(this.FrmListarChamados_Load);
            this.pnlChamado.ResumeLayout(false);
            this.pnlChamado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtIdChamado;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Panel pnlChamado;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblPrestador;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblDtServico;
        private System.Windows.Forms.ComboBox cmbPrestador;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.NumericUpDown txtHoras;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.NumericUpDown txtnumero;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.CheckBox chkVip;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.DateTimePicker dtpDtServico;
        private System.Windows.Forms.DataGridView dtgChamado;
        private System.Windows.Forms.DateTimePicker dtpDtAbertura;
        private System.Windows.Forms.Label lblDtAbertura;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSair;
    }
}