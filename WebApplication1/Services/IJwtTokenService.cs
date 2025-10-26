namespace DotnetcoreMVCWithAuthentication.Services
{
    public interface IJwtTokenService
    {
        string GenerateToken(string username);
    }
}