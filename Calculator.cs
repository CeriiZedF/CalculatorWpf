using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

//Model Object
namespace MVVSCalculatorWpf
{
    internal class Calculator
    {
        public int LOperand { get; set; }
        public int ROperand { get; set; }
       

        public int Sum()
        {
            try
            {
                return LOperand + ROperand;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Minus()
        {
            try
            {
                return LOperand - ROperand;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Multiplication()
        {
            try
            {
                return LOperand * ROperand;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Division()
        {
            try
            {
                return LOperand / ROperand;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
