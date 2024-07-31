using _3rdParty_Services_Implementation.VNPAY_Sandbox.VnPayModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdParty_Services_Implementation.VNPAY_Sandbox
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(HttpContext context, VnPayRequestModel model);
        VnPayResponseModel PaymentResponse(IQueryCollection collection);
    }
}
