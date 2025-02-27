using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using CRA.ModelLayer.MetadataTypes;
using CRA.ModelLayer.Core;
using CRA.ModelLayer.Strategy;
using System.Reflection;
using VarInfo = CRA.ModelLayer.Core.VarInfo;
using Preconditions = CRA.ModelLayer.Core.Preconditions;
using PhenologyMaizeCrop2ML.API;
using PhenologyMaizeCrop2ML.DomainClass;


namespace PhenologyMaizeCrop2ML.Strategies
{
    class UpdateCalendar : PhenologyCrop2MLiStrategy
    {
        public UpdateCalendar()
        {
            ModellingOptions mo0_0 = new ModellingOptions();
            //Parameters
            List<VarInfo> _parameters0_0 = new List<VarInfo>();
            mo0_0.Parameters = _parameters0_0;

            //Inputs
            List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
            PropertyDescription pd1 = new PropertyDescription();
            pd1.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd1.PropertyName = "cumulTT";
            pd1.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.cumulTT).ValueType.TypeForCurrentValue;
            pd1.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
            _inputs0_0.Add(pd1);
            PropertyDescription pd2 = new PropertyDescription();
            pd2.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd2.PropertyName = "calendarMoments";
            pd2.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments).ValueType.TypeForCurrentValue;
            pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
            _inputs0_0.Add(pd2);
            PropertyDescription pd3 = new PropertyDescription();
            pd3.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd3.PropertyName = "calendarDates";
            pd3.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates).ValueType.TypeForCurrentValue;
            pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
            _inputs0_0.Add(pd3);
            PropertyDescription pd4 = new PropertyDescription();
            pd4.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd4.PropertyName = "calendarCumuls";
            pd4.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls).ValueType.TypeForCurrentValue;
            pd4.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
            _inputs0_0.Add(pd4);
            PropertyDescription pd5 = new PropertyDescription();
            pd5.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd5.PropertyName = "currentdate";
            pd5.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.currentdate).ValueType.TypeForCurrentValue;
            pd5.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.currentdate);
            _inputs0_0.Add(pd5);
            PropertyDescription pd6 = new PropertyDescription();
            pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd6.PropertyName = "phase";
            pd6.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.phase).ValueType.TypeForCurrentValue;
            pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.phase);
            _inputs0_0.Add(pd6);
            mo0_0.Inputs = _inputs0_0;


            List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
            PropertyDescription pd8 = new PropertyDescription();
            pd8.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd8.PropertyName = "calendarMoments";
            pd8.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments).ValueType.TypeForCurrentValue;
            pd8.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
            _outputs0_0.Add(pd8);
            PropertyDescription pd9 = new PropertyDescription();
            pd9.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd9.PropertyName = "calendarDates";
            pd9.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates).ValueType.TypeForCurrentValue;
            pd9.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
            _outputs0_0.Add(pd9);
            PropertyDescription pd10 = new PropertyDescription();
            pd10.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
            pd10.PropertyName = "calendarCumuls";
            pd10.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls).ValueType.TypeForCurrentValue;
            pd10.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
            _outputs0_0.Add(pd10);


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
            get { return "triggers germination"; }
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
            _pd.Add("Creator", "lucille.roux@inrae.fr");
            _pd.Add("Date", "24/08/2020");
            _pd.Add("Publisher", "INRAE");
        }

        public PublisherData PublisherData
        {
            get { return _pd; }
        }

        #endregion

        #region ModellingOptionsManager

        private ModellingOptionsManager _modellingOptionsManager;

        public ModellingOptionsManager ModellingOptionsManager
        {
            get { return _modellingOptionsManager; }
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


        public void SetParametersDefaultValue()
        {
            _modellingOptionsManager.SetParametersDefaultValue();
        }

        private static void SetStaticParametersVarInfoDefinitions()
        {
        }

        public string TestPostConditions(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex, string callID)
        {
            try
            {
                //Set current values of the outputs to the static VarInfo representing the output properties of the domain classes
                PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.CurrentValue = s.calendarMoments;
                PhenologyMaizeCrop2MLStateVarInfo.calendarDates.CurrentValue = s.calendarDates;
                PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.CurrentValue = s.calendarCumuls;
                ConditionsCollection prc = new ConditionsCollection();
                Preconditions pre = new Preconditions();
                RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
                if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.ValueType)) { prc.AddCondition(r7); }
                RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
                if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarDates.ValueType)) { prc.AddCondition(r8); }
                RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
                if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.ValueType)) { prc.AddCondition(r9); }
                string postConditionsResult = pre.VerifyPostconditions(prc, callID); if (!string.IsNullOrEmpty(postConditionsResult)) { pre.TestsOut(postConditionsResult, true, "PostConditions errors in strategy " + this.GetType().Name); }
                return postConditionsResult;
            }
            catch (Exception exception)
            {
                string msg = ".Phenology, " + this.GetType().Name + ": Unhandled exception running post-condition test. ";
                throw new Exception(msg, exception);
            }
        }

        public string TestPreConditions(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex, string callID)
        {
            try
            {
                //Set current values of the inputs to the static VarInfo representing the inputs properties of the domain classes
                PhenologyMaizeCrop2MLStateVarInfo.cumulTT.CurrentValue = s.cumulTT;
                PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.CurrentValue = s.calendarMoments;
                PhenologyMaizeCrop2MLStateVarInfo.calendarDates.CurrentValue = s.calendarDates;
                PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.CurrentValue = s.calendarCumuls;
                PhenologyMaizeCrop2MLStateVarInfo.currentdate.CurrentValue = s.currentdate;
                PhenologyMaizeCrop2MLStateVarInfo.phase.CurrentValue = s.phase;
                ConditionsCollection prc = new ConditionsCollection();
                Preconditions pre = new Preconditions();
                RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
                if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r1); }
                RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
                if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.ValueType)) { prc.AddCondition(r2); }
                RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
                if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarDates.ValueType)) { prc.AddCondition(r3); }
                RangeBasedCondition r4 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
                if (r4.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.ValueType)) { prc.AddCondition(r4); }
                RangeBasedCondition r5 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.currentdate);
                if (r5.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.currentdate.ValueType)) { prc.AddCondition(r5); }
                RangeBasedCondition r6 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.phase);
                if (r6.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.phase.ValueType)) { prc.AddCondition(r6); }
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
            try
            {
                CalculateModel(s, s1, r, a, ex);
            }
            catch (Exception exception)
            {
                string msg = "Error in component Phenology, strategy: " + this.GetType().Name + ": Unhandled exception running model. " + exception.GetType().FullName + " - " + exception.Message;
                throw new Exception(msg, exception);
            }
        }
        public String PreviousMoment(PhenologyMaizeCrop2MLState s)
        {
            if (s.phase < 0)
            {
                return "Unknown";
            }
            else if (s.phase >= 0 && s.phase< 1)//SowingToEmergence
            {
                return "Sowing";
            }
            else if (s.phase >= 1 && s.phase < 2)//EmergenceToFloralInitiation
            {
                return "Emergence";
            }
            else if (s.phase >= 2 && s.phase < 3)//FloralInitiationToAnthesis
            {
                return "FloralInitiation";
            }
            else if (s.phase >= 3 && s.phase< 4)//FloralInitiationToAnthesis
            {
                return "PanicleVisible";
            }
            else if (s.phase == 4)//AnthesisToEndCellDivision
            {
                return "Anthesis";
            }
            else if (s.phase == 4.5)//EndCellDivisionToEndGrainFill
            {
                return "EndCellDivision";
            }
            else if (s.phase >= 5 && s.phase< 6)//EndGrainFillToMaturity
            {
                return "Maturity";
            }
            else if (s.phase >= 6 && s.phase< 7)//AllOver
            {
                return "Maturity";
            }
            else
            {
                throw new InvalidOperationException();
            }

        }
        private void CalculateModel(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
        {
            double cumulTT_day = s.cumulTT[6];
            double phase = s.phase;

            List<string> calendarMoments = s.calendarMoments;
            List<DateTime> calendarDates = s.calendarDates;
            List<double> calendarCumuls = s.calendarCumuls;
            DateTime currentdate = s.currentdate;

            if (phase >= 1.0d && phase < 2.0d && !calendarMoments.Contains("Emergence"))
            {
                calendarMoments.Add("Emergence");
                calendarCumuls.Add(cumulTT_day);
                calendarDates.Add(currentdate);
            }
            else if (phase >= 2.0d && phase < 3.0d && !calendarMoments.Contains("FloralInitiation"))
            {
                calendarMoments.Add("FloralInitiation");
                calendarCumuls.Add(cumulTT_day);
                calendarDates.Add(currentdate);
            }
            else if (phase >= 3.0d && phase < 4.0d && !calendarMoments.Contains("PanicleVisible"))
            {
                calendarMoments.Add("PanicleVisible");
                calendarCumuls.Add(cumulTT_day);
                calendarDates.Add(currentdate);
            }
            else if (phase == 4.0d && !calendarMoments.Contains("Anthesis"))
            {
                calendarMoments.Add("Anthesis");
                calendarCumuls.Add(cumulTT_day);
                calendarDates.Add(currentdate);
            }
            else if (phase == 4.5d && !calendarMoments.Contains("EndCellDivision"))
            {
                calendarMoments.Add("EndCellDivision");
                calendarCumuls.Add(cumulTT_day);
                calendarDates.Add(currentdate);
            }
            else if (phase >= 5.0d && phase < 6.0d && !calendarMoments.Contains("EndGrainFilling"))
            {
                calendarMoments.Add("EndGrainFilling");
                calendarCumuls.Add(cumulTT_day);
                calendarDates.Add(currentdate);
            }
            else if (phase >= 6.0d && phase < 7.0d && !calendarMoments.Contains("Maturity"))
            {
                calendarMoments.Add("Maturity");
                calendarCumuls.Add(cumulTT_day);
                calendarDates.Add(currentdate);
            }
            s.calendarMoments = calendarMoments;
            s.calendarDates = calendarDates;
            s.calendarCumuls = calendarCumuls;
        }
    }
}
