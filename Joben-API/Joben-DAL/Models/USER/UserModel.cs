﻿using Joben_DAL.Models.RATING;
using Joben_DAL.Models.USER.MISC;

namespace Joben_DAL.Models.USER
{
    public class UserModel : BaseModel
    {
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public int GenderID { get; set; }

        public int CivilStatusID { get; set; }

        public int PositionID { get; set; }

        public virtual GenderModel? Gender { get; set; }

        public virtual CivilStatusModel? CivilStatus { get; set; }

        public virtual PositionModel? Position { get; set; }
    }
}
