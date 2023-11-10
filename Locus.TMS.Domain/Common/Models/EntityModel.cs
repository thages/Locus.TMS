namespace Locus.TMS.Domain.Common.Models
{
    public class EntityModel
    {
        public EntityModel()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; protected set; }
        public DateTimeOffset CreatedAt { get; protected set; }
        public Guid? CreatedBy { get; protected set; }
    }
}
