using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRA.ModelLayer.Core;



namespace PhenologyMaizeCrop2ML.DomainClass
{
    class PhenologyMaizeCrop2MLStateVarInfo : IVarInfoClass
    {
        static PhenologyMaizeCrop2MLStateVarInfo()
        {
            PhenologyMaizeCrop2MLStateVarInfo.DescribeVariables();
        }
        #region Private fields
        static VarInfo _currentdate = new VarInfo();

        static VarInfo _cumulTT = new VarInfo();

        static VarInfo _GrainCumulTT = new VarInfo();

        static VarInfo _GAI = new VarInfo();

        static VarInfo _IsLatestLeafInternodeLengthPotPositive = new VarInfo();

        //static VarInfo _Calendar = new VarInfo();
        static VarInfo _calendarDates = new VarInfo();
        static VarInfo _calendarMoments = new VarInfo();
        static VarInfo _calendarCumuls = new VarInfo();


        static VarInfo _currentBBCHStage = new VarInfo();

        static VarInfo _phase = new VarInfo();


        static VarInfo _LeafNumber = new VarInfo();


        static VarInfo _HasFlagLeafLiguleAppeared = new VarInfo();

        static VarInfo _hasLastPrimordiumAppeared = new VarInfo();

        static VarInfo _isMomentRegistredBBCH_1n = new VarInfo();

        static VarInfo _cumulTTFromBBCH_1n = new VarInfo();

        static VarInfo _cumulTTFromBBCH_85 = new VarInfo();

        static VarInfo _cumulTTFromBBCH_63 = new VarInfo();



        static VarInfo _hasBBCHStageChanged = new VarInfo();

        static VarInfo _tilleringProfile = new VarInfo();

        static VarInfo _leafTillerNumberArray = new VarInfo();

        static VarInfo _CanopyShootNumber = new VarInfo();

        static VarInfo _AverageShootNumberPerPlant = new VarInfo();

        static VarInfo _TillerNumber = new VarInfo();

        static VarInfo _Ntip = new VarInfo();

        static VarInfo _cumulTTPhenoMaizeAtEmergence = new VarInfo();

        static VarInfo _LNlig = new VarInfo();

        static VarInfo _LNfullyexp = new VarInfo();

        static VarInfo _nextStopExpFinalLeaf = new VarInfo();

        static VarInfo _TT_Nlimll = new VarInfo();

        static VarInfo _transition_lig = new VarInfo();

        static VarInfo _LNliglim = new VarInfo();

        static VarInfo _TTemergence = new VarInfo();

        static VarInfo _hasGerminationHappened = new VarInfo();

        static VarInfo _liguleTT = new VarInfo();

        static VarInfo _fullyExpTT = new VarInfo();

        static VarInfo _startExpTT = new VarInfo();

        static VarInfo _tipTT = new VarInfo();

        static VarInfo _hasANewLeafAppeared = new VarInfo();

        static VarInfo _cumulTTFromLastLeaf = new VarInfo();

        static VarInfo _hasFlagLeafAppeared = new VarInfo();

        static VarInfo _hasSilkingStarted = new VarInfo();

        static VarInfo _AllTTLeavesCalculated = new VarInfo();

        static VarInfo _plantDensityAfterGermination = new VarInfo();

        static VarInfo _SoilWaterPot = new VarInfo();

        static VarInfo _dayNumber = new VarInfo();

        static VarInfo _cumulTTSoil = new VarInfo();

        static VarInfo _SumPsiSoil = new VarInfo();

        static VarInfo _StopAtHarvestDate = new VarInfo();
        #endregion

        #region IVarInfoClass members
        /// <summary>Domain Class description</summary>
        public virtual string Description
        {
            get
            {
                return "Domain class for the phenology component of Sirius Quality";
            }
        }

        /// <summary>Reference to the ontology</summary>
        public string URL
        {
            get
            {
                return "http://";
            }
        }

        /// <summary>Value domain class of reference</summary>
        public string DomainClassOfReference
        {
            get
            {
                return "PhenologyMaizeState";
            }
        }
        #endregion

        #region VarInfo values
        static void DescribeVariables()
        {
            //   
            _currentdate.Name = "currentdate";
            _currentdate.Description = "current date";
            _currentdate.MaxValue = -1D;
            _currentdate.MinValue = -1D;
            _currentdate.DefaultValue = -1D;
            _currentdate.Units = "NA";
            _currentdate.URL = "http://";
            _currentdate.ValueType = VarInfoValueTypes.GetInstanceForName("Date");
            //   
            _cumulTT.Name = "cumulTT";
            _cumulTT.Description = "array of the different cumulTT to be saved in the calendar. The first element is " +
                "the one used to advance the phenology";
            _cumulTT.MaxValue = 10000D;
            _cumulTT.MinValue = 0D;
            _cumulTT.DefaultValue = 0D;
            _cumulTT.Units = "°Cd";
            _cumulTT.URL = "http://";
            _cumulTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _GrainCumulTT.Name = "GrainCumulTT";
            _GrainCumulTT.Description = "cumulTT used for the grain developpment";
            _GrainCumulTT.MaxValue = 10000D;
            _GrainCumulTT.MinValue = 0D;
            _GrainCumulTT.DefaultValue = 0D;
            _GrainCumulTT.Units = "°Cd";
            _GrainCumulTT.URL = "http://";
            _GrainCumulTT.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _GAI.Name = "GAI";
            _GAI.Description = "green area index";
            _GAI.MaxValue = 10000D;
            _GAI.MinValue = 0D;
            _GAI.DefaultValue = 0D;
            _GAI.Units = "m²/m²";
            _GAI.URL = "http://";
            _GAI.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _IsLatestLeafInternodeLengthPotPositive.Name = "IsLatestLeafInternodeLengthPotPositive";
            _IsLatestLeafInternodeLengthPotPositive.Description = "true if the potential length of the latest leaf\'s internode is positive. Used to " +
                "test for the beginning stem expension";
            _IsLatestLeafInternodeLengthPotPositive.MaxValue = 1D;
            _IsLatestLeafInternodeLengthPotPositive.MinValue = 0D;
            _IsLatestLeafInternodeLengthPotPositive.DefaultValue = 0D;
            _IsLatestLeafInternodeLengthPotPositive.Units = "NA";
            _IsLatestLeafInternodeLengthPotPositive.URL = "http://";
            _IsLatestLeafInternodeLengthPotPositive.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _calendarDates.Name = "calendarDates";
            _calendarDates.Description = "list of dates, one of the 3 lists used to  mimmic the orginal Calednar Class" ;
            _calendarDates.MaxValue = -1D;
            _calendarDates.MinValue = -1D;
            _calendarDates.DefaultValue = -1D;
            _calendarDates.Units = "NA";
            _calendarDates.URL = "http://";
            _calendarDates.ValueType = VarInfoValueTypes.GetInstanceForName("ListDate");

            _calendarMoments.Name = "calendarMoments";
            _calendarMoments.Description = "list of moments, one of the 3 lists used to  mimmic the orginal Calednar Class";
            _calendarMoments.MaxValue = -1D;
            _calendarMoments.MinValue = -1D;
            _calendarMoments.DefaultValue = -1D;
            _calendarMoments.Units = "NA";
            _calendarMoments.URL = "http://";
            _calendarMoments.ValueType = VarInfoValueTypes.GetInstanceForName("ListString");

            _calendarCumuls.Name = "calendarCumuls";
            _calendarCumuls.Description = "list of cumulTT, one of the 3 lists used to  mimmic the orginal Calednar Class" +
                " types of cumulated thermal times";
            _calendarCumuls.MaxValue = -1D;
            _calendarCumuls.MinValue = -1D;
            _calendarCumuls.DefaultValue = -1D;
            _calendarCumuls.Units = "NA";
            _calendarCumuls.URL = "http://";
            _calendarCumuls.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");

            //   
            _LeafNumber.Name = "LeafNumber";
            _LeafNumber.Description = "Actual number of phytomers";
            _LeafNumber.MaxValue = 25D;
            _LeafNumber.MinValue = 0D;
            _LeafNumber.DefaultValue = 0D;
            _LeafNumber.Units = "leaf";
            _LeafNumber.URL = "http://";
            _LeafNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _phase.Name = "phase";
            _phase.Description = "current develoipment phase, a number from 0 to  . You can get the name of the phase using phase.getPh" +
                "aseAsString(PhaseValue)";
            _phase.MaxValue = 7D;
            _phase.MinValue = 0D;
            _phase.DefaultValue = 0D;
            _phase.Units = "NA";
            _phase.URL = "http://";
            _phase.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _HasFlagLeafLiguleAppeared.Name = "HasFlagLeafLiguleAppeared";
            _HasFlagLeafLiguleAppeared.Description = "true if flag leaf has appeared (leafnumber reached finalLeafNumber)";
            _HasFlagLeafLiguleAppeared.MaxValue = 1D;
            _HasFlagLeafLiguleAppeared.MinValue = 0D;
            _HasFlagLeafLiguleAppeared.DefaultValue = 0D;
            _HasFlagLeafLiguleAppeared.Units = "NA";
            _HasFlagLeafLiguleAppeared.URL = "http://";
            _HasFlagLeafLiguleAppeared.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _hasLastPrimordiumAppeared.Name = "hasLastPrimordiumAppeared";
            _hasLastPrimordiumAppeared.Description = "true if the last primordium has appeared";
            _hasLastPrimordiumAppeared.MaxValue = 1D;
            _hasLastPrimordiumAppeared.MinValue = 0D;
            _hasLastPrimordiumAppeared.DefaultValue = 0D;
            _hasLastPrimordiumAppeared.Units = "NA";
            _hasLastPrimordiumAppeared.URL = "http://";
            _hasLastPrimordiumAppeared.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _isMomentRegistredBBCH_1n.Name = "isMomentRegistredBBCH_1n";
            _isMomentRegistredBBCH_1n.Description = "true if ZC_39 is regitered in the calendar";
            _isMomentRegistredBBCH_1n.MaxValue = 1D;
            _isMomentRegistredBBCH_1n.MinValue = 0D;
            _isMomentRegistredBBCH_1n.DefaultValue = 0D;
            _isMomentRegistredBBCH_1n.Units = "NA";
            _isMomentRegistredBBCH_1n.URL = "http://";
            _isMomentRegistredBBCH_1n.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _cumulTTFromBBCH_1n.Name = "cumulTTFromBBCH_1n";
            _cumulTTFromBBCH_1n.Description = "cumul of the thermal time ( DeltaTT) since the moment ZC_39";
            _cumulTTFromBBCH_1n.MaxValue = 10000D;
            _cumulTTFromBBCH_1n.MinValue = 0D;
            _cumulTTFromBBCH_1n.DefaultValue = 0D;
            _cumulTTFromBBCH_1n.Units = "°C/d";
            _cumulTTFromBBCH_1n.URL = "http://";
            _cumulTTFromBBCH_1n.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _cumulTTFromBBCH_85.Name = "cumulTTFromBBCH_85";
            _cumulTTFromBBCH_85.Description = "cumul of the thermal time (DeltaTT) since the moment ZC_91";
            _cumulTTFromBBCH_85.MaxValue = 10000D;
            _cumulTTFromBBCH_85.MinValue = 0D;
            _cumulTTFromBBCH_85.DefaultValue = 0D;
            _cumulTTFromBBCH_85.Units = "°C/d";
            _cumulTTFromBBCH_85.URL = "http://";
            _cumulTTFromBBCH_85.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _cumulTTFromBBCH_63.Name = "cumulTTFromBBCH_63";
            _cumulTTFromBBCH_63.Description = "cumul of the thermal time (DeltaTT) since the moment ZC_65";
            _cumulTTFromBBCH_63.MaxValue = 10000D;
            _cumulTTFromBBCH_63.MinValue = 0D;
            _cumulTTFromBBCH_63.DefaultValue = 0D;
            _cumulTTFromBBCH_63.Units = "°C/d";
            _cumulTTFromBBCH_63.URL = "http://";
            _cumulTTFromBBCH_63.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _currentBBCHStage.Name = "currentBBCHStage";
            _currentBBCHStage.Description = "current zadok stage as a string";
            _currentBBCHStage.MaxValue = 20D;
            _currentBBCHStage.MinValue = 0D;
            _currentBBCHStage.DefaultValue = 0D;
            _currentBBCHStage.Units = "NA";
            _currentBBCHStage.URL = "http://";
            _currentBBCHStage.ValueType = VarInfoValueTypes.GetInstanceForName("String");
            //   
            _hasBBCHStageChanged.Name = "hasBBCHStageChanged";
            _hasBBCHStageChanged.Description = "true if the zadok stage has changed this time step";
            _hasBBCHStageChanged.MaxValue = 1D;
            _hasBBCHStageChanged.MinValue = 0D;
            _hasBBCHStageChanged.DefaultValue = 0D;
            _hasBBCHStageChanged.Units = "NA";
            _hasBBCHStageChanged.URL = "http://";
            _hasBBCHStageChanged.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _tilleringProfile.Name = "tilleringProfile";
            _tilleringProfile.Description = "store the amount of new tiller created at each time a new tiller appears";
            _tilleringProfile.MaxValue = 0D;
            _tilleringProfile.MinValue = 0D;
            _tilleringProfile.DefaultValue = 0D;
            _tilleringProfile.Units = "NA";
            _tilleringProfile.URL = "http://";
            _tilleringProfile.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _leafTillerNumberArray.Name = "leafTillerNumberArray";
            _leafTillerNumberArray.Description = "store the number of tiller for each leaf layer";
            _leafTillerNumberArray.MaxValue = 0D;
            _leafTillerNumberArray.MinValue = 0D;
            _leafTillerNumberArray.DefaultValue = 0D;
            _leafTillerNumberArray.Units = "NA";
            _leafTillerNumberArray.URL = "http://";
            _leafTillerNumberArray.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _CanopyShootNumber.Name = "CanopyShootNumber";
            _CanopyShootNumber.Description = "shoot number for the whole canopy";
            _CanopyShootNumber.MaxValue = 1000D;
            _CanopyShootNumber.MinValue = 0D;
            _CanopyShootNumber.DefaultValue = 0D;
            _CanopyShootNumber.Units = "shoot/m²";
            _CanopyShootNumber.URL = "http://";
            _CanopyShootNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _AverageShootNumberPerPlant.Name = "AverageShootNumberPerPlant";
            _AverageShootNumberPerPlant.Description = "average shoot number per plant in the canopy";
            _AverageShootNumberPerPlant.MaxValue = 15D;
            _AverageShootNumberPerPlant.MinValue = 0D;
            _AverageShootNumberPerPlant.DefaultValue = 1D;
            _AverageShootNumberPerPlant.Units = "shoot";
            _AverageShootNumberPerPlant.URL = "http://";
            _AverageShootNumberPerPlant.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _TillerNumber.Name = "TillerNumber";
            _TillerNumber.Description = "number of tiller which have appeared";
            _TillerNumber.MaxValue = 15D;
            _TillerNumber.MinValue = 0D;
            _TillerNumber.DefaultValue = 1D;
            _TillerNumber.Units = "shoot";
            _TillerNumber.URL = "http://";
            _TillerNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _Ntip.Name = "Ntip";
            _Ntip.Description = "Maize number of tip";
            _Ntip.MaxValue = 20D;
            _Ntip.MinValue = 0D;
            _Ntip.DefaultValue = 16D;
            _Ntip.Units = "tip";
            _Ntip.URL = "http://";
            _Ntip.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _cumulTTPhenoMaizeAtEmergence.Name = "cumulTTPhenoMaizeAtEmergence";
            _cumulTTPhenoMaizeAtEmergence.Description = "Cumul thermal time for maïze since emergence";
            _cumulTTPhenoMaizeAtEmergence.MaxValue = 8000D;
            _cumulTTPhenoMaizeAtEmergence.MinValue = 0D;
            _cumulTTPhenoMaizeAtEmergence.DefaultValue = 140D;
            _cumulTTPhenoMaizeAtEmergence.Units = "°C/d";
            _cumulTTPhenoMaizeAtEmergence.URL = "http://";
            _cumulTTPhenoMaizeAtEmergence.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _LNlig.Name = "LNlig";
            _LNlig.Description = "Number of ligulated leaves";
            _LNlig.MaxValue = 25D;
            _LNlig.MinValue = 0D;
            _LNlig.DefaultValue = 0D;
            _LNlig.Units = "leaf";
            _LNlig.URL = "http://";
            _LNlig.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _LNfullyexp.Name = "LNfullyexp";
            _LNfullyexp.Description = "Number of fully expanded leaves";
            _LNfullyexp.MaxValue = 25D;
            _LNfullyexp.MinValue = 0D;
            _LNfullyexp.DefaultValue = 0D;
            _LNfullyexp.Units = "leaf";
            _LNfullyexp.URL = "http://";
            _LNfullyexp.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _nextStopExpFinalLeaf.Name = "nextStopExpFinalLeaf";
            _nextStopExpFinalLeaf.Description = "Thermal time threshold to reach to stop the final leaf growth";
            _nextStopExpFinalLeaf.MaxValue = 10000D;
            _nextStopExpFinalLeaf.MinValue = 0D;
            _nextStopExpFinalLeaf.DefaultValue = 0D;
            _nextStopExpFinalLeaf.Units = "°Cd";
            _nextStopExpFinalLeaf.URL = "http://";
            _nextStopExpFinalLeaf.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _TT_Nlimll.Name = "TT_Nlimll";
            _TT_Nlimll.Description = "Thermal time when Nlimll leaves have appeared";
            _TT_Nlimll.MaxValue = 10000D;
            _TT_Nlimll.MinValue = 0D;
            _TT_Nlimll.DefaultValue = 0D;
            _TT_Nlimll.Units = "°Cd";
            _TT_Nlimll.URL = "http://";
            _TT_Nlimll.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _transition_lig.Name = "transition_lig";
            _transition_lig.Description = "the value indicates in which part of the bilinear function used for ligulation yo" +
                "u are";
            _transition_lig.MaxValue = 1D;
            _transition_lig.MinValue = 0D;
            _transition_lig.DefaultValue = 0D;
            _transition_lig.Units = "NA";
            _transition_lig.URL = "http://";
            _transition_lig.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _LNliglim.Name = "LNliglim";
            _LNliglim.Description = "ligulated leaf number at which you switch to the second part of the bilinear func" +
                "tion of ligulation";
            _LNliglim.MaxValue = 30D;
            _LNliglim.MinValue = 0D;
            _LNliglim.DefaultValue = 0D;
            _LNliglim.Units = "leaf";
            _LNliglim.URL = "http://";
            _LNliglim.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _TTemergence.Name = "TTemergence";
            _TTemergence.Description = "Thermal time threshold to reach to trigger emergence";
            _TTemergence.MaxValue = 200D;
            _TTemergence.MinValue = 0D;
            _TTemergence.DefaultValue = 115D;
            _TTemergence.Units = "°Cd";
            _TTemergence.URL = "http://";
            _TTemergence.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _hasGerminationHappened.Name = "hasGerminationHappened";
            _hasGerminationHappened.Description = "true if germination happened";
            _hasGerminationHappened.MaxValue = 1D;
            _hasGerminationHappened.MinValue = 0D;
            _hasGerminationHappened.DefaultValue = 0D;
            _hasGerminationHappened.Units = "NA";
            _hasGerminationHappened.URL = "http://";
            _hasGerminationHappened.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _liguleTT.Name = "liguleTT";
            _liguleTT.Description = "TT at ligule appeareance";
            _liguleTT.MaxValue = 2000D;
            _liguleTT.MinValue = 0D;
            _liguleTT.DefaultValue = 0D;
            _liguleTT.Units = "°Cd";
            _liguleTT.URL = "http://";
            _liguleTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _fullyExpTT.Name = "fullyExpTT";
            _fullyExpTT.Description = "TT at initiation, when fully expanded (liguleTT - 50)";
            _fullyExpTT.MaxValue = 2000D;
            _fullyExpTT.MinValue = 0D;
            _fullyExpTT.DefaultValue = 0D;
            _fullyExpTT.Units = "°Cd";
            _fullyExpTT.URL = "http://";
            _fullyExpTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _startExpTT.Name = "startExpTT";
            _startExpTT.Description = "Thermal Time at start of expansion (initTT + 100)";
            _startExpTT.MaxValue = 2000D;
            _startExpTT.MinValue = 0D;
            _startExpTT.DefaultValue = 0D;
            _startExpTT.Units = "°Cd";
            _startExpTT.URL = "http://";
            _startExpTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _tipTT.Name = "tipTT";
            _tipTT.Description = "Thermal Time at tip emergence";
            _tipTT.MaxValue = 2000D;
            _tipTT.MinValue = 0D;
            _tipTT.DefaultValue = 0D;
            _tipTT.Units = "°Cd";
            _tipTT.URL = "http://";
            _tipTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _hasANewLeafAppeared.Name = "hasANewLeafAppeared";
            _hasANewLeafAppeared.Description = "Flag for leaf appearence";
            _hasANewLeafAppeared.MaxValue = 1D;
            _hasANewLeafAppeared.MinValue = 0D;
            _hasANewLeafAppeared.DefaultValue = 0D;
            _hasANewLeafAppeared.Units = "-";
            _hasANewLeafAppeared.URL = "http://";
            _hasANewLeafAppeared.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _cumulTTFromLastLeaf.Name = "cumulTTFromLastLeaf";
            _cumulTTFromLastLeaf.Description = "Cumul TT from last leave";
            _cumulTTFromLastLeaf.MaxValue = 2000D;
            _cumulTTFromLastLeaf.MinValue = 0D;
            _cumulTTFromLastLeaf.DefaultValue = 0D;
            _cumulTTFromLastLeaf.Units = "°Cd";
            _cumulTTFromLastLeaf.URL = "http://";
            _cumulTTFromLastLeaf.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _hasFlagLeafAppeared.Name = "hasFlagLeafAppeared";
            _hasFlagLeafAppeared.Description = "Flag for flag list appearence";
            _hasFlagLeafAppeared.MaxValue = 1D;
            _hasFlagLeafAppeared.MinValue = 0D;
            _hasFlagLeafAppeared.DefaultValue = 0D;
            _hasFlagLeafAppeared.Units = "-";
            _hasFlagLeafAppeared.URL = "http://";
            _hasFlagLeafAppeared.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _hasSilkingStarted.Name = "hasSilkingStarted";
            _hasSilkingStarted.Description = "Flag for start of silking";
            _hasSilkingStarted.MaxValue = 1D;
            _hasSilkingStarted.MinValue = 0D;
            _hasSilkingStarted.DefaultValue = 0D;
            _hasSilkingStarted.Units = "-";
            _hasSilkingStarted.URL = "http://";
            _hasSilkingStarted.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _AllTTLeavesCalculated.Name = "AllTTLeavesCalculated";
            _AllTTLeavesCalculated.Description = "True if all the thermal time thresholds of the leaves have been calculated";
            _AllTTLeavesCalculated.MaxValue = 1D;
            _AllTTLeavesCalculated.MinValue = 0D;
            _AllTTLeavesCalculated.DefaultValue = 0D;
            _AllTTLeavesCalculated.Units = "-";
            _AllTTLeavesCalculated.URL = "http://";
            _AllTTLeavesCalculated.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _plantDensityAfterGermination.Name = "plantDensityAfterGermination";
            _plantDensityAfterGermination.Description = "plant density after germination";
            _plantDensityAfterGermination.MaxValue = 100D;
            _plantDensityAfterGermination.MinValue = 0D;
            _plantDensityAfterGermination.DefaultValue = 6D;
            _plantDensityAfterGermination.Units = "plant/m2";
            _plantDensityAfterGermination.URL = "http://";
            _plantDensityAfterGermination.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _SoilWaterPot.Name = "SoilWaterPot";
            _SoilWaterPot.Description = "soil water potential";
            _SoilWaterPot.MaxValue = 1000D;
            _SoilWaterPot.MinValue = -1000D;
            _SoilWaterPot.DefaultValue = 0D;
            _SoilWaterPot.Units = "MPa";
            _SoilWaterPot.URL = "http://";
            _SoilWaterPot.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _dayNumber.Name = "dayNumber";
            _dayNumber.Description = "day sumber after sowing";
            _dayNumber.MaxValue = 1000D;
            _dayNumber.MinValue = 0D;
            _dayNumber.DefaultValue = 0D;
            _dayNumber.Units = "day";
            _dayNumber.URL = "http://";
            _dayNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _cumulTTSoil.Name = "cumulTTSoil";
            _cumulTTSoil.Description = "cumulated thermal time of the soil";
            _cumulTTSoil.MaxValue = 10000D;
            _cumulTTSoil.MinValue = 0D;
            _cumulTTSoil.DefaultValue = 0D;
            _cumulTTSoil.Units = "°Cd";
            _cumulTTSoil.URL = "http://";
            _cumulTTSoil.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _SumPsiSoil.Name = "SumPsiSoil";
            _SumPsiSoil.Description = "sum of the daily soil water potentials";
            _SumPsiSoil.MaxValue = 10000D;
            _SumPsiSoil.MinValue = -10000D;
            _SumPsiSoil.DefaultValue = 0D;
            _SumPsiSoil.Units = "MPa";
            _SumPsiSoil.URL = "http://";
            _SumPsiSoil.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _StopAtHarvestDate.Name = "StopAtHarvestDate";
            _StopAtHarvestDate.Description = "Switch to stop option at harvest date";
            _StopAtHarvestDate.MaxValue = 1D;
            _StopAtHarvestDate.MinValue = 0D;
            _StopAtHarvestDate.DefaultValue = 0D;
            _StopAtHarvestDate.Units = "-";
            _StopAtHarvestDate.URL = "http://";
            _StopAtHarvestDate.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
        }
        #endregion


        #region Public properties
        public static VarInfo currentdate
        {
            get
            {
                return _currentdate;
            }
        }

        /// <summary>array of the different cumulTT to be saved in the calendar. The first element is the one used to advance the phenology</summary>
        public static VarInfo cumulTT
        {
            get
            {
                return _cumulTT;
            }
        }

        /// <summary>cumulTT used for the grain developpment</summary>
        public static VarInfo GrainCumulTT
        {
            get
            {
                return _GrainCumulTT;
            }
        }

        /// <summary>green area index</summary>
        public static VarInfo GAI
        {
            get
            {
                return _GAI;
            }
        }

        /// <summary>true if the potential length of the latest leaf's internode is positive. Used to test for the beginning stem expension</summary>
        public static VarInfo IsLatestLeafInternodeLengthPotPositive
        {
            get
            {
                return _IsLatestLeafInternodeLengthPotPositive;
            }
        }

        /// <summary>Dictionnary containing for each stage the date it occurs as well as a copy of all types of cumulated thermal times</summary>
        /*      public static VarInfo Calendar
              {
                  get
                  {
                      return _Calendar;
                  }
              }*/
        /// <summary>list of dates, one of the 3 lists used to  mimmic the orginal Calednar Class</summary>
        public static VarInfo calendarDates
        {
            get { return _calendarDates; }
        }
        /// <summary>list of moments, one of the 3 lists used to  mimmic the orginal Calednar Class</summary>
        public static VarInfo calendarMoments
        {
            get 
            { 
                return _calendarMoments; 
            }
        }
        /// <summary>list of cumulTT, one of the 3 lists used to  mimmic the orginal Calednar Class</summary>
        public static VarInfo calendarCumuls
        {
            get { return _calendarCumuls; }
        }


        /// <summary>Actual number of phytomers</summary>
        public static VarInfo LeafNumber
        {
            get
            {
                return _LeafNumber;
            }
        }

        /// <summary>instance of the phase class . You can get the name of the phase using phase.getPhaseAsString(PhaseValue)</summary>
        public static VarInfo phase
        {
            get
            {
                return _phase;
            }
        }

        /// <summary>true if flag leaf has appeared (leafnumber reached finalLeafNumber)</summary>
        public static VarInfo HasFlagLeafLiguleAppeared
        {
            get
            {
                return _HasFlagLeafLiguleAppeared;
            }
        }

        /// <summary>true if the last primordium has appeared</summary>
        public static VarInfo hasLastPrimordiumAppeared
        {
            get
            {
                return _hasLastPrimordiumAppeared;
            }
        }

        /// <summary>true if ZC_39 is regitered in the calendar</summary>
        public static VarInfo isMomentRegistredBBCH_1n
        {
            get
            {
                return _isMomentRegistredBBCH_1n;
            }
        }

        /// <summary>cumul of the thermal time ( DeltaTT) since the moment ZC_39</summary>
        public static VarInfo cumulTTFromBBCH_1n
        {
            get
            {
                return _cumulTTFromBBCH_1n;
            }
        }

        /// <summary>cumul of the thermal time (DeltaTT) since the moment ZC_91</summary>
        public static VarInfo cumulTTFromBBCH_85
        {
            get
            {
                return _cumulTTFromBBCH_85;
            }
        }

        /// <summary>cumul of the thermal time (DeltaTT) since the moment ZC_65</summary>
        public static VarInfo cumulTTFromBBCH_63
        {
            get
            {
                return _cumulTTFromBBCH_63;
            }
        }

        /// <summary>current zadok stage see the definition of "GrowthStage" in the Phase class</summary>
        public static VarInfo currentBBCHStage
        {
            get
            {
                return _currentBBCHStage;
            }
        }

        /// <summary>true if the zadok stage has changed this time step</summary>
        public static VarInfo hasBBCHStageChanged
        {
            get
            {
                return _hasBBCHStageChanged;
            }
        }

        /// <summary>store the amount of new tiller created at each time a new tiller appears</summary>
        public static VarInfo tilleringProfile
        {
            get
            {
                return _tilleringProfile;
            }
        }

        /// <summary>store the number of tiller for each leaf layer</summary>
        public static VarInfo leafTillerNumberArray
        {
            get
            {
                return _leafTillerNumberArray;
            }
        }

        /// <summary>shoot number for the whole canopy</summary>
        public static VarInfo CanopyShootNumber
        {
            get
            {
                return _CanopyShootNumber;
            }
        }

        /// <summary>average shoot number per plant in the canopy</summary>
        public static VarInfo AverageShootNumberPerPlant
        {
            get
            {
                return _AverageShootNumberPerPlant;
            }
        }

        /// <summary>number of tiller which have appeared</summary>
        public static VarInfo TillerNumber
        {
            get
            {
                return _TillerNumber;
            }
        }

        /// <summary>Maize number of tip</summary>
        public static VarInfo Ntip
        {
            get
            {
                return _Ntip;
            }
        }

        /// <summary>Cumul thermal time for maïze since emergence</summary>
        public static VarInfo cumulTTPhenoMaizeAtEmergence
        {
            get
            {
                return _cumulTTPhenoMaizeAtEmergence;
            }
        }

        /// <summary>Number of ligulated leaves</summary>
        public static VarInfo LNlig
        {
            get
            {
                return _LNlig;
            }
        }

        /// <summary>Number of fully expanded leaves</summary>
        public static VarInfo LNfullyexp
        {
            get
            {
                return _LNfullyexp;
            }
        }

        /// <summary>Thermal time threshold to reach to stop the final leaf growth</summary>
        public static VarInfo nextStopExpFinalLeaf
        {
            get
            {
                return _nextStopExpFinalLeaf;
            }
        }

        /// <summary>Thermal time when Nlimll leaves have appeared</summary>
        public static VarInfo TT_Nlimll
        {
            get
            {
                return _TT_Nlimll;
            }
        }

        /// <summary>the value indicates in which part of the bilinear function used for ligulation you are</summary>
        public static VarInfo transition_lig
        {
            get
            {
                return _transition_lig;
            }
        }

        /// <summary>ligulated leaf number at which you switch to the second part of the bilinear function of ligulation</summary>
        public static VarInfo LNliglim
        {
            get
            {
                return _LNliglim;
            }
        }

        /// <summary>Thermal time threshold to reach to trigger emergence</summary>
        public static VarInfo TTemergence
        {
            get
            {
                return _TTemergence;
            }
        }

        /// <summary>true if germination happened</summary>
        public static VarInfo hasGerminationHappened
        {
            get
            {
                return _hasGerminationHappened;
            }
        }

        /// <summary>TT at ligule appeareance</summary>
        public static VarInfo liguleTT
        {
            get
            {
                return _liguleTT;
            }
        }

        /// <summary>TT at initiation, when fully expanded (liguleTT - 50)</summary>
        public static VarInfo fullyExpTT
        {
            get
            {
                return _fullyExpTT;
            }
        }

        /// <summary>Thermal Time at start of expansion (initTT + 100)</summary>
        public static VarInfo startExpTT
        {
            get
            {
                return _startExpTT;
            }
        }

        /// <summary>Thermal Time at tip emergence</summary>
        public static VarInfo tipTT
        {
            get
            {
                return _tipTT;
            }
        }

        /// <summary>Flag for leaf appearence</summary>
        public static VarInfo hasANewLeafAppeared
        {
            get
            {
                return _hasANewLeafAppeared;
            }
        }

        /// <summary>Cumul TT from last leave</summary>
        public static VarInfo cumulTTFromLastLeaf
        {
            get
            {
                return _cumulTTFromLastLeaf;
            }
        }

        /// <summary>Flag for flag list appearence</summary>
        public static VarInfo hasFlagLeafAppeared
        {
            get
            {
                return _hasFlagLeafAppeared;
            }
        }

        /// <summary>Flag for start of silking</summary>
        public static VarInfo hasSilkingStarted
        {
            get
            {
                return _hasSilkingStarted;
            }
        }

        /// <summary>True if all the thermal time thresholds of the leaves have been calculated</summary>
        public static VarInfo AllTTLeavesCalculated
        {
            get
            {
                return _AllTTLeavesCalculated;
            }
        }

        /// <summary>plant density after germination</summary>
        public static VarInfo plantDensityAfterGermination
        {
            get
            {
                return _plantDensityAfterGermination;
            }
        }

        /// <summary>soil water potential</summary>
        public static VarInfo SoilWaterPot
        {
            get
            {
                return _SoilWaterPot;
            }
        }

        /// <summary>day sumber after sowing</summary>
        public static VarInfo dayNumber
        {
            get
            {
                return _dayNumber;
            }
        }

        /// <summary>cumulated thermal time of the soil</summary>
        public static VarInfo cumulTTSoil
        {
            get
            {
                return _cumulTTSoil;
            }
        }

        /// <summary>sum of the daily soil water potentials</summary>
        public static VarInfo SumPsiSoil
        {
            get
            {
                return _SumPsiSoil;
            }
        }

        /// <summary>Switch to stop option at harvest date</summary>
        public static VarInfo StopAtHarvestDate
        {
            get
            {
                return _StopAtHarvestDate;
            }
        }
        #endregion


    }
}
