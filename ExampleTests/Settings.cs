using DataRepository;

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
                    repo.RegisterReader(new XmlFileObjectReader<Tree>());
                    repo.RegisterReader(new CsvFileObjectReader<Permission>());
                }
                return repo;
            }
        }
    }
}
