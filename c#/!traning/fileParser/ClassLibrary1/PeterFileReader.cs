using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class PeterFileReader
    {
        public string[] getPathList()
        {
            var patch = new StringBuilder(Directory
                .GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString())
                    .ToString()).ToString()).ToString()).Append(@"\ClassLibrary1\data").ToString();

            return Directory.GetFiles(patch);
        }

        public string getFileName(string fileName)
        {
            int j = 0;
            string res = "";

            var splitList = fileName.Split(new char[] { '_' });

            while (splitList[splitList.Length - 1][j] != '.')
            {
                res += splitList[splitList.Length - 1][j];
                j++;                    //???
            }

            return res.ToLower();
        }

        public string RunFactory(string nameOfDoc)
        {
            Dictionary<string,Func<string>> dictionary = new Dictionary<string, Func<string>>()
            {
                {"doc0",()=> new slashParser().parseFile()},
                {"doc1",()=> new slashParser().parseFile()},
                {"doc2",()=> new slashParser().parseFile()},
                {"doc3",()=> new slashParser().parseFile()},
                {"doc4",()=> new slashParser().parseFile()},
                {"doc5",()=> new slashParser().parseFile()},
                {"doc6",()=> new slashParser().parseFile()},
                {"doc7",()=> new slashParser().parseFile()},
                {"doc8",()=> new slashParser().parseFile()},
                {"doc9",()=> new slashParser().parseFile()},
            };

            return dictionary[nameOfDoc]();
        }

        public static int licz = 0;

        //////////////////////////proba odpalania na watkach
        public void runParallelFile(string name)
        {
            var a = RunFactory(getFileName(name));
            licz++;
        }



        public void execute(int ile = 10)
        {
            //for (int i = 0; i < getPathList().Length; i++)
            {
                getPathList().AsParallel().WithDegreeOfParallelism(ile).ForAll(runParallelFile);
            }
        }

    }
}