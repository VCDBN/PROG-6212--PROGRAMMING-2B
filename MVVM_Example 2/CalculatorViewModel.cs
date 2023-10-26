using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Example
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private CalculatorModel _model = new CalculatorModel();
        private int _number1;
        private int _number2;
        private int _result;

        public int Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged("Number1");
            }
        }

        public int Number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                OnPropertyChanged("Number2");
            }
        }

        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public ICommand AddCommand => new RelayCommand(AddNumbers);

        private void AddNumbers()
        {
            Result = _model.Add(Number1, Number2);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

