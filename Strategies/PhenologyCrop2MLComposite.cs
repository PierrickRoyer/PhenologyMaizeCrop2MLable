using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using CRA.ModelLayer.MetadataTypes;
using CRA.ModelLayer.Core;
using CRA.ModelLayer.Strategy;
using System.Reflection;
using VarInfo = CRA.ModelLayer.Core.VarInfo;
using Preconditions = CRA.ModelLayer.Core.Preconditions;
using CRA.AgroManagement;
using PhenologyMaizeCrop2ML.API;
using PhenologyMaizeCrop2ML.DomainClass;

namespace PhenologyMaizeCrop2ML.Strategies
{


	public class PhenologyCrop2MLComposite : PhenologyCrop2MLiStrategy
	{

		CalculateLeafNumber _calculateleafnumber = new CalculateLeafNumber();
		RegisterZadok _registerzadok = new RegisterZadok();
		UpdateLeafFlag _updateleafflag = new UpdateLeafFlag();
		UpdatePhase _updatephase = new UpdatePhase();
		Emergence _emergence = new Emergence();
		Germination _germination = new Germination();
		IsMomentRegistered _ismomentregistered = new IsMomentRegistered();
		UpdateCalendar _updatecalendar = new UpdateCalendar();

		#region Constructor

		public PhenologyCrop2MLComposite()
		{

			ModellingOptions mo0_0 = new ModellingOptions();
			//Parameters
			List<VarInfo> _parameters0_0 = new List<VarInfo>();
			VarInfo v1 = new VarInfo();
			v1.DefaultValue = 0;
			v1.Description = "0: Continue until simulated Harvest; 1: Stop at observed Harvest (Management)";
			v1.Id = 0;
			v1.MaxValue = 1;
			v1.MinValue = 0;
			v1.Name = "StopAtHarvest";
			v1.Size = 1;
			v1.Units = "-";
			v1.URL = "";
			v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v1.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
			_parameters0_0.Add(v1);
			VarInfo v2 = new VarInfo();
			v2.DefaultValue = 0;
			v2.Description = "Date of observed Harvest";
			v2.Id = 0;
			v2.MaxValue = 1;
			v2.MinValue = 0;
			v2.Name = "HarvestDate";
			v2.Size = 0;
			v2.Units = "-";
			v2.URL = "";
			v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v2.ValueType = VarInfoValueTypes.GetInstanceForName("Date");
			_parameters0_0.Add(v2);
			VarInfo v3 = new CompositeStrategyVarInfo(_calculateleafnumber, "phyltip");
			_parameters0_0.Add(v3);
			VarInfo v4 = new CompositeStrategyVarInfo(_calculateleafnumber, "Ntip0");
			_parameters0_0.Add(v4);
			VarInfo v5 = new CompositeStrategyVarInfo(_calculateleafnumber, "k_bl");
			_parameters0_0.Add(v5);
			VarInfo v6 = new CompositeStrategyVarInfo(_calculateleafnumber, "Nlim");
			_parameters0_0.Add(v6);
			VarInfo v7 = new CompositeStrategyVarInfo(_calculateleafnumber, "Nfinal");
			_parameters0_0.Add(v7);
			VarInfo v8 = new CompositeStrategyVarInfo(_calculateleafnumber, "a_ll1");
			_parameters0_0.Add(v8);
			VarInfo v9 = new CompositeStrategyVarInfo(_calculateleafnumber, "b_ll1");
			_parameters0_0.Add(v9);
			VarInfo v10 = new CompositeStrategyVarInfo(_calculateleafnumber, "Lagmax");
			_parameters0_0.Add(v10);
			VarInfo v11 = new CompositeStrategyVarInfo(_calculateleafnumber, "k_ll");
			_parameters0_0.Add(v11);
			VarInfo v12 = new CompositeStrategyVarInfo(_calculateleafnumber, "alpha_tr");
			_parameters0_0.Add(v12);
			VarInfo v13 = new CompositeStrategyVarInfo(_calculateleafnumber, "Dse");
			_parameters0_0.Add(v13);
			VarInfo v14 = new CompositeStrategyVarInfo(_calculateleafnumber, "btip");
			_parameters0_0.Add(v14);
			VarInfo v16 = new CompositeStrategyVarInfo(_registerzadok, "Der");
			_parameters0_0.Add(v16);
			VarInfo v17 = new CompositeStrategyVarInfo(_registerzadok, "slopeTSFLN");
			_parameters0_0.Add(v17);
			VarInfo v18 = new CompositeStrategyVarInfo(_registerzadok, "intTSFLN");
			_parameters0_0.Add(v18);
			VarInfo v19 = new CompositeStrategyVarInfo(_registerzadok, "Nfinal");
			_parameters0_0.Add(v19);
			VarInfo v20 = new CompositeStrategyVarInfo(_updateleafflag, "Nfinal");
			_parameters0_0.Add(v20);
			VarInfo v21 = new CompositeStrategyVarInfo(_updatephase, "Dse");
			_parameters0_0.Add(v21);
			VarInfo v22 = new CompositeStrategyVarInfo(_updatephase, "PFLLAnth");
			_parameters0_0.Add(v22);
			VarInfo v23 = new CompositeStrategyVarInfo(_updatephase, "Dcd");
			_parameters0_0.Add(v23);
			VarInfo v24 = new CompositeStrategyVarInfo(_updatephase, "Dgf");
			_parameters0_0.Add(v24);
			VarInfo v25 = new CompositeStrategyVarInfo(_updatephase, "Degfm");
			_parameters0_0.Add(v25);
			VarInfo v26 = new CompositeStrategyVarInfo(_updatephase, "IgnoreGrainMaturation");
			_parameters0_0.Add(v26);
			VarInfo v27 = new CompositeStrategyVarInfo(_updatephase, "PHEADANTH");
			_parameters0_0.Add(v27);
			VarInfo v28 = new CompositeStrategyVarInfo(_updatephase, "Nfinal");
			_parameters0_0.Add(v28);
			VarInfo v29 = new CompositeStrategyVarInfo(_updatephase, "LERc");
			_parameters0_0.Add(v29);
			VarInfo v30 = new CompositeStrategyVarInfo(_updatephase, "waterStressCoeffSilk");
			_parameters0_0.Add(v30);
			VarInfo v31 = new CompositeStrategyVarInfo(_updatephase, "ASIbase");
			_parameters0_0.Add(v31);
			VarInfo v32 = new CompositeStrategyVarInfo(_updatephase, "phyltip");
			_parameters0_0.Add(v32);
			VarInfo v33 = new CompositeStrategyVarInfo(_updatephase, "btip");
			_parameters0_0.Add(v33);
			VarInfo v34 = new CompositeStrategyVarInfo(_emergence, "EmergenceLag");
			_parameters0_0.Add(v34);
			VarInfo v35 = new CompositeStrategyVarInfo(_emergence, "ShootGrowthRate");
			_parameters0_0.Add(v35);
			VarInfo v36 = new CompositeStrategyVarInfo(_emergence, "SowingDepth");
			_parameters0_0.Add(v36);
			VarInfo v37 = new CompositeStrategyVarInfo(_emergence, "k_emergence");
			_parameters0_0.Add(v37);
			VarInfo v38 = new CompositeStrategyVarInfo(_emergence, "Dse");
			_parameters0_0.Add(v38);
			VarInfo v39 = new CompositeStrategyVarInfo(_germination, "MinSoilWaterPotForGermination");
			_parameters0_0.Add(v39);
			VarInfo v40 = new CompositeStrategyVarInfo(_germination, "SoilWaterPotNoStress");
			_parameters0_0.Add(v40);
			VarInfo v41 = new CompositeStrategyVarInfo(_germination, "SowingDensity");
			_parameters0_0.Add(v41);
			mo0_0.Parameters = _parameters0_0;
			//Inputs
			List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
			mo0_0.Inputs = _inputs0_0;

			//Outputs
			List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
			mo0_0.Outputs = _outputs0_0;
			//Associated strategies
			List<string> lAssStrat0_0 = new List<string>();
			lAssStrat0_0.Add(typeof(PhenologyMaizeCrop2ML.Strategies.CalculateLeafNumber).FullName);
			lAssStrat0_0.Add(typeof(PhenologyMaizeCrop2ML.Strategies.RegisterZadok).FullName);
			lAssStrat0_0.Add(typeof(PhenologyMaizeCrop2ML.Strategies.UpdateLeafFlag).FullName);
			lAssStrat0_0.Add(typeof(PhenologyMaizeCrop2ML.Strategies.UpdatePhase).FullName);
			lAssStrat0_0.Add(typeof(PhenologyMaizeCrop2ML.Strategies.Emergence).FullName);
			lAssStrat0_0.Add(typeof(PhenologyMaizeCrop2ML.Strategies.Germination).FullName);
			mo0_0.AssociatedStrategies = lAssStrat0_0;
			//Adding the modeling options to the modeling options manager

			//Creating the modeling options manager of the strategy
			_modellingOptionsManager = new ModellingOptionsManager(mo0_0);

			SetStaticParametersVarInfoDefinitions();
			SetPublisherData();

		}

		public PhenologyCrop2MLComposite(PhenologyCrop2MLComposite toCopy) : this()
		{
			//we only need to copy the parameters (the strategies being stateless)
			StopAtHarvest = toCopy.StopAtHarvest;
			HarvestDate = toCopy.HarvestDate;
			Dse = toCopy.Dse;
			PFLLAnth = toCopy.PFLLAnth;
			PHEADANTH = toCopy.PHEADANTH;
			Dcd = toCopy.Dcd;
			Dgf = toCopy.Dgf;
			Degfm = toCopy.Degfm;
			IgnoreGrainMaturation = toCopy.IgnoreGrainMaturation;
			Der = toCopy.Der;
			slopeTSFLN = toCopy.slopeTSFLN;
			intTSFLN = toCopy.intTSFLN;

			phyltip = toCopy.phyltip;
			Ntip0 = toCopy.Ntip0;
			k_bl = toCopy.k_bl;
			Nlim = toCopy.Nlim;
			Nfinal = toCopy.Nfinal;
			alpha_tr = toCopy.alpha_tr;
			a_ll1 = toCopy.a_ll1;
			k_ll = toCopy.k_ll;
			b_ll1 = toCopy.b_ll1;
			Lagmax = toCopy.Lagmax;
			waterStressCoeffSilk = toCopy.waterStressCoeffSilk;
			ASIbase = toCopy.ASIbase;
			LERc = toCopy.LERc;
			MinSoilWaterPotForGermination = toCopy.MinSoilWaterPotForGermination; //a decommenter quand germination aura ete ajoutee a la composite
			SoilWaterPotNoStress = toCopy.SoilWaterPotNoStress; //idem
			ShootGrowthRate = toCopy.ShootGrowthRate; //a decommenter quand emergence aura ete ajoutee a la composite
			EmergenceLag = toCopy.EmergenceLag;
			k_emergence = toCopy.k_emergence;
			SowingDensity = toCopy.SowingDensity;
			SowingDepth = toCopy.SowingDepth;
			btip = toCopy.btip;
			AbortLimitTT = toCopy.AbortLimitTT;
			NFSilkingInit = toCopy.NFSilkingInit;



		}

		#endregion

		#region Implementation of IAnnotatable

		/// <summary>
		/// Description of the model
		/// </summary>
		public string Description
		{
			get { return "Composite strategy which manage the phenology of Sirius Quality"; }
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

		#region Instances of the parameters

		// Getter and setters for the value of the parameters of the strategy. The actual parameters are stored into the ModelingOptionsManager of the strategy.


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

		// Getter and setters for the value of the parameters of a composite strategy

		public Double phyltip
		{
			get
			{
				return _calculateleafnumber.phyltip;
			}
			set
			{
				_calculateleafnumber.phyltip = value;
				_updatephase.phyltip = value;
			}
		}

		public Double AbortLimitTT
		{
			get
			{
				return _updatephase.AbortLimitTT;
			}
			set
			{
				_updatephase.AbortLimitTT = value;

			}
		}

		public Double NFSilkingInit
		{
			get
			{
				return _updatephase.NFSilkingInit;
			}
			set
			{
				_updatephase.NFSilkingInit = value;

			}
		}

		public Double Ntip0
		{
			get
			{
				return _calculateleafnumber.Ntip0;
			}
			set
			{
				_calculateleafnumber.Ntip0 = value;
			}
		}
		public Double k_bl
		{
			get
			{
				return _calculateleafnumber.k_bl;
			}
			set
			{
				_calculateleafnumber.k_bl = value;
			}
		}
		public Double Nlim
		{
			get
			{
				return _calculateleafnumber.Nlim;
			}
			set
			{
				_calculateleafnumber.Nlim = value;
			}
		}
		public Double Nfinal
		{
			get
			{
				return _calculateleafnumber.Nfinal;
			}
			set
			{
				_calculateleafnumber.Nfinal = value;
				_registerzadok.Nfinal = value;
				_updateleafflag.Nfinal = value;
				_updatephase.Nfinal = value;
			}
		}
		public Double a_ll1
		{
			get
			{
				return _calculateleafnumber.a_ll1;
			}
			set
			{
				_calculateleafnumber.a_ll1 = value;
			}
		}
		public Double b_ll1
		{
			get
			{
				return _calculateleafnumber.b_ll1;
			}
			set
			{
				_calculateleafnumber.b_ll1 = value;
			}
		}
		public Double Lagmax
		{
			get
			{
				return _calculateleafnumber.Lagmax;
			}
			set
			{
				_calculateleafnumber.Lagmax = value;
			}
		}
		public Double k_ll
		{
			get
			{
				return _calculateleafnumber.k_ll;
			}
			set
			{
				_calculateleafnumber.k_ll = value;
			}
		}
		public Double alpha_tr
		{
			get
			{
				return _calculateleafnumber.alpha_tr;
			}
			set
			{
				_calculateleafnumber.alpha_tr = value;
			}
		}
		public Double Dse
		{
			get
			{
				return _calculateleafnumber.Dse;
			}
			set
			{
				_calculateleafnumber.Dse = value;
				_updatephase.Dse = value;
				_emergence.Dse = value;
			}
		}
		public Double btip
		{
			get
			{
				return _calculateleafnumber.btip;
			}
			set
			{
				_calculateleafnumber.btip = value;
				_updatephase.btip = value;
			}
		}

		public Double Der
		{
			get
			{
				return _registerzadok.Der;
			}
			set
			{
				_registerzadok.Der = value;
			}
		}
		public Double slopeTSFLN
		{
			get
			{
				return _registerzadok.slopeTSFLN;
			}
			set
			{
				_registerzadok.slopeTSFLN = value;
			}
		}
		public Double intTSFLN
		{
			get
			{
				return _registerzadok.intTSFLN;
			}
			set
			{
				_registerzadok.intTSFLN = value;
			}
		}
		public Double PFLLAnth
		{
			get
			{
				return _updatephase.PFLLAnth;
			}
			set
			{
				_updatephase.PFLLAnth = value;
			}
		}
		public Double Dcd
		{
			get
			{
				return _updatephase.Dcd;
			}
			set
			{
				_updatephase.Dcd = value;
			}
		}
		public Double Dgf
		{
			get
			{
				return _updatephase.Dgf;
			}
			set
			{
				_updatephase.Dgf = value;
			}
		}
		public Double Degfm
		{
			get
			{
				return _updatephase.Degfm;
			}
			set
			{
				_updatephase.Degfm = value;
			}
		}
		public Int32 IgnoreGrainMaturation
		{
			get
			{
				return _updatephase.IgnoreGrainMaturation;
			}
			set
			{
				_updatephase.IgnoreGrainMaturation = value;
			}
		}
		public Double PHEADANTH
		{
			get
			{
				return _updatephase.PHEADANTH;
			}
			set
			{
				_updatephase.PHEADANTH = value;
			}
		}
		public Double LERc
		{
			get
			{
				return _updatephase.LERc;
			}
			set
			{
				_updatephase.LERc = value;
			}
		}
		public Double waterStressCoeffSilk
		{
			get
			{
				return _updatephase.waterStressCoeffSilk;
			}
			set
			{
				_updatephase.waterStressCoeffSilk = value;
			}
		}
		public Double ASIbase
		{
			get
			{
				return _updatephase.ASIbase;
			}
			set
			{
				_updatephase.ASIbase = value;
			}
		}
		public Double EmergenceLag
		{
			get
			{
				return _emergence.EmergenceLag;
			}
			set
			{
				_emergence.EmergenceLag = value;
			}
		}
		public Double ShootGrowthRate
		{
			get
			{
				return _emergence.ShootGrowthRate;
			}
			set
			{
				_emergence.ShootGrowthRate = value;
			}
		}
		public Double SowingDepth
		{
			get
			{
				return _emergence.SowingDepth;
			}
			set
			{
				_emergence.SowingDepth = value;
			}
		}
		public Double k_emergence
		{
			get
			{
				return _emergence.k_emergence;
			}
			set
			{
				_emergence.k_emergence = value;
			}
		}
		public Double MinSoilWaterPotForGermination
		{
			get
			{
				return _germination.MinSoilWaterPotForGermination;
			}
			set
			{
				_germination.MinSoilWaterPotForGermination = value;
			}
		}
		public Double SoilWaterPotNoStress
		{
			get
			{
				return _germination.SoilWaterPotNoStress;
			}
			set
			{
				_germination.SoilWaterPotNoStress = value;
			}
		}
		public Double SowingDensity
		{
			get
			{
				return _germination.SowingDensity;
			}
			set
			{
				_germination.SowingDensity = value;
			}
		}

		#endregion

		#region Parameters initialization method

		/// <summary>
		/// Set parameter(s) current values to the default value
		/// </summary>
		public void SetParametersDefaultValue()
		{
			_modellingOptionsManager.SetParametersDefaultValue();

			_calculateleafnumber.SetParametersDefaultValue();
			_registerzadok.SetParametersDefaultValue();
			_updateleafflag.SetParametersDefaultValue();
			_updatephase.SetParametersDefaultValue();
			_emergence.SetParametersDefaultValue();
			_germination.SetParametersDefaultValue();
			_ismomentregistered.SetParametersDefaultValue();

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
			phyltipVarInfo.Name = "phyltip";
			phyltipVarInfo.Description = " slope of leaf initiation";
			phyltipVarInfo.MaxValue = 1000;
			phyltipVarInfo.MinValue = 0;
			phyltipVarInfo.DefaultValue = 10;
			phyltipVarInfo.Units = "leaf/°Cday";
			phyltipVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			Ntip0VarInfo.Name = "Ntip0";
			Ntip0VarInfo.Description = " parameter for maize number of tip emerged";
			Ntip0VarInfo.MaxValue = 1000;
			Ntip0VarInfo.MinValue = 0;
			Ntip0VarInfo.DefaultValue = 10;
			Ntip0VarInfo.Units = "leaf";
			Ntip0VarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			k_blVarInfo.Name = "k_bl";
			k_blVarInfo.Description = " -";
			k_blVarInfo.MaxValue = 1000;
			k_blVarInfo.MinValue = 0;
			k_blVarInfo.DefaultValue = 0.708;
			k_blVarInfo.Units = "-";
			k_blVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			NlimVarInfo.Name = "Nlim";
			NlimVarInfo.Description = " -";
			NlimVarInfo.MaxValue = 1000;
			NlimVarInfo.MinValue = 0;
			NlimVarInfo.DefaultValue = 6;
			NlimVarInfo.Units = "leaf";
			NlimVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			NfinalVarInfo.Name = "Nfinal";
			NfinalVarInfo.Description = " final leaf number of the genotype";
			NfinalVarInfo.MaxValue = 25;
			NfinalVarInfo.MinValue = 0;
			NfinalVarInfo.DefaultValue = 16;
			NfinalVarInfo.Units = "leaf";
			NfinalVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			a_ll1VarInfo.Name = "a_ll1";
			a_ll1VarInfo.Description = " ligulochrone";
			a_ll1VarInfo.MaxValue = 1000;
			a_ll1VarInfo.MinValue = 0;
			a_ll1VarInfo.DefaultValue = 86;
			a_ll1VarInfo.Units = "ligulated leaf/°Cd";
			a_ll1VarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			b_ll1VarInfo.Name = "b_ll1";
			b_ll1VarInfo.Description = " thermal time of the first leaf ligulation";
			b_ll1VarInfo.MaxValue = 200;
			b_ll1VarInfo.MinValue = 0;
			b_ll1VarInfo.DefaultValue = 137;
			b_ll1VarInfo.Units = "°Cd";
			b_ll1VarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			LagmaxVarInfo.Name = "Lagmax";
			LagmaxVarInfo.Description = " Relative thermal time difference per leaf between ligulation and end of expansion";
			LagmaxVarInfo.MaxValue = 10;
			LagmaxVarInfo.MinValue = 0;
			LagmaxVarInfo.DefaultValue = 6;
			LagmaxVarInfo.Units = "°Cd/leaf";
			LagmaxVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			k_llVarInfo.Name = "k_ll";
			k_llVarInfo.Description = " Proportionality factor between a_ll1 and a_ll2";
			k_llVarInfo.MaxValue = 10;
			k_llVarInfo.MinValue = 0;
			k_llVarInfo.DefaultValue = 0.454;
			k_llVarInfo.Units = "-";
			k_llVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			alpha_trVarInfo.Name = "alpha_tr";
			alpha_trVarInfo.Description = " Transition between the two linear functions describing leaf ligulation with thermal time relative to Nfinal";
			alpha_trVarInfo.MaxValue = 10;
			alpha_trVarInfo.MinValue = 0;
			alpha_trVarInfo.DefaultValue = 0.52;
			alpha_trVarInfo.Units = "-";
			alpha_trVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			DseVarInfo.Name = "Dse";
			DseVarInfo.Description = " Thermal time between sowing and emergence";
			DseVarInfo.MaxValue = 1000;
			DseVarInfo.MinValue = 0;
			DseVarInfo.DefaultValue = 115;
			DseVarInfo.Units = "°Cd";
			DseVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			btipVarInfo.Name = "btip";
			btipVarInfo.Description = " Intercept of the regression of thermal time with tip appearance";
			btipVarInfo.MaxValue = 1000;
			btipVarInfo.MinValue = -1000;
			btipVarInfo.DefaultValue = -49;
			btipVarInfo.Units = "-";
			btipVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

			/*	stopLigulVarInfo.Name = "stopLigul";
				stopLigulVarInfo.Description =" fraction of final leaf number from the top of the plant with same growing thermal time";
				stopLigulVarInfo.MaxValue = 1;
				stopLigulVarInfo.MinValue = 0;
				stopLigulVarInfo.DefaultValue = 0.2;
				stopLigulVarInfo.Units = "-";
				stopLigulVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");
			*/


		}

		//Parameters static VarInfo list 

		private static VarInfo _phyltipVarInfo = new VarInfo();
		/// <summary> 
		///phyltip VarInfo definition
		/// </summary>
		public static VarInfo phyltipVarInfo
		{
			get { return _phyltipVarInfo; }
		}
		private static VarInfo _Ntip0VarInfo = new VarInfo();
		/// <summary> 
		///Ntip0 VarInfo definition
		/// </summary>
		public static VarInfo Ntip0VarInfo
		{
			get { return _Ntip0VarInfo; }
		}
		private static VarInfo _k_blVarInfo = new VarInfo();
		/// <summary> 
		///k_bl VarInfo definition
		/// </summary>
		public static VarInfo k_blVarInfo
		{
			get { return _k_blVarInfo; }
		}
		private static VarInfo _NlimVarInfo = new VarInfo();
		/// <summary> 
		///Nlim VarInfo definition
		/// </summary>
		public static VarInfo NlimVarInfo
		{
			get { return _NlimVarInfo; }
		}
		private static VarInfo _NfinalVarInfo = new VarInfo();
		/// <summary> 
		///Nfinal VarInfo definition
		/// </summary>
		public static VarInfo NfinalVarInfo
		{
			get { return _NfinalVarInfo; }
		}
		private static VarInfo _a_ll1VarInfo = new VarInfo();
		/// <summary> 
		///a_ll1 VarInfo definition
		/// </summary>
		public static VarInfo a_ll1VarInfo
		{
			get { return _a_ll1VarInfo; }
		}
		private static VarInfo _b_ll1VarInfo = new VarInfo();
		/// <summary> 
		///b_ll1 VarInfo definition
		/// </summary>
		public static VarInfo b_ll1VarInfo
		{
			get { return _b_ll1VarInfo; }
		}
		private static VarInfo _LagmaxVarInfo = new VarInfo();
		/// <summary> 
		///Lagmax VarInfo definition
		/// </summary>
		public static VarInfo LagmaxVarInfo
		{
			get { return _LagmaxVarInfo; }
		}
		private static VarInfo _k_llVarInfo = new VarInfo();
		/// <summary> 
		///k_ll VarInfo definition
		/// </summary>
		public static VarInfo k_llVarInfo
		{
			get { return _k_llVarInfo; }
		}
		private static VarInfo _alpha_trVarInfo = new VarInfo();
		/// <summary> 
		///alpha_tr VarInfo definition
		/// </summary>
		public static VarInfo alpha_trVarInfo
		{
			get { return _alpha_trVarInfo; }
		}
		private static VarInfo _DseVarInfo = new VarInfo();
		/// <summary> 
		///Dse VarInfo definition
		/// </summary>
		public static VarInfo DseVarInfo
		{
			get { return _DseVarInfo; }
		}
		private static VarInfo _btipVarInfo = new VarInfo();
		/// <summary> 
		///btip VarInfo definition
		/// </summary>
		public static VarInfo btipVarInfo
		{
			get { return _btipVarInfo; }
		}
		/*private static VarInfo _stopLigulVarInfo= new VarInfo();
		/// <summary> 
		///stopLigul VarInfo definition
		/// </summary>
		public static VarInfo stopLigulVarInfo
		{
			get { return _stopLigulVarInfo; }
		}	*/

		//Parameters static VarInfo list of the composite class


		#endregion


		#region Post/Pre Conditions
		public string TestPostConditions(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex, string callID)
		{
			try
			{
				//Set current values of the outputs to the static VarInfo representing the output properties of the domain classes				


				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();




				string ret = "";
				ret += _calculateleafnumber.TestPostConditions(s, s1, r, a, ex, callID);
				ret += _registerzadok.TestPostConditions(s, s1, r, a, ex, callID);
				ret += _updateleafflag.TestPostConditions(s, s1, r, a, ex, callID);
				ret += _updatephase.TestPostConditions(s, s1, r, a, ex, callID);
				ret += _emergence.TestPostConditions(s, s1, r, a, ex, callID);
				ret += _germination.TestPostConditions(s, s1, r, a, ex, callID);
				ret += _ismomentregistered.TestPostConditions(s, s1, r, a, ex, callID);
				if (ret != "") { pre.TestsOut(ret, true, "   postconditions tests of associated classes"); }

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


				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("StopAtHarvest")));


				string ret = "";
				ret += _calculateleafnumber.TestPreConditions(s, s1, r, a, ex, callID);
				ret += _registerzadok.TestPreConditions(s, s1, r, a, ex, callID);
				ret += _updateleafflag.TestPreConditions(s, s1, r, a, ex, callID);
				ret += _updatephase.TestPreConditions(s, s1, r, a, ex, callID);
				ret += _emergence.TestPreConditions(s, s1, r, a, ex, callID);
				ret += _germination.TestPreConditions(s, s1, r, a, ex, callID);
				ret += _ismomentregistered.TestPreConditions(s, s1, r, a, ex, callID);
				if (ret != "") { pre.TestsOut(ret, true, "   preconditions tests of associated classes"); }

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

		#region ModellingOptionsManager

		private ModellingOptionsManager _modellingOptionsManager;

		public ModellingOptionsManager ModellingOptionsManager
		{
			get { return _modellingOptionsManager; }
		}

		#endregion


		public IEnumerable<Type> GetStrategyDomainClassesTypes()
		{
			return new List<Type>() { typeof(PhenologyMaizeCrop2MLState), typeof(PhenologyMaizeCrop2MLState), typeof(PhenologyMaizeCrop2MLRate), typeof(PhenologyMaizeCrop2MLAuxiliary), typeof(PhenologyMaizeCrop2MLExogenous) };
		}

		public void Estimate(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{

			CalculateModel(s, s1, r, a, ex);
		}



		private void CalculateModel(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{
			EstimateOfAssociatedClasses(s, s1, r, a, ex);
		}

		private void EstimateOfAssociatedClasses(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex)
		{
			_ismomentregistered.Estimate(s, s1, r, a, ex);
			_germination.Estimate(s, s1, r, a, ex);
			_emergence.Estimate(s, s1, r, a, ex);
			_updatephase.Estimate(s, s1, r, a, ex);
			_calculateleafnumber.Estimate(s, s1, r, a, ex);
			_updateleafflag.Estimate(s, s1, r, a, ex);
			_registerzadok.Estimate(s, s1, r, a, ex);
			_updatecalendar.Estimate(s,s1,r,a,ex);



		}


	}
}
