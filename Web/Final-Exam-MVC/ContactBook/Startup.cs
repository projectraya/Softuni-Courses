using BasicWebServer.Server;
using BasicWebServer.Server.Controllers;
using ContactBook.Controllers;
using System.Threading.Tasks;
using BasicWebServer.Server.Responses;

namespace ContactBook
{
    public class Startup
    {
        public static async Task Main()
        {
            HttpServer server = new HttpServer(routes => routes
            .MapGet<ContactsController>("/Contacts/Add", c => c.Add())
            .MapPost<ContactsController>("/Contacts/Add", c => c.AddContact()));

            await server.Start();
        }
        

    }
}
