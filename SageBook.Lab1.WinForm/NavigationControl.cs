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
                foreach (var control in _userControls.Select((v, i)=> new { Item = v, Index = i }))
                {
                    if (control.Index == index)
                    {
                        control.Item.Visible = true;
                        control.Item.BringToFront();
                    }
                    else
                    {
                        control.Item.Visible = false;
                    }
                }
            }
        }
    }
}