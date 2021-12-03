using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Annotation
{
    class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee Class Validation");
            Console.WriteLine("-------------------------");
            Employee objEmployee = new Employee();
            objEmployee.Name = "Rutwik";
            objEmployee.Age = 21;
            objEmployee.PhoneNumber = "8007356529";
            objEmployee.Email = "rutwikgulhaneg@gmail.com";
            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name : {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message :: {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name : " + objEmployee.Name + "\n" + "Age : " + objEmployee.Age + "\n" + "Phone Number : " + objEmployee.PhoneNumber + "\n" + "Email Address : " + objEmployee.Email);
            }
        }
    }
}