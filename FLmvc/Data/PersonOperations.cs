using FLmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLmvc.Data
{
    public class PersonOperations
    {

        private List<Person> persons = new List<Person>
        {
            new Person {Id=1, Firstname= "Erik", Lastname="Öberg", Age=42 },
            new Person {Id=2, Firstname= "Mary", Lastname="Jenkins", Age=12 },
        };


        public Person GetPersonById(int id)
        {
            var result = persons.FirstOrDefault(p => p.Id == id);
            return result;
        }

        public List<Person> GetPersons()
        {
            return persons;
        }

    }
}