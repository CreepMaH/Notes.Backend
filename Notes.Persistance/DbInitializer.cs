namespace Notes.Persistance
{
    public class DbInitializer
    {
        public static void Initialize(NotesDbContext notesDbContext)
        {
            notesDbContext.Database.EnsureCreated();
        }
    }
}
