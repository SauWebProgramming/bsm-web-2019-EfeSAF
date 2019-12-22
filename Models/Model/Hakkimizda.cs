using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje.Models.Model
{
    [Table("Hakkimizda")]
    public class Hakkimizda
    {
        
        public int HakkimizdaId { get; set; }
        
        public string Aciklama { get; set; }
        
    }
}