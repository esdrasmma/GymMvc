﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMvc.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public ICollection<Modality> Modalities { get; set; } = new List<Modality>();

        public Instructor() { }

        public Instructor(int id, string nome, string cPF, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
        }
    }
}
