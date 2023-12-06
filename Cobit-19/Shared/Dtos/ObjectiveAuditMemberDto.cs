using Cobit_19.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Shared.Dtos
{
    public class ObjectiveAuditMemberDto
    {
        public int ObjectiveAuditID { get; set; }
        public string ApplicationUserID { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Selected { get; set; }
        public UserDto UserDto { get; set; }
    }
}
