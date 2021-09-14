using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;
using System.Collections.Generic;

namespace RazorPages.Pages
{
    public class ProductModel : PageModel
    {
        private IProductService productService;

        public List<ProductItem> Products { get; set; }

        public ProductModel(IProductService productService)
        {
            this.productService = productService;
        }

        public void OnGet()
        {
            Products = productService.GetProductItems();
        }
    }
}

