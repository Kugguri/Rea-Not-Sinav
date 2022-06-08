using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Notlar.Models
{
    public class Not
    {
        [Key]
        public int NotId { get; set; }
        public string NotBaslik { get; set; }
        public string NotIcerik { get; set; }
    }
}
