using DataRepository;
using System.Collections.Generic;

namespace ExampleTests
{
    static class Settings
    {
        private static Repository repo;

        public static Repository Repo
        {
            get
            {
                if (repo == null)
                {
                    repo = new Repository();
                    repo.RegisterReader(new XmlFileObjectReader());
                    repo.RegisterReader(new CsvFileObjectReader());
                }
                return repo;
            }
        }

        public static Tree ReporterTree
        {
            get { return Repo.Read<Tree>("ReporterTree"); }
        }

        public static IEnumerable<Permission> SxpPermissions
        {
            get { return Repo.ReadMany<Permission>("SxpPermissions"); }
        }
    }
}
