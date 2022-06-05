using MHBrokerUtilities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.FileManagement
{
    public static class MasterFileFactory
    {
        public static IMasterFile GetNewMasterFile()
        {
            return new MasterFile();
        }
    }
}
