using System;
using System.IO;

class DemoFileRW 
{
  public static void Main() {
    //  Writing to a new file
    //  On windows change the "/" to "\". Windows use backslash in path instead of forward slash.
    string FilePath = Directory.GetCurrentDirectory() + "/out.dat";
    Console.Clear(); 

    int opt;
    do {
      Console.WriteLine("File Path: " + FilePath);
      Console.WriteLine("1. Create new file and write to it");
      Console.WriteLine("2. Read from file");
      Console.WriteLine("3. Delete the file");
      Console.WriteLine("4. Quit");
      Console.Write("? ");
      opt = Convert.ToInt32(Console.ReadLine());
      switch(opt) {
        case 1:
          Console.Clear();
          WriteNew(FilePath);
          AppendText(FilePath);
          break;
        case 3:
          Console.Clear();
          Delete(FilePath);
          Console.WriteLine("Deleted\n\n");
          break;
        case 2: 
          Console.Clear();
          ReadFromFile(FilePath);
          break;
      }
    }
    while(opt != 4);
  }

  public static void WriteNew(string FilePath){
    if(!File.Exists(FilePath)) {
      using (StreamWriter sw = File.CreateText(FilePath)){
        for(int i = 1; i < 4; i++) 
          sw.WriteLine(i + ". A line of text");
        sw.Close();
      }
    }
    else {
      Console.WriteLine("File Path: "+ FilePath + "\nFile exists!");
    }
  }

  private static int ReadFromFile(string FilePath) {
    if(!File.Exists(FilePath)) {
      Console.WriteLine("Error: file NOT found");
      Console.WriteLine("FilePath: " + FilePath);
      return 0;
    }
    using (StreamReader sr = File.OpenText(FilePath)) {
      string line;
      while((line = sr.ReadLine()) != null) {
        Console.WriteLine("Read Line: "+line);
      }
      sr.Close();
    }
    return 0;
  }

  private static void AppendText(string FilePath) {
    using (StreamWriter sw = File.AppendText(FilePath)) {
      sw.WriteLine("Newly appended text");
      sw.Close();
    }
  }

  private static void Delete(string FilePath) {
    File.Delete(FilePath);
  }
}