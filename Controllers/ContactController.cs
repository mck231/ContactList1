using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactList1.Models;

namespace ContactList1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListContact()
        {
            List<People> people = new List<People>();

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "josh", LastName = "nik", EmailAddress = @"gdfsh@you.com",
            PeopleNotes = @"He's the not best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"nowhome st."});

             people.Add(new People { FirstName = "andy", LastName = "jgsk", EmailAddress = @"akljklsh@you.com",
            PeopleNotes = @"He's the not best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosdf@you.com",
            PeopleNotes = @"He's the not best!!!", PhoneNumber = @"291-233-4245", StreetAddress = @"awesdfasdme st."});

             people.Add(new People { FirstName = "breed", LastName = "nonly", EmailAddress = @"gadgh@you.com",
            PeopleNotes = @"He's not the best!!!", PhoneNumber = @"251-232-4245", StreetAddress = @"tesome st."});

            people.Add(new People { FirstName = "bret", LastName = "gabe", EmailAddress = @"gdfdh@you.com",
            PeopleNotes = @"He's not the best!!!", PhoneNumber = @"291-204-4245", StreetAddress = @"awegde st."});

             people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

             people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

             people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

             people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});

            people.Add(new People { FirstName = "Marco", LastName = "Cabrera", EmailAddress = @"gosh@you.com",
            PeopleNotes = @"He's the best!!!", PhoneNumber = @"291-234-4245", StreetAddress = @"awesome st."});


            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });

            people.Add(new People
            {
                FirstName = "Marco",
                LastName = "Cabrera",
                EmailAddress = @"gosh@you.com",
                PeopleNotes = @"He's the best!!!",
                PhoneNumber = @"291-234-4245",
                StreetAddress = @"awesome st."
            });


            return View(people);
        }
    }
}