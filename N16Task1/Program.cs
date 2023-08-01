using System.Net.Mail;
using System.Net;

var userEmail = Console.ReadLine();

EmailService email = new EmailService("anvarjonovozodbek416@gmail.com", "Ozodbek");
email.SendEmail(userEmail);

public class EmailService
{
    private string _credentialAddress;
    private string _credentialPassword;
    public string CredentialAddress
    {
        get { return _credentialAddress; }
        init { _credentialAddress = value; }
    }
    public string CredentialPassword
    {
        get { return _credentialPassword; }
        init { _credentialPassword = value; }
    }
    public EmailService(string CreEmail, string CrePass)
    {
        _credentialAddress = CreEmail;
        _credentialPassword = CrePass;
    }

    public void SendEmail(string receiverEmail)
    {
        var senderEmail = "sultonbek.rakhimov.recovery@gmail.com";
        var senderPassword = "szabguksrhwsbtie";

        var mail = new MailMessage(senderEmail, receiverEmail);
        mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
        mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz";

        var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
        smtpClient.EnableSsl = true;

        smtpClient.Send(mail);
    }
}
