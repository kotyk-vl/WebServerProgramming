using SageBook.Data.Models;
using SageBook.Repository;
using SageBook.Repository.Interfaces;
using System.Collections.Immutable;
using System.Data;

namespace SageBook.Lab1.WinForm.UserControls
{
    public partial class BooksControl : UserControl
    {
        private readonly IBookRepository _bookRepository;
        private readonly ISageRepository _sageRepository;

        private Book _book;

        public Book CurrentBook
        {
            get
            {
                if (_book == null)
                {
                    _book = new Book();
                }
                return _book;
            }
            set { _book = value; }
        }

        private List<Sage> _sages;

        public List<Sage> SelectedSages
        {
            get
            {
                if (_sages != null)
                {
                    return CurrentBook.Sages.Where(s => _sages.Select(x => x.SageId).Contains(s.SageId)).ToList();
                }

                return new List<Sage>();
            }
        }

        public List<Sage> AvailableSages
        {
            get
            {
                if (_sages != null)
                {
                    return _sages.Where(s => !CurrentBook.Sages.Select(x => x.SageId).Contains(s.SageId) || CurrentBook.BookId == 0).ToList();
                }

                return new List<Sage>();
            }
        }

        public BooksControl()
        {
            _sages = new List<Sage>();
            _bookRepository = new BookRepository();
            _sageRepository = new SageRepository();

            InitializeComponent();
            InitializeDataGrid();
            InitalizeCollections();
        }

        private Book GetBook()
        {
            return new Book
            {
                Name = txtBookName.Text,
                Description = txtBookDescription.Text
            };
        }

        private void InitializeDataGrid()
        {
            datBooks.DataSource = _bookRepository.GetBooks().ToList();
            datBooks.Refresh();
        }

        private void InitalizeCollections()
        {
            if (datBooks.Rows.Count > 0)
            {
                var bookId = (int)datBooks.Rows[0].Cells["BookId"].Value;
                CurrentBook = _bookRepository.GetBooksById(bookId);
                //CurrentBook = (Book)row.DataBoundItem;
            }

            _sages = _sageRepository.GetSages().ToList();

            cmbSages.DataSource = AvailableSages;
            cmbSages.DisplayMember = "Name";
            cmbSages.ValueMember = "SageId";
            cmbSages.SelectedItem = null;
            cmbSages.SelectedText = "Select Item";

            lstSages.DataSource = SelectedSages;
            lstSages.DisplayMember = "Name";
            lstSages.ValueMember = "SageId";
        }

        private void UpsertSageToBook(Book book)
        {
            book.Sages.Clear();

            if (_sages.Count > 0)
            {
                foreach (var sage in _sages)
                {
                    book.Sages.Add(sage);
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var book = GetBook();
            _bookRepository.AddNewBook(book);

            if (_sages.Capacity > 0)
            {
                UpsertSageToBook(book);
                _bookRepository.EditBook(book);
            }

            InitializeDataGrid();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            //var id = GetSelectedRow();

            //var book = _bookRepository.GetBooksById(id);
            //book.Name = txtBookName.Text;
            //book.Description = txtBookDescription.Text;

            //UpsertSageToBook(book);

            _bookRepository.EditBook(CurrentBook);

            InitializeDataGrid();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (datBooks.SelectedRows.Count > 0)
            {
                //int id = GetSelectedRow();
                _bookRepository.DeleteBook(CurrentBook.BookId);
                InitializeDataGrid();
            }
        }

        private int GetSelectedRow()
        {
            var selectedIndex = datBooks.SelectedRows[0].Index;
            var selectedRow = datBooks.Rows[selectedIndex];
            var id = (int)selectedRow.Cells["BookId"].Value;

            return id;
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = txtBookSearch.Text;

            if (int.TryParse(searchTerm, out int id))
            {
                datBooks.DataSource = new List<Book> { _bookRepository.GetBooksById(id) };
            }
            else
            {
                datBooks.DataSource = _bookRepository.SearchBook(searchTerm);
            }
        }

        private void btnAddSage_Click(object sender, EventArgs e)
        {
            var selectedSage = (Sage)cmbSages.SelectedItem;

            if (selectedSage != null)
            {
                if (CurrentBook.Sages.Select(x => x.SageId).Contains(selectedSage.SageId))
                    return;

                CurrentBook.Sages.Add(selectedSage);
                RefreshCollections();
            }
        }

        private void btnRemoveSage_Click(object sender, EventArgs e)
        {
            var selectedSage = (Sage)lstSages.SelectedItem;

            if (selectedSage != null)
            {
                if (!CurrentBook.Sages.Select(x => x.SageId).Contains(selectedSage.SageId))
                    return;

                var sage = CurrentBook.Sages.First(x => x.SageId == selectedSage.SageId);

                CurrentBook.Sages.Remove(sage);
                RefreshCollections();
            }
        }

        private void RefreshCollections()
        {
            cmbSages.DataSource = AvailableSages;
            if (cmbSages.Items.Count == 0)
            {
                cmbSages.SelectedItem = null;
                cmbSages.SelectedText = "Select Item";
            }

            lstSages.DataSource = SelectedSages;
        }

        private void datBooks_SelectionChanged(object sender, EventArgs e)
        {
            var book = (Book)datBooks.CurrentRow.DataBoundItem;

            if (book == null) { return; }

            CurrentBook = _bookRepository.GetBooksById(book.BookId);
            txtBookName.Text = book.Name;
            txtBookDescription.Text = book.Description;
            RefreshCollections();

            //var existedSages = _bookRepository.GetBooksById(book.BookId).SageBooks.Select(x => x.Sage).ToList();
            //lstSages.DataSource = existedSages;
            //cmbSages.DataSource = _sageRepository.GetSages()
            //    .Where(availableSage => !existedSages.Select(x => x.SageId).Contains(availableSage.SageId)).ToList();
        }
    }
}