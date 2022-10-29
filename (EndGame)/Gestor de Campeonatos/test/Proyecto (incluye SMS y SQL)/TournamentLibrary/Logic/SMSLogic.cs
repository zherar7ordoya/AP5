using System;
using System.Collections.Generic;
using System.Text;
using Twilio;                           
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TournamentLibrary.Logic
{
    public class SMSLogic                                               
    {
        public static void SendSMSMessage(string textMessage)
        {
            string accountSid = GlobalConfig.AppKeyLookup("smsAccountSid");
            string authToken = GlobalConfig.AppKeyLookup("smsAuthToken");
            string fromPhoneNumber = GlobalConfig.AppKeyLookup("smsFromPhoneNumber");

            TwilioClient.Init(accountSid, authToken);   

            var message = MessageResource.Create(
                to: new PhoneNumber("+31618857002"),        
                from: new PhoneNumber(fromPhoneNumber),
                body: textMessage
                );
        }
    }
}
