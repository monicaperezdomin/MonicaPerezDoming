
using System.Collections.Generic;

namespace WebApplication1.Model
{
    public interface IRepository
    {
        void ReadFile();
        bool WriteFile(string lineResult);
        bool FindRebeld(List<string>testRebeld);
    }
}