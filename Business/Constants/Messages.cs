using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {

        //All
        public static string AllListed = "Listelendi";
        public static string MaintenanceTime = "Bakımda";

        //Car
        public static string CarAdded = "Araç eklendi";
        public static string DailyPriceError = "Daily Price O'dan büyük olmalı!";
        public static string CarUpdated = "Car Updated";
        public static string CarDeleted = "Car Deleted";

        //Color
        public static string ColorNameError = "Color Name Must be greater than 2 letters";
        public static string ColorAdded ="Color Added";
        public static string ColorDeleted="Color Deleted";
        public static string ColorUpdated = "Color Updated";
       

        //Brand
        public static string BrandAdded = "Brand Added";
        public static string BrandDeleted = "Brand Added";
        public static string BrandUpdated = "Brand Updated";

        //User-success
        public static string UserAdded = "User Added";
        public static string UserDeleted = "User Deleted";
        public static string UserUpdated = "User Updated";
        //User-Error
        public static string UserNameError = "User Name Must be greater than 2 letters";
        public static string UserLastError = "User LastName Must be greater than 2 letters";

        //Customer
        public static string CustomerAdded = "Customer Added";
        public static string CustomerDeleted = "Customer Deleted";
        public static string CustomerUpdated = "Customer Updated";

        //Rental
        public static string RentalAdded = "Rental Added";
        public static string RentalUpdated = "Rental Updated";
        public static string RentalDeleted = "Rental Deleted";


        public static string BrandCountError = "aynı markadan en fazla on tane ekleyebilirsiniz.";

        public static string ColorLimitExceded { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }

        public static string UserAlreadyExists = "kullanıcı zaten mevcut";

        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";

        public static string UserRegistered = "Kayıt oluşturuldu.";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string AuthorizationDenied = "Yetkiniz Yok!";

        public static string CarImageLimit = "1 araç için 5 den fazla resim yüklenemez.";

        public static string CarImageAdded = "Resim eklendi";

        public static string ColorNameAlreadyExist = "Bu isimde Renk var";

        public static string BrandNameAlreadyExist = "Bu isimde marka var";
    }
}
