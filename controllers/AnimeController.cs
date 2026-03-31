using Microsoft.AspNetCore.Mvc;

namespace AnimeCrudPro.Controllers
{
    public class AnimeController : Controller
    {
        private readonly AnimeRepository _repo = new AnimeRepository();

        // READ: Lista todos los animes
        public IActionResult Index()
        {
            var lista = _repo.ObtenerTodos();
            return View(lista);
        }

        // CREATE: Muestra el formulario
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Anime anime)
        {
            _repo.Crear(anime);
            return RedirectToAction("Index");
        }

        // UPDATE: Carga los datos en el formulario de edición
        public IActionResult Edit(int id)
        {
            var anime = _repo.ObtenerTodos().Find(a => a.Id == id);
            return View(anime);
        }

        [HttpPost]
        public IActionResult Edit(Anime anime)
        {
            _repo.Actualizar(anime);
            return RedirectToAction("Index");
        }

        // DELETE: Borra y regresa a la lista
        public IActionResult Delete(int id)
        {
            _repo.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}