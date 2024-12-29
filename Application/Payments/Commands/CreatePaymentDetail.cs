using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Payments.Response;
using Domain.Models;
using MediatR;

namespace Application.Payments.Commands
{
    public class CreatePaymentDetail : IRequest<CreatePersonCommandResponse>
    {
        public string CardOwnerName { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string ExpirationDate { get; set; } = string.Empty;
        public string Securitycode { get; set; } = string.Empty;
    }
}
