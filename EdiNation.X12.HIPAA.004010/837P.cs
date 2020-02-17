namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_2010A_837P
    {
        public Loop_2010AA_837P Loop2010AA;
        public Loop_2010AB_837P Loop2010AB;
    }
    public class All_2010B_837P
    {
        public Loop_2010BA_837P Loop2010BA;
        public Loop_2010BB_837P Loop2010BB;
        public Loop_2010BC_837P Loop2010BC;
        public Loop_2010BD_837P Loop2010BD;
    }
    public class All_2310_837P
    {
        public List<Loop_2310A_837P> Loop2310A;
        public Loop_2310B_837P Loop2310B;
        public Loop_2310C_837P Loop2310C;
        public Loop_2310D_837P Loop2310D;
        public Loop_2310E_837P Loop2310E;
    }
    public class All_2330_837P
    {
        public Loop_2330A_837P Loop2330A;
        public Loop_2330B_837P Loop2330B;
        public Loop_2330C_837P Loop2330C;
        public List<Loop_2330D_837P> Loop2330D;
        public Loop_2330E_837P Loop2330E;
        public Loop_2330F_837P Loop2330F;
        public Loop_2330G_837P Loop2330G;
        public Loop_2330H_837P Loop2330H;
    }
    public class All_2420_837P
    {
        public Loop_2420A_837P Loop2420A;
        public Loop_2420B_837P Loop2420B;
        public Loop_2420C_837P Loop2420C;
        public Loop_2420D_837P Loop2420D;
        public Loop_2420E_837P Loop2420E;
        public List<Loop_2420F_837P> Loop2420F;
        public List<Loop_2420G_837P> Loop2420G;
    }
    public class All_AMT_837P
    {
        public AMT_CreditDebitCardMaximumAmount AMT_CreditDebitCardMaximumAmount;
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount AMT_PatientAmountPaid;
        public AMT_TotalPurchasedServiceAmount AMT_TotalPurchasedServiceAmount;
    }
    public class All_AMT_837P_2
    {
        public AMT_CoordinationOfBenefitsCOBTaxAmount AMT_SalesTaxAmount;
        public AMT_ApprovedAmount AMT_ApprovedAmount;
        public AMT_PostageClaimedAmount AMT_PostageClaimedAmount;
    }
    public class All_AMT_837P_3
    {
        public AMT_CoordinationOfBenefitsCOBPayerPaidAmount AMT_CoordinationOfBenefitsCOBPayerPaidAmount;
        public AMT_ApprovedAmount AMT_CoordinationOfBenefitsCOBApprovedAmount;
        public AMT_CoordinationOfBenefitsCOBAllowedAmount AMT_CoordinationOfBenefitsCOBAllowedAmount;
        public AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount;
        public AMT_CoordinationOfBenefitsCOBCoveredAmount AMT_CoordinationOfBenefitsCOBCoveredAmount;
        public AMT_CoordinationOfBenefitsCOBDiscountAmount AMT_CoordinationOfBenefitsCOBDiscountAmount;
        public AMT_CoordinationOfBenefitsCOBPerDayLimitAmount AMT_CoordinationOfBenefitsCOBPerDayLimitAmount;
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount AMT_CoordinationOfBenefitsCOBPatientPaidAmount;
        public AMT_CoordinationOfBenefitsCOBTaxAmount AMT_CoordinationOfBenefitsCOBTaxAmount;
        public AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount;
    }
    public class All_CRC_837P
    {
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification;
        public List<CRC_PatientConditionInformationVision> CRC_PatientConditionInformationVision;
        public CRC_HomeboundIndicator CRC_HomeboundIndicator;
        public CRC_EPSDTReferral CRC_EPSDTReferral;
    }
    public class All_CRC_837P_2
    {
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification;
        public CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator;
        public List<CRC_DMERCConditionIndicator> CRC_DMERCConditionIndicator;
    }
    public class All_DTP_837P
    {
        public DTP_DateInitialTreatment DTP_DateInitialTreatment;
        public DTP_DateDateLastSeen DTP_DateDateLastSeen;
        public DTP_DateOnsetOfCurrentIllnessSymptom DTP_DateOnsetOfCurrentIllnessSymptom;
        public List<DTP_DateAcuteManifestation> DTP_DateAcuteManifestation;
        public List<DTP_DateSimilarIllnessSymptomOnset> DTP_DateSimilarIllnessSymptomOnset;
        public List<DTP_DateAccident> DTP_DateAccident;
        public DTP_DateLastMenstrualPeriod DTP_DateLastMenstrualPeriod;
        public DTP_DateLastXray DTP_DateLastXray;
        public DTP_DateHearingAndVisionPrescriptionDate DTP_DateHearingAndVisionPrescriptionDate;
        public List<DTP_DateDisabilityBegin> DTP_DateDisabilityBegin;
        public List<DTP_DateDisabilityEnd> DTP_DateDisabilityEnd;
        public DTP_DateLastWorked DTP_DateLastWorked;
        public DTP_DateAuthorizedReturnToWork DTP_DateAuthorizedReturnToWork;
        public DTP_DateAdmission DTP_DateAdmission;
        public DTP_DateDischarge DTP_DateDischarge;
        public List<DTP_DateAssumedAndRelinquishedCareDates> DTP_DateAssumedAndRelinquishedCareDates;
    }
    public class All_DTP_837P_2
    {
        public DTP_DateService DTP_DateServiceDate;
        public DTP_DateCertificationRevisionDate DTP_DateCertificationRevisionDate;
        public DTP_DateBeginTherapyDate DTP_DateBeginTherapyDate;
        public DTP_DateLastCertificationDate DTP_DateLastCertificationDate;
        public DTP_DateDateLastSeen DTP_DateDateLastSeen;
        public List<DTP_DateTest> DTP_DateTest;
        public List<DTP_DateOxygenSaturationArterialBloodGasTest> DTP_DateOxygenSaturationArterialBloodGasTest;
        public DTP_DateShipped DTP_DateShipped;
        public DTP_DateOnsetOfCurrentIllnessSymptom DTP_DateOnsetOfCurrentSymptomIllness;
        public DTP_DateLastXray DTP_DateLastXray;
        public DTP_DateAcuteManifestation DTP_DateAcuteManifestation;
        public DTP_DateInitialTreatment DTP_DateInitialTreatment;
        public DTP_DateSimilarIllnessSymptomOnset DTP_DateSimilarIllnessSymptomOnset;
    }
    public class All_REF_837P
    {
        public List<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification_2010AA;
        public List<REF_ClaimSubmitterCreditDebitCardInformation> REF_CreditDebitCardBillingInformation_2010AA;
    }
    public class All_REF_837P_2
    {
        public List<REF_OtherPayerPatientIdentification> REF_SubscriberSecondaryIdentification_2010BA;
        public REF_PropertyAndCasualtyClaimNumber REF_PropertyAndCasualtyClaimNumber_2010BA;
    }
    public class All_REF_837P_3
    {
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode;
        public REF_MandatoryMedicareSection4081CrossoverIndicator REF_MandatoryMedicareSection4081CrossoverIndicator;
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber;
        public List<REF_DependentAdditionalInformation> REF_PriorAuthorizationOrReferralNumber;
        public REF_OriginalReferenceNumberICNDCN REF_OriginalReferenceNumberICNDCN;
        public List<REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification> REF_ClinicalLaboratoryImprovementAmendmentCLIANumber;
        public REF_RepricedClaimNumber REF_RepricedClaimNumber;
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber;
        public REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber;
        ///Transmission Intermediaries
        public REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries;
        public List<REF_AmbulatoryPatientGroupAPG> REF_AmbulatoryPatientGroupAPG;
        public REF_MedicalRecordIdentification REF_MedicalRecordNumber;
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier;
    }
    public class All_REF_837P_4
    {
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber;
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber;
        public List<REF_DependentAdditionalInformation> REF_PriorAuthorizationOrReferralNumber;
        public REF_LineItemControlNumber REF_LineItemControlNumber;
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber;
        public REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification;
        ///Identification
        public REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification;
        public REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber;
        public List<REF_AmbulatoryPatientGroupAPG> REF_AmbulatoryPatientGroupAPG;
        public REF_OxygenFlowRate REF_OxygenFlowRate;
        public REF_UniversalProductNumberUPN REF_UniversalProductNumberUPN;
    }
    public class All_REF_837P_5
    {
        public List<REF_OtherPayerSecondaryIdentificationAndReferenceNumber> REF_OtherPayerSecondaryIdentifier;
        public List<REF_DependentAdditionalInformation> REF_OtherPayerPriorAuthorizationOrReferralNumber;
        public List<REF_OtherPayerClaimAdjustmentIndicator> REF_OtherPayerClaimAdjustmentIndicator;
    }
    public class Loop_1000A_837P
    {
        public NM1_SubmitterName NM1_SubmitterName;
        public List<PER_OtherPayerContactInformation> PER_SubmitterEDIContactInformation;
    }
    public class Loop_1000B_837P
    {
        public NM1_ReceiverName NM1_ReceiverName;
    }
    public class Loop_2000A_837P
    {
        public HL_BillingPaytoProviderHierarchicalLevel HL_BillingPaytoProviderHierarchicalLevel;
        public PRV_BillingPaytoProviderSpecialtyInformation PRV_BillingPaytoProviderSpecialtyInformation;
        public CUR_ForeignCurrencyInformation_2 CUR_ForeignCurrencyInformation;
        public All_2010A_837P All2010A;
        public List<Loop_2000B_837P> Loop2000B;
    }
    public class Loop_2000B_837P
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel;
        public SBR_SubscriberInformation SBR_SubscriberInformation;
        public PAT_PatientInformation PAT_PatientInformation;
        public All_2010B_837P All2010B;
        public List<Loop_2300_837P_2> Loop2300;
        public List<Loop_2000C_837P> Loop2000C;
    }
    public class Loop_2000C_837P
    {
        public HL_DependentLevel HL_PatientHierarchicalLevel;
        public PAT_PatientInformation_2 PAT_PatientInformation;
        public Loop_2010CA_837P Loop2010CA;
        public List<Loop_2300_837P> Loop2300;
    }
    public class Loop_2010AA_837P
    {
        public NM1_BillingProviderName NM1_BillingProviderName_2010AA;
        public N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress_2010AA;
        public N4_BillingProviderCityStateZIPCode N4_BillingProviderCityStateZIPCode_2010AA;
        public All_REF_837P AllREF;
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation_2010AA;
    }
    public class Loop_2010AB_837P
    {
        public NM1_PaytoProviderName NM1_PaytoProviderName_2010AB;
        public N3_AdditionalPatientInformationContactAddress N3_PaytoProviderAddress_2010AB;
        public N4_BillingProviderCityStateZIPCode N4_PaytoProviderCityStateZIPCode_2010AB;
        public List<REF_BillingProviderSecondaryIdentification> REF_PaytoProviderSecondaryIdentification_2010AB;
    }
    public class Loop_2010BA_837P
    {
        public NM1_SubscriberName_4 NM1_SubscriberName_2010BA;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress_2010BA;
        public N4_BillingProviderCityStateZIPCode N4_SubscriberCityStateZIPCode_2010BA;
        public DMG_DependentDemographicInformation_3 DMG_SubscriberDemographicInformation_2010BA;
        public All_REF_837P_2 AllREF;
    }
    public class Loop_2010BB_837P
    {
        public NM1_OtherPayerName NM1_PayerName_2010BB;
        public N3_AdditionalPatientInformationContactAddress N3_PayerAddress_2010BB;
        public N4_BillingProviderCityStateZIPCode N4_PayerCityStateZIPCode_2010BB;
        public List<REF_PayerSecondaryIdentification> REF_PayerSecondaryIdentification_2010BB;
    }
    public class Loop_2010BC_837P
    {
        public NM1_ResponsiblePartyName NM1_ResponsiblePartyName_2010BC;
        public N3_AdditionalPatientInformationContactAddress N3_ResponsiblePartyAddress_2010BC;
        public N4_BillingProviderCityStateZIPCode N4_ResponsiblePartyCityStateZIPCode_2010BC;
    }
    public class Loop_2010BD_837P
    {
        public NM1_CreditDebitCardAccountHolderName NM1_CreditDebitCardHolderName_2010BD;
        public List<REF_CreditDebitCardInformation> REF_CreditDebitCardInformation_2010BD;
    }
    public class Loop_2010CA_837P
    {
        public NM1_PatientName_2 NM1_PatientName_2010CA;
        public N3_AdditionalPatientInformationContactAddress N3_PatientAddress_2010CA;
        public N4_BillingProviderCityStateZIPCode N4_PatientCityStateZIPCode_2010CA;
        public DMG_DependentDemographicInformation_3 DMG_PatientDemographicInformation_2010CA;
        public All_REF_837P_2 AllREF;
    }
    public class Loop_2300_837P
    {
        public CLM_ClaimInformation CLM_ClaimInformation;
        public All_DTP_837P AllDTP;
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation CN1_ContractInformation;
        public All_AMT_837P AllAMT;
        public All_REF_837P_3 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public NTE_ClaimNote NTE_ClaimNote;
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation;
        public CR2_SpinalManipulationServiceInformation_3 CR2_SpinalManipulationServiceInformation;
        public All_CRC_837P AllCRC;
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode;
        public HCP_ClaimPricingRepricingInformation HCP_ClaimPricingRepricingInformation;
        public List<Loop_2305_837P> Loop2305;
        public All_2310_837P All2310;
        public List<Loop_2320_837P> Loop2320;
        public List<Loop_2400_837P> Loop2400;
    }
    public class Loop_2300_837P_2
    {
        public CLM_ClaimInformation CLM_ClaimInformation;
        public All_DTP_837P AllDTP;
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation CN1_ContractInformation;
        public All_AMT_837P AllAMT;
        public All_REF_837P_3 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public NTE_ClaimNote NTE_ClaimNote;
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation;
        public CR2_SpinalManipulationServiceInformation_3 CR2_SpinalManipulationServiceInformation;
        public All_CRC_837P AllCRC;
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode;
        public HCP_ClaimPricingRepricingInformation HCP_ClaimPricingRepricingInformation;
        public List<Loop_2305_837P> Loop2305;
        public All_2310_837P All2310;
        public List<Loop_2320_837P> Loop2320;
        public List<Loop_2400_837P> Loop2400;
    }
    public class Loop_2305_837P
    {
        public CR7_HomeHealthCarePlanInformation CR7_HomeHealthCarePlanInformation;
        public List<HSD_HealthCareServicesDelivery_4> HSD_HealthCareServicesDelivery;
    }
    public class Loop_2310A_837P
    {
        public NM1_ReferringProviderName NM1_ReferringProviderName;
        public PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation;
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2310B_837P
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_OrderingProviderSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2310C_837P
    {
        public NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName;
        public List<REF_PurchasedServiceProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification;
    }
    public class Loop_2310D_837P
    {
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress;
        public N4_BillingProviderCityStateZIPCode N4_ServiceFacilityLocationCityStateZIP;
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2310E_837P
    {
        public NM1_SupervisingProviderName NM1_SupervisingProviderName;
        public List<REF_OrderingProviderSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification;
    }
    public class Loop_2320_837P
    {
        public SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation;
        public List<CAS_ClaimAdjustment> CAS_ClaimLevelAdjustments;
        public All_AMT_837P_3 AllAMT;
        public DMG_DependentDemographicInformation_3 DMG_SubscriberDemographicInformation;
        public OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation;
        public MOA_MedicareOutpatientAdjudicationInformation MOA_MedicareOutpatientAdjudicationInformation;
        public All_2330_837P All2330;
    }
    public class Loop_2330A_837P
    {
        public NM1_OtherSubscriberName NM1_OtherSubscriberName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress;
        public N4_DependentCityStateZIPCode N4_OtherSubscriberCityStateZIPCode;
        public List<REF_OtherPayerPatientIdentification> REF_OtherSubscriberSecondaryIdentification;
    }
    public class Loop_2330B_837P
    {
        public NM1_OtherPayerName NM1_OtherPayerName;
        public List<PER_OtherPayerContactInformation> PER_OtherPayerContactInformation;
        public DTP_ClaimAdjudicationDate DTP_ClaimAdjudicationDate;
        public All_REF_837P_5 AllREF;
    }
    public class Loop_2330C_837P
    {
        public NM1_OtherPayerPatientInformation NM1_OtherPayerPatientInformation;
        public List<REF_OtherPayerPatientIdentification> REF_OtherPayerPatientIdentification;
    }
    public class Loop_2330D_837P
    {
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider;
        public List<REF_OtherPayerReferringProviderIdentification> REF_OtherPayerReferringProviderIdentification;
    }
    public class Loop_2330E_837P
    {
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider;
        public List<REF_OtherPayerReferringProviderIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification;
    }
    public class Loop_2330F_837P
    {
        public NM1_OtherPayerPurchasedServiceProvider NM1_OtherPayerPurchasedServiceProvider;
        public List<REF_OtherPayerPurchasedServiceProviderIdentification> REF_OtherPayerPurchasedServiceProviderIdentification;
    }
    public class Loop_2330G_837P
    {
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation;
        public List<REF_OtherPayerServiceFacilityLocationIdentification> REF_OtherPayerServiceFacilityLocationIdentification;
    }
    public class Loop_2330H_837P
    {
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider;
        public List<REF_OtherPayerSupervisingProviderIdentification> REF_OtherPayerSupervisingProviderIdentification;
    }
    public class Loop_2400_837P
    {
        public LX_HeaderNumber LX_ServiceLine;
        public SV1_ProfessionalService SV1_ProfessionalService;
        public SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService;
        public PWK_DMERCCMNIndicator PWK_DMERCCMNIndicator;
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation;
        public List<CR2_SpinalManipulationServiceInformation_3> CR2_SpinalManipulationServiceInformation;
        public CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification;
        public CR5_HomeOxygenTherapyInformation_3 CR5_HomeOxygenTherapyInformation;
        public All_CRC_837P_2 AllCRC;
        public All_DTP_837P_2 AllDTP;
        public List<MEA_TestResult> MEA_TestResult;
        public CN1_ContractInformation_2 CN1_ContractInformation;
        public All_REF_837P_4 AllREF;
        public All_AMT_837P_2 AllAMT;
        public List<K3_FileInformation> K3_FileInformation;
        public NTE_LineNote NTE_LineNote;
        public PS1_PurchasedServiceInformation PS1_PurchasedServiceInformation;
        public HSD_HealthCareServicesDelivery_5 HSD_HealthCareServicesDelivery;
        public HCP_LinePricingRepricingInformation HCP_LinePricingRepricingInformation;
        public List<Loop_2410_837P> Loop2410;
        public All_2420_837P All2420;
        public List<Loop_2430_837P> Loop2430;
        public List<Loop_2440_837P> Loop2440;
    }
    public class Loop_2410_837P
    {
        public LIN_DrugIdentification LIN_DrugIdentification;
        public CTP_DrugPricing CTP_DrugPricing;
        public REF_PrescriptionNumber REF_PrescriptionNumber;
    }
    public class Loop_2420A_837P
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_OrderingProviderSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2420B_837P
    {
        public NM1_PurchasedServiceProviderName_2 NM1_PurchasedServiceProviderName;
        public List<REF_PurchasedServiceProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification;
    }
    public class Loop_2420C_837P
    {
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress;
        public N4_BillingProviderCityStateZIPCode N4_ServiceFacilityLocationCityStateZIP;
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2420D_837P
    {
        public NM1_SupervisingProviderName NM1_SupervisingProviderName;
        public List<REF_OrderingProviderSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification;
    }
    public class Loop_2420E_837P
    {
        public NM1_OrderingProviderName NM1_OrderingProviderName;
        public N3_AdditionalPatientInformationContactAddress N3_OrderingProviderAddress;
        public N4_BillingProviderCityStateZIPCode N4_OrderingProviderCityStateZIPCode;
        public List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification;
        public PER_BillingProviderContactInformation PER_OrderingProviderContactInformation;
    }
    public class Loop_2420F_837P
    {
        public NM1_ReferringProviderName_2 NM1_ReferringProviderName;
        public PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation;
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2420G_837P
    {
        public NM1_OtherPayerName NM1_OtherPayerPriorAuthorizationOrReferralNumber;
        public List<REF_DependentAdditionalInformation> REF_OtherPayerPriorAuthorizationOrReferralNumber;
    }
    public class Loop_2430_837P
    {
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation;
        public List<CAS_ClaimAdjustment> CAS_LineAdjustment;
        public DTP_ClaimAdjudicationDate DTP_LineAdjudicationDate;
    }
    public class Loop_2440_837P
    {
        public LQ_FormIdentificationCode LQ_FormIdentificationCode;
        public List<FRM_SupportingDocumentation> FRM_SupportingDocumentation;
    }
    public class TS837P 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_7 BHT_BeginningOfHierarchicalTransaction;
        public REF_TransmissionTypeIdentification REF_TransmissionTypeIdentification;
        public Loop_1000A_837P Loop1000A;
        public Loop_1000B_837P Loop1000B;
        public List<Loop_2000A_837P> Loop2000A;
        public SE SE;
    }
}
