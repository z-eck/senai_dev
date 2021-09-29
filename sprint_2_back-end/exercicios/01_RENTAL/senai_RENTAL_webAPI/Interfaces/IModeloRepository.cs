using senai_RENTAL_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ModeloRepository
    /// </summary>
    interface IModeloRepository
    {
        /// <summary>
        /// Lista todos os Modelos
        /// </summary>
        /// <returns>A lista de todos os Modelos</returns>
        List<ModeloDomain> ListarTodos();

        /// <summary>
        /// Buscar um Modelo pelo seu ID
        /// </summary>  
        /// <param name="idModelo">ID do Modelo que irá ser pesquisado</param>
        /// <returns>O ID específico pesquisado</returns>
        ModeloDomain BuscarPorID(int idModelo);

        /// <summary>
        /// Registra um novo Modelo
        /// </summary>
        /// <param name="novoModelo">Objeto novoModelo com os novos dados</param>
        void Registrar(ModeloDomain novoModelo);

        /// <summary>
        /// Atualiza um Modelo que já está registrado
        /// </summary>
        /// <param name="modeloAtualizado">Objeto modeloAtualizado vem com os novos dados atualizados</param>
        void AtualizarIDCorpo(ModeloDomain modeloAtualizado);

        /// <summary>
        /// Deleta um Modelo registrado
        /// </summary>
        /// <param name="idModelo">ID do Modelo que será deletado</param>
        void Deletar(int idModelo);
    }
}
