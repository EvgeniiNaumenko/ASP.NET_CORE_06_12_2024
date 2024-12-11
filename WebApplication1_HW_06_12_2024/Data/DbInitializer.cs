using WebApplication1_HW_06_12_2024.Models;

namespace WebApplication1_HW_06_12_2024.Data
{
    public static class DbInitializer
    {
        public static void Seed(BookStoreContext context)
    {
        if (!context.Books.Any())
        {
            context.Books.AddRange(
                new Book
                {
                    Title = "Naruto, Vol. 1",
                    Author = "Masashi Kishimoto",
                    Genre = "Shounen",
                    Price = 7.99m
                },
                new Book
                {
                    Title = "Attack on Titan, Vol. 1",
                    Author = "Hajime Isayama",
                    Genre = "Action",
                    Price = 9.99m
                },
                new Book
                {
                    Title = "One Piece, Vol. 1",
                    Author = "Eiichiro Oda",
                    Genre = "Adventure",
                    Price = 8.99m
                },
                new Book
                {
                    Title = "Demon Slayer: Kimetsu no Yaiba, Vol. 1",
                    Author = "Koyoharu Gotouge",
                    Genre = "Fantasy",
                    Price = 10.99m
                },
                new Book
                {
                    Title = "My Hero Academia, Vol. 1",
                    Author = "Kohei Horikoshi",
                    Genre = "Superhero",
                    Price = 8.49m
                }
            );

            context.SaveChanges();
        }
    }
    }
}
