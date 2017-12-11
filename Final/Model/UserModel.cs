using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Model
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public UserAddress Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool Login(string userName, string userPassword)
        {
            UserName = userName;
            Password = userPassword;
            
            return true;
        }

        public bool Logoff(string userName, string userPassword)
        {
            UserName = userName;
            Password = userPassword;

            return true;
        }

    }

    public class UserAddress
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }

    public class Applicant : User
    {
        public float GPA { get; set; }
        public string HighSchool { get; set; }
        public string Major { get; set; }
        public int ParentsIncome { get; set; }
        public string Comments { get; set; }
        public DateTime InterviewTime { get; set; }
        public bool IsEligible{ get; set; }
        public bool IsAdmitted { get; set; }
        public bool StudentID { get; set; }

        public void Schedule_Interview()
        {
        }


        public void Cancel_Interview()
        {
        }

        public void Update_Bio()
        {
        }

        public void View_fees()
        {
        }

    }

    public class AdmissionsCounsler : User
    {
        public  void ListApplicants(IEnumerable<Applicant> applicantList)
        {
            
        }

    }
}