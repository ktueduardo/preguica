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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            dateFooter.Text = System.DateTime.Now.ToLongDateString() + " - "+ System.DateTime.Now.ToLongTimeString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(ListFuncionarios.Instance))
            {
                Container.Controls.Add(ListFuncionarios.Instance);
                ListFuncionarios.Instance.Dock = DockStyle.Fill;
                ListFuncionarios.Instance.BringToFront();
            }
            else
            {
                ListFuncionarios.Instance.BringToFront();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(Empresas.Instance))
            {
                Container.Controls.Add(Empresas.Instance);
                Empresas.Instance.Dock = DockStyle.Fill;
                Empresas.Instance.BringToFront();
            }
            else
            {
                Empresas.Instance.BringToFront();
            }
        }
    }
}
