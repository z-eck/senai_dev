using senai_RENTAL_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ClienteRepository
    /// </summary>
    interface IClienteRepository
    {
        /// <summary>
        /// Lista todos os Clientes
        /// </summary>
        /// <returns>A lista de todos os cliente</returns>
        List<ClienteDomain> ListarTodos();

        /// <summary>
        /// Buscar um Cliente pelo seu ID
        /// </summary>
        /// <param name="idCliente">ID do cliente que irá ser pesquisado</param>
        /// <returns>O ID específico pesquisado</returns>
        ClienteDomain BuscarPorID(int idCliente);

        /// <summary>
        /// Registra um novo Cliente
        /// </summary>
        /// <param name="novoCliente">Objeto novoCliente com os novos dados</param>
        void Registrar(ClienteDomain novoCliente);

        /// <summary>
        /// Atualiza um Cliente que já está registrado
        /// </summary>
        /// <param name="clienteAtualizado">Objeto clienteAtualizado vem com os novos dados atualizados</param>
        void AtualizarIDCorpo(ClienteDomain clienteAtualizado);

        /// <summary>
        /// Deleta um Cliente registrado
        /// </summary>
        /// <param name="idCliente">ID do Cliente que será deletado</param>
        void Deletar(int idCliente);
    }
}
