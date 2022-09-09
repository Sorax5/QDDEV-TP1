using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// A directory composes persons
    /// </summary>
    /// <see cref="Person"/>
    public class Directory
    {
        #region associations
        private List<Person> contact = new List<Person>();
        #endregion

        #region operations
        /// <summary>
        /// Add a person as a contact
        /// </summary>
        /// <param name="p">the person to add</param>
        public void NewContact(Person p)
        {
            contact.Add(p);  
        }
        /// <summary>
        /// Remove a person from the contacts
        /// </summary>
        /// <param name="p">person to remove</param>
        public void RemoveContact(Person p)
        {
            contact.Remove(p);
        }
        /// <summary>
        /// find contact by his id
        /// </summary>
        /// <param name="id"> identifiant of the Person</param>
        /// <returns> a Person </returns>
        public Person FindContact(String id)
        {
            return contact.Find(p => p.Identity == id);
        }
        /// <summary>
        /// List all the contacts
        /// </summary>
        /// <returns>An simple array containing contacts</returns>
        public Person[] ListContacts()
        {
            return contact.ToArray();
        }

        /// <summary>
        /// Get persons with lastname starts with the give letter 
        /// </summary>
        /// <param name="initial">the initial (case-sensitive)</param>
        /// <returns>an array with the contacts found</returns>
        public Person[] ListContacts(char initial)
        {
            List<Person> filtre = new List<Person>();
            foreach (Person h in contact)
            {
                if (h.LastName.StartsWith(initial.ToString()))
                {
                    filtre.Add(h);
                }
            }
            return filtre.ToArray();
        }
        #endregion
    }
}
