namespace ProyectoToken.Models.Custom
{
    public class RefreshTokenRequest
    {
        public string TokenExpirado { get; set; }
        public string RefreshToken { get; set; }
    }
}
