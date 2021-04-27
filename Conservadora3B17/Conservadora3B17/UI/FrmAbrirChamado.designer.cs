namespace Conservadora
{
    partial class FrmAbrirChamado
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
            this.dtpdataservico = new System.Windows.Forms.DateTimePicker();
            this.cbxservico = new System.Windows.Forms.ComboBox();
            this.chkVip = new System.Windows.Forms.CheckBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.NumericUpDown();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.NumericUpDown();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxPrestador = new System.Windows.Forms.ComboBox();
            this.lblDtServico = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPrestador = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpdataservico
            // 
            this.dtpdataservico.Location = new System.Drawing.Point(182, 12);
            this.dtpdataservico.Name = "dtpdataservico";
            this.dtpdataservico.Size = new System.Drawing.Size(230, 20);
            this.dtpdataservico.TabIndex = 0;
            // 
            // cbxservico
            // 
            this.cbxservico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxservico.FormattingEnabled = true;
            this.cbxservico.Location = new System.Drawing.Point(168, 364);
            this.cbxservico.Name = "cbxservico";
            this.cbxservico.Size = new System.Drawing.Size(311, 21);
            this.cbxservico.TabIndex = 2;
            // 
            // chkVip
            // 
            this.chkVip.AutoSize = true;
            this.chkVip.Location = new System.Drawing.Point(552, 350);
            this.chkVip.Name = "chkVip";
            this.chkVip.Size = new System.Drawing.Size(78, 17);
            this.chkVip.TabIndex = 3;
            this.chkVip.Text = "Cliente VIP";
            this.chkVip.UseVisualStyleBackColor = true;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(599, 76);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(120, 20);
            this.txtcep.TabIndex = 4;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(599, 45);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(120, 20);
            this.txtnumero.TabIndex = 5;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(182, 79);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(230, 20);
            this.txtcomplemento.TabIndex = 6;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(182, 113);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(120, 20);
            this.txtHoras.TabIndex = 7;
            this.txtHoras.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(182, 139);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(534, 98);
            this.txtdescricao.TabIndex = 8;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(182, 243);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(534, 70);
            this.txtcomentario.TabIndex = 9;
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(168, 391);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(311, 21);
            this.cbxCliente.TabIndex = 10;
            // 
            // cbxPrestador
            // 
            this.cbxPrestador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrestador.FormattingEnabled = true;
            this.cbxPrestador.Location = new System.Drawing.Point(168, 418);
            this.cbxPrestador.Name = "cbxPrestador";
            this.cbxPrestador.Size = new System.Drawing.Size(311, 21);
            this.cbxPrestador.TabIndex = 11;
            // 
            // lblDtServico
            // 
            this.lblDtServico.AutoSize = true;
            this.lblDtServico.Location = new System.Drawing.Point(24, 12);
            this.lblDtServico.Name = "lblDtServico";
            this.lblDtServico.Size = new System.Drawing.Size(87, 13);
            this.lblDtServico.TabIndex = 12;
            this.lblDtServico.Text = "Data do Serviço:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(549, 76);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 13;
            this.lblCEP.Text = "CEP:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(549, 47);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(24, 79);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 15;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(24, 113);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(98, 13);
            this.lblHoras.TabIndex = 16;
            this.lblHoras.Text = "Horas Contratadas:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(24, 142);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(143, 13);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Breve Descrição do Serviço:";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(24, 243);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(68, 13);
            this.lblComentarios.TabIndex = 18;
            this.lblComentarios.Text = "Comentários:";
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Location = new System.Drawing.Point(10, 364);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(85, 13);
            this.lblTipoServico.TabIndex = 19;
            this.lblTipoServico.Text = "Tipo de Serviço:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(10, 391);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblPrestador
            // 
            this.lblPrestador.AutoSize = true;
            this.lblPrestador.Location = new System.Drawing.Point(10, 421);
            this.lblPrestador.Name = "lblPrestador";
            this.lblPrestador.Size = new System.Drawing.Size(55, 13);
            this.lblPrestador.TabIndex = 21;
            this.lblPrestador.Text = "Prestador:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(496, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 32);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(616, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 32);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(24, 45);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(182, 45);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(346, 20);
            this.txtEndereco.TabIndex = 25;
            // 
            // FrmAbrirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 455);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblPrestador);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTipoServico);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblDtServico);
            this.Controls.Add(this.cbxPrestador);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.chkVip);
            this.Controls.Add(this.cbxservico);
            this.Controls.Add(this.dtpdataservico);
            this.Name = "FrmAbrirChamado";
            this.Text = "ORDEM DE SERVIÇO: Abrir Chamado  ";
            this.Load += new System.EventHandler(this.FrmAbrirChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpdataservico;
        private System.Windows.Forms.ComboBox cbxservico;
        private System.Windows.Forms.CheckBox chkVip;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.NumericUpDown txtnumero;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.NumericUpDown txtHoras;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxPrestador;
        private System.Windows.Forms.Label lblDtServico;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPrestador;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
    }
}