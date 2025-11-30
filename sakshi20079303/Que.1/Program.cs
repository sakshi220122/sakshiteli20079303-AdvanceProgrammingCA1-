#nullable disable


using System;

class MainClass
{
    static ContactBook[] contacts = new ContactBook[100];
    static int count = 0;

    public static void Main(string[] args)
    {
        for (int i = 0; i < 20; i++)
        {
            ContactBook CB = new ContactBook();
            CB.FirstName = "Person" + (i + 1);
            CB.LastName = "lastname" + (i + 1);
            CB.Company = "company" + (i + 1);
            CB.Mobile = "123456789" + (i + 1);
            CB.Email = "person" + (i + 1) + "@gmail.com";
            CB.BirthDate = "1990-01-01";
            contacts[count] = CB;
            count++;
        }
       


        while (true)
        {
            Console.WriteLine("\n--- Contact Book Menu --- ");
            Console.WriteLine(" 1. Add contact ");
            Console.WriteLine(" 2. Show All Contacts ");
            Console.WriteLine(" 3. Show one Contacts ");
            Console.WriteLine(" 4. Update Contact ");
            Console.WriteLine(" 5. Delete Contact ");
            Console.WriteLine(" 0. Exit ");
            Console.WriteLine(" Enter Option ");

            string str = Console.ReadLine();

            switch (str)
            {
                case "0":
                    return;

                case "1":
                    AddContact();
                    break;

                case "2":
                    ShowAll();
                    break;

                case "3":
                    ShowOne();
                    break;

                case "4":
                    UpdateContact();
                    break;

                case "5":
                    DeleteContact();
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }   

    static void AddContact()
    {
        ContactBook CB = new ContactBook();

        Console.Write("First Name :");
        CB.FirstName = Console.ReadLine();

        Console.Write("Last Name :");
        CB.LastName = Console.ReadLine();

        Console.Write("Company : ");
        CB.Company = Console.ReadLine();

        string mobileNumber = "";

        while (true)
        {
            Console.Write("Mobile Number ( 9 digits ) : ");
            mobileNumber = Console.ReadLine();

            if (mobileNumber.Length == 9 && mobileNumber != "000000000" && long.TryParse(mobileNumber, out _))
                break;

            Console.WriteLine("Invalid Mobile Number . Please Try Again...");
        }

        CB.Mobile = mobileNumber;

        Console.Write("Email : ");
        CB.Email = Console.ReadLine();

        Console.Write("Birthdate :");
        CB.BirthDate = Console.ReadLine();

        contacts[count] = CB;
        count++;

        Console.WriteLine("Contact Added !");
    }

    static void ShowAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(contacts[i].FirstName + " " + contacts[i].LastName + " -- " + contacts[i].Mobile);
        }
    }

    static void ShowOne()
    {
        Console.Write("Enter Mobile Number :");
        string mobileNumber = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Mobile == mobileNumber)
            {
                contacts[i].showContact("Contact Details ");  
                return;
            }
        }

        Console.WriteLine("Contact not found....");   
    }

    static void UpdateContact()
    {
        Console.Write("Enter Mobile Number To Update : ");
        string mobileNumber = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Mobile == mobileNumber)
            {
                Console.Write("New First Name :");
                string FN = Console.ReadLine();
                if (FN != "") contacts[i].FirstName = FN;

                Console.Write("New Last Name :");
                string LN = Console.ReadLine();
                if (LN != "") contacts[i].LastName = LN;

                Console.Write("New Company :");
                string COM = Console.ReadLine();
                if (COM != "") contacts[i].Company = COM;

                Console.Write("New Email:");
                string EM = Console.ReadLine();
                if (EM != "") contacts[i].Email = EM;

                Console.Write("New Birthdate  :");
                string BD = Console.ReadLine() ;
                if (BD != "") contacts[i].BirthDate = BD;

                Console.WriteLine("Contact Updated ! ");
                return;
            }
        }

        Console.WriteLine("Contact not found....");   
    }

    static void DeleteContact()
    {
        Console.Write(" Enter Mobile Number To Delete : ");
        string mobileNumber = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Mobile == mobileNumber)
            {
                for (int j = i; j < count - 1; j++)
                {
                    contacts[j] = contacts[j + 1];
                }
                count--;
                Console.WriteLine(" Contact Deleted ! ");
                return;
            }
        }

        Console.WriteLine("Contact not found....");
    }
}



//To run program we have to first go in cd C:\Users\Admin\Desktop\sakshi20079303\Que.1
//Then inside this folder run - dotnet run