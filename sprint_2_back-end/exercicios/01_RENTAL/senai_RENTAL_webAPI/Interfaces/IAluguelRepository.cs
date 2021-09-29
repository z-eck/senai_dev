using senai_RENTAL_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Interfaces
{
    interface IAluguelRepository
    {
        /// <summary>
        /// Lista todos os Alugueis
        /// </summary>
        /// <returns>A lista de todos os Alugueis</returns>
        List<AluguelDomain> ListarTodos();

        /// <summary>
        /// Buscar um Aluguel pelo seu ID
        /// </summary>  
        /// <param name="idAluguel">ID do Aluguel que irá ser pesquisado</param>
        /// <returns>O ID específico pesquisado</returns>
        AluguelDomain BuscarPorID(int idAluguel);

        /// <summary>
        /// Registra um novo Aluguel
        /// </summary>
        /// <param name="novoAluguel">Objeto novoAluguel com os novos dados</param>
        void Registrar(AluguelDomain novoAluguel);

        /// <summary>
        /// Atualiza um Aluguel que já está registrado
        /// </summary>
        /// <param name="aluguelAtualizado">Objeto aluguelAtualizado vem com os novos dados atualizados</param>
        void AtualizarIDCorpo(AluguelDomain aluguelAtualizado);

        /// <summary>
        /// Deleta um Aluguel registrado
        /// </summary>
        /// <param name="idAluguel">ID do Aluguel que será deletado</param>
        void Deletar(int idAluguel);
    }
}
