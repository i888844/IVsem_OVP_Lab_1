using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._1
{
    public class ComplexNumber
    {
        public double A { get; private set; }
        public double B { get; private set; }

        public ComplexNumber()
        {
            A = 0.0;
            B = 0.0;
        }

        public ComplexNumber(double valueA, double valueB)
        {
            A = valueA;
            B = valueB;
        }

        public ComplexNumber(ComplexNumber sourceComplexNumber)
        {
            if (this != sourceComplexNumber)
            {
                A = sourceComplexNumber.A;
                B = sourceComplexNumber.B;
            }
        }

        ~ComplexNumber() { }

        public override string ToString()
        {
            if (A >= 0) return $"{A} + {B}i";
            else return $"{A} - {Math.Abs(B)}i";
        }
    }

    public class ComplexNumberOperator
    {
        private ComplexNumber[] complexNumbers;

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

        ~ComplexNumberOperator()
        {
            if (complexNumbers != null)
            {
                complexNumbers[0] = null;
                complexNumbers[1] = null;
            }
        }

        public ComplexNumber[] СomplexNumbers
        {
            get { return complexNumbers; }
            set
            {
                if (value.Length != 2)
                {
                    throw new ArgumentException("Массив должен иметь два элемента.");
                }

                complexNumbers = new ComplexNumber[2];
                complexNumbers[0] = new ComplexNumber(value[0]);
                complexNumbers[1] = new ComplexNumber(value[1]);
            }
        }

        public ComplexNumber Add()
        {
            double resultA = complexNumbers[0].A + complexNumbers[1].A;
            double resultB = complexNumbers[0].B + complexNumbers[1].B;

            return new ComplexNumber(resultA, resultB);
        }

        public ComplexNumber Subtract()
        {
            double resultA = complexNumbers[0].A - complexNumbers[1].A;
            double resultB = complexNumbers[0].B - complexNumbers[1].B;

            return new ComplexNumber(resultA, resultB);
        }

        public ComplexNumber Multiply()
        {
            double resultA = complexNumbers[0].A * complexNumbers[1].A - complexNumbers[0].B * complexNumbers[1].B;
            double resultB = complexNumbers[0].A * complexNumbers[1].B + complexNumbers[0].B * complexNumbers[1].A;

            return new ComplexNumber(resultA, resultB);
        }

        public ComplexNumber Divide()
        {
            double denominator = complexNumbers[1].A * complexNumbers[1].A + complexNumbers[1].B * complexNumbers[1].B;

            if (denominator == 0)
            {
                throw new InvalidOperationException("Невозможно выполнить операцию деления на ноль.");
            }

            double resultA = (complexNumbers[0].A * complexNumbers[1].A + complexNumbers[0].B * complexNumbers[1].B) / denominator;
            double resultB = (complexNumbers[0].B * complexNumbers[1].A - complexNumbers[0].A * complexNumbers[1].B) / denominator;

            return new ComplexNumber(resultA, resultB);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Случайно созданные события
        private void button1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
