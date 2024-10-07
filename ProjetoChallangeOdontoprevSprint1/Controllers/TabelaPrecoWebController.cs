using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
    public class TabelaPrecoWebController : Controller
    {


        //Lista de carro para simular o banco de dados
        private static List<TabelaPreco> _lista = new List<TabelaPreco>();

        private static int _id = 0; //Controla o IDc 


        // GET: PacienteWebController
        public ActionResult Index()
        {

            return View(_lista);
        }



        // GET: PacienteWebController/Create
        public ActionResult Adcionar()
        {
            return View(new TabelaPreco());
        }

        // POST: PacienteWebController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Adcionar(TabelaPreco tabelapreco)
        {
            //Setar o código do carro
            tabelapreco.id_tabela_preco = ++_id;
            //Adicionar o carro na lista
            _lista.Add(tabelapreco);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Tabela preco cadastrada!";
            //Redireciona para o método Cadastrar
            return RedirectToAction("Index");

        }

        // GET: PacienteWebController/Edit/5
        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Atualizar(int id)
        {

            var index = _lista.FindIndex(c => c.id_tabela_preco == id);
            //Recuperar o carro através do ID
            var tabelapreco = _lista[index];
            //Enviar o carro para a view
            return View(tabelapreco);


        }

        // POST: PacienteWebController/Edit/5
        [HttpPost]

        public ActionResult Atualizar(TabelaPreco tabelapreco)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.id_tabela_preco == tabelapreco.id_tabela_preco);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = tabelapreco;
            //Mensagem de sucesso
            TempData["msg"] = "Tabela Preco atualizada!";
            //Redirect para a listagem/editar
            return RedirectToAction("Index");
            //REVER THAIS return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Excluir(int id)
        {

            var index = _lista.FindIndex(c => c.id_tabela_preco == id);
            //Recuperar o carro através do ID
            var tabelapreco = _lista[index];
            //Enviar o carro para a view
            return View(tabelapreco);


        }


        // POST: PacienteWebController/Delete/5
        [HttpPost]

        public ActionResult Excluir(int id, string nome)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.id_tabela_preco == id));
            //Mensagem de sucesso
            TempData["msg"] = "Paciente removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }


    }
}