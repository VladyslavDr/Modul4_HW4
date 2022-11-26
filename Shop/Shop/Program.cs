using Microsoft.EntityFrameworkCore;
using Shop.Data;

var factory = new ApplicationDbContextFactory();

using (var context = factory.CreateDbContext(new string[0]))
{
    var products = context.Categories.ToList();
    foreach (var product in products)
    {
        Console.WriteLine(product.CategoryName);
    }

    /*
    context.Remove(products[0]);
    context.SaveChanges();
    */
}