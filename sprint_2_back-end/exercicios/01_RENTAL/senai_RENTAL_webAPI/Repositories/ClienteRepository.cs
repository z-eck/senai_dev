using senai_RENTAL_webAPI.Domains;
using senai_RENTAL_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Repositories
{
    /// <summary> 
    /// Classe definida para possuir a responsabilidade do repositório "Cliente"
    /// </summary>
    public class ClienteRepository : IClienteRepository
    {
        /// <summary>
        /// String de conexão com o BDD que recebe os parâmetros
        /// </summary>
        private string stringConexao = @"CAL\SQLEXPRESS; initial catalog=RENTAL_T; user Id=sa; pwd=Senai@132";

        public void AtualizarIDCorpo(ClienteDomain clienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public ClienteDomain BuscarPorID(int idCliente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idCliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDomain> ListarTodos()
        {
            List<ClienteDomain> listaCliente = new List<ClienteDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idCliente, nomeCliente, sobrenomeCliente, cpfCliente, cnhCliente FROM CLIENTE";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain()
                        {
                            idCliente = Convert.ToInt32(rdr[0]),
                            nomeCliente = rdr[1].ToString(),
                            sobrenomeCliente = rdr[2].ToString(),
                            cpfCliente = rdr[3].ToString(),
                            cnhCliente = rdr[4].ToString()
                        };

                        listaCliente.Add(cliente);
                    }
                }
            }

            return listaCliente;
        }

        public void Registrar(ClienteDomain novoCliente)
        {
            throw new NotImplementedException();
        }
    }
}
