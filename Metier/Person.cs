using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LogicLayer
{
    /// <summary>
    /// A simple person
    /// </summary>
    [DataContract]
    public class Person : IPerson
    {
        #region attributes
        [DataMember]
        private String lastname;
        [DataMember]
        private String firstname;
        [DataMember]
        private String adresse;
        [DataMember]
        private String phone;
        [DataMember]
        private GenderType gender;
        #endregion

        #region properties
        /// <summary>
        /// get or set the person last name
        /// </summary>
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        /// <summary>
        /// get or set the person first name.
        /// </summary>
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        /// <summary>
        /// get or set the person's address
        /// </summary>
        public string Address
        {
            get { return adresse; }
            set { adresse = value; }
        }

        /// <summary>
        /// get or set the phone number of the person
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// get the person's identity (LastName FirstName)
        /// </summary>
        public string Identity
        {
            get { return lastname + " " + firstname; }
        }

        /// <summary>
        /// Setter & Getter of the gender 
        /// </summary>
        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }
        #endregion

        /// <summary>
        /// Init a person
        /// </summary>
        /// <param name="last">person's lastname</param>
        /// <param name="first">person's firstname</param>
        public Person(string last, string first, GenderType gender = GenderType.NEUTRAL)
        {
            lastname = last;
            firstname = first;
            this.gender = gender;
            this.adresse = "";
        }
        /// <summary>
        /// Copy Constuctor
        /// </summary>
        /// <param name="p">The person to copy</param>
        public Person(Person p)
        {
            lastname = p.lastname;
            firstname = p.firstname;
            adresse = p.adresse;
            phone = p.phone;
            gender = p.gender;
        }
        /// <summary>
        /// Update person information
        /// </summary>
        /// <param name="p">Person to copy</param>
        public void Copy(IPerson p)
        {
            
            lastname = p.LastName;
            firstname = p.FirstName;
            adresse = p.Address;
            phone = p.Phone;
            gender = p.Gender;
        }

        /// <summary>
        /// get a string value of the person
        /// </summary>
        /// <returns>a string contains the person's last & first names</returns>
        public override string ToString()
        {
            return Identity;
        }

        /// <summary>
        /// Equals of the Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Person person &&
                   lastname == person.lastname &&
                   firstname == person.firstname &&
                   adresse == person.adresse &&
                   phone == person.phone &&
                   gender == person.gender;
        }

        /// <summary>
        /// Return a clone of the instance
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Person(this);
        }
    }
}
