namespace Locus.TMS.Domain.Common.Models
{
    public class EntityModel
    {
        public EntityModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; protected set; }
    }
}
