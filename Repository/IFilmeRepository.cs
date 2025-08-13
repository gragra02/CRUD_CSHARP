using dotnet_dapper.Models;


namespace dotnet_dapper.Repository
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<FilmesResponse>> BuscaFilmesAsync();
        Task<FilmesResponse> BuscaFilmesAsync(int id);
        Task<bool> AdicionaAsync(FilmesRequest request);
        Task<bool> AtualizarAsync(FilmesRequest request, int id);
        Task<bool> DeletarAsync(int id);
    }
}