using BlazorCRUDNet8.Data;
using BlazorCRUDNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDNet8.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _dataContext;

        public GameService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Game> AddGame(Game game)
        {
            _dataContext.Games.Add(game);
            await _dataContext.SaveChangesAsync();
            return game;
        }

        public async Task<List<Game>> GetAllGames()
        {
            var games = await _dataContext.Games.ToListAsync();
            return games;
        }
    }
}
