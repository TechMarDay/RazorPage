using RazorPages.Models;
using System.Collections.Generic;

namespace RazorPages.Services
{
    public interface IProductService
    {
        List<ProductItem> GetProductItems();
    }
}