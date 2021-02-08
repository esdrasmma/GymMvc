using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMvc.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public Membership Membership { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public Modality Modality { get; set; }

    

        public Payment()
        {
        }

        public Payment(int id, Membership membership, DateTime dataInicial, DateTime dataFinal, Modality modality)
        {
            Id = id;
            Membership = membership;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            Modality = modality;
        }
    }
}
