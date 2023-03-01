namespace QuarzoModel
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}