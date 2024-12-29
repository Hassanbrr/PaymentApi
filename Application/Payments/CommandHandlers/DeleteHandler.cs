using Domain.Models;
using Application.Abstraction;
using Application.Payments.Commands;
using Application.Payments.Response;
using AutoMapper;
using MediatR;

namespace Application.Payments.CommandHandlers
{
    public class DeleteHandler : IRequestHandler<Delete, CreatePersonCommandResponse>
    {
        private readonly IPaymentDetRepository _PayRepo;
        private readonly IMapper _mapper;
        public DeleteHandler(IPaymentDetRepository PayRepo, IMapper maper)
        {
            _PayRepo = PayRepo;
            _mapper = maper;
        }
        public  async Task<CreatePersonCommandResponse> Handle(Delete request, CancellationToken cancellationToken)
        {
            var PaymentDetail = _mapper.Map<PaymentDetail>(request);
            _PayRepo.Delete(PaymentDetail);
            await _PayRepo.Save();
            return new CreatePersonCommandResponse(PaymentDetail.PaymentDetailId);


        }
    }
}
