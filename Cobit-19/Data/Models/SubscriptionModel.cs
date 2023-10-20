using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    [PrimaryKey(nameof(ApplicationUserID), nameof(FocusAreaID))]
    public class SubscriptionModel
    {
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        [ForeignKey("FocusAreaModel")]
        public int FocusAreaID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual FocusAreaModel FocusArea { get; set; }
    }
}
