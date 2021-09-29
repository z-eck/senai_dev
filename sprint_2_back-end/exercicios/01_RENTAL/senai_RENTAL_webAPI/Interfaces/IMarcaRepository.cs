using senai_RENTAL_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório MarcaRepository
    /// </summary>
    interface IMarcaRepository
    {
        /// <summary>
        /// Lista todas as Marcas
        /// </summary>
        /// <returns>A lista de todos as Marcas</returns>
        List<MarcaDomain> ListarTodos();

        /// <summary>
        /// Buscar uma Marca pelo seu ID
        /// </summary>
        /// <param name="idMarca">ID da Marca que irá ser pesquisada</param>
        /// <returns>O ID específico pesquisado</returns>
        MarcaDomain BuscarPorID(int idMarca);

        /// <summary>
        /// Registra uma nova Marca
        /// </summary>
        /// <param name="novaMarca">Objeto novaMarca com os novos dados</param>
        void Registrar(MarcaDomain novaMarca);

        /// <summary>
        /// Atualiza uma Marca que já está registrada
        /// </summary>
        /// <param name="marcaAtualizado">Objeto marcaAtualizado vem com os novos dados atualizados</param>
        void AtualizarIDCorpo(MarcaDomain marcaAtualizado);

        /// <summary>
        /// Deleta uma Marca registrada
        /// </summary>
        /// <param name="idMarca">ID da Marca que será deletada</param>
        void Deletar(int idMarca);
    }
}
