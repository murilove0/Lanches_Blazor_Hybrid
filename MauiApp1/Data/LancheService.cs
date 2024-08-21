using LanchesLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class LancheService : ILancheService
    {
        public async Task<List<Lanche>>? LoadLanchesAsync()
        {
            await Task.Delay(1000);
            var lanches = new[]
            {
                new Lanche() {Name = "Cheese Burguer", Description = "Pão, Hamburguer tradicional com Queijo"},
                new Lanche() {Name = "Cheese Burguer Duplo", Description = "Pão, Dois Hamburgueres tradicionais com Queijo"},
                new Lanche() {Name = "Cheese Burguer Salada", Description = "Pão, Hamburguer tradicional com Queijo, Alface e Tomate"},
            };
            return lanches.ToList();
        }
        
    }
}
