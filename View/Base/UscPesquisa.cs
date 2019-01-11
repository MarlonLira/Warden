namespace Warden.View.Base
{
    public partial class UscPesquisa : UscBase
    {
        public UscPesquisa()
        {
            InitializeComponent();
        }

        private void UscPesquisa_Load(object sender, System.EventArgs e)
        {
            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns.Add("cpf", "CPF");
            dataGridView1.Columns.Add("tel", "Tel");
            dataGridView1.Columns.Add("cep", "CEP");
        }
    }
}
