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
    public string NameofImage { get; set; }

    public GOGActors()
    {

    }

    public GOGActors(string name, string character, string imag)
    {
        NameofActor = name;
        NameofChar = character;
        NameofImage = imag;
    }

    public static List<GOGActors> GetActor() => new List<GOGActors>
    {
        new GOGActors("Chris Pratt", "Starlord", "starlord.jpg"),
        new GOGActors("Zoe Saldana", "Gamora", "gamora.jpg"),
        new GOGActors("Vin Diesel", "Groot", "groot.jpg"),
        new GOGActors("Bradley Cooper", "Rocket", "rocket.jpg"),
        new GOGActors("Karen Gillan", "Nebula", "nebula.jpg")
     };
}
