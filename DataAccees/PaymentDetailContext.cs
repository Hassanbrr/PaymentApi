using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions options) : base (options) { 
        
            
        
        }
      public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
