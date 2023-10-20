using System.ComponentModel.DataAnnotations;

namespace Cobit_19.Data
{
    public abstract class AppModel<TKey> where TKey : IEquatable<TKey>
    {
        [Key]
        public virtual TKey ID { get; set; } = default!;
    }
}
