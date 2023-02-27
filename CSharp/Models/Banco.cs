using System.Collections.Generic;

namespace LH_Pets.Models
{
    public class Banco
    {
        public List<string> Clientes { get; set; }

        public Banco()
        {
            Clientes = new List<string>();
            Clientes.Add("Cliente 1");
            Clientes.Add("Cliente 2");
            Clientes.Add("Cliente 3");
        }
    }
}

