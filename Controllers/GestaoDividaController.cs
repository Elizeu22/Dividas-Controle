using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConrtroleDividas.Repositorio;
using ConrtroleDividas.Models;


namespace ConrtroleDividas.Controllers
{
    public class GestaoDividaController : Controller
    {
        // GET: GestaoDivida


        /// <summary>
        /// 
        /// </summary>
        /// <returns>listar Dividas</returns>
        public IActionResult ListarDividas()
        {
            var DividaRepositorio = new GestaoDividas();
            ModelState.Clear();

            return View(DividaRepositorio.SelecionarTodos());
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns>Cadastro de Divida</returns>
        public IActionResult CadastrarDivida()
        {
            return View();
            
        }


        [HttpPost]
        public IActionResult CadastrarDivida(Dividas CadastroDivida)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var DividaRepositorio = new GestaoDividas();

                    CadastroDivida.ValorDivida = (CadastroDivida.ValorProduto * CadastroDivida.QtdeProduto);

                    if (DividaRepositorio.CadastrarDivida(CadastroDivida))
                    {
                        
                        ViewBag.Message = "Cadastrado com sucesso";
                    }
                }

               
                return RedirectToAction("CadastrarDivida");
            }
            catch
            {
                return View();
            }

        }




       /// <summary>
       /// 
       /// </summary>
       /// <param name="id">Atualizacao de Dividas</param>
       /// <returns></returns>
        public IActionResult AtualizarDivida(int id)
        {
           
            try
            {
        
                var SelecionaDivida = new GestaoDividas();

                return View(SelecionaDivida.SelecionarTodos().Find(Dividas => Dividas.id==id));
               

            }
            catch
            {
                return NotFound();
            }

        }



        [HttpPost]
        public IActionResult AtualizarDivida(Dividas AtualizadoDivida)
        {
           
            try
            {
               

                var DividaRepositorio = new GestaoDividas();

                AtualizadoDivida.ValorDivida = (AtualizadoDivida.ValorProduto* AtualizadoDivida.QtdeProduto);

                DividaRepositorio.AtualizarDivida(AtualizadoDivida);



                return RedirectToAction("ListarDividas");


            }
            catch
            {
                return NotFound();
            }

        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Detalhes da Divida</param>
        /// <returns></returns>
        public IActionResult DetalheDivida(int id)
        {
            try
            {

                var SelecionaDivida = new GestaoDividas();

                return View(SelecionaDivida.SelecionarTodos().Find(Dividas => Dividas.id == id));


            }
            catch
            {
                return NotFound();
            }
        }






        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Excluir Divida</param>
        /// <returns></returns>
        public IActionResult ExcluirDivida(int id)
        {
            try
            {

                var SelecionaDivida = new GestaoDividas();

                return View(SelecionaDivida.SelecionarTodos().Find(Dividas => Dividas.id == id));


            }
            catch
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult ExcluirDivida(Dividas AtualizadoDivida)
        {

            try
            {


                var DividaRepositorio = new GestaoDividas();

        

                DividaRepositorio.ExcluirDivida(AtualizadoDivida.id);



                return RedirectToAction("ListarDividas");


            }
            catch
            {
                return NotFound();
            }

        }





    }

}


    
