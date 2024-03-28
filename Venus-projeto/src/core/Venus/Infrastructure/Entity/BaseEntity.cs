namespace Infrastructure.Entity
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime DataCreate { get; set; } = DateTime.Now;
    }
}
