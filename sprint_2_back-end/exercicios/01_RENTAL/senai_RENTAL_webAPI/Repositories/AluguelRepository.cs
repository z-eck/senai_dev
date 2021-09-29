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
    /// Classe definida para possuir a responsabilidade do repositório "Aluguel"
    /// </summary>
    public class AluguelRepository : IAluguelRepository
    {
        /// <summary>
        /// String de conexão com o BDD que recebe os parâmetros
        /// </summary>
        private string stringConexao = @"CAL\SQLEXPRESS; initial catalog=RENTAL_T; user Id=sa; pwd=Senai@132";

        public void AtualizarIDCorpo(AluguelDomain aluguelAtualizado)
        {
            throw new NotImplementedException();
        }

        public AluguelDomain BuscarPorID(int idAluguel)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idAluguel)
        {
            throw new NotImplementedException();
        }

        public List<AluguelDomain> ListarTodos()
        {
            List<AluguelDomain> listaAluguel = new List<AluguelDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idAluguel, nomeCliente, sobrenomeCliente, cnhCliente, nomeMarca, nomeModelo, placaVeiculo, dataAquisicao, dataDevolucao FROM ALUGUEL INNER JOIN CLIENTE ON ALUGUEL.idCliente = CLIENTE.idCliente INNER JOIN VEICULO ON ALUGUEL.idVeiculo = VEICULO.idVeiculo INNER JOIN MARCA ON VEICULO.idMarca = MARCA.idMarca INNER JOIN MODELO ON VEICULO.idModelo = MODELO.idModelo";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        AluguelDomain aluguel = new AluguelDomain()
                        {
                            idAluguel = Convert.ToInt32(rdr[0]),
                            nomeCliente = rdr[1].ToString(),
                            sobrenomeCliente = rdr[2].ToString(),
                            cnhCliente = rdr[3].ToString(),
                            nomeMarca = rdr[4].ToString(),
                            nomeModelo = rdr[5].ToString(),
                            placaVeiculo = rdr[6].ToString(),
                            dataAquisicao = rdr[7].ToString(),
                            dataDevolucao = rdr[8].ToString()
                        };

                        listaAluguel.Add(aluguel);
                    }
                }
            }

            return listaAluguel;
        }

        public void Registrar(AluguelDomain novoAluguel)
        {
            throw new NotImplementedException();
        }
    }
}
