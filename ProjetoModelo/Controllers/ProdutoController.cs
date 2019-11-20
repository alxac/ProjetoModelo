using Aplicacao.Interface;
using Domain.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoModelo.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoApp produtoApp;

        public ProdutoController(IProdutoApp _produtoApp)
        {
            produtoApp = _produtoApp;
        }
        // GET: Produto
        public ActionResult Index()
        {
            return View(produtoApp.Listar());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View(produtoApp.ObterPorId(id));
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View(new Produto());
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            try
            {
                // TODO: Add insert logic here
                produtoApp.Adicionar(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View(produtoApp.ObterPorId(id));
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Produto produto)
        {
            try
            {
                // TODO: Add update logic here
                produtoApp.Atualizar(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View(produtoApp.ObterPorId(id));
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Produto produto)
        {
            try
            {
                // TODO: Add delete logic here
                produtoApp.Excluir(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}