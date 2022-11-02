using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

var email = new MimeMessage();
email.From.Add(MailboxAddress.Parse("test@yahoo.com"));
email.To.Add(MailboxAddress.Parse("firstChance@google.com"));
email.Subject = "Testing sending email from console .NET Core";
email.Body = new TextPart(TextFormat.Html) { Text = "<h1>This is a header<h1><p>This is more text to go here."};

using var smtp = new SmtpClient();
smtp.Connect("localhost", 2525, false);

smtp.Send(email);
smtp.Disconnect(true);
