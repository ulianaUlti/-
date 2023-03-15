using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace коллекции
{
    class Collection
    {
List<Department> department = new List<Department>()
{
new Department { Name = "Отдел закупок", Reg ="Германия" },
new Department { Name = "Отдел продаж", Reg ="Испания" },
new Department { Name = "Отдел маркетинга", Reg ="Испания" }
};
    List<Employ> employes = new List<Employ>()
{
 new Employ{Name="Иванов", department =" Отдел закупок "},
new Employ {Name="Петров", department =" Отдел закупок "},
new Employ {Name="Сидоров", department =" Отдел продаж "},
new Employ {Name="Лямин", department =" Отдел продаж "},
new Employ {Name="Сидоренко", department =" Отдел маркетинга "},
new Employ {Name="=Кривоносов", department =" Отдел продаж "}
};
                
//var result = from pl in employes
//                     join t in Employ on pl.Employ equals t.Name
//                     select new { Name = pl.Name, Team = pl.Team, department = t.department };
//foreach (var item in result)
//Console.WriteLine($"{item.Name} - {item. department } ({item. department})");
     
//            //выводим на и фамилии

//            var result = employes.Join(teams,
//p => p.Team,
//t => t.Name,
//(p, t) => new {
//    Name = p.Name,
//    Team = p.Team,
//    Country = t.Country
//});
    }
}
