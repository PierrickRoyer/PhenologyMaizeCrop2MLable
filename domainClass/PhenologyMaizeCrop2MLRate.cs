
using System;
using System.Collections.Generic;
using CRA.ModelLayer.Core;
using System.Reflection;
using CRA.ModelLayer.ParametersManagement;   

namespace PhenologyMaizeCrop2ML.DomainClass
{
    public class PhenologyMaizeCrop2MLRate : ICloneable, IDomainClass
    {
        private ParametersIO _parametersIO;

        public PhenologyMaizeCrop2MLRate()
        {
            _parametersIO = new ParametersIO(this);
        }

        public PhenologyMaizeCrop2MLRate(PhenologyMaizeCrop2MLRate toCopy, bool copyAll) // copy constructor 
        {
            if (copyAll)
            {
            }
        }

        public string Description
        {
            get { return "PhenologyRate of the component";}
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