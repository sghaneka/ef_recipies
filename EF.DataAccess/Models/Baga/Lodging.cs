namespace EF.DataAccess.Models.Baga
{
    public class Lodging
    {
        public int LodgingId { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public bool IsResort { get; set; }

        //public Destination Destination { get; set; }

        public int DestinationId { get; set; }

        // pros and cons with the foreign key id thing
        // if you use the id, then it's not nullable (foreign key is required)
        // also, you don't have to have the entire object in memory to connect to the destination...

        public Person PrimaryContactFor { get; set; }
        public Person SecondaryContactFor { get; set; }
    }
}
