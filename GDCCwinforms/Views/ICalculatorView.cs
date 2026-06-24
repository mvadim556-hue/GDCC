using System;

namespace GDCCwinforms.Views
{
    public interface ICalculatorView
    {
        string ProgrammersText { get; set; }
        string ArtistsText { get; set; }
        string MonthsText { get; set; }
        string ResultText { get; set; }

        event EventHandler CalculateClicked;

        void ShowError(string message);
    }
}
