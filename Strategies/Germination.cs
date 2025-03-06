using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using CRA.ModelLayer.MetadataTypes;
using CRA.ModelLayer.Core;
using CRA.ModelLayer.Strategy;
using System.Reflection;
using VarInfo=CRA.ModelLayer.Core.VarInfo;
using Preconditions=CRA.ModelLayer.Core.Preconditions;
using PhenologyMaizeCrop2ML.API;
using PhenologyMaizeCrop2ML.DomainClass;

namespace PhenologyMaizeCrop2ML.Strategies
{
    class Germination : PhenologyCrop2MLiStrategy
	{

		public Germination()
		{

			ModellingOptions mo0_0 = new ModellingOptions();
			//Parameters
			List<VarInfo> _parameters0_0 = new List<VarInfo>();
			VarInfo v1 = new VarInfo();
			v1.DefaultValue = -10;
			v1.Description = "Minimal soil water potential to trigger germination";
			v1.Id = 0;
			v1.MaxValue = 100;
			v1.MinValue = -100;
			v1.Name = "MinSoilWaterPotForGermination";
			v1.Size = 1;
			v1.Units = "bar";
			v1.URL = "";
			v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v1);
			VarInfo v2 = new VarInfo();
			v2.DefaultValue = -2;
			v2.Description = "Soil water potential above which all the seeds germinate";
			v2.Id = 0;
			v2.MaxValue = 100;
			v2.MinValue = -100;
			v2.Name = "SoilWaterPotNoStress";
			v2.Size = 1;
			v2.Units = "bar";
			v2.URL = "";
			v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v2.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v2);
			VarInfo v3 = new VarInfo();
			v3.DefaultValue = 6;
			v3.Description = "Sowing density";
			v3.Id = 0;
			v3.MaxValue = 100;
			v3.MinValue = 1;
			v3.Name = "SowingDensity";
			v3.Size = 1;
			v3.Units = "plant/m2";
			v3.URL = "";
			v3.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v3.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v3);
			mo0_0.Parameters = _parameters0_0;
			//Inputs
			List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
			PropertyDescription pd1 = new PropertyDescription();
			pd1.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd1.PropertyName = "cumulTT";
			pd1.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTT)).ValueType.TypeForCurrentValue;
			pd1.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
			_inputs0_0.Add(pd1);
			PropertyDescription pd2 = new PropertyDescription();
			pd2.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd2.PropertyName = "SoilWaterPot";
			pd2.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.SoilWaterPot)).ValueType.TypeForCurrentValue;
			pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.SoilWaterPot);
			_inputs0_0.Add(pd2);
			PropertyDescription pd3 = new PropertyDescription();
			pd3.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd3.PropertyName = "hasGerminationHappened";
			pd3.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened)).ValueType.TypeForCurrentValue;
			pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened);
			_inputs0_0.Add(pd3);
			PropertyDescription pd4 = new PropertyDescription();
			pd4.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd4.PropertyName = "SumPsiSoil";
			pd4.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.SumPsiSoil)).ValueType.TypeForCurrentValue;
			pd4.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.SumPsiSoil);
			_inputs0_0.Add(pd4);
			PropertyDescription pd5 = new PropertyDescription();
			pd5.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd5.PropertyName = "dayNumber";
			pd5.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.dayNumber)).ValueType.TypeForCurrentValue;
			pd5.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.dayNumber);
			_inputs0_0.Add(pd5);
			mo0_0.Inputs = _inputs0_0;
			//Outputs
			List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
			PropertyDescription pd6 = new PropertyDescription();
			pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd6.PropertyName = "hasGerminationHappened";
			pd6.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened)).ValueType.TypeForCurrentValue;
			pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened);
			_outputs0_0.Add(pd6);
			PropertyDescription pd7 = new PropertyDescription();
			pd7.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd7.PropertyName = "plantDensityAfterGermination";
			pd7.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.plantDensityAfterGermination)).ValueType.TypeForCurrentValue;
			pd7.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.plantDensityAfterGermination);
			_outputs0_0.Add(pd7);
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

		#endregion

		#region Instances of the parameters

		// Getter and setters for the value of the parameters of the strategy. The actual parameters are stored into the ModelingOptionsManager of the strategy.


		public Double MinSoilWaterPotForGermination
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("MinSoilWaterPotForGermination");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'MinSoilWaterPotForGermination' not found (or found null) in strategy 'Germination'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("MinSoilWaterPotForGermination");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'MinSoilWaterPotForGermination' not found in strategy 'Germination'");
			}
		}
		public Double SoilWaterPotNoStress
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("SoilWaterPotNoStress");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'SoilWaterPotNoStress' not found (or found null) in strategy 'Germination'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("SoilWaterPotNoStress");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'SoilWaterPotNoStress' not found in strategy 'Germination'");
			}
		}
		public Double SowingDensity
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("SowingDensity");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'SowingDensity' not found (or found null) in strategy 'Germination'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("SowingDensity");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'SowingDensity' not found in strategy 'Germination'");
			}
		}

		// Getter and setters for the value of the parameters of a composite strategy


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
			MinSoilWaterPotForGerminationVarInfo.Name = "MinSoilWaterPotForGermination";
			MinSoilWaterPotForGerminationVarInfo.Description = " Minimal soil water potential to trigger germination";
			MinSoilWaterPotForGerminationVarInfo.MaxValue = 100;
			MinSoilWaterPotForGerminationVarInfo.MinValue = -100;
			MinSoilWaterPotForGerminationVarInfo.DefaultValue = -10;
			MinSoilWaterPotForGerminationVarInfo.Units = "bar";
			MinSoilWaterPotForGerminationVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			SoilWaterPotNoStressVarInfo.Name = "SoilWaterPotNoStress";
			SoilWaterPotNoStressVarInfo.Description = " Soil water potential above which all the seeds germinate";
			SoilWaterPotNoStressVarInfo.MaxValue = 100;
			SoilWaterPotNoStressVarInfo.MinValue = -100;
			SoilWaterPotNoStressVarInfo.DefaultValue = -2;
			SoilWaterPotNoStressVarInfo.Units = "bar";
			SoilWaterPotNoStressVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			SowingDensityVarInfo.Name = "SowingDensity";
			SowingDensityVarInfo.Description = " Sowing density";
			SowingDensityVarInfo.MaxValue = 100;
			SowingDensityVarInfo.MinValue = 1;
			SowingDensityVarInfo.DefaultValue = 6;
			SowingDensityVarInfo.Units = "plant/m2";
			SowingDensityVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");



		}

		//Parameters static VarInfo list 

		private static VarInfo _MinSoilWaterPotForGerminationVarInfo = new VarInfo();
		/// <summary> 
		///MinSoilWaterPotForGermination VarInfo definition
		/// </summary>
		public static VarInfo MinSoilWaterPotForGerminationVarInfo
		{
			get { return _MinSoilWaterPotForGerminationVarInfo; }
		}


		private static VarInfo _SoilWaterPotNoStressVarInfo = new VarInfo();
		/// <summary> 
		///SoilWaterPotNoStress VarInfo definition
		/// </summary>
		public static VarInfo SoilWaterPotNoStressVarInfo
		{
			get { return _SoilWaterPotNoStressVarInfo; }
		}


		private static VarInfo _SowingDensityVarInfo = new VarInfo();
		/// <summary> 
		///SowingDensity VarInfo definition
		/// </summary>
		public static VarInfo SowingDensityVarInfo
		{
			get { return _SowingDensityVarInfo; }
		}

		//Parameters static VarInfo list of the composite class


		#endregion

		#region pre/post conditions management		

		/// <summary>
		/// Test to verify the postconditions
		/// </summary>
		public string TestPostConditions(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex, string callID)
		{
			try
			{
				//Set current values of the outputs to the static VarInfo representing the output properties of the domain classes				

				PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened.CurrentValue = s.hasGerminationHappened;
				PhenologyMaizeCrop2MLStateVarInfo.plantDensityAfterGermination.CurrentValue = s.plantDensityAfterGermination;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r6 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened);
				if (r6.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened.ValueType)) { prc.AddCondition(r6); }
				RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.plantDensityAfterGermination);
				if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.plantDensityAfterGermination.ValueType)) { prc.AddCondition(r7); }



				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section4
				//Code written below will not be overwritten by a future code generation



				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section4 

				//Get the evaluation of postconditions
				string postConditionsResult = pre.VerifyPostconditions(prc, callID);
				//if we have errors, send it to the configured output 
				if (!string.IsNullOrEmpty(postConditionsResult)) { pre.TestsOut(postConditionsResult, true, "PostConditions errors in component SiriusQualityMaizePheno.Strategies, strategy " + this.GetType().Name); }
				return postConditionsResult;
			}
			catch (Exception exception)
			{
				//Uncomment the next line to use the trace
				//TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Error, 1001,	"Strategy: " + this.GetType().Name + " - Unhandled exception running post-conditions");

				string msg = "Component SiriusQualityMaizePheno.Strategies, " + this.GetType().Name + ": Unhandled exception running post-condition test. ";
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
				//Set current values of the inputs to the static VarInfo representing the input properties of the domain classes				

				PhenologyMaizeCrop2MLStateVarInfo.cumulTT.CurrentValue = s.cumulTT;
				PhenologyMaizeCrop2MLStateVarInfo.SoilWaterPot.CurrentValue = s.SoilWaterPot;
				PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened.CurrentValue = s.hasGerminationHappened;
				PhenologyMaizeCrop2MLStateVarInfo.SumPsiSoil.CurrentValue = s.SumPsiSoil;
				PhenologyMaizeCrop2MLStateVarInfo.dayNumber.CurrentValue = s.dayNumber;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
				if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r1); }
				RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.SoilWaterPot);
				if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.SoilWaterPot.ValueType)) { prc.AddCondition(r2); }
				RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened);
				if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened.ValueType)) { prc.AddCondition(r3); }
				RangeBasedCondition r4 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.SumPsiSoil);
				if (r4.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.SumPsiSoil.ValueType)) { prc.AddCondition(r4); }
				RangeBasedCondition r5 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.dayNumber);
				if (r5.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.dayNumber.ValueType)) { prc.AddCondition(r5); }
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("MinSoilWaterPotForGermination")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("SoilWaterPotNoStress")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("SowingDensity")));



				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section3
				//Code written below will not be overwritten by a future code generation



				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section3 

				//Get the evaluation of preconditions;					
				string preConditionsResult = pre.VerifyPreconditions(prc, callID);
				//if we have errors, send it to the configured output 
				if (!string.IsNullOrEmpty(preConditionsResult)) { pre.TestsOut(preConditionsResult, true, "PreConditions errors in component SiriusQualityMaizePheno.Strategies, strategy " + this.GetType().Name); }
				return preConditionsResult;
			}
			catch (Exception exception)
			{
				//Uncomment the next line to use the trace
				//	TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Error, 1002,"Strategy: " + this.GetType().Name + " - Unhandled exception running pre-conditions");

				string msg = "Component SiriusQualityMaizePheno.Strategies, " + this.GetType().Name + ": Unhandled exception running pre-condition test. ";
				throw new Exception(msg, exception);
			}
		}
        #endregion
        
		#region Model
        public void Estimate(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{

			CalculateModel(s, s1,r,a, ex );
		}

		private void CalculateModel(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{
			int hasGerminationHappened_t1 = s1.hasGerminationHappened;
			int hasGerminationHappened = s.hasGerminationHappened;


			double SoilHumidityStressFactor = 1;
			double plantDensityAfterGermination = SowingDensity * SoilHumidityStressFactor;

			if (hasGerminationHappened_t1 == 0)
			{
				//Temp dummy model of Germiantion


				hasGerminationHappened = 1;


				
			}
            else 
			{ 
				hasGerminationHappened = hasGerminationHappened_t1;
				
			}
			s.hasGerminationHappened = hasGerminationHappened;
			s.plantDensityAfterGermination = plantDensityAfterGermination;



		}
		#endregion
	}
}
