namespace FinalProject_Mujakovic
{
    public class StudentWorker : Student
    {
        private decimal _hourlyRate;
        private double _hoursWorked;
        private decimal _weeklySalary;

        // Properties
        public decimal HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }

        public double HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        // Constructors
        public StudentWorker() : base()
        {
            _hourlyRate = 0.0m;
            _hoursWorked = 0;
            _weeklySalary = CalculateWeeklyPay();
        }

        public StudentWorker(string fName, string lName, int year, string major,
            int ID, decimal rate, double hours)
            : base(fName, lName, year, major, ID)
        {
            _hourlyRate = rate;
            _hoursWorked = hours;
            _weeklySalary = CalculateWeeklyPay();
        }
        // Calculate weekly pay, it takes the hours worked times the hourly rate and
        // multiplies the result by 7 days (1 week)
        public decimal CalculateWeeklyPay()
        {
            if ((HoursWorked < 1 || HoursWorked > 15) || (HourlyRate < 7.25m || HourlyRate > 14.75m))
            {
                return 0m;
            }
            else
            {
                return (decimal) ((double)(HourlyRate * (decimal)HoursWorked) * 7);
            }
            
        }
        // Override method
        public override string MakeNamePlate()
        {
            return base.MakeNamePlate() + ", Rate: $" + HourlyRate.ToString("F2")
                + ", Hours: " + HoursWorked;
        }

        public override string ToString()
        {
            return base.ToString() + " | Hourly Rate: $" + HourlyRate.ToString("F2")
                + " | Hours Worked: " + Convert.ToString(HoursWorked) + " | Weekly Rate: $"
                + WeeklySalary.ToString("F2");
        }
    }
}