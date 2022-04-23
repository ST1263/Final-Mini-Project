using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNS.Model
{
    public class RecallCategories
    {
        [Key]
        public int RecallCategoriesId { get; set; }
        [MaxLength(30)]
        public string RecallCategoriesName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public virtual RecallInfo RecallInfo { get; set; }
    }
}
