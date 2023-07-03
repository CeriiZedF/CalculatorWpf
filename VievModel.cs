using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVVSCalculatorWpf
{
    internal class VievModel : INotifyPropertyChanged
    {
        private Calculator cal_model;

        public VievModel()
        {
            cal_model = new Calculator();
        }
        public int LeftOperand
        {
            get { return cal_model.LOperand; }
            set
            {
                cal_model.LOperand = value;
                OnPropertyChanged("LeftOperand");
            }
        }
        public int RightOperand
        { 
            get { return cal_model.ROperand; }
            set
            {
                cal_model.ROperand = value;
                OnPropertyChanged("RightOperand");
            }
        }
        public int Difference(int index)
        {
            int temp = 0;
            switch (index)
            {
                case 0:
                    {
                        temp = cal_model.Sum();
                        break;
                    }
                case 1:
                    {
                        temp = cal_model.Minus();
                        break;
                    }
                case 2:
                    {
                        temp = cal_model.Multiplication();
                        break;
                    }
                case 3:
                    {
                        temp = cal_model.Division();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return temp;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
