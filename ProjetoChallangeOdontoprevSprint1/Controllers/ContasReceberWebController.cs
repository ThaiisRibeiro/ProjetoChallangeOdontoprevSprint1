using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
    public class ContasReceberWebController : Controller
    {


        //Lista de carro para simular o banco de dados
        private static List<ContasReceber> _lista = new List<ContasReceber>();

        private static int _id = 0; //Controla o IDc 


        // GET: PacienteWebController
        public ActionResult Index()
        {

            return View(_lista);
        }



        // GET: PacienteWebController/Create
        public ActionResult Adcionar()
        {
            return View(new ContasReceber());
        }

        // POST: PacienteWebController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Adcionar(ContasReceber contasreceber)
        {
            //Setar o código do carro
            contasreceber.id_conta_receber = ++_id;
            //Adicionar o carro na lista
            _lista.Add(contasreceber);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Contas Receber cadastrado!";
            //Redireciona para o método Cadastrar
            return RedirectToAction("Index");

        }

        // GET: PacienteWebController/Edit/5
        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Atualizar(int id)
        {

            var index = _lista.FindIndex(c => c.id_conta_receber == id);
            //Recuperar o carro através do ID
            var contasreceber = _lista[index];
            //Enviar o carro para a view
            return View(contasreceber);


        }

        // POST: PacienteWebController/Edit/5
        [HttpPost]

        public ActionResult Atualizar(ContasReceber contasreceber)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.id_conta_receber == contasreceber.id_conta_receber);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = contasreceber;
            //Mensagem de sucesso
            TempData["msg"] = "Contas Receber atualizado!";
            //Redirect para a listagem/editar
            return RedirectToAction("Index");
            //REVER THAIS return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Excluir(int id)
        {

            var index = _lista.FindIndex(c => c.id_conta_receber == id);
            //Recuperar o carro através do ID
            var contasreceber = _lista[index];
            //Enviar o carro para a view
            return View(contasreceber);


        }


        // POST: PacienteWebController/Delete/5
        [HttpPost]

        public ActionResult Excluir(int id, double valor)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.id_conta_receber == id));
            //Mensagem de sucesso
            TempData["msg"] = "Contas Receber removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }


    }
}
