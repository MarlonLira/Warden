using System;
using Warden.View.Cliente;

namespace Warden.View
{
    public partial class UscCliente : UscBase
    {
        FrmInicio Inicio;
        public UscCliente(FrmInicio Frm)
        {
            InitializeComponent();
            Inicio = Frm;
        }

        private void UscCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UscClienteCadastro CadastrarCliente = new UscClienteCadastro();
            this.Controls.Add(CadastrarCliente);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UscClientePesquisar PesquisarCliente = new UscClientePesquisar();
            this.Controls.Add(PesquisarCliente);
        }
    }
}
