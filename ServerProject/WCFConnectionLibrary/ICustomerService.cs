﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerProject.DatabaseLayer;

namespace WCFConnectionLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        Scheduler getSchedulerByMovie(int movieID);

        
    }
}
