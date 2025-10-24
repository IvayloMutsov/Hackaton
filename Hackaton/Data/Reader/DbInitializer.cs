namespace Hackaton.Data.Reader
{
    public static class DbInitializer
    {
        public static void SeedProffessors()
        {
            StreamReader reader = new StreamReader("Database.xlsx");
            using (reader)
            {

            }
        }
    }
}
