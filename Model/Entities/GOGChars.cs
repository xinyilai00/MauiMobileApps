using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.Model.Entities;

public class GOGChars
{
    public string NameofChar { get; set; }

    public GOGChars()
    {

    }

    public GOGChars(string name) => NameofChar = name;

    public static List<GOGChars> GetChar() => new List<GOGChars>
    {
        new GOGChars("Starlord"),
        new GOGChars("Gamora"),
        new GOGChars("Groot"),
        new GOGChars("Rocket"),
        new GOGChars("Nebula")
     };
}
