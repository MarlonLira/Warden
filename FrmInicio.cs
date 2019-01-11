using System.Diagnostics;
using System.Windows.Forms;
using Warden.View;
using Warden.View.Produto;

namespace Warden
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, System.EventArgs e)
        {
            UscBase UBase = new UscBase();
            pn_base.Controls.Add(UBase);
        }

        private void btn_fechar_Click(object sender, System.EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void btn_cliente_Click(object sender, System.EventArgs e)
        {
            pn_base.Controls.Clear();
            UscCliente UCliente = new UscCliente();
            pn_base.Controls.Add(UCliente);
        }

        private void btn_produto_Click(object sender, System.EventArgs e)
        {
            pn_base.Controls.Clear();
            UscProduto UProduto = new UscProduto();
            pn_base.Controls.Add(UProduto);
        }

        private void btn_minimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, System.EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
