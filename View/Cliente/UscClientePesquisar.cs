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
    }
}
