namespace Warden.View.Base
{
    partial class UscMenu
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPesquisarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPesquisarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu,
            this.tsmiInicio,
            this.tsmiCliente,
            this.tsmiProduto});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 631);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.BackColor = System.Drawing.Color.Transparent;
            this.tsmiInicio.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.tsmiInicio.Margin = new System.Windows.Forms.Padding(5);
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(245, 27);
            this.tsmiInicio.Text = "Inicio";
            // 
            // tsmiCliente
            // 
            this.tsmiCliente.BackColor = System.Drawing.Color.Transparent;
            this.tsmiCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastroCliente,
            this.tsmiPesquisarCliente});
            this.tsmiCliente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.tsmiCliente.Margin = new System.Windows.Forms.Padding(5);
            this.tsmiCliente.Name = "tsmiCliente";
            this.tsmiCliente.Size = new System.Drawing.Size(245, 27);
            this.tsmiCliente.Text = "Cliente";
            // 
            // tsmiProduto
            // 
            this.tsmiProduto.BackColor = System.Drawing.Color.Transparent;
            this.tsmiProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastrarProduto,
            this.tsmiPesquisarProduto});
            this.tsmiProduto.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.tsmiProduto.Margin = new System.Windows.Forms.Padding(5);
            this.tsmiProduto.Name = "tsmiProduto";
            this.tsmiProduto.Size = new System.Drawing.Size(245, 27);
            this.tsmiProduto.Text = "Produtos";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.BackColor = System.Drawing.Color.Transparent;
            this.tsmiMenu.Enabled = false;
            this.tsmiMenu.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.tsmiMenu.Margin = new System.Windows.Forms.Padding(5);
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(245, 27);
            this.tsmiMenu.Text = "Menu";
            this.tsmiMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiCadastroCliente
            // 
            this.tsmiCadastroCliente.Name = "tsmiCadastroCliente";
            this.tsmiCadastroCliente.Size = new System.Drawing.Size(251, 28);
            this.tsmiCadastroCliente.Text = "Cadastrar Cliente";
            // 
            // tsmiPesquisarCliente
            // 
            this.tsmiPesquisarCliente.Name = "tsmiPesquisarCliente";
            this.tsmiPesquisarCliente.Size = new System.Drawing.Size(251, 28);
            this.tsmiPesquisarCliente.Text = "Pesquisar Cliente";
            // 
            // tsmiCadastrarProduto
            // 
            this.tsmiCadastrarProduto.Name = "tsmiCadastrarProduto";
            this.tsmiCadastrarProduto.Size = new System.Drawing.Size(255, 28);
            this.tsmiCadastrarProduto.Text = "Cadastrar Produto";
            // 
            // tsmiPesquisarProduto
            // 
            this.tsmiPesquisarProduto.Name = "tsmiPesquisarProduto";
            this.tsmiPesquisarProduto.Size = new System.Drawing.Size(255, 28);
            this.tsmiPesquisarProduto.Text = "Pesquisar Produto";
            // 
            // UscMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.menuStrip1);
            this.Name = "UscMenu";
            this.Size = new System.Drawing.Size(262, 631);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiPesquisarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiPesquisarProduto;
        protected System.Windows.Forms.MenuStrip menuStrip1;
    }
}
