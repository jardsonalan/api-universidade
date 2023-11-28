using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiUniversidade.DTO
{
    public class UsuarioToken
    {
        public bool Authenticated { get; set; }

        public DateTime Expiration { get; set; }

        public String? Token { get; set; }

        public String? Message { get; set; }
    }
}