using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Directory = LogicLayer.Directory;

namespace Serialization
{
    /// <summary>
    /// this class is used to serialize and deserialize a directory
    /// </summary>
    public class JsonStorage : IStorage
    {

        #region attributes
        private String file;
        private Directory directory;
        #endregion

        /// <summary>
        /// COnstructeur de la classe
        /// </summary>
        public JsonStorage()
        {
            this.file = Environment.CurrentDirectory + "directory.json";
        }

        /// <summary>
        /// Crée une nouvelle personne
        /// </summary>
        /// <returns></returns>
        public Person Create()
        {
            return new Person("","");
        }

        /// <summary>
        /// Supprime une personne du dictionnaire
        /// </summary>
        /// <param name="person"></param>
        public void Delete(Person person)
        {
            this.Save();
        }

        /// <summary>
        /// Deserialize le Dictionnaire
        /// </summary>
        /// <returns></returns>
        public Directory Load()
        {
            // load Directory from a Json file
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Directory));
                    directory = ser.ReadObject(fs) as Directory;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                directory = new Directory();
            }
            return directory;
        }

        /// <summary>
        /// Serialize le Dictionnaire
        /// </summary>
        /// <param name="person"></param>
        public void Update(Person person)
        {
            this.Save();
        }

        private void Save()
        {
            try
            {
                using (FileStream fs = new FileStream(file, FileMode.Create))
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Directory));
                    ser.WriteObject(fs, directory);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
