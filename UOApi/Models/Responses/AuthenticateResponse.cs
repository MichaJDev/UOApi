using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOApi.Entities.Users;

namespace UOApi.Models.Responses
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Username = user.Username;
            Token = token;
        }
    }
}
