using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibary;

namespace BusinessLibary
{
    public class businessOperations
    {
        dataOperations objD = new dataOperations();
        List<string> lstPeople = new List<string>();
        List<string> replaceDomains = new List<string>();
        List<User> middlenames = new List<User>();
        public List<string> viewDomainsToPres(string domain)
        {
            lstPeople = objD.ReadFile();
            foreach (var item in lstPeople)
            {
                if (item.Contains(domain))
                {
                    Console.WriteLine(item);
                }
            }
            return lstPeople;
        }
        public List<string> ReplaceToPres(string orginDomain, string replacementDomain)
        {
            replaceDomains = objD.ReadFileForDomains();

            foreach (var item in replaceDomains)
            {

                Console.WriteLine(item.Replace(orginDomain, replacementDomain));

            }
            return replaceDomains;



        }
        //The commented out part is for when you want use the User class method 
        public /*List<User>*/ List<string>middlenameToPres()
        {
           var names = objD.ReadFile();

          
            foreach (var item in names)
            {
                var arrPeople = item.Split(',');
                string middle=arrPeople[2];///If you using user class comment this out
                string first = arrPeople[1];///If you using user class comment this out
                //var namess = new User()
                //{
                //    Id = arrPeople[0],
                //    FirstName= arrPeople[1],
                //    MiddleName= arrPeople[2],
                //    LastName= arrPeople[3],
                //};
                //middlenames.Add(namess);
                // Console.WriteLine($"NAME:{namess.FirstName} \t\t MIDDLENAME:{namess.MiddleName.Substring(0,1).ToUpper()}");

                Console.WriteLine($"NAME:{first} \t\t MIDDLENAME:{middle.Substring(0, 1).ToUpper()}");///If you using user class comment this out

            }
            //return middlenames;
            return names;///If you using user class comment this out


        }



    }
    public class User 
        {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string IPAddress { get; set; }
        public string Test { get; set; }
    }

}      

 
   