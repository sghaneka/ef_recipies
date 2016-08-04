namespace EF.DataAccess.Models.Poems
{
    public class Poem
    {
        public Poet Poet { get; set; }
        public int PoemId { get; set; }
        public string Title { get; set; }
        public int MeterId { get; set; }

    // Let's take out this property, then we will refer to the Poet directly and the foreign key will be optional
      //  public int PoetId { get; set; }

        public Meter Meter { get; set; }

    }
}
