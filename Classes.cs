using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab._1.Classes;

namespace Lab._1
{
    internal class Classes
    {
        public class ComplexNumber
        {
            private double a;
            private double b;

            static ComplexNumber() { }

            public ComplexNumber()
            {
                a = 1.0;
                b = 1.0;
            }

            public ComplexNumber(double valueA, double valueB)
            {
                a = valueA;
                b = valueB;
            }

            public ComplexNumber(ComplexNumber sourceComplexNumber)
            {
                if (this != sourceComplexNumber)
                {
                    a = sourceComplexNumber.a;
                    b = sourceComplexNumber.b;
                }
            }

            ~ComplexNumber() { }

            public double A { get { return a; } set { a = value; } }

            public double B { get { return b; } set { b = value; } }
            
            public override string ToString()
            {
                if (a >= 0) return $"{a} + {b}i";
                else return $"{a} - {Math.Abs(b)}i";
            }

            //public ComplexNumber Add(ComplexNumber other)
            //{
            //    double resultA = this.A + other.A;
            //    double resultB = this.B + other.B;

            //    return new ComplexNumber(resultA, resultB);
            //}

            //public ComplexNumber Subtract(ComplexNumber other)
            //{
            //    double resultA = this.A - other.A;
            //    double resultB = this.B - other.B;

            //    return new ComplexNumber(resultA, resultB);
            //}

            //public ComplexNumber Multiply(ComplexNumber other)
            //{
            //    double resultA = this.A * other.A - this.B * other.B;
            //    double resultB = this.A * other.B + this.B * other.A;

            //    return new ComplexNumber(resultA, resultB);
            //}

            //public ComplexNumber Divide(ComplexNumber other)
            //{
            //    double denominator = other.A * other.A + other.B * other.B;

            //    if (denominator == 0)
            //    {
            //        throw new InvalidOperationException("Невозможно выполнить операцию деления на ноль.");
            //    }

            //    double resultA = (this.A * other.A + this.B * other.B) / denominator;
            //    double resultB = (this.B * other.A - this.A * other.B) / denominator;

            //    return new ComplexNumber(resultA, resultB);
            //}

            public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1.A + c2.A, c1.B + c2.B);
            }

            public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1.A - c2.A, c1.B - c2.B);
            }

            public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
            {
                double resultA = c1.A * c2.A - c1.B * c2.B;
                double resultB = c1.A * c2.B + c1.B * c2.A;

                return new ComplexNumber(resultA, resultB);
            }

            public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
            {
                double denominator = c2.A * c2.A + c2.B * c2.B;

                if (denominator == 0)
                {
                    throw new InvalidOperationException("Невозможно выполнить операцию деления на ноль.");
                }

                double resultA = (c1.A * c2.A + c1.B * c2.B) / denominator;
                double resultB = (c1.B * c2.A - c1.A * c2.B) / denominator;

                return new ComplexNumber(resultA, resultB);
            }
        }

        public class ComplexNumberOperator
        {
            private ComplexNumber[] complexNumbers;

            static ComplexNumberOperator() { }

            public ComplexNumberOperator()
            {
                complexNumbers = new ComplexNumber[2];
                complexNumbers[0] = new ComplexNumber();
                complexNumbers[1] = new ComplexNumber();
            }

            public ComplexNumberOperator(double firstComplexNumberA, double firstComplexNumberB,
                double secondComplexNumberA, double secondComplexNumberB)
            {
                complexNumbers = new ComplexNumber[2];
                complexNumbers[0] = new ComplexNumber(firstComplexNumberA, firstComplexNumberB);
                complexNumbers[1] = new ComplexNumber(secondComplexNumberA, secondComplexNumberB);
            }

            public ComplexNumberOperator(ComplexNumberOperator sourceCompexNumberOperator)
            {
                if (this != sourceCompexNumberOperator)
                {
                    complexNumbers = new ComplexNumber[2];
                    complexNumbers[0] = new ComplexNumber(sourceCompexNumberOperator.complexNumbers[0]);
                    complexNumbers[1] = new ComplexNumber(sourceCompexNumberOperator.complexNumbers[1]);
                }
            }

            //~ComplexNumberOperator()
            //{
            //    if (complexNumbers != null)
            //    {
            //        complexNumbers[0] = null;
            //        complexNumbers[1] = null;
            //    }
            //}

            public ComplexNumber[] СomplexNumbers
            {
                get { return complexNumbers; }
                set
                {
                    if (value?.Length != 2)
                    {
                        throw new ArgumentException("Массив должен иметь два элемента.");
                    }

                    complexNumbers = new ComplexNumber[2];
                    complexNumbers[0] = new ComplexNumber(value[0]);
                    complexNumbers[1] = new ComplexNumber(value[1]);
                }
            }

            public ComplexNumber this[int index]
            {
                get { return complexNumbers[index]; }
                set { complexNumbers[index] = value; }
            }

            //public ComplexNumber this[int index]
            //{
            //    get
            //    {
            //        if (index < 0 || index >= complexNumbers.Length)
            //        {
            //            throw new IndexOutOfRangeException("Индекс выходит за пределы диапазона.");
            //        }

            //        return complexNumbers[index];
            //    }
            //    set
            //    {
            //        if (index < 0 || index >= complexNumbers.Length)
            //        {
            //            throw new IndexOutOfRangeException("Индекс выходит за пределы диапазона.");
            //        }

            //        complexNumbers[index] = value;
            //    }
            //}

            public ComplexNumber Add()
            {
                return complexNumbers[0] + complexNumbers[1];
            }

            public ComplexNumber Subtract()
            {
                return complexNumbers[0] - complexNumbers[1];
            }

            public ComplexNumber Multiply()
            {
                return complexNumbers[0] * complexNumbers[1];
            }

            public ComplexNumber Divide()
            {
                return complexNumbers[0] / complexNumbers[1];
            }

            //public ComplexNumber Add()
            //{
            //    double resultA = complexNumbers[0].A + complexNumbers[1].A;
            //    double resultB = complexNumbers[0].B + complexNumbers[1].B;

            //    return new ComplexNumber(resultA, resultB);
            //}

            //public ComplexNumber Subtract()
            //{
            //    double resultA = complexNumbers[0].A - complexNumbers[1].A;
            //    double resultB = complexNumbers[0].B - complexNumbers[1].B;

            //    return new ComplexNumber(resultA, resultB);
            //}

            //public ComplexNumber Multiply()
            //{
            //    double resultA = complexNumbers[0].A * complexNumbers[1].A - complexNumbers[0].B * complexNumbers[1].B;
            //    double resultB = complexNumbers[0].A * complexNumbers[1].B + complexNumbers[0].B * complexNumbers[1].A;

            //    return new ComplexNumber(resultA, resultB);
            //}

            //public ComplexNumber Divide()
            //{
            //    double denominator = complexNumbers[1].A * complexNumbers[1].A + complexNumbers[1].B * complexNumbers[1].B;

            //    if (denominator == 0)
            //    {
            //        throw new InvalidOperationException("Невозможно выполнить операцию деления на ноль.");
            //    }

            //    double resultA = (complexNumbers[0].A * complexNumbers[1].A + complexNumbers[0].B * complexNumbers[1].B) / denominator;
            //    double resultB = (complexNumbers[0].B * complexNumbers[1].A - complexNumbers[0].A * complexNumbers[1].B) / denominator;

            //    return new ComplexNumber(resultA, resultB);
            //}

            public override string ToString()
            {
                return $"[ {complexNumbers[0]}, {complexNumbers[1]} ]";
            }
        }
    }
}
