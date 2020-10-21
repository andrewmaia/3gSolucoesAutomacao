using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3gSolucoesAutomacao
{
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            this.BackColor = Color.DimGray;
            this.TransparencyKey = Color.DimGray;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
