using Aplication.Aplication;
using Aplication.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoChallangeOdontoprevSprint1.Controllers
{
    public class PacienteWebController : Controller
    {
       

        //Lista de carro para simular o banco de dados
        private static List<Paciente> _lista = new List<Paciente>();

        private static int _id = 0; //Controla o IDc 
        

        // GET: PacienteWebController
        public ActionResult Index()
        {
            
            return View(_lista);
        }

     

        // GET: PacienteWebController/Create
        public ActionResult Adcionar()
        {
            return View(new Paciente());
        }

        // POST: PacienteWebController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Adcionar(Paciente paciente)
        { 
                //Setar o código do carro
                paciente.id_paciente = ++_id;
                //Adicionar o carro na lista
                _lista.Add(paciente);
                //Mandar uma mensagem de sucesso para a view
                TempData["msg"] = "Paciente cadastrado!";
                //Redireciona para o método Cadastrar
                return RedirectToAction("Index");
      
        }

        // GET: PacienteWebController/Edit/5
        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Atualizar(int id)
        {

            var index = _lista.FindIndex(c => c.id_paciente == id);
            //Recuperar o carro através do ID
            var paciente = _lista[index];
            //Enviar o carro para a view
            return View(paciente);


        }

        // POST: PacienteWebController/Edit/5
        [HttpPost]
       
        public ActionResult Atualizar(Paciente paciente)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.id_paciente == paciente.id_paciente);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = paciente;
            //Mensagem de sucesso
            TempData["msg"] = "Paciente atualizado!";
            //Redirect para a listagem/editar
            return RedirectToAction("Index");
            //REVER THAIS return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public ActionResult Excluir(int id)
        {

            var index = _lista.FindIndex(c => c.id_paciente == id);
            //Recuperar o carro através do ID
            var paciente = _lista[index];
            //Enviar o carro para a view
            return View(paciente);


        }


        // POST: PacienteWebController/Delete/5
        [HttpPost]
       
        public ActionResult Excluir(int id,string nome)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.id_paciente == id));
            //Mensagem de sucesso
            TempData["msg"] = "Paciente removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

        
    }
}
