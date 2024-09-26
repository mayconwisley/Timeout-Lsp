using System;
using System.Windows.Forms;

namespace Timeout_Copacol
{
    public partial class FrmPrincipal : Form
    {
        private string _timeout = string.Empty;
        private int count = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
            _timeout = "2";
        }
        public FrmPrincipal(string timeout)
        {
            InitializeComponent();
            _timeout = timeout;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (_timeout != string.Empty)
            {

                int timeout = int.Parse(_timeout);
                count = timeout;
                TimeoutPrincipal.Enabled = true;
            }

        }

        private void TimeoutPrincipal_Tick(object sender, EventArgs e)
        {
            if (count == 1)
            {
                LblAguardando.Text = $"Aguardando {count:00} segundo";
            }
            else
            {
                LblAguardando.Text = $"Aguardando {count:00} segundos";
            }

            if (count == 0)
            {
                TimeoutPrincipal.Stop();
                Application.Exit();
            }
            count--;
        }
    }
}
