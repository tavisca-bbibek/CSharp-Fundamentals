using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;
        
        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }

        
        public Statistics GetStatistics(){            
            var result = new Statistics();
            result.Min = double.MaxValue;
            result.Max = double.MinValue;

            foreach(double grade in grades){
                result.Average += grade;
                result.Min = Math.Min(result.Min, grade);
                result.Max = Math.Max(result.Max, grade);
            }
            result.Average = result.Average / grades.Count;

            return result;   
        }
    }
}