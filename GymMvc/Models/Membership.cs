using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMvc.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public ICollection<Payment> Payments { get; set; } = new List<Payment>();

        public Membership() { }

        public Membership(int id, string cPF, string nome, string email, string telefone, DateTime dataNascimento)
        {
            Id = id;
            CPF = cPF;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }
    }
}
