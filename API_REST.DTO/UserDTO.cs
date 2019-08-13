using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_REST.DTO
{
    public class UserDTO : ResponseDTO
    {
        public int Iduser { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Rut { get; set; }
    }
}
