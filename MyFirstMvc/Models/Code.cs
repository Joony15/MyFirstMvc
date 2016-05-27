using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MyFirstMvc.Models
{
    public class Code
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
     public class CodeDBContext : DbContext
    {
        public DbSet<Code> Codes { get; set; }
    }
}