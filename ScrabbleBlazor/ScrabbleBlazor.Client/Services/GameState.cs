using Microsoft.AspNetCore.Blazor;
using ScrabbleBlazor.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScrabbleBlazor.Client.Services
{
    public class GameState
    {

        private readonly HttpClient http;
        public GameState(HttpClient httpInstance)
        {
            http = httpInstance;
        }

        public async Task<Player> RegisterUser(string identifier)
        {
            return await http.PostJsonAsync<Player>("/api/currentstate/register", identifier);
            
        }

    }
}
