using Cobit_19.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Cobit_19.Shared.Enums;

namespace Cobit_19.Shared.Dtos
{
    public class AuditDto
    {
        public int ID { get; set; }
        public UserDto User { get; set; } = default!;
        public FocusAreaDto FocusArea { get; set; } = default!;
        public string Name { get; set; } = default!;
        public AuditStatus Status { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
