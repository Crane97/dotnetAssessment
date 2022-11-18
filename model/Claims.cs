using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalAssessmentDotNet.model
{
    [Table("claims")]
    public class Claims
    {
        [Key]
        public int Id { get; set; }

        public String Description { get; set; }

        public String Status { get; set; }

        public DateTime Date { get; set; }

        public int Vehicle_Id { get; set; }


    }
}
