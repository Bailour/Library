using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PagedList;
using PagedList.Mvc;

namespace Library_System.Models
{
    public class Books
    {
        public Books()
        {
            
        }
        [Key]
        public int Bookid { get; set; }
        [DisplayName("Book Name")]
        public string Title { get; set; }
        [DisplayName("Book Description")]
        public string Description { get; set; }
        public string Author { get; set; }
        [DisplayName("Book Category")]  
        
        public string Category { get; set; }
        [DisplayName("Book Sub Category")]
        public string SubCategory { get; set; }
        [DisplayName("Publication Date Time")]
        public DateTime PublicationDate { get; set; }
    }
}
