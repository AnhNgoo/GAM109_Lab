using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAM109_Lab1
{
    internal partial class Calculator
    {
        public double Add() { return a + b; }
        public double Sub() { return a - b; }
        public double Mul() { return a * b; }
        public double Div() { return a / b; }

        public void DisplayResult()
        {
            Console.WriteLine($"Cộng: {a} + {b} = {Add()}");
            Console.WriteLine($"Trừ: {a} - {b} = {Sub()}");
            Console.WriteLine($"Nhân: {a} * {b} = {Mul()}");
            Console.WriteLine($"Chia: {a} / {b} = {Div()}");
        }
    }
}
