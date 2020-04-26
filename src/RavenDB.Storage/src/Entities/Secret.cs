using System;

namespace IdentityServer4.RavenDB.Entities
{
    public abstract class Secret
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }

        public DateTime? Expiration { get; set; }

        public string Type { get; set; } = "SharedSecret";

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
