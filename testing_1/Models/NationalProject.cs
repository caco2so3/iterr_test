namespace testing_1.Models
{
    public class NationalProject
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
        public virtual Employee Employee { get; set; }
    }
}