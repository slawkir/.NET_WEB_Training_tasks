using System;

namespace FileManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemManager manager = new FileSystemManager();

            manager.Begin();
        }
    }
}
