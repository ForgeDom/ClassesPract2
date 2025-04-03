namespace ClassesPract2.Classes;

 internal class City
    {
        private string _cityName;
        private string _countryName;
        private int _cityPopulation;
        private string _cityCode;
        private string[] _districts;

        public City()
        {
            _cityName = "Empty";
            _countryName = "Empty";
            _cityPopulation = 0;
            _cityCode = "Empty";
            _districts = new string[0]; 
        }
        public City(string cityName, string countryName, int cityPopulation,string cityCode, string[] districts)
        {
            _cityName=cityName;
            _countryName=countryName;
            _cityPopulation=cityPopulation;
            _cityCode=cityCode;
            _districts=districts;
        }
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
        public int CityPopulation
        {
            get { return _cityPopulation; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Population can`t be less than 0!");
                }
                _cityPopulation = value;
            }
        }
        public string CityCode
        {
            get { return _cityCode; }
            set { _cityCode = value; }
        }
        public string[] Districts
        {
            get { return _districts; }
            set { _districts = value; }
        }
        public void Input()
        {
            Console.WriteLine("Enter city name:");
            _cityName = Console.ReadLine();

            Console.WriteLine("Enter country name:");
            _countryName = Console.ReadLine();

            Console.WriteLine("Enter population:");
            _cityPopulation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phone code:");
            _cityCode = Console.ReadLine();

            Console.WriteLine("Enter number of districts:");
            int districtCount = Convert.ToInt32(Console.ReadLine());
            _districts = new string[districtCount];

            Console.WriteLine("Enter district names:");
            for (int i = 0; i < districtCount; i++)
            {
                Console.Write($"District {i + 1}: ");
                _districts[i] = Console.ReadLine();
            }
        }
        public void DisplayData()
        {
            Console.WriteLine($"City Name: {_cityName}");
            Console.WriteLine($"Country Name: {_countryName}");
            Console.WriteLine($"Population: {_cityPopulation}");
            Console.WriteLine($"Phone Code: {_cityCode}");
            Console.WriteLine("Districts:");
            foreach (var district in _districts)
            {
                Console.WriteLine($"- {district}");
            }
        }
        
        public static City operator +(City city, int population)
        {
            city.CityPopulation += population;
            return city;
        }

        public static City operator -(City city, int population)
        {
            city.CityPopulation -= population;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.CityPopulation == city2.CityPopulation;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.CityPopulation != city2.CityPopulation;   
        }
        public override bool Equals(object obj)
        {
            if (obj is City city)
            {
                return this == city;
            }
            return false;
        }
    }