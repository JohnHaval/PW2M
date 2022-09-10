using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2N.TaskClasses
{/// <summary>
/// Класс для нахождения S3 при R1 > R2
/// </summary>
    public class SquareFind
    {
        double _r1, _r2;
        public const double PI = 3.14;        
        /// <summary>
        /// Внешний радиус
        /// </summary>
        public double R1 { get => _r1; set => _r1 = value; }
        /// <summary>
        /// Внутренний радиус
        /// </summary>
        public double R2 
        { 
            get => _r2; 
            set 
            {
                if (_r1 <= value) throw new Exception("Не соответствует условию поставленной задачи");
                _r2 = value; 
            } 
        }
        public double S1 { get; set; }
        public double S2 { get; set; }
        /// <summary>
        /// Площадь кольца
        /// </summary>
        public double S3 { get; set; }
        public SquareFind() { }
        public SquareFind(double r1, double r2)
        {
            R1 = r1;
            R2 = r2;
        }
        public double FindS1()
        {
            return S1 = PI * Math.Pow(R1, 2);
        }
        public double FindS1(double r1)
        {
            return S1 = PI * Math.Pow(R1=r1, 2);
        }
        public double FindS2()
        {
            return S2 = PI * Math.Pow(R2, 2);
        }
        public double FindS2(double r2)
        {
            return S2 = PI * Math.Pow(R2=r2, 2);
        }
        public double FindS3()
        {
            return S3 = S1 - S2;
        }
        public double FindS3(double r1, double r2)
        {
            S1 = FindS1(r1);
            S2 = FindS1(r2);
            return S3 = S1 - S2;
        }
    }
}
