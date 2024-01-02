using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrudDotnet8.Data;
using BlazorCrudDotnet8.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotnet8.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;
        public GameService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Game>> GetAllGames()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }
    }
}