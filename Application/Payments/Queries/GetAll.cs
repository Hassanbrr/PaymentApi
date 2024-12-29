using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using MediatR;

namespace Application.Payments.Queries
{
    public class GetAll:IRequest<ICollection<PaymentDetail>>
    {
    }
}
