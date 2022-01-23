using System;
using System.Globalization;
using AutoMapper;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Mvc;
using MUsefulMethods;
using WebItProject.Models.Payment;

namespace WebItProject.Controllers
{
    public class TestController: Controller
    {
        private IMapper _mapper;
        private Options _options;

        public TestController(IMapper mapper)
        {
            _mapper = mapper;
            _options = new Options()
            {
                ApiKey = "sandbox-zCEECkYFMbaWcVq3d6O9bNfL4o4YJLxA",
                SecretKey = "sandbox-MNmiw8ZolOIILD2VBluaIluW5QI6UUWe",
                BaseUrl = "https://sandbox-api.iyzipay.com"
            };
        }

        

        public JsonResult binAndInstallment()
        {
            var conversationId = GenerateConversationId();
            var garantiBank = "540036";
            var price = 1000;

            RetrieveInstallmentInfoRequest request = new RetrieveInstallmentInfoRequest()
            {
                Locale = Locale.TR.ToString(),
                ConversationId = conversationId,
                BinNumber = garantiBank,
                Price = price.ToString(new CultureInfo("en-US")),
            };    

            InstallmentInfo result = InstallmentInfo.Retrieve(request, _options);    

            if (result.Status == "failure")
            {
                throw new Exception(result.ErrorMessage);
            }

            if (result.ConversationId != conversationId)
            {
                throw new Exception("Hatalı istek oluturuldu");
            }  

            return Json(result);
        }

        private string GenerateConversationId()
        {
            return StringHelpers.GenerateUniqueCode();
        }
    }
}