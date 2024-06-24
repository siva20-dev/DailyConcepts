using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts.Collections
{
    public class Collections

    {
        //new Customer1 {name="John",age= 20};
        //new Customer2 {name="Tony",age= 40};
        //new Customer3 { name = "Suzi", age = 16 };

        //new Order1 {Id=1, ProductName= "Pot"};
        //new Order2 {Id=2, ProductName= "Pen"};
        //new Order3 {Id=3, ProductName= "Book"};

        //Collections are types that holds a set of related data object together

        //Treat them as a single object
        //List<Customer>customerObject= new List<Customer>()

        //On which you can perform operations like
        //Searching = customerObject.find(x=>x.age==25)
        //Do anything = foreach(var item customerObject)
        //   {
        //       //do Something
        //   }

        //Storing Related Data
        //customerObject.Add(new Customer {name="John",age= 25};
        //customerObject.Add(new Customer {name="Sam",age= 16};
        //customerObject.Add(new Customer {name="Martin",age= 55};

        //Perform Operations like
        //var martins = customerObject.find(x=>x.Name=="Martin");
        //martins.Foreach(x=> Console.WriteLine(x.Name));

        //if ( customerObject.Exists(x=>x.Name=="John"));
        //{
        //Console.WriteLine(" Yes a person with a name John Exists")
        //}

        //Types of Collections in C#

        //System.Collection(Array,Stack,Queue,HashTable)
        //System.Collection.Generic(List,Stack,Queue,LinkedList,HashSet,SortedSet,Dictionary,SortedDictionary,SortedList)
        //System.Collection.Concurrent(Blocking Collection,ConcurrentBag,ConcurrenQueue,ConcurrenDictionary)
    }
}
