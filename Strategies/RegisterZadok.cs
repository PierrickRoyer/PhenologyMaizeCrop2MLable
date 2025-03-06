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
    ///Property Description of Calendar related object missing, hope it s not important
    class RegisterZadok : PhenologyCrop2MLiStrategy
    {
		// missing pro^poerty description calendar related stuff
		#region Constructor

		public RegisterZadok()
		{

			ModellingOptions mo0_0 = new ModellingOptions();
			//Parameters
			List<VarInfo> _parameters0_0 = new List<VarInfo>();
			VarInfo v1 = new VarInfo();
			v1.DefaultValue = 0;
			v1.Description = "Duration of the endosperm endoreduplication phase";
			v1.Id = 0;
			v1.MaxValue = 10000;
			v1.MinValue = 0;
			v1.Name = "Der";
			v1.Size = 1;
			v1.Units = "°Cd";
			v1.URL = "";
			v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v1);
			VarInfo v2 = new VarInfo();
			v2.DefaultValue = 0;
			v2.Description = "used for the calcul of Terminal spikelet";
			v2.Id = 0;
			v2.MaxValue = 10000;
			v2.MinValue = 0;
			v2.Name = "slopeTSFLN";
			v2.Size = 1;
			v2.Units = "-";
			v2.URL = "";
			v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v2.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v2);
			VarInfo v3 = new VarInfo();
			v3.DefaultValue = 0;
			v3.Description = "used for the calcul of Terminal spikelet";
			v3.Id = 0;
			v3.MaxValue = 10000;
			v3.MinValue = 0;
			v3.Name = "intTSFLN";
			v3.Size = 1;
			v3.Units = "-";
			v3.URL = "";
			v3.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v3.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v3);
			VarInfo v4 = new VarInfo();
			v4.DefaultValue = 10;
			v4.Description = "Maize final leaf number";
			v4.Id = 0;
			v4.MaxValue = 100;
			v4.MinValue = 0;
			v4.Name = "Nfinal";
			v4.Size = 1;
			v4.Units = "leaf";
			v4.URL = "";
			v4.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v4.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v4);
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
			pd2.PropertyName = "phase";
			pd2.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.phase)).ValueType.TypeForCurrentValue;
			pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.phase);
			_inputs0_0.Add(pd2);
			PropertyDescription pd3 = new PropertyDescription();
			pd3.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd3.PropertyName = "LeafNumber";
			pd3.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LeafNumber)).ValueType.TypeForCurrentValue;
			pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
			_inputs0_0.Add(pd3);
			PropertyDescription pd4 = new PropertyDescription();
			pd4.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd4.PropertyName = "currentdate";
			pd4.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.currentdate)).ValueType.TypeForCurrentValue;
			pd4.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.currentdate);
			_inputs0_0.Add(pd4);
			PropertyDescription pd5 = new PropertyDescription();
			pd5.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd5.PropertyName = "calendarMoments";
			pd5.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments).ValueType.TypeForCurrentValue;
			pd5.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
			_inputs0_0.Add(pd5);
			PropertyDescription pd6 = new PropertyDescription();
			pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd6.PropertyName = "calendarDates";
			pd6.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates).ValueType.TypeForCurrentValue;
			pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
			_inputs0_0.Add(pd6);
			PropertyDescription pd7 = new PropertyDescription();
			pd7.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd7.PropertyName = "calendarCumuls";
			pd7.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls).ValueType.TypeForCurrentValue;
			pd7.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
			_inputs0_0.Add(pd7);
			PropertyDescription pd11 = new PropertyDescription();
			pd11.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd11.PropertyName = "IsLatestLeafInternodeLengthPotPositive";
			pd11.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.IsLatestLeafInternodeLengthPotPositive).ValueType.TypeForCurrentValue;
			pd11.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.IsLatestLeafInternodeLengthPotPositive);
			_inputs0_0.Add(pd11);
			PropertyDescription pd12 = new PropertyDescription();
			pd12.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd12.PropertyName = "hasSilkingStarted";
			pd12.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted).ValueType.TypeForCurrentValue;
			pd12.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted);
			_inputs0_0.Add(pd12);
			PropertyDescription pd13 = new PropertyDescription();
			pd13.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd13.PropertyName = "currentBBCHStage";
			pd13.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage).ValueType.TypeForCurrentValue;
			pd13.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage);
			_inputs0_0.Add(pd13);
			PropertyDescription pd14 = new PropertyDescription();
			pd14.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd14.PropertyName = "hasBBCHStageChanged";
			pd14.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.hasBBCHStageChanged).ValueType.TypeForCurrentValue;
			pd14.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasBBCHStageChanged);
			_inputs0_0.Add(pd14);



			/*			PropertyDescription pd5 = new PropertyDescription();
						pd5.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
						pd5.PropertyName = "Calendar";
						pd5.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.Calendar)).ValueType.TypeForCurrentValue;
						pd5.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.Calendar);
						_inputs0_0.Add(pd5);
						*/
			//Outputs
			/*			List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
						PropertyDescription pd6 = new PropertyDescription();
						pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
						pd6.PropertyName = "Calendar";
						pd6.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.Calendar)).ValueType.TypeForCurrentValue;
						pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.Calendar);
						_outputs0_0.Add(pd6);
						;*/
			//
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
			PropertyDescription pd15 = new PropertyDescription();
			pd15.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd15.PropertyName = "currentBBCHStage";
			pd15.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage).ValueType.TypeForCurrentValue;
			pd15.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage);
			_outputs0_0.Add(pd15);
			PropertyDescription pd16 = new PropertyDescription();
			pd16.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd16.PropertyName = "hasBBCHStageChanged";
			pd16.PropertyType = (PhenologyMaizeCrop2MLStateVarInfo.hasBBCHStageChanged).ValueType.TypeForCurrentValue;
			pd16.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasBBCHStageChanged);
			_outputs0_0.Add(pd16);


			mo0_0.Inputs = _inputs0_0;
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
			get { return "record the zadok stage in the calendar"; }
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
			_pd.Add("Creator", "pierre.martre@supagro.inra.fr");
			_pd.Add("Date", "31/12/2020");
			_pd.Add("Publisher", "Inra");
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


		public Double Der
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Der");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Der' not found (or found null) in strategy 'RegisterZadok'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Der");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Der' not found in strategy 'RegisterZadok'");
			}
		}
		public Double slopeTSFLN
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("slopeTSFLN");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'slopeTSFLN' not found (or found null) in strategy 'RegisterZadok'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("slopeTSFLN");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'slopeTSFLN' not found in strategy 'RegisterZadok'");
			}
		}
		public Double intTSFLN
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("intTSFLN");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'intTSFLN' not found (or found null) in strategy 'RegisterZadok'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("intTSFLN");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'intTSFLN' not found in strategy 'RegisterZadok'");
			}
		}
		public Double Nfinal
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Nfinal' not found (or found null) in strategy 'RegisterZadok'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Nfinal' not found in strategy 'RegisterZadok'");
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
			DerVarInfo.Name = "Der";
			DerVarInfo.Description = " Duration of the endosperm endoreduplication phase";
			DerVarInfo.MaxValue = 10000;
			DerVarInfo.MinValue = 0;
			DerVarInfo.DefaultValue = 0;
			DerVarInfo.Units = "°Cd";
			DerVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			slopeTSFLNVarInfo.Name = "slopeTSFLN";
			slopeTSFLNVarInfo.Description = " used for the calcul of Terminal spikelet";
			slopeTSFLNVarInfo.MaxValue = 10000;
			slopeTSFLNVarInfo.MinValue = 0;
			slopeTSFLNVarInfo.DefaultValue = 0;
			slopeTSFLNVarInfo.Units = "-";
			slopeTSFLNVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			intTSFLNVarInfo.Name = "intTSFLN";
			intTSFLNVarInfo.Description = " used for the calcul of Terminal spikelet";
			intTSFLNVarInfo.MaxValue = 10000;
			intTSFLNVarInfo.MinValue = 0;
			intTSFLNVarInfo.DefaultValue = 0;
			intTSFLNVarInfo.Units = "-";
			intTSFLNVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			NfinalVarInfo.Name = "Nfinal";
			NfinalVarInfo.Description = " Maize final leaf number";
			NfinalVarInfo.MaxValue = 100;
			NfinalVarInfo.MinValue = 0;
			NfinalVarInfo.DefaultValue = 10;
			NfinalVarInfo.Units = "leaf";
			NfinalVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");



		}

		//Parameters static VarInfo list 

		private static VarInfo _DerVarInfo = new VarInfo();
		/// <summary> 
		///Der VarInfo definition
		/// </summary>
		public static VarInfo DerVarInfo
		{
			get { return _DerVarInfo; }
		}
		private static VarInfo _slopeTSFLNVarInfo = new VarInfo();
		/// <summary> 
		///slopeTSFLN VarInfo definition
		/// </summary>
		public static VarInfo slopeTSFLNVarInfo
		{
			get { return _slopeTSFLNVarInfo; }
		}
		private static VarInfo _intTSFLNVarInfo = new VarInfo();
		/// <summary> 
		///intTSFLN VarInfo definition
		/// </summary>
		public static VarInfo intTSFLNVarInfo
		{
			get { return _intTSFLNVarInfo; }
		}
		private static VarInfo _NfinalVarInfo = new VarInfo();
		/// <summary> 
		///Nfinal VarInfo definition
		/// </summary>
		public static VarInfo NfinalVarInfo
		{
			get { return _NfinalVarInfo; }
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

				PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.CurrentValue = s.calendarCumuls;
				PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.CurrentValue = s.calendarMoments;
				PhenologyMaizeCrop2MLStateVarInfo.calendarDates.CurrentValue = s.calendarDates;
				PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage.CurrentValue = s.currentBBCHStage;

                //Create the collection of the conditions to test
                ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
				if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.ValueType)) { prc.AddCondition(r7); }
				RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
				if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.ValueType)) { prc.AddCondition(r8); }
				RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
				if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarDates.ValueType)) { prc.AddCondition(r9); }
                RangeBasedCondition r10 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage);
                if (r10.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage.ValueType)) { prc.AddCondition(r10); }



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
				PhenologyMaizeCrop2MLStateVarInfo.phase.CurrentValue = s.phase;
				PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.CurrentValue = s.LeafNumber;
				PhenologyMaizeCrop2MLStateVarInfo.currentdate.CurrentValue = s.currentdate;
				PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.CurrentValue = s.calendarCumuls;
				PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.CurrentValue = s.calendarMoments;
				PhenologyMaizeCrop2MLStateVarInfo.calendarDates.CurrentValue = s.calendarDates;
                PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage.CurrentValue = s.currentBBCHStage;
                //Create the collection of the conditions to test
                ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
				if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r1); }
				RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.phase);
				if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.phase.ValueType)) { prc.AddCondition(r2); }
				RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
				if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.ValueType)) { prc.AddCondition(r3); }
				RangeBasedCondition r4 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.currentdate);
				if (r4.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.currentdate.ValueType)) { prc.AddCondition(r4); }

				RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
				if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.ValueType)) { prc.AddCondition(r7); }
				RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
				if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.ValueType)) { prc.AddCondition(r8); }
				RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
				if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarDates.ValueType)) { prc.AddCondition(r9); }
                RangeBasedCondition r10 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage);
                if (r10.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.currentBBCHStage.ValueType)) { prc.AddCondition(r10); }


                prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Der")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("slopeTSFLN")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("intTSFLN")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Nfinal")));



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

			CalculateModel(s, s1, r, a, ex);
		}



		private void CalculateModel(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{


			//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section1
			//Code written below will not be overwritten by a future code generation

			


			DateTime currentdate = s.currentdate;
			double cumulTT6 = s.cumulTT[6];
			double LeafNumber = s.LeafNumber;
			List<string> calendarMoments_t1 = s1.calendarMoments;
			List<DateTime> calendarDates_t1 = s1.calendarDates;
			List<double> calendarCumuls_t1 = s1.calendarCumuls;

			List<string> calendarMoments = s.calendarMoments;
			List<DateTime> calendarDates = s.calendarDates;
			List<double> calendarCumuls = s.calendarCumuls;


			int IsLatestLeafInternodeLengthPotPositive = s.IsLatestLeafInternodeLengthPotPositive;
			int hasSilkingStarted = s.hasSilkingStarted;



			string currentBBCHStage = s.currentBBCHStage;
			int hasBBCHStageChanged = s.hasBBCHStageChanged;


			int roundedFinalLeafNumber = (int)(Nfinal + 0.5);


			//if (HasReachedHaun(4, s.LeafNumber) && !(s1.Calendar[GrowthStage.ZC_21_MainShootPlus1Tiller].HasValue))
			//{
			//s.Calendar.Set(GrowthStage.ZC_21_MainShootPlus1Tiller, s.currentdate, s.cumulTT);
			//s.currentBBCHStage = GrowthStage.ZC_21_MainShootPlus1Tiller;
			//s.hasBBCHStageChanged = 1;
			//}
			//else if (HasReachedHaun(5, s.LeafNumber) && !(s1.Calendar[GrowthStage.ZC_22_MainShootPlus2Tiller].HasValue))
			//{
			//s.Calendar.Set(GrowthStage.ZC_22_MainShootPlus2Tiller, s.currentdate, s.cumulTT);
			//s.currentBBCHStage = GrowthStage.ZC_22_MainShootPlus2Tiller;
			//s.hasBBCHStageChanged = 1;
			//}
			//else if (HasReachedHaun(6, s.LeafNumber) && !(s1.Calendar[GrowthStage.ZC_23_MainShootPlus3Tiller].HasValue))
			//{
			//s.Calendar.Set(GrowthStage.ZC_23_MainShootPlus3Tiller, s.currentdate, s.cumulTT);
			//s.currentBBCHStage = GrowthStage.ZC_23_MainShootPlus3Tiller;
			//s.hasBBCHStageChanged = 1;
			//}
			if (IsLatestLeafInternodeLengthPotPositive == 1 && !(calendarMoments_t1.Contains("BeginningStemExtension")))
			{
				calendarMoments.Add("BeginningStemExtension");
				calendarDates.Add(currentdate);
				calendarCumuls.Add(cumulTT6);
				currentBBCHStage = "BeginningStemExtension";
				hasBBCHStageChanged = 1;

			}
			//else if (Nfinal > 0 && HasReachedHaun(slopeTSFLN * Nfinal - intTSFLN, s.LeafNumber) && !(s1.Calendar[GrowthStage.TerminalSpikelet].HasValue))
			//{
			//s.Calendar.Set(GrowthStage.TerminalSpikelet, s.currentdate, s.cumulTT);
			//s.currentBBCHStage = GrowthStage.TerminalSpikelet;
			//s.hasBBCHStageChanged = 1;
			//}
			else if (HasReachedFlagLeaf(4, roundedFinalLeafNumber, LeafNumber) && !(calendarMoments_t1.Contains("PseudoStemElongation")))
			{
				calendarMoments.Add("PseudoStemElongation");
				calendarDates.Add(currentdate);
				calendarCumuls.Add(cumulTT6);
				currentBBCHStage = "PseudoStemElongation";
				hasBBCHStageChanged = 1;
			}
			else if (HasReachedFlagLeaf(3, roundedFinalLeafNumber, LeafNumber) && !(calendarMoments_t1.Contains("1stNodeDetectable")))
			{
				calendarMoments.Add("1stNodeDetectable");
				calendarDates.Add(currentdate);
				calendarCumuls.Add(cumulTT6);
				currentBBCHStage = "1stNodeDetectable";
				hasBBCHStageChanged = 1;
			}
			else if (HasReachedFlagLeaf(2, roundedFinalLeafNumber, LeafNumber) && !(calendarMoments_t1.Contains("2ndNodeDetectable")))
			{
				calendarMoments.Add("2ndNodeDetectable");
				calendarDates.Add(currentdate);
				calendarCumuls.Add(cumulTT6);
				currentBBCHStage = "2ndNodeDetectable";
				hasBBCHStageChanged = 1;
			}
			//else if (HasReachedFlagLeaf(1, roundedFinalLeafNumber, phenologymaizestate.LeafNumber) && !(phenologymaizestate1.Calendar[GrowthStage.ZC_37_FlagLeafJustVisible].HasValue))
			//{
			//phenologymaizestate.Calendar.Set(GrowthStage.ZC_37_FlagLeafJustVisible, phenologymaizestate.currentdate, phenologymaizestate.cumulTT);
			//phenologymaizestate.currentBBCHStage = GrowthStage.ZC_37_FlagLeafJustVisible;
			//phenologymaizestate.hasBBCHStageChanged = 1;
			//}
			//else if (!(phenologymaizestate1.Calendar[GrowthStageMaize.LastLeafVisible].HasValue))//HasReachedFlagLeaf(1, roundedFinalLeafNumber, phenologymaizestate.Ntip) && 
			//{
			//	phenologymaizestate.Calendar.Set(GrowthStageMaize.LastLeafVisible, phenologymaizestate.currentdate, phenologymaizestate.cumulTT);
			//	phenologymaizestate.currentBBCHStage = GrowthStageMaize.LastLeafVisible;
			//	phenologymaizestate.hasBBCHStageChanged = 1;
			//}
			//else if (!(phenologymaizestate1.Calendar[GrowthStageMaize.BBCH_1n_FlagLeafLiguleJustVisible].HasValue) && phenologymaizestate.LNlig >= Nfinal)//HasReachedFlagLeaf(0, roundedFinalLeafNumber, phenologymaizestate.LeafNumber) &&
			//{
			//	//phenologymaizestate.HasFlagLeafLiguleAppeared = 1;
			//	phenologymaizestate.Calendar.Set(GrowthStageMaize.BBCH_1n_FlagLeafLiguleJustVisible, phenologymaizestate.currentdate, phenologymaizestate.cumulTT);
			//	phenologymaizestate.currentBBCHStage = GrowthStageMaize.BBCH_1n_FlagLeafLiguleJustVisible;
			//	phenologymaizestate.hasBBCHStageChanged = 1;
			//}
			//else if (phenologymaizestate.phase_.phaseValue == 4 && !(phenologymaizestate1.Calendar[GrowthStageMaize.BBCH_63_Anthesis].HasValue))
			//{
			//	phenologymaizestate.Calendar.Set(GrowthStageMaize.BBCH_63_Anthesis, phenologymaizestate.currentdate, phenologymaizestate.cumulTT);
			//	phenologymaizestate.currentBBCHStage = GrowthStageMaize.BBCH_63_Anthesis;
			//	phenologymaizestate.hasBBCHStageChanged = 1;
			//}
			/*else if ((!(phenologymaizestate1.Calendar[GrowthStageMaize.BBCH_83_MidGrainFilling].HasValue))
                    && phenologymaizestate.phase_.phaseValue == 4.5//EndCellDivisionToEndGrainFill
                    && phenologymaizestate.cumulTTFromBBCH_63 >= Der)
            {
            phenologymaizestate.Calendar.Set(GrowthStageMaize.BBCH_83_MidGrainFilling, phenologymaizestate.currentdate, phenologymaizestate.cumulTT);
            phenologymaizestate.currentBBCHStage = GrowthStageMaize.BBCH_83_MidGrainFilling;
            phenologymaizestate.hasBBCHStageChanged = 1;
            }*/
			else if (hasSilkingStarted == 1 && !(calendarMoments_t1.Contains("Silking")))
			{
				calendarMoments.Add("Silking");
				calendarDates.Add(currentdate);
				calendarCumuls.Add(cumulTT6);
				currentBBCHStage = "Silking";
				hasBBCHStageChanged = 1;
			}
			else
			{
				hasBBCHStageChanged = 0;
				calendarMoments = calendarMoments_t1;
				calendarDates = calendarDates_t1;
				calendarCumuls = calendarCumuls_t1;
			}

			s.calendarMoments = calendarMoments;
			s.calendarDates = calendarDates  ;
			s.calendarCumuls = calendarCumuls;

			s.currentBBCHStage = currentBBCHStage;
			s.hasBBCHStageChanged = hasBBCHStageChanged;
		}



		#endregion


		//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section2
		//Code written below will not be overwritten by a future code generation
		///<summary>Check if the crop has reached the stage "flag leaf ligule just visible"</summary>
		///<param name="stg"> the flag leaf</param>
		///<returns>return true if the crop has reached the stage "flag leaf ligule just visible", false if not</returns>
		public bool HasReachedFlagLeaf(int stg, int roundedFinalLeafNumber, double leafNumber)
		{
			double trgt = roundedFinalLeafNumber - (double)stg;
			return (leafNumber >= trgt && trgt > 0);
		}

		///<summary>Check if the crop has reached a specified Haun stage</summary>
		///<param name="stg">Haun stage to check for</param>
		///<returns>return true if the crop has reached the specified Haun stage, false if not</returns>
		private bool HasReachedHaun(double stg, double leafNumber)
		{
			return (leafNumber >= stg);
		}
	}
}
