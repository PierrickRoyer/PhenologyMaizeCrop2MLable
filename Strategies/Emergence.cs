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
    class Emergence : PhenologyCrop2MLiStrategy
    {
		#region Constructor

		public Emergence()
		{

			ModellingOptions mo0_0 = new ModellingOptions();
			//Parameters
			List<VarInfo> _parameters0_0 = new List<VarInfo>();
			VarInfo v1 = new VarInfo();
			v1.DefaultValue = 55;
			v1.Description = "Thermal time lag before emergence";
			v1.Id = 0;
			v1.MaxValue = 100;
			v1.MinValue = 0;
			v1.Name = "EmergenceLag";
			v1.Size = 1;
			v1.Units = "°Cd";
			v1.URL = "";
			v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v1);
			VarInfo v2 = new VarInfo();
			v2.DefaultValue = 0.6;
			v2.Description = "Thermal time to grow 1 mm";
			v2.Id = 0;
			v2.MaxValue = 10;
			v2.MinValue = 0;
			v2.Name = "ShootGrowthRate";
			v2.Size = 1;
			v2.Units = "°Cd/mm";
			v2.URL = "";
			v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v2.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v2);
			VarInfo v3 = new VarInfo();
			v3.DefaultValue = 0.2;
			v3.Description = "Depth of Sowing";
			v3.Id = 0;
			v3.MaxValue = 100;
			v3.MinValue = 0;
			v3.Name = "SowingDepth";
			v3.Size = 1;
			v3.Units = "cm";
			v3.URL = "";
			v3.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v3.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v3);
			VarInfo v4 = new VarInfo();
			v4.DefaultValue = 0.03;
			v4.Description = "Ratio between the SoilGrowthRate and the LagEmergence";
			v4.Id = 0;
			v4.MaxValue = 10;
			v4.MinValue = 0;
			v4.Name = "k_emergence";
			v4.Size = 1;
			v4.Units = "mm/°Cd2";
			v4.URL = "";
			v4.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v4.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v4);
			VarInfo v5 = new VarInfo();
			v5.DefaultValue = 100;
			v5.Description = "Thermal time from sowing to emergence";
			v5.Id = 0;
			v5.MaxValue = 500;
			v5.MinValue = 0;
			v5.Name = "Dse";
			v5.Size = 1;
			v5.Units = "°Cd";
			v5.URL = "";
			v5.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v5.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v5);
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
			pd2.PropertyName = "cumulTTSoil";
			pd2.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil)).ValueType.TypeForCurrentValue;
			pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil);
			_inputs0_0.Add(pd2);
			mo0_0.Inputs = _inputs0_0;
			//Outputs
			List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
			PropertyDescription pd3 = new PropertyDescription();
			pd3.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd3.PropertyName = "TTemergence";
			pd3.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.TTemergence)).ValueType.TypeForCurrentValue;
			pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.TTemergence);
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

		#endregion

		#region Implementation of IAnnotatable

		/// <summary>
		/// Description of the model
		/// </summary>
		public string Description
		{
			get { return "calculates the time of emergence, checks wether it has been reached or not"; }
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
			_pd.Add("Date", "31/08/2020");
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


		public Double EmergenceLag
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("EmergenceLag");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'EmergenceLag' not found (or found null) in strategy 'Emergence'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("EmergenceLag");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'EmergenceLag' not found in strategy 'Emergence'");
			}
		}
		public Double ShootGrowthRate
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("ShootGrowthRate");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'ShootGrowthRate' not found (or found null) in strategy 'Emergence'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("ShootGrowthRate");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'ShootGrowthRate' not found in strategy 'Emergence'");
			}
		}
		public Double SowingDepth
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("SowingDepth");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'SowingDepth' not found (or found null) in strategy 'Emergence'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("SowingDepth");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'SowingDepth' not found in strategy 'Emergence'");
			}
		}
		public Double k_emergence
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("k_emergence");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'k_emergence' not found (or found null) in strategy 'Emergence'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("k_emergence");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'k_emergence' not found in strategy 'Emergence'");
			}
		}
		public Double Dse
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dse");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Dse' not found (or found null) in strategy 'Emergence'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dse");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Dse' not found in strategy 'Emergence'");
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
			EmergenceLagVarInfo.Name = "EmergenceLag";
			EmergenceLagVarInfo.Description = " Thermal time lag before emergence";
			EmergenceLagVarInfo.MaxValue = 100;
			EmergenceLagVarInfo.MinValue = 0;
			EmergenceLagVarInfo.DefaultValue = 55;
			EmergenceLagVarInfo.Units = "°Cd";
			EmergenceLagVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			ShootGrowthRateVarInfo.Name = "ShootGrowthRate";
			ShootGrowthRateVarInfo.Description = " Thermal time to grow 1 mm";
			ShootGrowthRateVarInfo.MaxValue = 10;
			ShootGrowthRateVarInfo.MinValue = 0;
			ShootGrowthRateVarInfo.DefaultValue = 0.6;
			ShootGrowthRateVarInfo.Units = "°Cd/mm";
			ShootGrowthRateVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			SowingDepthVarInfo.Name = "SowingDepth";
			SowingDepthVarInfo.Description = " Depth of Sowing";
			SowingDepthVarInfo.MaxValue = 100;
			SowingDepthVarInfo.MinValue = 0;
			SowingDepthVarInfo.DefaultValue = 0.2;
			SowingDepthVarInfo.Units = "cm";
			SowingDepthVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			k_emergenceVarInfo.Name = "k_emergence";
			k_emergenceVarInfo.Description = " Ratio between the SoilGrowthRate and the LagEmergence";
			k_emergenceVarInfo.MaxValue = 10;
			k_emergenceVarInfo.MinValue = 0;
			k_emergenceVarInfo.DefaultValue = 0.03;
			k_emergenceVarInfo.Units = "mm/°Cd2";
			k_emergenceVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			DseVarInfo.Name = "Dse";
			DseVarInfo.Description = " Thermal time from sowing to emergence";
			DseVarInfo.MaxValue = 500;
			DseVarInfo.MinValue = 0;
			DseVarInfo.DefaultValue = 100;
			DseVarInfo.Units = "°Cd";
			DseVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");



		}

		//Parameters static VarInfo list 

		private static VarInfo _EmergenceLagVarInfo = new VarInfo();
		/// <summary> 
		///EmergenceLag VarInfo definition
		/// </summary>
		public static VarInfo EmergenceLagVarInfo
		{
			get { return _EmergenceLagVarInfo; }
		}
		private static VarInfo _ShootGrowthRateVarInfo = new VarInfo();
		/// <summary> 
		///ShootGrowthRate VarInfo definition
		/// </summary>
		public static VarInfo ShootGrowthRateVarInfo
		{
			get { return _ShootGrowthRateVarInfo; }
		}
		private static VarInfo _SowingDepthVarInfo = new VarInfo();
		/// <summary> 
		///SowingDepth VarInfo definition
		/// </summary>
		public static VarInfo SowingDepthVarInfo
		{
			get { return _SowingDepthVarInfo; }
		}
		private static VarInfo _k_emergenceVarInfo = new VarInfo();
		/// <summary> 
		///k_emergence VarInfo definition
		/// </summary>
		public static VarInfo k_emergenceVarInfo
		{
			get { return _k_emergenceVarInfo; }
		}
		private static VarInfo _DseVarInfo = new VarInfo();
		/// <summary> 
		///Dse VarInfo definition
		/// </summary>
		public static VarInfo DseVarInfo
		{
			get { return _DseVarInfo; }
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

				PhenologyMaizeCrop2MLStateVarInfo.TTemergence.CurrentValue = s.TTemergence;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.TTemergence);
				if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.TTemergence.ValueType)) { prc.AddCondition(r3); }



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
				PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil.CurrentValue = s.cumulTTSoil;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
				if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r1); }
				RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil);
				if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil.ValueType)) { prc.AddCondition(r2); }
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("EmergenceLag")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("ShootGrowthRate")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("SowingDepth")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("k_emergence")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Dse")));



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

		/// <summary>
		/// Run the strategy to calculate the outputs. In case of error during the execution, the preconditions tests are executed.
		/// </summary>
		public void Estimate(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{
			try
			{
				CalculateModel(s,s1,r,a,ex);

				//Uncomment the next line to use the trace
				//TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 1005,"Strategy: " + this.GetType().Name + " - Model executed");
			}
			catch (Exception exception)
			{
				//Uncomment the next line to use the trace
				//TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Error, 1003,		"Strategy: " + this.GetType().Name + " - Unhandled exception running model");

				string msg = "Error in component SiriusQualityMaizePheno.Strategies, strategy: " + this.GetType().Name + ": Unhandled exception running model. " + exception.GetType().FullName + " - " + exception.Message;
				throw new Exception(msg, exception);
			}
		}



		private void CalculateModel(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{
			//temp dummy emergence modele

			double EmergenceLag = s.EmergenceLag;

			double TTemergence = EmergenceLag;

		
			 /*10 * SowingDepth / (k_emergence * EmergenceLag) +*/ ; //*10 conversion from cm to mm
																							  //phenologymaizestate.TTemergence = Dse;
																							  //Console.WriteLine(phenologymaizestate.TTemergence + " " + SowingDepth + " " + k_emergence + " " + EmergenceLag + " " + EmergenceLag);

			s.TTemergence = TTemergence;
		}



		#endregion
	}
}
