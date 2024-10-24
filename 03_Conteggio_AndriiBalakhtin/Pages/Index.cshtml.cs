using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _03_Conteggio_AndriiBalakhtin.Pages
{
    public class IndexModel : PageModel
    {
        public class Product
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int Counter { get; set; }
        }

        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Counter = 0 },
            new Product { Id = 2, Name = "Product 2", Counter = 0 },
            new Product { Id = 3, Name = "Product 3", Counter = 0 },
            new Product { Id = 4, Name = "Product 4", Counter = 0 },
            new Product { Id = 5, Name = "Product 5", Counter = 0 },
        };

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            int productId = Convert.ToInt32(Request.Form["productId"]);

            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                product.Counter++;
            }

            return RedirectToPage();
        }
    }
}
