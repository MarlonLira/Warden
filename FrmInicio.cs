using System.Diagnostics;
using System.Windows.Forms;
using Warden.View;
using Warden.View.Base;

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
            UscCliente UCliente = new UscCliente(this);
            pn_base.Controls.Add(UCliente);
            
        }

        private void btn_produto_Click(object sender, System.EventArgs e)
        {
            pn_base.Controls.Clear();
            FrmBase Base = new FrmBase();
            Base.TopLevel = false;
            pn_base.Controls.Add(Base);
            Base.Show();
        }
    }
}
