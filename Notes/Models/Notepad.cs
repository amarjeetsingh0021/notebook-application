using System.ComponentModel.DataAnnotations;

namespace Notebook.Models
{
    public class Notepad
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string title { get; set; } = string.Empty;

        [Required, StringLength(1000)]
        public string description { get; set; } = string.Empty;
        public Priorities priority { get; set; }

        public DateTime createdDate { get; set; } = DateTime.UtcNow;
        public DateTime modifiedDate { get; set; } = DateTime.UtcNow;
        public string createdBy { get; set; } = string.Empty;
    }
    public enum Priorities { Low, Medium, High}
}
