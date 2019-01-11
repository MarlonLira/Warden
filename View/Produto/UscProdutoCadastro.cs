using System;
using System.Windows.Forms;

namespace Warden.View.Produto
{
    public partial class UscProdutoCadastro : Base.UscCadastro
    {
        public UscProdutoCadastro()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, System.EventArgs e)
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
