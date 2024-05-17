namespace Udemy.JwtApp.Back.Onion.Application.Tools
{
    public class JwtTokenDefaults
    {
        /*
         * validaudience = "http://localhost",
        validıssuer = "http://localhost",
        clockskew = timespan.zero,
        ıssuersigningkey = new symmetricsecuritykey(encoding.utf8.getbytes("yiityiityiityiityiit1.")),
        validateıssuersigningkey = true,
        validatelifetime = true,
         */
        public const string ValidAudience = "http://localhost";
        public const string ValidIssuer = "http://localhost";
        public const string Key = "gtonpaqdrjıwgtonpaqdrjıwgtonpaqdrjıwgtonpaqdrjıwgtonpaqdrjıw";
        public const int Expire = 15;
    }
}
