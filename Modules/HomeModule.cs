using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Carter;

namespace CarterAPI.Modules
{
    public class HomeModule : CarterModule
    {
        public HomeModule()
        {
            Get("/", (req, res) => res.WriteAsync("Hello from Carter!"));
        }
    }
}