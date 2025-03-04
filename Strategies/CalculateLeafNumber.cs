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
    class CalculateLeafNumber : PhenologyCrop2MLiStrategy
    {

		#region Constructor

		public CalculateLeafNumber()
		{

			ModellingOptions mo0_0 = new ModellingOptions();
			//Parameters
			List<VarInfo> _parameters0_0 = new List<VarInfo>();
			VarInfo v1 = new VarInfo();
			v1.DefaultValue = 10;
			v1.Description = "slope of leaf initiation";
			v1.Id = 0;
			v1.MaxValue = 1000;
			v1.MinValue = 0;
			v1.Name = "phyltip";
			v1.Size = 1;
			v1.Units = "leaf/°Cday";
			v1.URL = "";
			v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v1);
			VarInfo v2 = new VarInfo();
			v2.DefaultValue = 10;
			v2.Description = "parameter for maize number of tip emerged";
			v2.Id = 0;
			v2.MaxValue = 1000;
			v2.MinValue = 0;
			v2.Name = "Ntip0";
			v2.Size = 1;
			v2.Units = "leaf";
			v2.URL = "";
			v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v2.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v2);
			VarInfo v3 = new VarInfo();
			v3.DefaultValue = 0.708;
			v3.Description = "-";
			v3.Id = 0;
			v3.MaxValue = 1000;
			v3.MinValue = 0;
			v3.Name = "k_bl";
			v3.Size = 1;
			v3.Units = "-";
			v3.URL = "";
			v3.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v3.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v3);
			VarInfo v4 = new VarInfo();
			v4.DefaultValue = 6;
			v4.Description = "-";
			v4.Id = 0;
			v4.MaxValue = 1000;
			v4.MinValue = 0;
			v4.Name = "Nlim";
			v4.Size = 1;
			v4.Units = "leaf";
			v4.URL = "";
			v4.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v4.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v4);
			VarInfo v5 = new VarInfo();
			v5.DefaultValue = 16;
			v5.Description = "final leaf number of the genotype";
			v5.Id = 0;
			v5.MaxValue = 25;
			v5.MinValue = 0;
			v5.Name = "Nfinal";
			v5.Size = 1;
			v5.Units = "leaf";
			v5.URL = "";
			v5.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v5.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v5);
			VarInfo v6 = new VarInfo();
			v6.DefaultValue = 86;
			v6.Description = "ligulochrone";
			v6.Id = 0;
			v6.MaxValue = 1000;
			v6.MinValue = 0;
			v6.Name = "a_ll1";
			v6.Size = 1;
			v6.Units = "ligulated leaf/°Cd";
			v6.URL = "";
			v6.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v6.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v6);
			VarInfo v7 = new VarInfo();
			v7.DefaultValue = 137;
			v7.Description = "thermal time of the first leaf ligulation";
			v7.Id = 0;
			v7.MaxValue = 200;
			v7.MinValue = 0;
			v7.Name = "b_ll1";
			v7.Size = 1;
			v7.Units = "°Cd";
			v7.URL = "";
			v7.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v7.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v7);
			VarInfo v8 = new VarInfo();
			v8.DefaultValue = 6;
			v8.Description = "Relative thermal time difference per leaf between ligulation and end of expansion";
			v8.Id = 0;
			v8.MaxValue = 10;
			v8.MinValue = 0;
			v8.Name = "Lagmax";
			v8.Size = 1;
			v8.Units = "°Cd/leaf";
			v8.URL = "";
			v8.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v8.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v8);
			VarInfo v9 = new VarInfo();
			v9.DefaultValue = 0.454;
			v9.Description = "Proportionality factor between a_ll1 and a_ll2";
			v9.Id = 0;
			v9.MaxValue = 10;
			v9.MinValue = 0;
			v9.Name = "k_ll";
			v9.Size = 1;
			v9.Units = "-";
			v9.URL = "";
			v9.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v9.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v9);
			VarInfo v10 = new VarInfo();
			v10.DefaultValue = 0.52;
			v10.Description = "Transition between the two linear functions describing leaf ligulation with thermal time relative to Nfinal";
			v10.Id = 0;
			v10.MaxValue = 10;
			v10.MinValue = 0;
			v10.Name = "alpha_tr";
			v10.Size = 1;
			v10.Units = "-";
			v10.URL = "";
			v10.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v10.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v10);
			VarInfo v11 = new VarInfo();
			v11.DefaultValue = 115;
			v11.Description = "Thermal time between sowing and emergence";
			v11.Id = 0;
			v11.MaxValue = 1000;
			v11.MinValue = 0;
			v11.Name = "Dse";
			v11.Size = 1;
			v11.Units = "°Cd";
			v11.URL = "";
			v11.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v11.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v11);
			VarInfo v12 = new VarInfo();
			v12.DefaultValue = -49;
			v12.Description = "Intercept of the regression of thermal time with tip appearance";
			v12.Id = 0;
			v12.MaxValue = 1000;
			v12.MinValue = -1000;
			v12.Name = "btip";
			v12.Size = 1;
			v12.Units = "-";
			v12.URL = "";
			v12.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
			v12.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
			_parameters0_0.Add(v12);
			/*	VarInfo v13 = new VarInfo();
				 v13.DefaultValue = 0.2;
				 v13.Description = "fraction of final leaf number from the top of the plant with same growing thermal time";
				 v13.Id = 0;
				 v13.MaxValue = 1;
				 v13.MinValue = 0;
				 v13.Name = "stopLigul";
				 v13.Size = 1;
				 v13.Units = "-";
				 v13.URL = "";
				 v13.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v13.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v13);*/
			mo0_0.Parameters = _parameters0_0;
			//Inputs
			List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
			PropertyDescription pd1 = new PropertyDescription();
			pd1.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd1.PropertyName = "cumulTTPhenoMaizeAtEmergence";
			pd1.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence)).ValueType.TypeForCurrentValue;
			pd1.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence);
			_inputs0_0.Add(pd1);
			PropertyDescription pd2 = new PropertyDescription();
			pd2.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd2.PropertyName = "LeafNumber";
			pd2.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LeafNumber)).ValueType.TypeForCurrentValue;
			pd2.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
			_inputs0_0.Add(pd2);
			PropertyDescription pd3 = new PropertyDescription();
			pd3.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd3.PropertyName = "cumulTT";
			pd3.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.cumulTT)).ValueType.TypeForCurrentValue;
			pd3.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
			_inputs0_0.Add(pd3);
			PropertyDescription pd4 = new PropertyDescription();
			pd4.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd4.PropertyName = "HasFlagLeafLiguleAppeared";
			pd4.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared)).ValueType.TypeForCurrentValue;
			pd4.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared);
			_inputs0_0.Add(pd4);
			PropertyDescription pd5 = new PropertyDescription();
			pd5.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd5.PropertyName = "LNlig";
			pd5.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LNlig)).ValueType.TypeForCurrentValue;
			pd5.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LNlig);
			_inputs0_0.Add(pd5);
			PropertyDescription pd6 = new PropertyDescription();
			pd6.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd6.PropertyName = "LNfullyexp";
			pd6.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp)).ValueType.TypeForCurrentValue;
			pd6.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp);
			_inputs0_0.Add(pd6);
			PropertyDescription pd7 = new PropertyDescription();
			pd7.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd7.PropertyName = "nextStopExpFinalLeaf";
			pd7.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.nextStopExpFinalLeaf)).ValueType.TypeForCurrentValue;
			pd7.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.nextStopExpFinalLeaf);
			_inputs0_0.Add(pd7);
			PropertyDescription pd8 = new PropertyDescription();
			pd8.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd8.PropertyName = "fullyExpTT";
			pd8.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT)).ValueType.TypeForCurrentValue;
			pd8.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT);
			_inputs0_0.Add(pd8);
			PropertyDescription pd9 = new PropertyDescription();
			pd9.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd9.PropertyName = "liguleTT";
			pd9.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.liguleTT)).ValueType.TypeForCurrentValue;
			pd9.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.liguleTT);
			_inputs0_0.Add(pd9);
			PropertyDescription pd10 = new PropertyDescription();
			pd10.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd10.PropertyName = "startExpTT";
			pd10.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.startExpTT)).ValueType.TypeForCurrentValue;
			pd10.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.startExpTT);
			_inputs0_0.Add(pd10);
			PropertyDescription pd11 = new PropertyDescription();
			pd11.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd11.PropertyName = "tipTT";
			pd11.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.tipTT)).ValueType.TypeForCurrentValue;
			pd11.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.tipTT);
			_inputs0_0.Add(pd11);
			PropertyDescription pd12 = new PropertyDescription();
			pd12.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd12.PropertyName = "hasANewLeafAppeared";
			pd12.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared)).ValueType.TypeForCurrentValue;
			pd12.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared);
			_inputs0_0.Add(pd12);
			PropertyDescription pd13 = new PropertyDescription();
			pd13.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd13.PropertyName = "AllTTLeavesCalculated";
			pd13.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated)).ValueType.TypeForCurrentValue;
			pd13.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated);
			_inputs0_0.Add(pd13);
			mo0_0.Inputs = _inputs0_0;
			//Outputs
			List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
			PropertyDescription pd14 = new PropertyDescription();
			pd14.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd14.PropertyName = "LeafNumber";
			pd14.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LeafNumber)).ValueType.TypeForCurrentValue;
			pd14.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
			_outputs0_0.Add(pd14);
			PropertyDescription pd15 = new PropertyDescription();
			pd15.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd15.PropertyName = "Ntip";
			pd15.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.Ntip)).ValueType.TypeForCurrentValue;
			pd15.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.Ntip);
			_outputs0_0.Add(pd15);
			PropertyDescription pd16 = new PropertyDescription();
			pd16.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd16.PropertyName = "LNfullyexp";
			pd16.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp)).ValueType.TypeForCurrentValue;
			pd16.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp);
			_outputs0_0.Add(pd16);
			PropertyDescription pd17 = new PropertyDescription();
			pd17.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd17.PropertyName = "LNlig";
			pd17.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.LNlig)).ValueType.TypeForCurrentValue;
			pd17.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.LNlig);
			_outputs0_0.Add(pd17);
			PropertyDescription pd18 = new PropertyDescription();
			pd18.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd18.PropertyName = "startExpTT";
			pd18.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.startExpTT)).ValueType.TypeForCurrentValue;
			pd18.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.startExpTT);
			_outputs0_0.Add(pd18);
			PropertyDescription pd19 = new PropertyDescription();
			pd19.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd19.PropertyName = "liguleTT";
			pd19.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.liguleTT)).ValueType.TypeForCurrentValue;
			pd19.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.liguleTT);
			_outputs0_0.Add(pd19);
			PropertyDescription pd20 = new PropertyDescription();
			pd20.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd20.PropertyName = "fullyExpTT";
			pd20.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT)).ValueType.TypeForCurrentValue;
			pd20.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT);
			_outputs0_0.Add(pd20);
			PropertyDescription pd21 = new PropertyDescription();
			pd21.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd21.PropertyName = "tipTT";
			pd21.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.tipTT)).ValueType.TypeForCurrentValue;
			pd21.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.tipTT);
			_outputs0_0.Add(pd21);
			PropertyDescription pd22 = new PropertyDescription();
			pd22.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd22.PropertyName = "hasANewLeafAppeared";
			pd22.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared)).ValueType.TypeForCurrentValue;
			pd22.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared);
			_outputs0_0.Add(pd22);
			PropertyDescription pd23 = new PropertyDescription();
			pd23.DomainClassType = typeof(PhenologyMaizeCrop2MLState);
			pd23.PropertyName = "AllTTLeavesCalculated";
			pd23.PropertyType = ((PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated)).ValueType.TypeForCurrentValue;
			pd23.PropertyVarInfo = (PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated);
			_outputs0_0.Add(pd23);
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
			get { return "calculate leaf number. LeafNumber increase is caped at one more leaf per day"; }
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
			_pd.Add("Date", "24/06/2020");
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

		public Double phyltip
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("phyltip");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'phyltip' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("phyltip");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'phyltip' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double Ntip0
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Ntip0");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Ntip0' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Ntip0");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Ntip0' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double k_bl
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("k_bl");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'k_bl' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("k_bl");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'k_bl' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double Nlim
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nlim");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Nlim' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nlim");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Nlim' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double Nfinal
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Nfinal' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Nfinal' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double a_ll1
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("a_ll1");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'a_ll1' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("a_ll1");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'a_ll1' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double b_ll1
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("b_ll1");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'b_ll1' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("b_ll1");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'b_ll1' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double Lagmax
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Lagmax");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Lagmax' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Lagmax");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Lagmax' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double k_ll
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("k_ll");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'k_ll' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("k_ll");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'k_ll' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double alpha_tr
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("alpha_tr");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'alpha_tr' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("alpha_tr");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'alpha_tr' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double Dse
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dse");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'Dse' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("Dse");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'Dse' not found in strategy 'CalculateLeafNumber'");
			}
		}
		public Double btip
		{
			get
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("btip");
				if (vi != null && vi.CurrentValue != null) return (Double)vi.CurrentValue;
				else throw new Exception("Parameter 'btip' not found (or found null) in strategy 'CalculateLeafNumber'");
			}
			set
			{
				VarInfo vi = _modellingOptionsManager.GetParameterByName("btip");
				if (vi != null) vi.CurrentValue = value;
				else throw new Exception("Parameter 'btip' not found in strategy 'CalculateLeafNumber'");
			}
		}
		/*public Double stopLigul
		{ 
			get {
					VarInfo vi= _modellingOptionsManager.GetParameterByName("stopLigul");
					if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
					else throw new Exception("Parameter 'stopLigul' not found (or found null) in strategy 'CalculateLeafNumber'");
			 } set {
						VarInfo vi = _modellingOptionsManager.GetParameterByName("stopLigul");
						if (vi != null)  vi.CurrentValue=value;
					else throw new Exception("Parameter 'stopLigul' not found in strategy 'CalculateLeafNumber'");
			}
		}*/

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

		#region pre/post conditions management		

		/// <summary>
		/// Test to verify the postconditions
		/// </summary>
		public string TestPostConditions(PhenologyMaizeCrop2MLState s, PhenologyMaizeCrop2MLState s1, PhenologyMaizeCrop2MLRate r, PhenologyMaizeCrop2MLAuxiliary a, PhenologyMaizeCrop2MLExogenous ex, string callID)
		{
			try
			{
				//Set current values of the outputs to the static VarInfo representing the output properties of the domain classes				

				PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.CurrentValue = s.LeafNumber;
				PhenologyMaizeCrop2MLStateVarInfo.Ntip.CurrentValue = s.Ntip;
				PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp.CurrentValue = s.LNfullyexp;
				PhenologyMaizeCrop2MLStateVarInfo.LNlig.CurrentValue = s.LNlig;
				PhenologyMaizeCrop2MLStateVarInfo.startExpTT.CurrentValue = s.startExpTT;
				PhenologyMaizeCrop2MLStateVarInfo.liguleTT.CurrentValue = s.liguleTT;
				PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT.CurrentValue = s.fullyExpTT;
				PhenologyMaizeCrop2MLStateVarInfo.tipTT.CurrentValue = s.tipTT;
				PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared.CurrentValue = s.hasANewLeafAppeared;
				PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated.CurrentValue = s.AllTTLeavesCalculated;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r14 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
				if (r14.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.ValueType)) { prc.AddCondition(r14); }
				RangeBasedCondition r15 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.Ntip);
				if (r15.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.Ntip.ValueType)) { prc.AddCondition(r15); }
				RangeBasedCondition r16 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp);
				if (r16.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp.ValueType)) { prc.AddCondition(r16); }
				RangeBasedCondition r17 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LNlig);
				if (r17.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LNlig.ValueType)) { prc.AddCondition(r17); }
				RangeBasedCondition r18 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.startExpTT);
				if (r18.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.startExpTT.ValueType)) { prc.AddCondition(r18); }
				RangeBasedCondition r19 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.liguleTT);
				if (r19.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.liguleTT.ValueType)) { prc.AddCondition(r19); }
				RangeBasedCondition r20 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT);
				if (r20.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT.ValueType)) { prc.AddCondition(r20); }
				RangeBasedCondition r21 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.tipTT);
				if (r21.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.tipTT.ValueType)) { prc.AddCondition(r21); }
				RangeBasedCondition r22 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared);
				if (r22.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared.ValueType)) { prc.AddCondition(r22); }
				RangeBasedCondition r23 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated);
				if (r23.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated.ValueType)) { prc.AddCondition(r23); }



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

				PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence.CurrentValue = s.cumulTTPhenoMaizeAtEmergence;
				PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.CurrentValue = s.LeafNumber;
				PhenologyMaizeCrop2MLStateVarInfo.cumulTT.CurrentValue = s.cumulTT;
				PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared.CurrentValue = s.HasFlagLeafLiguleAppeared;
				PhenologyMaizeCrop2MLStateVarInfo.LNlig.CurrentValue = s.LNlig;
				PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp.CurrentValue = s.LNfullyexp;
				PhenologyMaizeCrop2MLStateVarInfo.nextStopExpFinalLeaf.CurrentValue = s.nextStopExpFinalLeaf;
				PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT.CurrentValue = s.fullyExpTT;
				PhenologyMaizeCrop2MLStateVarInfo.liguleTT.CurrentValue = s.liguleTT;
				PhenologyMaizeCrop2MLStateVarInfo.startExpTT.CurrentValue = s.startExpTT;
				PhenologyMaizeCrop2MLStateVarInfo.tipTT.CurrentValue = s.tipTT;
				PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared.CurrentValue = s.hasANewLeafAppeared;
				PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated.CurrentValue = s.AllTTLeavesCalculated;

				//Create the collection of the conditions to test
				ConditionsCollection prc = new ConditionsCollection();
				Preconditions pre = new Preconditions();


				RangeBasedCondition r1 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence);
				if (r1.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTTPhenoMaizeAtEmergence.ValueType)) { prc.AddCondition(r1); }
				RangeBasedCondition r2 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber);
				if (r2.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LeafNumber.ValueType)) { prc.AddCondition(r2); }
				RangeBasedCondition r3 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.cumulTT);
				if (r3.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.cumulTT.ValueType)) { prc.AddCondition(r3); }
				RangeBasedCondition r4 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared);
				if (r4.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.HasFlagLeafLiguleAppeared.ValueType)) { prc.AddCondition(r4); }
				RangeBasedCondition r5 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LNlig);
				if (r5.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LNlig.ValueType)) { prc.AddCondition(r5); }
				RangeBasedCondition r6 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp);
				if (r6.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.LNfullyexp.ValueType)) { prc.AddCondition(r6); }
				RangeBasedCondition r7 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.nextStopExpFinalLeaf);
				if (r7.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.nextStopExpFinalLeaf.ValueType)) { prc.AddCondition(r7); }
				RangeBasedCondition r8 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT);
				if (r8.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.fullyExpTT.ValueType)) { prc.AddCondition(r8); }
				RangeBasedCondition r9 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.liguleTT);
				if (r9.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.liguleTT.ValueType)) { prc.AddCondition(r9); }
				RangeBasedCondition r10 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.startExpTT);
				if (r10.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.startExpTT.ValueType)) { prc.AddCondition(r10); }
				RangeBasedCondition r11 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.tipTT);
				if (r11.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.tipTT.ValueType)) { prc.AddCondition(r11); }
				RangeBasedCondition r12 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared);
				if (r12.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.hasANewLeafAppeared.ValueType)) { prc.AddCondition(r12); }
				RangeBasedCondition r13 = new RangeBasedCondition(PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated);
				if (r13.ApplicableVarInfoValueTypes.Contains(PhenologyMaizeCrop2MLStateVarInfo.AllTTLeavesCalculated.ValueType)) { prc.AddCondition(r13); }
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("phyltip")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Ntip0")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("k_bl")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Nlim")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Nfinal")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("a_ll1")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("b_ll1")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Lagmax")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("k_ll")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("alpha_tr")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Dse")));
				prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("btip")));
				//prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("stopLigul")));



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
			double phase = s.phase;
			int HasFlagLeafLiguleAppeared = s.HasFlagLeafLiguleAppeared;
			int AllTTLeavesCalculated_t1 = s1.AllTTLeavesCalculated;
			double LeafNumber_t1 = s1.LeafNumber;
			double LNFullyExp_t1 = s1.LNfullyexp;
			double Ntip_t1 = s1.Ntip;
			double cumulTT6 = s.cumulTT[6];
			double cumulTTPhenoMaizeAtEmergence = s.cumulTTPhenoMaizeAtEmergence;
			double LeafNumber_t1 = s1.LeafNumber;
			double LNlig_t1 = s1.LNlig;
			double LNfullyexp_t1 = s1.LNfullyexp;

			List<double> startExpTT_t1 = s1.startExpTT;
			List<double> liguleTT_t1 = s1.liguleTT;
			List<double> tipTT_t1 = s1.tipTT;
			List<double> fullyExpTT_t1 = s1.fullyExpTT;


			List<double> startExpTT= new List<double>();
			List<double> liguleTT = new List<double>();
			List<double> tipTT = new List<double>();
			List<double> fullyExpTT = new List<double>();

			int AllTTLeavesCalculated;
			double Ntip = s.Ntip;
			double LeafNumber;
			double LNlig;
			double LNfullyexp ;

			//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section1
			//Code written below will not be overwritten by a future code generation

			//Added Pierrick 22/07; Pour FullyExpTT < AnthTTnoStress; à remplacer par AnthTT (le vrai)  

			//double AnthTTnoStress = 10E10;
			//if(phenologymaizestate.Calendar.IsMomentRegistred(GrowthStageMaize.BBCH_63_Anthesis)==1 && flag)
			//         {
			//	AnthTTnoStress = phenologymaizestate.cumulTT[6];
			//	flag = false;
			//         }
			//double AnthTTnoStress = phyltip * Nfinal + btip + phyltip /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/;

			if (phase >= 1 && phase < 4) { 
				double AnthTTnoStress = phyltip * (int)(Nfinal + 0.5) + btip + phyltip /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/;

				int roundedFinalLeafNumber = (int)(Nfinal + 0.5);//
																	//Nfinal;// (int) (Nfinal+0.5);

			
				for (int i = 0; i < startExpTT_t1.Count; i++)startExpTT.Add(startExpTT_t1[i]);

				for (int i = 0; i < liguleTT_t1.Count; i++) liguleTT.Add(liguleTT_t1[i]);

				
				for (int i = 0; i < tipTT_t1.Count; i++) tipTT.Add(tipTT_t1[i]);

				for (int i = 0; i < fullyExpTT_t1.Count; i++) fullyExpTT.Add(fullyExpTT_t1[i]);


				double Nlimll = alpha_tr * roundedFinalLeafNumber;
				double Nlimbl = Nlim;



				if (HasFlagLeafLiguleAppeared == 0)
				{//sowingToAnthesis
					if (AllTTLeavesCalculated_t1 == 0)
					{

						if (LeafNumber_t1 < Ntip0)
						{
							startExpTT.Add(/*phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/0.0);//be careful! if the equations need to be modified you need to do it here and below (from the line 1224)
							liguleTT.Add(a_ll1 + /*phenologymaizestate.cumulTTPhenoMaizeAtEmergence +*/ b_ll1);
							tipTT.Add(/*phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/0.0);
							fullyExpTT.Add(Math.Max(0.0, a_ll1 /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/ + b_ll1 - Lagmax));
						}


						for (var i = 1; i <= roundedFinalLeafNumber; i++)
						{
							//tip appearance
							double nextTipTT = 0.0;
							//double btip = -49;
							nextTipTT = phyltip * (i + 1) /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/ + btip;

							//leaf expansion
							double nextStartExpTT = 0.0;
							double phyl_bl = 0.0;
							if (i < Nlimbl) phyl_bl = phyltip;
							else phyl_bl = phyltip * k_bl;
							double bbl = btip + Nlimbl * phyltip * (1 - k_bl);
							if (i < Nlimbl) nextStartExpTT = nextTipTT;
							else { nextStartExpTT = phyl_bl * (i + 1) + bbl; } /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/

                            //ligulation
                            double nextLigTT1 = 0.0;
							double a_ll2 = a_ll1 * k_ll;
							double b_ll2 = a_ll1 * (int)(Nlimll + 0.5) * (1 - k_ll) + b_ll1;
							if (i < (int)(Nlimll + 0.5))
							//if (phenologymaizestate1.LeafNumber < Math.Floor(Nlimll + 0.5))
							{
								nextLigTT1 = a_ll1 * (i + 1) + b_ll1 /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/;
							}
							else
							{
								nextLigTT1 = a_ll2 * (i + 1) + b_ll2 /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/;
								//if (i >= roundedFinalLeafNumber - roundedFinalLeafNumber * stopLigul && i < roundedFinalLeafNumber - roundedFinalLeafNumber * stopLigul + 1) finalLeafLigTT = nextLigTT1;
								//if (i >= roundedFinalLeafNumber - roundedFinalLeafNumber * stopLigul) nextLigTT1 = finalLeafLigTT;
							}

							//End of leaf expansion
							double nextStopExpTT = 0.0d;
							if (i <= roundedFinalLeafNumber)
							{
								if (i < (int)(Nlimll + 0.5))
								{
									nextStopExpTT = (a_ll1 - Lagmax) * (i + 1) + b_ll1 /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/;
								}
								else
								{
									if (LNFullyExp_t1 <= roundedFinalLeafNumber) 
									{
										nextStopExpTT = (a_ll2 - Lagmax) * (i + 1) + b_ll2 /*+ phenologymaizestate.cumulTTPhenoMaizeAtEmergence*/;
									}
									//if (i >= roundedFinalLeafNumber * stopLigul) phenologymaizestate.nextStopExpFinalLeaf = nextStopExpTT;
									//if (i >= roundedFinalLeafNumber - roundedFinalLeafNumber * stopLigul && i < roundedFinalLeafNumber * stopLigul + 1) nextStopExpTT = phenologymaizestate.nextStopExpFinalLeaf;
								}

							}
							if (nextStopExpTT > AnthTTnoStress) nextStopExpTT = AnthTTnoStress;
							if (nextTipTT > 0) tipTT.Add(nextTipTT);
							else
							{
								tipTT.Add(0.0d);
/*								if (i > 3) throw new Exception("A tip of a leaf with rank >3 (rank " + i + ") appears at emergence: Your leaf apparence parametrization is not coherent," +
										 " the absolute value of the Intercept of the regression of thermal time " +
										 "with tip appearance (btip) might be too large or the value of" +
										 " others parameters relatively to low");*/
							}
							if (nextStartExpTT > 0) startExpTT.Add(nextStartExpTT);
							else
							{
								startExpTT.Add(0.0d);
							/*	if (i > 3) throw new Exception("A leaf with rank >3 (rank " + i + ") starts to expand at emergence: Your leaf apparence parametrization is not coherent," +
								 " the absolute value of the Intercept of the regression of thermal time " +
								 "with tip appearance (btip) might be too large or the value of" +
								 " others parameters relatively to low");*/


							}
							if (nextLigTT1 > 0) liguleTT.Add(nextLigTT1);
						/*	else
							{
*//*
								throw new Exception("A leaf with rank" + i + " is ligulate at emergence: Your leaf apparence parametrization is not coherent," +
								" the absolute value of the Intercept of the regression of thermal time " +
								"with tip appearance (btip) might be too large or the value of" +
							   " others parameters relatively to low");*//*
							}*/
							if (nextStopExpTT > 0) fullyExpTT.Add(nextStopExpTT);
/*							else
							{
								throw new Exception("A leaf with rank" + i + " is fully expanded at emergence: Your leaf apparence parametrization is not coherent," +
									 " the absolute value of the Intercept of the regression of thermal time " +
									 "with tip appearance (btip) might be too large or the value of" +
									 " others parameters relatively to low");
							}*/

						}
						AllTTLeavesCalculated = 1;

					}
					else
					{
						//tip number
						if (Ntip_t1 < roundedFinalLeafNumber)
						{
							int TipNb = Convert.ToInt32(Ntip_t1 + 1);
							if (cumulTT6 - cumulTTPhenoMaizeAtEmergence /*- btip*/ >= tipTT[TipNb - 1]) Ntip = Ntip_t1 + 1;
							else Ntip = Ntip_t1;
						}


						//growing leaf number
						if (LeafNumber_t1 < roundedFinalLeafNumber)
						{
							int LeafNb = Convert.ToInt32(LeafNumber_t1 + 1);
							if (cumulTT6 - cumulTTPhenoMaizeAtEmergence /*- btip*/ >= startExpTT[LeafNb - 1])
							{
								LeafNumber = LeafNumber_t1 + 1;

							}
							else LeafNumber = LeafNumber_t1;
						}


						//ligulated leaf number
						if (LNlig_t1 < roundedFinalLeafNumber)
						{
							int LigNb = Convert.ToInt32(LNlig_t1 + 1);
							if (cumulTT6 - cumulTTPhenoMaizeAtEmergence /*- btip*/ >= liguleTT[LigNb - 1])
							{
								LNlig = LNlig_t1 + 1;
							}
							else LNlig = LNlig_t1;
						}


						//fully expanded leaf number
						if (LNfullyexp_t1 < roundedFinalLeafNumber)
						{
							int FullyExpNb = Convert.ToInt32(LNfullyexp_t1 + 1);
							if (cumulTT6 - cumulTTPhenoMaizeAtEmergence /*- btip*/  >= fullyExpTT[FullyExpNb - 1])
							{
								LNfullyexp = LNfullyexp_t1 + 1;
							}
							else LNfullyexp = LNfullyexp_t1;
						}


					}
				}


				s.AllTTLeavesCalculated = AllTTLeavesCalculated;
				s.Ntip =  Ntip;
				s.LeafNumber = LeafNumber;
				s.LNlig = LNlig;
				s.LNfullyexp = LNfullyexp;
				
				
				s.startExpTT = startExpTT;
				s.liguleTT = liguleTT;
				s.tipTT = tipTT;
				s.fullyExpTT = fullyExpTT;




			}


		}
		#endregion
	}
}
