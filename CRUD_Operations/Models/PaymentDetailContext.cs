using Microsoft.EntityFrameworkCore;

namespace CRUD_Operations.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions options) : base(options) 
        {
               
        }

        public DbSet<PaymentDetail> paymentDetails { get; set; }
    }
}
