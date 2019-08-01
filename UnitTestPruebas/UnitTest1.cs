using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace UnitTestPruebas
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestRebeld()
        {
            string name = "";
            string planet = "";


            Assert.AreEqual("Error debe rellenar los campos", "Error debe rellenar los campos");
        }

        [TestMethod]
        public void FindRebeld(List<string> TestRebeld)
        {
            string Path = (@"C:RebeldFile.txt");
            string name = "Manolo";
            string planet = "Conchinchina";

            var find = false;

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



            Assert.AreEqual("false", "false");
        }



        [TestMethod]
        public void ReadFile(List<string> TestRebeld)
        {
         List<string> ResultFile = new List<string>();
        string _line;
            string Path = (@"C:RebeldFile.txt");
            var file =
                new System.IO.StreamReader(Path);
            //"~\\FolderIcon\\Folder");
            while ((_line = file.ReadLine()) != null) ResultFile.Add(_line);

            file.Close();

        }

    }
}
