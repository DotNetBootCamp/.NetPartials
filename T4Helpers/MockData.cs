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
                    Name = "Users",
                    Columns = new List<DbColumn>
                    {
                        new DbColumn
                        {
                            Name = "UserId",
                            DotNetType = "int"
                        }
                    }
                    
                }
            };
        }
    }
}