using System;
using System.Drawing;
using System.Windows.Forms;

namespace Warden.View
{
    public partial class UscBase : UserControl
    {
        public UscBase()
        {
            InitializeComponent();
        }

        protected void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
