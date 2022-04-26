using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Andrew Williamson / P113357.
// Date Started: 09/06/2021.
// Date Finished: 17/06/2021.
namespace MegaBooksStore
{
    [Serializable]
    class Customer
    {
        // Class variables that every customer will have.
        private string custID;
        private string name;
        private string location;
        private string email;

        // Overloaded constructor for the unknown/anonymous customer.
        public Customer()
        {
            custID = "C999";
            name = "unknown";
            location = "unknown";
            email = "unknown";
        }
        // Overloaded constructor for a standard customer.
        public Customer(string newCustID, string newName, string newLocation, string newEmail)
        {
            custID = newCustID;
            name = newName;
            location = newLocation;
            email = newEmail;
        }

        // Getter and Setter methods the the class variables.
        public string GetCustID()
        {
            return custID;
        }
        public void SetCustID(string newCustID)
        {
            custID = newCustID;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetLocation()
        {
            return location;
        }
        public void SetLocation(string newLocation)
        {
            location = newLocation;
        }

        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string newEmail)
        {
            email = newEmail;
        }

        public string DisplayOneCustomer()
        {
            return GetCustID() + " " +
                    GetName() + " " +
                    GetLocation() + " " +
                    GetEmail();
        }

    }
}
