using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutWPF.Models
{
    class Gol : BaseModel
    {
        public Jogador Marcador { get; set; }
        public Jogador Passador { get; set; }
    }
}
