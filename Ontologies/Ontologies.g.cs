// Attention: This file is generated. Any modifications will eventually be overwritten.
// Date: 17/04/2018 10:53:14

using System;
using System.Collections.Generic;
using System.Text;
using Semiodesk.Trinity;

namespace CliExample
{
	
///<summary>
///The RDF Concepts Vocabulary (RDF)
///
///</summary>
public class rdf : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "rdf";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#"/>
    ///</summary>
    public static readonly Resource _22_rdf_syntax_ns = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));    

    ///<summary>
    ///The datatype of RDF literals storing fragments of HTML content
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"/>
    ///</summary>
    public static readonly Resource HTML = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"));    

    ///<summary>
    ///The datatype of language-tagged string values
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"/>
    ///</summary>
    public static readonly Resource langString = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"));    

    ///<summary>
    ///The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"/>
    ///</summary>
    public static readonly Resource PlainLiteral = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"));    

    ///<summary>
    ///The subject is an instance of a class.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"/>
    ///</summary>
    public static readonly Property type = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"));    

    ///<summary>
    ///The class of RDF properties.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"/>
    ///</summary>
    public static readonly Class Property = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"));    

    ///<summary>
    ///The class of RDF statements.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"/>
    ///</summary>
    public static readonly Class Statement = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"));    

    ///<summary>
    ///The subject of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"/>
    ///</summary>
    public static readonly Property subject = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"));    

    ///<summary>
    ///The predicate of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"/>
    ///</summary>
    public static readonly Property predicate = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"));    

    ///<summary>
    ///The object of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"/>
    ///</summary>
    public static readonly Property _object = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#object"));    

    ///<summary>
    ///The class of unordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"/>
    ///</summary>
    public static readonly Class Bag = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"));    

    ///<summary>
    ///The class of ordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"/>
    ///</summary>
    public static readonly Class Seq = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"));    

    ///<summary>
    ///The class of containers of alternatives.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"/>
    ///</summary>
    public static readonly Class Alt = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"));    

    ///<summary>
    ///Idiomatic property used for structured values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"/>
    ///</summary>
    public static readonly Property value = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#value"));    

    ///<summary>
    ///The class of RDF Lists.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"/>
    ///</summary>
    public static readonly Class List = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#List"));    

    ///<summary>
    ///The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"/>
    ///</summary>
    public static readonly Resource nil = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"));    

    ///<summary>
    ///The first item in the subject RDF list.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"/>
    ///</summary>
    public static readonly Property first = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#first"));    

    ///<summary>
    ///The rest of the subject RDF list after the first item.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"/>
    ///</summary>
    public static readonly Property rest = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"));    

    ///<summary>
    ///The datatype of XML literal values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"/>
    ///</summary>
    public static readonly Resource XMLLiteral = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"));
}
///<summary>
///The RDF Concepts Vocabulary (RDF)
///
///</summary>
public static class RDF
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "RDF";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#"/>
    ///</summary>
    public const string _22_rdf_syntax_ns = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";

    ///<summary>
    ///The datatype of RDF literals storing fragments of HTML content
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"/>
    ///</summary>
    public const string HTML = "http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML";

    ///<summary>
    ///The datatype of language-tagged string values
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"/>
    ///</summary>
    public const string langString = "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString";

    ///<summary>
    ///The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"/>
    ///</summary>
    public const string PlainLiteral = "http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral";

    ///<summary>
    ///The subject is an instance of a class.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"/>
    ///</summary>
    public const string type = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type";

    ///<summary>
    ///The class of RDF properties.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"/>
    ///</summary>
    public const string Property = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Property";

    ///<summary>
    ///The class of RDF statements.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"/>
    ///</summary>
    public const string Statement = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement";

    ///<summary>
    ///The subject of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"/>
    ///</summary>
    public const string subject = "http://www.w3.org/1999/02/22-rdf-syntax-ns#subject";

    ///<summary>
    ///The predicate of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"/>
    ///</summary>
    public const string predicate = "http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate";

    ///<summary>
    ///The object of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"/>
    ///</summary>
    public const string _object = "http://www.w3.org/1999/02/22-rdf-syntax-ns#object";

    ///<summary>
    ///The class of unordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"/>
    ///</summary>
    public const string Bag = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag";

    ///<summary>
    ///The class of ordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"/>
    ///</summary>
    public const string Seq = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq";

    ///<summary>
    ///The class of containers of alternatives.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"/>
    ///</summary>
    public const string Alt = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt";

    ///<summary>
    ///Idiomatic property used for structured values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"/>
    ///</summary>
    public const string value = "http://www.w3.org/1999/02/22-rdf-syntax-ns#value";

    ///<summary>
    ///The class of RDF Lists.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"/>
    ///</summary>
    public const string List = "http://www.w3.org/1999/02/22-rdf-syntax-ns#List";

    ///<summary>
    ///The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"/>
    ///</summary>
    public const string nil = "http://www.w3.org/1999/02/22-rdf-syntax-ns#nil";

    ///<summary>
    ///The first item in the subject RDF list.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"/>
    ///</summary>
    public const string first = "http://www.w3.org/1999/02/22-rdf-syntax-ns#first";

    ///<summary>
    ///The rest of the subject RDF list after the first item.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"/>
    ///</summary>
    public const string rest = "http://www.w3.org/1999/02/22-rdf-syntax-ns#rest";

    ///<summary>
    ///The datatype of XML literal values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"/>
    ///</summary>
    public const string XMLLiteral = "http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral";
}
///<summary>
///The RDF Schema vocabulary (RDFS)
///
///</summary>
public class rdfs : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2000/01/rdf-schema#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "rdfs";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#"/>
    ///</summary>
    public static readonly Resource rdf_schema = new Resource(new Uri("http://www.w3.org/2000/01/rdf-schema#"));    

    ///<summary>
    ///The class resource, everything.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Resource"/>
    ///</summary>
    public static readonly Class Resource = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Resource"));    

    ///<summary>
    ///The class of classes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public static readonly Class Class = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Class"));    

    ///<summary>
    ///The subject is a subclass of a class.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subClassOf"/>
    ///</summary>
    public static readonly Property subClassOf = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#subClassOf"));    

    ///<summary>
    ///The subject is a subproperty of a property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"/>
    ///</summary>
    public static readonly Property subPropertyOf = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#subPropertyOf"));    

    ///<summary>
    ///A description of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#comment"/>
    ///</summary>
    public static readonly Property comment = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#comment"));    

    ///<summary>
    ///A human-readable name for the subject.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#label"/>
    ///</summary>
    public static readonly Property label = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#label"));    

    ///<summary>
    ///A domain of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#domain"/>
    ///</summary>
    public static readonly Property domain = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#domain"));    

    ///<summary>
    ///A range of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#range"/>
    ///</summary>
    public static readonly Property range = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#range"));    

    ///<summary>
    ///Further information about the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#seeAlso"/>
    ///</summary>
    public static readonly Property seeAlso = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#seeAlso"));    

    ///<summary>
    ///The defininition of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"/>
    ///</summary>
    public static readonly Property isDefinedBy = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#isDefinedBy"));    

    ///<summary>
    ///The class of literal values, eg. textual strings and integers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Literal"/>
    ///</summary>
    public static readonly Class Literal = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Literal"));    

    ///<summary>
    ///The class of RDF containers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Container"/>
    ///</summary>
    public static readonly Class Container = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Container"));    

    ///<summary>
    ///The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                    all of which are sub-properties of 'member'.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"/>
    ///</summary>
    public static readonly Class ContainerMembershipProperty = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"));    

    ///<summary>
    ///A member of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#member"/>
    ///</summary>
    public static readonly Property member = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#member"));    

    ///<summary>
    ///The class of RDF datatypes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Datatype"/>
    ///</summary>
    public static readonly Class Datatype = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Datatype"));
}
///<summary>
///The RDF Schema vocabulary (RDFS)
///
///</summary>
public static class RDFS
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2000/01/rdf-schema#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "RDFS";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#"/>
    ///</summary>
    public const string rdf_schema = "http://www.w3.org/2000/01/rdf-schema#";

    ///<summary>
    ///The class resource, everything.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Resource"/>
    ///</summary>
    public const string Resource = "http://www.w3.org/2000/01/rdf-schema#Resource";

    ///<summary>
    ///The class of classes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public const string Class = "http://www.w3.org/2000/01/rdf-schema#Class";

    ///<summary>
    ///The subject is a subclass of a class.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subClassOf"/>
    ///</summary>
    public const string subClassOf = "http://www.w3.org/2000/01/rdf-schema#subClassOf";

    ///<summary>
    ///The subject is a subproperty of a property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"/>
    ///</summary>
    public const string subPropertyOf = "http://www.w3.org/2000/01/rdf-schema#subPropertyOf";

    ///<summary>
    ///A description of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#comment"/>
    ///</summary>
    public const string comment = "http://www.w3.org/2000/01/rdf-schema#comment";

    ///<summary>
    ///A human-readable name for the subject.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#label"/>
    ///</summary>
    public const string label = "http://www.w3.org/2000/01/rdf-schema#label";

    ///<summary>
    ///A domain of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#domain"/>
    ///</summary>
    public const string domain = "http://www.w3.org/2000/01/rdf-schema#domain";

    ///<summary>
    ///A range of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#range"/>
    ///</summary>
    public const string range = "http://www.w3.org/2000/01/rdf-schema#range";

    ///<summary>
    ///Further information about the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#seeAlso"/>
    ///</summary>
    public const string seeAlso = "http://www.w3.org/2000/01/rdf-schema#seeAlso";

    ///<summary>
    ///The defininition of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"/>
    ///</summary>
    public const string isDefinedBy = "http://www.w3.org/2000/01/rdf-schema#isDefinedBy";

    ///<summary>
    ///The class of literal values, eg. textual strings and integers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Literal"/>
    ///</summary>
    public const string Literal = "http://www.w3.org/2000/01/rdf-schema#Literal";

    ///<summary>
    ///The class of RDF containers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Container"/>
    ///</summary>
    public const string Container = "http://www.w3.org/2000/01/rdf-schema#Container";

    ///<summary>
    ///The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                    all of which are sub-properties of 'member'.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"/>
    ///</summary>
    public const string ContainerMembershipProperty = "http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty";

    ///<summary>
    ///A member of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#member"/>
    ///</summary>
    public const string member = "http://www.w3.org/2000/01/rdf-schema#member";

    ///<summary>
    ///The class of RDF datatypes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Datatype"/>
    ///</summary>
    public const string Datatype = "http://www.w3.org/2000/01/rdf-schema#Datatype";
}
///<summary>
///The OWL 2 Schema vocabulary (OWL 2)
///
///</summary>
public class owl : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2002/07/owl#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "owl";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///  This ontology partially describes the built-in classes and
    ///  properties that together form the basis of the RDF/XML syntax of OWL 2.
    ///  The content of this ontology is based on Tables 6.1 and 6.2
    ///  in Section 6.4 of the OWL 2 RDF-Based Semantics specification,
    ///  available at http://www.w3.org/TR/owl2-rdf-based-semantics/.
    ///  Please note that those tables do not include the different annotations
    ///  (labels, comments and rdfs:isDefinedBy links) used in this file.
    ///  Also note that the descriptions provided in this ontology do not
    ///  provide a complete and correct formal description of either the syntax
    ///  or the semantics of the introduced terms (please see the OWL 2
    ///  recommendations for the complete and normative specifications).
    ///  Furthermore, the information provided by this ontology may be
    ///  misleading if not used with care. This ontology SHOULD NOT be imported
    ///  into OWL ontologies. Importing this file into an OWL 2 DL ontology
    ///  will cause it to become an OWL 2 Full ontology and may have other,
    ///  unexpected, consequences.
    ///   
    ///<see cref="http://www.w3.org/2002/07/owl"/>
    ///</summary>
    public static readonly Resource owl_0 = new Resource(new Uri("http://www.w3.org/2002/07/owl"));    

    ///<summary>
    ///The class of collections of pairwise different individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDifferent"/>
    ///</summary>
    public static readonly Class AllDifferent = new Class(new Uri("http://www.w3.org/2002/07/owl#AllDifferent"));    

    ///<summary>
    ///The class of collections of pairwise disjoint classes.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointClasses"/>
    ///</summary>
    public static readonly Class AllDisjointClasses = new Class(new Uri("http://www.w3.org/2002/07/owl#AllDisjointClasses"));    

    ///<summary>
    ///The class of collections of pairwise disjoint properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointProperties"/>
    ///</summary>
    public static readonly Class AllDisjointProperties = new Class(new Uri("http://www.w3.org/2002/07/owl#AllDisjointProperties"));    

    ///<summary>
    ///The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Annotation"/>
    ///</summary>
    public static readonly Class Annotation = new Class(new Uri("http://www.w3.org/2002/07/owl#Annotation"));    

    ///<summary>
    ///The class of annotation properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AnnotationProperty"/>
    ///</summary>
    public static readonly Class AnnotationProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#AnnotationProperty"));    

    ///<summary>
    ///The class of asymmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AsymmetricProperty"/>
    ///</summary>
    public static readonly Class AsymmetricProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#AsymmetricProperty"));    

    ///<summary>
    ///The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Axiom"/>
    ///</summary>
    public static readonly Class Axiom = new Class(new Uri("http://www.w3.org/2002/07/owl#Axiom"));    

    ///<summary>
    ///The class of OWL classes.
    ///<see cref="http://www.w3.org/2002/07/owl#Class"/>
    ///</summary>
    public static readonly Class Class = new Class(new Uri("http://www.w3.org/2002/07/owl#Class"));    

    ///<summary>
    ///The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    ///<see cref="http://www.w3.org/2002/07/owl#DataRange"/>
    ///</summary>
    public static readonly Class DataRange = new Class(new Uri("http://www.w3.org/2002/07/owl#DataRange"));    

    ///<summary>
    ///The class of data properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DatatypeProperty"/>
    ///</summary>
    public static readonly Class DatatypeProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#DatatypeProperty"));    

    ///<summary>
    ///The class of deprecated classes.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedClass"/>
    ///</summary>
    public static readonly Class DeprecatedClass = new Class(new Uri("http://www.w3.org/2002/07/owl#DeprecatedClass"));    

    ///<summary>
    ///The class of deprecated properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedProperty"/>
    ///</summary>
    public static readonly Class DeprecatedProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#DeprecatedProperty"));    

    ///<summary>
    ///The class of functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#FunctionalProperty"/>
    ///</summary>
    public static readonly Class FunctionalProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#FunctionalProperty"));    

    ///<summary>
    ///The class of inverse-functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#InverseFunctionalProperty"/>
    ///</summary>
    public static readonly Class InverseFunctionalProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#InverseFunctionalProperty"));    

    ///<summary>
    ///The class of irreflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#IrreflexiveProperty"/>
    ///</summary>
    public static readonly Class IrreflexiveProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#IrreflexiveProperty"));    

    ///<summary>
    ///The class of named individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#NamedIndividual"/>
    ///</summary>
    public static readonly Class NamedIndividual = new Class(new Uri("http://www.w3.org/2002/07/owl#NamedIndividual"));    

    ///<summary>
    ///The class of negative property assertions.
    ///<see cref="http://www.w3.org/2002/07/owl#NegativePropertyAssertion"/>
    ///</summary>
    public static readonly Class NegativePropertyAssertion = new Class(new Uri("http://www.w3.org/2002/07/owl#NegativePropertyAssertion"));    

    ///<summary>
    ///This is the empty class.
    ///<see cref="http://www.w3.org/2002/07/owl#Nothing"/>
    ///</summary>
    public static readonly Class Nothing = new Class(new Uri("http://www.w3.org/2002/07/owl#Nothing"));    

    ///<summary>
    ///The class of object properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ObjectProperty"/>
    ///</summary>
    public static readonly Class ObjectProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#ObjectProperty"));    

    ///<summary>
    ///The class of ontologies.
    ///<see cref="http://www.w3.org/2002/07/owl#Ontology"/>
    ///</summary>
    public static readonly Class Ontology = new Class(new Uri("http://www.w3.org/2002/07/owl#Ontology"));    

    ///<summary>
    ///The class of ontology properties.
    ///<see cref="http://www.w3.org/2002/07/owl#OntologyProperty"/>
    ///</summary>
    public static readonly Class OntologyProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#OntologyProperty"));    

    ///<summary>
    ///The class of reflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ReflexiveProperty"/>
    ///</summary>
    public static readonly Class ReflexiveProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#ReflexiveProperty"));    

    ///<summary>
    ///The class of property restrictions.
    ///<see cref="http://www.w3.org/2002/07/owl#Restriction"/>
    ///</summary>
    public static readonly Class Restriction = new Class(new Uri("http://www.w3.org/2002/07/owl#Restriction"));    

    ///<summary>
    ///The class of symmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#SymmetricProperty"/>
    ///</summary>
    public static readonly Class SymmetricProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#SymmetricProperty"));    

    ///<summary>
    ///The class of transitive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#TransitiveProperty"/>
    ///</summary>
    public static readonly Class TransitiveProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#TransitiveProperty"));    

    ///<summary>
    ///The class of OWL individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#Thing"/>
    ///</summary>
    public static readonly Class Thing = new Class(new Uri("http://www.w3.org/2002/07/owl#Thing"));    

    ///<summary>
    ///The property that determines the class that a universal property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#allValuesFrom"/>
    ///</summary>
    public static readonly Property allValuesFrom = new Property(new Uri("http://www.w3.org/2002/07/owl#allValuesFrom"));    

    ///<summary>
    ///The property that determines the predicate of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedProperty"/>
    ///</summary>
    public static readonly Property annotatedProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#annotatedProperty"));    

    ///<summary>
    ///The property that determines the subject of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedSource"/>
    ///</summary>
    public static readonly Property annotatedSource = new Property(new Uri("http://www.w3.org/2002/07/owl#annotatedSource"));    

    ///<summary>
    ///The property that determines the object of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedTarget"/>
    ///</summary>
    public static readonly Property annotatedTarget = new Property(new Uri("http://www.w3.org/2002/07/owl#annotatedTarget"));    

    ///<summary>
    ///The property that determines the predicate of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#assertionProperty"/>
    ///</summary>
    public static readonly Property assertionProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#assertionProperty"));    

    ///<summary>
    ///The annotation property that indicates that a given ontology is backward compatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#backwardCompatibleWith"/>
    ///</summary>
    public static readonly Property backwardCompatibleWith = new Property(new Uri("http://www.w3.org/2002/07/owl#backwardCompatibleWith"));    

    ///<summary>
    ///The data property that does not relate any individual to any data value.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomDataProperty"/>
    ///</summary>
    public static readonly Property bottomDataProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#bottomDataProperty"));    

    ///<summary>
    ///The object property that does not relate any two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomObjectProperty"/>
    ///</summary>
    public static readonly Property bottomObjectProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#bottomObjectProperty"));    

    ///<summary>
    ///The property that determines the cardinality of an exact cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#cardinality"/>
    ///</summary>
    public static readonly Property cardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#cardinality"));    

    ///<summary>
    ///The property that determines that a given class is the complement of another class.
    ///<see cref="http://www.w3.org/2002/07/owl#complementOf"/>
    ///</summary>
    public static readonly Property complementOf = new Property(new Uri("http://www.w3.org/2002/07/owl#complementOf"));    

    ///<summary>
    ///The property that determines that a given data range is the complement of another data range with respect to the data domain.
    ///<see cref="http://www.w3.org/2002/07/owl#datatypeComplementOf"/>
    ///</summary>
    public static readonly Property datatypeComplementOf = new Property(new Uri("http://www.w3.org/2002/07/owl#datatypeComplementOf"));    

    ///<summary>
    ///The annotation property that indicates that a given entity has been deprecated.
    ///<see cref="http://www.w3.org/2002/07/owl#deprecated"/>
    ///</summary>
    public static readonly Property deprecated = new Property(new Uri("http://www.w3.org/2002/07/owl#deprecated"));    

    ///<summary>
    ///The property that determines that two given individuals are different.
    ///<see cref="http://www.w3.org/2002/07/owl#differentFrom"/>
    ///</summary>
    public static readonly Property differentFrom = new Property(new Uri("http://www.w3.org/2002/07/owl#differentFrom"));    

    ///<summary>
    ///The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointUnionOf"/>
    ///</summary>
    public static readonly Property disjointUnionOf = new Property(new Uri("http://www.w3.org/2002/07/owl#disjointUnionOf"));    

    ///<summary>
    ///The property that determines that two given classes are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointWith"/>
    ///</summary>
    public static readonly Property disjointWith = new Property(new Uri("http://www.w3.org/2002/07/owl#disjointWith"));    

    ///<summary>
    ///The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#distinctMembers"/>
    ///</summary>
    public static readonly Property distinctMembers = new Property(new Uri("http://www.w3.org/2002/07/owl#distinctMembers"));    

    ///<summary>
    ///The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentClass"/>
    ///</summary>
    public static readonly Property equivalentClass = new Property(new Uri("http://www.w3.org/2002/07/owl#equivalentClass"));    

    ///<summary>
    ///The property that determines that two given properties are equivalent.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentProperty"/>
    ///</summary>
    public static readonly Property equivalentProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#equivalentProperty"));    

    ///<summary>
    ///The property that determines the collection of properties that jointly build a key.
    ///<see cref="http://www.w3.org/2002/07/owl#hasKey"/>
    ///</summary>
    public static readonly Property hasKey = new Property(new Uri("http://www.w3.org/2002/07/owl#hasKey"));    

    ///<summary>
    ///The property that determines the property that a self restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasSelf"/>
    ///</summary>
    public static readonly Property hasSelf = new Property(new Uri("http://www.w3.org/2002/07/owl#hasSelf"));    

    ///<summary>
    ///The property that determines the individual that a has-value restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasValue"/>
    ///</summary>
    public static readonly Property hasValue = new Property(new Uri("http://www.w3.org/2002/07/owl#hasValue"));    

    ///<summary>
    ///The property that is used for importing other ontologies into a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#imports"/>
    ///</summary>
    public static readonly Property imports = new Property(new Uri("http://www.w3.org/2002/07/owl#imports"));    

    ///<summary>
    ///The annotation property that indicates that a given ontology is incompatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#incompatibleWith"/>
    ///</summary>
    public static readonly Property incompatibleWith = new Property(new Uri("http://www.w3.org/2002/07/owl#incompatibleWith"));    

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build an intersection.
    ///<see cref="http://www.w3.org/2002/07/owl#intersectionOf"/>
    ///</summary>
    public static readonly Property intersectionOf = new Property(new Uri("http://www.w3.org/2002/07/owl#intersectionOf"));    

    ///<summary>
    ///The property that determines that two given properties are inverse.
    ///<see cref="http://www.w3.org/2002/07/owl#inverseOf"/>
    ///</summary>
    public static readonly Property inverseOf = new Property(new Uri("http://www.w3.org/2002/07/owl#inverseOf"));    

    ///<summary>
    ///The property that determines the cardinality of a maximum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxCardinality"/>
    ///</summary>
    public static readonly Property maxCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#maxCardinality"));    

    ///<summary>
    ///The property that determines the cardinality of a maximum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxQualifiedCardinality"/>
    ///</summary>
    public static readonly Property maxQualifiedCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#maxQualifiedCardinality"));    

    ///<summary>
    ///The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#members"/>
    ///</summary>
    public static readonly Property members = new Property(new Uri("http://www.w3.org/2002/07/owl#members"));    

    ///<summary>
    ///The property that determines the cardinality of a minimum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minCardinality"/>
    ///</summary>
    public static readonly Property minCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#minCardinality"));    

    ///<summary>
    ///The property that determines the cardinality of a minimum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minQualifiedCardinality"/>
    ///</summary>
    public static readonly Property minQualifiedCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#minQualifiedCardinality"));    

    ///<summary>
    ///The property that determines the class that a qualified object cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onClass"/>
    ///</summary>
    public static readonly Property onClass = new Property(new Uri("http://www.w3.org/2002/07/owl#onClass"));    

    ///<summary>
    ///The property that determines the data range that a qualified data cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDataRange"/>
    ///</summary>
    public static readonly Property onDataRange = new Property(new Uri("http://www.w3.org/2002/07/owl#onDataRange"));    

    ///<summary>
    ///The property that determines the datatype that a datatype restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDatatype"/>
    ///</summary>
    public static readonly Property onDatatype = new Property(new Uri("http://www.w3.org/2002/07/owl#onDatatype"));    

    ///<summary>
    ///The property that determines the collection of individuals or data values that build an enumeration.
    ///<see cref="http://www.w3.org/2002/07/owl#oneOf"/>
    ///</summary>
    public static readonly Property oneOf = new Property(new Uri("http://www.w3.org/2002/07/owl#oneOf"));    

    ///<summary>
    ///The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperties"/>
    ///</summary>
    public static readonly Property onProperties = new Property(new Uri("http://www.w3.org/2002/07/owl#onProperties"));    

    ///<summary>
    ///The property that determines the property that a property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperty"/>
    ///</summary>
    public static readonly Property onProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#onProperty"));    

    ///<summary>
    ///The annotation property that indicates the predecessor ontology of a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#priorVersion"/>
    ///</summary>
    public static readonly Property priorVersion = new Property(new Uri("http://www.w3.org/2002/07/owl#priorVersion"));    

    ///<summary>
    ///The property that determines the n-tuple of properties that build a sub property chain of a given property.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyChainAxiom"/>
    ///</summary>
    public static readonly Property propertyChainAxiom = new Property(new Uri("http://www.w3.org/2002/07/owl#propertyChainAxiom"));    

    ///<summary>
    ///The property that determines that two given properties are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyDisjointWith"/>
    ///</summary>
    public static readonly Property propertyDisjointWith = new Property(new Uri("http://www.w3.org/2002/07/owl#propertyDisjointWith"));    

    ///<summary>
    ///The property that determines the cardinality of an exact qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#qualifiedCardinality"/>
    ///</summary>
    public static readonly Property qualifiedCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#qualifiedCardinality"));    

    ///<summary>
    ///The property that determines that two given individuals are equal.
    ///<see cref="http://www.w3.org/2002/07/owl#sameAs"/>
    ///</summary>
    public static readonly Property sameAs = new Property(new Uri("http://www.w3.org/2002/07/owl#sameAs"));    

    ///<summary>
    ///The property that determines the class that an existential property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#someValuesFrom"/>
    ///</summary>
    public static readonly Property someValuesFrom = new Property(new Uri("http://www.w3.org/2002/07/owl#someValuesFrom"));    

    ///<summary>
    ///The property that determines the subject of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#sourceIndividual"/>
    ///</summary>
    public static readonly Property sourceIndividual = new Property(new Uri("http://www.w3.org/2002/07/owl#sourceIndividual"));    

    ///<summary>
    ///The property that determines the object of a negative object property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetIndividual"/>
    ///</summary>
    public static readonly Property targetIndividual = new Property(new Uri("http://www.w3.org/2002/07/owl#targetIndividual"));    

    ///<summary>
    ///The property that determines the value of a negative data property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetValue"/>
    ///</summary>
    public static readonly Property targetValue = new Property(new Uri("http://www.w3.org/2002/07/owl#targetValue"));    

    ///<summary>
    ///The data property that relates every individual to every data value.
    ///<see cref="http://www.w3.org/2002/07/owl#topDataProperty"/>
    ///</summary>
    public static readonly Property topDataProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#topDataProperty"));    

    ///<summary>
    ///The object property that relates every two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#topObjectProperty"/>
    ///</summary>
    public static readonly Property topObjectProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#topObjectProperty"));    

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build a union.
    ///<see cref="http://www.w3.org/2002/07/owl#unionOf"/>
    ///</summary>
    public static readonly Property unionOf = new Property(new Uri("http://www.w3.org/2002/07/owl#unionOf"));    

    ///<summary>
    ///The annotation property that provides version information for an ontology or another OWL construct.
    ///<see cref="http://www.w3.org/2002/07/owl#versionInfo"/>
    ///</summary>
    public static readonly Property versionInfo = new Property(new Uri("http://www.w3.org/2002/07/owl#versionInfo"));    

    ///<summary>
    ///The property that identifies the version IRI of an ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#versionIRI"/>
    ///</summary>
    public static readonly Property versionIRI = new Property(new Uri("http://www.w3.org/2002/07/owl#versionIRI"));    

    ///<summary>
    ///The property that determines the collection of facet-value pairs that define a datatype restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#withRestrictions"/>
    ///</summary>
    public static readonly Property withRestrictions = new Property(new Uri("http://www.w3.org/2002/07/owl#withRestrictions"));
}
///<summary>
///The OWL 2 Schema vocabulary (OWL 2)
///
///</summary>
public static class OWL
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2002/07/owl#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "OWL";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///  This ontology partially describes the built-in classes and
    ///  properties that together form the basis of the RDF/XML syntax of OWL 2.
    ///  The content of this ontology is based on Tables 6.1 and 6.2
    ///  in Section 6.4 of the OWL 2 RDF-Based Semantics specification,
    ///  available at http://www.w3.org/TR/owl2-rdf-based-semantics/.
    ///  Please note that those tables do not include the different annotations
    ///  (labels, comments and rdfs:isDefinedBy links) used in this file.
    ///  Also note that the descriptions provided in this ontology do not
    ///  provide a complete and correct formal description of either the syntax
    ///  or the semantics of the introduced terms (please see the OWL 2
    ///  recommendations for the complete and normative specifications).
    ///  Furthermore, the information provided by this ontology may be
    ///  misleading if not used with care. This ontology SHOULD NOT be imported
    ///  into OWL ontologies. Importing this file into an OWL 2 DL ontology
    ///  will cause it to become an OWL 2 Full ontology and may have other,
    ///  unexpected, consequences.
    ///   
    ///<see cref="http://www.w3.org/2002/07/owl"/>
    ///</summary>
    public const string owl_0 = "http://www.w3.org/2002/07/owl";

    ///<summary>
    ///The class of collections of pairwise different individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDifferent"/>
    ///</summary>
    public const string AllDifferent = "http://www.w3.org/2002/07/owl#AllDifferent";

    ///<summary>
    ///The class of collections of pairwise disjoint classes.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointClasses"/>
    ///</summary>
    public const string AllDisjointClasses = "http://www.w3.org/2002/07/owl#AllDisjointClasses";

    ///<summary>
    ///The class of collections of pairwise disjoint properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointProperties"/>
    ///</summary>
    public const string AllDisjointProperties = "http://www.w3.org/2002/07/owl#AllDisjointProperties";

    ///<summary>
    ///The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Annotation"/>
    ///</summary>
    public const string Annotation = "http://www.w3.org/2002/07/owl#Annotation";

    ///<summary>
    ///The class of annotation properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AnnotationProperty"/>
    ///</summary>
    public const string AnnotationProperty = "http://www.w3.org/2002/07/owl#AnnotationProperty";

    ///<summary>
    ///The class of asymmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AsymmetricProperty"/>
    ///</summary>
    public const string AsymmetricProperty = "http://www.w3.org/2002/07/owl#AsymmetricProperty";

    ///<summary>
    ///The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Axiom"/>
    ///</summary>
    public const string Axiom = "http://www.w3.org/2002/07/owl#Axiom";

    ///<summary>
    ///The class of OWL classes.
    ///<see cref="http://www.w3.org/2002/07/owl#Class"/>
    ///</summary>
    public const string Class = "http://www.w3.org/2002/07/owl#Class";

    ///<summary>
    ///The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    ///<see cref="http://www.w3.org/2002/07/owl#DataRange"/>
    ///</summary>
    public const string DataRange = "http://www.w3.org/2002/07/owl#DataRange";

    ///<summary>
    ///The class of data properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DatatypeProperty"/>
    ///</summary>
    public const string DatatypeProperty = "http://www.w3.org/2002/07/owl#DatatypeProperty";

    ///<summary>
    ///The class of deprecated classes.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedClass"/>
    ///</summary>
    public const string DeprecatedClass = "http://www.w3.org/2002/07/owl#DeprecatedClass";

    ///<summary>
    ///The class of deprecated properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedProperty"/>
    ///</summary>
    public const string DeprecatedProperty = "http://www.w3.org/2002/07/owl#DeprecatedProperty";

    ///<summary>
    ///The class of functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#FunctionalProperty"/>
    ///</summary>
    public const string FunctionalProperty = "http://www.w3.org/2002/07/owl#FunctionalProperty";

    ///<summary>
    ///The class of inverse-functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#InverseFunctionalProperty"/>
    ///</summary>
    public const string InverseFunctionalProperty = "http://www.w3.org/2002/07/owl#InverseFunctionalProperty";

    ///<summary>
    ///The class of irreflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#IrreflexiveProperty"/>
    ///</summary>
    public const string IrreflexiveProperty = "http://www.w3.org/2002/07/owl#IrreflexiveProperty";

    ///<summary>
    ///The class of named individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#NamedIndividual"/>
    ///</summary>
    public const string NamedIndividual = "http://www.w3.org/2002/07/owl#NamedIndividual";

    ///<summary>
    ///The class of negative property assertions.
    ///<see cref="http://www.w3.org/2002/07/owl#NegativePropertyAssertion"/>
    ///</summary>
    public const string NegativePropertyAssertion = "http://www.w3.org/2002/07/owl#NegativePropertyAssertion";

    ///<summary>
    ///This is the empty class.
    ///<see cref="http://www.w3.org/2002/07/owl#Nothing"/>
    ///</summary>
    public const string Nothing = "http://www.w3.org/2002/07/owl#Nothing";

    ///<summary>
    ///The class of object properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ObjectProperty"/>
    ///</summary>
    public const string ObjectProperty = "http://www.w3.org/2002/07/owl#ObjectProperty";

    ///<summary>
    ///The class of ontologies.
    ///<see cref="http://www.w3.org/2002/07/owl#Ontology"/>
    ///</summary>
    public const string Ontology = "http://www.w3.org/2002/07/owl#Ontology";

    ///<summary>
    ///The class of ontology properties.
    ///<see cref="http://www.w3.org/2002/07/owl#OntologyProperty"/>
    ///</summary>
    public const string OntologyProperty = "http://www.w3.org/2002/07/owl#OntologyProperty";

    ///<summary>
    ///The class of reflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ReflexiveProperty"/>
    ///</summary>
    public const string ReflexiveProperty = "http://www.w3.org/2002/07/owl#ReflexiveProperty";

    ///<summary>
    ///The class of property restrictions.
    ///<see cref="http://www.w3.org/2002/07/owl#Restriction"/>
    ///</summary>
    public const string Restriction = "http://www.w3.org/2002/07/owl#Restriction";

    ///<summary>
    ///The class of symmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#SymmetricProperty"/>
    ///</summary>
    public const string SymmetricProperty = "http://www.w3.org/2002/07/owl#SymmetricProperty";

    ///<summary>
    ///The class of transitive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#TransitiveProperty"/>
    ///</summary>
    public const string TransitiveProperty = "http://www.w3.org/2002/07/owl#TransitiveProperty";

    ///<summary>
    ///The class of OWL individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#Thing"/>
    ///</summary>
    public const string Thing = "http://www.w3.org/2002/07/owl#Thing";

    ///<summary>
    ///The property that determines the class that a universal property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#allValuesFrom"/>
    ///</summary>
    public const string allValuesFrom = "http://www.w3.org/2002/07/owl#allValuesFrom";

    ///<summary>
    ///The property that determines the predicate of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedProperty"/>
    ///</summary>
    public const string annotatedProperty = "http://www.w3.org/2002/07/owl#annotatedProperty";

    ///<summary>
    ///The property that determines the subject of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedSource"/>
    ///</summary>
    public const string annotatedSource = "http://www.w3.org/2002/07/owl#annotatedSource";

    ///<summary>
    ///The property that determines the object of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedTarget"/>
    ///</summary>
    public const string annotatedTarget = "http://www.w3.org/2002/07/owl#annotatedTarget";

    ///<summary>
    ///The property that determines the predicate of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#assertionProperty"/>
    ///</summary>
    public const string assertionProperty = "http://www.w3.org/2002/07/owl#assertionProperty";

    ///<summary>
    ///The annotation property that indicates that a given ontology is backward compatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#backwardCompatibleWith"/>
    ///</summary>
    public const string backwardCompatibleWith = "http://www.w3.org/2002/07/owl#backwardCompatibleWith";

    ///<summary>
    ///The data property that does not relate any individual to any data value.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomDataProperty"/>
    ///</summary>
    public const string bottomDataProperty = "http://www.w3.org/2002/07/owl#bottomDataProperty";

    ///<summary>
    ///The object property that does not relate any two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomObjectProperty"/>
    ///</summary>
    public const string bottomObjectProperty = "http://www.w3.org/2002/07/owl#bottomObjectProperty";

    ///<summary>
    ///The property that determines the cardinality of an exact cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#cardinality"/>
    ///</summary>
    public const string cardinality = "http://www.w3.org/2002/07/owl#cardinality";

    ///<summary>
    ///The property that determines that a given class is the complement of another class.
    ///<see cref="http://www.w3.org/2002/07/owl#complementOf"/>
    ///</summary>
    public const string complementOf = "http://www.w3.org/2002/07/owl#complementOf";

    ///<summary>
    ///The property that determines that a given data range is the complement of another data range with respect to the data domain.
    ///<see cref="http://www.w3.org/2002/07/owl#datatypeComplementOf"/>
    ///</summary>
    public const string datatypeComplementOf = "http://www.w3.org/2002/07/owl#datatypeComplementOf";

    ///<summary>
    ///The annotation property that indicates that a given entity has been deprecated.
    ///<see cref="http://www.w3.org/2002/07/owl#deprecated"/>
    ///</summary>
    public const string deprecated = "http://www.w3.org/2002/07/owl#deprecated";

    ///<summary>
    ///The property that determines that two given individuals are different.
    ///<see cref="http://www.w3.org/2002/07/owl#differentFrom"/>
    ///</summary>
    public const string differentFrom = "http://www.w3.org/2002/07/owl#differentFrom";

    ///<summary>
    ///The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointUnionOf"/>
    ///</summary>
    public const string disjointUnionOf = "http://www.w3.org/2002/07/owl#disjointUnionOf";

    ///<summary>
    ///The property that determines that two given classes are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointWith"/>
    ///</summary>
    public const string disjointWith = "http://www.w3.org/2002/07/owl#disjointWith";

    ///<summary>
    ///The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#distinctMembers"/>
    ///</summary>
    public const string distinctMembers = "http://www.w3.org/2002/07/owl#distinctMembers";

    ///<summary>
    ///The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentClass"/>
    ///</summary>
    public const string equivalentClass = "http://www.w3.org/2002/07/owl#equivalentClass";

    ///<summary>
    ///The property that determines that two given properties are equivalent.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentProperty"/>
    ///</summary>
    public const string equivalentProperty = "http://www.w3.org/2002/07/owl#equivalentProperty";

    ///<summary>
    ///The property that determines the collection of properties that jointly build a key.
    ///<see cref="http://www.w3.org/2002/07/owl#hasKey"/>
    ///</summary>
    public const string hasKey = "http://www.w3.org/2002/07/owl#hasKey";

    ///<summary>
    ///The property that determines the property that a self restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasSelf"/>
    ///</summary>
    public const string hasSelf = "http://www.w3.org/2002/07/owl#hasSelf";

    ///<summary>
    ///The property that determines the individual that a has-value restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasValue"/>
    ///</summary>
    public const string hasValue = "http://www.w3.org/2002/07/owl#hasValue";

    ///<summary>
    ///The property that is used for importing other ontologies into a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#imports"/>
    ///</summary>
    public const string imports = "http://www.w3.org/2002/07/owl#imports";

    ///<summary>
    ///The annotation property that indicates that a given ontology is incompatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#incompatibleWith"/>
    ///</summary>
    public const string incompatibleWith = "http://www.w3.org/2002/07/owl#incompatibleWith";

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build an intersection.
    ///<see cref="http://www.w3.org/2002/07/owl#intersectionOf"/>
    ///</summary>
    public const string intersectionOf = "http://www.w3.org/2002/07/owl#intersectionOf";

    ///<summary>
    ///The property that determines that two given properties are inverse.
    ///<see cref="http://www.w3.org/2002/07/owl#inverseOf"/>
    ///</summary>
    public const string inverseOf = "http://www.w3.org/2002/07/owl#inverseOf";

    ///<summary>
    ///The property that determines the cardinality of a maximum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxCardinality"/>
    ///</summary>
    public const string maxCardinality = "http://www.w3.org/2002/07/owl#maxCardinality";

    ///<summary>
    ///The property that determines the cardinality of a maximum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxQualifiedCardinality"/>
    ///</summary>
    public const string maxQualifiedCardinality = "http://www.w3.org/2002/07/owl#maxQualifiedCardinality";

    ///<summary>
    ///The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#members"/>
    ///</summary>
    public const string members = "http://www.w3.org/2002/07/owl#members";

    ///<summary>
    ///The property that determines the cardinality of a minimum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minCardinality"/>
    ///</summary>
    public const string minCardinality = "http://www.w3.org/2002/07/owl#minCardinality";

    ///<summary>
    ///The property that determines the cardinality of a minimum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minQualifiedCardinality"/>
    ///</summary>
    public const string minQualifiedCardinality = "http://www.w3.org/2002/07/owl#minQualifiedCardinality";

    ///<summary>
    ///The property that determines the class that a qualified object cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onClass"/>
    ///</summary>
    public const string onClass = "http://www.w3.org/2002/07/owl#onClass";

    ///<summary>
    ///The property that determines the data range that a qualified data cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDataRange"/>
    ///</summary>
    public const string onDataRange = "http://www.w3.org/2002/07/owl#onDataRange";

    ///<summary>
    ///The property that determines the datatype that a datatype restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDatatype"/>
    ///</summary>
    public const string onDatatype = "http://www.w3.org/2002/07/owl#onDatatype";

    ///<summary>
    ///The property that determines the collection of individuals or data values that build an enumeration.
    ///<see cref="http://www.w3.org/2002/07/owl#oneOf"/>
    ///</summary>
    public const string oneOf = "http://www.w3.org/2002/07/owl#oneOf";

    ///<summary>
    ///The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperties"/>
    ///</summary>
    public const string onProperties = "http://www.w3.org/2002/07/owl#onProperties";

    ///<summary>
    ///The property that determines the property that a property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperty"/>
    ///</summary>
    public const string onProperty = "http://www.w3.org/2002/07/owl#onProperty";

    ///<summary>
    ///The annotation property that indicates the predecessor ontology of a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#priorVersion"/>
    ///</summary>
    public const string priorVersion = "http://www.w3.org/2002/07/owl#priorVersion";

    ///<summary>
    ///The property that determines the n-tuple of properties that build a sub property chain of a given property.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyChainAxiom"/>
    ///</summary>
    public const string propertyChainAxiom = "http://www.w3.org/2002/07/owl#propertyChainAxiom";

    ///<summary>
    ///The property that determines that two given properties are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyDisjointWith"/>
    ///</summary>
    public const string propertyDisjointWith = "http://www.w3.org/2002/07/owl#propertyDisjointWith";

    ///<summary>
    ///The property that determines the cardinality of an exact qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#qualifiedCardinality"/>
    ///</summary>
    public const string qualifiedCardinality = "http://www.w3.org/2002/07/owl#qualifiedCardinality";

    ///<summary>
    ///The property that determines that two given individuals are equal.
    ///<see cref="http://www.w3.org/2002/07/owl#sameAs"/>
    ///</summary>
    public const string sameAs = "http://www.w3.org/2002/07/owl#sameAs";

    ///<summary>
    ///The property that determines the class that an existential property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#someValuesFrom"/>
    ///</summary>
    public const string someValuesFrom = "http://www.w3.org/2002/07/owl#someValuesFrom";

    ///<summary>
    ///The property that determines the subject of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#sourceIndividual"/>
    ///</summary>
    public const string sourceIndividual = "http://www.w3.org/2002/07/owl#sourceIndividual";

    ///<summary>
    ///The property that determines the object of a negative object property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetIndividual"/>
    ///</summary>
    public const string targetIndividual = "http://www.w3.org/2002/07/owl#targetIndividual";

    ///<summary>
    ///The property that determines the value of a negative data property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetValue"/>
    ///</summary>
    public const string targetValue = "http://www.w3.org/2002/07/owl#targetValue";

    ///<summary>
    ///The data property that relates every individual to every data value.
    ///<see cref="http://www.w3.org/2002/07/owl#topDataProperty"/>
    ///</summary>
    public const string topDataProperty = "http://www.w3.org/2002/07/owl#topDataProperty";

    ///<summary>
    ///The object property that relates every two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#topObjectProperty"/>
    ///</summary>
    public const string topObjectProperty = "http://www.w3.org/2002/07/owl#topObjectProperty";

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build a union.
    ///<see cref="http://www.w3.org/2002/07/owl#unionOf"/>
    ///</summary>
    public const string unionOf = "http://www.w3.org/2002/07/owl#unionOf";

    ///<summary>
    ///The annotation property that provides version information for an ontology or another OWL construct.
    ///<see cref="http://www.w3.org/2002/07/owl#versionInfo"/>
    ///</summary>
    public const string versionInfo = "http://www.w3.org/2002/07/owl#versionInfo";

    ///<summary>
    ///The property that identifies the version IRI of an ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#versionIRI"/>
    ///</summary>
    public const string versionIRI = "http://www.w3.org/2002/07/owl#versionIRI";

    ///<summary>
    ///The property that determines the collection of facet-value pairs that define a datatype restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#withRestrictions"/>
    ///</summary>
    public const string withRestrictions = "http://www.w3.org/2002/07/owl#withRestrictions";
}
///<summary>
///Friend of a Friend (FOAF) vocabulary
///
///</summary>
public class foaf : Ontology
{
    public static readonly Uri Namespace = new Uri("http://xmlns.com/foaf/0.1/");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "foaf";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://xmlns.com/foaf/0.1/"/>
    ///</summary>
    public static readonly Resource _0_1 = new Resource(new Uri("http://xmlns.com/foaf/0.1/"));    

    ///<summary>
    ///
    ///<see cref="http://xmlns.com/wot/0.1/assurance"/>
    ///</summary>
    public static readonly Property assurance = new Property(new Uri("http://xmlns.com/wot/0.1/assurance"));    

    ///<summary>
    ///
    ///<see cref="http://xmlns.com/wot/0.1/src_assurance"/>
    ///</summary>
    public static readonly Property src_assurance = new Property(new Uri("http://xmlns.com/wot/0.1/src_assurance"));    

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status"/>
    ///</summary>
    public static readonly Property term_status = new Property(new Uri("http://www.w3.org/2003/06/sw-vocab-status/ns#term_status"));    

    ///<summary>
    ///
    ///<see cref="http://purl.org/dc/elements/1.1/description"/>
    ///</summary>
    public static readonly Property description = new Property(new Uri("http://purl.org/dc/elements/1.1/description"));    

    ///<summary>
    ///
    ///<see cref="http://purl.org/dc/elements/1.1/title"/>
    ///</summary>
    public static readonly Property title = new Property(new Uri("http://purl.org/dc/elements/1.1/title"));    

    ///<summary>
    ///
    ///<see cref="http://purl.org/dc/elements/1.1/date"/>
    ///</summary>
    public static readonly Property date = new Property(new Uri("http://purl.org/dc/elements/1.1/date"));    

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public static readonly Class Class = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Class"));    

    ///<summary>
    ///A foaf:LabelProperty is any RDF property with texual values that serve as labels.
    ///<see cref="http://xmlns.com/foaf/0.1/LabelProperty"/>
    ///</summary>
    public static readonly Class LabelProperty = new Class(new Uri("http://xmlns.com/foaf/0.1/LabelProperty"));    

    ///<summary>
    ///A person.
    ///<see cref="http://xmlns.com/foaf/0.1/Person"/>
    ///</summary>
    public static readonly Class Person = new Class(new Uri("http://xmlns.com/foaf/0.1/Person"));    

    ///<summary>
    ///An agent (eg. person, group, software or physical artifact).
    ///<see cref="http://xmlns.com/foaf/0.1/Agent"/>
    ///</summary>
    public static readonly Class Agent = new Class(new Uri("http://xmlns.com/foaf/0.1/Agent"));    

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing"/>
    ///</summary>
    public static readonly Class SpatialThing = new Class(new Uri("http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing"));    

    ///<summary>
    ///A document.
    ///<see cref="http://xmlns.com/foaf/0.1/Document"/>
    ///</summary>
    public static readonly Class Document = new Class(new Uri("http://xmlns.com/foaf/0.1/Document"));    

    ///<summary>
    ///An organization.
    ///<see cref="http://xmlns.com/foaf/0.1/Organization"/>
    ///</summary>
    public static readonly Class Organization = new Class(new Uri("http://xmlns.com/foaf/0.1/Organization"));    

    ///<summary>
    ///A class of Agents.
    ///<see cref="http://xmlns.com/foaf/0.1/Group"/>
    ///</summary>
    public static readonly Class Group = new Class(new Uri("http://xmlns.com/foaf/0.1/Group"));    

    ///<summary>
    ///A project (a collective endeavour of some kind).
    ///<see cref="http://xmlns.com/foaf/0.1/Project"/>
    ///</summary>
    public static readonly Class Project = new Class(new Uri("http://xmlns.com/foaf/0.1/Project"));    

    ///<summary>
    ///An image.
    ///<see cref="http://xmlns.com/foaf/0.1/Image"/>
    ///</summary>
    public static readonly Class Image = new Class(new Uri("http://xmlns.com/foaf/0.1/Image"));    

    ///<summary>
    ///A personal profile RDF document.
    ///<see cref="http://xmlns.com/foaf/0.1/PersonalProfileDocument"/>
    ///</summary>
    public static readonly Class PersonalProfileDocument = new Class(new Uri("http://xmlns.com/foaf/0.1/PersonalProfileDocument"));    

    ///<summary>
    ///An online account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineAccount"/>
    ///</summary>
    public static readonly Class OnlineAccount = new Class(new Uri("http://xmlns.com/foaf/0.1/OnlineAccount"));    

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2002/07/owl#Thing"/>
    ///</summary>
    public static readonly Resource Thing = new Resource(new Uri("http://www.w3.org/2002/07/owl#Thing"));    

    ///<summary>
    ///An online gaming account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineGamingAccount"/>
    ///</summary>
    public static readonly Class OnlineGamingAccount = new Class(new Uri("http://xmlns.com/foaf/0.1/OnlineGamingAccount"));    

    ///<summary>
    ///An online e-commerce account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount"/>
    ///</summary>
    public static readonly Class OnlineEcommerceAccount = new Class(new Uri("http://xmlns.com/foaf/0.1/OnlineEcommerceAccount"));    

    ///<summary>
    ///An online chat account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineChatAccount"/>
    ///</summary>
    public static readonly Class OnlineChatAccount = new Class(new Uri("http://xmlns.com/foaf/0.1/OnlineChatAccount"));    

    ///<summary>
    ///A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.
    ///<see cref="http://xmlns.com/foaf/0.1/mbox"/>
    ///</summary>
    public static readonly Property mbox = new Property(new Uri("http://xmlns.com/foaf/0.1/mbox"));    

    ///<summary>
    ///The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.
    ///<see cref="http://xmlns.com/foaf/0.1/mbox_sha1sum"/>
    ///</summary>
    public static readonly Property mbox_sha1sum = new Property(new Uri("http://xmlns.com/foaf/0.1/mbox_sha1sum"));    

    ///<summary>
    ///The gender of this Agent (typically but not necessarily 'male' or 'female').
    ///<see cref="http://xmlns.com/foaf/0.1/gender"/>
    ///</summary>
    public static readonly Property gender = new Property(new Uri("http://xmlns.com/foaf/0.1/gender"));    

    ///<summary>
    ///A textual geekcode for this person, see http://www.geekcode.com/geek.html
    ///<see cref="http://xmlns.com/foaf/0.1/geekcode"/>
    ///</summary>
    public static readonly Property geekcode = new Property(new Uri("http://xmlns.com/foaf/0.1/geekcode"));    

    ///<summary>
    ///A checksum for the DNA of some thing. Joke.
    ///<see cref="http://xmlns.com/foaf/0.1/dnaChecksum"/>
    ///</summary>
    public static readonly Property dnaChecksum = new Property(new Uri("http://xmlns.com/foaf/0.1/dnaChecksum"));    

    ///<summary>
    ///A sha1sum hash, in hex.
    ///<see cref="http://xmlns.com/foaf/0.1/sha1"/>
    ///</summary>
    public static readonly Property sha1 = new Property(new Uri("http://xmlns.com/foaf/0.1/sha1"));    

    ///<summary>
    ///A location that something is based near, for some broadly human notion of near.
    ///<see cref="http://xmlns.com/foaf/0.1/based_near"/>
    ///</summary>
    public static readonly Property based_near = new Property(new Uri("http://xmlns.com/foaf/0.1/based_near"));    

    ///<summary>
    ///Title (Mr, Mrs, Ms, Dr. etc)
    ///<see cref="http://xmlns.com/foaf/0.1/title"/>
    ///</summary>
    public static readonly Property title_0 = new Property(new Uri("http://xmlns.com/foaf/0.1/title"));    

    ///<summary>
    ///A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).
    ///<see cref="http://xmlns.com/foaf/0.1/nick"/>
    ///</summary>
    public static readonly Property nick = new Property(new Uri("http://xmlns.com/foaf/0.1/nick"));    

    ///<summary>
    ///A jabber ID for something.
    ///<see cref="http://xmlns.com/foaf/0.1/jabberID"/>
    ///</summary>
    public static readonly Property jabberID = new Property(new Uri("http://xmlns.com/foaf/0.1/jabberID"));    

    ///<summary>
    ///An AIM chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/aimChatID"/>
    ///</summary>
    public static readonly Property aimChatID = new Property(new Uri("http://xmlns.com/foaf/0.1/aimChatID"));    

    ///<summary>
    ///A Skype ID
    ///<see cref="http://xmlns.com/foaf/0.1/skypeID"/>
    ///</summary>
    public static readonly Property skypeID = new Property(new Uri("http://xmlns.com/foaf/0.1/skypeID"));    

    ///<summary>
    ///An ICQ chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/icqChatID"/>
    ///</summary>
    public static readonly Property icqChatID = new Property(new Uri("http://xmlns.com/foaf/0.1/icqChatID"));    

    ///<summary>
    ///A Yahoo chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/yahooChatID"/>
    ///</summary>
    public static readonly Property yahooChatID = new Property(new Uri("http://xmlns.com/foaf/0.1/yahooChatID"));    

    ///<summary>
    ///An MSN chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/msnChatID"/>
    ///</summary>
    public static readonly Property msnChatID = new Property(new Uri("http://xmlns.com/foaf/0.1/msnChatID"));    

    ///<summary>
    ///A name for some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/name"/>
    ///</summary>
    public static readonly Property name = new Property(new Uri("http://xmlns.com/foaf/0.1/name"));    

    ///<summary>
    ///The first name of a person.
    ///<see cref="http://xmlns.com/foaf/0.1/firstName"/>
    ///</summary>
    public static readonly Property firstName = new Property(new Uri("http://xmlns.com/foaf/0.1/firstName"));    

    ///<summary>
    ///The last name of a person.
    ///<see cref="http://xmlns.com/foaf/0.1/lastName"/>
    ///</summary>
    public static readonly Property lastName = new Property(new Uri("http://xmlns.com/foaf/0.1/lastName"));    

    ///<summary>
    ///The given name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/givenName"/>
    ///</summary>
    public static readonly Property givenName = new Property(new Uri("http://xmlns.com/foaf/0.1/givenName"));    

    ///<summary>
    ///The given name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/givenname"/>
    ///</summary>
    public static readonly Property givenname = new Property(new Uri("http://xmlns.com/foaf/0.1/givenname"));    

    ///<summary>
    ///The surname of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/surname"/>
    ///</summary>
    public static readonly Property surname = new Property(new Uri("http://xmlns.com/foaf/0.1/surname"));    

    ///<summary>
    ///The family name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/family_name"/>
    ///</summary>
    public static readonly Property family_name = new Property(new Uri("http://xmlns.com/foaf/0.1/family_name"));    

    ///<summary>
    ///The family name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/familyName"/>
    ///</summary>
    public static readonly Property familyName = new Property(new Uri("http://xmlns.com/foaf/0.1/familyName"));    

    ///<summary>
    ///A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).
    ///<see cref="http://xmlns.com/foaf/0.1/phone"/>
    ///</summary>
    public static readonly Property phone = new Property(new Uri("http://xmlns.com/foaf/0.1/phone"));    

    ///<summary>
    ///A homepage for some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/homepage"/>
    ///</summary>
    public static readonly Property homepage = new Property(new Uri("http://xmlns.com/foaf/0.1/homepage"));    

    ///<summary>
    ///A weblog of some thing (whether person, group, company etc.).
    ///<see cref="http://xmlns.com/foaf/0.1/weblog"/>
    ///</summary>
    public static readonly Property weblog = new Property(new Uri("http://xmlns.com/foaf/0.1/weblog"));    

    ///<summary>
    ///An OpenID for an Agent.
    ///<see cref="http://xmlns.com/foaf/0.1/openid"/>
    ///</summary>
    public static readonly Property openid = new Property(new Uri("http://xmlns.com/foaf/0.1/openid"));    

    ///<summary>
    ///A tipjar document for this agent, describing means for payment and reward.
    ///<see cref="http://xmlns.com/foaf/0.1/tipjar"/>
    ///</summary>
    public static readonly Property tipjar = new Property(new Uri("http://xmlns.com/foaf/0.1/tipjar"));    

    ///<summary>
    ///A .plan comment, in the tradition of finger and '.plan' files.
    ///<see cref="http://xmlns.com/foaf/0.1/plan"/>
    ///</summary>
    public static readonly Property plan = new Property(new Uri("http://xmlns.com/foaf/0.1/plan"));    

    ///<summary>
    ///Something that was made by this agent.
    ///<see cref="http://xmlns.com/foaf/0.1/made"/>
    ///</summary>
    public static readonly Property made = new Property(new Uri("http://xmlns.com/foaf/0.1/made"));    

    ///<summary>
    ///An agent that  made this thing.
    ///<see cref="http://xmlns.com/foaf/0.1/maker"/>
    ///</summary>
    public static readonly Property maker = new Property(new Uri("http://xmlns.com/foaf/0.1/maker"));    

    ///<summary>
    ///An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).
    ///<see cref="http://xmlns.com/foaf/0.1/img"/>
    ///</summary>
    public static readonly Property img = new Property(new Uri("http://xmlns.com/foaf/0.1/img"));    

    ///<summary>
    ///A depiction of some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/depiction"/>
    ///</summary>
    public static readonly Property depiction = new Property(new Uri("http://xmlns.com/foaf/0.1/depiction"));    

    ///<summary>
    ///A thing depicted in this representation.
    ///<see cref="http://xmlns.com/foaf/0.1/depicts"/>
    ///</summary>
    public static readonly Property depicts = new Property(new Uri("http://xmlns.com/foaf/0.1/depicts"));    

    ///<summary>
    ///A derived thumbnail image.
    ///<see cref="http://xmlns.com/foaf/0.1/thumbnail"/>
    ///</summary>
    public static readonly Property thumbnail = new Property(new Uri("http://xmlns.com/foaf/0.1/thumbnail"));    

    ///<summary>
    ///A Myers Briggs (MBTI) personality classification.
    ///<see cref="http://xmlns.com/foaf/0.1/myersBriggs"/>
    ///</summary>
    public static readonly Property myersBriggs = new Property(new Uri("http://xmlns.com/foaf/0.1/myersBriggs"));    

    ///<summary>
    ///A workplace homepage of some person; the homepage of an organization they work for.
    ///<see cref="http://xmlns.com/foaf/0.1/workplaceHomepage"/>
    ///</summary>
    public static readonly Property workplaceHomepage = new Property(new Uri("http://xmlns.com/foaf/0.1/workplaceHomepage"));    

    ///<summary>
    ///A work info homepage of some person; a page about their work for some organization.
    ///<see cref="http://xmlns.com/foaf/0.1/workInfoHomepage"/>
    ///</summary>
    public static readonly Property workInfoHomepage = new Property(new Uri("http://xmlns.com/foaf/0.1/workInfoHomepage"));    

    ///<summary>
    ///A homepage of a school attended by the person.
    ///<see cref="http://xmlns.com/foaf/0.1/schoolHomepage"/>
    ///</summary>
    public static readonly Property schoolHomepage = new Property(new Uri("http://xmlns.com/foaf/0.1/schoolHomepage"));    

    ///<summary>
    ///A person known by this person (indicating some level of reciprocated interaction between the parties).
    ///<see cref="http://xmlns.com/foaf/0.1/knows"/>
    ///</summary>
    public static readonly Property knows = new Property(new Uri("http://xmlns.com/foaf/0.1/knows"));    

    ///<summary>
    ///A page about a topic of interest to this person.
    ///<see cref="http://xmlns.com/foaf/0.1/interest"/>
    ///</summary>
    public static readonly Property interest = new Property(new Uri("http://xmlns.com/foaf/0.1/interest"));    

    ///<summary>
    ///A thing of interest to this person.
    ///<see cref="http://xmlns.com/foaf/0.1/topic_interest"/>
    ///</summary>
    public static readonly Property topic_interest = new Property(new Uri("http://xmlns.com/foaf/0.1/topic_interest"));    

    ///<summary>
    ///A link to the publications of this person.
    ///<see cref="http://xmlns.com/foaf/0.1/publications"/>
    ///</summary>
    public static readonly Property publications = new Property(new Uri("http://xmlns.com/foaf/0.1/publications"));    

    ///<summary>
    ///A current project this person works on.
    ///<see cref="http://xmlns.com/foaf/0.1/currentProject"/>
    ///</summary>
    public static readonly Property currentProject = new Property(new Uri("http://xmlns.com/foaf/0.1/currentProject"));    

    ///<summary>
    ///A project this person has previously worked on.
    ///<see cref="http://xmlns.com/foaf/0.1/pastProject"/>
    ///</summary>
    public static readonly Property pastProject = new Property(new Uri("http://xmlns.com/foaf/0.1/pastProject"));    

    ///<summary>
    ///An organization funding a project or person.
    ///<see cref="http://xmlns.com/foaf/0.1/fundedBy"/>
    ///</summary>
    public static readonly Property fundedBy = new Property(new Uri("http://xmlns.com/foaf/0.1/fundedBy"));    

    ///<summary>
    ///A logo representing some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/logo"/>
    ///</summary>
    public static readonly Property logo = new Property(new Uri("http://xmlns.com/foaf/0.1/logo"));    

    ///<summary>
    ///A topic of some page or document.
    ///<see cref="http://xmlns.com/foaf/0.1/topic"/>
    ///</summary>
    public static readonly Property topic = new Property(new Uri("http://xmlns.com/foaf/0.1/topic"));    

    ///<summary>
    ///The primary topic of some page or document.
    ///<see cref="http://xmlns.com/foaf/0.1/primaryTopic"/>
    ///</summary>
    public static readonly Property primaryTopic = new Property(new Uri("http://xmlns.com/foaf/0.1/primaryTopic"));    

    ///<summary>
    ///The underlying or 'focal' entity associated with some SKOS-described concept.
    ///<see cref="http://xmlns.com/foaf/0.1/focus"/>
    ///</summary>
    public static readonly Property focus = new Property(new Uri("http://xmlns.com/foaf/0.1/focus"));    

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2004/02/skos/core#Concept"/>
    ///</summary>
    public static readonly Resource Concept = new Resource(new Uri("http://www.w3.org/2004/02/skos/core#Concept"));    

    ///<summary>
    ///A document that this thing is the primary topic of.
    ///<see cref="http://xmlns.com/foaf/0.1/isPrimaryTopicOf"/>
    ///</summary>
    public static readonly Property isPrimaryTopicOf = new Property(new Uri("http://xmlns.com/foaf/0.1/isPrimaryTopicOf"));    

    ///<summary>
    ///A page or document about this thing.
    ///<see cref="http://xmlns.com/foaf/0.1/page"/>
    ///</summary>
    public static readonly Property page = new Property(new Uri("http://xmlns.com/foaf/0.1/page"));    

    ///<summary>
    ///A theme.
    ///<see cref="http://xmlns.com/foaf/0.1/theme"/>
    ///</summary>
    public static readonly Property theme = new Property(new Uri("http://xmlns.com/foaf/0.1/theme"));    

    ///<summary>
    ///Indicates an account held by this agent.
    ///<see cref="http://xmlns.com/foaf/0.1/account"/>
    ///</summary>
    public static readonly Property account = new Property(new Uri("http://xmlns.com/foaf/0.1/account"));    

    ///<summary>
    ///Indicates an account held by this agent.
    ///<see cref="http://xmlns.com/foaf/0.1/holdsAccount"/>
    ///</summary>
    public static readonly Property holdsAccount = new Property(new Uri("http://xmlns.com/foaf/0.1/holdsAccount"));    

    ///<summary>
    ///Indicates a homepage of the service provide for this online account.
    ///<see cref="http://xmlns.com/foaf/0.1/accountServiceHomepage"/>
    ///</summary>
    public static readonly Property accountServiceHomepage = new Property(new Uri("http://xmlns.com/foaf/0.1/accountServiceHomepage"));    

    ///<summary>
    ///Indicates the name (identifier) associated with this online account.
    ///<see cref="http://xmlns.com/foaf/0.1/accountName"/>
    ///</summary>
    public static readonly Property accountName = new Property(new Uri("http://xmlns.com/foaf/0.1/accountName"));    

    ///<summary>
    ///Indicates a member of a Group
    ///<see cref="http://xmlns.com/foaf/0.1/member"/>
    ///</summary>
    public static readonly Property member = new Property(new Uri("http://xmlns.com/foaf/0.1/member"));    

    ///<summary>
    ///Indicates the class of individuals that are a member of a Group
    ///<see cref="http://xmlns.com/foaf/0.1/membershipClass"/>
    ///</summary>
    public static readonly Property membershipClass = new Property(new Uri("http://xmlns.com/foaf/0.1/membershipClass"));    

    ///<summary>
    ///The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.
    ///<see cref="http://xmlns.com/foaf/0.1/birthday"/>
    ///</summary>
    public static readonly Property birthday = new Property(new Uri("http://xmlns.com/foaf/0.1/birthday"));    

    ///<summary>
    ///The age in years of some agent.
    ///<see cref="http://xmlns.com/foaf/0.1/age"/>
    ///</summary>
    public static readonly Property age = new Property(new Uri("http://xmlns.com/foaf/0.1/age"));    

    ///<summary>
    ///A string expressing what the user is happy for the general public (normally) to know about their current activity.
    ///<see cref="http://xmlns.com/foaf/0.1/status"/>
    ///</summary>
    public static readonly Property status = new Property(new Uri("http://xmlns.com/foaf/0.1/status"));
}
///<summary>
///Friend of a Friend (FOAF) vocabulary
///
///</summary>
public static class FOAF
{
    public static readonly Uri Namespace = new Uri("http://xmlns.com/foaf/0.1/");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "FOAF";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://xmlns.com/foaf/0.1/"/>
    ///</summary>
    public const string _0_1 = "http://xmlns.com/foaf/0.1/";

    ///<summary>
    ///
    ///<see cref="http://xmlns.com/wot/0.1/assurance"/>
    ///</summary>
    public const string assurance = "http://xmlns.com/wot/0.1/assurance";

    ///<summary>
    ///
    ///<see cref="http://xmlns.com/wot/0.1/src_assurance"/>
    ///</summary>
    public const string src_assurance = "http://xmlns.com/wot/0.1/src_assurance";

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status"/>
    ///</summary>
    public const string term_status = "http://www.w3.org/2003/06/sw-vocab-status/ns#term_status";

    ///<summary>
    ///
    ///<see cref="http://purl.org/dc/elements/1.1/description"/>
    ///</summary>
    public const string description = "http://purl.org/dc/elements/1.1/description";

    ///<summary>
    ///
    ///<see cref="http://purl.org/dc/elements/1.1/title"/>
    ///</summary>
    public const string title = "http://purl.org/dc/elements/1.1/title";

    ///<summary>
    ///
    ///<see cref="http://purl.org/dc/elements/1.1/date"/>
    ///</summary>
    public const string date = "http://purl.org/dc/elements/1.1/date";

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public const string Class = "http://www.w3.org/2000/01/rdf-schema#Class";

    ///<summary>
    ///A foaf:LabelProperty is any RDF property with texual values that serve as labels.
    ///<see cref="http://xmlns.com/foaf/0.1/LabelProperty"/>
    ///</summary>
    public const string LabelProperty = "http://xmlns.com/foaf/0.1/LabelProperty";

    ///<summary>
    ///A person.
    ///<see cref="http://xmlns.com/foaf/0.1/Person"/>
    ///</summary>
    public const string Person = "http://xmlns.com/foaf/0.1/Person";

    ///<summary>
    ///An agent (eg. person, group, software or physical artifact).
    ///<see cref="http://xmlns.com/foaf/0.1/Agent"/>
    ///</summary>
    public const string Agent = "http://xmlns.com/foaf/0.1/Agent";

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing"/>
    ///</summary>
    public const string SpatialThing = "http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing";

    ///<summary>
    ///A document.
    ///<see cref="http://xmlns.com/foaf/0.1/Document"/>
    ///</summary>
    public const string Document = "http://xmlns.com/foaf/0.1/Document";

    ///<summary>
    ///An organization.
    ///<see cref="http://xmlns.com/foaf/0.1/Organization"/>
    ///</summary>
    public const string Organization = "http://xmlns.com/foaf/0.1/Organization";

    ///<summary>
    ///A class of Agents.
    ///<see cref="http://xmlns.com/foaf/0.1/Group"/>
    ///</summary>
    public const string Group = "http://xmlns.com/foaf/0.1/Group";

    ///<summary>
    ///A project (a collective endeavour of some kind).
    ///<see cref="http://xmlns.com/foaf/0.1/Project"/>
    ///</summary>
    public const string Project = "http://xmlns.com/foaf/0.1/Project";

    ///<summary>
    ///An image.
    ///<see cref="http://xmlns.com/foaf/0.1/Image"/>
    ///</summary>
    public const string Image = "http://xmlns.com/foaf/0.1/Image";

    ///<summary>
    ///A personal profile RDF document.
    ///<see cref="http://xmlns.com/foaf/0.1/PersonalProfileDocument"/>
    ///</summary>
    public const string PersonalProfileDocument = "http://xmlns.com/foaf/0.1/PersonalProfileDocument";

    ///<summary>
    ///An online account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineAccount"/>
    ///</summary>
    public const string OnlineAccount = "http://xmlns.com/foaf/0.1/OnlineAccount";

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2002/07/owl#Thing"/>
    ///</summary>
    public const string Thing = "http://www.w3.org/2002/07/owl#Thing";

    ///<summary>
    ///An online gaming account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineGamingAccount"/>
    ///</summary>
    public const string OnlineGamingAccount = "http://xmlns.com/foaf/0.1/OnlineGamingAccount";

    ///<summary>
    ///An online e-commerce account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount"/>
    ///</summary>
    public const string OnlineEcommerceAccount = "http://xmlns.com/foaf/0.1/OnlineEcommerceAccount";

    ///<summary>
    ///An online chat account.
    ///<see cref="http://xmlns.com/foaf/0.1/OnlineChatAccount"/>
    ///</summary>
    public const string OnlineChatAccount = "http://xmlns.com/foaf/0.1/OnlineChatAccount";

    ///<summary>
    ///A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.
    ///<see cref="http://xmlns.com/foaf/0.1/mbox"/>
    ///</summary>
    public const string mbox = "http://xmlns.com/foaf/0.1/mbox";

    ///<summary>
    ///The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.
    ///<see cref="http://xmlns.com/foaf/0.1/mbox_sha1sum"/>
    ///</summary>
    public const string mbox_sha1sum = "http://xmlns.com/foaf/0.1/mbox_sha1sum";

    ///<summary>
    ///The gender of this Agent (typically but not necessarily 'male' or 'female').
    ///<see cref="http://xmlns.com/foaf/0.1/gender"/>
    ///</summary>
    public const string gender = "http://xmlns.com/foaf/0.1/gender";

    ///<summary>
    ///A textual geekcode for this person, see http://www.geekcode.com/geek.html
    ///<see cref="http://xmlns.com/foaf/0.1/geekcode"/>
    ///</summary>
    public const string geekcode = "http://xmlns.com/foaf/0.1/geekcode";

    ///<summary>
    ///A checksum for the DNA of some thing. Joke.
    ///<see cref="http://xmlns.com/foaf/0.1/dnaChecksum"/>
    ///</summary>
    public const string dnaChecksum = "http://xmlns.com/foaf/0.1/dnaChecksum";

    ///<summary>
    ///A sha1sum hash, in hex.
    ///<see cref="http://xmlns.com/foaf/0.1/sha1"/>
    ///</summary>
    public const string sha1 = "http://xmlns.com/foaf/0.1/sha1";

    ///<summary>
    ///A location that something is based near, for some broadly human notion of near.
    ///<see cref="http://xmlns.com/foaf/0.1/based_near"/>
    ///</summary>
    public const string based_near = "http://xmlns.com/foaf/0.1/based_near";

    ///<summary>
    ///Title (Mr, Mrs, Ms, Dr. etc)
    ///<see cref="http://xmlns.com/foaf/0.1/title"/>
    ///</summary>
    public const string title_0 = "http://xmlns.com/foaf/0.1/title";

    ///<summary>
    ///A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).
    ///<see cref="http://xmlns.com/foaf/0.1/nick"/>
    ///</summary>
    public const string nick = "http://xmlns.com/foaf/0.1/nick";

    ///<summary>
    ///A jabber ID for something.
    ///<see cref="http://xmlns.com/foaf/0.1/jabberID"/>
    ///</summary>
    public const string jabberID = "http://xmlns.com/foaf/0.1/jabberID";

    ///<summary>
    ///An AIM chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/aimChatID"/>
    ///</summary>
    public const string aimChatID = "http://xmlns.com/foaf/0.1/aimChatID";

    ///<summary>
    ///A Skype ID
    ///<see cref="http://xmlns.com/foaf/0.1/skypeID"/>
    ///</summary>
    public const string skypeID = "http://xmlns.com/foaf/0.1/skypeID";

    ///<summary>
    ///An ICQ chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/icqChatID"/>
    ///</summary>
    public const string icqChatID = "http://xmlns.com/foaf/0.1/icqChatID";

    ///<summary>
    ///A Yahoo chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/yahooChatID"/>
    ///</summary>
    public const string yahooChatID = "http://xmlns.com/foaf/0.1/yahooChatID";

    ///<summary>
    ///An MSN chat ID
    ///<see cref="http://xmlns.com/foaf/0.1/msnChatID"/>
    ///</summary>
    public const string msnChatID = "http://xmlns.com/foaf/0.1/msnChatID";

    ///<summary>
    ///A name for some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/name"/>
    ///</summary>
    public const string name = "http://xmlns.com/foaf/0.1/name";

    ///<summary>
    ///The first name of a person.
    ///<see cref="http://xmlns.com/foaf/0.1/firstName"/>
    ///</summary>
    public const string firstName = "http://xmlns.com/foaf/0.1/firstName";

    ///<summary>
    ///The last name of a person.
    ///<see cref="http://xmlns.com/foaf/0.1/lastName"/>
    ///</summary>
    public const string lastName = "http://xmlns.com/foaf/0.1/lastName";

    ///<summary>
    ///The given name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/givenName"/>
    ///</summary>
    public const string givenName = "http://xmlns.com/foaf/0.1/givenName";

    ///<summary>
    ///The given name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/givenname"/>
    ///</summary>
    public const string givenname = "http://xmlns.com/foaf/0.1/givenname";

    ///<summary>
    ///The surname of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/surname"/>
    ///</summary>
    public const string surname = "http://xmlns.com/foaf/0.1/surname";

    ///<summary>
    ///The family name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/family_name"/>
    ///</summary>
    public const string family_name = "http://xmlns.com/foaf/0.1/family_name";

    ///<summary>
    ///The family name of some person.
    ///<see cref="http://xmlns.com/foaf/0.1/familyName"/>
    ///</summary>
    public const string familyName = "http://xmlns.com/foaf/0.1/familyName";

    ///<summary>
    ///A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).
    ///<see cref="http://xmlns.com/foaf/0.1/phone"/>
    ///</summary>
    public const string phone = "http://xmlns.com/foaf/0.1/phone";

    ///<summary>
    ///A homepage for some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/homepage"/>
    ///</summary>
    public const string homepage = "http://xmlns.com/foaf/0.1/homepage";

    ///<summary>
    ///A weblog of some thing (whether person, group, company etc.).
    ///<see cref="http://xmlns.com/foaf/0.1/weblog"/>
    ///</summary>
    public const string weblog = "http://xmlns.com/foaf/0.1/weblog";

    ///<summary>
    ///An OpenID for an Agent.
    ///<see cref="http://xmlns.com/foaf/0.1/openid"/>
    ///</summary>
    public const string openid = "http://xmlns.com/foaf/0.1/openid";

    ///<summary>
    ///A tipjar document for this agent, describing means for payment and reward.
    ///<see cref="http://xmlns.com/foaf/0.1/tipjar"/>
    ///</summary>
    public const string tipjar = "http://xmlns.com/foaf/0.1/tipjar";

    ///<summary>
    ///A .plan comment, in the tradition of finger and '.plan' files.
    ///<see cref="http://xmlns.com/foaf/0.1/plan"/>
    ///</summary>
    public const string plan = "http://xmlns.com/foaf/0.1/plan";

    ///<summary>
    ///Something that was made by this agent.
    ///<see cref="http://xmlns.com/foaf/0.1/made"/>
    ///</summary>
    public const string made = "http://xmlns.com/foaf/0.1/made";

    ///<summary>
    ///An agent that  made this thing.
    ///<see cref="http://xmlns.com/foaf/0.1/maker"/>
    ///</summary>
    public const string maker = "http://xmlns.com/foaf/0.1/maker";

    ///<summary>
    ///An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).
    ///<see cref="http://xmlns.com/foaf/0.1/img"/>
    ///</summary>
    public const string img = "http://xmlns.com/foaf/0.1/img";

    ///<summary>
    ///A depiction of some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/depiction"/>
    ///</summary>
    public const string depiction = "http://xmlns.com/foaf/0.1/depiction";

    ///<summary>
    ///A thing depicted in this representation.
    ///<see cref="http://xmlns.com/foaf/0.1/depicts"/>
    ///</summary>
    public const string depicts = "http://xmlns.com/foaf/0.1/depicts";

    ///<summary>
    ///A derived thumbnail image.
    ///<see cref="http://xmlns.com/foaf/0.1/thumbnail"/>
    ///</summary>
    public const string thumbnail = "http://xmlns.com/foaf/0.1/thumbnail";

    ///<summary>
    ///A Myers Briggs (MBTI) personality classification.
    ///<see cref="http://xmlns.com/foaf/0.1/myersBriggs"/>
    ///</summary>
    public const string myersBriggs = "http://xmlns.com/foaf/0.1/myersBriggs";

    ///<summary>
    ///A workplace homepage of some person; the homepage of an organization they work for.
    ///<see cref="http://xmlns.com/foaf/0.1/workplaceHomepage"/>
    ///</summary>
    public const string workplaceHomepage = "http://xmlns.com/foaf/0.1/workplaceHomepage";

    ///<summary>
    ///A work info homepage of some person; a page about their work for some organization.
    ///<see cref="http://xmlns.com/foaf/0.1/workInfoHomepage"/>
    ///</summary>
    public const string workInfoHomepage = "http://xmlns.com/foaf/0.1/workInfoHomepage";

    ///<summary>
    ///A homepage of a school attended by the person.
    ///<see cref="http://xmlns.com/foaf/0.1/schoolHomepage"/>
    ///</summary>
    public const string schoolHomepage = "http://xmlns.com/foaf/0.1/schoolHomepage";

    ///<summary>
    ///A person known by this person (indicating some level of reciprocated interaction between the parties).
    ///<see cref="http://xmlns.com/foaf/0.1/knows"/>
    ///</summary>
    public const string knows = "http://xmlns.com/foaf/0.1/knows";

    ///<summary>
    ///A page about a topic of interest to this person.
    ///<see cref="http://xmlns.com/foaf/0.1/interest"/>
    ///</summary>
    public const string interest = "http://xmlns.com/foaf/0.1/interest";

    ///<summary>
    ///A thing of interest to this person.
    ///<see cref="http://xmlns.com/foaf/0.1/topic_interest"/>
    ///</summary>
    public const string topic_interest = "http://xmlns.com/foaf/0.1/topic_interest";

    ///<summary>
    ///A link to the publications of this person.
    ///<see cref="http://xmlns.com/foaf/0.1/publications"/>
    ///</summary>
    public const string publications = "http://xmlns.com/foaf/0.1/publications";

    ///<summary>
    ///A current project this person works on.
    ///<see cref="http://xmlns.com/foaf/0.1/currentProject"/>
    ///</summary>
    public const string currentProject = "http://xmlns.com/foaf/0.1/currentProject";

    ///<summary>
    ///A project this person has previously worked on.
    ///<see cref="http://xmlns.com/foaf/0.1/pastProject"/>
    ///</summary>
    public const string pastProject = "http://xmlns.com/foaf/0.1/pastProject";

    ///<summary>
    ///An organization funding a project or person.
    ///<see cref="http://xmlns.com/foaf/0.1/fundedBy"/>
    ///</summary>
    public const string fundedBy = "http://xmlns.com/foaf/0.1/fundedBy";

    ///<summary>
    ///A logo representing some thing.
    ///<see cref="http://xmlns.com/foaf/0.1/logo"/>
    ///</summary>
    public const string logo = "http://xmlns.com/foaf/0.1/logo";

    ///<summary>
    ///A topic of some page or document.
    ///<see cref="http://xmlns.com/foaf/0.1/topic"/>
    ///</summary>
    public const string topic = "http://xmlns.com/foaf/0.1/topic";

    ///<summary>
    ///The primary topic of some page or document.
    ///<see cref="http://xmlns.com/foaf/0.1/primaryTopic"/>
    ///</summary>
    public const string primaryTopic = "http://xmlns.com/foaf/0.1/primaryTopic";

    ///<summary>
    ///The underlying or 'focal' entity associated with some SKOS-described concept.
    ///<see cref="http://xmlns.com/foaf/0.1/focus"/>
    ///</summary>
    public const string focus = "http://xmlns.com/foaf/0.1/focus";

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2004/02/skos/core#Concept"/>
    ///</summary>
    public const string Concept = "http://www.w3.org/2004/02/skos/core#Concept";

    ///<summary>
    ///A document that this thing is the primary topic of.
    ///<see cref="http://xmlns.com/foaf/0.1/isPrimaryTopicOf"/>
    ///</summary>
    public const string isPrimaryTopicOf = "http://xmlns.com/foaf/0.1/isPrimaryTopicOf";

    ///<summary>
    ///A page or document about this thing.
    ///<see cref="http://xmlns.com/foaf/0.1/page"/>
    ///</summary>
    public const string page = "http://xmlns.com/foaf/0.1/page";

    ///<summary>
    ///A theme.
    ///<see cref="http://xmlns.com/foaf/0.1/theme"/>
    ///</summary>
    public const string theme = "http://xmlns.com/foaf/0.1/theme";

    ///<summary>
    ///Indicates an account held by this agent.
    ///<see cref="http://xmlns.com/foaf/0.1/account"/>
    ///</summary>
    public const string account = "http://xmlns.com/foaf/0.1/account";

    ///<summary>
    ///Indicates an account held by this agent.
    ///<see cref="http://xmlns.com/foaf/0.1/holdsAccount"/>
    ///</summary>
    public const string holdsAccount = "http://xmlns.com/foaf/0.1/holdsAccount";

    ///<summary>
    ///Indicates a homepage of the service provide for this online account.
    ///<see cref="http://xmlns.com/foaf/0.1/accountServiceHomepage"/>
    ///</summary>
    public const string accountServiceHomepage = "http://xmlns.com/foaf/0.1/accountServiceHomepage";

    ///<summary>
    ///Indicates the name (identifier) associated with this online account.
    ///<see cref="http://xmlns.com/foaf/0.1/accountName"/>
    ///</summary>
    public const string accountName = "http://xmlns.com/foaf/0.1/accountName";

    ///<summary>
    ///Indicates a member of a Group
    ///<see cref="http://xmlns.com/foaf/0.1/member"/>
    ///</summary>
    public const string member = "http://xmlns.com/foaf/0.1/member";

    ///<summary>
    ///Indicates the class of individuals that are a member of a Group
    ///<see cref="http://xmlns.com/foaf/0.1/membershipClass"/>
    ///</summary>
    public const string membershipClass = "http://xmlns.com/foaf/0.1/membershipClass";

    ///<summary>
    ///The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.
    ///<see cref="http://xmlns.com/foaf/0.1/birthday"/>
    ///</summary>
    public const string birthday = "http://xmlns.com/foaf/0.1/birthday";

    ///<summary>
    ///The age in years of some agent.
    ///<see cref="http://xmlns.com/foaf/0.1/age"/>
    ///</summary>
    public const string age = "http://xmlns.com/foaf/0.1/age";

    ///<summary>
    ///A string expressing what the user is happy for the general public (normally) to know about their current activity.
    ///<see cref="http://xmlns.com/foaf/0.1/status"/>
    ///</summary>
    public const string status = "http://xmlns.com/foaf/0.1/status";
}
}