using System.Collections.Generic;

namespace T4Helpers
{
    public class DbTable
    {
        public string Name { get; set; }
        public List<DbColumn> Columns { get; set; }
    }
}
