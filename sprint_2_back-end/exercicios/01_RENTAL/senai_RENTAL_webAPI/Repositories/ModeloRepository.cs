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
    /// Classe definida para possuir a responsabilidade do repositório "Modelo"
    /// </summary>
    public class ModeloRepository : IModeloRepository
    {
        /// <summary>
        /// String de conexão com o BDD que recebe os parâmetros
        /// </summary>
        private string stringConexao = @"CAL\SQLEXPRESS; initial catalog=RENTAL_T; user Id=sa; pwd=Senai@132";

        public void AtualizarIDCorpo(ModeloDomain modeloAtualizado)
        {
            throw new NotImplementedException();
        }

        public ModeloDomain BuscarPorID(int idModelo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idModelo)
        {
            throw new NotImplementedException();
        }

        public List<ModeloDomain> ListarTodos()
        {
            List<ModeloDomain> listaModelo = new List<ModeloDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idModelo, nomeModelo FROM MODELO";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        ModeloDomain modelo = new ModeloDomain()
                        {
                            idModelo = Convert.ToInt32(rdr[0]),
                            nomeModelo = rdr[1].ToString(),
                        };

                        listaModelo.Add(modelo);
                    }
                }
            }

            return listaModelo;
        }

        public void Registrar(ModeloDomain novoModelo)
        {
            throw new NotImplementedException();
        }
    }
}
