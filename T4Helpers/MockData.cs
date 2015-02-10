using System.Collections.Generic;

namespace T4Helpers
{
    public class MockData
    {
        public static List<DbTable> GetAllTables()
        {
            return new List<DbTable>
            {
                new DbTable
                {
                    Name = "User",
                    Columns = new List<DbColumn>
                    {
                        new DbColumn("UserId","int", true),
                        new DbColumn("Name","string", true),
                        new DbColumn("Username","string", true),
                        new DbColumn("TimesLoggedIn","int", true),
                        new DbColumn("DateCreatedUtc","DateTime", true),
                        new DbColumn("LastLoggedInUtc","DateTime?", false),
                        new DbColumn("FavouritePet","Pet",false)
                    }
                    
                },
                new DbTable
                {
                    Name ="Pet",
                    Columns = new List<DbColumn>
                    {
                        new DbColumn("PetId","int", true),
                        new DbColumn("Name","string", true)
                    }
                }
            };
        }
    }
}