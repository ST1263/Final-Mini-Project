using System.ComponentModel.DataAnnotations;

namespace ProjectNS.Model
{
    public class FDAClassification
    {
        [Key]
        public int FDAClassificationId { get; set; }
        [MaxLength(30)]
        public string FdaClassificationName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
