using System;
using System.Collections.Generic;
using System.Threading;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Services.Implementations;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService

    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            
        
            for (int i = 0; i < 8; i++){

                Person person = MockPerson(i);

                persons.Add(person);
            }
            return persons;
        }

      

        public Person FindByID(long id)
        {
           return new Person{
               Id = IncrementAndGet(),
               FirstName = "Marcio",
               LastName = "Pereira",
               Address = "São Joaquim do Monte - PE",
               Gender = "Male"
           };
        }

        public Person Update(Person person)
        {

            return person;
        }
        private Person MockPerson(int i)
        {
           return new Person{
               Id = IncrementAndGet(),
               FirstName = "Person name" + i,
               LastName = "Person last name " + i,
               Address = "Outra Cidade"+ i,
               Gender = "Male"
           };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

    }
}  