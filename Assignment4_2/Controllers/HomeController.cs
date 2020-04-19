using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using Assignment4_2;
using Assignment4_2.DataAccess;
using Assignment4_2.Models;

namespace Assignment4_2
{
    public class HomeController : Controller
    {
        string BASE_URL = "https://api.data.gov/ed/collegescorecard/v1/schools.json?school.name=University&_fields=id,school.name,2013.student.size&";
        HttpClient httpClient;

        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public UniversityData GetUniversities()
        {
            string API_PATH = BASE_URL + "&api_key=ck1LVrQunLhfsjSgoithxWggF6ZbNSp3SvalD4d4";
            string companyList = "";
            UniversityData data = null;

            // Connect to the IEXTrading API and retrieve information
            httpClient.BaseAddress = new Uri(API_PATH);
            HttpResponseMessage response = httpClient.GetAsync(API_PATH).GetAwaiter().GetResult();

            // Read the Json objects in the API response
            if (response.IsSuccessStatusCode)
            {
                companyList = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }

            // Parse the Json strings as C# objects
            if (!companyList.Equals(""))
            {
                data = JsonConvert.DeserializeObject<UniversityData>(companyList);
               
            }

            return data ;
        }
        public IActionResult Index()
        {
            // Get the data from the List using GetSymbols method
            UniversityData response = GetUniversities();
            List<University> universityList = response.universityList;
            // Send the data to the Index view
            return View(universityList);
        }


        

        

        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
