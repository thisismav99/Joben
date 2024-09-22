namespace Joben_API.Models.Custom
{
    public class CustomRatingModel : BaseCustomModel
    {
        public int Rating { get; set; }

        public string? Remark { get; set; }

        public int UserID { get; set; }
    }
}
