using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Warden.View.Base
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        protected void ManualSettings()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(1020, 628);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            ManualSettings();
        }
    }
}
