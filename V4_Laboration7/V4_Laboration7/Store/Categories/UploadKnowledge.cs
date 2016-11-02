using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V4_Laboration7
{
    public class UploadKnowledge : Product
    {

        public int DataTransferTime { get; set; }

        public override string ProductParameterLabels()
        {
            return String.Format("{0,-20}{1}",
                base.ProductParameterLabels(),
                "Data Transfer Time (in minutes)");
        }

        public override string ProductParameterValues()
        {
            return String.Format("{0,-20}{1}",
                base.ProductParameterValues(),
                DataTransferTime);
        }

        public override string UniquePropertyString()
        {
            return " minutes (Data Transfer Time)";
        }
    }
}