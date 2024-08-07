using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext: DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowdb;Integrated Security=True;TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer(connectionString);
    }
}
