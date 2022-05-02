using System.ComponentModel.DataAnnotations;

namespace ProjectNS.ViewModel
{
    public class RecallTypeVM
    {
        public int RecallTypeId { get; set; }
        [Required(ErrorMessage = "Please Enter Recall Type"), MaxLength(30)]
        public string RecallTypeName { get; set; }
        [Required(ErrorMessage = "Please Enter Description"), MaxLength(255)]
        public string Description { get; set; }
    }
}
