using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SamplePama.Models;
using System.Data.SqlClient;
using Dapper;

namespace SamplePama.DAL
{
    public class PegawaiDAL : IPegawai
    {
        private IConfiguration _config;
        public PegawaiDAL(IConfiguration config)
        {
            _config = config;
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
            using(SqlConnection conn = new SqlConnection(GetConn()))
            {
                var strSql = @"select * from Pegawai
                               order by FirstName";
                return conn.Query<Pegawai>(strSql);   
            }
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
