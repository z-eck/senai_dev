using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Domains
{
    /// <summary>
    /// Classe voltada a entidade "Veiculo" na empresa Rental
    /// </summary>
    public class VeiculoDomain
    {
        internal string nomeMarca;
        internal string nomeModelo;

        public int idVeiculo { get; set; }
        public int idMarca { get; set; }
        public int idModelo { get; set; }
        public string placaVeiculo { get; set; }
        public MarcaDomain marca { get; set; }
        public ModeloDomain modelo { get; set; }
    }
}
