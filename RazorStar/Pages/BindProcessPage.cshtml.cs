using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;

namespace RazorStar.Pages
{
    public class BindProcessPageModel : PageModel
    {
        [BindProperty]

        public Process[]? Procs { get; set; }


        public void OnGet()
        {
            Procs = Process.GetProcesses();
            ViewData["Processes"] = Procs;
        }
    }
}
