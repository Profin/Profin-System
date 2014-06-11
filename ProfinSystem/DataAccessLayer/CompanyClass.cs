using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CompanyClass
    {
        public CompanyClass() { }

        string companyID;

        public string CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        string registrationNum;

        public string RegistrationNum
        {
            get { return registrationNum; }
            set { registrationNum = value; }
        }

        string fspNum;

        public string FspNum
        {
            get { return fspNum; }
            set { fspNum = value; }
        }

        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string initials;

        public string Initials
        {
            get { return initials; }
            set { initials = value; }
        }

        string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        string phoneNo;

        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        string faxNo;

        public string FaxNo
        {
            get { return faxNo; }
            set { faxNo = value; }
        }

        string cellNo;

        public string CellNo
        {
            get { return cellNo; }
            set { cellNo = value; }
        }

        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        string region;

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        string suburb;

        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        string town;

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        string postalCode;

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

    }
}
