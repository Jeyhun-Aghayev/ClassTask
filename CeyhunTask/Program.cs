class Program
{
    static void Main()
    {
        Store myStore = new Store { Name = "My Store" };

        Phone phone1 = new Phone { Id = 1, Name = "13 pro", BrandName = "Iphone", Price = 1998.99, Count = 10 };
        Phone phone2 = new Phone { Id = 2, Name = "13 pro max", BrandName = "Iphone", Price = 1799.99, Count = 5 };
        Phone phone3 = new Phone { Id = 3, Name = "14 pro", BrandName = "Iphone", Price = 2498.99, Count = 10 };
        Phone phone4 = new Phone { Id = 4, Name = "14 pro max", BrandName = "Iphone", Price = 2998.99, Count = 10 };


        myStore.AddPhone(phone1);
        myStore.AddPhone(phone2);
        myStore.AddPhone(phone3);
        myStore.AddPhone(phone4);

        myStore.ShowAllPhones();
        Console.WriteLine("\n-------------------------------------------------------------------------------------------------------");
        double minPrice = 1000.00;
        double maxPrice = 2000.00;
        myStore.ShowPhonesForPrice(minPrice, maxPrice);
        myStore.RemovePhone(2);
        Console.WriteLine("\n-------------------------------------------------------------------------------------------------------");
        Console.WriteLine("FromRemove:");
        myStore.ShowAllPhones();


    }
}