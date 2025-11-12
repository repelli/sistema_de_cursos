using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_CURSOS_MVC.Data;
using SISTEMA_DE_CURSOS_MVC.Models;
//pega informações de view e da conexão com o bd
namespace SISTEMA_DE_CURSOS_MVC.Controllers
{
    public class CursoController : Controller
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //listar
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaCurso.ToListAsync(); // traz a listagem dentro da tabela cursos
            return View(lista);
        }

        [HttpGet]

        //lista o formulário
        public IActionResult Criar() => View(); //retorna o formaulario vazio

        //para cadastrar as informções, como insert

        [HttpPost] //posta algo, cadastra no banco, cria o registro no banco
        public async Task<IActionResult> Criar(string nomeConstrutor, int horasConstrutor, string tipoCursoConstrutor)
        {
            Curso? novoCurso = null; // deixa inicializar curso como vazio - interrogação
            if (tipoCursoConstrutor == "Tecnico")
            {
                novoCurso = new Tecnico(nomeConstrutor, horasConstrutor);
            }
            else if (tipoCursoConstrutor == "Superior")
            {
                novoCurso = new Superior(nomeConstrutor, horasConstrutor);
            }
            else
            {
                return BadRequest("Tipo de curso inválido.");
            }

            _context.TabelaCurso.Add(novoCurso);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //opcao de excluir

        public async Task<IActionResult> Deletar(int id)
        {
            var Curso = await _context.TabelaCurso.FindAsync(id);
            if (Curso == null) return NotFound();

            _context.TabelaCurso.Remove(Curso);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
            
            

        }

    }
}