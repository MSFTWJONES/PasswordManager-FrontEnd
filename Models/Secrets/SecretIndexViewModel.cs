using System;

namespace keyvault.web
{
    public class SecretIndexViewModel : SecretViewModel
    {
        public string vaultUri { get; set; }
        public DateTime updatedOn { get; set; }
        
    }
}