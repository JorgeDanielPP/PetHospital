using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using PetHospitals.Web.Models.Entities;


namespace PetHospital.Web.Controllers
{
    public class AppointmentViewModelsController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44335/api");
        private readonly HttpClient _httpClient;
           
        public AppointmentViewModelsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("api/Appointments/listar");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var appointments = JsonConvert.DeserializeObject<IEnumerable<AppointmentViewModel>>(content);
                return View("Index", appointments);
            }
            return View(new List<AppointmentViewModel>());
        }
    }
}

