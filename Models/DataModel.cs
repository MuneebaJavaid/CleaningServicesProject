using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaafCleaningProject.Models
{
    public class DataModel
    {
        [Key]
        public int CId { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string CName { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string CEmail { get; set; }
        [Column(TypeName = "Varchar(15)")]
        public string CPhone { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string CAddress { get; set; }
        [Column(TypeName = "Varchar(200)")]
        public string message { get; set; }

    }


}
