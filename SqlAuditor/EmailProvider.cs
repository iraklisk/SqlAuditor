using SqlAuditor.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SqlAuditor
{
    public class EmailProvider : ITraceObserver
    {
        SmtpClient smtp;
        EmailConfig emailConfig;
        MailAddress from;
        public void Init(Trace.TraceContext context)
        {
            this.emailConfig = context.Trace.EmailConfig;
            if (emailConfig.Enabled)
            {
                smtp = new SmtpClient(emailConfig.Server, emailConfig.Port);
                smtp.EnableSsl = emailConfig.UseSSL;
                smtp.Credentials = new NetworkCredential(emailConfig.Username, emailConfig.Password);
                from = new MailAddress(emailConfig.EmailAddress);
            }
        }

        public void EventReceived(Trace.TraceEvent traceEvent)
        {
            if (emailConfig.Enabled && emailConfig.Events.Contains(traceEvent.EventClass))
            {
                MailMessage msg = new MailMessage();
                msg.From = from;
                foreach (var t in emailConfig.Receipients) msg.To.Add(t);
                msg.Subject = "SqlAuditor - Event";
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("EventClass:\t{0}\n", traceEvent.EventClass);
                sb.AppendFormat("Application:\t{0}\n", traceEvent.ApplicationName);
                sb.AppendFormat("DatabaseName:\t{0}\n", traceEvent.DatabaseName);
                sb.AppendFormat("LoginName:\t{0}\n", traceEvent.LoginName);
                sb.AppendFormat("StartTime:\t{0}\n", traceEvent.StartTime);
                sb.AppendFormat("EndTime:\t{0}\n", traceEvent.EndTime);
                sb.AppendLine(traceEvent.TextData);
                sb.AppendLine("");
                sb.AppendLine("Power by SqlAuditor.");
                sb.AppendLine("http://github.com/iraklisk/SqlAuditor");
                msg.Body = sb.ToString();
                smtp.Send(msg);
            }
        }
    }
}
