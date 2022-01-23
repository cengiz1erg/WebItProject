using System.Collections.Generic;
using WebItProject.Models.Payment;

namespace WebItProject.Services
{
    public interface IPaymentService
    {
        public List<InstallmentModel> CheckInstallments(string binNumber, decimal price);
        public PaymentResponseModel Pay(PaymentModel model);
    }
}