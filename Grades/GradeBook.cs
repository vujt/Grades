using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        
        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }


        //private string _name;
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }

        //    set
        //    {
        //        if (!String.IsNullOrEmpty(value))
        //        {
        //            if (_name != value && NameChanged != null)
        //            {
        //                NameChangedEventArgs args = new NameChangedEventArgs();
        //                args.ExistingName = _name;
        //                args.NewName = value;
        //                NameChanged(this, args);
        //            }

        //            _name = value;
        //        }
        //    }
        //}
        //public event NameChangedDelegate NameChanged;

        public override void WriteGrade(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

       

        protected List<float> grades;
    }
}
