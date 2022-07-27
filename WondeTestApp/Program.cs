using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeTestApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            WondeApiServices.Services.SchoolService schService = new WondeApiServices.Services.SchoolService("d84d95f0416bc19c12ae854716a3bac48b07584b"); //Token
            var result = await schService.GetAll();

            Console.WriteLine("Hello, World!");

        }
    }
}
