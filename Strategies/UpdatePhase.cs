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
    class UpdatePhase : PhenologyCrop2MLiStrategy
    {

		#region Constructor

		public UpdatePhase()
		{

		

			ModellingOptions mo0_0 = new ModellingOptions();
			//Parameters
			List<VarInfo> _parameters0_0 = new List<VarInfo>();
			VarInfo v00 = new VarInfo();
			v00.DefaultValue = 10;
			v00.Description = "Leaf Number before last tip appearence for the initiation of abortive period";
			v00.Id = 0;
			v00.MaxValue = 1000;
			v00.MinValue = 0;
			v00.Name = "NFSilkingInit";
			v00.Size = 1;
			v00.Units = "leaf";
			v00.URL = "";
			v00.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v00.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v00);
			VarInfo v0 = new VarInfo();
			v0.DefaultValue = 10;
			v0.Description = "Thermal time after Silking for end of abortive period";
			v0.Id = 0;
			v0.MaxValue = 1000;
			v0.MinValue = 0;
			v0.Name = "AbortLimitTT";
			v0.Size = 1;
			v0.Units = "°Cday";
			v0.URL = "";
			v0.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v0.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v0);
			VarInfo v1 = new VarInfo();
			v1.DefaultValue = 150;
			v1.Description = "Thermal time from sowing to emergence";
			v1.Id = 0;
			v1.MaxValue = 1000;
			v1.MinValue = 0;
			v1.Name = "Dse";
			v1.Size = 1;
			v1.Units = "°Cd";
			v1.URL = "";
			v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v1);
			VarInfo v2 = new VarInfo();
			v2.DefaultValue = 0;
			v2.Description = "Phyllochronic duration of the period between flag leaf ligule appearance and anthesis";
			v2.Id = 0;
			v2.MaxValue = 1000;
			v2.MinValue = 0;
			v2.Name = "PFLLAnth";
			v2.Size = 1;
			v2.Units = "dimensionless";
			v2.URL = "";
			v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v2.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v2);
			VarInfo v3 = new VarInfo();
			v3.DefaultValue = 0;
			v3.Description = "Duration of the endosperm cell division phase";
			v3.Id = 0;
			v3.MaxValue = 10000;
			v3.MinValue = 0;
			v3.Name = "Dcd";
			v3.Size = 1;
			v3.Units = "°Cd";
			v3.URL = "";
			v3.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v3.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v3);
			VarInfo v4 = new VarInfo();
			v4.DefaultValue = 0;
			v4.Description = "Grain filling duration (from anthesis to physiological maturity)";
			v4.Id = 0;
			v4.MaxValue = 10000;
			v4.MinValue = 0;
			v4.Name = "Dgf";
			v4.Size = 1;
			v4.Units = "°Cd";
			v4.URL = "";
			v4.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v4.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v4);
			VarInfo v5 = new VarInfo();
			v5.DefaultValue = 0;
			v5.Description = "Grain maturation duration (from physiological maturity to harvest ripeness)";
			v5.Id = 0;
			v5.MaxValue = 10000;
			v5.MinValue = 0;
			v5.Name = "Degfm";
			v5.Size = 1;
			v5.Units = "°Cd";
			v5.URL = "";
			v5.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v5.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v5);
			VarInfo v6 = new VarInfo();
			v6.DefaultValue = 0;
			v6.Description = "true to ignore grain maturation";
			v6.Id = 0;
			v6.MaxValue = 1;
			v6.MinValue = 0;
			v6.Name = "IgnoreGrainMaturation";
			v6.Size = 1;
			v6.Units = "-";
			v6.URL = "";
			v6.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v6.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
			_parameters0_0.Add(v6);
			VarInfo v7 = new VarInfo();
			v7.DefaultValue = 1;
			v7.Description = "Number of phyllochron between heading and anthesis";
			v7.Id = 0;
			v7.MaxValue = 3;
			v7.MinValue = 0;
			v7.Name = "PHEADANTH";
			v7.Size = 1;
			v7.Units = "-";
			v7.URL = "";
			v7.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v7.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v7);
			VarInfo v8 = new VarInfo();
			v8.DefaultValue = 16;
			v8.Description = "Final leaf number";
			v8.Id = 0;
			v8.MaxValue = 25;
			v8.MinValue = 10;
			v8.Name = "Nfinal";
			v8.Size = 1;
			v8.Units = "leaf";
			v8.URL = "";
			v8.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v8.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v8);
			VarInfo v9 = new VarInfo();
			v9.DefaultValue = 3.69;
			v9.Description = "leaf 6 sensitivity to water stress";
			v9.Id = 0;
			v9.MaxValue = 10;
			v9.MinValue = -10;
			v9.Name = "LERc";
			v9.Size = 1;
			v9.Units = "mm/(°Cd.bars)";
			v9.URL = "";
			v9.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v9.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v9);
			VarInfo v10 = new VarInfo();
			v10.DefaultValue = 1;
			v10.Description = " LERc divided by this coeff gives the sensitivity of silks to water stress";
			v10.Id = 0;
			v10.MaxValue = 10;
			v10.MinValue = -10;
			v10.Name = "waterStressCoeffSilk";
			v10.Size = 1;
			v10.Units = "-";
			v10.URL = "";
			v10.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v10.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v10);
			VarInfo v11 = new VarInfo();
			v11.DefaultValue = 0;
			v11.Description = "ASI of the genotype in well watered conditions";
			v11.Id = 0;
			v11.MaxValue = 10000;
			v11.MinValue = -10000;
			v11.Name = "ASIbase";
			v11.Size = 1;
			v11.Units = "°Cd";
			v11.URL = "";
			v11.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v11.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v11);
			VarInfo v12 = new VarInfo();
			v12.DefaultValue = 86;
			v12.Description = "old version of phyltip";
			v12.Id = 0;
			v12.MaxValue = 100;
			v12.MinValue = 0;
			v12.Name = "phyltip";
			v12.Size = 1;
			v12.Units = "°Cd/leaf";
			v12.URL = "";
			v12.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v12.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v12);
			VarInfo v13 = new VarInfo();
			v13.DefaultValue = -1.35;
			v13.Description = "intercept of the leaf apparition line";
			v13.Id = 0;
			v13.MaxValue = 999;
			v13.MinValue = -999;
			v13.Name = "btip";
			v13.Size = 1;
			v13.Units = "°Cd";
			v13.URL = "";
			v13.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v13.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v13);
			VarInfo v14 = new VarInfo();
			v14.DefaultValue = 0;
			v14.Description = "0: Continue until simulated Harvest; 1: Stop at observed Harvest (Management)";
			v14.Id = 0;
			v14.MaxValue = 1;
			v14.MinValue = 0;
			v14.Name = "StopAtHarvest";
			v14.Size = 1;
			v14.Units = "-";
			v14.URL = "";
			v14.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v14.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
			_parameters0_0.Add(v14);
			VarInfo v15 = new VarInfo();
			v15.DefaultValue = 0;
			v15.Description = "Date of observed Harvest";
			v15.Id = 0;
			v15.MaxValue = 1;
			v15.MinValue = 0;
			v15.Name = "HarvestDate";
			v15.Size = 0;
			v15.Units = "-";
			v15.URL = "";
			v15.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v15.ValueType = VarInfoValueTypes.GetInstanceForName("Date");
			_parameters0_0.Add(v15);
			mo0_0.Parameters = _parameters0_0;

			//Inputs
			List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();

			PropertyDescription pd21 = new PropertyDescription();
			pd21.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd21.PropertyName = "SoilWaterPot";
			pd21.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.SoilWaterPot)).ValueType.TypeForCurrentValue;
			pd21.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.SoilWaterPot);
			_inputs0_0.Add(pd21);
			PropertyDescription pd22 = new PropertyDescription();
			pd22.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd22.PropertyName = "cumulTTFromLastLeaf";
			pd22.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromLastLeaf)).ValueType.TypeForCurrentValue;
			pd22.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTFromLastLeaf);
			_inputs0_0.Add(pd22);
			PropertyDescription pd23 = new PropertyDescription();
			pd23.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd23.PropertyName = "GrainCumulTT";
			pd23.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.GrainCumulTT)).ValueType.TypeForCurrentValue;
			pd23.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.GrainCumulTT);
			_inputs0_0.Add(pd23);
			PropertyDescription pd24 = new PropertyDescription();
			pd24.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd24.PropertyName = "hasLastPrimordiumAppeared";
			pd24.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared)).ValueType.TypeForCurrentValue;
			pd24.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared);
			_inputs0_0.Add(pd24);
			PropertyDescription pd25 = new PropertyDescription();
			pd25.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd25.PropertyName = "hasLastPrimordiumAppeared";
			pd25.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared)).ValueType.TypeForCurrentValue;
			pd25.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared);
			_inputs0_0.Add(pd25);
			PropertyDescription pd26 = new PropertyDescription();
			pd26.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd26.PropertyName = "transition_lig";
			pd26.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.transition_lig)).ValueType.TypeForCurrentValue;
			pd26.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.transition_lig);
			_inputs0_0.Add(pd26);
			PropertyDescription pd28 = new PropertyDescription();
			pd28.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd28.PropertyName = "cumulTTPhenoMaizeAtEmergence";
			pd28.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence)).ValueType.TypeForCurrentValue;
			pd28.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence);
			_inputs0_0.Add(pd28);
			PropertyDescription pd0 = new PropertyDescription();
			pd0.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd0.PropertyName = "currentdate";
			pd0.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.currentdate)).ValueType.TypeForCurrentValue;
			pd0.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.currentdate);
			_inputs0_0.Add(pd0);
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
			pd3.PropertyName = "GrainCumulTT";
			pd3.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.GrainCumulTT)).ValueType.TypeForCurrentValue;
			pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.GrainCumulTT);
			_inputs0_0.Add(pd3);
			PropertyDescription pd4 = new PropertyDescription();
			pd4.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd4.PropertyName = "Ntip";
			pd4.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.Ntip)).ValueType.TypeForCurrentValue;
			pd4.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.Ntip);
			_inputs0_0.Add(pd4);
			PropertyDescription pd14 = new PropertyDescription();
			pd14.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd14.PropertyName = "GAI";
			pd14.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.GAI)).ValueType.TypeForCurrentValue;
			pd14.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.GAI);
			_inputs0_0.Add(pd14);
	
			PropertyDescription pd6 = new PropertyDescription();
			pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd6.PropertyName = "hasGerminationHappened";
			pd6.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened)).ValueType.TypeForCurrentValue;
			pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened);
			_inputs0_0.Add(pd6);
			PropertyDescription pd7 = new PropertyDescription();
			pd7.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd7.PropertyName = "hasSilkingStarted";
			pd7.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted)).ValueType.TypeForCurrentValue;
			pd7.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted);
			_inputs0_0.Add(pd7);
			PropertyDescription pd17 = new PropertyDescription();
			pd17.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd17.PropertyName = "hasFlagLeafAppeared";
			pd17.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasFlagLeafAppeared)).ValueType.TypeForCurrentValue;
			pd17.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasFlagLeafAppeared);
			_inputs0_0.Add(pd17);
			PropertyDescription pd8 = new PropertyDescription();
			pd8.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd8.PropertyName = "cumulTTSoil";
			pd8.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil)).ValueType.TypeForCurrentValue;
			pd8.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil);
			_inputs0_0.Add(pd8);
			PropertyDescription pd18 = new PropertyDescription();
			pd18.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd18.PropertyName = "TTemergence";
			pd18.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.TTemergence)).ValueType.TypeForCurrentValue;
			pd18.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.TTemergence);
			_inputs0_0.Add(pd18);
			mo0_0.Inputs = _inputs0_0;


			//Outputs
			List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
			PropertyDescription pd9 = new PropertyDescription();
			pd9.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd9.PropertyName = "phase";
			pd9.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.phase)).ValueType.TypeForCurrentValue;
			pd9.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.phase);
			PropertyDescription pd19 = new PropertyDescription();
			pd19.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd19.PropertyName = "cumulTTPhenoMaizeAtEmergence";
			pd19.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence)).ValueType.TypeForCurrentValue;
			pd19.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence);
			_outputs0_0.Add(pd9);
			PropertyDescription pd29 = new PropertyDescription();
			pd29.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd29.PropertyName = "transition_lig";
			pd29.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.transition_lig)).ValueType.TypeForCurrentValue;
			pd29.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.transition_lig);
			_outputs0_0.Add(pd9);
			PropertyDescription pd10 = new PropertyDescription();
			pd10.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd10.PropertyName = "hasLastPrimordiumAppeared";
			pd10.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared)).ValueType.TypeForCurrentValue;
			pd10.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared);
			_outputs0_0.Add(pd10);
			PropertyDescription pd11 = new PropertyDescription();
			pd11.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd11.PropertyName = "hasSilkingStarted";
			pd11.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted)).ValueType.TypeForCurrentValue;
			pd11.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted);
			_outputs0_0.Add(pd11);
			PropertyDescription pd12 = new PropertyDescription();
			pd12.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd12.PropertyName = "StopAtHarvestDate";
			pd12.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.StopAtHarvestDate)).ValueType.TypeForCurrentValue;
			pd12.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.StopAtHarvestDate);
			_outputs0_0.Add(pd12);

			/*			PropertyDescription pd24 = new PropertyDescription();
						pd24.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
						pd24.PropertyName = "hasLastPrimordiumAppeared";
						pd24.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared)).ValueType.TypeForCurrentValue;
						pd24.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared);
						_outputs0_0.Add(pd24);*/
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
			get { return "This strategy advances the phase and calculate the final leaf number"; }
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
			_pd.Add("Date", "15/07/2020");
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
		public DateTime HarvestDate
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("HarvestDate");
				if (vi != null && vi.CurrentValue != null) return (DateTime)vi.CurrentValue;
				else throw new Exception("Parameter 'HarvestDate' not found (or found null) in strategy 'Phenology'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("HarvestDate");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'HarvestDate' not found in strategy 'Phenology'");
			}
		}

		public Int32 StopAtHarvest
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("StopAtHarvest");
				if (vi != null && vi.CurrentValue != null) return (Int32)vi.CurrentValue;
				else throw new Exception("Parameter 'StopAtHarvest' not found (or found null) in strategy 'Phenology'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("StopAtHarvest");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'StopAtHarvest' not found in strategy 'Phenology'");
			}
		}
		public Double Dse
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dse");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Dse' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dse");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Dse' not found in strategy 'UpdatePhase'");
			}
		}
		public Double PFLLAnth
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("PFLLAnth");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'PFLLAnth' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("PFLLAnth");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'PFLLAnth' not found in strategy 'UpdatePhase'");
			}
		}
		public Double Dcd
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dcd");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Dcd' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dcd");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Dcd' not found in strategy 'UpdatePhase'");
			}
		}
		public Double Dgf
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dgf");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Dgf' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dgf");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Dgf' not found in strategy 'UpdatePhase'");
			}
		}
		public Double Degfm
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Degfm");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Degfm' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Degfm");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Degfm' not found in strategy 'UpdatePhase'");
			}
		}
		public Int32 IgnoreGrainMaturation
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("IgnoreGrainMaturation");
				if (vi != null && vi.CurrentValue != null) return (Int32)vi.CurrentValue;
				else throw new Exception("Parameter 'IgnoreGrainMaturation' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("IgnoreGrainMaturation");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'IgnoreGrainMaturation' not found in strategy 'UpdatePhase'");
			}
		}
		public Double PHEADANTH
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("PHEADANTH");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'PHEADANTH' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("PHEADANTH");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'PHEADANTH' not found in strategy 'UpdatePhase'");
			}
		}
		public Double Nfinal
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Nfinal' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Nfinal' not found in strategy 'UpdatePhase'");
			}
		}
		public Double LERc
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("LERc");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'LERc' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("LERc");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'LERc' not found in strategy 'UpdatePhase'");
			}
		}
		public Double waterStressCoeffSilk
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("waterStressCoeffSilk");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'waterStressCoeffSilk' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("waterStressCoeffSilk");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'waterStressCoeffSilk' not found in strategy 'UpdatePhase'");
			}
		}
		public Double ASIbase
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("ASIbase");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'ASIbase' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("ASIbase");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'ASIbase' not found in strategy 'UpdatePhase'");
			}
		}


		public Double NFSilkingInit
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("NFSilkingInit");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'NFSilkingInit' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("NFSilkingInit");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'NFSilkingInit' not found in strategy 'CalculateLeafNumber'");
			}
		}

		public Double AbortLimitTT
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("AbortLimitTT");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'AbortLimitTT' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("AbortLimitTT");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'AbortLimitTT' not found in strategy 'CalculateLeafNumber'");
			}
		}



		public Double phyltip
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("phyltip");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'phyltip' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("phyltip");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'phyltip' not found in strategy 'UpdatePhase'");
			}
		}
		public Double btip
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("btip");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'btip' not found (or found null) in strategy 'UpdatePhase'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("btip");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'btip' not found in strategy 'UpdatePhase'");
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
			HarvestDateVarInfo.Name = "HarvestDate";
			HarvestDateVarInfo.Description = " Date of observed Harvest";
			HarvestDateVarInfo.MaxValue = 1;
			HarvestDateVarInfo.MinValue = 0;
			HarvestDateVarInfo.DefaultValue = 0;
			HarvestDateVarInfo.Units = "-";
			HarvestDateVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Date");


			StopAtHarvestVarInfo.Name = "StopAtHarvest";
			StopAtHarvestVarInfo.Description = " 0: Continue until simulated Harvest; 1: Stop at observed Harvest (Management)";
			StopAtHarvestVarInfo.MaxValue = 1;
			StopAtHarvestVarInfo.MinValue = 0;
			StopAtHarvestVarInfo.DefaultValue = 0;
			StopAtHarvestVarInfo.Units = "-";
			StopAtHarvestVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Integer");


			DseVarInfo.Name = "Dse";
			DseVarInfo.Description = " Thermal time from sowing to emergence";
			DseVarInfo.MaxValue = 1000;
			DseVarInfo.MinValue = 0;
			DseVarInfo.DefaultValue = 150;
			DseVarInfo.Units = "°Cd";
			DseVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			PFLLAnthVarInfo.Name = "PFLLAnth";
			PFLLAnthVarInfo.Description = " Phyllochronic duration of the period between flag leaf ligule appearance and anthesis";
			PFLLAnthVarInfo.MaxValue = 1000;
			PFLLAnthVarInfo.MinValue = 0;
			PFLLAnthVarInfo.DefaultValue = 0;
			PFLLAnthVarInfo.Units = "dimensionless";
			PFLLAnthVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			DcdVarInfo.Name = "Dcd";
			DcdVarInfo.Description = " Duration of the endosperm cell division phase";
			DcdVarInfo.MaxValue = 10000;
			DcdVarInfo.MinValue = 0;
			DcdVarInfo.DefaultValue = 0;
			DcdVarInfo.Units = "°Cd";
			DcdVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			DgfVarInfo.Name = "Dgf";
			DgfVarInfo.Description = " Grain filling duration (from anthesis to physiological maturity)";
			DgfVarInfo.MaxValue = 10000;
			DgfVarInfo.MinValue = 0;
			DgfVarInfo.DefaultValue = 0;
			DgfVarInfo.Units = "°Cd";
			DgfVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			DegfmVarInfo.Name = "Degfm";
			DegfmVarInfo.Description = " Grain maturation duration (from physiological maturity to harvest ripeness)";
			DegfmVarInfo.MaxValue = 10000;
			DegfmVarInfo.MinValue = 0;
			DegfmVarInfo.DefaultValue = 0;
			DegfmVarInfo.Units = "°Cd";
			DegfmVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			IgnoreGrainMaturationVarInfo.Name = "IgnoreGrainMaturation";
			IgnoreGrainMaturationVarInfo.Description = " true to ignore grain maturation";
			IgnoreGrainMaturationVarInfo.MaxValue = 1;
			IgnoreGrainMaturationVarInfo.MinValue = 0;
			IgnoreGrainMaturationVarInfo.DefaultValue = 0;
			IgnoreGrainMaturationVarInfo.Units = "-";
			IgnoreGrainMaturationVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Integer");

			PHEADANTHVarInfo.Name = "PHEADANTH";
			PHEADANTHVarInfo.Description = " Number of phyllochron between heading and anthesis";
			PHEADANTHVarInfo.MaxValue = 3;
			PHEADANTHVarInfo.MinValue = 0;
			PHEADANTHVarInfo.DefaultValue = 1;
			PHEADANTHVarInfo.Units = "-";
			PHEADANTHVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			NfinalVarInfo.Name = "Nfinal";
			NfinalVarInfo.Description = " Final leaf number";
			NfinalVarInfo.MaxValue = 25;
			NfinalVarInfo.MinValue = 10;
			NfinalVarInfo.DefaultValue = 16;
			NfinalVarInfo.Units = "leaf";
			NfinalVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			LERcVarInfo.Name = "LERc";
			LERcVarInfo.Description = " leaf 6 sensitivity to water stress";
			LERcVarInfo.MaxValue = 10;
			LERcVarInfo.MinValue = -10;
			LERcVarInfo.DefaultValue = 3.69;
			LERcVarInfo.Units = "mm/(°Cd.bars)";
			LERcVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			waterStressCoeffSilkVarInfo.Name = "waterStressCoeffSilk";
			waterStressCoeffSilkVarInfo.Description = "  LERc divided by this coeff gives the sensitivity of silks to water stress";
			waterStressCoeffSilkVarInfo.MaxValue = 10;
			waterStressCoeffSilkVarInfo.MinValue = -10;
			waterStressCoeffSilkVarInfo.DefaultValue = 1;
			waterStressCoeffSilkVarInfo.Units = "-";
			waterStressCoeffSilkVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			ASIbaseVarInfo.Name = "ASIbase";
			ASIbaseVarInfo.Description = " ASI of the genotype in well watered conditions";
			ASIbaseVarInfo.MaxValue = 10000;
			ASIbaseVarInfo.MinValue = -10000;
			ASIbaseVarInfo.DefaultValue = 0;
			ASIbaseVarInfo.Units = "°Cd";
			ASIbaseVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			phyltipVarInfo.Name = "phyltip";
			phyltipVarInfo.Description = " old version of phyltip";
			phyltipVarInfo.MaxValue = 100;
			phyltipVarInfo.MinValue = 0;
			phyltipVarInfo.DefaultValue = 86;
			phyltipVarInfo.Units = "°Cd/leaf";
			phyltipVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			btipVarInfo.Name = "btip";
			btipVarInfo.Description = " intercept of the leaf apparition line";
			btipVarInfo.MaxValue = 999;
			btipVarInfo.MinValue = -999;
			btipVarInfo.DefaultValue = -1.35;
			btipVarInfo.Units = "°Cd";
			btipVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			NFSilkingInitInfo.Name = "NFSilkingInit";
			NFSilkingInitInfo.Description = "Leaf Number before last tip appearence for the initiation of abortive period";
			NFSilkingInitInfo.MaxValue = 999;
			NFSilkingInitInfo.MinValue = -999;
			NFSilkingInitInfo.DefaultValue = -1.35;
			NFSilkingInitInfo.Units = "leaf";
			NFSilkingInitInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");


			AbortLimitTTInfo.Name = "AbortLimitTT";
			AbortLimitTTInfo.Description = "Thermal time after Silking for end of abortive period";
			AbortLimitTTInfo.MaxValue = 999;
			AbortLimitTTInfo.MinValue = -999;
			AbortLimitTTInfo.DefaultValue = -1.35;
			AbortLimitTTInfo.Units = "leaf";
			AbortLimitTTInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");


			//Parameters static VarInfo list 

		}



		private static VarInfo _StopAtHarvestVarInfo = new VarInfo();
		/// <summary> 
		///StopAtHarvest VarInfo definition
		/// </summary>
		public static VarInfo StopAtHarvestVarInfo
		{
			get { return _StopAtHarvestVarInfo; }
		}
		private static VarInfo _HarvestDateVarInfo = new VarInfo();
		/// <summary> 
		///HarvestDate VarInfo definition
		/// </summary>
		public static VarInfo HarvestDateVarInfo
		{
			get { return _HarvestDateVarInfo; }
		}

		private static VarInfo _AbortLimitTTInfo = new VarInfo();
		/// <summary> 
		///Dse VarInfo definition
		/// </summary>
		public static VarInfo AbortLimitTTInfo
		{
			get { return _AbortLimitTTInfo; }
		}


		private static VarInfo _NFSilkingInitInfo = new VarInfo();
		/// <summary> 
		///Dse VarInfo definition
		/// </summary>
		public static VarInfo NFSilkingInitInfo
		{
			get { return _NFSilkingInitInfo; }
		}




		private static VarInfo _DseVarInfo = new VarInfo();
		/// <summary> 
		///Dse VarInfo definition
		/// </summary>
		public static VarInfo DseVarInfo
		{
			get { return _DseVarInfo; }
		}
		private static VarInfo _PFLLAnthVarInfo = new VarInfo();
		/// <summary> 
		///PFLLAnth VarInfo definition
		/// </summary>
		public static VarInfo PFLLAnthVarInfo
		{
			get { return _PFLLAnthVarInfo; }
		}
		private static VarInfo _DcdVarInfo = new VarInfo();
		/// <summary> 
		///Dcd VarInfo definition
		/// </summary>
		public static VarInfo DcdVarInfo
		{
			get { return _DcdVarInfo; }
		}
		private static VarInfo _DgfVarInfo = new VarInfo();
		/// <summary> 
		///Dgf VarInfo definition
		/// </summary>
		public static VarInfo DgfVarInfo
		{
			get { return _DgfVarInfo; }
		}
		private static VarInfo _DegfmVarInfo = new VarInfo();
		/// <summary> 
		///Degfm VarInfo definition
		/// </summary>
		public static VarInfo DegfmVarInfo
		{
			get { return _DegfmVarInfo; }
		}
		private static VarInfo _IgnoreGrainMaturationVarInfo = new VarInfo();
		/// <summary> 
		///IgnoreGrainMaturation VarInfo definition
		/// </summary>
		public static VarInfo IgnoreGrainMaturationVarInfo
		{
			get { return _IgnoreGrainMaturationVarInfo; }
		}
		private static VarInfo _PHEADANTHVarInfo = new VarInfo();
		/// <summary> 
		///PHEADANTH VarInfo definition
		/// </summary>
		public static VarInfo PHEADANTHVarInfo
		{
			get { return _PHEADANTHVarInfo; }
		}
		private static VarInfo _NfinalVarInfo = new VarInfo();
		/// <summary> 
		///Nfinal VarInfo definition
		/// </summary>
		public static VarInfo NfinalVarInfo
		{
			get { return _NfinalVarInfo; }
		}
		private static VarInfo _LERcVarInfo = new VarInfo();
		/// <summary> 
		///LERc VarInfo definition
		/// </summary>
		public static VarInfo LERcVarInfo
		{
			get { return _LERcVarInfo; }
		}
		private static VarInfo _waterStressCoeffSilkVarInfo = new VarInfo();
		/// <summary> 
		///waterStressCoeffSilk VarInfo definition
		/// </summary>
		public static VarInfo waterStressCoeffSilkVarInfo
		{
			get { return _waterStressCoeffSilkVarInfo; }
		}
		private static VarInfo _ASIbaseVarInfo = new VarInfo();
		/// <summary> 
		///ASIbase VarInfo definition
		/// </summary>
		public static VarInfo ASIbaseVarInfo
		{
			get { return _ASIbaseVarInfo; }
		}
		private static VarInfo _phyltipVarInfo = new VarInfo();
		/// <summary> 
		///phyltip VarInfo definition
		/// </summary>
		public static VarInfo phyltipVarInfo
		{
			get { return _phyltipVarInfo; }
		}
		private static VarInfo _btipVarInfo = new VarInfo();
		/// <summary> 
		///btip VarInfo definition
		/// </summary>
		public static VarInfo btipVarInfo
		{
			get { return _btipVarInfo; }
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

				PhenologyMaizeCrop2MLStateVarInfo.phase.CurrentValue = s.phase;
				PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared.CurrentValue = s.hasLastPrimordiumAppeared;
				PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted.CurrentValue = s.hasSilkingStarted;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.phase);
				if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.phase.ValueType)) { prc.AddCondition(r9); }
				RangeBasedCondition r10 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared);
				if (r10.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasLastPrimordiumAppeared.ValueType)) { prc.AddCondition(r10); }
				RangeBasedCondition r11 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted);
				if (r11.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted.ValueType)) { prc.AddCondition(r11); }



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
				PhenologyMaizeCrop2MLStateVarInfo.GrainCumulTT.CurrentValue = s.GrainCumulTT;
				PhenologyMaizeCrop2MLStateVarInfo.GAI.CurrentValue = s.GAI;
				PhenologyMaizeCrop2MLStateVarInfo.phase.CurrentValue = s.phase;
				PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened.CurrentValue = s.hasGerminationHappened;
				PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted.CurrentValue = s.hasSilkingStarted;
				PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil.CurrentValue = s.cumulTTSoil;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
				if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r1); }
				RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
				if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.ValueType)) { prc.AddCondition(r2); }
				RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.GrainCumulTT);
				if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.GrainCumulTT.ValueType)) { prc.AddCondition(r3); }
				RangeBasedCondition r4 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.GAI);
				if (r4.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.GAI.ValueType)) { prc.AddCondition(r4); }
				RangeBasedCondition r5 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.phase);
				if (r5.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.phase.ValueType)) { prc.AddCondition(r5); }
				RangeBasedCondition r6 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened);
				if (r6.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasGerminationHappened.ValueType)) { prc.AddCondition(r6); }
				RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted);
				if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasSilkingStarted.ValueType)) { prc.AddCondition(r7); }
				RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil);
				if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTTSoil.ValueType)) { prc.AddCondition(r8); }
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Dse")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("PFLLAnth")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Dcd")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Dgf")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Degfm")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("IgnoreGrainMaturation")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("PHEADANTH")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Nfinal")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("LERc")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("waterStressCoeffSilk")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("ASIbase")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("phyltip")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("btip")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("AbortLimitTT")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("NFSilkingInit")));

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

			double cumulTT6 = s.cumulTT[6];

			DateTime currentdate = s.currentdate;

			double phase_t1 = s1.phase;
			int hasGerminationHappened = s.hasGerminationHappened;
			double TTemergence = s.TTemergence;
			double Ntip = s.Ntip;
			
			int hasFlagLeafAppeared = s.hasFlagLeafAppeared;
			double waterPot = s.SoilWaterPot;
			double cumulTTFromLastLeaf = s.cumulTTFromLastLeaf;
			double GrainCumulTT = s.GrainCumulTT;
			double GAI = s.GAI;
			int transition_lig_t1 = s1.transition_lig;

			double ttFromLastLeafToAnthesis = PFLLAnth * phyltip;
			double TTFromLastLeafToSilk = ttFromLastLeafToAnthesis + ASIbase * (1 + LERc * waterStressCoeffSilk * (-waterPot));


			int StopAtHarvestDate = 0;
			double cumulTTPhenoMaizeAtEmergence = -999;
			double phase =0 ;
			int hasLastPrimordiumAppeared = s.hasLastPrimordiumAppeared;
			int hasSilkingStarted = s.hasSilkingStarted;

			if (( StopAtHarvest == 1 ) && (currentdate == HarvestDate ) ) StopAtHarvestDate = 1;
            else StopAtHarvestDate = 0;

		

				if (phase_t1 >= 0 && phase_t1 < 1)//SowingToEmergence
				{
					//CheckEmergence
					//if (phenologymaizestate.cumulTT[6] >= phenologymaizestate.TTemergence)//phenologymaizestate.cumulTT[6] >= Dse
					//																	  //attention: changer cumulTT[6] avec le bon cumulTT pour le sol
					//{
					//	phenologymaizestate.phase = 1;//Emergence
					//}
					//else
					//{
					//	phenologymaizestate.phase = phenologymaizestate1.phase;
					//}

					if (hasGerminationHappened == 1)
					{
						//Console.WriteLine(phenologymaizestate.cumulTTSoil + " " + phenologymaizestate.TTemergence);
						//CheckEmergence
						//if (phenologymaizestate.cumulTTSoil >= phenologymaizestate.TTemergence)//phenologymaizestate.cumulTT[6] >= Dse
						if (cumulTT6 >= TTemergence)                                                                      //attention: changer cumulTT[6] avec le bon cumulTT pour le sol
						{
							//Console.WriteLine("**" + phenologymaizestate.cumulTTSoil + " " + phenologymaizestate.TTemergence);
							phase = 1;//Emergence
							cumulTTPhenoMaizeAtEmergence = cumulTT6;
						}
						else
						{
							phase = phase_t1;
						}
					}
					else
						{
						phase = phase_t1;
						}

				}
				else if (phase_t1 >= 1 && phase_t1 < 2)//EmergenceToFloralInitiation
				{
					//CalculateFinalLeafNumber

					hasLastPrimordiumAppeared = 1;

					//CheckFloralInitiation
					if (hasLastPrimordiumAppeared == 1)
					{
						phase = 2;//Floralinitiation  
					}

					if (Ntip >= (int)(Nfinal + 0.5) - NFSilkingInit) transition_lig_t1 = 1;


				}
				else if (phase_t1 >= 2 && phase_t1 < 4)//FloralInitiationToAnthesis
				{
					if (Ntip >= (int)(Nfinal + 0.5) - NFSilkingInit) transition_lig_t1 = 1;

					if (hasFlagLeafAppeared == 1) //if ()  phenologymaizestate.HasFlagLeafLiguleAppeared == 1
					{

						
						//PFLLAnth* phyltip
						//PFLLAnth

						if (cumulTTFromLastLeaf >= ttFromLastLeafToAnthesis)// phenologymaizestate.cumulTTFromBBCH_1n
						{
							phase = 4;//Anthesis


		//What Lucille Did :
		/*					if (!s.Calendar[GrowthStageMaize.BBCH_63_Anthesis].HasValue)
							{
								s.Calendar.Set(GrowthStageMaize.BBCH_63_Anthesis, phenologymaizestate.currentdate, phenologymaizestate.cumulTT);

							}
							s.currentBBCHStage = GrowthStageMaize.BBCH_63_Anthesis;
							s.hasBBCHStageChanged = 1;
							double test = s.cumulTT[6];
		*/

		//What I would do in Local :	But Better to add a updateCalendar class with a estimate
		/*					if(!s.calendarMoments.Contains("Anthesis"))
                            {
								s.calendarMoments.Add("Anthesis");
								s.calendarDates.Add(s.currentdate);
								s.calendarCumuls.Add(s.cumulTT[6]);
                            }
		*/
						}
						else
						{
							phase = phase_t1;
					}

						if (cumulTTFromLastLeaf >= TTFromLastLeafToSilk)// silking
						{
							hasSilkingStarted = 1;
						}

					}
					else
					{
					phase = phase_t1;
				}
				}
				else if (phase_t1 == 4)//AnthesisToEndCellDivision
				{

					if (cumulTTFromLastLeaf >= TTFromLastLeafToSilk)// silking
					{
						hasSilkingStarted = 1;
					}

					//CheckEndCellDivision
					if (cumulTTFromLastLeaf >= TTFromLastLeafToSilk + AbortLimitTT || StopAtHarvestDate == 1)
					{
						phase = 4.5;//EndCellDivision
					}
					else
					{
						phase = phase_t1;
					}
				}
				else if (phase_t1 == 4.5)//EndCellDivisionToEndGrainFill
				{
					// CheckEndGrainFilling
					if (GrainCumulTT >= Dgf || GAI <= 0 || StopAtHarvestDate == 1)
					{
						phase = 5;//End of grain filling
					}
					else
					{
						phase = phase_t1;
					}
				}
				else if (phase_t1 >= 5 && phase_t1 < 6)//EndGrainFillToMaturity
				{
				//CheckMaturity
				///<Comment>To enable ignoring grain maturation duration</Comment>
				//double LocalDegfm = Degfm;
				//if (IgnoreGrainMaturation == 1) LocalDegfm = -1;

				//if (phenologymaizestate.cumulTTFromBBCH_85 >= LocalDegfm)
				//{
					phase = 6; //maturity
															   //}
															   //else
															   //{
					///  phenologymaizestate.phase = phenologymaizestate1.phase;
					//}
				}
				else if (phase_t1 >= 6 && phase_t1 < 7)
				{
					phase = phase_t1;

				}
			/*				else
							{
								throw new Exception("current phase is not between 0 and 7");
							}
			*/
			//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
			//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section1 



			s.StopAtHarvestDate =  StopAtHarvestDate;
			s.cumulTTPhenoMaizeAtEmergence =  cumulTTPhenoMaizeAtEmergence ;
			s.phase = phase ;
			s.hasLastPrimordiumAppeared =  hasLastPrimordiumAppeared;
			s1.transition_lig = transition_lig_t1;
			s.hasSilkingStarted = hasSilkingStarted;
		}


/*		public void Init(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{
			s1.transition_lig = 0;
		}

*/
		#endregion

	}
}
