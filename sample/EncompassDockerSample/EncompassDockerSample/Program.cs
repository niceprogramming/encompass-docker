using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllieMae.Encompass.BusinessObjects.ExternalOrganization;
using EllieMae.Encompass.Client;

namespace EncompassDockerSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting");
                var clientId = ConfigurationManager.AppSettings["ClientId"];
                var username = ConfigurationManager.AppSettings["Username"];
                var password = ConfigurationManager.AppSettings["Password"];
                new EllieMae.Encompass.Runtime.RuntimeServices().Initialize();

                Start(clientId, username, password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        private static void Start(string clientId, string username, string password)
        {
            var session = new Session();
            session.Start($@"https://{clientId}.ea.elliemae.net${clientId}", username, password);

            var currentUser = session.GetCurrentUser();

            Console.WriteLine(currentUser.ID);
            Console.WriteLine(currentUser.Personas.ToString());

            session.End();
        }
    }
}
