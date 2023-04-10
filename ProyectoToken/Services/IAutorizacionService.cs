using ProyectoToken.Models.Custom;

namespace ProyectoToken.Services
{
    public interface IAutorizacionService
    {

        Task<AutorizacionResponse> DevolverToken(AutorizacionRequest autorizacion);
        Task<AutorizacionResponse> DevolverRefreshToken(RefreshTokenRequest refreshTokenRequest, int idUsuario);
    }
}
