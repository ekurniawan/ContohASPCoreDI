using SamplePama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePama.DAL
{
    public interface IPegawai
    {
        IEnumerable<Pegawai> GetAll();
        Pegawai GetById(string id);
        void Insert(Pegawai obj);
        void Update(Pegawai obj);
        void Delete(string id);
    }
}
