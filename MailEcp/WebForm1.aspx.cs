using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailEcp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
             msg.From = new MailAddress(txtFromAddress.Text.Trim());
          //  msg.From = new MailAddress(Class1.FromAddress, Class1.FromName);
            msg.To.Add(new MailAddress(txtToAddress.Text.ToString()));
            // msg.CC.Add(new MailAddress(Class1.ToAddress, Class1.ToName));
            msg.Subject = txtSubject.Text.ToString();
            msg.Body = txtBody.Text;
            msg.IsBodyHtml = true;
            //StrFilePath = "c:\\emps.txt";
            //MailAttachment attach = new MailAttachment(strFilePath);
            //msg.Attachments.Add(attach);
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("kevaladeshara@gmail.com", "keval@7743");
            client.Send(msg);
            //clearcontrols();
            //Response.Redirect(RedirectionPages.WelComePageURL);

        }
    }
}