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
            return await http.GetJsonAsync<Player>("/api/currentstate/register?identifier=" + identifier);
        }

        public async Task SubmitWord(string identifier, string word)
        {
            await http.GetAsync(string.Format("/api/currentstate/SubmitWord?identifier={0}&word={1}", identifier, word));
        }
        

    }
}
