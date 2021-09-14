using RazorPages.Models;
using System.Collections.Generic;

namespace RazorPages.Services
{
    public class ProductService : IProductService
    {
        public List<ProductItem> GetProductItems()
        {
            return new List<ProductItem>()
            {
                new ProductItem()
                {
                    Id = 1,
                    Slug = "long-sleev-shirt",
                    Name = "Long sleev shirt",
                    Discount = 25,
                    Summary = "VINTAGE STYLE: This heavyweight 6.5 ounce men's brawny.",
                    Description = @"Lorem ipsum dolor sit amet consectetur, adipisicing elit. Iste atque ea quis
          molestias. Fugiat pariatur maxime quis culpa corporis vitae repudiandae
          aliquam voluptatem veniam, est atque cumque eum delectus sint!",
                    ImageFile = "longsleevshirt.png"
                },
                new ProductItem()
                {
                    Id = 2,
                    Slug = "Black-top-caps",
                    Name = "Black top caps",
                    Discount = 15,
                    Summary = "The 'Blacktop' Collection is for the road warrior, weekend crusier.",
                    Description = @"Lorem ipsum dolor sit amet consectetur, adipisicing elit. Iste atque ea quis
          molestias. Fugiat pariatur maxime quis culpa corporis vitae repudiandae
          aliquam voluptatem veniam, est atque cumque eum delectus sint!",
                    ImageFile = "blacktopcaps.png"
                },
                new ProductItem()
                {
                    Id = 3,
                    Slug = "Kiton-sui-suit",
                    Name = "Kiton sui suit",
                    Discount = 90,
                    Summary = "100% made in italy, tailored suits at the best prices available online with free.",
                    Description = @"Lorem ipsum dolor sit amet consectetur, adipisicing elit. Iste atque ea quis
          molestias. Fugiat pariatur maxime quis culpa corporis vitae repudiandae
          aliquam voluptatem veniam, est atque cumque eum delectus sint!",
                    ImageFile = "kitonsuisuit.png"
                }
            };
        }
    }
}