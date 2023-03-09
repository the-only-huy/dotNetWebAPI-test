
namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Adventures of Huckleberry Finn",
                    Description = "The book is noted for changing the course of children's literature in the United States for the deeply felt portrayal of boyhood. It is also known for its colorful description of people and places along the Mississippi River. Set in a Southern antebellum society that had ceased to exist over 20 years before the work was published, Adventures of Huckleberry Finn is an often scathing satire on entrenched attitudes, particularly racism and freedom.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Huckleberry_Finn_book.JPG/330px-Huckleberry_Finn_book.JPG",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Moby Dick",
                    Description = "Moby-Dick; or, The Whale is an 1851 novel by American writer Herman Melville. The book is the sailor Ishmael's narrative of the maniacal quest of Ahab, captain of the whaling ship Pequod, for vengeance against Moby Dick, the giant white sperm whale that crippled him on the ship's previous voyage. A contribution to the literature of the American Renaissance, Moby-Dick was published to mixed reviews, was a commercial failure, and was out of print at the time of the author's death in 1891. Its reputation as a Great American Novel was established only in the 20th century, after the 1919 centennial of its author's birth. William Faulkner said he wished he had written the book himself,[1] and D. H. Lawrence called it one of the strangest and most wonderful books in the world and the greatest book of the sea ever written Its opening sentence, Call me Ishmael, is among world literature's most famous.[3]",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Moby-Dick_FE_title_page.jpg/800px-Moby-Dick_FE_title_page.jpg",
                    Price = 8.90m
                },
                new Product
                {
                    Id = 3,
                    Title = "The Great Gatsby",
                    Description = "The novel was inspired by a youthful romance Fitzgerald had with socialite Ginevra King, and the riotous parties he attended on Long Island's North Shore in 1922. Following a move to the French Riviera, Fitzgerald completed a rough draft of the novel in 1924. He submitted it to editor Maxwell Perkins, who persuaded Fitzgerald to revise the work over the following winter. After making revisions, Fitzgerald was satisfied with the text, but remained ambivalent about the book's title and considered several alternatives. Painter Francis Cugat's cover art greatly impressed Fitzgerald, and he incorporated its imagery into the novel.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg/330px-The_Great_Gatsby_Cover_1925_Retouched.jpg",
                    Price = 6.59m
                }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
