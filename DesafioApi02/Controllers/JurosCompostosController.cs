using DesafioApi02.Model;
using DesafioApi02.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosCompostosController
    {
        public JurosCompostosController()
        {
        }

        [HttpGet]
        [Route("/calculajuros")]
        public async Task<JurosCompostosViewModel> Get(decimal valorInicial, int meses)
        {
            return await JurosCompostosService.GetJurosCompostos(valorInicial, meses);
        }
    }
}
