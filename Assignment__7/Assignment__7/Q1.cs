namespace FileIODemo
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Ayesha\Training";
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);

            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            Console.ReadLine();
        }
    }
}