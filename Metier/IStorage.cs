using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface IStorage
    {
        public Person Create();
        public void Delete(Person person);
        public void Update(Person person);
        public Directory Load();


    }
}
