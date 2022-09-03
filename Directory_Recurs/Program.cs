﻿Console.Clear();

string path = "C:/Users/Vadim/Desktop/GB/C#/Examples";
// DirectoryInfo di = new DirectoryInfo(path);

// System.Console.Write(di.CreationTime);
// FileInfo[] fi =  di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

void CatalogInfo(string path, string indent = "") {
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
     for (int i = 0; i < catalogs.Length; i++)
     {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
     } 

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

CatalogInfo(path);
