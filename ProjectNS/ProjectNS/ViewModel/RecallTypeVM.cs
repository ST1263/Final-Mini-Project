using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNS.ViewModel
{
    public class RecallTypeVM
    {
        public int RecallTypeId { get; set; }
        [MaxLength(30)]
        public string RecallTypeName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
