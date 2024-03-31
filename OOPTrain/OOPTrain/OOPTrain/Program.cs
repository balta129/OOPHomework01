using System;
using Microsoft.Win32.SafeHandles;
using OOPtrain.Concrete;
using OOPTrain.Concrete;

namespace OOPT
{
    public class Program
    {
        static void Main(string [] args)
        {    
            Student student1 = new Student("Hamza", new DateTime(1999, 7, 16));     
            Student student2 = new Student("Balta", new DateTime(1999, 7, 16));  
            Class class1 = new Class("11A", new Student[]
            {
                student1
            });
            Class class2 = new Class("11B", new Student[]
            {   
                student2
            });
            student1.Class = class2;
            Console.WriteLine($"Student name: {student1.Name}, Age: {DateTime.UtcNow.Year - student1.birthDay.Year}, Class: {student1.Class.Code}");
            Console.WriteLine($"Student name: {student2.Name}, Age: {DateTime.UtcNow.Year - student2.birthDay.Year}, Class: {student2.Class.Code}");


        }
    }
}
