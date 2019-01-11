using System;
using System.Windows.Forms;

namespace Warden.View.Cliente
{
    public partial class UscClienteCadastro : Base.UscCadastro
    {
        public UscClienteCadastro()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            UscCliente Ucliente;
            try
            {
                Ucliente = new UscCliente();
                CreateNewControl(Ucliente);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
