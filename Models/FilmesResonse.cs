using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_dapper.Models
{
    public class FilmesResponse
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Ano { get; set; }

        public string Produtora { get; set; }
    }
}