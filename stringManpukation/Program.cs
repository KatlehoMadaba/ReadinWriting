using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLibary;

namespace stringManpukation
{
    class Program
    {
        static void Main(string[] args)
        {
  
            bool continueLoop = true;
       
            string domain = "";
            string replacevar = "";
            businessOperations objB = new businessOperations();


            do
            {
                Console.WriteLine("Option1:View domains only");
                Console.WriteLine("Option2:enter the domanin");
                Console.WriteLine("Option3:To convert the middle name to upper case");
                Console.WriteLine("Please enter number 0 to exit or enter any number to continue: ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("What domain do you want to enter:");
                    domain = Console.ReadLine();
                    objB.viewDomainsToPres(domain);
                    Console.WriteLine("====================================================================================================================================================");
                 }
                else if(option == "2")
                {
                    Console.WriteLine("What domain do you want replace:");
                    string orginDomain = Console.ReadLine();
                    Console.WriteLine("Enter the domain you want repalce it with:");
                    string replacementDomain = Console.ReadLine();
                    objB.ReplaceToPres(orginDomain,replacementDomain);
                    Console.WriteLine("====================================================================================================================================================");
                }
                else if (option == "3")
                {
                    objB.middlenameToPres();
                }
                if (option == "0")
                {
                    continueLoop = false;
                    break;
                }

            } while (continueLoop);
        }
    }
}
