namespace ClassesPract2.Class;

internal class Subhelper
    {
        private string _fullName;
        private string _birthDate;
        private string _phoneNumber;
        private string _email;
        private string _position;
        private string _duty;
        private int _salary;
    
        public Subhelper()
        {
            _fullName = "None";
            _birthDate = "None";
            _phoneNumber = "None";
            _email = "None";
            _position = "None";
            _duty = "None";
            _salary = 0;
        }

        public Subhelper(string fullName, string birthDate, string phoneNumber, string email, string position, string duty, int salary)
        {
            _fullName = fullName;
            _birthDate = birthDate;
            _phoneNumber = phoneNumber;
            _email = email;
            _position = position;
            _duty = duty;
            _salary = salary;
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string Duty
        {
            get { return _duty; }
            set { _duty = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void Input()
        {
            Console.WriteLine("Enter Full Name:");
            FullName = Console.ReadLine();

            Console.WriteLine("Enter Birth Date (yyyy-mm-dd):");
            BirthDate = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            Email = Console.ReadLine();

            Console.WriteLine("Enter Position:");
            Position = Console.ReadLine();

            Console.WriteLine("Enter Duty Description:");
            Duty = Console.ReadLine();
            
            Console.WriteLine("Enter Salary:");
            while (true)
            {
                try
                {
                    Salary = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid salary.");
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Birth Date: {BirthDate}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Duty Description: {Duty}");
            Console.WriteLine($"Salary: {Salary}");
        }
        
        public static Subhelper operator +(Subhelper subhelper, int salary)
        {
            subhelper._salary = salary;
            return subhelper;
        }
        public static Subhelper operator -(Subhelper subhelper, int salary)
        {
            subhelper._salary -= salary;
            return subhelper;
        }
        public static Subhelper operator ++(Subhelper subhelper)
        {
            subhelper._salary++;
            return subhelper;
        }
        public static Subhelper operator --(Subhelper subhelper)
        {
            subhelper._salary--;
            return subhelper;
        }
        public static bool operator ==(Subhelper subhelper1, Subhelper subhelper2)
        {
            return subhelper1._salary == subhelper2._salary;
        }

        public static bool operator !=(Subhelper subhelper1, Subhelper subhelper2)
        {
            return !(subhelper1 == subhelper2);
        }
        public override bool Equals(object obj)
        {
            if (obj is Subhelper subhelper)
            {
                return this == subhelper;
            }
            return false;
        }
    }