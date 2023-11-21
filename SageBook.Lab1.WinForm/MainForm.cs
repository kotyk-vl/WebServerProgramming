using SageBook.Lab1.WinForm.UserControls;

namespace SageBook.Lab1.WinForm
{
    public partial class MainForm : Form
    {
        private NavigationControl _navigationControl;
        private NavigationButtons _navigationButtons;

        private Color _btnDefaultColor = Color.AliceBlue;
        private Color _btnSelectedColor = Color.Blue;

        public MainForm()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void InitializeNavigationControl()
        {
            var userControls = new List<UserControl>()
            {
                new BooksControl(),
                //new SagesControl()
            };

            _navigationControl = new NavigationControl(userControls, panelMainBody);
            _navigationControl.Display(0);
        }

        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            {
                btnBooks, 
                btnSages
            };

            _navigationButtons = new NavigationButtons(buttons, _btnDefaultColor, _btnSelectedColor);
            _navigationButtons.SetSelectedButton(btnBooks);
        }

        private void btn_sages_Click(object sender, EventArgs e)
        {
            _navigationControl.Display(1);
            _navigationButtons.SetSelectedButton(btnSages);
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            _navigationControl.Display(0);
            _navigationButtons.SetSelectedButton(btnBooks);
        }
    }
}