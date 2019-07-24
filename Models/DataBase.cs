using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class DataBase : DbContext
    {
        public DataBase() : base("dataBase")
        {

        }

        public DbSet<Cidade> cidades { get; set; }
    }
}