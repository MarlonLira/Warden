using System;
using System.Drawing;
using System.Windows.Forms;

namespace Warden.View
{
    public partial class UscBase : UserControl
    {
        public Control CacheControl;

        public UscBase()
        {
            InitializeComponent();
        }

        protected void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        protected void CreateNewControl(Control NewControl)
        {
            try
            {
                this.Controls.Clear();
                this.Controls.Add(NewControl);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }

        protected void ManualSettings()
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(1020, 631);
        }

        protected void UscBase_Load(object sender, EventArgs e)
        {
            ManualSettings();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }
    }
}
