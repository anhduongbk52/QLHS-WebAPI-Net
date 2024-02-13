namespace QLHS_WEB_API.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
    }
}
