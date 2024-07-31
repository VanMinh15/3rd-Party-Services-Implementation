using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdParty_Services_Implementation.VNPAY_Sandbox.VnPayModel
{
    public class VnPayResponseModel
    {
        public bool Status { get; set; }
        public string ResponseCode { get; set; }
        public string Description { get; set; }
        public string TransactionId { get; set; }
    }
}
