using senai_RENTAL_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Interfaces
{
    interface IEmpresaRepository
    {
        /// <summary>
        /// Lista todas as Empresas
        /// </summary>
        /// <returns>A lista de todos as Empresas</returns>
        List<EmpresaDomain> ListarTodos();

        /// <summary>
        /// Buscar uma Empresa pelo seu ID
        /// </summary>
        /// <param name="idEmpresa">ID da Empresa que irá ser pesquisada</param>
        /// <returns>O ID específico pesquisado</returns>
        EmpresaDomain BuscarPorID(int idEmpresa);

        /// <summary>
        /// Registra uma nova Empresa
        /// </summary>
        /// <param name="novaEmpresa">Objeto novaEmpresa com os novos dados</param>
        void Registrar(EmpresaDomain novaEmpresa);

        /// <summary>
        /// Atualiza uma Empresa que já está registrada
        /// </summary>
        /// <param name="empresaAtualizado">Objeto emrpesaAtualizado vem com os novos dados atualizados</param>
        void AtualizarIDCorpo(EmpresaDomain empresaAtualizado);

        /// <summary>
        /// Deleta uma Empresa registrada
        /// </summary>
        /// <param name="idEmpresa">ID da Empresa que será deletada</param>
        void Deletar(int idEmpresa);
    }
}
