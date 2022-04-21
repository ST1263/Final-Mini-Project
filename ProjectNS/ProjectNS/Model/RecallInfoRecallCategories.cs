using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNS.Model
{
    public class RecallInfoRecallCategories
    {
        [Key]
        public int RecallInfoRecallCategoriesId { get; set; }
        [ForeignKey("RecallInfo")]
        public int RecallInfoId { get; set; }
        [ForeignKey("RecallCategories")]
        public int RecallCategoriesId { get; set; }
        public virtual RecallInfo RecallInfo { get; set; }
        public virtual RecallCategories RecallCategories { get; set; }
    }
}
