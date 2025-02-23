
using System.Collections;
using e_shop.DataAccess;
using e_shop.DataAccess.Services;
using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Customer;
using e_shop.Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using var context = new ShopContext();

var service = new ProductService(context);

var categoryService = new CategoryService(context);

var customerService = new CustomerService(context);

var cartService = new CartService(context);

var orderService = new OrderService(context);


// service.Add(new Product()
// {
//     //Id = 1,
//     ProductName = "Orange2",
//     DiscountPrice = 10,
//     RegularPrice = 10,
//     ProductDescription = "some desc",
//     ProductNote = "some note",
//     SKU = "sku_1",
//     ShortDescription = "short desc",
//     Quantity = 1,
//     Published = true,
//     CreatedAt = DateTime.UtcNow,
//     CreatedBy = 1,
//     ProductWeight = 1,
//     UpdatedAt = DateTime.UtcNow,
//     UpdatedBy = 1
// });
// context.SaveChanges();

// var product = (new Product()
// {
//     Id = 2,
//     ProductName = "Orange1",
//     DiscountPrice = 10,
//     RegularPrice = 10,
//     ProductWeight = 1,
//     SKU = "sku_1",
//     ProductDescription = "some desc",
//     ProductNote = "some note",
//     ShortDescription = "short desc",
//     Quantity = 1,
//     Published = true,
//     
//     Categories = new List<Category>()
//     {
//         new Category()
//         {
//             Id = 1,
//             CategoryName = "Category 1"
//         }
//     }
// });



// var order = (new Order()
// {
//     Id = 1,
//     OrderStatusId = 1,
//     CreatedAt = DateTime.Now
//     
// }); 
//
// context.SaveChanges();





// var cartItem = new List<CartItem>()
// {
//     new()
//     {
//         Quantity = 3,
//         Product = new Product()
//         {
//             Quantity = 100,
//             DiscountPrice = 439,
//             ProductDescription = "1 year warranty",
//             ProductName = "iPhone Se4",
//             ProductNote = "New iPhone with new Apple Modem",
//             ProductWeight = 6.8M,
//             Published = true,
//             SKU = "88888888",
//             RegularPrice = 499,
//             CreatedBy = 1,
//             
//         }
//     }
// };
//
// var cart = new Cart()
// {
//     CustomerId = 1,
//     CartItems = cartItem,
// };
//
// await cartService.AddCart(cart);
// await cartService.SaveChanges();

// await cartService.AddCartItem(cartItem);


//CategoryService.Add(Category);
//CategoryService.SaveChanges();

// var costumerAddress = new CustomerAddress()
// {
//     CustomerId = 1,
//     AddressLine1 = "Mirobod 12, Tashkent, Uzbekistan",
//     City = "Tashkent",
//     Country = "Uzbekistan",
//     PhoneNumber = "+998999999999",
//     DialCode = "9999",
//     PostalCode = "100000",
// };

// CustomerService.Add(Customer);
// CustomerService.SaveChanges();

// var customer = new Customer()
// {
//     FirstName = "John",
//     LastName = "Doe",
//     PhoneNumber = "+998999999999",
//     PasswordHash = "password",
//     CustomerAddress = new List<CustomerAddress>()
//     {
//         new CustomerAddress()
//         {
//             AddressLine1 = "Mirobod",
//             City = "Tashkent",
//             Country = "Uzbekistan",
//             PhoneNumber = "+998999999999",
//             DialCode = "9999",
//             PostalCode = "100000",
//         }
//     }
// };

// await customerService.AddCustomer(customer);
// await CustomerService.AddCustomerAddress(customerAddress);
// customerService.SaveChanges();


// public partial class Program
// {
//     public static void Main(string[] args)
//     {
//         void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             optionsBuilder
//                 .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database =TestDb_1; Trusted_Connection = True; ")
//                 .LogTo(Console.WriteLine, LogLevel.Information);
//         }
//
//         using var context = new ShopContext();
//         
//         var categories = context
//             .Categories
//             .ToList();
//         
//         foreach (var category in categories)
//         {
//             Console.WriteLine($"\t{category.Id}, {category.CategoryName}");
//             
//             context
//                 .Entry(category)
//                 .Collection(c => c.Products)
//                 .Load();
//             foreach (var product in category.Products)
//             {
//                 Console.WriteLine($"\t{product.Id}, {product.ProductName}");
//             }
//         }
//     }
// }


#region ChangeTrackerLesson


//  var product = context.Products.FirstOrDefault(); //state - 1
//  Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//
//  var product1 = context.Products.AsNoTracking().FirstOrDefault();
//
// context.Products.Remove(product1);
// context.ChangeTracker.DetectChanges();
// Console.WriteLine(context.ChangeTracker.DebugView.LongView);

// var lastProduct = context.Products.Skip(1).FirstOrDefault();
//
// lastProduct.ProductWeight = 3;
//
// context.Products.Remove(lastProduct);
//
// context.ChangeTracker.DetectChanges();
// Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//
// context.SaveChanges();
//
// context.ChangeTracker.DetectChanges();
// Console.WriteLine(context.ChangeTracker.DebugView.LongView);


// context.Update(product);
// Console.WriteLine(context.ChangeTracker.DebugView.LongView);
// context.SaveChanges();

// Console.WriteLine(context.ChangeTracker.DebugView.LongView);
// context.Attach(product);
//
// Console.WriteLine(context.ChangeTracker.DebugView.LongView);
// service.SaveChanges();
//
// Console.WriteLine(context.ChangeTracker.DebugView.LongView);
#endregion


