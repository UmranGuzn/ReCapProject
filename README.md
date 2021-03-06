# Re Cap Project
Araba Kiralama Sistemi | Kodlama.io
##  Introduction
  - Entities, DataAccess, Business ve Console katmanlarından oluşan araba kiralama projesdir.
  Car, Brand, Color, Customer, User ve Rental nesnelerinden ve onların operasyonlarından oluşan bu proje zamanla geliştirilecektir.
  
 ## Recent Changes
  ✔ WebAPI katmanı ekendi.
## Layers

**``Entities``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Brand.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/Concrete/Brand.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Car.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/Concrete/Car.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Color.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/Concrete/Color.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Customer.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/Concrete/Customer.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Rental.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/Concrete/Rental.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [User.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/Concrete/User.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DTOs`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CarDetailDto.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/DTOs/CarDetailDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [RentalDetailDto.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Entities/DTOs/RentalDetailDto.cs) <br><br>
**``DataAccess``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IBrandDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Abstract/IBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ICarDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IColorDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Abstract/IColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ICustomerDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Abstract/ICustomerDal.cs) <br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IRentalDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Abstract/IRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IUserDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Abstract/IUserDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [EfBrandDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [EfCarDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [EfColorDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [EfCustomerDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [EfRentalDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [EfUserDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``InMemory`` <br> 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [InMemoryCarDal.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryCarDal.cs) <br><br>

**``Business``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Constants`` <br><br>

**``Core``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DataAccess`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Entities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Utilities`` <br><br>

**``ConsolUI``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br><br>

**``WepAPI``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Controllers`` <br>
