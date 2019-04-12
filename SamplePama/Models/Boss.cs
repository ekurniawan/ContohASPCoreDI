using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePama.Models
{
    public class Boss
    {
        public int BossID { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
    }
}
