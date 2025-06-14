using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.Models
{
    public class JwtResponseModel
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
