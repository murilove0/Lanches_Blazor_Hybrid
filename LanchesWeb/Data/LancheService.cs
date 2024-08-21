using LanchesLibrary.Data;

namespace LanchesWeb.Data
{
    public class LancheService : ILancheService
    {
        private readonly HttpClient _httpClient = new();
        public async Task<List<Lanche>> LoadLanchesAsync()
        {
            var lanches = await _httpClient.GetFromJsonAsync<List<Lanche>>(
                "https://https://www.macoratti.net/Sistemas/lanches.json");

            return lanches!.ToList();
        }
    }
}
