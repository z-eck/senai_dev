using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_RENTAL_webAPI.Domains
{
    /// <summary>
    /// Classe voltada a entidade "Cliente" na empresa Rental
    /// </summary>
    public class ClienteDomain
    {
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }
        public string sobrenomeCliente { get; set; }
        public string cpfCliente { get; set; }
        public string cnhCliente { get; set; }
    }
}
