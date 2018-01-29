using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeProject
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Belt of Truth",
                    Description="Protection",
                    AttributeType=Item.Attribute.Defense,
                    Value=20,
                    BodyPartType=Item.BodyPart.Body,
                    Range=0,
                    Image="truth.jpg"
                },
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Breastplate of righteousness",
                    Description="Guards the heart",
                    AttributeType=Item.Attribute.Defense,
                    Value=7,
                    BodyPartType=Item.BodyPart.Body,
                    Range=0,
                    Image="righteousness.jpg"
                },
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Gospel of Peace",
                    Description="Preparation",
                    AttributeType=Item.Attribute.Speed,
                    Value=12,
                    BodyPartType=Item.BodyPart.Feet,
                    Range=0,
                    Image="peace.jpg"
                },
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Shield of faith",
                    Description="Protection",
                    AttributeType=Item.Attribute.Defense,
                    Value=15,
                    BodyPartType=Item.BodyPart.OffHand,
                    Range=0,
                    Image="faith.jpg"
                },
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Helmet of salvation",
                    Description="Protection",
                    AttributeType=Item.Attribute.Defense,
                    Value=10,
                    BodyPartType=Item.BodyPart.Head,
                    Range=0,
                    Image="salvation.jpg"
                },
                new Item { Id = Guid.NewGuid().ToString(),
                    Text = "Sword of the Spirit",
                    Description="Word of God",
                    AttributeType=Item.Attribute.Attack,
                    Value=50,
                    BodyPartType=Item.BodyPart.MainHand,
                    Range=0,
                    Image="swordOfSpirit.jpg"
                },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
