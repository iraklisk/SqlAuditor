using SqlAuditor.Config;
using SqlAuditor.Trace;
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
        TraceContext context;
        public void Init(Trace.TraceContext context)
        {
            this.context = context;
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
                try
                {
                    MailMessage msg = new MailMessage();
                    msg.From = from;
                    foreach (var t in emailConfig.Receipients) msg.To.Add(t);

                    var e = context.SqlTraceEvents[traceEvent.EventClass];
                    var evtCtgr = context.SqlTraceCategories[e.CategoryId];

                    msg.Subject = "SqlAuditor Notification - " + e.Name;

                    StringBuilder sb = new StringBuilder();

                    sb.AppendFormat("Event Name: {0}\n", e.Name);
                    sb.AppendFormat("Event Category: {0}\n", evtCtgr.Name);
                    foreach (var kv in traceEvent.Values)
                    {
                        sb.AppendFormat("{0}: {1}\n", context.SqlTraceColumns[kv.Key].Name, kv.Value.ToString());
                        if (context.SqlTraceColumns[kv.Key].HasSubClassValues && context.SqlTraceEvents[traceEvent.EventClass].SubClassValues.ContainsKey(kv.Key))
                            sb.AppendFormat("{0}_VALUE: {1}\n", context.SqlTraceColumns[kv.Key].Name, context.SqlTraceEvents[traceEvent.EventClass].SubClassValues[kv.Key][(int)kv.Value].Name);
                    }
                    sb.AppendLine("Powered by SqlAuditor");
                    sb.AppendLine("http://github.com/iraklisk/SqlAuditor");
                    msg.Body = sb.ToString();
                    smtp.Send(msg);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
