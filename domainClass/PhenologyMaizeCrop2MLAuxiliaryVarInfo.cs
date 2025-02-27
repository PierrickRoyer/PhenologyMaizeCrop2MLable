
using System;
using System.Collections.Generic;
using CRA.ModelLayer.Core;
using System.Reflection;
using CRA.ModelLayer.ParametersManagement;   

namespace PhenologyMaizeCrop2ML.DomainClass
{
    public class PhenologyMaizeCrop2MLAuxiliaryVarInfo: IVarInfoClass
    {

        static PhenologyMaizeCrop2MLAuxiliaryVarInfo()
        {
            PhenologyMaizeCrop2MLAuxiliaryVarInfo.DescribeVariables();
        }

        public virtual string Description
        {
            get { return "PhenologyRate Domain class of the component"; }
        }

        public string URL
        {
            get { return "http://"; }
        }

        public string DomainClassOfReference
        {
            get { return "PhenologyRate"; }
        }

        static void DescribeVariables()
        {
        }

    }
}