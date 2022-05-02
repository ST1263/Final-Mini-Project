using System.ComponentModel.DataAnnotations;

namespace ProjectNS.ViewModel
{
    public class RecallInfoVM
    {
        public int RecallInfoId { get; set; }
        public int RecallId { get; set; }
        [Required(ErrorMessage = "Please Enter Recall Name"), MaxLength(30)]
        public string RecallName { get; set; }
        [Required(ErrorMessage = "Please Enter Recall Type"), MaxLength(30)]
        public string RecallType { get; set; }
        public string RecallDate { get; set; }
        public int ZNumber { get; set; }
        [Required(ErrorMessage = "Please Enter FDA Classification"), MaxLength(30)]
        public string FDAClassification { get; set; }
        [Required(ErrorMessage = "Please Enter Recall Categories"), MaxLength(30)]
        public string RecallCategories { get; set; }
        [MaxLength(30)]
        public string RecallStatus { get; set; }
        public bool MarkAsUrgent { get; set; }
        public bool CustomizeedContent { get; set; }
        [MaxLength(30)]
        public string SupplierVoluntaryRegulatoryMandate { get; set; }
        [MaxLength(255)]
        public string SupportingMaterial { get; set; }
        public string Description { get; set; }
    }
}
