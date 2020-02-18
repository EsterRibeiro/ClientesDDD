using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FornecedoresDDD.Aplicacao.Interfaces;
using FornecedoresDDD.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FornecedoresDDD.Apresentacao.Controllers
{
    public class ProdutoMVCController : Controller
    {
        private readonly IProduto _produtoApp;

        //método construtor
        public ProdutoMVCController(IProduto iProduto)
        {
            _produtoApp = iProduto;
        }


        // GET: ProdutoMVC
        public ActionResult Index()
        {
            return View(_produtoApp.Listar());
        }

        // GET: ProdutoMVC/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_produtoApp.RecuperarPorId(id));
        }

        // GET: ProdutoMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            try
            {
                produto.Id = Guid.NewGuid();
                _produtoApp.Adicionar(produto);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: ProdutoMVC/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_produtoApp.RecuperarPorId(id));
        }

        // POST: ProdutoMVC/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produto produto)
        {
            try
            {
                // TODO: Add update logic here
                _produtoApp.Atualizar(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoMVC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}