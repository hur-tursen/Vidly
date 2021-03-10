using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        string barisDescription = "";
        string simayDescription = "";
        string zeynepDescription = "";

        List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Kuzey Tekinoğlu", Status = "success", Description = "A little edgy but trustful person.", LongDescription =
                    "One day, a good hearted person sees his love in his big brother's arm and loses all his hopes to live, gives himself to drinking. His brtother" +
            "comes to bring him to home. While they fight in the car, big brother hits a pedesterian and escape from the crime scene back to their home. Soon the police " +
            "find them but when police asks for the responsible, he makes an ultimate sacrifice to save his big brother and tells them he did it.\n\nKuzey is the little brother here," +
            "made an ultimate decision to save his life and being called criminal as his brother, Güney, is a very talented smart and gifted man. Kuzey sent to prison for 4 years" +
            " and it changed him much. Although he protects himself with being the tough guy, the little boy within him stills lingers in deeps.\n\nHe is married to Simay, " +
            "flirting with Zeynep but loves Cemre." },
                new Customer { Name = "Güney Tekinoğlu", Status = "danger",  Description = "Dangerous greed user cykopat that needs to be overwatched all the time.", LongDescription =
                    "One day, a good hearted person sees his love in his big brother's arm and loses all his hopes to live, gives himself to drinking. His brtother" +
            "comes to bring him to home. While they fight in the car, big brother hits a pedesterian and escape from the crime scene back to their home. Soon the police " +
            "find them but when police asks for the responsible, he makes an ultimate sacrifice to save his big brother and tells them he did it.\n\nGüney is the big brother here," +
            " driven to a life which he has to a lie everyone. Nobody should know the truth or he will lose all the power he gained and his brother would went to prison for nothing." +
            "\n\n Although he is married to Banu, he loves Cemre but sacrificied his love for his brother as his brother sacrificied his life for himself."},
                new Customer { Name = "Cemre Çayak Hakmen", Status = "success",  Description = "Angel reflection on earth with a little cleptomancy behaviour.", LongDescription = "One day, a good hearted person sees his love in his big brother's arm and loses all his hopes to live, gives himself to drinking. His brtother" +
            "comes to bring him to home. While they fight in the car, big brother hits a pedesterian and escape from the crime scene back to their home. Soon the police " +
            "find them but when police asks for the responsible, he makes an ultimate sacrifice to save his big brother and tells them he did it.\n\nCemre is the girl here, " +
            "a beatiful good hearted angel. She finds herself between the love of the two brothers but she knows that her hearth is always belongs to Kuzey.\n\n" +
            "She was engaged to Güney, is married to Barış but loves Kuzey."},
                new Customer { Name = "Banu Sinaner Tekinoğlu", Status = "warning", Description = "Rich family's little girl has grown up to hide her psychological trams.", LongDescription =
                    "One day, a good hearted person sees his love in his big brother's arm and loses all his hopes to live, gives himself to drinking. His brtother" +
            "comes to bring him to home. While they fight in the car, big brother hits a pedesterian and escape from the crime scene back to their home. Soon the police " +
            "find them but when police asks for the responsible, he makes an ultimate sacrifice to save his big brother and tells them he did it.\n\nBanu is wife of the big brother, Güney" +
            ". Her family is a very respectable and rich. Her loves for Güney lingers from unknown places for unknown reasons but she is very clever and usually gets anything she wants."},
                new Customer { Name = "Barış Hakmen", Status = "danger",  Description = "Adopt daddy issues put his ambition to a dangerous place. "},
                new Customer { Name = "Simay Canay Tekinoğlu", Status = "danger" ,  Description = "Most dangerous ALIVE person that can do anything harmful to have fun for putting and watching watch Kuzey in a painful situtaion"},
                new Customer { Name = "Zeynep Çiçek", Status = "warning",  Description = "Hiding her demonic face under a cheerful designer girl."}
            };
        
        public ActionResult Index(String name)
        {
            var movie = new Movie
            {
                Name = "s"
            };


            var viewModel = new CustomersIndexViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("customers/details/{name}")]
        public ActionResult Details(String name)
        {

            System.Diagnostics.Debug.WriteLine(customers);
            var customer = customers.Find(x => x.Name == name);
            System.Diagnostics.Debug.WriteLine(customer);
            if (customer == null)
            {
                return HttpNotFound();
            }
            

            var viewModel = new CustomersDetailsViewModel
            {
                CustomerName = name,
                CustomerDescription = customer.LongDescription
            };
            return View(viewModel);
        }

    }
}