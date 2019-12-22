using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje.Models.Model
{
    
    
    public partial class Kimlik
    {
        
        public int KimlikId { get; set; }
        
        public string Title { get; set; }
        
        public string Keywords { get; set; }
        
        public string Description { get; set; }
        
        public string LogoURL { get; set; }
        
        public string Unvan { get; set; }
    }
}
