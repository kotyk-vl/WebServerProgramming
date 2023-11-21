using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageBook.Lab1.WinForm
{
    public class NavigationButtons
    {
        List<Button> _buttons;
        Color _defaultColor;
        Color _selectedColor;

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            _buttons = buttons;
            _defaultColor = defaultColor;
            _selectedColor = selectedColor;
            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach (var btn in _buttons)
            {
                btn.BackColor = _defaultColor;
            }
        }

        public void SetSelectedButton(Button selectedButton)
        {
            foreach (var btn in _buttons)
            {
                if (btn == selectedButton)
                {
                    selectedButton.BackColor = _selectedColor;
                }
                else
                {
                btn.BackColor = _defaultColor;
                }
            }
        }
    }
}
