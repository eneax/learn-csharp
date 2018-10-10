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
