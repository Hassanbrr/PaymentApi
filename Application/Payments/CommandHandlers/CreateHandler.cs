using Application.Abstraction;
using Application.Payments.Commands;
using Application.Payments.Response;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Payments.CommandHandlers
{

    public class CreateHandler : IRequestHandler<CreatePaymentDetail, CreatePersonCommandResponse>
    {
        private readonly IPaymentDetRepository _PayRepo;
        private readonly IMapper _mapper;
        public CreateHandler(IPaymentDetRepository PayRepo, IMapper maper)
        {
            _PayRepo = PayRepo;
            _mapper = maper;
        }

        public async Task<CreatePersonCommandResponse> Handle(CreatePaymentDetail request, CancellationToken cancellationToken)
        {
            var PaymentDetail = _mapper.Map<PaymentDetail>(request);
            await _PayRepo.Create(PaymentDetail);
            await _PayRepo.Save();
            return  new CreatePersonCommandResponse(PaymentDetail.PaymentDetailId );
              

        }
    }
}
