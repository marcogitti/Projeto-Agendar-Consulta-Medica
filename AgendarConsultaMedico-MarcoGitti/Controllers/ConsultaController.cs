using AgendarConsultaMedico_MarcoGitti.Data;
using AgendarConsultaMedico_MarcoGitti.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendarConsultaMedico_MarcoGitti.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly ApplicationDBContext _db;
        public int id;

        public ConsultaController(ApplicationDBContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            IEnumerable<ConsultaModel> consultas = _db.Consultas;
            return View(consultas);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(ConsultaModel consulta)
        {
            if(ModelState.IsValid)
            {
                _db.Consultas.Add(consulta);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        //public IActionResult Editar()
        //{
            //return View();
        //}
        [HttpGet]
        public IActionResult Editar()
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            ConsultaModel consulta = _db.Consultas.FirstOrDefault(x => x.Id == id);

            if(consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }
        [HttpPost]
        public IActionResult Editar(ConsultaModel consulta)
        {
            if(ModelState.IsValid)
            {
                _db.Consultas.Update(consulta);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(consulta);
        }
        [HttpPost]
        public IActionResult Excluir(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            ConsultaModel consulta = _db.Consultas.FirstOrDefault(x => x.Id == id);

            if(consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }
        [HttpPost]
        public IActionResult Excluir(ConsultaModel consulta)
        {
            if (consulta == null)
            {
                return NotFound();
            }
            _db.Consultas.Remove(consulta);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
            }
    }
