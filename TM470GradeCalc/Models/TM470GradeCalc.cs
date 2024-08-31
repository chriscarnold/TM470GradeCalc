namespace TM470GradeCalc.Models
{
    public class GradeCalc
    {
        public int Id { get; set; } // Primary key for EF Core
        public double TMA1 { get; set; }
        public double TMA2 { get; set; }
        public double TMA3 { get; set; }
        public double EMA { get; set; }
        public DateTime CalculationDate { get; set; } = DateTime.Now;

        public double CalculateFinalGrade()
        {
            return (TMA1 * 0.05) + (TMA2 * 0.10) + (TMA3 * 0.10) + (EMA * 0.75);
        }

        public string GetGradeClassification(double finalGrade)
        {
            if (finalGrade >= 85)
                return "Distinction";
            else if (finalGrade >= 70)
                return "Pass 2";
            else if (finalGrade >= 55)
                return "Pass 3";
            else if (finalGrade >= 40)
                return "Bare Pass";
            else
                return "Fail";
        }
    }
}
