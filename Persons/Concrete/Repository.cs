using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Abstract;
using Persons.Models;    

namespace Persons.Concrete
{
    public class PersonsRepository<T> : IRepository<T> where T:Person
    {
        private List<Person> list;

        public PersonsRepository()
        {
            list = new List<Person> {
                new Person { ID = 1, Age = 20, Name = "John" },
                new Person { ID = 2, Age = 25, Name = "Martin" },
                new Person { ID = 3, Age = 18, Name = "Lusy" },
                new Person { ID = 4, Age = 33, Name = "Ivan" },
                new Person { ID = 5, Age = 26, Name = "George" },
                new Person { ID = 6, Age = 34, Name = "Olga" },
                new Person { ID = 7, Age = 19, Name = "Anna" },
                new Person { ID = 8, Age = 22, Name = "Pablo" },
                new Person { ID = 9, Age = 37, Name = "Erik" },
                new Person { ID = 10, Age = 26, Name = "Liza" },
                new Person { ID = 11, Age = 24, Name = "Gomer" },
                new Person { ID = 12, Age = 34, Name = "Petr" },
            };
        }


        public Task<T> GetItemAsync(int Id)
        {
            return Task.Run<T>(() =>
            {
                return list.FirstOrDefault(i => i.ID == Id) as T;
            });
        }

        public Task<List<T>> GetListAsync()
        {
            return Task.Run(() => list as List<T>);
        }
    }
}
