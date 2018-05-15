using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetTechnology.Pages
{
    public class AdminModel : PageModel
    {
        public String AdminPageInfo { get; set; }

        public String Message { get; set; }

        [BindProperty]
        public String Name { get; set; }
        [BindProperty]
        public String Birthday { get; set; }
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public String Description { get; set; }
        [BindProperty]
        public String Email { get; set; }
        public void OnGet()
        {
            AdminPageInfo = "This is the admin page where you can edit the about page and the gallery page.";
        }

        public void OnPost()
        {
            System.IO.File.WriteAllText("C:/Users/Mads/source/repos/InternetTechnology/InternetTechnology/Data/test.txt", "My name is " + Name + " my birthday is " + Birthday
                + " which makes me " + Age + " years old. " + Description + " To get in contact with me you can use this E-mail: " + Email);

            Message = "The new info was successfully added";
        }
    }
}