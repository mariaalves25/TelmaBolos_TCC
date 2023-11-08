using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelmaBolossite;
using TelmaBolossite.Entidades;

namespace TelmaBolossite.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto _context;
        private string path;

        public ProdutosController(Contexto context, IWebHostEnvironment env)
        {
            path = env.WebRootPath;
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.PRODUTOS.Include(p => p.Categoria);
            return View(await contexto.ToListAsync());
        }

      

        // GET: Produtos/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.CATEGORIAS, "Id", "Id");
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,descricaoproduto,valorproduto,unidadeproduto,CategoriaId,imagem")] Produto produto, IFormFile imagem)
        {
            if (imagem != null && imagem.Length > 0)
            {
                string nomeImagem = Guid.NewGuid().ToString()+imagem.FileName;
                string caminho = path + "\\fotos\\";
                if (!Directory.Exists(caminho))
                {
                    Directory.CreateDirectory(caminho);
                }


                //cria uma nova instância de MemoryStream, que é uma classe do .NET usada para armazenar dados na memória.
                using (var stream = System.IO.File.Create(caminho+nomeImagem))
                {
                    //indica que esses dados da memória é a Imagem e coloca esses dados em um array de bytes para que a imagem possa ser armazenada diretamente no banco de dados como um blob (
                    //permite armazenar grandes quantidades de dados binários em um único campo no BD)
                    await imagem.CopyToAsync(stream);
                    produto.imagem = "\\fotos\\" + nomeImagem;
                }
            }
           
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
          
            //ViewData["CategoriaId"] = new SelectList(_context.CATEGORIAS, "Id", "Id", produto.CategoriaId);
            //return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PRODUTOS == null)
            {
                return NotFound();
            }

            var produto = await _context.PRODUTOS.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.CATEGORIAS, "Id", "Id", produto.CategoriaId);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,descricaoproduto,valorproduto,unidadeproduto,CategoriaId")] Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.CATEGORIAS, "Id", "Id", produto.CategoriaId);
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PRODUTOS == null)
            {
                return NotFound();
            }

            var produto = await _context.PRODUTOS
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PRODUTOS == null)
            {
                return Problem("Entity set 'Contexto.PRODUTOS'  is null.");
            }
            var produto = await _context.PRODUTOS.FindAsync(id);
            if (produto != null)
            {
                _context.PRODUTOS.Remove(produto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
          return (_context.PRODUTOS?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
