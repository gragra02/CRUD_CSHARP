
using System.Data.SqlClient;
using Dapper;
using dotnet_dapper.Models;

namespace dotnet_dapper.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public FilmeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("SqlConnection");
            // Initialize parameters or dependencies here
        }
        public Task<bool> AdicionaAsync(FilmesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarAsync(FilmesRequest request, int id)
        {
            throw new NotImplementedException();
        }

     public async Task<IEnumerable<FilmesResponse>> BuscaFilmesAsync()
{
    string sql = @"SELECT 
                    f.id Id,
                    f.nome Nome,
                    f.ano Ano,
                    p.nome Produtora
                FROM tb_filmes f
                JOIN tb_produtora p ON f.id_produtora = p.id";
    using var con = new SqlConnection(connectionString);
    return await con.QueryAsync<FilmesResponse>(sql);
}
            public async Task<FilmesResponse> BuscaFilmesAsync(int id)
        {
            string sql = @"SELECT 
                            f.id Id,
                            f.nome Nome,
                            f.ano Ano,
                            p.nome Produtora
                        FROM tb_filmes f
                        JOIN tb_produtora p ON f.id_produtora = p.id
                        WHERE f.id = @Id";

         using var con = new SqlConnection(connectionString);
            var result = await con.QueryFirstOrDefaultAsync<FilmesResponse>(sql, new { Id = id });
            if (result == null)
            {
                throw new InvalidOperationException($"Filme com id {id} não encontrado.");
            }
            return result;
        }

        public Task<bool> DeletarAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

