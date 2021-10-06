using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuThiThanh103.Models;

namespace VuThiThanh103.Data
{
    public class VuThiThanh103Context : DbContext
    {
        public VuThiThanh103Context (DbContextOptions<VuThiThanh103Context> options)
            : base(options)
        {
        }

        public DbSet<VuThiThanh103.Models.PersonVTT103> PersonVTT103 { get; set; }

        public DbSet<VuThiThanh103.Models.VTT1103> VTT1103 { get; set; }
    }
}
