using System;
using System.Collections.Generic;
using Semiodesk.Trinity;

namespace CliExample
{
    [RdfClass(FOAF.Agent)]
    public class Agent : Resource
    {
        public Agent(Uri uri) : base(uri) 
        {
            EMailAccounts = new List<Resource>();
        }

        [RdfProperty(FOAF.name)]
        public string Name { get; set; }

        [RdfProperty(FOAF.mbox)]
        public List<Resource> EMailAccounts { get; set; }
    }

    [RdfClass(FOAF.Person)]
    public class Person : Agent
    {
        public Person(Uri uri) : base(uri) 
        {
            Knows = new List<Person>();
        }

        [RdfProperty(FOAF.knows)]
        public List<Person> Knows { get; set; }
    }

    [RdfClass(FOAF.Group)]
    public class Group : Agent
    {
        public Group(Uri uri) : base(uri) 
        {
            Member = new List<Agent>();
        }

        [RdfProperty(FOAF.member)]
        public List<Agent> Member { get; set; }
    }
}
