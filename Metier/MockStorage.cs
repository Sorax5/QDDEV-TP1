using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class MockStorage : IStorage
    {
        public Person Create()
        {
            return new Person("","");
        }

        public void Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public Directory Load()
        {
            Directory directory = new Directory();
            directory.NewContact(new Person("harris", "steve", GenderType.MALE));
            directory.NewContact(new Person("dickinson", "bruce"));
            directory.NewContact(new Person("murray", "dave", GenderType.FEMALE));
            directory.NewContact(new Person("smith", "adrian", GenderType.MALE));
            directory.NewContact(new Person("gers", "jannick"));
            directory.NewContact(new Person("mc brain", "nicko", GenderType.FEMALE));
            return directory;
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
