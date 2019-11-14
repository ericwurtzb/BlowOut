using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Message = String.Format("Thank you {0}. We will send an email to {1}", name, email);
            return View();
        }

       
        
        public ActionResult Contact(string name, string email)
        {
            if (ModelState.IsValid)
            {
                
                var message = new MailMessage();
                message.To.Add(new MailAddress(email));  // replace with valid value 
                message.From = new MailAddress("ericwurtzb@gmail.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format("Email To: {0}", name);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "ericwurtzb@gmail.com",  // replace with valid value
                        Password = "Megapistol184#"  // replace with valid value
                    };
                    
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = credential;
                    smtp.Send(message);
                    return RedirectToAction("Sent");
                }
            }
            return View();
        }
        public ActionResult Sent()
        {
            return Content("we are sent boy");
        }
    }
}