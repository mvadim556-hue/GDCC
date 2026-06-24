using System;
using System.Windows.Forms;
using GDCCwinforms.Presenters;
using GDCCwinforms.Views;

namespace GDCCwinforms
{
    public partial class MainForm : Form, ICalculatorView
    {
        private readonly CalculatorPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new CalculatorPresenter(this);
        }

        public string ProgrammersText
        {
            get => txtProgrammers.Text;
            set => txtProgrammers.Text = value;
        }

        public string ArtistsText
        {
            get => txtArtists.Text;
            set => txtArtists.Text = value;
        }

        public string MonthsText
        {
            get => txtMonths.Text;
            set => txtMonths.Text = value;
        }

        public string ResultText
        {
            get => lblResult.Text;
            set => lblResult.Text = value;
        }

        public event EventHandler CalculateClicked;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateClicked?.Invoke(this, EventArgs.Empty);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalculate_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
