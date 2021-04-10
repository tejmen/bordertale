using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Articles
{
    public class Item
    {
        public string title;
        public string name;
        public int price;

        public void Acquire()
        {
            MainGame.player.inventory.Append(this);
        }
        
        public void Remove()
        {
            MainGame.player.inventory.Remove(this);
        }
    }
}
