using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace SageBook.Lab2_3.MVC_WebAPI.Models.Book
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public List<SelectListItem> Sages { get; set; }

        [Display(Name = "Sages: ")]
        public string SageText
        {
            get
            {
                if (Sages != null && Sages.Count > 0)
                {
                    var selected = Sages.Where(x => x.Selected);
                    return string.Join(", ", selected.Select(x => x.Text));
                }
                return string.Empty;
            }
        }

        public BookViewModel()
        {
            Sages = new List<SelectListItem>();
        }
    }
}