using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetTechnology.Pages
{
    public class GalleryModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "This is a little gallery of pictures that i have taken";
        }
    }
}
