using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst4NorthvndTables.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        public string CompanyName { get; set; }
        [MaxLength(40)]
        public string? ContactName { get; set; }
        [MaxLength(30)]

        public string? ContactTittle { get; set; }
        [MaxLength(30)]
        public string? Address { get; set; }
        [MaxLength(60)]
        public string? City { get; set; }
        [MaxLength(15)]

        public string? Region { get; set; }
        [MaxLength(15)]

        public string? PostalCode { get; set; }
        [MaxLength(10)]

        public string? Country { get; set; }
        [MaxLength(15)]

        public string? Phone { get; set; }
        [MaxLength(24)]

        public string? Fax { get; set; }
        [MaxLength(24)]
        public string? HomePage { get; set; }

    }
}