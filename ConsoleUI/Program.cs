using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            bool exit = true;

            while (exit)
            {
                Console.WriteLine("------Rent A Car-----\n");
                Console.WriteLine("1. Add Car\n2. Delete Car\n3. Update Car\n4. Listed Car\n" +
                    "5. Arabaların detaylı listelenmesi\n6. Arabaların Markasına göre listelenmesi\n" +
                    "7. Arabaların renklerine göre listelenmesi\n8. Arabaların ıd ye göre listelenmesi\n" +
                    "9. Fiyat aralığına göre Listeleme\n10. Model yılına göre Listeleme\n" +
                    "11. Add Customer\n12. Listed Customer\n13. Add User\n14. Listed User\n" +
                    "15. Araba Kiralama\n16. Araba Teslim Etme\n17. Araba Kiralama Listesi\n18. Exit");
           }
        }

    }
}
