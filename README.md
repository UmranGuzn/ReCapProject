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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IBrandService.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ICarService.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Abstract/ICarService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IColorService.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Abstract/IColorService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ICustomerService.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IRentalService.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IUserService.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [BrandManager.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Concrete/BrandManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CarManager.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Concrete/CarManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ColorManager.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Concrete/ColorManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CustomerManager.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Concrete/CustomerManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [RentalManager.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Concrete/RentalManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [UserManager.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Concrete/UserManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Constants`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Messages.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Business/Constants/Messages.cs) <br>
<br>

**``Core``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DataAccess`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [EfEntityRepositoryBase.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IEntityRepository.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/DataAccess/IEntityRepository.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Entities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IDto.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Entities/IDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IEntity.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Entities/IEntity.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Utilities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Result`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [DataResult.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/DataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ErrorDataResult.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/ErrorDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ErrorResult.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/ErrorResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IDataResult.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/IDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [IResult.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/IResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [Result.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/Result.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [SuccessDataResult.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/SuccessDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [SuccessResult.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/Core/Utilities/Results/v.cs) <br>
<br><br>
**``ConsolUI``**<br>
<br>
**``WepAPI``**<br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Controllers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [BrandsController.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/WebAPI/Controllers/BrandsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CarsController.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/WebAPI/Controllers/CarsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ColorsController.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/WebAPI/Controllers/ColorsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CustomersController.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/WebAPI/Controllers/CustomersController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [RentalsController.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/WebAPI/Controllers/RentalsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [UsersController.cs](https://github.com/UmranGuzn/ReCapProject/blob/master/WebAPI/Controllers/UsersController.cs) <br>
