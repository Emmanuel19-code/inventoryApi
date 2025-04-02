namespace inventoryApi.Infrastruture.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<Users> Users {get;set;}
        public DbSet<Products> Products {get;set;}
        public DbSet<ExpenseByCategory> ExpenseByCategory {get;set;}
        public DbSet<Sales> Sales {get;set;}
        public DbSet<Expenses> Expenses {get;set;}
        public DbSet<ExpenseSummary> ExpenseSummary {get;set;}
        public DbSet<Purchases> Purchases {get;set;}
        public DbSet<PurchaseSummary> PurchaseSummary {get;set;}
        public DbSet<SalesSummary> SalesSummary {get;set;}
    }
}