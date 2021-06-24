using Salino.DataLayer;
using SmsIrRestful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalinoMvc5.SalinoUtilities
{
    public static class SmsService
    {
       
        #region SendSms
        public static int SendSms(int? userid)
        {
            #region SmsSender
          SalinoContext db = new SalinoContext();
          var user = db.users.Find(userid);


            SmsIrRestful.Token tk = new SmsIrRestful.Token();
            string result = tk.GetToken("86b2652ab294098a798e6ad7", "salino12345@@salllosijm");

            var restVerificationCode = new RestVerificationCode()
            {
                Code = user.CodeActivate,
                MobileNumber = user.Mobile
            };

            var restVerificationCodeRespone = new VerificationCode().Send(result, restVerificationCode);
            if (restVerificationCodeRespone.IsSuccessful)
            {
                return 1;


            }
            else
            {

                return 0;
            }

            #endregion
        }
        #endregion
    }
}