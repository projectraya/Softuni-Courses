﻿using System;
using System.Collections.Generic;
using System.IO;


    public static class DirectoryTraverserBFS
{
        static void Main(string[] args)
        {
            //TraverseDirBFS(@"C:\Windows\assembly");
        }

        public static void TraverseDirBFS(string directoryPath)
        {
            Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));

            while(visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] children = currentDir.GetDirectories();

                foreach(DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }

            
        }
    }

