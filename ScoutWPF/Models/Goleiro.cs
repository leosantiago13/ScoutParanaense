using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutWPF.Models
{
    class Goleiro : BaseModel
    {
        public Jogador Titular { get; set; }
        public int Defesas { get; set; }
    }
}
