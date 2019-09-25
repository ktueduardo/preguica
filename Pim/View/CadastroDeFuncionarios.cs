using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim
{
    public partial class CadastroDeFuncionarios : Form
    {
        public CadastroDeFuncionarios()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.Cancel;
        }
    }
}
