using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Firm
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Profile { get; set; }
        public string FIO { get; set; }
        public int Employee_emount { get; set; }
        public string Address { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1 task

            List<Firm> firms = new List<Firm>()
            {
                new Firm { Name = "TechSolutions", Year = 2005, Profile = "IT Services", FIO = "John Doe", Employee_emount = 150, Address = "123 Tech St, Silicon Valley" },
                new Firm { Name = "GreenEnergy", Year = 2010, Profile = "Renewable Energy", FIO = "Jane Smith", Employee_emount = 80, Address = "456 Green Blvd, San Francisco" },
                new Firm { Name = "SmartRetail", Year = 2018, Profile = "E-commerce", FIO = "Michael Johnson", Employee_emount = 250, Address = "789 Retail Rd, New York" },
                new Firm { Name = "HealthCarePro", Year = 2000, Profile = "Healthcare", FIO = "Emily Brown", Employee_emount = 500, Address = "321 Wellness Ave, Chicago" },
                new Firm { Name = "FinTech Global", Year = 2015, Profile = "Financial Services", FIO = "William Davis", Employee_emount = 200, Address = "654 Finance St, London" },
                new Firm { Name = "EduTech", Year = 2012, Profile = "Education Technology", FIO = "Sophia Martinez", Employee_emount = 120, Address = "432 Learning Ln, Boston" },
                new Firm { Name = "AutoTech", Year = 2016, Profile = "Automotive", FIO = "Oliver Wilson", Employee_emount = 300, Address = "987 Auto Pkwy, Detroit" },
                new Firm { Name = "DesignMasters", Year = 2008, Profile = "Graphic Design", FIO = "Lily Clark", Employee_emount = 50, Address = "123 Art St, Los Angeles" },
                new Firm { Name = "CyberSec Solutions", Year = 2019, Profile = "Cybersecurity", FIO = "Daniel Lewis", Employee_emount = 75, Address = "876 Secure Rd, Washington" },
                new Firm { Name = "Foodie Inc.", Year = 2011, Profile = "Food Industry", FIO = "Ava Allen", Employee_emount = 400, Address = "543 Tasty Ave, Miami" }
            };


            Console.WriteLine("Получить информацию обо всех фирмах");
            foreach (var firm in firms)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }

            Console.WriteLine("Получить фирмы, у которых в названии есть слово Food");
            var firm1 = from firm in firms
                        where firm.Name.IndexOf("Food", StringComparison.OrdinalIgnoreCase) >= 0
                        select firm;

            foreach (var firm in firm1)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }


            Console.WriteLine("Получить фирмы, которые работают в области маркетинга");
            var firm2 = from firm in firms
                        where firm.Profile == "Marketing"
                        select firm;

            foreach (var firm in firm2)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }

            Console.WriteLine("Получить фирмы, которые работают в области маркетинга или IT");
            var firm3 = from firm in firms
                        where firm.Profile == "Marketing" || firm.Profile == "IT"
                        select firm;

            foreach (var firm in firm3)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }


            Console.WriteLine("Получить фирмы с количеством сотрудников, большем 100");
            var firm4 = from firm in firms
                        where firm.Employee_emount > 100
                        select firm;

            foreach (var firm in firm4)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }

            Console.WriteLine("Получить фирмы с количеством сотрудников в диапазоне от 100 до 300");
            var firm5 = from firm in firms
                        where firm.Employee_emount > 100 && firm.Employee_emount < 300
                        select firm;

            foreach (var firm in firm5)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }

            Console.WriteLine("Получить фирмы, которые находятся в Лондоне");
            var firm6 = from firm in firms
                        where firm.Address == "London"
                        select firm;

            foreach (var firm in firm6)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }


            Console.WriteLine("Получить фирмы, у которых фамилия директора White");
            var firm7 = from firm in firms
                        where firm.FIO.StartsWith("White")
                        select firm;

            foreach (var firm in firm7)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }


            Console.WriteLine("Получить фирмы, которые основаны больше двух лет назад");
            DateTime currentDate1 = DateTime.Now;
            var firm8 = from firm in firms
                        where firm.Year < currentDate1.Year - 2
                        select firm;

            foreach (var firm in firm8)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }


            Console.WriteLine("Получить фирмы со дня основания, которых прошло 123 дня");

            DateTime currentDate2 = DateTime.Now;
            DateTime targetDate = currentDate2.AddDays(-123);

            var firm9 = from firm in firms
                        where new DateTime(firm.Year, 1, 1) <= targetDate 
                        select firm;


            foreach (var firm in firm9)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }


            Console.WriteLine("Получить фирмы, у которых фамилия директора Black и название фирмы содержит слово White");

            var firm10 = from firm in firms
                        where firm.FIO.StartsWith("Black") && firm.Name.IndexOf("White", StringComparison.OrdinalIgnoreCase) >= 0
                         select firm;


            foreach (var firm in firm10)
            {
                Console.WriteLine($"Firm Name: {firm.Name}");
                Console.WriteLine($"Year Established: {firm.Year}");
                Console.WriteLine($"Profile: {firm.Profile}");
                Console.WriteLine($"CEO: {firm.FIO}");
                Console.WriteLine($"Employee Count: {firm.Employee_emount}");
                Console.WriteLine($"Address: {firm.Address}");
                Console.WriteLine("----------");
            }



        }
    }
}
