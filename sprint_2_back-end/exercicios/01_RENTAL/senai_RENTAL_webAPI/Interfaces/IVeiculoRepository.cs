using senai_RENTAL_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Interfaces
{
    interface IVeiculoRepository
    {
        /// <summary>
        /// Lista todos os Veiculos
        /// </summary>
        /// <returns>A lista de todos os Veiculos</returns>
        List<VeiculoDomain> ListarTodos();

        /// <summary>
        /// Buscar um Veiculo pelo seu ID
        /// </summary>  
        /// <param name="idVeiculo">ID do Veiculo que irá ser pesquisado</param>
        /// <returns>O ID específico pesquisado</returns>
        VeiculoDomain BuscarPorID(int idVeiculo);

        /// <summary>
        /// Registra um novo Veiculo
        /// </summary>
        /// <param name="novoVeiculo">Objeto novoVeiculo com os novos dados</param>
        void Registrar(VeiculoDomain novoVeiculo);

        /// <summary>
        /// Atualiza um Veiculo que já está registrado
        /// </summary>
        /// <param name="veiculoAtualizado">Objeto veiculoAtualizado vem com os novos dados atualizados</param>
        void AtualizarIDCorpo(VeiculoDomain veiculoAtualizado);

        /// <summary>
        /// Deleta um Veiculo registrado
        /// </summary>
        /// <param name="idVeiculo">ID do Veiculo que será deletado</param>
        void Deletar(int idVeiculo);
    }
}
