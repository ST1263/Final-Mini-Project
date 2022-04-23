using ProjectNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNS.ViewModel
{
    public class RecallInfoVM
    {
        public int RecallInfoId { get; set; }
        public int RecallId { get; set; }
        public string RecallName { get; set; }
        public string RecallType { get; set; }
        public string RecallDate { get; set; }
        public int ZNumber { get; set; }
        public string FDAClassification { get; set; }
        public string RecallCategories { get; set; }
        public string RecallStatus { get; set; }
        public bool MarkAsUrgent { get; set; }
        public bool CustomizeedContent { get; set; }
        public string SupplierVoluntaryRegulatoryMandate { get; set; }
        public string SupportingMaterial { get; set; }
        public string Description { get; set; }
    }
}
