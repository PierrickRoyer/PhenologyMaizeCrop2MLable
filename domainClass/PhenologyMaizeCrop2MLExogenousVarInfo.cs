
using System;
using System.Collections.Generic;
using CRA.ModelLayer.Core;
using System.Reflection;
using CRA.ModelLayer.ParametersManagement;   

namespace PhenologyMaizeCrop2ML.DomainClass
{
    public class PhenologyMaizeCrop2MLExogenousVarInfo : IVarInfoClass
    {

        static PhenologyMaizeCrop2MLExogenousVarInfo()
        {
            PhenologyMaizeCrop2MLExogenousVarInfo.DescribeVariables();
        }

        public virtual string Description
        {
            get { return "PhenologyExogenous Domain class of the component";}
        }

        public string URL
        {
            get { return "http://" ;}
        }

        public string DomainClassOfReference
        {
            get { return "PhenologyExogenous";}
        }

        static void DescribeVariables()
        {
        }

    }
}