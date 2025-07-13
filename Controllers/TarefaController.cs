using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trilha_Net_MVC_Desafio.Context;
using Trilha_Net_MVC_Desafio.Models;

namespace Trilha_Net_MVC_Desafio.Controllers
{
    public class TarefaController : Controller
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }
        public IActionResult Editar(int id)
        {
            //Buscar no banco
            var Tarefa = _context.Tarefas.Find(id);
            if (Tarefa == null)
                return RedirectToAction(nameof(Index));
            return View(Tarefa);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa Tarefa)
        {
            var TarefaBanco = _context.Tarefas.Find(Tarefa.Id);

            TarefaBanco.Titulo = Tarefa.Titulo;
            TarefaBanco.Descricao = Tarefa.Descricao;
            TarefaBanco.Data = Tarefa.Data;
            TarefaBanco.Status = Tarefa.Status;

            _context.Tarefas.Update(TarefaBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var Tarefa = _context.Tarefas.Find(id);

            if (Tarefa == null)
                return RedirectToAction(nameof(Index));

            return View(Tarefa);
        }
        public IActionResult Deletar(int id)
        {
            //Buscar no banco
            var Tarefa = _context.Tarefas.Find(id);

            if (Tarefa == null)
                return RedirectToAction(nameof(Index));
            return View(Tarefa);
        }

        [HttpPost]
        public IActionResult Deletar(Tarefa Tarefa)
        {
            var TarefaBanco = _context.Tarefas.Find(Tarefa.Id);

            _context.Tarefas.Remove(TarefaBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}