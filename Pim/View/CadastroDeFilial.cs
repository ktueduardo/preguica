using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pim.Model;
using Pim.Controller;

namespace Pim
{

    public partial class CadastroDeFilial : Form
    {
        public CadastroDeFilial()
        {
            InitializeComponent();
            filialModel combo = new filialModel();
            SqlDataReader rdr = combo.getFilial();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr.GetString(1));
                }
            }
            rdr.Close();
            combo.closeReader();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            filialController cadastro = new filialController();
            string resultado = cadastro.CadastrarFilial(
                     nome.Text,
                     razao.Text,
                     email.Text,
                     CNPJ.Text,
                     tel1.Text,
                     tel2.Text,
                     web.Text,
                     Convert.ToInt64(numerofilial.Text),
                     comboBox1.SelectedItem.ToString(),
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
