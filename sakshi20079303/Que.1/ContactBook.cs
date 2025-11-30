using System;

class ContactBook
{
    public string ? FirstName,LastName,Company,Mobile,Email,BirthDate;

    public  void showContact()
    {
        
            Console.WriteLine("First Name :" + FirstName);
            Console.WriteLine("Last Name : " + LastName);
            Console.WriteLine("Company : " + Company );
            Console.WriteLine("Mobile : " + Mobile );
            Console.WriteLine("Email : " + Email );
            Console.WriteLine("Birthdate : " + BirthDate );

    }

    public void showContact(string title)
    {
        Console.WriteLine("\n---" + title + "----");
        showContact();

    }

}