namespace SageBook.Lab2_3.MVC_WebAPI.Models.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<string> SageList { get; set; }

        public string Sages
        {
            get
            {
                if (SageList == null)
                {
                    return string.Empty;
                }
                return string.Join(", ", SageList);
            }
        }
    }
}