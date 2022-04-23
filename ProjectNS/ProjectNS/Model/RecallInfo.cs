using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNS.Model
{
    public class RecallInfo
    {
        [Key]
        public int RecallInfoId { get; set; }
        public int RecallId { get; set; }
        [MaxLength(30)]
        public string RecallName { get; set; }
        [MaxLength(30)]
        public string RecallType { get; set; }
        public string RecallDate { get; set; }
        public int ZNumber { get; set; }
        [MaxLength(30)]
        public string FDAClassification { get; set; }
        [MaxLength(30)]
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
        public ICollection<RecallCategories> RecallCategorieas { get; set; }
    }
}
