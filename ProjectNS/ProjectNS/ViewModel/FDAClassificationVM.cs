using System.ComponentModel.DataAnnotations;

namespace ProjectNS.ViewModel
{
    public class FDAClassificationVM
    {
        public int FDAClassificationId { get; set; }
        [Required(ErrorMessage = "Please Enter FDA Classification"), MaxLength(30)]
        public string FdaClassificationName { get; set; }
        [Required(ErrorMessage = "Please Enter Description"), MaxLength(255)]
        public string Description { get; set; }
    }
}
