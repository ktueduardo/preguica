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
    public partial class Empresas : UserControl
    {
        private static Empresas _instance;

        public static Empresas Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Empresas();
                    return _instance;
                }
                return _instance;
            }
        }
        public Empresas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CadastroDaEmpresa frm = new CadastroDaEmpresa();

            if(frm.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Empresa cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Algo deu errado, Tente novamente mais tarde!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CadastroDeFilial frm = new CadastroDeFilial();

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Filial cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Parece que algo deu errado!");
            }
        }
    }
}
