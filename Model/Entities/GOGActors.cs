using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.Model.Entities;

public class GOGActors
{
    public string NameofActor { get; set; }
    public string NameofChar { get; set; }

    public GOGActors()
    {

    }

    public GOGActors(string name) => NameofActor = name;
    //public GOGActors(string character) => NameofChar = character;

    public static List<GOGActors> GetActor() => new List<GOGActors>
    {
        new GOGActors("Chris Pratt"),
        new GOGActors("Zoe Saldana"),
        new GOGActors("Vin Diesel"),
        new GOGActors("Bradley Cooper"),
        new GOGActors("Karen Gillan")
     };

    //public static List<GOGActors> GetChar() => new List<GOGActors>
   //{
        //new GOGActors("Starlord"),
       // new GOGActors("Gamora"),
        //new GOGActors("Groot"),
       // new GOGActors("Rocket"),
        //new GOGActors("Nebula")
     //};
}
