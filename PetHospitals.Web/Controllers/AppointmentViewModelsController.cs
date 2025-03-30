using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using PetHospital.Domain.Entities;
using PetHospital.Web.Models.Entities;
using System.Text;


namespace PetHospital.Web.Controllers
{
    public class AppointmentViewModelsController : Controller
    {
        private readonly HttpClient _httpClient;

        public AppointmentViewModelsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44335/api");
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Appointments appointment)
        {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(appointment);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("/api/Appointments/crear", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error al crear producto");
                }

            }
            return View(appointment);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"api/Appointments/consultar?id={id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var appointments = JsonConvert.DeserializeObject<AppointmentViewModel>(content);
                return View(appointments);
            }
            else
            {
                return RedirectToAction("Details");
            }
        }

        [HttpPost]
           public async Task<IActionResult> Edit(int id, AppointmentViewModel appointment)
         {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(appointment);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"api/Appointments/editar?id={id}", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("index", new { id });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Ërror al actualizar producto");
                }
            }
            return View(appointment);
        }
        public async Task<IActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync($"api/Appointments/consultar?id={id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var appointments = JsonConvert.DeserializeObject<AppointmentViewModel>(content);
                return View(appointments);
            }
            else
            {
                return RedirectToAction("Details");
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Appointments/eliminar?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Error"] = "Error al eliminar el producto";
                return RedirectToAction("Index");
            }
        }
    }
}





