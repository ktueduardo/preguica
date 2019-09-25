using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Pim
{
    class empresaModel
    {
        private SqlConnection conn;
        private SqlCommand command;
        private string connectionString = @"Data Source=DESKTOP-K04TCNQ\SQLEXPRESS;Initial Catalog=D:\DB.MDF;Persist Security Info=True;User ID=edu;Password=senha1";
        private List<SqlParameter> listaDeParametrosSQL = new List<SqlParameter>();
        public SqlConnection getConnection()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return conn;
            }
        }

        public string CadastroEmpresa(
            string nome, string razao, string email, string CNPJ,
            string tel1, string tel2, string website, string endereco,
            Int64 cep, Int64 numero, string comp, string bairro,
            string cidade, string estado
            )
        {
            try
            {
                command = new SqlCommand();
                command.Connection = getConnection();
                if (tel2 != string.Empty)
                {
                    command.CommandText = "cadastroEmpresa";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Declaração dos parametros do método
                    addParam(nameof(CNPJ), CNPJ, 0);
                    addParam(nameof(nome), nome, 0);
                    addParam(nameof(razao), razao, 0);
                    addParam(nameof(email), email, 0);
                    addParam(nameof(tel1), tel1, 0);
                    addParam(nameof(tel2), tel2, 0);
                    addParam(nameof(website), website, 0);
                    addParam(nameof(endereco), endereco, 0);
                    addParam(nameof(numero), "", numero);
                    addParam(nameof(cep), "", cep);
                    addParam(nameof(comp), comp, 0);
                    addParam(nameof(bairro), bairro, 0);
                    addParam(nameof(cidade), cidade, 0);
                    addParam(nameof(estado), estado, 0);

                    foreach (SqlParameter parametros in listaDeParametrosSQL)
                    {
                        command.Parameters.Add(parametros);
                    }
                }
                else
                {
                    command.CommandText = "cadastroEmpresaSemTelefone2";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Declaração dos parametros do método
                    addParam(nameof(CNPJ), CNPJ, 0);
                    addParam(nameof(nome), nome, 0);
                    addParam(nameof(razao), razao, 0);
                    addParam(nameof(email), email, 0);
                    addParam(nameof(tel1), tel1, 0);
                    addParam(nameof(website), website, 0);
                    addParam(nameof(endereco), endereco, 0);
                    addParam(nameof(numero), "", numero);
                    addParam(nameof(cep), "", cep);
                    addParam(nameof(comp), comp, 0);
                    addParam(nameof(bairro), bairro, 0);
                    addParam(nameof(cidade), cidade, 0);
                    addParam(nameof(estado), estado, 0);

                    foreach (SqlParameter parametros in listaDeParametrosSQL)
                    {
                        command.Parameters.Add(parametros);
                    }
                }


                command.ExecuteNonQuery();
                command.Parameters.Clear();
                listaDeParametrosSQL.Clear();

                return "cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return ex.Message.ToString();
            }
        }


        public List<SqlParameter> addParam(string name, string valorString, Int64 valorInt)
        {
            if (valorString != string.Empty)
            {
                listaDeParametrosSQL.Add(new SqlParameter(name, valorString));
                return listaDeParametrosSQL;
            }
            else
            {
                listaDeParametrosSQL.Add(new SqlParameter(name, valorInt));
                return listaDeParametrosSQL;
            }

        }
    }
}
