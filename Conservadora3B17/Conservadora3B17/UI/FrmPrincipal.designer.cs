namespace Conservadora
{
    partial class FrmPrincipal
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
            this.abrirChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarChamadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioOsAbertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioOsPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatorioOsPorStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abrirChamadoToolStripMenuItem
            // 
            this.abrirChamadoToolStripMenuItem.Name = "abrirChamadoToolStripMenuItem";
            this.abrirChamadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirChamadoToolStripMenuItem.Text = "Abrir Chamado";
            // 
            // listarChamadosToolStripMenuItem
            // 
            this.listarChamadosToolStripMenuItem.Name = "listarChamadosToolStripMenuItem";
            this.listarChamadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarChamadosToolStripMenuItem.Text = "Listar Chamados";
            // 
            // fecharChamadosToolStripMenuItem
            // 
            this.fecharChamadosToolStripMenuItem.Name = "fecharChamadosToolStripMenuItem";
            this.fecharChamadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharChamadosToolStripMenuItem.Text = "Fechar Chamados";
            // 
            // ordemServiçoToolStripMenuItem
            // 
            this.ordemServiçoToolStripMenuItem.Name = "ordemServiçoToolStripMenuItem";
            this.ordemServiçoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.ordemServiçoToolStripMenuItem.Text = "Ordem Serviço";
            this.ordemServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemServiçoToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.prestadorToolStripMenuItem,
            this.servicosToolStripMenuItem,
            this.fecharChamadoToolStripMenuItem,
            this.listarChamadosToolStripMenuItem1,
            this.relatorioOsAbertasToolStripMenuItem,
            this.relatorioOsPorDataToolStripMenuItem,
            this.relatorioOsPorStatusToolStripMenuItem});
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // prestadorToolStripMenuItem
            // 
            this.prestadorToolStripMenuItem.Name = "prestadorToolStripMenuItem";
            this.prestadorToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.prestadorToolStripMenuItem.Text = "Prestador";
            this.prestadorToolStripMenuItem.Click += new System.EventHandler(this.prestadorToolStripMenuItem_Click);
            // 
            // servicosToolStripMenuItem
            // 
            this.servicosToolStripMenuItem.Name = "servicosToolStripMenuItem";
            this.servicosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.servicosToolStripMenuItem.Text = "Servicos";
            this.servicosToolStripMenuItem.Click += new System.EventHandler(this.servicosToolStripMenuItem_Click);
            // 
            // fecharChamadoToolStripMenuItem
            // 
            this.fecharChamadoToolStripMenuItem.Name = "fecharChamadoToolStripMenuItem";
            this.fecharChamadoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.fecharChamadoToolStripMenuItem.Text = "Fechar chamado";
            this.fecharChamadoToolStripMenuItem.Click += new System.EventHandler(this.fecharChamadoToolStripMenuItem_Click);
            // 
            // listarChamadosToolStripMenuItem1
            // 
            this.listarChamadosToolStripMenuItem1.Name = "listarChamadosToolStripMenuItem1";
            this.listarChamadosToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.listarChamadosToolStripMenuItem1.Text = "Listar chamados";
            this.listarChamadosToolStripMenuItem1.Click += new System.EventHandler(this.listarChamadosToolStripMenuItem1_Click);
            // 
            // relatorioOsAbertasToolStripMenuItem
            // 
            this.relatorioOsAbertasToolStripMenuItem.Name = "relatorioOsAbertasToolStripMenuItem";
            this.relatorioOsAbertasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatorioOsAbertasToolStripMenuItem.Text = "Relatorio Os Abertas";
            this.relatorioOsAbertasToolStripMenuItem.Click += new System.EventHandler(this.relatorioOsAbertasToolStripMenuItem_Click);
            // 
            // relatorioOsPorDataToolStripMenuItem
            // 
            this.relatorioOsPorDataToolStripMenuItem.Name = "relatorioOsPorDataToolStripMenuItem";
            this.relatorioOsPorDataToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatorioOsPorDataToolStripMenuItem.Text = "Relatorio Os por data";
            this.relatorioOsPorDataToolStripMenuItem.Click += new System.EventHandler(this.relatorioOsPorDataToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemServiçoToolStripMenuItem,
            this.gerenciarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatorioOsPorStatusToolStripMenuItem
            // 
            this.relatorioOsPorStatusToolStripMenuItem.Name = "relatorioOsPorStatusToolStripMenuItem";
            this.relatorioOsPorStatusToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.relatorioOsPorStatusToolStripMenuItem.Text = "Relatorio Os por status";
            this.relatorioOsPorStatusToolStripMenuItem.Click += new System.EventHandler(this.relatorioOsPorStatusToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C O N S E R V A D O R A";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem abrirChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarChamadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatorioOsAbertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioOsPorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioOsPorStatusToolStripMenuItem;
    }
}

