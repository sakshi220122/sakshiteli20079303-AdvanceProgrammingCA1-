using System;

class FileExtension
{
    public string ? Extension , Description;

    public void showExtension()
    {
        Console.WriteLine("Extension : " + Extension);
        Console.WriteLine("Description: " + Description);

    }
    
    public void showExtension(string title)
    {
        Console.WriteLine("\n--- " + title + "--- ");
        showExtension();

    }

}