using Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Hitachi_DotNet_Practical_Assignment.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SignIn(SignInDTO user);

        [OperationContract]
        string SignUp(SignUpDTO newUser);

        
    }

    
  
    
}
