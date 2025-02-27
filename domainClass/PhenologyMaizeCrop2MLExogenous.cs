
using System;
using System.Collections.Generic;
using CRA.ModelLayer.Core;
using System.Reflection;
using CRA.ModelLayer.ParametersManagement;   

namespace PhenologyMaizeCrop2ML.DomainClass
{
    public class PhenologyMaizeCrop2MLExogenous : ICloneable, IDomainClass
    {
        private ParametersIO _parametersIO;

        public PhenologyMaizeCrop2MLExogenous()
        {
            _parametersIO = new ParametersIO(this);
        }

        public PhenologyMaizeCrop2MLExogenous(PhenologyMaizeCrop2MLExogenous toCopy, bool copyAll) // copy constructor 
        {
            if (copyAll)
            {
            }
        }

        public string Description
        {
            get { return "PhenologyExogenous of the component";}
        }

        public string URL
        {
            get { return "http://" ;}
        }

        public virtual IDictionary<string, PropertyInfo> PropertiesDescription
        {
            get { return _parametersIO.GetCachedProperties(typeof(IDomainClass));}
        }

        public virtual Boolean ClearValues()
        {
            return true;
        }

        public virtual Object Clone()
        {
            IDomainClass myclass = (IDomainClass) this.MemberwiseClone();
            _parametersIO.PopulateClonedCopy(myclass);
            return myclass;
        }
    }
}