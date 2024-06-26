// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace FFXIVClientStructs.FFXIV.Client.UI.Misc;

/// <summary>
/// ConfigOption indexes for use with ConfigModule.
/// This enum will be incorrect after any patch that adds or removes any config options.
/// </summary>
public enum ConfigOption : short {
    Invalid = -1,
    None = 0,

    #region System
    // <FINAL FANTASY XIV Config File>
    // <Version>
    GuidVersion = 2,
    ConfigVersion = 3,
    Language = 4,
    Region = 5,
    // <Network Settings>
    UPnP = 7,
    Port = 8,
    LastLogin0 = 9,
    LastLogin1 = 10,
    WorldId = 11,
    ServiceIndex = 12,
    DktSessionId = 13,
    // <Display Settings>
    MainAdapter = 15,
    ScreenLeft = 16,
    ScreenTop = 17,
    ScreenWidth = 18,
    ScreenHeight = 19,
    ScreenMode = 20,
    FullScreenWidth = 21,
    FullScreenHeight = 22,
    Refreshrate = 23,
    Fps = 24,
    AntiAliasing = 25,
    FPSInActive = 26,
    ResoMouseDrag = 27,
    MouseOpeLimit = 28,
    LangSelectSub = 29,
    Gamma = 30,
    UiBaseScale = 31,
    CharaLight = 32,
    UiHighScale = 33,
    // <Graphics Settings>
    TextureFilterQuality = 35,
    TextureAnisotropicQuality = 36,
    SSAO = 37,
    Glare = 38,
    DistortionWater = 39,
    DepthOfField = 40,
    RadialBlur = 42,
    Vignetting = 43,
    GrassQuality = 44,
    TranslucentQuality = 45,
    ShadowVisibilityType = 46,
    ShadowSoftShadowType = 47,
    ShadowTextureSizeType = 48,
    ShadowCascadeCountType = 49,
    LodType = 50,
    StreamingType = 51,
    GeneralQuality = 52,
    OcclusionCulling = 53,
    ShadowLOD = 54,
    PhysicsType = 59,
    MapResolution = 60,
    ShadowVisibilityTypeSelf = 61,
    ShadowVisibilityTypeParty = 62,
    ShadowVisibilityTypeOther = 63,
    ShadowVisibilityTypeEnemy = 64,
    PhysicsTypeSelf = 65,
    PhysicsTypeParty = 66,
    PhysicsTypeOther = 67,
    PhysicsTypeEnemy = 68,
    ReflectionType = 69,
    ScreenShotImageType = 70,
    // <Sound Settings>
    IsSoundDisable = 72,
    IsSoundAlways = 73,
    IsSoundBgmAlways = 74,
    IsSoundSeAlways = 75,
    IsSoundVoiceAlways = 76,
    IsSoundSystemAlways = 77,
    IsSoundEnvAlways = 78,
    IsSoundPerformAlways = 79,
    // <Font Settings>
    // <GamePad Settings>
    PadGuid = 82,
    InstanceGuid = 83,
    ProductGuid = 84,
    DeadArea = 85,
    Alias = 86,
    AlwaysInput = 87,
    ForceFeedBack = 88,
    PadPovInput = 89,
    PadMode = 90,
    PadAvailable = 91,
    PadReverseConfirmCancel = 92,
    PadSelectButtonIcon = 93,
    PadMouseMode = 94,
    TextPasteEnable = 95,
    EnablePsFunction = 96,
    WaterWet = 97,
    DisplayObjectLimitType = 98,
    WindowDispNum = 99,
    ScreenShotDir = 100,
    // <Graphics Settings DX11>
    AntiAliasing_DX11 = 102,
    TextureFilterQuality_DX11 = 103,
    TextureAnisotropicQuality_DX11 = 104,
    SSAO_DX11 = 105,
    Glare_DX11 = 106,
    DistortionWater_DX11 = 107,
    DepthOfField_DX11 = 108,
    RadialBlur_DX11 = 109,
    Vignetting_DX11 = 110,
    GrassQuality_DX11 = 111,
    TranslucentQuality_DX11 = 112,
    ShadowSoftShadowType_DX11 = 113,
    ShadowTextureSizeType_DX11 = 114,
    ShadowCascadeCountType_DX11 = 115,
    LodType_DX11 = 116,
    OcclusionCulling_DX11 = 117,
    ShadowLOD_DX11 = 118,
    MapResolution_DX11 = 119,
    ShadowVisibilityTypeSelf_DX11 = 120,
    ShadowVisibilityTypeParty_DX11 = 121,
    ShadowVisibilityTypeOther_DX11 = 122,
    ShadowVisibilityTypeEnemy_DX11 = 123,
    PhysicsTypeSelf_DX11 = 124,
    PhysicsTypeParty_DX11 = 125,
    PhysicsTypeOther_DX11 = 126,
    PhysicsTypeEnemy_DX11 = 127,
    ReflectionType_DX11 = 128,
    WaterWet_DX11 = 129,
    ParallaxOcclusion_DX11 = 130,
    Tessellation_DX11 = 131,
    GlareRepresentation_DX11 = 132,
    DynamicRezoThreshold = 133,
    GraphicsRezoScale = 134,
    GraphicsRezoUpscaleType = 135,
    GrassEnableDynamicInterference = 136,
    ShadowBgLOD = 137,
    TextureRezoType = 138,
    ShadowLightValidType = 139,
    DynamicRezoEnableCutScene = 140,
    UiSystemEnlarge = 141,
    SoundPadSeType = 142,
    SoundPad = 143,
    IsSoundPad = 144,
    TouchPadMouse = 145,
    TouchPadCursorSpeed = 146,
    TouchPadButtonExtension = 147,
    TouchPadButton_Left = 148,
    TouchPadButton_Right = 149,
    RemotePlayRearTouchpadEnable = 150,
    SupportButtonAutorunEnable = 151,
    R3ButtonWindowScalingEnable = 152,
    AutoAfkSwitchingTime = 153,
    AutoChangeCameraMode = 154,
    AccessibilitySoundVisualEnable = 155,
    AccessibilitySoundVisualDispSize = 156,
    AccessibilitySoundVisualPermeabilityRate = 157,
    AccessibilityColorBlindFilterEnable = 158,
    AccessibilityColorBlindFilterType = 159,
    AccessibilityColorBlindFilterStrength = 160,
    // <Mouse Settings>
    MouseAutoFocus = 162,
    // <UI Settings>
    FPSDownAFK = 164,
    IdlingCameraAFK = 165,
    MouseSpeed = 186,
    CameraZoom = 208,
    DynamicRezoType = 323,
    // <Move Operation>
    Is3DAudio = 330,
    BattleEffect = 332,
    BGEffect = 333,
    ColorThemeType = 741,
    SystemMouseOperationSoftOn = 830,
    SystemMouseOperationTrajectory = 831,
    SystemMouseOperationCursorScaling = 832,
    HardwareCursorSize = 833,
    UiAssetType = 834,
    FellowshipShowNewNotice = 855,
    // <Cutscene Settings>
    CutsceneMovieVoice = 873,
    CutsceneMovieCaption = 874,
    CutsceneMovieOpening = 875,
    // <SoundPlay Settings>
    SoundMaster = 878,
    SoundBgm = 879,
    SoundSe = 880,
    SoundVoice = 881,
    SoundEnv = 882,
    SoundSystem = 883,
    SoundPerform = 884,
    SoundPlayer = 885,
    SoundParty = 886,
    SoundOther = 887,
    IsSndMaster = 888,
    IsSndBgm = 889,
    IsSndSe = 890,
    IsSndVoice = 891,
    IsSndEnv = 892,
    IsSndSystem = 893,
    IsSndPerform = 894,
    SoundDolby = 895,
    SoundMicpos = 896,
    SoundChocobo = 897,
    SoundFieldBattle = 898,
    SoundCfTimeCount = 899,
    SoundHousing = 900,
    SoundEqualizerType = 901,
    // <GamePad Button Settings>
    PadButton_L2 = 903,
    PadButton_R2 = 904,
    PadButton_L1 = 905,
    PadButton_R1 = 906,
    PadButton_Triangle = 907,
    PadButton_Circle = 908,
    PadButton_Cross = 909,
    PadButton_Square = 910,
    PadButton_Select = 911,
    PadButton_Start = 912,
    PadButton_LS = 913,
    PadButton_RS = 914,
    PadButton_L3 = 915,
    PadButton_R3 = 916,
    // <CUSTOM CONFIGURATION>
    #endregion

    #region Ui
    BattleEffectSelf = 55,
    BattleEffectParty = 56,
    BattleEffectOther = 57,
    BattleEffectPvPEnemyPc = 58,
    // <GamePad Settings>
    // <UI Settings>
    // <Charcter Settings>
    WeaponAutoPutAway = 167,
    WeaponAutoPutAwayTime = 168,
    LipMotionType = 169,
    // <Game Camera Settings>
    FirstPersonDefaultYAngle = 171,
    FirstPersonDefaultZoom = 172,
    FirstPersonDefaultDistance = 173,
    ThirdPersonDefaultYAngle = 174,
    ThirdPersonDefaultZoom = 175,
    ThirdPersonDefaultDistance = 176,
    LockonDefaultYAngle = 177,
    LockonDefaultZoom = 178,
    LockonDefaultZoom_179 = 179,
    CameraProductionOfAction = 203,
    FPSCameraInterpolationType = 204,
    FPSCameraVerticalInterpolation = 205,
    LegacyCameraCorrectionFix = 206,
    LegacyCameraType = 207,
    EventCameraAutoControl = 209,
    CameraLookBlinkType = 210,
    IdleEmoteTime = 211,
    IdleEmoteRandomType = 212,
    CutsceneSkipIsShip = 213,
    CutsceneSkipIsContents = 214,
    CutsceneSkipIsHousing = 215,
    PetTargetOffInCombat = 307,
    GroundTargetFPSPosX = 308,
    GroundTargetFPSPosY = 309,
    GroundTargetTPSPosX = 310,
    GroundTargetTPSPosY = 311,
    TargetDisableAnchor = 312,
    TargetCircleClickFilterEnableNearestCursor = 313,
    TargetEnableMouseOverSelect = 314,
    GroundTargetCursorCorrectType = 315,
    GroundTargetActionExcuteType = 316,
    AutoNearestTarget = 321,
    AutoNearestTargetType = 322,
    RightClickExclusionPC = 324,
    RightClickExclusionBNPC = 325,
    RightClickExclusionMinion = 326,
    TurnSpeed = 329,
    FootEffect = 331,
    LegacySeal = 334,
    GBarrelDisp = 335,
    EgiMirageTypeGaruda = 336,
    EgiMirageTypeTitan = 337,
    EgiMirageTypeIfrit = 338,
    BahamutSize = 339,
    PetMirageTypeCarbuncleSupport = 340,
    PhoenixSize = 341,
    GarudaSize = 342,
    TitanSize = 343,
    IfritSize = 344,
    SolBahamutSize = 345,
    PetMirageTypeFairy = 346,
    TimeMode = 347,
    Time12 = 348,
    TimeEorzea = 349,
    TimeLocal = 350,
    TimeServer = 351,
    ActiveLS_H = 352,
    ActiveLS_L = 353,
    HotbarLock = 355,
    HotbarDispRecastTime = 357,
    HotbarCrossContentsActionEnableInput = 358,
    HotbarDispRecastTimeDispType = 359,
    ExHotbarChangeHotbar1 = 372,
    HotbarCommon01 = 374,
    HotbarCommon02 = 375,
    HotbarCommon03 = 376,
    HotbarCommon04 = 377,
    HotbarCommon05 = 378,
    HotbarCommon06 = 379,
    HotbarCommon07 = 380,
    HotbarCommon08 = 381,
    HotbarCommon09 = 382,
    HotbarCommon10 = 383,
    HotbarCrossCommon01 = 384,
    HotbarCrossCommon02 = 385,
    HotbarCrossCommon03 = 386,
    HotbarCrossCommon04 = 387,
    HotbarCrossCommon05 = 388,
    HotbarCrossCommon06 = 389,
    HotbarCrossCommon07 = 390,
    HotbarCrossCommon08 = 391,
    HotbarCrossHelpDisp = 392,
    HotbarCrossOperation = 393,
    HotbarCrossDisp = 394,
    HotbarCrossLock = 395,
    HotbarCrossUsePadGuide = 398,
    HotbarCrossActiveSet = 399,
    HotbarCrossActiveSetPvP = 400,
    HotbarCrossSetChangeCustomIsAuto = 401,
    HotbarCrossSetChangeCustom = 403,
    HotbarCrossSetChangeCustomSet1 = 404,
    HotbarCrossSetChangeCustomSet2 = 405,
    HotbarCrossSetChangeCustomSet3 = 406,
    HotbarCrossSetChangeCustomSet4 = 407,
    HotbarCrossSetChangeCustomSet5 = 408,
    HotbarCrossSetChangeCustomSet6 = 409,
    HotbarCrossSetChangeCustomSet7 = 410,
    HotbarCrossSetChangeCustomSet8 = 411,
    HotbarCrossSetChangeCustomIsSword = 412,
    HotbarCrossSetChangeCustomIsSwordSet1 = 413,
    HotbarCrossSetChangeCustomIsSwordSet2 = 414,
    HotbarCrossSetChangeCustomIsSwordSet3 = 415,
    HotbarCrossSetChangeCustomIsSwordSet4 = 416,
    HotbarCrossSetChangeCustomIsSwordSet5 = 417,
    HotbarCrossSetChangeCustomIsSwordSet6 = 418,
    HotbarCrossSetChangeCustomIsSwordSet7 = 419,
    HotbarCrossSetChangeCustomIsSwordSet8 = 420,
    HotbarCrossAdvancedSetting = 421,
    HotbarCrossAdvancedSettingLeft = 422,
    HotbarCrossAdvancedSettingRight = 423,
    HotbarCrossSetPvpModeActive = 424,
    HotbarCrossSetChangeCustomPvp = 425,
    HotbarCrossSetChangeCustomIsAutoPvp = 426,
    HotbarCrossSetChangeCustomSet1Pvp = 427,
    HotbarCrossSetChangeCustomSet2Pvp = 428,
    HotbarCrossSetChangeCustomSet3Pvp = 429,
    HotbarCrossSetChangeCustomSet4Pvp = 430,
    HotbarCrossSetChangeCustomSet5Pvp = 431,
    HotbarCrossSetChangeCustomSet6Pvp = 432,
    HotbarCrossSetChangeCustomSet7Pvp = 433,
    HotbarCrossSetChangeCustomSet8Pvp = 434,
    HotbarCrossSetChangeCustomIsSwordPvp = 435,
    HotbarCrossSetChangeCustomIsSwordSet1Pvp = 436,
    HotbarCrossSetChangeCustomIsSwordSet2Pvp = 437,
    HotbarCrossSetChangeCustomIsSwordSet3Pvp = 438,
    HotbarCrossSetChangeCustomIsSwordSet4Pvp = 439,
    HotbarCrossSetChangeCustomIsSwordSet5Pvp = 440,
    HotbarCrossSetChangeCustomIsSwordSet6Pvp = 441,
    HotbarCrossSetChangeCustomIsSwordSet7Pvp = 442,
    HotbarCrossSetChangeCustomIsSwordSet8Pvp = 443,
    HotbarCrossAdvancedSettingPvp = 444,
    HotbarCrossAdvancedSettingLeftPvp = 445,
    HotbarCrossAdvancedSettingRightPvp = 446,
    HotbarWXHBEnable = 447,
    HotbarWXHBSetLeft = 448,
    HotbarWXHBSetRight = 449,
    HotbarWXHBEnablePvP = 450,
    HotbarWXHBSetLeftPvP = 451,
    HotbarWXHBSetRightPvP = 452,
    HotbarWXHB8Button = 453,
    HotbarWXHB8ButtonPvP = 454,
    HotbarWXHBSetInputTime = 455,
    HotbarWXHBDisplay = 456,
    HotbarWXHBFreeLayout = 457,
    HotbarXHBActiveTransmissionAlpha = 458,
    HotbarXHBAlphaDefault = 459,
    HotbarXHBAlphaActiveSet = 460,
    HotbarXHBAlphaInactiveSet = 461,
    HotbarWXHBInputOnce = 462,
    ExHotbarChangeHotbar1IsFashion = 463,
    HotbarCrossUseExDirectionAutoSwitch = 464,
    IdlingCameraSwitchType = 465,
    HotbarXHBEditEnable = 466,
    PlateType = 467,
    PlateDispHPBar = 468,
    PlateDisableMaxHPBar = 469,
    NamePlateHpSizeType = 470,
    NamePlateColorSelf = 471,
    NamePlateEdgeSelf = 472,
    NamePlateDispTypeSelf = 473,
    NamePlateNameTypeSelf = 474,
    NamePlateHpTypeSelf = 475,
    NamePlateColorSelfBuddy = 476,
    NamePlateEdgeSelfBuddy = 477,
    NamePlateDispTypeSelfBuddy = 478,
    NamePlateHpTypeSelfBuddy = 479,
    NamePlateColorSelfPet = 480,
    NamePlateEdgeSelfPet = 481,
    NamePlateDispTypeSelfPet = 482,
    NamePlateHpTypeSelfPet = 483,
    NamePlateColorParty = 484,
    NamePlateEdgeParty = 485,
    NamePlateDispTypeParty = 486,
    NamePlateNameTypeParty = 487,
    NamePlateHpTypeParty = 488,
    NamePlateDispTypePartyPet = 489,
    NamePlateHpTypePartyPet = 490,
    NamePlateDispTypePartyBuddy = 491,
    NamePlateHpTypePartyBuddy = 492,
    NamePlateColorAlliance = 493,
    NamePlateEdgeAlliance = 494,
    NamePlateDispTypeAlliance = 495,
    NamePlateNameTypeAlliance = 496,
    NamePlateHpTypeAlliance = 497,
    NamePlateDispTypeAlliancePet = 498,
    NamePlateHpTypeAlliancePet = 499,
    NamePlateColorOther = 500,
    NamePlateEdgeOther = 501,
    NamePlateDispTypeOther = 502,
    NamePlateNameTypeOther = 503,
    NamePlateHpTypeOther = 504,
    NamePlateDispTypeOtherPet = 505,
    NamePlateHpTypeOtherPet = 506,
    NamePlateDispTypeOtherBuddy = 507,
    NamePlateHpTypeOtherBuddy = 508,
    NamePlateColorUnengagedEnemy = 509,
    NamePlateEdgeUnengagedEnemy = 510,
    NamePlateDispTypeUnengagedEnemy = 511,
    NamePlateHpTypeUnengagedEmemy = 512,
    NamePlateColorEngagedEnemy = 513,
    NamePlateEdgeEngagedEnemy = 514,
    NamePlateDispTypeEngagedEnemy = 515,
    NamePlateHpTypeEngagedEmemy = 516,
    NamePlateColorClaimedEnemy = 517,
    NamePlateEdgeClaimedEnemy = 518,
    NamePlateDispTypeClaimedEnemy = 519,
    NamePlateHpTypeClaimedEmemy = 520,
    NamePlateColorUnclaimedEnemy = 521,
    NamePlateEdgeUnclaimedEnemy = 522,
    NamePlateDispTypeUnclaimedEnemy = 523,
    NamePlateHpTypeUnclaimedEmemy = 524,
    NamePlateColorNpc = 525,
    NamePlateEdgeNpc = 526,
    NamePlateDispTypeNpc = 527,
    NamePlateHpTypeNpc = 528,
    NamePlateColorObject = 529,
    NamePlateEdgeObject = 530,
    NamePlateDispTypeObject = 531,
    NamePlateHpTypeObject = 532,
    NamePlateColorMinion = 533,
    NamePlateEdgeMinion = 534,
    NamePlateDispTypeMinion = 535,
    NamePlateColorOtherBuddy = 536,
    NamePlateEdgeOtherBuddy = 537,
    NamePlateColorOtherPet = 538,
    NamePlateEdgeOtherPet = 539,
    NamePlateNameTitleTypeSelf = 540,
    NamePlateNameTitleTypeParty = 541,
    NamePlateNameTitleTypeAlliance = 542,
    NamePlateNameTitleTypeOther = 543,
    NamePlateNameTitleTypeFriend = 544,
    NamePlateColorFriend = 545,
    NamePlateColorFriendEdge = 546,
    NamePlateDispTypeFriend = 547,
    NamePlateNameTypeFriend = 548,
    NamePlateHpTypeFriend = 549,
    NamePlateDispTypeFriendPet = 550,
    NamePlateHpTypeFriendPet = 551,
    NamePlateDispTypeFriendBuddy = 552,
    NamePlateHpTypeFriendBuddy = 553,
    NamePlateColorLim = 554,
    NamePlateColorLimEdge = 555,
    NamePlateColorGri = 556,
    NamePlateColorGriEdge = 557,
    NamePlateColorUld = 558,
    NamePlateColorUldEdge = 559,
    NamePlateColorHousingFurniture = 560,
    NamePlateColorHousingFurnitureEdge = 561,
    NamePlateDispTypeHousingFurniture = 562,
    NamePlateColorHousingField = 563,
    NamePlateColorHousingFieldEdge = 564,
    NamePlateDispTypeHousingField = 565,
    NamePlateNameTypePvPEnemy = 566,
    NamePlateDispTypeFeast = 567,
    NamePlateNameTypeFeast = 568,
    NamePlateHpTypeFeast = 569,
    NamePlateDispTypeFeastPet = 570,
    NamePlateHpTypeFeastPet = 571,
    NamePlateNameTitleTypeFeast = 572,
    NamePlateDispSize = 573,
    NamePlateDispJobIcon = 574,
    NamePlateDispJobIconType = 575,
    NamePlateSetRoleColor = 576,
    NamePlateColorTank = 577,
    NamePlateEdgeTank = 578,
    NamePlateColorHealer = 579,
    NamePlateEdgeHealer = 580,
    NamePlateColorDps = 581,
    NamePlateEdgeDps = 582,
    NamePlateColorOtherClass = 583,
    NamePlateEdgeOtherClass = 584,
    NamePlateDispWorldTravel = 585,
    NamePlateDispJobIconInPublicParty = 586,
    NamePlateDispJobIconInPublicOther = 587,
    NamePlateDispJobIconInInstanceParty = 588,
    NamePlateDispJobIconInInstanceOther = 589,
    ActiveInfo = 590,
    PartyList = 591,
    PartyListStatus = 592,
    PartyListStatusTimer = 594,
    EnemyList = 595,
    TargetInfo = 596,
    Gil = 597,
    DTR = 598,
    PlayerInfo = 600,
    NaviMap = 601,
    Help = 602,
    CrossMainHelp = 604,
    HousingLocatePreview = 606,
    Log = 607,
    LogTell = 608,
    LogFontSize = 610,
    LogTabName2 = 611,
    LogTabName3 = 612,
    LogTabFilter0 = 613,
    LogTabFilter1 = 614,
    LogTabFilter2 = 615,
    LogTabFilter3 = 616,
    LogChatFilter = 617,
    LogEnableErrMsgLv1 = 618,
    LogNameType = 620,
    LogTimeDisp = 621,
    LogTimeSettingType = 622,
    LogTimeDispType = 623,
    IsLogTell = 624,
    IsLogParty = 625,
    LogParty = 626,
    IsLogAlliance = 627,
    LogAlliance = 628,
    IsLogFc = 629,
    LogFc = 630,
    IsLogPvpTeam = 631,
    LogPvpTeam = 632,
    IsLogLs1 = 633,
    LogLs1 = 634,
    IsLogLs2 = 635,
    LogLs2 = 636,
    IsLogLs3 = 637,
    LogLs3 = 638,
    IsLogLs4 = 639,
    LogLs4 = 640,
    IsLogLs5 = 641,
    LogLs5 = 642,
    IsLogLs6 = 643,
    LogLs6 = 644,
    IsLogLs7 = 645,
    LogLs7 = 646,
    IsLogLs8 = 647,
    LogLs8 = 648,
    IsLogBeginner = 649,
    LogBeginner = 650,
    IsLogCwls = 651,
    IsLogCwls2 = 652,
    IsLogCwls3 = 653,
    IsLogCwls4 = 654,
    IsLogCwls5 = 655,
    IsLogCwls6 = 656,
    IsLogCwls7 = 657,
    IsLogCwls8 = 658,
    LogCwls = 659,
    LogCwls2 = 660,
    LogCwls3 = 661,
    LogCwls4 = 662,
    LogCwls5 = 663,
    LogCwls6 = 664,
    LogCwls7 = 665,
    LogCwls8 = 666,
    LogRecastActionErrDisp = 667,
    LogPermeationRate = 668,
    LogFontSizeForm = 669,
    LogItemLinkEnableType = 670,
    LogFontSizeLog2 = 671,
    LogTimeDispLog2 = 672,
    LogPermeationRateLog2 = 673,
    LogFontSizeLog3 = 674,
    LogTimeDispLog3 = 675,
    LogPermeationRateLog3 = 676,
    LogFontSizeLog4 = 677,
    LogTimeDispLog4 = 678,
    LogPermeationRateLog4 = 679,
    LogFlyingHeightMaxErrDisp = 680,
    LogCrossWorldName = 681,
    LogDragResize = 682,
    LogNameIconType = 683,
    LogDispClassJobName = 684,
    LogSetRoleColor = 685,
    LogColorRoleTank = 686,
    LogColorRoleHealer = 687,
    LogColorRoleDPS = 688,
    LogColorOtherClass = 689,
    ChatType = 690,
    ShopSell = 691,
    ColorSay = 692,
    ColorShout = 693,
    ColorTell = 694,
    ColorParty = 695,
    ColorAlliance = 696,
    ColorLS1 = 697,
    ColorLS2 = 698,
    ColorLS3 = 699,
    ColorLS4 = 700,
    ColorLS5 = 701,
    ColorLS6 = 702,
    ColorLS7 = 703,
    ColorLS8 = 704,
    ColorFCompany = 705,
    ColorPvPGroup = 706,
    ColorPvPGroupAnnounce = 707,
    ColorBeginner = 708,
    ColorEmoteUser = 709,
    ColorEmote = 710,
    ColorYell = 711,
    ColorBeginnerAnnounce = 713,
    ColorCWLS = 714,
    ColorCWLS2 = 715,
    ColorCWLS3 = 716,
    ColorCWLS4 = 717,
    ColorCWLS5 = 718,
    ColorCWLS6 = 719,
    ColorCWLS7 = 720,
    ColorCWLS8 = 721,
    ColorAttackSuccess = 722,
    ColorAttackFailure = 723,
    ColorAction = 724,
    ColorItem = 725,
    ColorCureGive = 726,
    ColorBuffGive = 727,
    ColorDebuffGive = 728,
    ColorEcho = 729,
    ColorSysMsg = 730,
    ColorFCAnnounce = 731,
    ColorSysBattle = 732,
    ColorSysGathering = 733,
    ColorSysErr = 734,
    ColorNpcSay = 735,
    ColorItemNotice = 736,
    ColorGrowup = 737,
    ColorLoot = 738,
    ColorCraft = 739,
    ColorGathering = 740,
    ShopConfirm = 742,
    ShopConfirmMateria = 743,
    ShopConfirmExRare = 744,
    ShopConfirmSpiritBondMax = 745,
    ItemSortItemCategory = 746,
    ItemSortEquipLevel = 747,
    ItemSortItemLevel = 748,
    ItemSortItemStack = 749,
    ItemSortTidyingType = 750,
    ItemNoArmoryMaskOff = 751,
    ItemInventryStoreEnd = 752,
    InfoSettingDispWorldNameType = 765,
    TargetNamePlateNameType = 767,
    FocusTargetNamePlateNameType = 770,
    ItemDetailTemporarilySwitch = 772,
    ItemDetailTemporarilySwitchKey = 773,
    ItemDetailTemporarilyHide = 774,
    ItemDetailTemporarilyHideKey = 775,
    ToolTipDispSize = 785,
    RecommendLoginDisp = 786,
    RecommendAreaChangeDisp = 787,
    PlayGuideLoginDisp = 788,
    PlayGuideAreaChangeDisp = 789,
    MapPadOperationYReverse = 792,
    MapPadOperationXReverse = 793,
    MapDispSize = 795,
    FlyTextDispSize = 796,
    PopUpTextDispSize = 798,
    DetailDispDelayType = 799,
    PartyListSortTypeTank = 800,
    PartyListSortTypeHealer = 801,
    PartyListSortTypeDps = 802,
    PartyListSortTypeOther = 803,
    RatioHpDisp = 804,
    BuffDispType = 805,
    ContentsFinderListSortType = 808,
    ContentsFinderSupplyEnable = 809,
    EnemyListCastbarEnable = 815,
    AchievementAppealLoginDisp = 816,
    ContentsFinderUseLangTypeJA = 817,
    ContentsFinderUseLangTypeEN = 818,
    ContentsFinderUseLangTypeDE = 819,
    ContentsFinderUseLangTypeFR = 820,
    ItemInventryWindowSizeType = 828,
    ItemInventryRetainerWindowSizeType = 829,
    BattleTalkShowFace = 835,
    BannerContentsDispType = 836,
    BannerContentsNotice = 837,
    MipDispType = 838,
    BannerContentsOrderType = 839,
    CCProgressAllyFixLeftSide = 840,
    CCMapAllyFixLeftSide = 841,
    DispCCCountDown = 842,
    EmoteTextType = 843,
    IsEmoteSe = 844,
    EmoteSeType = 845,
    PartyFinderNewArrivalDisp = 846,
    GPoseTargetFilterNPCLookAt = 847,
    GPoseMotionFilterAction = 848,
    LsListSortPriority = 849,
    FriendListSortPriority = 850,
    FriendListFilterType = 851,
    FriendListSortType = 852,
    LetterListFilterType = 853,
    LetterListSortType = 854,
    ContentsReplayEnable = 856,
    MouseWheelOperationUp = 857,
    MouseWheelOperationDown = 858,
    MouseWheelOperationCtrlUp = 859,
    MouseWheelOperationCtrlDown = 860,
    MouseWheelOperationAltUp = 861,
    MouseWheelOperationAltDown = 862,
    MouseWheelOperationShiftUp = 863,
    MouseWheelOperationShiftDown = 864,
    TelepoTicketUseType = 865,
    TelepoTicketGilSetting = 866,
    TelepoCategoryType = 867,
    HidePcAroundQuestProgressNpc = 868,
    HidePcAroundQuestProgressNpcIncludeParty = 869,
    HidePcAroundNpcAccessingQuest = 870,
    HidePcAroundNpcAccessingQuestIncludeParty = 871,
    PvPFrontlinesGCFree = 876,
    #endregion

    #region UiControl
    // <Charcter Settings>
    AutoChangePointOfView = 180,
    KeyboardCameraInterpolationType = 181,
    KeyboardCameraVerticalInterpolation = 182,
    TiltOffset = 183,
    KeyboardSpeed = 184,
    PadSpeed = 185,
    PadFpsXReverse = 187,
    PadFpsYReverse = 188,
    PadTpsXReverse = 189,
    PadTpsYReverse = 190,
    MouseFpsXReverse = 191,
    MouseFpsYReverse = 192,
    MouseTpsXReverse = 193,
    MouseTpsYReverse = 194,
    MouseCharaViewRotYReverse = 195,
    MouseCharaViewRotXReverse = 196,
    MouseCharaViewMoveYReverse = 197,
    MouseCharaViewMoveXReverse = 198,
    PADCharaViewRotYReverse = 199,
    PADCharaViewRotXReverse = 200,
    PADCharaViewMoveYReverse = 201,
    PADCharaViewMoveXReverse = 202,
    FlyingControlType = 216,
    FlyingLegacyAutorun = 217,
    // <Target Settings>
    AutoFaceTargetOnAction = 219,
    SelfClick = 220,
    NoTargetClickCancel = 221,
    AutoTarget = 222,
    TargetTypeSelect = 223,
    AutoLockOn = 224,
    CircleBattleModeAutoChange = 226,
    CircleIsCustom = 227,
    CircleSwordDrawnIsActive = 228,
    CircleSwordDrawnNonPartyPc = 229,
    CircleSwordDrawnParty = 230,
    CircleSwordDrawnEnemy = 231,
    CircleSwordDrawnAggro = 232,
    CircleSwordDrawnNpcOrObject = 233,
    CircleSwordDrawnMinion = 234,
    CircleSwordDrawnDutyEnemy = 235,
    CircleSwordDrawnPet = 236,
    CircleSwordDrawnAlliance = 237,
    CircleSwordDrawnMark = 238,
    CircleSheathedIsActive = 239,
    CircleSheathedNonPartyPc = 240,
    CircleSheathedParty = 241,
    CircleSheathedEnemy = 242,
    CircleSheathedAggro = 243,
    CircleSheathedNpcOrObject = 244,
    CircleSheathedMinion = 245,
    CircleSheathedDutyEnemy = 246,
    CircleSheathedPet = 247,
    CircleSheathedAlliance = 248,
    CircleSheathedMark = 249,
    CircleClickIsActive = 250,
    CircleClickNonPartyPc = 251,
    CircleClickParty = 252,
    CircleClickEnemy = 253,
    CircleClickAggro = 254,
    CircleClickNpcOrObject = 255,
    CircleClickMinion = 256,
    CircleClickDutyEnemy = 257,
    CircleClickPet = 258,
    CircleClickAlliance = 259,
    CircleClickMark = 260,
    CircleXButtonIsActive = 261,
    CircleXButtonNonPartyPc = 262,
    CircleXButtonParty = 263,
    CircleXButtonEnemy = 264,
    CircleXButtonAggro = 265,
    CircleXButtonNpcOrObject = 266,
    CircleXButtonMinion = 267,
    CircleXButtonDutyEnemy = 268,
    CircleXButtonPet = 269,
    CircleXButtonAlliance = 270,
    CircleXButtonMark = 271,
    CircleYButtonIsActive = 272,
    CircleYButtonNonPartyPc = 273,
    CircleYButtonParty = 274,
    CircleYButtonEnemy = 275,
    CircleYButtonAggro = 276,
    CircleYButtonNpcOrObject = 277,
    CircleYButtonMinion = 278,
    CircleYButtonDutyEnemy = 279,
    CircleYButtonPet = 280,
    CircleYButtonAlliance = 281,
    CircleYButtonMark = 282,
    CircleBButtonIsActive = 283,
    CircleBButtonNonPartyPc = 284,
    CircleBButtonParty = 285,
    CircleBButtonEnemy = 286,
    CircleBButtonAggro = 287,
    CircleBButtonNpcOrObject = 288,
    CircleBButtonMinion = 289,
    CircleBButtonDutyEnemy = 290,
    CircleBButtonPet = 291,
    CircleBButtonAlliance = 292,
    CircleBButtonMark = 293,
    CircleAButtonIsActive = 294,
    CircleAButtonNonPartyPc = 295,
    CircleAButtonParty = 296,
    CircleAButtonEnemy = 297,
    CircleAButtonAggro = 298,
    CircleAButtonNpcOrObject = 299,
    CircleAButtonMinion = 300,
    CircleAButtonDutyEnemy = 301,
    CircleAButtonPet = 302,
    CircleAButtonAlliance = 303,
    CircleAButtonMark = 304,
    GroundTargetType = 305,
    GroundTargetCursorSpeed = 306,
    TargetCircleType = 317,
    TargetLineType = 318,
    LinkLineType = 319,
    ObjectBorderingType = 320,
    MoveMode = 328,
    HotbarDisp = 354,
    HotbarEmptyVisible = 356,
    HotbarNoneSlotDisp01 = 360,
    HotbarNoneSlotDisp02 = 361,
    HotbarNoneSlotDisp03 = 362,
    HotbarNoneSlotDisp04 = 363,
    HotbarNoneSlotDisp05 = 364,
    HotbarNoneSlotDisp06 = 365,
    HotbarNoneSlotDisp07 = 366,
    HotbarNoneSlotDisp08 = 367,
    HotbarNoneSlotDisp09 = 368,
    HotbarNoneSlotDisp10 = 369,
    HotbarNoneSlotDispEX = 370,
    ExHotbarSetting = 371,
    HotbarExHotbarUseSetting = 373,
    HotbarCrossUseEx = 396,
    HotbarCrossUseExDirection = 397,
    HotbarCrossDispType = 402,
    PartyListSoloOff = 593,
    HowTo = 603,
    HousingFurnitureBindConfirm = 605,
    DirectChat = 619,
    CharaParamDisp = 753,
    LimitBreakGaugeDisp = 754,
    ScenarioTreeDisp = 755,
    ScenarioTreeCompleteDisp = 756,
    HotbarCrossDispAlways = 757,
    ExpDisp = 758,
    InventryStatusDisp = 759,
    DutyListDisp = 760,
    NaviMapDisp = 761,
    GilStatusDisp = 762,
    InfoSettingDisp = 763,
    InfoSettingDispType = 764,
    TargetInfoDisp = 766,
    EnemyListDisp = 768,
    FocusTargetDisp = 769,
    ItemDetailDisp = 771,
    ActionDetailDisp = 776,
    DetailTrackingType = 777,
    ToolTipDisp = 778,
    MapPermeationRate = 779,
    MapOperationType = 780,
    PartyListDisp = 781,
    PartyListNameType = 782,
    FlyTextDisp = 783,
    MapPermeationMode = 784,
    AllianceList1Disp = 790,
    AllianceList2Disp = 791,
    TargetInfoSelfBuff = 794,
    PopUpTextDisp = 797,
    ContentsInfoDisp = 806,
    DutyListHideWhenCntInfoDisp = 807,
    DutyListNumDisp = 810,
    InInstanceContentDutyListDisp = 811,
    InPublicContentDutyListDisp = 812,
    ContentsInfoJoiningRequestDisp = 813,
    ContentsInfoJoiningRequestSituationDisp = 814,
    HotbarDispSetNum = 821,
    HotbarDispSetChangeType = 822,
    HotbarDispSetDragType = 823,
    MainCommandType = 824,
    MainCommandDisp = 825,
    MainCommandDragShortcut = 826,
    HotbarDispLookNum = 827,
    #endregion
}
