using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
	public FileHandler()
	{
	}

	public static bool Save(string filename, List<String> list)
	{
		FileStream fsWrite = new FileStream(filename, FileMode.OpenOrCreate);

        if (!fsWrite.CanWrite)
        {
			return false;
        }

		StreamWriter sw = new StreamWriter(fsWrite);
		sw.AutoFlush = true;

		foreach(string item in list)
        {
			sw.WriteLine(item);
		}

		fsWrite.Close();

		return true;
	}
	public static List<String> Read(string filename)
    {
		List<string> list = new List<string>();
		FileStream fsRead = new FileStream(filename, FileMode.Open);
		StreamReader sr = new StreamReader(fsRead);

        while (!sr.EndOfStream)
        {
			list.Add(sr.ReadLine());
        }
		return list;
    }
}
