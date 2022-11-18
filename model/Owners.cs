using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalAssessmentDotNet.model
{
    [Table("Owners")]
    public class Owners
    {
        [Key]
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String DriverLicense { get; set; }

    }
}
