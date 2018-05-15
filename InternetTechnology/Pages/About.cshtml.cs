using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetTechnology.Pages
{
    public class AboutMeModel : PageModel
    {
        public String Message { get; set; }
        public String SecTitel { get; set; }
        public String MyDescription { get; set; } 
        public void OnGet()
        {
            Message = "This is me!";
            SecTitel = "About me:";
            MyDescription = System.IO.File.ReadAllText("C:/Users/Mads/source/repos/InternetTechnology/InternetTechnology/Data/About.txt");
        }
    }
}
