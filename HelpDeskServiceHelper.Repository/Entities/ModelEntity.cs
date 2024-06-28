namespace HelpDeskServiceHelper.Repository.Entities
{
    public class ModelEntity : CommonEntity
    {
        public string Name { get; set; }

        public string ProductNumber { get; set; }

        public int ManufacturerId { get; set; }
    }
}
