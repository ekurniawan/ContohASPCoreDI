using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SamplePama.Models;
using System.Data.SqlClient;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace SamplePama.DAL
{
    public class PegawaiDAL : IPegawai
    {
        private IConfiguration _config;
        private PamaDataContext _db;

        public PegawaiDAL(IConfiguration config,PamaDataContext db)
        {
            _config = config;
            _db = db;
        }

        private string GetConn()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pegawai> GetAll()
        {
            /*using(SqlConnection conn = new SqlConnection(GetConn()))
            {
                var strSql = @"select * from Pegawai
                               order by FirstName";
                return conn.Query<Pegawai>(strSql);   
            }*/

            var data = from p in _db.Pegawai.Include(p=>p.Department)
                       select p;

            return data;
        }

        public Pegawai GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pegawai obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Pegawai obj)
        {
            throw new NotImplementedException();
        }
    }
}
