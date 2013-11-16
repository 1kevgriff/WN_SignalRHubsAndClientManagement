using System.Data.Entity;

namespace GriffDesk.ServiceLibrary.Data
{
    public static class DatabaseConfiguration
    {
        public static void Configure()
        {
            Database.SetInitializer(new GriffDeskDatabaseInitializer());
        }
    }
}