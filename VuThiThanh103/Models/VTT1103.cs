using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VuThiThanh103.Models
{
    public class VTT1103
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string VTTId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string VTTName { get; set; }

        public Boolean VTTGender { get; set; }
    }
}
