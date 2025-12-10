namespace FinalProject_Mujakovic
{
     public class Student
    {
        // Private variables
        private string _firstName;
        private string _lastName;
        private int _year;
        private string _major;
        private int _studentID;
       
        // Properties      
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }
        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        // Constructors
        public Student()
        {
            _firstName = "John";
            _lastName = "Doe";
            _year = 2000;
            _major = "Computer Science";
            _studentID = -1;
        }

        public Student(string fName, string lName, int year, string major, int ID)
        {
           _firstName = fName;
           _lastName = lName;
           _year = year;
           _major = major;
           _studentID = ID;
        }

        // Methods
        public virtual string MakeNamePlate()
        {
            return LastName + ", " + FirstName + " (" + Year + ")" + ", Major: " + Major +  ", ID: " + StudentID;
        }
        // To string
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " | ID: " + StudentID + " | Major: " + Major + " | Year of graduation: " + Year;
        }  
    }
}