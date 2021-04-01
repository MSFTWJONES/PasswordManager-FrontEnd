using System;

namespace keyvault.web
{
    public class SecretDetailsViewModel : SecretViewModel
    {

        public SecretPropertiesModel Properties { get; set; }      
    }

    public class SecretPropertiesModel
    {
        public string id { get; set; }
        public string vaultUri { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string contentType { get; set; }
        public bool managed { get; set; }
        public string keyId { get; set; }
        public bool enabled { get; set; }
        public string notBefore { get; set; }
        public string expiresOn { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }
        public int recoverableDays { get; set; }
        public string recoveryLevel { get; set; }
        
    }
}