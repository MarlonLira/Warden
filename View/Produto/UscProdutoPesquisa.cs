using System;
using System.Windows.Forms;

namespace Warden.View.Produto
{
    public partial class UscProdutoPesquisa : Base.UscPesquisa
    {
        public UscProdutoPesquisa()
        {
            InitializeComponent();
        }

        private void UscProdutoPesquisa_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns.Add("quantidade", "Quantidade");
            dataGridView1.Columns.Add("tipo", "Tipo");
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            UscProduto Uproduto;
            try
            {
                Uproduto = new UscProduto();
                CreateNewControl(Uproduto);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
