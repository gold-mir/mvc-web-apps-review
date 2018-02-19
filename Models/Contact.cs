using System.Collections.Generic;

namespace Application.Models
{
    public class Contact
    {
        public Contact(string name, string email, string phone)
        {
            _name = name;
            _email = email;
            _phone = phone;

            allContacts.Add(this);
            _id = maxID++;
        }

        private static List<Contact> allContacts = new List<Contact>();
        private static int maxID = 0;

        public static Contact GetByID(int id)
        {
            foreach(Contact c in allContacts)
            {
                if (c.GetID() == id)
                {
                    return c;
                }
            }

            return null;
        }

        public static List<Contact> GetAllInstances()
        {
            return allContacts;
        }

        private string _name;
        private string _email;
        private string _phone;
        private int _id;

        public int GetID()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetEmail()
        {
            return _email;
        }

        public string GetPhone()
        {
            return _phone;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public void SetPhone(string phone)
        {
            _phone = phone;
        }
    }
}
