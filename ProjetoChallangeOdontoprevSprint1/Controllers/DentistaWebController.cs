using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
    public class DentistaWebController : Controller
    {


        //Lista de carro para simular o banco de dados
        private static List<Dentista> _lista = new List<Dentista>();

        private static int _id = 0; //Controla o IDc 


        // GET: PacienteWebController
        public ActionResult Index()
        {

            return View(_lista);
        }



        // GET: PacienteWebController/Create
        public ActionResult Adcionar()
        {
            return View(new Dentista());
        }

        // POST: PacienteWebController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Adcionar(Dentista dentista)
        {
            //Setar o código do carro
            dentista.id_dentista = ++_id;
            //Adicionar o carro na lista
            _lista.Add(dentista);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Paciente cadastrado!";
            //Redireciona para o método Cadastrar
            return RedirectToAction("Index");

        }

        // GET: PacienteWebController/Edit/5
        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Atualizar(int id)
        {

            var index = _lista.FindIndex(c => c.id_dentista == id);
            //Recuperar o carro através do ID
            var dentista = _lista[index];
            //Enviar o carro para a view
            return View(dentista);


        }

        // POST: PacienteWebController/Edit/5
        [HttpPost]

        public ActionResult Atualizar(Dentista dentista)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.id_dentista == dentista.id_dentista);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = dentista;
            //Mensagem de sucesso
            TempData["msg"] = "Dentista atualizado!";
            //Redirect para a listagem/editar
            return RedirectToAction("Index");
            //REVER THAIS return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Excluir(int id)
        {

            var index = _lista.FindIndex(c => c.id_dentista == id);
            //Recuperar o carro através do ID
            var dentista = _lista[index];
            //Enviar o carro para a view
            return View(dentista);


        }


        // POST: PacienteWebController/Delete/5
        [HttpPost]

        public ActionResult Excluir(int id, string nome)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.id_dentista == id));
            //Mensagem de sucesso
            TempData["msg"] = "Dentista removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }


    }
}
