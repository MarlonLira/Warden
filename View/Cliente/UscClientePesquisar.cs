using System;
using System.Windows.Forms;

namespace Warden.View.Cliente
{
    public partial class UscClientePesquisar : Base.UscPesquisa
    {
        public UscClientePesquisar()
        {
            InitializeComponent();
        }

        private void UscClientePesquisar_Load(object sender, System.EventArgs e)
        {
            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns.Add("cpf", "CPF");
            dataGridView1.Columns.Add("tel", "Tel");
            dataGridView1.Columns.Add("cep", "CEP");
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
