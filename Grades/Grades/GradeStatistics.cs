using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Description
        {
            get
            {
                string result;

                switch(LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }

                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;

                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}

/*
- We initialize HighestGrade with 0 and LowestGrade with the max value a float can reach,
  so that we can compare each grade in the grades List with the current HighestGrade and LowestGrade and
  update the value as new grades are added.

  stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
  stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
*/



/*
Switching
- restricted to integers, characters, strings and enums
- case labels are constants
- each case requires a 'break' statement 
- default label is optional
- switch statements are not so useful for evaluating ranges, 
  but sometimes useful for replacing 'if', 'else if', 'else' statements
*/