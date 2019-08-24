using System.Collections.Generic;
using System.Threading.Tasks;
using Xfw.Models;

namespace Xfw.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAll();
    }

    public sealed class ItemService : IItemService
    {
        public async Task<List<Item>> GetAll()
        {
            await Task.Delay(2000);

            return new List<Item>
            {
                Item.Create("Cebolinha","Malandro", "http://turmadamonica.uol.com.br/wp-content/uploads/2012/12/monica_dest.jpg"),
                Item.Create("Magali", "Come de tudo e tudo!", "http://turmadamonica.uol.com.br/wp-content/uploads/2012/12/monica_dest.jpg"),
                Item.Create("Monica", "Monica bate em todo mundo!", "http://turmadamonica.uol.com.br/wp-content/uploads/2012/12/monica_dest.jpg"),
                Item.Create("Cascao", "Nao toma banho", "http://turmadamonica.uol.com.br/wp-content/uploads/2012/12/monica_dest.jpg"),
            };
        }
    }
}
