using _8DSystem.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace _8DSystem.Services
{
   
    public class Notify : INotify
    {
        private readonly IConfiguration _conf;
        private Dictionary<string, string> LineMessage { get; set; }
        public Notify(IConfiguration configuration)
        {
            _conf = configuration;
            LineMessage = new Dictionary<string, string>();
        }
        private string MailSubject { get; set; }
        private string MailMessage { get; set; }
        private string MailAddress { get; set; }
        private List<string> MailCc = new List<string>();
        public void InvokeEmail()
        {
            var setConfig = _conf.GetSection("EmailConfig");
            try
            {
                var smtp = new SmtpClient
                {
                    Host = setConfig["Host"],
                    Port = Convert.ToInt32(setConfig["Port"]),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(setConfig["FromAddress"], setConfig["Password"])
                };

                var mail = new MailMessage
                {
                    From = new MailAddress(setConfig["FromAddress"])
                };

                mail.To.Add(MailAddress);
                if (MailCc != null)
                {
                    foreach (var e in MailCc)
                    {
                        mail.CC.Add(e);
                    }
                }


                //mail.To.Add("sarocha.s@senior-thailand.com");
                mail.Bcc.Add("sarocha.s@senior-thailand.com");
                mail.IsBodyHtml = true;
                mail.Subject = MailSubject;
                mail.Body = MailMessage;

                smtp.Send(mail);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void SendEmail(ReportHeader report)
        {
            var setConfig = _conf.GetSection("SiteInfo");
            var informs = new List<string>();

            switch (report.WorkFlow.RefStatusId)
            {
                case StatusId.WaitingApprove:
                    MailSubject = "[8D Report] Report wait for your action";
                    MailMessage = "<h5>Dear all concern,</h5>";
                    MailMessage += GetEmailTemplete(report);
                    MailMessage += "<br />";
                    MailMessage += "<div>for more information click <a href='" + setConfig["HttpRootPath"] + "Auth/Login?returnUrl=/Home/Edit/" + report.Id + "'>[Link]</a></div>";

                    MailAddress = report.WorkFlow.ActionEmail;
                    MailCc.Add(report.CreateByEmail);
                    if (!string.IsNullOrWhiteSpace(MailAddress))
                    {
                        InvokeEmail();
                    }

                    break;
                case StatusId.MgrApproved:
                    MailSubject = "[8D Report] Report wait for your action";
                    MailMessage = "<h5>Dear all concern,</h5>";
                    MailMessage += GetEmailTemplete(report);
                    MailMessage += "<br />";
                    MailMessage += "<div>for more information click <a href='" + setConfig["HttpRootPath"] + "Auth/Login?returnUrl=/Home/Edit/" + report.Id + "'>[Link]</a></div>";

                    MailAddress = report.WorkFlow.ActionEmail;
                    //MailCc.Add(report.CreateByEmail);
                    if (!string.IsNullOrWhiteSpace(MailAddress))
                    {
                        InvokeEmail();
                    }

                    break;
                case StatusId.Completed:
                    MailSubject = "[8D Report] Report is completed";
                    MailMessage = "<h5>Dear all concern,</h5>";
                    MailMessage += GetEmailTemplete(report);
                    MailMessage += "<br />";
                    MailMessage += "<div>for more information click <a href='" + setConfig["HttpRootPath"] + "Auth/Login?returnUrl=/Home/Edit/" + report.Id + "'>[Link]</a></div>";

                    MailAddress = report.WorkFlow.ActionEmail;
                    MailCc.Add(report.CreateByEmail);
                    if (!string.IsNullOrWhiteSpace(MailAddress))
                    {
                        InvokeEmail();
                    }

                    break;
                case StatusId.Rejected:
                    MailSubject = "[8D Report] Report is rejected";
                    MailMessage = "<h5>Dear all concern,</h5>";
                    MailMessage += GetEmailTemplete(report);
                    MailMessage += "<br />";
                    MailMessage += "<div>for more information click <a href='" + setConfig["HttpRootPath"] + "Auth/Login?returnUrl=/Home/Edit/" + report.Id + "'>[Link]</a></div>";

                    MailAddress = report.WorkFlow.ActionEmail;
                    //MailCc.Add(report.CreateByEmail);
                    if (!string.IsNullOrWhiteSpace(MailAddress))
                    {
                        InvokeEmail();
                    }

                    break;
            }
        }

        private string GetEmailTemplete(ReportHeader report)
        {
            var ret = $" <table> "
                    + "  <tr> "
                    + "      <td style='text-align: right;;font-weight:bold'>Report No :</td> "
                    + $"      <td> { report.Code } </td> "
                    + "  </tr> "
                    + "  <tr> "
                    + "      <td style='text-align: right;;font-weight:bold'>NCR No:</td> "
                    + $"      <td> { report.NcrNo } </td> "
                    + "  </tr> "
                    + "  <tr> "
                    + "      <td style='text-align: right;;font-weight:bold'>Create Date :</td> "
                    + $"      <td> { report.DateCreate:dd/MM/yyyy HH:mm} </td> "
                    + "  </tr> "
                    + "  <tr> "
                    + "      <td style='text-align: right;;font-weight:bold'>Register by :</td> "
                    + $"      <td> { report.CreateByName } </td> "
                    + "  </tr> ";
            ret += "</table> ";

            return ret;
        }
    }
}
