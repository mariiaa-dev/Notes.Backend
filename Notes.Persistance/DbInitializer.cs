namespace Notes.Persistance
{
    public class DbInitializer
    {
        public static void Initiatize(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
