using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetTechnology.Pages
{
    public class NewsLetterModel : PageModel
    {
        public String Message { get; set; }
        public void OnGet()
        {
            Message = "To sign up for the newsletter please submit your E-mail address into the form below."
;        }

        public void OnPost()
        {
            String emailAddress = Request.Form["emailaddress"];
            System.IO.File.AppendAllText("C:/Users/Mads/source/repos/InternetTechnology/InternetTechnology/Data/email.txt", emailAddress);
            Message = "E-mail successfully submitted you are now on the mailing list!";
        }
    }
}