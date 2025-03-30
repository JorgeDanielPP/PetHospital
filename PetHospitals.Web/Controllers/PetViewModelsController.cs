using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PetHospital.Domain.Migrations;
using PetHospital.Web.Models.Entities;
using System.Text;

namespace PetHospital.Web.Controllers
{
    public class PetViewModelsController : Controller
    {
        private readonly HttpClient _httpClient;

        public PetViewModelsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44335/api");
        }
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("api/Pets/listar");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var pets = JsonConvert.DeserializeObject<IEnumerable<PetViewModel>>(content);
                return View("Index", pets);
            }
            return View(new List<PetViewModel>());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pets pets)
        {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(pets);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("/api/Pets/crear", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error al crear mascota");
                }

            }
            return View(pets);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"api/Pets/consultar?id={id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var pets = JsonConvert.DeserializeObject<PetViewModel>(content);
                return View(pets);
            }
            else
            {
                return RedirectToAction("Details");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, PetViewModel pets)
        {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(pets);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"api/Pets/editar?id={id}", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("index", new { id });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Ërror al actualizar producto");
                }
            }
            return View(pets);
        }
        public async Task<IActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync($"api/Pets/consultar?id={id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var pets = JsonConvert.DeserializeObject<PetViewModel>(content);
                return View(pets);
            }
            else
            {
                return RedirectToAction("Details");
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Pets/eliminar?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Error"] = "Error al eliminar la mascota";
                return RedirectToAction("Index");
            }
        }

    }
}