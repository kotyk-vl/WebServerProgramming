using SageBook.Common.Helpers;
using SageBook.Common.Models;
using SageBook.Lab1.WinForm.Helpers;
using SageBook.Repository;
using SageBook.Service.Interfaces;
using SageBook.Service.Models.Book;
using SageBook.Service.Models.Sage;
using SageBook.Service.Services;
using System.Data;

namespace SageBook.Lab1.WinForm.UserControls
{
    public partial class SagesControl : UserControl
    {
        private readonly ISageService _sageService;
        private readonly IBookService _bookService;

        private SageModel _sage;
        private List<BookModel> _books;

        #region PROPERTIES

        public SageModel CurrentSage
        {
            get
            {
                if (_sage == null)
                {
                    _sage = new SageModel();
                }
                return _sage;
            }
            set { _sage = value; }
        }

        public List<ComboItem> Books
        {
            get
            {
                if (_books != null)
                {
                    return _books
                        .Where(b => b.SageIds.Contains(CurrentSage.Id))
                        .Select(Helper.GetBookList)
                        .OrderBy(i => i.Text)
                        .ToList();
                }

                return new List<ComboItem>();
            }
        }

        #endregion PROPERTIES

        public SagesControl()
        {
            _books = new List<BookModel>();
            _sageService = new SageService(new SageRepository());
            _bookService = new BookService(new BookRepository());

            InitializeComponent();
            InitializeDataGrid();
            InitializeCollection();
            SetupPictureBox();
        }

        #region PRIVATE METHODS

        private void InitializeDataGrid()
        {
            datSages.DataSource = _sageService.GetSages().ToList();
            datSages.Refresh();
        }

        private void InitializeCollection()
        {
            _books = _bookService.GetBooks().ToList();
            lstBooks.DataSource = Books;
            lstBooks.DisplayMember = "Text";
            lstBooks.ValueMember = "ID";
        }

        private void RefreshCollections()
        {
            lstBooks.DataSource = Books;
        }

        private void SetupPictureBox()
        {
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private SageModel GetSage()
        {
            return new SageModel
            {
                Name = txtSageName.Text,
                Age = (int)numSageAge.Value,
                City = txtSageCity.Text,
                Photo = ImageHelper.ImageToByteArray(pbPhoto.Image)
            };
        }

        private void SetCurrentSage(int sageId)
        {
            CurrentSage = _sageService.GetSageById(sageId) ?? new SageModel();
        }

        private void SetSageProperties(SageModel sage)
        {
            txtSageName.Text = sage.Name;
            numSageAge.Value = sage.Age;
            txtSageCity.Text = sage.City;
            pbPhoto.Image = new Bitmap(ImageHelper.ImageFromByteArray(sage.Photo));
        }

        private SageModel GetSelectedItem()
        {
            return (SageModel)datSages.CurrentRow?.DataBoundItem;
        }

        private void ShowMessage(string text, string caption = "Error", MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            MessageBox.Show(text, caption, button, icon);
        }

        #endregion PRIVATE METHODS

        #region EVENT_HANDLERS

        private void btnAddSage_Click(object sender, EventArgs e)
        {
            try
            {
                var sage = GetSage();
                _sageService.AddSage(sage);
                InitializeDataGrid();
            }
            catch (Exception)
            {
                ShowMessage("Couldn't add new book");
            }
        }

        private void btnUpdateSage_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedItem() == null)
                {
                    ShowMessage("No row is selected. Select any", "Warning", icon: MessageBoxIcon.Warning);
                    return;
                }

                var sage = GetSage();
                sage.Id = CurrentSage.Id;
                _sageService.EditSage(sage);
                InitializeDataGrid();
            }
            catch (Exception)
            {
                ShowMessage("Couldn't update book");
            }
        }

        private void btnSageDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedItem() == null)
                {
                    ShowMessage("No row is selected. Select any", "Warning", icon: MessageBoxIcon.Warning);
                    return;
                }

                _sageService.DeleteSage(CurrentSage.Id);
                InitializeDataGrid();
            }
            catch (Exception)
            {
                ShowMessage("Couldn't delete new book");
            }
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Images " +
                "(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|" +
                "*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";

            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select Photos";

            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    pbPhoto.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void datSages_SelectionChanged(object sender, EventArgs e)
        {
            var sage = GetSelectedItem();

            if (sage != null)
            {
                SetCurrentSage(sage.Id);
                SetSageProperties(sage);
                RefreshCollections();
            }

            return;
        }

        private void SagesControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                InitializeDataGrid();
                InitializeCollection();
                SetupPictureBox();
            }
        }

        #endregion EVENT_HANDLERS
    }
}