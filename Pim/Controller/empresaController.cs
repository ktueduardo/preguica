using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim
{
    class empresaController
    {
        public string CadastrarEmpresa(string nome,
                string razao,
                string email,
                string CNPJ,
                string telefone,
                string telefone2,
                string website,
                string endereco,
                Int64 cep,
                Int64 numero,
                string complemento,
                string bairro,
                string cidade,
                string estado)
        {
            empresaModel modelo = new empresaModel();
            string resultado = modelo.CadastroEmpresa(nome, razao, email, CNPJ, telefone,telefone2, website, endereco, cep, numero, complemento, bairro, cidade, estado);

            return resultado;
        }
    }
}
