namespace SageBook.Lab1.WinForm
{
    public class NavigationControl
    {
        private List<UserControl> _userControls = new List<UserControl>();
        private Panel _panel;

        public NavigationControl(List<UserControl> userControls, Panel panel)
        {
            _userControls = userControls;
            _panel = panel;

            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < _userControls.Count(); i++)
            {
                _userControls[i].Dock = DockStyle.Fill;
                _panel.Controls.Add(_userControls[i]);
            }
        }

        public void Display(int index)
        {
            if (index < _userControls.Count())
            {
                _userControls[index].BringToFront();
            }
        }
    }
}