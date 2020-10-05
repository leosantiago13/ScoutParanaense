using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScoutWPF.Models
{
    class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}