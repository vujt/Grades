using System.IO;

namespace Grades
{
    internal interface IGradeTracker
    {
        void AddGrade(float grade);

        GradeStatistics ComputeStatistics();

        void WriteGrade(TextWriter destination);

        string Name { get; set; }
    }
}