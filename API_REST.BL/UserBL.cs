using API_REST.DATA;
using API_REST.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_REST.BL
{
    public class UserBL
    {
        public UserDTO GetUser(decimal idUser)
        {
            UserDTO userDTO = new UserDTO();
            UserDAO userDAO = new UserDAO();
            userDTO = userDAO.GetUser(idUser);
            return userDTO;
        }

        public ResponseDTO LoginUser(UserDTO userDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO();
            UserDAO userDAO = new UserDAO();
            responseDTO = userDAO.LoginUser(userDTO);
            return responseDTO;
        }

        public ResponseDTO InsertUser(UserDTO userDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO();
            UserDAO userDAO = new UserDAO();
            responseDTO = userDAO.InsertUser(userDTO);
            return responseDTO;
        }
    }
}
