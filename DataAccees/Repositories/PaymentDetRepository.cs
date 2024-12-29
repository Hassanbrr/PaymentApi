using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction;
using DataAccess.Models;
using Domain.Models;

namespace DataAccees.Repositories
{
    public class PaymentDetRepository : Repository<PaymentDetail>, IPaymentDetRepository
    {
        public PaymentDetRepository(PaymentDetailContext db) : base(db)
        {
        }
    }
}
