using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class FileReader
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string[] getPathList()
        {
            var patch = new StringBuilder(Directory
                .GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString())
                    .ToString()).ToString()).ToString()).Append(@"\ClassLibrary1\data").ToString();

            return Directory.GetFiles(patch);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void execute(int howMany = 5)
        {
            string[] filePath = getPathList();
            filePath.AsParallel().WithDegreeOfParallelism(howMany).ForAll(ParalleFileParse);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ParalleFileParse(string filePath)
        {
            var parser = getPropertyParser(getParserName(filePath));
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public IReader getPropertyParser(string name)
        {
            Dictionary<string, Func<IReader>> parserFactory = new Dictionary<string, Func<IReader>>()
            {
                {"doc0", () => new slashParser()},
            };

            return parserFactory[name]();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string getParserName(string fileName)
        {
            int j = 0;
            string res = "";

            var splitList = fileName.Split(new char[] {'_'});

            while (splitList[splitList.Length-1][j] != '.')
            {
                res += splitList[splitList.Length - 1][j];
            }

            return res.ToLower();
        }
    }
}