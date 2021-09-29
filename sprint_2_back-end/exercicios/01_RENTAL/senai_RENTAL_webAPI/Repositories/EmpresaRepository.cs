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
    /// Classe definida para possuir a responsabilidade do repositório "Empresa"
    /// </summary>
    public class EmpresaRepository : IEmpresaRepository
    {
        /// <summary>
        /// String de conexão com o BDD que recebe os parâmetros
        /// </summary>
        private string stringConexao = @"CAL\SQLEXPRESS; initial catalog=RENTAL_T; user Id=sa; pwd=Senai@132";

        public void AtualizarIDCorpo(EmpresaDomain empresaAtualizado)
        {
            throw new NotImplementedException();
        }

        public EmpresaDomain BuscarPorID(int idEmpresa)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idEmpresa)
        {
            throw new NotImplementedException();
        }

        public List<EmpresaDomain> ListarTodos()
        {
            List<EmpresaDomain> listaEmpresa = new List<EmpresaDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idEmpresa, nomeEmpresa FROM EMPRESA";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        EmpresaDomain empresa = new EmpresaDomain()
                        {
                            idEmpresa = Convert.ToInt32(rdr[0]),
                            nomeEmpresa = rdr[1].ToString(),
                        };

                        listaEmpresa.Add(empresa);
                    }
                }
            }

            return listaEmpresa;
        }

        public void Registrar(EmpresaDomain novaEmpresa)
        {
            throw new NotImplementedException();
        }
    }
}
