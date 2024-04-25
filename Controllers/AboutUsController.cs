using DIS6225_FinalProject_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DIS6225_FinalProject_MVC.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            var teamMembers = new List<TeamMember>
        {
            new TeamMember
            {
                Name = "Anoop Garige",
                Role = "Aspiring Business Analyst",
                ImageUrl = "img/anoop.jpeg",
                GitHubUrl = "https://github.com/Anoop135"
            },
            new TeamMember
            {
                Name = "Asif Imtiaz",
                Role = "Aspiring Data Analyst",
                ImageUrl = "img/asif.png",
                GitHubUrl = "https://github.com/asif-imtiaz-j"
            },
            new TeamMember
            {
                Name = "Zeina Kamal",
                Role = "Aspiring Business Intelligence Analyst",
                ImageUrl = "img/zeina.png",
                GitHubUrl = "https://github.com/zrkamal"
            },
            new TeamMember
            {
                Name = "Devan Kreitzer",
                Role = "Aspiring Data Engineer",
                ImageUrl = "img/devan.png",
                GitHubUrl = "https://github.com/dkreitzer-usf"
            }
        };

            var model = new AboutUsModel
            {
                TeamMembers = teamMembers,
                DataModelImageUrl = "img/datamodel.png",
                GitHubRepoUrl = "https://github.com/dkreitzer-usf/DIS6225_FinalProject_MVC"
            };

            return View(model);
        }
    }
}
