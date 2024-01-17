﻿
namespace CleanMovie.Domain
{
    public class Member
    {
        public int MemberId { get; set; }
        public int RentalId { get; set; }       
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;   
        public Rental? Rental { get; set; }
    }
}
