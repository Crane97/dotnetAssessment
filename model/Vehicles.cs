using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalAssessmentDotNet.model
{
    [Table("Vehicles")]
    public class Vehicles
    {
        [Key]
        public int Id { get; set; }

        public String Brand { get; set; }

        public String Vin { get; set; }

        public String Color { get; set; }

        public int Year { get; set; }

        public int Owner_Id { get; set; }
    }
}
