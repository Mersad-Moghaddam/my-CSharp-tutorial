namespace PersonalInformationManagementSystem
{
    internal class Person
    {
        // Property
        private string _name;
        private int _age;
        private string _department;
        private string _position;
        private string _address;

        // Setter and Getter
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine($"Age Cannot be Negative");

                }
            }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"| Display Person Information");
            Console.WriteLine($"|");
            Console.WriteLine($"|   1. Name : {Name}");
            Console.WriteLine($"|   2. Age : {Age}");
            Console.WriteLine($"|   3. Address: {Address}");
            Console.WriteLine($"|   4. Position: {Position}");
            Console.WriteLine($"|   5. Department: {Department}");
            Console.WriteLine($"|");
            Console.WriteLine($"-----------------------------");
                        
        }
    }
   
}