using LogicLayer;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class TestPerson
    {
        private Person CreatePerson()
        {
            return new Person("doe", "john");
        }

        [Fact]
        public void TestFirstName()
        {
            Person p = CreatePerson();
            Assert.Equal("john", p.FirstName);
            p.FirstName = "bill";
            Assert.Equal("bill", p.FirstName);
        }

        [Fact]
        public void TestLastName()
        {
            Person p = CreatePerson();
            Assert.Equal("doe", p.LastName);
            p.LastName = "smith";
            Assert.Equal("smith", p.LastName);
        }

        [Fact]
        public void TestAddress()
        {
            Person p = CreatePerson();
            String s = "7b, sesame street";
            p.Address = s;
            Assert.Equal(s, p.Address);
        }

        [Fact]
        public void TestPhone()
        {
            Person p = CreatePerson();
            string s = "03-80-81-82-83";
            p.Phone = s;
            Assert.Equal(s, p.Phone);
        }

        [Fact]
        public void TestIdentity()
        {
            Person p = CreatePerson();
            Assert.Equal("doe john", p.Identity);
        }

        [Fact]
        public void TestGender()
        {
            Person p = CreatePerson();
            Assert.Equal(GenderType.NEUTRAL, p.Gender);
        }

        [Fact]
        public void TestCopy()
        {
            Person p = new Person("Jean","Michel");
            Person p2 = new Person(p);
            Assert.Equal(p.LastName, p2.LastName);
            Assert.Equal(p.FirstName, p2.FirstName);
            Assert.Equal(p.Address, p2.Address);
            Assert.Equal(p.Phone, p2.Phone);
            Assert.Equal(p.Gender, p2.Gender);

            p.LastName = "Dupont";
            p.FirstName = "Jacques";
            p.Address = "1 rue de la paix";
            p.Phone = "01-02-03-04-05";
            p.Gender = GenderType.MALE;

            p2.Copy(p);

            Assert.Equal(p.LastName, p2.LastName);
            Assert.Equal(p.FirstName, p2.FirstName);
            Assert.Equal(p.Address, p2.Address);
            Assert.Equal(p.Phone, p2.Phone);
            Assert.Equal(p.Gender, p2.Gender);
        }
    }
}