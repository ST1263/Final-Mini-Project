using System.ComponentModel.DataAnnotations;

namespace ProjectNS.Model
{
    public class RecallType
    {
        [Key]
        public int RecallTypeId { get; set; }
        [MaxLength(30)]
        public string RecallTypeName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
      /*  public int RecallInfoId { get; set; }*/
  /*      public virtual RecallInfo RecallInfo { get; set; }*/
    }
}
