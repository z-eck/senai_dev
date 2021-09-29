using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Domains
{
    /// <summary>
    /// Classe voltada a entidade "Aluguel" na empresa Rental
    /// </summary>
    public class AluguelDomain
    {
        internal string nomeCliente;
        internal string sobrenomeCliente;
        internal string cnhCliente;
        internal string nomeMarca;
        internal string nomeModelo;
        internal string placaVeiculo;

        public int idAluguel { get; set; }
        public int idCliente { get; set; }
        public int idVeiculo { get; set; }
        public string dataAquisicao { get; set; }
        public string dataDevolucao { get; set; }
    }
}
