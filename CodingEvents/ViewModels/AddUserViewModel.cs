namespace SpaDay6;

public class AddUserViewModel
{
    [Required(ErrorMessage = "Username field is required.")]
    [StringLength (15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters.")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength (20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Verify password is required.")]
    [StringLength (20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
    public string? Verify { get; set; }   

    [EmailAddress]
    public string? Email { get; set; }


}