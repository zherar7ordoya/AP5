namespace _1.S
{
    /// <summary>
    /// 
    /// Aquí hay algo interesante.
    /// Originalmente, esta clase era un método, el cual se invocaba así:
    /// 
    /// MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
    /// this.SendInvoiceEmail(mailMessage);
    /// 
    /// ...y el método era:
    /// public void SendInvoiceEmail(MailMessage mailMessage) {...}
    /// 
    /// </summary>
    public class MailSender
    {
        public string EMailFrom { get; set; }
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }
        public void SendEmail()
        {
            // Here we need to write the Code for sending the mail
        }
    }
}
