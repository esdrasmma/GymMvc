using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMvc.Models
{
    public class Modality
    {
        public int Id { get; set; }
        public string Nome { get; set; }
      
        public Instructor Instructor { get; set; }
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();

        public Modality(){ }

        public Modality(int id, string nome, Instructor instructor)
        {
            Id = id;
            Nome = nome;
            Instructor = instructor;
        }
    }
}
