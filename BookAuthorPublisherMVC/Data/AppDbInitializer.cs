using BookAuthorPublisherMVC.Models;

namespace BookAuthorPublisherMVC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Publishers
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            Name = "Publisher 1"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 2"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 3"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 4"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 5"
                        },
                    });
                    context.SaveChanges();
                }
                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            Name = "Author 1"
                        },
                        new Author()
                        {
                            Name = "Author 2"
                        },
                        new Author()
                        {
                            Name = "Author 3"
                        },
                        new Author()
                        {
                            Name = "Actor 4"
                        },
                        new Author()
                        {
                            Name = "Actor 5"
                        }
                    });
                    context.SaveChanges();
                }
                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "Book 1",
                            Price = 39.50,
                            ReleaseDate = DateTime.Now.AddDays(-10),
                            PublisherId = 1
                        },
                        new Book()
                        {
                            Name = "Book 2",
                            Price = 24.50,
                            ReleaseDate = DateTime.Now.AddDays(-20),
                            PublisherId = 1
                        },
                        new Book()
                        {
                            Name = "Book 3",
                            Price = 139.50,
                            ReleaseDate = DateTime.Now.AddDays(10),
                            PublisherId = 4
                        },
                        new Book()
                        {
                            Name = "Book 4",
                            Price = 379.50,
                            ReleaseDate = DateTime.Now.AddDays(-100),
                            PublisherId = 2
                        },
                        new Book()
                        {
                            Name = "Book 5",
                            Price = 39.50,
                            ReleaseDate = DateTime.Now.AddDays(-80),
                            PublisherId = 3
                        },
                        new Book()
                        {
                            Name = "Book 6",
                            Price = 39.50,
                            ReleaseDate = DateTime.Now.AddDays(-10),
                            PublisherId = 5
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Authors_Books.Any())
                {
                    context.Authors_Books.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 1
                        },

                         new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 2
                        },
                         new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 2
                        },

                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 3
                        },


                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 4
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 4
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 4
                        },


                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 5
                        },


                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 6
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 6
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
