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
    class UpdateLeafFlag : PhenologyCrop2MLiStrategy
    {

		#region Constructor

		public UpdateLeafFlag()
		{

			ModellingOptions mo0_0 = new ModellingOptions();
			//Parameters
			List<VarInfo> _parameters0_0 = new List<VarInfo>();
			VarInfo v1 = new VarInfo();
			v1.DefaultValue = 10;
			v1.Description = "Maize final leaf number";
			v1.Id = 0;
			v1.MaxValue = 100;
			v1.MinValue = 0;
			v1.Name = "Nfinal";
			v1.Size = 1;
			v1.Units = "leaf";
			v1.URL = "";
			v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v1);
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
			pd2.PropertyName = "LeafNumber";
			pd2.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LeafNumber)).ValueType.TypeForCurrentValue;
			pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
			_inputs0_0.Add(pd2);
			PropertyDescription pd3 = new PropertyDescription();
			pd3.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd3.PropertyName = "currentdate";
			pd3.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.currentdate)).ValueType.TypeForCurrentValue;
			pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.currentdate);
			_inputs0_0.Add(pd3);
			PropertyDescription pd4 = new PropertyDescription();
			pd4.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd4.PropertyName = "HasFlagLeafLiguleAppeared";
			pd4.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared)).ValueType.TypeForCurrentValue;
			pd4.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared);
			_inputs0_0.Add(pd4);
/*			PropertyDescription pd5 = new PropertyDescription();
			pd5.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd5.PropertyName = "Calendar";
			pd5.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.Calendar)).ValueType.TypeForCurrentValue;
			pd5.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.Calendar);
			_inputs0_0.Add(pd5);
			mo0_0.Inputs = _inputs0_0;*/


			//Outputs
			List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
			PropertyDescription pd6 = new PropertyDescription();
			pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd6.PropertyName = "hasLastPrimordiumAppeared";
			pd6.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared)).ValueType.TypeForCurrentValue;
			pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared);
			_outputs0_0.Add(pd6);
			PropertyDescription pd7 = new PropertyDescription();
/*			pd7.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd7.PropertyName = "Calendar";
			pd7.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.Calendar)).ValueType.TypeForCurrentValue;
			pd7.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.Calendar);
			_outputs0_0.Add(pd7);
			mo0_0.Outputs = _outputs0_0;*/
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
			get { return "tells if flag leaf has appeared and update the calendar if so"; }
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
			_pd.Add("Date", "24/08/2020");
			_pd.Add("Publisher", "INRA");
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


		public Double Nfinal
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Nfinal' not found (or found null) in strategy 'UpdateLeafFlag'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Nfinal' not found in strategy 'UpdateLeafFlag'");
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
			NfinalVarInfo.Name = "Nfinal";
			NfinalVarInfo.Description = " Maize final leaf number";
			NfinalVarInfo.MaxValue = 100;
			NfinalVarInfo.MinValue = 0;
			NfinalVarInfo.DefaultValue = 10;
			NfinalVarInfo.Units = "leaf";
			NfinalVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");



		}

		//Parameters static VarInfo list 

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

				PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared.CurrentValue = s.hasLastPrimordiumAppeared;
				PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.CurrentValue = s.calendarCumuls;
				PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.CurrentValue = s.calendarMoments;
				PhenologyMaizeCrop2MLStateVarInfo.calendarDates.CurrentValue = s.calendarDates;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r6 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared);
				if (r6.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared.ValueType)) { prc.AddCondition(r6); }
				RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
				if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.ValueType)) { prc.AddCondition(r7); }
				RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
				if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.ValueType)) { prc.AddCondition(r8); }
				RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
				if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarDates.ValueType)) { prc.AddCondition(r9); }


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
				PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.CurrentValue = s.LeafNumber;
				PhenologyMaizeCrop2MLStateVarInfo.currentdate.CurrentValue = s.currentdate;
				PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared.CurrentValue = s.HasFlagLeafLiguleAppeared;
				PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.CurrentValue = s.calendarCumuls;
				PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.CurrentValue = s.calendarMoments;
				PhenologyMaizeCrop2MLStateVarInfo.calendarDates.CurrentValue = s.calendarDates;
				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
				if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r1); }
				RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
				if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.ValueType)) { prc.AddCondition(r2); }
				RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.currentdate);
				if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.currentdate.ValueType)) { prc.AddCondition(r3); }
				RangeBasedCondition r4 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared);
				if (r4.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared.ValueType)) { prc.AddCondition(r4); }
				RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls);
				if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarCumuls.ValueType)) { prc.AddCondition(r7); }
				RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments);
				if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarMoments.ValueType)) { prc.AddCondition(r8); }
				RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.calendarDates);
				if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.calendarDates.ValueType)) { prc.AddCondition(r9); }
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

			string currentBBCHStage_t = s.currentBBCHStage;
			int hasBBCHStageChanged_t = s.hasBBCHStageChanged;

			double Ntip = s.Ntip;
			double LNlig = s.LNlig;
			DateTime currentdate = s.currentdate;
			double LeafNumber = s.LeafNumber;
			double cumulTT6 = s.cumulTT[6];
			List<string> calendarMoments = s.calendarMoments;
			List<DateTime> calendarDates = s.calendarDates;
			List<double> calendarCumuls = s.calendarCumuls;

			List<string> calendarMoments_t1 = s1.calendarMoments;
			List<DateTime> calendarDates_t1 = s1.calendarDates;
			List<double> calendarCumuls_t1 = s1.calendarCumuls;

			int hasFlagLeafAppeared_t = s.hasFlagLeafAppeared;
			int hasFlagLeafAppeared_t1 = s1.hasFlagLeafAppeared;

			int HasFlagLeafLiguleAppeared_t = s.HasFlagLeafLiguleAppeared;
			int HasFlagLeafLiguleAppeared_t1 = s1.HasFlagLeafLiguleAppeared;


			//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section1
			//Code written below will not be overwritten by a future code generation
			if (HasFlagLeafLiguleAppeared_t1 == 0)
			{
				if (LeafNumber > 0)
				{
					if (hasFlagLeafAppeared_t1 == 0 && (Nfinal > 0 && Ntip == (int)(Nfinal + 0.5))) // NFinal > 0 ???!?
					{
						hasFlagLeafAppeared_t = 1;
						//LucilelCode with Calendar :
						/*if (!s1.Calendar[GrowthStageMaize.LastLeafVisible].HasValue)
						{
							s.Calendar.Set(GrowthStageMaize.LastLeafVisible, s.currentdate, s.cumulTT);
							s.currentBBCHStage = GrowthStageMaize.LastLeafVisible;
							s.hasBBCHStageChanged = 1;
						}*/
						//Pierrick's Code for Crop2ML traduction
						if (!calendarMoments_t1.Contains("LastLeafVisible"))
						{

							calendarMoments.Add("LastLeafVisible");
							calendarDates.Add(currentdate);
							calendarCumuls.Add(cumulTT6);

							currentBBCHStage_t = "LastLeafVisible";
							hasBBCHStageChanged_t = 1;
						}

					}
					else
					{
						hasFlagLeafAppeared_t = hasFlagLeafAppeared_t1;
						calendarMoments = calendarMoments_t1;
						calendarDates = calendarDates_t1;
						calendarCumuls = calendarCumuls_t1;
					}
					if (HasFlagLeafLiguleAppeared_t1 == 0 && (Nfinal > 0 && LNlig == (int)(Nfinal + 0.5)))
					{
						HasFlagLeafLiguleAppeared_t = 1;
						/*					if (!s1.Calendar[GrowthStageMaize.BBCH_1n_FlagLeafLiguleJustVisible].HasValue)
											{
												s.Calendar.Set(GrowthStageMaize.BBCH_1n_FlagLeafLiguleJustVisible, s.currentdate, s.cumulTT);
												s.currentBBCHStage = GrowthStageMaize.BBCH_1n_FlagLeafLiguleJustVisible;
												s.hasBBCHStageChanged = 1;
											}*/
						if (!calendarMoments_t1.Contains("FlagLeafLiguleJustVisible"))
						{

							calendarMoments.Add("FlagLeafLiguleJustVisible");
							calendarDates.Add(currentdate);
							calendarCumuls.Add(cumulTT6);

							currentBBCHStage_t = "FlagLeafLiguleJustVisible";
							hasBBCHStageChanged_t = 1;
						}

					}
					else
					{
						HasFlagLeafLiguleAppeared_t = HasFlagLeafLiguleAppeared_t1;
						calendarMoments = calendarMoments_t1;
						calendarDates = calendarDates_t1;
						calendarCumuls = calendarCumuls_t1;
					}




				}



			}


			s.calendarMoments = calendarMoments;
			s.calendarDates = calendarDates;
			s.calendarCumuls = calendarCumuls;

			s.HasFlagLeafLiguleAppeared = HasFlagLeafLiguleAppeared_t;
			s.hasFlagLeafAppeared = hasFlagLeafAppeared_t;

			s.currentBBCHStage = currentBBCHStage_t;
			s.hasBBCHStageChanged = hasBBCHStageChanged_t;
		}

		#endregion

	}
}
