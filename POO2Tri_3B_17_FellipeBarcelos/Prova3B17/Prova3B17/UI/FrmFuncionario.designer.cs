namespace Prova3B17
{
    partial class FrmFuncionario
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
            this.lblIdContrato = new System.Windows.Forms.Label();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblDtAdmissao = new System.Windows.Forms.Label();
            this.dtpDtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gridFuncionarios = new System.Windows.Forms.DataGridView();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblFormaContrato = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbFormaContrato = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdContrato
            // 
            this.lblIdContrato.AutoSize = true;
            this.lblIdContrato.Location = new System.Drawing.Point(6, 13);
            this.lblIdContrato.Name = "lblIdContrato";
            this.lblIdContrato.Size = new System.Drawing.Size(94, 13);
            this.lblIdContrato.TabIndex = 0;
            this.lblIdContrato.Text = "ID do Funcionário:";
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Enabled = false;
            this.txtIdFuncionario.Location = new System.Drawing.Point(113, 6);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(164, 20);
            this.txtIdFuncionario.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(6, 68);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Área:";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(113, 60);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(164, 21);
            this.cmbArea.TabIndex = 2;
            // 
            // lblDtAdmissao
            // 
            this.lblDtAdmissao.AutoSize = true;
            this.lblDtAdmissao.Location = new System.Drawing.Point(308, 13);
            this.lblDtAdmissao.Name = "lblDtAdmissao";
            this.lblDtAdmissao.Size = new System.Drawing.Size(96, 13);
            this.lblDtAdmissao.TabIndex = 6;
            this.lblDtAdmissao.Text = "Data de Admissão:";
            // 
            // dtpDtAdmissao
            // 
            this.dtpDtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtAdmissao.Location = new System.Drawing.Point(415, 7);
            this.dtpDtAdmissao.Name = "dtpDtAdmissao";
            this.dtpDtAdmissao.Size = new System.Drawing.Size(164, 20);
            this.dtpDtAdmissao.TabIndex = 4;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGravar.Location = new System.Drawing.Point(8, 270);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(130, 32);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExcluir.Location = new System.Drawing.Point(154, 270);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(133, 32);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.Location = new System.Drawing.Point(302, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 32);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSair.Location = new System.Drawing.Point(447, 270);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 32);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gridFuncionarios
            // 
            this.gridFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.gridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionarios.Location = new System.Drawing.Point(9, 118);
            this.gridFuncionarios.Name = "gridFuncionarios";
            this.gridFuncionarios.Size = new System.Drawing.Size(570, 150);
            this.gridFuncionarios.TabIndex = 7;
            this.gridFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContratos_CellClick);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(366, 38);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(416, 37);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(164, 20);
            this.txtCargo.TabIndex = 5;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRelatorio.Location = new System.Drawing.Point(226, 308);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(129, 31);
            this.btnRelatorio.TabIndex = 12;
            this.btnRelatorio.Text = "RELATÓRIO";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // cmbSetor
            // 
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(113, 89);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(164, 21);
            this.cmbSetor.TabIndex = 3;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(6, 94);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(35, 13);
            this.lblSetor.TabIndex = 17;
            this.lblSetor.Text = "Setor:";
            // 
            // lblFormaContrato
            // 
            this.lblFormaContrato.AutoSize = true;
            this.lblFormaContrato.Location = new System.Drawing.Point(307, 68);
            this.lblFormaContrato.Name = "lblFormaContrato";
            this.lblFormaContrato.Size = new System.Drawing.Size(97, 13);
            this.lblFormaContrato.TabIndex = 19;
            this.lblFormaContrato.Text = "Forma de Contrato:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cmbFormaContrato
            // 
            this.cmbFormaContrato.FormattingEnabled = true;
            this.cmbFormaContrato.Items.AddRange(new object[] {
            "Carteira Assinada",
            "Estagiário",
            "Terceirizado",
            "Home Office",
            "Autônomo"});
            this.cmbFormaContrato.Location = new System.Drawing.Point(415, 65);
            this.cmbFormaContrato.Name = "cmbFormaContrato";
            this.cmbFormaContrato.Size = new System.Drawing.Size(164, 21);
            this.cmbFormaContrato.TabIndex = 6;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.cmbFormaContrato);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFormaContrato);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.gridFuncionarios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtpDtAdmissao);
            this.Controls.Add(this.lblDtAdmissao);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtIdFuncionario);
            this.Controls.Add(this.lblIdContrato);
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.FrmContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdContrato;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblDtAdmissao;
        private System.Windows.Forms.DateTimePicker dtpDtAdmissao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView gridFuncionarios;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblFormaContrato;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbFormaContrato;
    }
}