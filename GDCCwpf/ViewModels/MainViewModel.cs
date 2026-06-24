using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GDCCwpf.Models;

namespace GDCCwpf.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly Calculator _model;
        private string _programmers = "";
        private string _artists = "";
        private string _months = "";
        private string _result = "Ожидание ввода...";

        public MainViewModel()
        {
            _model = new Calculator();
            CalculateCommand = new RelayCommand(ExecuteCalculate);
        }

        public string Programmers
        {
            get => _programmers;
            set
            {
                _programmers = value;
                OnPropertyChanged();
            }
        }

        public string Artists
        {
            get => _artists;
            set
            {
                _artists = value;
                OnPropertyChanged();
            }
        }

        public string Months
        {
            get => _months;
            set
            {
                _months = value;
                OnPropertyChanged();
            }
        }

        public string Result
        {
            get => _result;
            private set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalculateCommand { get; }

        private void ExecuteCalculate(object parameter)
        {
            try
            {
                int programmers = int.Parse(Programmers);
                int artists = int.Parse(Artists);
                int months = int.Parse(Months);

                decimal total = _model.CalculateTotalCost(programmers, artists, months);
                Result = $"Стоимость: {total:C2}";
            }
            catch (FormatException)
            {
                Result = "Ошибка ввода!";
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
