using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction;
using Application.Payments.Commands;
using Application.Payments.Response;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Payments.CommandHandlers
{
    public class UpdateHandler : IRequestHandler<Update, CreatePersonCommandResponse>
    {
        private readonly IPaymentDetRepository _PayRepo;
        private readonly IMapper _mapper;
        public UpdateHandler(IPaymentDetRepository PayRepo, IMapper maper)
        {
            _PayRepo = PayRepo;
            _mapper = maper;
        }
        public async Task<CreatePersonCommandResponse> Handle(Update request, CancellationToken cancellationToken)
        {
            var PaymentDetail = _PayRepo.GetById(u => u.PaymentDetailId == request.PaymentId).FirstOrDefault();
            PaymentDetail.CardOwnerName = request.CardOwnerName;
            PaymentDetail.CardNumber = request.CardNumber;
            PaymentDetail.ExpirationDate = request.ExpirationDate;
            PaymentDetail.Securitycode = request.Securitycode;
            _PayRepo.Update(PaymentDetail);
            await _PayRepo.Save();
            return new CreatePersonCommandResponse(PaymentDetail.PaymentDetailId);

        }

    }
}
