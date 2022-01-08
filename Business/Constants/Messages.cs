using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        public static string MaintenanceTime = "System is Under Maintenace!";

        //for the CarManager
        public static string CarAdded = "Car Added!";
        public static string CarNameInvalid = "Car Name Must be more than two letters!";
        public static string CarListed = "Cars are Listed!";
        public static string CarDeleted = "Car Deleted!";
        public static string CarUpdated = "Car Updated!";


        //for the Brandmanager
        public static string BrandAdded = "Brand Added!";
        public static string BrandNameInvalid = "Invalid Brand Name!";
        public static string BrandListed = "Brands are Listed!";
        public static string BrandDeleted = "Brand Deleted!";
        public static string BrandUpdated = "Brand Updated!";

        //for the ColorManager

        public static string ColorAdded = "Color Added!";
        public static string ColorDeleted = "Color Deleted!";
        public static string ColorUpdated = "Color Updated!";
        public static string ColorInvalid = "Color Invalid!";
        public static string ColorListed = "All Colors are Listed!";

        //for the CustomerManager


        public static string CustomerAdded = "Customer Added!";
        public static string CustomerDeleted = "Customer Deleted!";
        public static string CustomerUpdated = "Customer Updated!";
        public static string CustomerInvalid = "Invalid Customer!";
        public static string CustomerListed = "Customer Listed!";

        //for the RentalManager

        public static string RentalAdded = "Rental Added!";
        public static string RentalDeleted = "Rental Deleted!";
        public static string RentalUpdated = "Rental Updated!";
        public static string RentalInvalid = "Rental is Invalid!";
        public static string RentalListed = "Rentals are listed!";


        //for the UserManager

        public static string UserAdded = "User Added!";
        public static string UserDeleted = "User Deleted!";
        public static string UserUpdated = "User Updated!";
        public static string UserInvalid = "Invalid User!";
        public static string UserListed = "User Added!";
        
        //for the ImageUpload

        public static string ImageUploaded="The Image Added!";
        public static string ImageUploadFail = "Unable to Add Image!";
        public static string ImageDeleted = "The Image Deleted!";
        public static string ImageListed = "The Images Lİsted!";

        //for the user register

        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password incorrect";
        public static string SuccessfulLogin = "Login Success";
        public static string UserAlreadyExists = "User already exists!";
        public static string UserRegistered = "User registered!";
        public static string AccessTokenCreated = "Access token created";
        public static string AuthorizationDenied = "No Permission!";
    }
}
