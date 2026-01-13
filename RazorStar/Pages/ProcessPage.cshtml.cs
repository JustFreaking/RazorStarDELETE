namespace RazorStar.Pages
{
    public class ProcessPageModel : PageModel
    {
        public void OnGet()
        {
            Process[] processes = Process.GetProcesses();
            ViewData["Processes"] = processes;
        }
    }
}
