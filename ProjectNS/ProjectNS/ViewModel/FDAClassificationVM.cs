
using System.ComponentModel.DataAnnotations;

namespace ProjectNS.ViewModel
{
    public class FDAClassificationVM
    {
        public int FDAClassificationId { get; set; }
        [MaxLength(30)]
        public string FdaClassificationName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
