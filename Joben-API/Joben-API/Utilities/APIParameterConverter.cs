using Joben_API.Models.Custom;
using Joben_DAL.Models.RATING;
using Joben_DAL.Models.USER;

namespace Joben_API.Utilities
{
    public static class APIParameterConverter
    {
        public static UserModel ConvertUserModel(CustomUserModel customUserModel)
        {
            var userModel = new UserModel()
            {
                ID = customUserModel.ID,
                FirstName = customUserModel.FirstName,
                MiddleName = customUserModel.MiddleName,
                LastName = customUserModel.LastName,
                Email = customUserModel.Email,
                PhoneNumber = customUserModel.PhoneNumber,
                GenderID = customUserModel.GenderID,
                CivilStatusID = customUserModel.CivilStatusID,
                PositionID = customUserModel.PositionID,
                IsActive = customUserModel.IsActive,
                UpdatedBy = customUserModel.UpdatedBy,
                UpdatedOn = customUserModel.UpdatedOn,
                CreatedBy = customUserModel.CreatedBy,
                CreatedOn = customUserModel.CreatedOn
            };

            return userModel;
        }

        public static AddressModel ConvertAddressModel(CustomAddressModel customAddressModel)
        {
            var addressModel = new AddressModel()
            {
                ID = customAddressModel.ID,
                Street = customAddressModel.Street,
                Barangay = customAddressModel.Barangay,
                City = customAddressModel.City,
                Region = customAddressModel.Region,
                PostalCode = customAddressModel.PostalCode,
                Country = customAddressModel.Country,
                IsActive = customAddressModel.IsActive,
                UpdatedBy = customAddressModel.UpdatedBy,
                UpdatedOn = customAddressModel.UpdatedOn,
                CreatedBy = customAddressModel.CreatedBy,
                CreatedOn = customAddressModel.CreatedOn
            };

            return addressModel;
        }

        public static RatingModel ConvertRatingModel(CustomRatingModel customRatingModel)
        {
            var ratingModel = new RatingModel()
            {
                ID = customRatingModel.ID,
                Rating = customRatingModel.Rating,
                Remark = customRatingModel.Remark,
                UserID = customRatingModel.UserID,
                IsActive = customRatingModel.IsActive,
                UpdatedBy = customRatingModel.UpdatedBy,
                UpdatedOn = customRatingModel.UpdatedOn,
                CreatedBy = customRatingModel.CreatedBy,
                CreatedOn = customRatingModel.CreatedOn
            };

            return ratingModel;
        }
    }
}
