using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePama.Models
{
    public class Pegawai
    {
        public int PegawaiID { get; set; }
        public int DepartmentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
    }
}
