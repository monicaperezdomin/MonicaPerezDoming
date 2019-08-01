
using System.Collections.Generic;


namespace Applicatio
{
    public interface IOperatorRebeld
    {
        bool FindRebelds(string name, string planet);
        List<string> TotalRebeld(string name, string planet);
        bool WriteFileRebel(string rebeld,string planet);
    }
}