using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutWPF.Models
{
    class Jogo : BaseModel
    {
        public Time TimeA { get; set; }
        public Time TimeB { get; set; }
        public int GolsTimeA { get; set; }
        public int GolsTimeB { get; set; }
        public Jogador Goleiro { get; set; }
        public List<Gol> Gols { get; set; }
    }
}