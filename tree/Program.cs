using static tree.FileCrawler;

namespace tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string drive = Directory.GetLogicalDrives()[3];
            string path = @"D:\Games\FNV\FalloutNewVegas";
            Console.WriteLine(path);

            DirectoryInfo info = new DirectoryInfo(path);

            FileCrawler.PrintTreeViewOf(info);
        }
    }
}