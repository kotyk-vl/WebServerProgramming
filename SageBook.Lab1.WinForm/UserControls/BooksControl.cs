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
    public partial class BooksControl : UserControl
    {
        private readonly IBookService _bookService;
        private readonly ISageService _sageService;

        private BookModel _book;
        private List<SageModel> _sages;

        #region PROPERTIES

        public BookModel CurrentBook
        {
            get
            {
                if (_book == null)
                {
                    _book = new BookModel();
                }
                return _book;
            }
            set { _book = value; }
        }

        public List<ComboItem> SelectedSages
        {
            get
            {
                if (_sages != null)
                {
                    return _sages
                        .Where(s => CurrentBook.SageIds.Contains(s.Id))
                        .Select(Helper.GetSageList)
                        .OrderBy(i => i.Text)
                        .ToList();
                }

                return new List<ComboItem>();
            }
        }

        public List<ComboItem> AvailableSages
        {
            get
            {
                if (_sages != null)
                {
                    return _sages
                        .Where(s => !CurrentBook.SageIds
                            .Contains(s.Id) || CurrentBook.Id == 0)
                        .Select(Helper.GetSageList)
                        .OrderBy(i => i.Text)
                        .Prepend(new ComboItem { ID = 0, Text = "Select Item" })
                        .ToList();
                }

                return new List<ComboItem>();
            }
        }

        #endregion PROPERTIES

        public BooksControl()
        {
            _sages = new List<SageModel>();
            _bookService = new BookService(new BookRepository());
            _sageService = new SageService(new SageRepository());

            InitializeComponent();
            InitializeDataGrid();
            InitalizeCollections();
        }

        #region PRIVATE METHODS

        private BookModel GetBook()
        {
            return new BookModel
            {
                Name = txtBookName.Text,
                Description = txtBookDescription.Text
            };
        }

        private void InitializeDataGrid()
        {
            GetBooks();
        }

        private void InitalizeCollections()
        {
            if (datBooks.Rows.Count > 0)
            {
                var bookId = (int)datBooks.Rows[0].Cells["Id"].Value;
                SetCurrentBook(bookId);
            }

            _sages = _sageService.GetSages().ToList();

            SetAvailableSages();
            SetSelectedSages();
        }

        private void SetAvailableSages()
        {
            cmbSages.DataSource = AvailableSages;
            cmbSages.DisplayMember = "Text";
            cmbSages.ValueMember = "ID";
            cmbSages.SelectedItem = 0;
        }

        private void SetSelectedSages()
        {
            lstSages.DataSource = SelectedSages;
            lstSages.DisplayMember = "Text";
            lstSages.ValueMember = "ID";
        }

        private void RefreshCollections()
        {
            cmbSages.DataSource = AvailableSages;
            lstSages.DataSource = SelectedSages;
        }

        private void SetCurrentBook(int bookId)
        {
            CurrentBook = _bookService.GetBookById(bookId) ?? new BookModel();
        }

        private void ShowMessage(string text, string caption = "Error", MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            MessageBox.Show(text, caption, button, icon);
        }

        private BookModel GetSelectedItem()
        {
            return (BookModel)datBooks.CurrentRow?.DataBoundItem;
        }

        private void GetBooks()
        {
            var searchTerm = txtBookSearch.Text;

            if (int.TryParse(searchTerm, out int id))
            {
                datBooks.DataSource = new List<BookModel> { _bookService.GetBookById(id) ?? new BookModel() };
            }
            else if (!string.IsNullOrEmpty(searchTerm))
            {
                datBooks.DataSource = _bookService.SearchBook(searchTerm).ToList();
            }
            else
            {
                datBooks.DataSource = _bookService.GetBooks().ToList();
            }
            datBooks.Refresh();
        }

        #endregion PRIVATE METHODS

        #region EVENT_HANDLERS

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                var book = GetBook();
                book.SageIds.AddRange(CurrentBook.SageIds);
                _bookService.AddNewBook(book);
                InitializeDataGrid();
            }
            catch (Exception)
            {
                ShowMessage("Couldn't add new book");
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            var book = GetBook();

            try
            {
                if (GetSelectedItem() == null)
                {
                    ShowMessage("No row is selected. Select any", "Warning", icon: MessageBoxIcon.Warning);
                    return;
                }

                book.Id = CurrentBook.Id;
                book.SageIds.AddRange(CurrentBook.SageIds);
                _bookService.EditBook(book);

                InitializeDataGrid();
            }
            catch (Exception ex)
            {
                ShowMessage($"Couldn't update book - {book.Name}");
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedItem() == null)
                {
                    ShowMessage("No row is selected. Select any", "Warning", icon: MessageBoxIcon.Warning);
                    return;
                }

                _bookService.DeleteBook(CurrentBook.Id);
                InitializeDataGrid();
            }
            catch (Exception)
            {
                ShowMessage($"Couldn't delete book");
            }
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            GetBooks();
        }

        private void btnAddSage_Click(object sender, EventArgs e)
        {
            var selectedSage = (ComboItem)cmbSages.SelectedItem;

            if (selectedSage.ID != 0)
            {
                if (CurrentBook.SageIds.Contains(selectedSage.ID))
                    return;

                CurrentBook.SageIds.Add(selectedSage.ID);
                RefreshCollections();
            }
        }

        private void btnRemoveSage_Click(object sender, EventArgs e)
        {
            var selectedSage = (ComboItem)lstSages.SelectedItem;

            if (selectedSage != null)
            {
                if (!CurrentBook.SageIds.Contains(selectedSage.ID))
                    return;

                CurrentBook.SageIds.Remove(selectedSage.ID);
                RefreshCollections();
            }
        }

        private void datBooks_SelectionChanged(object sender, EventArgs e)
        {
            var book = GetSelectedItem();

            if (book != null)
            {
                SetCurrentBook(book.Id);
                txtBookName.Text = book.Name;
                txtBookDescription.Text = book.Description;
                RefreshCollections();
            }

            return;
        }

        private void BooksControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                InitializeDataGrid();
                InitalizeCollections();
            }
        }

        #endregion EVENT_HANDLERS
    }
}