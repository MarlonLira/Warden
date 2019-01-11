using System;
using System.Windows.Forms;

namespace Warden.View.Produto
{
    public partial class UscProduto : UscBase
    {
        public UscProduto()
        {
            InitializeComponent();
            
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            UscProdutoCadastro CadastrarProduto;
            try
            {
                CadastrarProduto = new UscProdutoCadastro();
                CreateNewControl(CadastrarProduto);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            UscProdutoPesquisa PesquisarProduto;
            try
            {
                PesquisarProduto = new UscProdutoPesquisa();
                CreateNewControl(PesquisarProduto);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
