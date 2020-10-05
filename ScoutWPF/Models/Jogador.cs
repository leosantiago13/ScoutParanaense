using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ScoutWPF.Models
{
    [Table("Jogadores")]
    class Jogador : BaseModel
    {
        public Jogador()
        {
            Posicao = new Posicao();
            Times = new List<Time>();
        }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
        public Posicao Posicao { get; set; }
        public List<Time> Times { get; set; }
        public List<Jogo> Jogos { get; set; }
    }
}
