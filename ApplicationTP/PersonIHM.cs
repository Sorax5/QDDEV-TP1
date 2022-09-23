﻿using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ApplicationTP
{
    public class PersonIHM : IPerson
    {

        #region attributes
        private Person personne;
        #endregion

        #region proprités
        /// <summary>
        /// image de la personne
        /// </summary>
        public BitmapImage Icon
        {
            get
            {
                switch (Gender)
                {
                    case GenderType.NEUTRAL:
                        return new BitmapImage(new Uri("pack://application:,,,/Images/contact_x.png"));
                    case GenderType.MALE:
                        return new BitmapImage(new Uri("pack://application:,,,/Images/contact_m.png"));
                    case GenderType.FEMALE:
                        return new BitmapImage(new Uri("pack://application:,,,/Images/contact_f.png"));
                }
                return null;
            }
            
        }

        /// <summary>
        /// personne
        /// </summary>
        public Person Personne
        {
            get { return personne; }
        }

        public bool IsMale
        {
            get => personne.Gender.Equals(GenderType.MALE);
            set
            {
                if (value.Equals(true))
                {
                    this.Gender = GenderType.MALE;
                }
            }
        }

        public bool Isfemale
        {
            get => personne.Gender.Equals(GenderType.FEMALE);
            set
            {
                if (value.Equals(true))
                {
                    this.Gender = GenderType.FEMALE;
                }
            }
        }


        #endregion


        public PersonIHM(Person p)
        {
            personne = p;
        }

        public string Address { get => personne.Address; set => personne.Address = value; }
        public string FirstName { get => personne.FirstName; set => personne.FirstName = value; }
        public GenderType Gender { get => personne.Gender; set => personne.Gender = value; }

        public string Identity => personne.Identity;

        public string LastName { get => personne.LastName; set => personne.LastName = value; }
        public string Phone { get => personne.Phone; set => personne.Phone = value; }

        public object Clone()
        {
            return new PersonIHM((Person)personne.Clone());
        }

        public void Copy(IPerson p)
        {
            personne.Copy(p);
        }
    }
}
