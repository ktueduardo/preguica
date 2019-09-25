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
    public partial class CadastroDaEmpresa : Form
    {
        public CadastroDaEmpresa()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            empresaController cadastro = new empresaController();
           string resultado = cadastro.CadastrarEmpresa(
                    nome.Text,
                    razao.Text,
                    email.Text,
                    cnpj.Text,
                    tel1.Text,
                    tel2.Text,
                    web.Text,
                    end.Text,
                    Convert.ToInt64(cep.Text),
                    Convert.ToInt64(num.Text),
                    comp.Text,
                    bairro.Text,
                    cidade.Text,
                    estado.Text);

            MessageBox.Show(resultado);
        }
    }
}
