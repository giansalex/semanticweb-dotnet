using System;
using Semiodesk.Trinity;

namespace CliExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SemiodeskDiscovery.Discover();

            IStore store = StoreFactory.CreateStoreFromConfiguration("virt0");
            store.LoadOntologySettings();

            Uri modelUri = new Uri("http://semiodesk.com/example/cli");
            IModel model;

            if (store.ContainsModel(modelUri))
            {
                model = store.GetModel(modelUri);
                model.Clear();
            }
            else
                model = store.CreateModel(modelUri);
            

            Person john = model.CreateResource<Person>();
            john.EMailAccounts.Add(new Resource("mailto:john.doe@example.com"));
            john.Name = "John Doe";
            john.Commit();

            Group myGroup = model.CreateResource<Group>();
            myGroup.Name = "My Group";
            myGroup.Member.Add(john);
            myGroup.Commit();

            var agents = model.GetResources<Agent>(true);
            foreach (var x in agents)
            {
                Console.WriteLine(x.Name);
            }
        }
    }
}
