using Sys.DataBus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sys.Services.Drv.Emera3
{
    #region (class MsgTest)
    internal class MsgTest
    {
        public OperationResult OperationResult;
        public String Message;

        public MsgTest(OperationResult operationResult, String message = "")
        {
            this.OperationResult = operationResult;
            this.Message = message;
        }
    }
    #endregion

}
