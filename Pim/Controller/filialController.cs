using Pim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Controller
{
    class filialController
    {
        public string CadastrarFilial(string nome,
                string razao,
                string email,
                string CNPJ,
                string telefone,
                string telefone2,
                string website,
                Int64 numerofilial,
                string cnpjSede,
                string endereco,
                Int64 cep,
                Int64 numero,
                string complemento,
                string bairro,
                string cidade,
                string estado)
        {
            filialModel modelo = new filialModel();
            string resultado = modelo.CadastroDeFilial(
                nome, razao, email, CNPJ, 
                telefone, telefone2, website,numerofilial,
                cnpjSede, endereco, cep, numero, 
                complemento, bairro, cidade, estado
                );

            return resultado;
        }
    }
}
