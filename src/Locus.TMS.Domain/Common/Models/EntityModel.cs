namespace Locus.TMS.Domain.Common.Models
{
    public abstract class EntityModel
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTimeOffset CreatedAt { get; protected set; } = DateTime.Now;
        public Guid? CreatedBy { get; protected set; }
    }
}
