using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class TokenModel
    {
        public string AccessToken { get; set; }
        public string EncryptedAccessToken { get; set; }
        public int ExpireInSeconds { get; set; }
        public long UserId { get; set; }

    }
}
