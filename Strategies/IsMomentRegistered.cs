using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhenologyMaizeCrop2ML.API;
using PhenologyMaizeCrop2ML.DomainClass;
using CRA.ModelLayer.MetadataTypes;
using CRA.ModelLayer.Core;
using CRA.ModelLayer.Strategy;
using VarInfo = CRA.ModelLayer.Core.VarInfo;
using Preconditions = CRA.ModelLayer.Core.Preconditions;


namespace PhenologyMaizeCrop2ML.Strategies
{
    class IsMomentRegistered : PhenologyCrop2MLiStrategy
    {
        //_____________________________________________________________________//
        //Param Initialisation; Parm varInfo, post & pre conditions crteated but empty;
        //_____________________________________________________________________//                                                      

        public IsMomentRegistered()
        {
            ModellingOptions mo0_0 = new ModellingOptions();
            //Parameters
            List<VarInfo> _parameters0_0 = new List<VarInfo>();
            mo0_0.Parameters = _parameters0_0;

            //Inputs
            List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
            PropertyDescription pd1 = new PropertyDescription();
            pd1.DomainClassType = typeof(PhenologyMaizeCrop2ML.DomainClass.PhenologyMaizeCrop2MLState);
            pd1.PropertyName = "calendarMoments";
            pd1.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments).ValueType.TypeForCurrentValue;
            pd1.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
            _inputs0_0.Add(pd1);


            PropertyDescription pd2 = new PropertyDescription();
            pd2.DomainClassType = typeof(PhenologyMaizeCrop2ML.DomainClass.PhenologyMaizeCrop2MLState);
            pd2.PropertyName = "calendarDates";
            pd2.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates).ValueType.TypeForCurrentValue;
            pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
            _inputs0_0.Add(pd2);

            PropertyDescription pd3 = new PropertyDescription();
            pd3.DomainClassType = typeof(PhenologyMaizeCrop2ML.DomainClass.PhenologyMaizeCrop2MLState);
            pd3.PropertyName = "calendarCumuls";
            pd3.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls).ValueType.TypeForCurrentValue;
            pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
            _inputs0_0.Add(pd3);

            PropertyDescription pd0 = new PropertyDescription();
            pd0.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd0.PropertyName = "cumulTT";
            pd0.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTT)).ValueType.TypeForCurrentValue;
            pd0.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
            _inputs0_0.Add(pd0);

            mo0_0.Inputs = _inputs0_0;

            //Outputs
            List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
            PropertyDescription pd4 = new PropertyDescription();
            pd4.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd4.PropertyName = "isMomentRegistredBBCH_1n";
            pd4.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.isMomentRegistredBBCH_1n).ValueType.TypeForCurrentValue;
            pd4.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.isMomentRegistredBBCH_1n);
            _outputs0_0.Add(pd4);

            PropertyDescription pd5 = new PropertyDescription();
            pd5.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd5.PropertyName = "cumulTTFromBBCH_63";
            pd5.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_63).ValueType.TypeForCurrentValue;
            pd5.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_63);
            _outputs0_0.Add(pd5);

            PropertyDescription pd6 = new PropertyDescription();
            pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd6.PropertyName = "cumulTTFromBBCH_1n";
            pd6.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_1n).ValueType.TypeForCurrentValue;
            pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_1n);
            _outputs0_0.Add(pd6);


            PropertyDescription pd7 = new PropertyDescription();
            pd7.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd7.PropertyName = "cumulTTFromLastLeaf";
            pd7.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromLastLeaf).ValueType.TypeForCurrentValue;
            pd7.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromLastLeaf);
            _outputs0_0.Add(pd7);

            pd1.DomainClassType = typeof(PhenologyMaizeCrop2ML.DomainClass.PhenologyMaizeCrop2MLState);
            pd1.PropertyName = "calendarMoments";
            pd1.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments).ValueType.TypeForCurrentValue;
            pd1.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
            _outputs0_0.Add(pd1);


            PropertyDescription pd2 = new PropertyDescription();
            pd2.DomainClassType = typeof(PhenologyMaizeCrop2ML.DomainClass.PhenologyMaizeCrop2MLState);
            pd2.PropertyName = "calendarDates";
            pd2.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates).ValueType.TypeForCurrentValue;
            pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
            _outputs0_0.Add(pd2);

            PropertyDescription pd3 = new PropertyDescription();
            pd3.DomainClassType = typeof(PhenologyMaizeCrop2ML.DomainClass.PhenologyMaizeCrop2MLState);
            pd3.PropertyName = "calendarCumuls";
            pd3.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls).ValueType.TypeForCurrentValue;
            pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
            _outputs0_0.Add(pd3);


            mo0_0.Outputs = _outputs0_0;
            //Associated strategies
            List<string> lAssStrat0_0 = new List<string>();
            mo0_0.AssociatedStrategies = lAssStrat0_0;
            //Adding the modeling options to the modeling options manager
            _modellingOptionsManager = new ModellingOptionsManager(mo0_0);
            SetStaticParametersVarInfoDefinitions();
            SetPublisherData();

        }

        #region Implementation of IAnnotatable

        /// <summary>
        /// Description of the model
        /// </summary>
        public string Description
        {
            get { return "unitModel calculating TT cumulated to certain stages based on current pheno stage"; }
        }

        /// <summary>
        /// URL to access the description of the model
        /// </summary>
        public string URL
        {
            get { return "http://biomamodelling.org"; }
        }

        #endregion

        #region Implementation of IStrategy

        /// <summary>
        /// Domain of the model.
        /// </summary>
        public string Domain
        {
            get { return "Crop"; }
        }

        /// <summary>
        /// Type of the model.
        /// </summary>
        public string ModelType
        {
            get { return "Development"; }
        }

        /// <summary>
        /// Declare if the strategy is a ContextStrategy, that is, it contains logic to select a strategy at run time. 
        /// </summary>
        public bool IsContext
        {
            get { return false; }
        }

        /// <summary>
        /// Timestep to be used with this strategy
        /// </summary>
        public IList<int> TimeStep
        {
            get
            {
                IList<int> ts = new List<int>();

                return ts;
            }
        }

        #endregion

        #region Publisher Data

        private PublisherData _pd;
        private void SetPublisherData()
        {
            // Set publishers' data

            _pd = new CRA.ModelLayer.MetadataTypes.PublisherData();
            _pd.Add("Creator", "loic.manceau@inra.fr");
            _pd.Add("Date", "22/06/2020");
            _pd.Add("Publisher", "INRA");
        }

        public PublisherData PublisherData
        {
            get { return _pd; }
        }

        #endregion

        /// <summary>
        /// Return the types of the domain classes used by the strategy
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Type> GetStrategyDomainClassesTypes()
        {
            return new List<Type>() { typeof(PhenologyMaizeCrop2MLState), typeof(PhenologyMaizeCrop2MLState), typeof(PhenologyMaizeCrop2MLRate), typeof(PhenologyMaizeCrop2MLAuxiliary), typeof(PhenologyMaizeCrop2MLExogenous) };
        }

        #region ModellingOptionsManager

        private ModellingOptionsManager _modellingOptionsManager;

        public ModellingOptionsManager ModellingOptionsManager
        {
            get { return _modellingOptionsManager; }
        }

        #endregion

        #region Parameters initialization method

        /// <summary>
        /// Set parameter(s) current values to the default value
        /// </summary>
        public void SetParametersDefaultValue()
        {
            _modellingOptionsManager.SetParametersDefaultValue();


            //GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section5
            //Code written below will not be overwritten by a future code generation

            //Custom initialization of the parameter. E.g. initialization of the array dimensions of array parameters

            //End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
            //PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section5 
        }

        #endregion

        #region Static parameters VarInfo definition

        // Define the properties of the static VarInfo of the parameters
        private static void SetStaticParametersVarInfoDefinitions()
        {
            
        }

        #endregion

        public string TestPostConditions(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex, string callID)
        {
            try
            {
                //Set current values of the outputs to the static VarInfo representing the output properties of the domain classes
                PhenologyMaizeCrop2MLStateVarInfo.isMomentRegistredBBCH_1n.CurrentValue = s.isMomentRegistredBBCH_1n;
                PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_63.CurrentValue = s.cumulTTFromBBCH_63;
                PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_1n.CurrentValue = s.cumulTTFromBBCH_1n;
                PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromLastLeaf.CurrentValue = s.cumulTTFromLastLeaf;

                ConditionsCollection prc = new ConditionsCollection();
                Preconditions pre = new Preconditions();
                RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.isMomentRegistredBBCH_1n);
                if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.isMomentRegistredBBCH_1n.ValueType)) { prc.AddCondition(r7); }
                RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_63);
                if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_63.ValueType)) { prc.AddCondition(r8); }
                RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_1n);
                if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromBBCH_1n.ValueType)) { prc.AddCondition(r9); }

                RangeBasedCondition r10 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromLastLeaf);
                if (r10.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromLastLeaf.ValueType)) { prc.AddCondition(r10); }

                string postConditionsResult = pre.VerifyPostconditions(prc, callID); if (!string.IsNullOrEmpty(postConditionsResult)) { pre.TestsOut(postConditionsResult, true, "PostConditions errors in strategy " + this.GetType().Name); }
                return postConditionsResult;
            }
            catch (Exception exception)
            {
                string msg = ".Phenology, " + this.GetType().Name + ": Unhandled exception running post-condition test. ";
                throw new Exception(msg, exception);
            }
        }

        /// <summary>
        /// Test to verify the preconditions
        /// </summary>
        public string TestPreConditions(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex, string callID)
        {
            try
            {
                //Set current values of the inputs to the static VarInfo representing the inputs properties of the domain classes

                PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.CurrentValue = s.calendarMoments;
                PhenologyMaizeCrop2MLStateVarInfo.calendarDates.CurrentValue = s.calendarDates;
                PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.CurrentValue = s.calendarCumuls;
                PhenologyMaizeCrop2MLStateVarInfo.cumulTT.CurrentValue = s.cumulTT;

                ConditionsCollection prc = new ConditionsCollection();
                Preconditions pre = new Preconditions();
               
                RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
                if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.ValueType)) { prc.AddCondition(r2); }
                RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
                if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarDates.ValueType)) { prc.AddCondition(r3); }
                RangeBasedCondition r4 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
                if (r4.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.ValueType)) { prc.AddCondition(r4); }

                RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
                if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r1); }


                string preConditionsResult = pre.VerifyPreconditions(prc, callID); if (!string.IsNullOrEmpty(preConditionsResult)) { pre.TestsOut(preConditionsResult, true, "PreConditions errors in strategy " + this.GetType().Name); }
                return preConditionsResult;
            }
            catch (Exception exception)
            {
                string msg = ".Phenology, " + this.GetType().Name + ": Unhandled exception running pre-condition test. ";
                throw new Exception(msg, exception);
            }
        }



        public void Estimate(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
        {

            CalculateModel(s, s1, r, a, ex);
        }
        
        private void CalculateModel(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
        {
            // modele unitaire rajouté pour avoir un modèle composite avec juste une pile d'appel
            double cumulTT6 = s.cumulTT[6];
            List<string> calendarMoments_t1 = s1.calendarMoments;
            List<DateTime> calendarDates_t1 = s1.calendarDates;
            List<double> calendarCumuls_t1 = s1.calendarCumuls;


            double cumulTTFromBBCH_63 = 0.0 ;
            double cumulTTFromBBCH_1n = 0.0;
            double cumulTTFromLastLeaf = 0.0;
            int isMomentRegistredBBCH_1n = 0;


            if (cumulTT6 > 0)
            {
               

                if (calendarMoments_t1.Contains("FlagLeafLiguleJustVisible")) isMomentRegistredBBCH_1n = 1;
                else isMomentRegistredBBCH_1n = 0;

                if (calendarMoments_t1.Contains("Anthesis"))
                {

                    int indexAnth = calendarMoments_t1.IndexOf("Anthesis");
                    cumulTTFromBBCH_63 = cumulTT6 - calendarCumuls_t1[indexAnth];

                }
                if (calendarMoments_t1.Contains("FlagLeafLiguleJustVisible"))
                {

                    int indexFlagLeaf  = calendarMoments_t1.IndexOf("FlagLeafLiguleJustVisible");
                    cumulTTFromBBCH_1n = cumulTT6 - calendarCumuls_t1[indexFlagLeaf];

                }
                if (calendarMoments_t1.Contains("LastLeafVisible"))
                {

                    int indexLastLeaf = calendarMoments_t1.IndexOf("LastLeafVisible");
                    cumulTTFromLastLeaf = cumulTT6 - calendarCumuls_t1[indexLastLeaf];
                }



            }
            s.cumulTTFromBBCH_63 = cumulTTFromBBCH_63;
            s.cumulTTFromBBCH_1n = cumulTTFromBBCH_1n;
            s.cumulTTFromLastLeaf = cumulTTFromLastLeaf;
            s.isMomentRegistredBBCH_1n = isMomentRegistredBBCH_1n;
            s.calendarMoments = calendarMoments_t1;
            s.calendarCumuls = calendarCumuls_t1;
            s.calendarDates = calendarDates_t1;

        }
/*        public void Init(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
        {
            
            s1.calendarMoments.Add("Sowing");
            s1.calendarCumuls.Add(0.0);
            s1.calendarDates.Add(s.currentdate);

        }
*/

    }
}
