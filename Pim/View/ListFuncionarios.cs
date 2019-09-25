using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim
{
    public partial class ListFuncionarios : UserControl
    {
        private static ListFuncionarios _instance;

        public static ListFuncionarios Instance
        {
            get
            {
                if(_instance == null){
                    _instance = new ListFuncionarios();
                    return _instance;
                }
                return _instance;
            }
        }
        public ListFuncionarios()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionarios form = new CadastroDeFuncionarios();

            if(form.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("O usuario apertou OK");
            }
            else
            {
                MessageBox.Show("O usuario apertou cancel");
            }
        }
    }
}
