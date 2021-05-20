using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteASPNET.Models
{
    public class Cliente
    {
        public int CLI_ID { get; set; }
        public string CLI_NOME { get; set; }
        public DateTime CLI_DATANASCIMENTO { get; set; }
        public bool CLI_ATIVO { get; set; }

    }
}
