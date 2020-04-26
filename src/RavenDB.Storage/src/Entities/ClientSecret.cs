namespace IdentityServer4.RavenDB.Entities
{
    public class ClientSecret : Secret
    {
        public string ClientId { get; set; }
    }
}
