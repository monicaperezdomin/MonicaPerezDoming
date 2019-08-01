using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using log4net;
using WebApplication1.Model;

namespace WebApplication2
{
    public class Repository : IRepository
    {
        private readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private string Path = (@"C:RebeldFile.txt");
        private string _line;
        private static Repository _instance;
        public List<string> ResultFile = new List<string>();


        private Repository()
        {
        }

        public static Repository Instance => _instance ?? (_instance = new Repository());


        public bool FindRebeld(List<string>TestRebeld)
        {
            string name = TestRebeld[0];
            string planet = TestRebeld[1];
            var find = false;
            try
            {
                using (StreamReader fileRead = new StreamReader(Path))
                {
                    string line;

                    while ((line = fileRead.ReadLine()) != null)
                    {
                        if (line.Contains(name) && line.Contains(planet))
                        {
                            find = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error("This error find");
            }

            return find;

        }

        public void ReadFile()
        {
            try
            {
                
                var file =
                    new System.IO.StreamReader(Path);
                //"~\\FolderIcon\\Folder");
                while ((_line = file.ReadLine()) != null) ResultFile.Add(_line);

                file.Close();

            }
            catch (Exception ex)
            {
                _log.Error("This is error read");
            }

        }

        public bool WriteFile(string lineResult)
        {

            try
            {
                if (System.IO.File.Exists(Path))

                {
                    using (StreamWriter writer = new StreamWriter(Path))
                    {
                        writer.WriteLine(lineResult);
                    }

                    return true;
                }
                else
                {
                    File.Create(Path);
                    using (StreamWriter writer = new StreamWriter(Path))
                    {
                        writer.WriteLine(lineResult);
                    }

                    return true;
                }

                
            }
            catch (Exception ex)
            {
                _log.Error("This is error write File");
            }

            return false;
        }

    }
}
