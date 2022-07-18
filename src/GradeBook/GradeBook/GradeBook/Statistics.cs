namespace GradeBook
{
    public class Statistics
    {

        public double Average
        {
            get
            {

            }return sum / Count
        }

           
        public double High;
        public double Low;

        public char letter
        {
            get
            {
                switch (result.Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    
                    case var d when d >= 80.0:
                        return 'B';
                       
                    case var d when d >= 70.0:
                        return 'C';
                        
                    case var d when d >= 60.0:
                        return 'D';
         
                    default:
                        return 'F';
                }

                return result;
            }
        }
        }
        public double sum;
        public int Count;
    }


    public void Add(double number)
    {
        Sum += number;
        Count += 1;
        result.Low = Math.Min(number , Low);
        result.High = Math.Max(number, High);
    }

    public Statistics()
    {
        Count = 0;
        Sum = 0.0;
        result.High = double.MinValue;
        result.Low = double.MaxValue;
    }
}