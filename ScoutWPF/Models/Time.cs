using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ScoutWPF.Models
{
    [Table("Times")]
    class Time : BaseModel
    {
        public Time()
        {
            Jogadores = new List<Jogador>();
        }
        public string Nome { get; set; }
        public DateTime DataDeFundacao { get; set; }
        public int Divisao { get; set; }
        public string Cores { get; set; }
        public List<Jogador> Jogadores { get; set; }
    }
}
