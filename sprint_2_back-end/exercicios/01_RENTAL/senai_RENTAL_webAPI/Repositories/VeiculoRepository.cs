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
    /// Classe definida para possuir a responsabilidade do repositório "Veículo"
    /// </summary>
    public class VeiculoRepository : IVeiculoRepository
    {
        /// <summary>
        /// String de conexão com o BDD que recebe os parâmetros
        /// </summary>
        private string stringConexao = @"CAL\SQLEXPRESS; initial catalog=RENTAL_T; user Id=sa; pwd=Senai@132";

        public void AtualizarIDCorpo(VeiculoDomain veiculoAtualizado)
        {
            throw new NotImplementedException();
        }

        public VeiculoDomain BuscarPorID(int idVeiculo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idVeiculo)
        {
            throw new NotImplementedException();
        }

        public List<VeiculoDomain> ListarTodos()
        {
            List<VeiculoDomain> listaVeiculo = new List<VeiculoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idVeiculo, nomeMarca, nomeModelo, placaVeiculo FROM VEICULO INNER JOIN MARCA ON VEICULO.idMarca = MARCA.idMarca INNER JOIN MODELO ON VEICULO.idModelo = MODELO.idModelo";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        VeiculoDomain veiculo = new VeiculoDomain()
                        {
                            idVeiculo = Convert.ToInt32(rdr[0]),
                            nomeMarca = rdr[1].ToString(),
                            nomeModelo = rdr[2].ToString(),
                            placaVeiculo = rdr[3].ToString(),
                        };

                        listaVeiculo.Add(veiculo);
                    }
                }
            }

            return listaVeiculo;
        }

        public void Registrar(VeiculoDomain novoVeiculo)
        {
            throw new NotImplementedException();
        }
    }
}
