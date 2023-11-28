using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiUniversidade.DTO
{
    public class UsuarioDTO
    {
        public String? Email { get; set; }

        public String? Password { get; set; }

        public String? ConfirmPassword { get; set; }
    }
}