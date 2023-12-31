using BlazorCRUDNet8.Entities;

namespace BlazorCRUDNet8.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> AddGame(Game game);
    }
}
