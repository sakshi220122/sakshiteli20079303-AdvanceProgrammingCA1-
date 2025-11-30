#nullable disable
using System;


class MainClass
{
    static FileExtension[] extension = new FileExtension[200];
    static int count = 0;

    public static void Main(string[] args)
    {
         AddDefaultExtension();

         while(true)
        {
            Console.WriteLine("\n---File Extension ---");
            Console.WriteLine(" 1.Show All Extensions ");
            Console.WriteLine(" 2.Show One Extensions ");
            Console.WriteLine(" 3.Add Extensions ");
            Console.WriteLine(" 4.Update Extensions ");
            Console.WriteLine(" 5.Delete Extensions ");
            Console.WriteLine(" 0.Exit");
            Console.Write("Enter option: ");

            string str = Console.ReadLine();

            switch(str)
            {
               
            
                case "0":
                    return;
                case "1":
                    ShowAll();
                    break;
                case "2":
                    Search();
                    break;
                case "3":
                    AddExtension();
                    break;
                case "4":
                    UpdateExtension();
                    break;
                case "5":
                    DeleteExtension();
                    break;
                default:
                    Console.WriteLine("Invalid option, try again....");
                    break;
            }

            

        }

    }

    static void AddDefaultExtension()
    {
       Add(".mp4",  "Video File");
        Add(".avi",  "Video File");
        Add(".mov",  "Video File");
        Add(".mkv",  "Video File");
        Add(".webm", "Video File");
        Add(".mp3",  "Audio File");
        Add(".wav",  "Audio File");
        Add(".flac", "Audio File");
        Add(".jpg",  "Image File");
        Add(".jpeg", "Image File");
        Add(".png",  "Image File");
        Add(".gif",  "Image File");
        Add(".pdf",  "Document");
        Add(".docx", "Word Document");
        Add(".xlsx", "Excel Sheet");
        Add(".pptx", "PowerPoint");
        Add(".txt",  "Text File");
        Add(".zip",  "Compressed File");
        Add(".rar",  "Compressed File");
        Add(".7z",   "Compressed File");
    
         
    }

    static void Add(string ext, string desc)
    {
        FileExtension FE = new FileExtension();
        FE.Extension = ext;
        FE.Description = desc;
        extension[count++] = FE;

    }

    static void ShowAll()
    {
        Console.WriteLine("\n Supported Extensions : ");
        for(int i = 0 ; i < count ; i++)
        {
            Console.WriteLine(extension[i].Extension + " - " + extension[i].Description);
        }
    }

    static void Search()
    {
        Console.Write(" Enter Extension : ");
        string ext = Console.ReadLine();

        if (ext.Length > 0 && ext[0] != '.')
            ext = "." + ext;

        for(int i=0;i<count;i++)
        {
            if(extension[i].Extension == ext)
            {
                extension[i].showExtension();
                return;
            }
        } 

        Console.WriteLine(" Extension Not Found ....");   

    }

    static void AddExtension()
    {
        Console.Write("Enter Extension : ");
        string ext = Console.ReadLine();
        if (ext != "" && ext[0] != '.')
            ext = "." + ext;

        Console.Write(" Enter Description : ");
        string desc = Console.ReadLine();

        Add(ext,desc);
        Console.WriteLine("Entension added ! ");

    }

    static void UpdateExtension()
    {
        Console.Write("Extension : ");
        string ext = Console.ReadLine();

        if (ext != "" && ext[0] != '.')
            ext = "." + ext;


        for ( int i = 0; i < count; i++)
        {
            if(extension[i].Extension == ext)
            {
                Console.Write("New Description : ");
                string D = Console.ReadLine();
                if(D != "") extension[i].Description = D;

                Console.WriteLine(" Extension Updated ");
                return;
            }
        }   

        Console.WriteLine(" Extension Not Found ");

    }

    static void DeleteExtension()
    {
        Console.Write("Extension : ");
        string ext = Console.ReadLine();

        if(ext != "" && ext[0] != '.')
           ext = "." + ext;

        for(int i = 0; i< count;i++)
        {
            
            if(extension[i].Extension == ext)
            {
                for(int j = i ; j<count-1; j++)
                {
                    extension[j] = extension[j+1];
                }

                count--;
                Console.WriteLine(" Extension Deleted :");
                return;
            }
        }   

        Console.WriteLine("Extension Not Found ....");
    }

}



//1. cd "C:\Users\Admin\Desktop\sakshi20079303\Que.2\ConsoleApp1" 
//2.dotnet run