using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public static class FileCrawler
    {
        private static char CONNECTOR = '└';
        private static char V_PIPE = '│';
        private static char D_CONNECTOR = '├';

        private static string H_PIPE_SPACER = "───";
        private static string DEPTH_TAB = "   ";

        private static int currentDepth = 0;
        // private static int lastDepth = 0;
        public static void PrintTreeViewOf(DirectoryInfo root)
        {
            string toPrint = "";

            DirectoryInfo[] subDirs = root.GetDirectories();

            int nDirs = subDirs.Length;

            /*if (nDirs == 1) toPrint += CONNECTOR;
            else { toPrint += D_CONNECTOR; }*/

            for(int i = 0; i < currentDepth; i++)
            {
                toPrint += V_PIPE + DEPTH_TAB;
            }

            if(nDirs != 0)
            {
                for(int i = 0; i < nDirs; i++)
                {
                    DirectoryInfo dir = subDirs[i];

                    if (i == nDirs - 1) toPrint += CONNECTOR;
                    else { toPrint += D_CONNECTOR; }

                    toPrint += H_PIPE_SPACER;
                    toPrint += dir.Name;

                    Console.WriteLine(toPrint);

                    currentDepth++;

                    toPrint = "";

                    PrintTreeViewOf(dir);
                }
            }
            else 
            {
                //Console.WriteLine(toPrint);
                currentDepth = 0; 
            }
        }
    }
}
