using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrudDotnet8.Data;
using BlazorCrudDotnet8.Entity;

namespace BlazorCrudDotnet8.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
    }
}