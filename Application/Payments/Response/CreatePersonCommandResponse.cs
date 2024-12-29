 
namespace Application.Payments.Response
{

    public class CreatePersonCommandResponse
    {
        private int paymentDetailId;

        public CreatePersonCommandResponse(Guid personId)
        {
            PersonId = personId;
        }

        public CreatePersonCommandResponse(int paymentDetailId)
        {
            this.paymentDetailId = paymentDetailId;
        }

        public Guid PersonId { get; set; }
    }
}
