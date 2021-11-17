using System;

//Never ever make your class fields as Public, dont give the access of the fields to anyone, instead use the set and get methods for any operation to be performed on the class fields

//Programming languages that do not have properties uses Getter and Setter methods to Encapsulate and Protect the fields
//As a result we have a better control over what gets assigned to the fields and what is returned from them

namespace _26.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.SetId(10);
            //S1.SetName(null);

            //If name is not set then it will print No name is given, if the name field is set to null then it will give the exception
            Console.WriteLine($"Student Id = {S1.GetId()}\nName = {S1.GetName()}\nPass Marks = {S1.GetPassMarks()} ");
        }
    }

    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMarks = 35;

        //This SetId method will only set the Id, but cannot return it back to the user
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("The Id must be greater than Zero");
            }
            this._ID = Id;
        }

        //This GetId method will return the value of the Id back to the user when this method is called
        public int GetId()
        {
            return this._ID;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("The Name field must not be empty");
            }
            else
            {
                this._Name = Name;
            }
        }

        public string GetName()
        {
            if (string.IsNullOrEmpty(this._Name))
            {
                return "No name is given";
            }
            else
            {
                return this._Name;
            }
        }

        public int GetPassMarks()
        {
            return this._PassMarks;
        }
    }
}
