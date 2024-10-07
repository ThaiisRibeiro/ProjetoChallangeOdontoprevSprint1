using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
    public class ClinicaWebController : Controller
    {


        //Lista de carro para simular o banco de dados
        private static List<Clinica> _lista = new List<Clinica>();

        private static int _id = 0; //Controla o IDc 


        // GET: PacienteWebController
        public ActionResult Index()
        {

            return View(_lista);
        }



        // GET: PacienteWebController/Create
        public ActionResult Adcionar()
        {
            return View(new Clinica());
        }

        // POST: PacienteWebController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Adcionar(Clinica clinica)
        {
            //Setar o código do carro
            clinica.id_clinica = ++_id;
            //Adicionar o carro na lista
            _lista.Add(clinica);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Clinica cadastrada!";
            //Redireciona para o método Cadastrar
            return RedirectToAction("Index");

        }

        // GET: PacienteWebController/Edit/5
        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Atualizar(int id)
        {

            var index = _lista.FindIndex(c => c.id_clinica == id);
            //Recuperar o carro através do ID
            var clinica = _lista[index];
            //Enviar o carro para a view
            return View(clinica);


        }

        // POST: PacienteWebController/Edit/5
        [HttpPost]

        public ActionResult Atualizar(Clinica clinica)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.id_clinica == clinica.id_clinica);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = clinica;
            //Mensagem de sucesso
            TempData["msg"] = "Clinica atualizada!";
            //Redirect para a listagem/editar
            return RedirectToAction("Index");
            //REVER THAIS return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Excluir(int id)
        {

            var index = _lista.FindIndex(c => c.id_clinica == id);
            //Recuperar o carro através do ID
            var clinica = _lista[index];
            //Enviar o carro para a view
            return View(clinica);


        }


        // POST: PacienteWebController/Delete/5
        [HttpPost]

        public ActionResult Excluir(int id, string nome)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.id_clinica == id));
            //Mensagem de sucesso
            TempData["msg"] = "Paciente removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }


    }
}
