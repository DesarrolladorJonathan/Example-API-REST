using API_REST.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_REST.DATA
{
    public class UserDAO
    {
        public UserDTO GetUser(decimal idUser)
        {
            UserDTO userDTO = new UserDTO();
            try
            {
                using (db_PruebaEntities db_PruebaEntities = new db_PruebaEntities())
                {
                    var getuser = db_PruebaEntities.SP_GET_USER(idUser).ToList();
                    if (getuser.Count() > 0)
                    {
                        var Datauser = getuser.FirstOrDefault();
                        userDTO = new UserDTO()
                        {
                            Iduser = Datauser.ID_USUARIO,
                            Email = Datauser.EMAIL,
                            Name = Datauser.NOMBRE,
                            Pass = Datauser.CONTRASENA,
                            Rol = Datauser.ROL,
                            Rut = Datauser.RUT
                        };
                        userDTO.code = 0;
                        userDTO.message = "OK";
                    }
                    else
                    {
                        userDTO.code = 998;
                        userDTO.message = "Usuario No encontrado";
                    }

                }
            }
            catch (Exception ex)
            {
                userDTO.code = 999;
                userDTO.message = String.Concat("Se cayo la wea", ex.Message.ToString());
            }
            return userDTO;
        }

        public ResponseDTO LoginUser(UserDTO userDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO();
            try
            {
                using (db_PruebaEntities db_PruebaEntities = new db_PruebaEntities())
                {
                    var getuser = db_PruebaEntities.SP_LOGIN_USER(userDTO.Rut, userDTO.Pass).ToList();
                    if (getuser.Count() > 0)
                    {
                        responseDTO.code = 0;
                        responseDTO.message = "OK";
                    }
                    else
                    {
                        responseDTO.code = 998;
                        responseDTO.message = "Usuario No encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                responseDTO.code = 999;
                responseDTO.message = String.Concat("Se cayo la wea", ex.Message.ToString());
            }
            return responseDTO;
        }

        public ResponseDTO InsertUser(UserDTO userDTO)
        {
            ResponseDTO responseDTO = new ResponseDTO();
            try
            {
                using (db_PruebaEntities db_PruebaEntities = new db_PruebaEntities())
                {
                    var getuser = db_PruebaEntities.SP_INSERT_USER(userDTO.Name, userDTO.Rol, userDTO.Pass, userDTO.Email, userDTO.Rut);
                    if (getuser == 1)
                    {
                        responseDTO.code = 0;
                        responseDTO.message = "OK";
                    }
                    else
                    {
                        responseDTO.code = 998;
                        responseDTO.message = "A ocurrido un error al intentar ingresar el Usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                responseDTO.code = 999;
                responseDTO.message = String.Concat("Se cayo la wea", ex.Message.ToString());
            }
            return responseDTO;
        }
    }
}
