using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
    public class ContasPagarWebController : Controller
    {


        //Lista de carro para simular o banco de dados
        private static List<ContasPagar> _lista = new List<ContasPagar>();

        private static int _id = 0; //Controla o IDc 


        // GET: PacienteWebController
        public ActionResult Index()
        {

            return View(_lista);
        }



        // GET: PacienteWebController/Create
        public ActionResult Adcionar()
        {
            return View(new ContasPagar());
        }

        // POST: PacienteWebController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Adcionar(ContasPagar contaspagar)
        {
            //Setar o código do carro
            contaspagar.id_conta_pagar = ++_id;
            //Adicionar o carro na lista
            _lista.Add(contaspagar);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Paciente cadastrado!";
            //Redireciona para o método Cadastrar
            return RedirectToAction("Index");

        }

        // GET: PacienteWebController/Edit/5
        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Atualizar(int id)
        {

            var index = _lista.FindIndex(c => c.id_conta_pagar == id);
            //Recuperar o carro através do ID
            var contaspagar = _lista[index];
            //Enviar o carro para a view
            return View(contaspagar);


        }

        // POST: PacienteWebController/Edit/5
        [HttpPost]

        public ActionResult Atualizar(ContasPagar contaspagar)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.id_conta_pagar == contaspagar.id_conta_pagar);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = contaspagar;
            //Mensagem de sucesso
            TempData["msg"] = "Conta Pagar atualizado!";
            //Redirect para a listagem/editar
            return RedirectToAction("Index");
            //REVER THAIS return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Excluir(int id)
        {

            var index = _lista.FindIndex(c => c.id_conta_pagar == id);
            //Recuperar o carro através do ID
            var contaspagar = _lista[index];
            //Enviar o carro para a view
            return View(contaspagar);


        }


        // POST: PacienteWebController/Delete/5
        [HttpPost]

        public ActionResult Excluir(int id, double valor)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.id_conta_pagar == id));
            //Mensagem de sucesso
            TempData["msg"] = "Conta Pagar removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }


    }
}
