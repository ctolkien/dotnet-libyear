namespace LibYear.FileTypes
{
    public class PackagesConfigFile : XmlProjectFile
    {
        public PackagesConfigFile(string filename) : base(filename, "package", "id", "version")
        {
        }
    }
}