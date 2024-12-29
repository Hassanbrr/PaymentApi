using Application.Payments.Response;
using MediatR;

namespace Application.Payments.Commands
{
    public class Update:IRequest<CreatePersonCommandResponse>
    {
        public int PaymentId { get; set; }
        public string CardOwnerName { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string ExpirationDate { get; set; } = string.Empty;
        public string Securitycode { get; set; } = string.Empty;
    }
}
