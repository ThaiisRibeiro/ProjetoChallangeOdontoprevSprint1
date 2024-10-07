using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
    public class FraudeWebController : Controller
    {


        //Lista de carro para simular o banco de dados
        private static List<Fraude> _lista = new List<Fraude>();

        private static int _id = 0; //Controla o IDc 


        // GET: PacienteWebController
        public ActionResult Index()
        {

            return View(_lista);
        }



        // GET: PacienteWebController/Create
        public ActionResult Adcionar()
        {
            return View(new Fraude());
        }

        // POST: PacienteWebController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Adcionar(Fraude fraude)
        {
            //Setar o código do carro
            fraude.id_fraude = ++_id;
            //Adicionar o carro na lista
            _lista.Add(fraude);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Fraude cadastrada!";
            //Redireciona para o método Cadastrar
            return RedirectToAction("Index");

        }

        // GET: PacienteWebController/Edit/5
        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Atualizar(int id)
        {

            var index = _lista.FindIndex(c => c.id_fraude == id);
            //Recuperar o carro através do ID
            var fraude = _lista[index];
            //Enviar o carro para a view
            return View(fraude);


        }

        // POST: PacienteWebController/Edit/5
        [HttpPost]

        public ActionResult Atualizar(Fraude fraude)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.id_paciente == fraude.id_paciente);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = fraude;
            //Mensagem de sucesso
            TempData["msg"] = "Fraude atualizada!";
            //Redirect para a listagem/editar
            return RedirectToAction("Index");
            //REVER THAIS return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Excluir(int id)
        {

            var index = _lista.FindIndex(c => c.id_fraude == id);
            //Recuperar o carro através do ID
            var fraude = _lista[index];
            //Enviar o carro para a view
            return View(fraude);


        }


        // POST: PacienteWebController/Delete/5
        [HttpPost]

        public ActionResult Excluir(int id, string nome)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.id_fraude == id));
            //Mensagem de sucesso
            TempData["msg"] = "Fraude removida!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }


    }
}