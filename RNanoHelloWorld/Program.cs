using Ninject;
using RNanoHello.Model;
using RNanoHello.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RNanoHelloWorld
{
    class Program
    {
        private const string REQUEST = "api/Hello";
        private static string ServiceHost = ConfigurationManager.AppSettings["ApiServer"];

        static void Main(string[] args)
        {
            CallNotifyServiceUsingAPI();
            CallNotifyServiceUsingNinject();
            Console.ReadLine();
        }

        /// <summary>
        /// Call service directly using NinjectModule
        /// </summary>
        private static void CallNotifyServiceUsingNinject()
        {
            var standardKernel = new StandardKernel(new NinjectBindings());
            INotifyService _notifyService = standardKernel.Get<INotifyService>();
            
            var result = _notifyService.GetNotify();
            Console.WriteLine("Notification Message: {0} ", result.Message);
        }

        /// <summary>
        /// Call service via API
        /// </summary>
        private static async void CallNotifyServiceUsingAPI()
        {
            var baseAddress = ServiceHost;
            var serviceProxy = new HttpClient { BaseAddress = new Uri(baseAddress) };

            var response = await serviceProxy.GetAsync(REQUEST);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsAsync<MessageModel>();

            Console.WriteLine("Notification Message via API: {0} ", result.Message);
        }
    }
}
