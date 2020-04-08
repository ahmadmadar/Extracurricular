using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_API.Models;

namespace Test_API.Controllers
{
    public class ContactController : ApiController
    {
        Contacts[] contacts = new Contacts[]
        {
            new Contacts() {ContactID = 0, FirstName = "Kyle", LastName = "Lowry"},
            new Contacts() {ContactID = 1, FirstName = "Pascal", LastName = "Siakam"},
            new Contacts() {ContactID = 2, FirstName = "Fred", LastName = "VanVleet"}

        };

        // GET: api/Contact
        public IEnumerable<Contacts> Get()
        {
            return contacts;
        }

        // GET: api/Contact/5
        public IHttpActionResult Get(int id)
        {
            Contacts contact = contacts.FirstOrDefault(c => c.ContactID == id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST: api/Contact
        public IEnumerable<Contacts> Post([FromBody]Contacts newContact)
        {
            List<Contacts> contactList = contacts.ToList();
            newContact.ContactID = contactList.Count();
            contactList.Add(newContact);
            contacts = contactList.ToArray();

            return contacts;
        }

        // PUT: api/Contact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contact/5
        public void Delete(int id)
        {
        }
    }
}
