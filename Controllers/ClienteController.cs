using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            List<Cliente> clientes = new List<Cliente>
           {
               new Cliente
               {
                   id= "1",
                   correo="jgaguas@espe.edu.ec",
                   edad="21",
                   nombre="Gustavo Aguas"
               },
                new Cliente
               {
                   id= "2",
                   correo="jspaucar@espe.edu.ec",
                   edad="21",
                   nombre="Sebastian Paucar"
               }


           };
            return clientes; 
        }

        [HttpGet]
        [Route("listarid")]
        public dynamic listarClienteid(int codigo)
        {
            return new Cliente
            {
                id = codigo.ToString(),
                correo = "pepa@gmail.com",
                edad = "50",
                nombre = "Peppa Pig"
            };
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)
        {
             cliente.id="3";
            return new
            {
                success = true,
                message = "Cliente Registrado",
                result = cliente
            };
        }

        [HttpPost]
        [Authorize]
        [Route("eliminar")]
        
        public dynamic eliminarCliente(Cliente cliente)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var rToken = Jwt.validarToken(identity);

            if (!rToken.success) return rToken;
            Usuario usuario = rToken.result;

            if(usuario.rol != "admin")
            {
                return new
                {
                    success = false,
                    message = "No tienes los permisos para eliminar Clientes",
                    result = ""
                };
            }

            return new
            {
                success = true,
                message = "cliente eliminado",
                result = cliente
            };
        }
    }
}
