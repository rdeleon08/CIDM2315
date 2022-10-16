class Professor{
        public string prof_name;
        public string class_teach;
        private double salary;
        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }
        public double GetSlary()
        {
            return salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Professor {prof_name} teaches {class_teach} ,and the salary is {salary}");
        }
    }

