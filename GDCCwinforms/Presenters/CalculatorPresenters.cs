using System;
using GDCCwinforms.Models;
using GDCCwinforms.Views;

namespace GDCCwinforms.Presenters
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly Calculator _model;

        public CalculatorPresenter(ICalculatorView view)
        {
            _view = view;
            _model = new Calculator();

            _view.CalculateClicked += OnCalculateClicked;
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            try
            {
                int programmers = int.Parse(_view.ProgrammersText);
                int artists = int.Parse(_view.ArtistsText);
                int months = int.Parse(_view.MonthsText);

                decimal result = _model.CalculateTotalCost(programmers, artists, months);
                _view.ResultText = $"Стоимость: {result:C2}";
            }
            catch (FormatException)
            {
                _view.ShowError("Введите корректные числа!");
                _view.ResultText = "Ошибка ввода";
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                _view.ResultText = "Ошибка";
            }
        }
    }
}
