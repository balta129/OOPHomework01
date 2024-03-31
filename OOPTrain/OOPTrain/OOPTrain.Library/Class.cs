using System;
using OOPtrain.Concrete;
namespace OOPTrain.Concrete;

public class Class
{
     private List<Student> _students = new List<Student>();
        public IEnumerable<Student> Students
        {
            get
            {
                return this._students;
            }
        }
    public string Code;
    public List<Student >student = new List<Student>();
    public Class (string code, IEnumerable<Student> students)
    {
        this.Validate(code);
        this.Code = code;
        this._students.AddRange(students);
        foreach(Student student in Students)
        {
            student.Class = this;
        }
        

    }
    private void Validate(string code)
    {
        if(string.IsNullOrEmpty(code))
        {
            throw new ApplicationException("Code must be filled.");
        }
        if(code.Length > 4)
        {
            throw new ApplicationException("Code cant be this long.");
        }
        
    }
}