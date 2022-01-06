using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Designation { get; set; }
        public bool IsActive { get; set; }
    }
}
