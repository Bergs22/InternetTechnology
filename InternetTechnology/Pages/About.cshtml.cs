using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetTechnology.Pages
{
    public class AboutMeModel : PageModel
    {
        public string Message { get; set; }

        public String Name { get; set; }
        public String BirthDay { get; set; }
        public int Age { get; set; }
        public String Occupation { get; set; }
        public String AboutMe { get; set; }
        public void OnGet()
        {
            Message = "This is me!";
            //System.IO.File.WriteAllText(path, "hej");
            //string s = System.IO.File.ReadAllText(path);
            Name = "Mads Berggreen";
        }
    }
}
