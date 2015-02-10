namespace T4Helpers
{
    public class DbColumn
    {
        public DbColumn(string name, string dotNetType, bool isRequired)
        {
            Name = name;
            DotNetType = dotNetType;
            IsRequired = isRequired;
        }

        public string Name { get; set; }
        public string DotNetType { get; set; }
        public bool IsRequired { get; set; }
    }
}