using FLmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLmvc.Data
{
    public class PersonOperations
    {

        private List<Person> persons = new List<Person>();
        
        public Person GetPerson()
        {
            Person p = new Person()
            {
                Firstname = "Erik",
                Lastname = "Öberg",
                Age = 42,
                Id = 1
            };
            return p;
        }

        public List<Person> GetPersons()
        {
            Person p = new Person()
            {
                Firstname = "Erik",
                Lastname = "Öberg",
                Age = 42,
                Id = 1
            };
            persons.Add(p);
            p = new Person()
            {
                Firstname = "Erasdfik",
                Lastname = "asdf",
                Age = 42,
                Id = 2
            };
            persons.Add(p);
            return persons;
        }
    }
}