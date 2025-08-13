using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_dapper.Models
{
    public class FilmesRequest 
    {
        public string Nome { get; set; }

        public int Ano { get; set; }

        public int ProdutoraId { get; set; }
    }
}