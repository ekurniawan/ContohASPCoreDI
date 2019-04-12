using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SamplePama.Models;

namespace SamplePama.DAL
{
    public class BossDAL : IBoss
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Task obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Boss> GetAll()
        {
            var data = new List<Boss>()
            {
                new Boss {BossID=1,Nama="Budi"},
                new Boss {BossID=2,Nama="Joko"}
            };
            return data;
        }

        public string GetBoss()
        {
            throw new NotImplementedException();
        }

        public Boss GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Boss obj)
        {
            throw new NotImplementedException();
        }
    }
}
