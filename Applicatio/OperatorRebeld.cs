using System;
using System.Collections.Generic;
using WebApplication1.Model;
using WebApplication2;

namespace Applicatio
{
    public class OperatorRebeld: IOperatorRebeld
    {
        private string _name;
        private string _planet;

        public List<string> RebeldImperial=new List<string>();


        IRepository RepositoryR = Repository.Instance;
       

        public OperatorRebeld()
        {

        }
        public OperatorRebeld(string name, string planet)
        {
            _name = name;
            _planet = planet;
        }

        public bool FindRebelds(string name, string planet)
        {
           
            RebeldImperial.Add(name);
            RebeldImperial.Add(planet);
            return RepositoryR.FindRebeld(RebeldImperial);
        }

        public bool WriteFileRebel(string name,string planet)
        {
            string date = DateTime.Now.ToString("g");
            string lineResult = " rebeld " + name + " on " + planet + " at( " + date + ")";
            return RepositoryR.WriteFile(lineResult);
        }


        public List<string> TotalRebeld (string rebelname, string rebelplanet)
        {
            List<string> newRebeld=new List<string>();
            newRebeld.Add(rebelname);
            newRebeld.Add(rebelplanet);
            return newRebeld;
        }
    }
}