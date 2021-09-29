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
    /// Classe definida para possuir a responsabilidade do repositório "Marca"
    /// </summary>
    public class MarcaRepository : IMarcaRepository
    {
        /// <summary>
        /// String de conexão com o BDD que recebe os parâmetros
        /// </summary>
        private string stringConexao = @"CAL\SQLEXPRESS; initial catalog=RENTAL_T; user Id=sa; pwd=Senai@132";

        public void AtualizarIDCorpo(MarcaDomain marcaAtualizado)
        {
            throw new NotImplementedException();
        }

        public MarcaDomain BuscarPorID(int idMarca)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idMarca)
        {
            throw new NotImplementedException();
        }

        public List<MarcaDomain> ListarTodos()
        {
            List<MarcaDomain> listaMarca = new List<MarcaDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idMarca, nomeMarca FROM MARCA";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        MarcaDomain marca = new MarcaDomain()
                        {
                            idMarca = Convert.ToInt32(rdr[0]),
                            nomeMarca = rdr[1].ToString(),
                        };

                        listaMarca.Add(marca);
                    }
                }
            }

            return listaMarca;
        }

        public void Registrar(MarcaDomain novaMarca)
        {
            throw new NotImplementedException();
        }
    }
}
