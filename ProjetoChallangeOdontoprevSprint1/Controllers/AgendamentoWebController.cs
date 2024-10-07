using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
        public class AgendamentoWebController : Controller
        {


            //Lista de carro para simular o banco de dados
            private static List<Agendamento> _lista = new List<Agendamento>();

            private static int _id = 0; //Controla o IDc 


            // GET: PacienteWebController
            public ActionResult Index()
            {

                return View(_lista);
            }



            // GET: PacienteWebController/Create
            public ActionResult Adcionar()
            {
                return View(new Agendamento());
            }

            // POST: PacienteWebController/Create
            [HttpPost]
            //[ValidateAntiForgeryToken]
            public ActionResult Adcionar(Agendamento agendamento)
            {
            //Setar o código do carro
            agendamento.id_agendamento = ++_id;
                //Adicionar o carro na lista
                _lista.Add(agendamento);
                //Mandar uma mensagem de sucesso para a view
                TempData["msg"] = "Agendamento cadastrado!";
                //Redireciona para o método Cadastrar
                return RedirectToAction("Index");

            }

            // GET: PacienteWebController/Edit/5
            [HttpGet] //Abrir o formulário com os dados preenchidos
            public ActionResult Atualizar(int id)
            {

                var index = _lista.FindIndex(c => c.id_agendamento == id);
                //Recuperar o carro através do ID
                var agendamento = _lista[index];
                //Enviar o carro para a view
                return View(agendamento);


            }

            // POST: PacienteWebController/Edit/5
            [HttpPost]

            public ActionResult Atualizar(Agendamento agendamento)
            {
                //Atualizar o carro na lista
                var index = _lista.FindIndex(c => c.id_paciente == agendamento.id_paciente);
                //Substitui o objeto na posição do carro antigo
                _lista[index] = agendamento;
                //Mensagem de sucesso
                TempData["msg"] = "Agendamento atualizado!";
                //Redirect para a listagem/editar
                return RedirectToAction("Index");
                //REVER THAIS return RedirectToAction("editar");
            }

            [HttpGet] //Abrir o formulário com os dados preenchidos
            public ActionResult Excluir(int id)
            {

                var index = _lista.FindIndex(c => c.id_agendamento == id);
                //Recuperar o carro através do ID
                var agendamento = _lista[index];
                //Enviar o carro para a view
                return View(agendamento);


            }


            // POST: PacienteWebController/Delete/5
            [HttpPost]

            public ActionResult Excluir(int id, DateTime data)
            {
                //Remover o carro da lista
                _lista.RemoveAt(_lista.FindIndex(c => c.id_agendamento == id));
                //Mensagem de sucesso
                TempData["msg"] = "Agendamento removido!";
                //Redirecionar para a listagem
                return RedirectToAction("Index");
            }


        }
    }
