using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// A simple person
    /// </summary>
    public class Person
    {
        #region attributes
        private String lastname;
        private String firstname;
        private String adresse;
        private String phone;
        #endregion

        #region properties
        /// <summary>
        /// get or set the person last name
        /// </summary>
        public string LastName 
		{ 
			get {return lastname;} 
			set {lastname = value;} 
		}
        /// <summary>
        /// get or set the person first name.
        /// </summary>
        public string FirstName 
		{ 
			get {return firstname;}
            set { firstname = value; }
        }
        
        /// <summary>
        /// get or set the person's address
        /// </summary>
        public string Address 
		{ 
			get {return adresse;}
			set { adresse = value; } 
		}
        
		/// <summary>
        /// get or set the phone number of the person
        /// </summary>
        public string Phone 
		{ 
			get {return phone;}
			set { phone = value; }
		}

        /// <summary>
        /// get the person's identity (LastName FirstName)
        /// </summary>
        public string Identity
        {
            get { return lastname + " " + firstname; }            
        }
        #endregion

        /// <summary>
        /// Init a person
        /// </summary>
        /// <param name="last">person's lastname</param>
        /// <param name="first">person's firstname</param>
        public Person(string last, string first)
        {
            lastname = last;
            firstname = first;

        }

        /// <summary>
        /// get a string value of the person
        /// </summary>
        /// <returns>a string contains the person's last & first names</returns>
        public override string ToString()
        {
            return Identity;
        }


    }
}
