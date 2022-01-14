using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClienteServiciosWCF.Controllers
{
    public class TestRandomNumerosController : Controller
    {
        ServiceRandomNumbersClient client;

        public TestRandomNumerosController()
        {
            this.client =
                new ServiceRandomNumbersClient
(ServiceRandomNumbersClient.EndpointConfiguration.BasicHttpBinding_IServiceRandomNumbers);
        }

        public async Task <IActionResult> Index()
        {
            int[] numeros = await this.client.GetRandomNumbersAsync();
            return View(numeros);
        }
    }
}
