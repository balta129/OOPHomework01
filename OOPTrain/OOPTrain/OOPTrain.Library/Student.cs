using System;
using Microsoft.Win32.SafeHandles;
using OOPTrain.Concrete;

namespace OOPtrain.Concrete;

public class Student
{
    private Class _class;
    public Class Class
    {
        get
        {
            return this._class;
        }
        internal set
        {
            this._class = value;
        }
    }

    public string Name;
    public DateTime birthDay;
    public Student(string name, DateTime birthDay)
    {   
        this.Validate(name,birthDay);
        this.Name = name;
        this.birthDay = birthDay;
    } 
    private void Validate(string name, DateTime birthDay)
    {
        if(string.IsNullOrEmpty(name))
        {
            throw new ApplicationException("Name must be filled");
        }
        
        if (name.Any(o => char.IsLetter(o) == false))
        {
            throw new ApplicationException("Name must contain only letter!");
        }
        if(DateTime.UtcNow.Year - birthDay.Year <= 7)
        {
            throw new ApplicationException("Birthdate must be bigger than 7");
        }
      
    }
}
 

