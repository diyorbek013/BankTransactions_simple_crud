using BankTransactions.Models;
using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Data
{
    public class TransactionDBContext : DbContext
    {
        public TransactionDBContext(DbContextOptions<TransactionDBContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
