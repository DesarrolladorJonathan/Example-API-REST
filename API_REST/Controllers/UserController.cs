using API_REST.BL;
using API_REST.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_REST.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public UserDTO GetUser(decimal idUser)
        {
            UserDTO userDTO = new UserDTO();
            UserBL userBL = new UserBL();
            userDTO = userBL.GetUser(idUser);
            return userDTO;
        }

        [HttpPost]
        public ResponseDTO LoginUser(UserDTO userDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO();
            UserBL userBL = new UserBL();
            responseDTO = userBL.LoginUser(userDTO);
            return responseDTO;
        }

        [HttpPost]
        public ResponseDTO InsertUser(UserDTO userDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO();
            UserBL userBL = new UserBL();
            responseDTO = userBL.InsertUser(userDTO);
            return responseDTO;
        }
    }
}
