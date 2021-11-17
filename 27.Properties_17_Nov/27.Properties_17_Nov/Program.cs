using System;

//In C#, to Encapsulate and Protect the fields we use Properties
//We use Get and Set to implement the properties
//A property with both Get and Set Accessor is Read and Write Property
//A property with only Get Accessor is ReadOnly Property
//A property with only Set Accessor is WriteOnly Property

//To avoid using Setter and Getter methods, we use Property for that particular field so that the Encapsulation could be achieved and we also maintain the access to the field and also the restrictions regarding the input in the fields is in place.

//Properties allow us to define which fields should be ReadOnly and which should be Read&Write 

//If there is no additional logic in the Property Accessor, then we can make the use of Auto-Implemented properties introduced in C# 3.0
//These reduce the amount of code that we have to write
//When you use the Auto-Implemented Properties, the compiler create a Private anonymous field that can only be accessed through the property's Get and Set accessors

namespace _27.Properties_17_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.Name = "Manthan";
            S.Id = 10;
            S.Email = "marsmanthan@gmail.com";
            S.City = "Shahada";

            Console.WriteLine($"Name of the student is {S.Name} \nId of Student is = {S.Id} \nPassing marks = {S.PassMarks} \nCity of the Student is {S.City} \nEmail = {S.Email}");
        }
    }

    public class Student
    {
        private int _id;
        private string _Name;
        private int _PassMarks = 35;
     // private string _Email;
     // private string _City;

        //The main benefit of a Property is that you do need not specify get or set explicitly
        //This is done on its own, we just need to used the Id Property name and the compiler will automatically decide whether to use get method or set method.
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("This is not a valid Id");
                }
                this._id = value;

            }
            get
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("The Name must not be null");
                }
                this._Name = value;
            }

            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }

        public int PassMarks
        {
            get
            {
                return this._PassMarks;
            }
        }


        //The following code is huge just to initialize the City and Email fields which do not have any particular logic while implementation. We just initialize them directly without any restriction on how the strings should be.
        //To avoid this much of code, we use something called as Auto-Implementation Property
     
   /*   public string City
        {
            set
            {
                this._City = value;
            }
            get
            {
                return this._City;
            }
        }

        public string Email
        {
            set
            {
                this._Email = value;
            }
            get
            {
                return this._Email;
            }
        }   */
        
        //Instead of all of this code we can simply use the following Auto Implemented Property
        //This automatically declares the Field as Private, hence we need not explicitly mention/initialize them in the starting of the code
       
        public string City
        {
            set;
            get;
        }

        public string Email { set; get; }
    
    }
}
