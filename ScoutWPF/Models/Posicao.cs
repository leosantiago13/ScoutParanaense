using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScoutWPF.Models
{
    [Table("Posicao")]
    class Posicao : BaseModel
    {
        public string NomePosicao { get; set; }
    }
}
