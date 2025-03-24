using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Controllers
{
    public class ContactsController : Controller
    {
        
        public ContactsController(Request request) : base(request)
        {
        }

        public Response Add() => View();
        public Response Add(ContactViewModel model) => View(model);

        public Response AddContact()
        {
            var name = this.Request.Form["name"];
            var phone = this.Request.Form["phone"];

            var model = new ContactViewModel()
            {
                Name = name,
                PhoneNumber = phone

            };

            return View(model, "Added");
        }

        //public Response All()
        //{
        //    if (System.IO.File.Exists(Constants.FileName))
        //    {
        //        return File(Constants.FileName);
        //    }

        //    return Text("");
        //}
    }
}
