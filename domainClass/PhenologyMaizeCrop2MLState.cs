
using System;
using System.Collections.Generic;
using CRA.ModelLayer.Core;
using System.Reflection;
using CRA.ModelLayer.ParametersManagement;

namespace PhenologyMaizeCrop2ML.DomainClass

{

    public class PhenologyMaizeCrop2MLState : ICloneable, IDomainClass
    {
        #region Private fields
        private System.DateTime _currentdate = new DateTime();

        private System.Collections.Generic.List<double> _cumulTT = new List<double>();

        private double _GrainCumulTT;

        private double _GAI;

        private int _IsLatestLeafInternodeLengthPotPositive;

        //private Calendar _Calendar;
        private System.Collections.Generic.List<DateTime> _calendarDates = new List<DateTime>();
        private System.Collections.Generic.List<string> _calendarMoments = new List<string>();
        private System.Collections.Generic.List<double> _calendarCumuls = new List<double>();

        private double _LeafNumber;

        //private Phase _phase_;
        private double _phase;


        private int _HasFlagLeafLiguleAppeared;

        private int _hasLastPrimordiumAppeared;

        private int _isMomentRegistredBBCH_1n;

        private double _cumulTTFromBBCH_1n;

        private double _cumulTTFromBBCH_85;

        private double _cumulTTFromBBCH_63;

        //private GrowthStageMaize _currentBBCHStage;
        private string _currentBBCHStage;

        private int _hasBBCHStageChanged;

        private System.Collections.Generic.List<double> _tilleringProfile = new List<double>();

        private System.Collections.Generic.List<double> _leafTillerNumberArray = new List<double>();

        private double _CanopyShootNumber;

        private double _AverageShootNumberPerPlant;

        private int _TillerNumber;

        private double _Ntip;

        private double _cumulTTPhenoMaizeAtEmergence;

        private double _LNlig;

        private double _LNfullyexp;

        private double _nextStopExpFinalLeaf;

        private double _TT_Nlimll;

        private int _transition_lig;

        private double _LNliglim;

        private double _TTemergence;

        private int _hasGerminationHappened;

        private System.Collections.Generic.List<double> _liguleTT = new List<double>();

        private System.Collections.Generic.List<double> _fullyExpTT = new List<double>();

        private System.Collections.Generic.List<double> _startExpTT = new List<double>();

        private System.Collections.Generic.List<double> _tipTT = new List<double>();

        private int _hasANewLeafAppeared;

        private double _cumulTTFromLastLeaf;

        private int _hasFlagLeafAppeared;

        private int _hasSilkingStarted;

        private int _AllTTLeavesCalculated;

        private double _plantDensityAfterGermination;

        private double _SoilWaterPot;

        private int _dayNumber;

        private double _cumulTTSoil;

        private double _SumPsiSoil;

        private int _StopAtHarvestDate;
        #endregion

        #region Private field for properties
        private ParametersIO _parametersIO;
        #endregion
        
        #region Constructor
        public PhenologyMaizeCrop2MLState()
        {
            _parametersIO = new ParametersIO(this);
        }

        public PhenologyMaizeCrop2MLState(PhenologyMaizeCrop2MLState toCopy, bool copyAll) // copy constructor 
        {
            _parametersIO = new ParametersIO(this);
            /* _phase_ = (toCopy._phase_ != null) ? new Phase(toCopy._phase_) : null;
             _Calendar = (toCopy._Calendar != null) ? new Calendar(toCopy._Calendar) : null;*/

            _currentBBCHStage = toCopy._currentBBCHStage;
            _phase = toCopy._phase;

            _calendarDates = toCopy._calendarDates;


            _calendarMoments = toCopy._calendarMoments;

            _calendarCumuls = toCopy._calendarCumuls;

            _currentdate = toCopy._currentdate;
            _cumulTT = toCopy._cumulTT;
            _GrainCumulTT = toCopy._GrainCumulTT;
            _GAI = toCopy._GAI;
            _LeafNumber = toCopy._LeafNumber;

            _CanopyShootNumber = toCopy._CanopyShootNumber;
            _TillerNumber = toCopy._TillerNumber;
            _AverageShootNumberPerPlant = toCopy._AverageShootNumberPerPlant;
            _hasANewLeafAppeared = toCopy._hasANewLeafAppeared;

            tilleringProfile = new List<double>();
            for (int i = 0; i < toCopy.tilleringProfile.Count; i++)
            {
                tilleringProfile.Add(toCopy.tilleringProfile[i]);
            }
            _leafTillerNumberArray = new List<double>();
            for (int i = 0; i < toCopy.leafTillerNumberArray.Count; i++)
            {
                _leafTillerNumberArray.Add(toCopy._leafTillerNumberArray[i]);
            }
            //_liguleTT = new List<double>(toCopy._liguleTT);
            _liguleTT = new List<double>();
            for (int i = 0; i < toCopy._liguleTT.Count; i++) _liguleTT.Add(toCopy._liguleTT[i]);
            //_fullyExpTT = new List<double>(toCopy._fullyExpTT);
            _fullyExpTT = new List<double>();
            for (int i = 0; i < toCopy._fullyExpTT.Count; i++) _fullyExpTT.Add(toCopy._fullyExpTT[i]);
            //_startExpTT = new List<double>(toCopy._startExpTT);
            _startExpTT = new List<double>();
            for (int i = 0; i < toCopy._startExpTT.Count; i++) _startExpTT.Add(toCopy._startExpTT[i]);
            //_tipTT = new List<double>(toCopy._tipTT);
            _tipTT = new List<double>();
            for (int i = 0; i < toCopy._tipTT.Count; i++) _tipTT.Add(toCopy._tipTT[i]);

            _StopAtHarvestDate = toCopy._StopAtHarvestDate;


            if (copyAll)
            {
                _Ntip = toCopy._Ntip;
                _hasLastPrimordiumAppeared = toCopy._hasLastPrimordiumAppeared;
                _isMomentRegistredBBCH_1n = toCopy._isMomentRegistredBBCH_1n;
                _cumulTTFromBBCH_1n = toCopy._cumulTTFromBBCH_1n;
                _cumulTTFromBBCH_85 = toCopy._cumulTTFromBBCH_85;
                _cumulTTFromBBCH_63 = toCopy._cumulTTFromBBCH_63;
                _IsLatestLeafInternodeLengthPotPositive = toCopy._IsLatestLeafInternodeLengthPotPositive;
                _HasFlagLeafLiguleAppeared = toCopy._HasFlagLeafLiguleAppeared;
                _cumulTTPhenoMaizeAtEmergence = toCopy._cumulTTPhenoMaizeAtEmergence;
                _hasBBCHStageChanged = toCopy._hasBBCHStageChanged;
                _LNlig = toCopy._LNlig;
                _LNfullyexp = toCopy._LNfullyexp;
                _nextStopExpFinalLeaf = toCopy._nextStopExpFinalLeaf;
                _TT_Nlimll = toCopy._TT_Nlimll;
                _transition_lig = toCopy._transition_lig;
                _LNliglim = toCopy._LNliglim;
                _TTemergence = toCopy._TTemergence;
                _hasGerminationHappened = toCopy._hasGerminationHappened;
                _hasFlagLeafAppeared = toCopy._hasFlagLeafAppeared;
                _cumulTTFromLastLeaf = toCopy._cumulTTFromLastLeaf;
                _hasSilkingStarted = toCopy._hasSilkingStarted;
                _AllTTLeavesCalculated = toCopy._AllTTLeavesCalculated;
                _plantDensityAfterGermination = toCopy._plantDensityAfterGermination;
                _SoilWaterPot = toCopy._SoilWaterPot;
                _dayNumber = toCopy._dayNumber;
                _SumPsiSoil = toCopy._SumPsiSoil;
                _calendarDates = toCopy._calendarDates;


                _calendarMoments = toCopy._calendarMoments;

                _calendarCumuls = toCopy._calendarCumuls;

                _cumulTTSoil = toCopy._cumulTTSoil;

            }
        }
        #endregion
        
        #region Public properties
        /// <summary>current date</summary>
        public System.DateTime currentdate
        {
            get
            {
                return this._currentdate;
            }
            set
            {
                this._currentdate = value;
            }
        }

        /// <summary>array of the different cumulTT to be saved in the calendar. The first element is the one used to advance the phenology</summary>
        public System.Collections.Generic.List<double> cumulTT
        {
            get
            {
                return this._cumulTT;
            }
            set
            {
                this._cumulTT = value;
            }
        }

        /// <summary>cumulTT used for the grain developpment</summary>
        public double GrainCumulTT
        {
            get
            {
                return this._GrainCumulTT;
            }
            set
            {
                this._GrainCumulTT = value;
            }
        }

        /// <summary>green area index</summary>
        public double GAI
        {
            get
            {
                return this._GAI;
            }
            set
            {
                this._GAI = value;
            }
        }

        /// <summary>true if the potential length of the latest leaf's internode is positive. Used to test for the beginning stem expension</summary>
        public int IsLatestLeafInternodeLengthPotPositive
        {
            get
            {
                return this._IsLatestLeafInternodeLengthPotPositive;
            }
            set
            {
                this._IsLatestLeafInternodeLengthPotPositive = value;
            }
        }

        /// <summary>list of dates, one of the 3 lists used to  mimmic the orginal Calednar Class</summary>
        public System.Collections.Generic.List<DateTime> calendarDates
        {
            get { return this._calendarDates; }
            set { this._calendarDates = value; }
        }
        /// <summary>list of moments, one of the 3 lists used to  mimmic the orginal Calednar Class</summary>
        public System.Collections.Generic.List<string> calendarMoments
        {
            get { return this._calendarMoments; }
            set { this._calendarMoments = value; }
        }
        /// <summary>list of cumulTT, one of the 3 lists used to  mimmic the orginal Calednar Class</summary>
        public System.Collections.Generic.List<double> calendarCumuls
        {
            get { return this._calendarCumuls; }
            set { this._calendarCumuls = value; }
        }
        /// <summary>Actual number of phytomers</summary>
        public double LeafNumber
        {
            get
            {
                return this._LeafNumber;
            }
            set
            {
                this._LeafNumber = value;
            }
        }

        /// <summary>instance of the phase class . You can get the name of the phase using phase.getPhaseAsString(PhaseValue)</summary>
        public double phase
        {
            get
            {
                return this._phase;
            }
            set
            {
                this._phase = value;
            }
        }

        /// <summary>true if flag leaf has appeared (leafnumber reached finalLeafNumber)</summary>
        public int HasFlagLeafLiguleAppeared
        {
            get
            {
                return this._HasFlagLeafLiguleAppeared;
            }
            set
            {
                this._HasFlagLeafLiguleAppeared = value;
            }
        }

        /// <summary>true if the last primordium has appeared</summary>
        public int hasLastPrimordiumAppeared
        {
            get
            {
                return this._hasLastPrimordiumAppeared;
            }
            set
            {
                this._hasLastPrimordiumAppeared = value;
            }
        }

        /// <summary>true if ZC_39 is regitered in the calendar</summary>
        public int isMomentRegistredBBCH_1n
        {
            get
            {
                return this._isMomentRegistredBBCH_1n;
            }
            set
            {
                this._isMomentRegistredBBCH_1n = value;
            }
        }

        /// <summary>cumul of the thermal time ( DeltaTT) since the moment ZC_39</summary>
        public double cumulTTFromBBCH_1n
        {
            get
            {
                return this._cumulTTFromBBCH_1n;
            }
            set
            {
                this._cumulTTFromBBCH_1n = value;
            }
        }

        /// <summary>cumul of the thermal time (DeltaTT) since the moment ZC_91</summary>
        public double cumulTTFromBBCH_85
        {
            get
            {
                return this._cumulTTFromBBCH_85;
            }
            set
            {
                this._cumulTTFromBBCH_85 = value;
            }
        }

        /// <summary>cumul of the thermal time (DeltaTT) since the moment ZC_65</summary>
        public double cumulTTFromBBCH_63
        {
            get
            {
                return this._cumulTTFromBBCH_63;
            }
            set
            {
                this._cumulTTFromBBCH_63 = value;
            }
        }

        /// <summary>current zadok stage see the definition of "GrowthStage" in the Phase class</summary>
        public string currentBBCHStage
        {
            get
            {
                return this._currentBBCHStage;
            }
            set
            {
                this._currentBBCHStage = value;
            }
        }

        /// <summary>true if the zadok stage has changed this time step</summary>
        public int hasBBCHStageChanged
        {
            get
            {
                return this._hasBBCHStageChanged;
            }
            set
            {
                this._hasBBCHStageChanged = value;
            }
        }

        /// <summary>store the amount of new tiller created at each time a new tiller appears</summary>
        public System.Collections.Generic.List<double> tilleringProfile
        {
            get
            {
                return this._tilleringProfile;
            }
            set
            {
                this._tilleringProfile = value;
            }
        }

        /// <summary>store the number of tiller for each leaf layer</summary>
        public System.Collections.Generic.List<double> leafTillerNumberArray
        {
            get
            {
                return this._leafTillerNumberArray;
            }
            set
            {
                this._leafTillerNumberArray = value;
            }
        }

        /// <summary>shoot number for the whole canopy</summary>
        public double CanopyShootNumber
        {
            get
            {
                return this._CanopyShootNumber;
            }
            set
            {
                this._CanopyShootNumber = value;
            }
        }

        /// <summary>average shoot number per plant in the canopy</summary>
        public double AverageShootNumberPerPlant
        {
            get
            {
                return this._AverageShootNumberPerPlant;
            }
            set
            {
                this._AverageShootNumberPerPlant = value;
            }
        }

        /// <summary>number of tiller which have appeared</summary>
        public int TillerNumber
        {
            get
            {
                return this._TillerNumber;
            }
            set
            {
                this._TillerNumber = value;
            }
        }

        /// <summary>Maize number of tip</summary>
        public double Ntip
        {
            get
            {
                return this._Ntip;
            }
            set
            {
                this._Ntip = value;
            }
        }

        /// <summary>Cumul thermal time for maïze since emergence</summary>
        public double cumulTTPhenoMaizeAtEmergence
        {
            get
            {
                return this._cumulTTPhenoMaizeAtEmergence;
            }
            set
            {
                this._cumulTTPhenoMaizeAtEmergence = value;
            }
        }

        /// <summary>Number of ligulated leaves</summary>
        public double LNlig
        {
            get
            {
                return this._LNlig;
            }
            set
            {
                this._LNlig = value;
            }
        }

        /// <summary>Number of fully expanded leaves</summary>
        public double LNfullyexp
        {
            get
            {
                return this._LNfullyexp;
            }
            set
            {
                this._LNfullyexp = value;
            }
        }

        /// <summary>Thermal time threshold to reach to stop the final leaf growth</summary>
        public double nextStopExpFinalLeaf
        {
            get
            {
                return this._nextStopExpFinalLeaf;
            }
            set
            {
                this._nextStopExpFinalLeaf = value;
            }
        }

        /// <summary>Thermal time when Nlimll leaves have appeared</summary>
        public double TT_Nlimll
        {
            get
            {
                return this._TT_Nlimll;
            }
            set
            {
                this._TT_Nlimll = value;
            }
        }

        /// <summary>the value indicates in which part of the bilinear function used for ligulation you are</summary>
        public int transition_lig
        {
            get
            {
                return this._transition_lig;
            }
            set
            {
                this._transition_lig = value;
            }
        }

        /// <summary>ligulated leaf number at which you switch to the second part of the bilinear function of ligulation</summary>
        public double LNliglim
        {
            get
            {
                return this._LNliglim;
            }
            set
            {
                this._LNliglim = value;
            }
        }

        /// <summary>Thermal time threshold to reach to trigger emergence</summary>
        public double TTemergence
        {
            get
            {
                return this._TTemergence;
            }
            set
            {
                this._TTemergence = value;
            }
        }

        /// <summary>true if germination happened</summary>
        public int hasGerminationHappened
        {
            get
            {
                return this._hasGerminationHappened;
            }
            set
            {
                this._hasGerminationHappened = value;
            }
        }

        /// <summary>TT at ligule appeareance</summary>
        public System.Collections.Generic.List<double> liguleTT
        {
            get
            {
                return this._liguleTT;
            }
            set
            {
                this._liguleTT = value;
            }
        }

        /// <summary>TT at initiation, when fully expanded (liguleTT - 50)</summary>
        public System.Collections.Generic.List<double> fullyExpTT
        {
            get
            {
                return this._fullyExpTT;
            }
            set
            {
                this._fullyExpTT = value;
            }
        }

        /// <summary>Thermal Time at start of expansion (initTT + 100)</summary>
        public System.Collections.Generic.List<double> startExpTT
        {
            get
            {
                return this._startExpTT;
            }
            set
            {
                this._startExpTT = value;
            }
        }

        /// <summary>Thermal Time at tip emergence</summary>
        public System.Collections.Generic.List<double> tipTT
        {
            get
            {
                return this._tipTT;
            }
            set
            {
                this._tipTT = value;
            }
        }

        /// <summary>Flag for leaf appearence</summary>
        public int hasANewLeafAppeared
        {
            get
            {
                return this._hasANewLeafAppeared;
            }
            set
            {
                this._hasANewLeafAppeared = value;
            }
        }

        /// <summary>Cumul TT from last leave</summary>
        public double cumulTTFromLastLeaf
        {
            get
            {
                return this._cumulTTFromLastLeaf;
            }
            set
            {
                this._cumulTTFromLastLeaf = value;
            }
        }

        /// <summary>Flag for flag list appearence</summary>
        public int hasFlagLeafAppeared
        {
            get
            {
                return this._hasFlagLeafAppeared;
            }
            set
            {
                this._hasFlagLeafAppeared = value;
            }
        }

        /// <summary>Flag for start of silking</summary>
        public int hasSilkingStarted
        {
            get
            {
                return this._hasSilkingStarted;
            }
            set
            {
                this._hasSilkingStarted = value;
            }
        }

        /// <summary>True if all the thermal time thresholds of the leaves have been calculated</summary>
        public int AllTTLeavesCalculated
        {
            get
            {
                return this._AllTTLeavesCalculated;
            }
            set
            {
                this._AllTTLeavesCalculated = value;
            }
        }

        /// <summary>plant density after germination</summary>
        public double plantDensityAfterGermination
        {
            get
            {
                return this._plantDensityAfterGermination;
            }
            set
            {
                this._plantDensityAfterGermination = value;
            }
        }

        /// <summary>soil water potential</summary>
        public double SoilWaterPot
        {
            get
            {
                return this._SoilWaterPot;
            }
            set
            {
                this._SoilWaterPot = value;
            }
        }

        /// <summary>day sumber after sowing</summary>
        public int dayNumber
        {
            get
            {
                return this._dayNumber;
            }
            set
            {
                this._dayNumber = value;
            }
        }

        /// <summary>cumulated thermal time of the soil</summary>
        public double cumulTTSoil
        {
            get
            {
                return this._cumulTTSoil;
            }
            set
            {
                this._cumulTTSoil = value;
            }
        }

        /// <summary>sum of the daily soil water potentials</summary>
        public double SumPsiSoil
        {
            get
            {
                return this._SumPsiSoil;
            }
            set
            {
                this._SumPsiSoil = value;
            }
        }

        /// <summary>Switch to stop option at harvest date</summary>
        public int StopAtHarvestDate
        {
            get
            {
                return this._StopAtHarvestDate;
            }
            set
            {
                this._StopAtHarvestDate = value;
            }
        }
        #endregion

        #region IDomainClass members
        /// <summary>Domain Class description</summary>
        public virtual string Description
        {
            get
            {
                return "Domain class for the phenology component of Sirius Quality";
            }
        }

        /// <summary>Domain Class URL</summary>
        public virtual string URL
        {
            get
            {
                return "http://";
            }
        }

        /// <summary>Domain Class Properties</summary>
        public virtual IDictionary<string, PropertyInfo> PropertiesDescription
        {
            get
            {
                return _parametersIO.GetCachedProperties(typeof(IDomainClass));
            }
        }
        #endregion
        public virtual Boolean ClearValues()
        {
            _currentdate = new DateTime();
            _cumulTT = new List<double>();
            _GrainCumulTT = default(System.Double);
            _GAI = default(System.Double);
            _IsLatestLeafInternodeLengthPotPositive = default(System.Int32);
            _calendarDates = new List<DateTime>();
            _calendarMoments = new List<string>();
            _calendarCumuls = new List<double>();
            _LeafNumber = default(System.Double);
            _phase = default(System.Double);
            _HasFlagLeafLiguleAppeared = default(System.Int32);
            _hasLastPrimordiumAppeared = default(System.Int32);
            _isMomentRegistredBBCH_1n = default(System.Int32);
            _cumulTTFromBBCH_1n = default(System.Double);
            _cumulTTFromBBCH_85 = default(System.Double);
            _cumulTTFromBBCH_63 = default(System.Double);
            _currentBBCHStage =  null;
            _hasBBCHStageChanged = default(System.Int32);
            _tilleringProfile = new List<double>();
            _leafTillerNumberArray = new List<double>();
            _CanopyShootNumber = default(System.Double);
            _AverageShootNumberPerPlant = default(System.Double);
            _TillerNumber = default(System.Int32);
            _Ntip = default(System.Double);
            _cumulTTPhenoMaizeAtEmergence = default(System.Double);
            _LNlig = default(System.Double);
            _LNfullyexp = default(System.Double);
            _nextStopExpFinalLeaf = default(System.Double);
            _TT_Nlimll = default(System.Double);
            _transition_lig = default(System.Int32);
            _LNliglim = default(System.Double);
            _TTemergence = default(System.Double);
            _hasGerminationHappened = default(System.Int32);
            _liguleTT = new List<double>();
            _fullyExpTT = new List<double>();
            _startExpTT = new List<double>();
            _tipTT = new List<double>();
            _hasANewLeafAppeared = default(System.Int32);
            _cumulTTFromLastLeaf = default(System.Double);
            _hasFlagLeafAppeared = default(System.Int32);
            _hasSilkingStarted = default(System.Int32);
            _AllTTLeavesCalculated = default(System.Int32);
            _plantDensityAfterGermination = default(System.Double);
            _SoilWaterPot = default(System.Double);
            _dayNumber = default(System.Int32);
            _cumulTTSoil = default(System.Double);
            _SumPsiSoil = default(System.Double);
            _StopAtHarvestDate = default(System.Int32);
            // Returns true if everything is ok
            return true;
        }
        public virtual Object Clone()
        {
            IDomainClass myclass = (IDomainClass)this.MemberwiseClone();
            _parametersIO.PopulateClonedCopy(myclass);
            return myclass;
        }
    }
}