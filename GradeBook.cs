using System;
namespace W5B_GradeBookApp
{
	public class GradeBook
	{
		public bool IsOpen { get; set; }

		//public List<double> Grades; //bad idea ??????
		private List<double> _grades; 

        public GradeBook()
		{
			IsOpen = true;
			_grades = new List<double>();

        }

		public void AddGrade(double grade)
		{
			//validation rules:
			//1. grade must be between 0 and 100
			//2. isOpen must be true

			if (grade < 0 || grade > 100)
				throw new Exception("Invalid Grade");

			if (!IsOpen)
                throw new Exception("Gradebook is closed");

            _grades.Add(grade);
		}

		//option 1
		//public double GetAverage()
		//{
		//	return 0;
		//}
  //      public double GetHighestGrade()
  //      {
  //          return 0;
  //      }
  //      public double GetLowestGrade()
  //      {
  //          return 0;
  //      }


        //option2:
        //double average = GetStats()[0];
        //      public List<double> GetStats()
        //{
        //	return null;
        //}

        // double average = GetStats().Average;
        public Stats GetStats()
        {
			
			double max = 0;
			double min = 100;
			double sum = 0;

			foreach(double grade in _grades)
			{
				sum += grade;

				if (grade > max)
					max = grade;

				if (grade < min)
					min = grade;
			}

			Stats result = new Stats()
			{
				Highest = max,
				Lowest = min,
				Average = sum / _grades.Count
			};

            return result;
        }
    }
}

