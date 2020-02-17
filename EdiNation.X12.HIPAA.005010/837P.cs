namespace EdiNation.X12.HIPAA005010
{
    using System.Collections.Generic;
    public class All_AMT_837P
    {
        public AMT_SalesTaxAmount AMT_SalesTaxAmount;
        public AMT_PostageClaimedAmount AMT_PostageClaimedAmount;
    }
    public class All_AMT_837P_2
    {
        public AMT_CoordinationofBenefits AMT_CoordinationofBenefits_COB_PayerPaidAmount;
        public AMT_CoordinationofBenefits_2 AMT_CoordinationofBenefits_COB_TotalNon_Amount;
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability;
    }
    public class All_CRC_837P
    {
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification;
        public CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator;
        public CRC_ConditionIndicator CRC_ConditionIndicator_DurableMedicalEquipment;
    }
    public class All_CRC_837P_2
    {
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification;
        public List<CRC_PatientConditionInformation> CRC_PatientConditionInformation_Vision;
        public CRC_HomeboundIndicator CRC_HomeboundIndicator;
        public CRC_EPSDTReferral CRC_EPSDTReferral;
    }
    public class All_DTP_837P
    {
        public DTP_ClaimLevelServiceDate DTP_Date_ServiceDate;
        public DTP_HearingandVisionPrescriptionDate DTP_Date_PrescriptionDate;
        public DTP_CertificationRevision DTP_DATE_CertificationRevision_RecertificationDate;
        public DTP_BeginTherapyDate DTP_Date_BeginTherapyDate;
        public DTP_LastCertificationDate DTP_Date_LastCertificationDate;
        public DTP_LastSeenDate DTP_Date_LastSeenDate;
        public List<DTP_TestDate> DTP_Date_TestDate;
        public DTP_ShippedDate DTP_Date_ShippedDate;
        public DTP_LastXrayDate DTP_Date_LastX_Date;
        public DTP_InitialTreatmentDate DTP_Date_InitialTreatmentDate;
    }
    public class All_DTP_837P_2
    {
        public DTP_OnsetofCurrentIllnessorSymptom DTP_Date_OnsetofCurrentIllnessorSymptom;
        public DTP_InitialTreatmentDate DTP_Date_InitialTreatmentDate;
        public DTP_LastSeenDate DTP_Date_LastSeenDate;
        public DTP_AcuteManifestation DTP_Date_AcuteManifestation;
        public DTP_AccidentDate_2 DTP_Date_Accident;
        public DTP_LastMenstrualPeriod DTP_Date_LastMenstrualPeriod;
        public DTP_LastXrayDate DTP_Date_LastX_Date;
        public DTP_HearingandVisionPrescriptionDate DTP_Date_HearingandVisionPrescriptionDate;
        public DTP_DisabilityDates DTP_Date_DisabilityDates;
        public DTP_LastWorked DTP_Date_LastWorked;
        public DTP_AuthorizedReturntoWork DTP_Date_AuthorizedReturntoWork;
        public DTP_AdmissionDate_4 DTP_Date_Admission;
        public DTP_Discharge DTP_Date_Discharge;
        public List<DTP_AssumedandRelinquishedCareDates> DTP_Date_AssumedandRelinquishedCareDates;
        public DTP_PropertyandCasualtyDateofFirstContact DTP_PropertyandCasualtyDateofFirstContact;
        public DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate;
    }
    public class All_HI_837P
    {
        public HI_DependentHealthCareDiagnosisCode HI_HealthCareDiagnosisCode;
        public HI_AnesthesiaRelatedProcedure HI_AnesthesiaRelatedProcedure;
        public List<HI_ConditionInformation> HI_ConditionInformation;
    }
    public class All_NM1_837P
    {
        public Loop_2010AA_837P Loop2010AA;
        public Loop_2010AB_837P Loop2010AB;
        public Loop_2010AC_837P Loop2010AC;
    }
    public class All_NM1_837P_2
    {
        public Loop_2010BA_837P Loop2010BA;
        public Loop_2010BB_837P Loop2010BB;
    }
    public class All_NM1_837P_3
    {
        public List<Loop_2310A_837P> Loop2310A;
        public Loop_2310B_837P Loop2310B;
        public Loop_2310C_837P Loop2310C;
        public Loop_2310D_837P Loop2310D;
        public Loop_2310E_837P Loop2310E;
        public Loop_2310F_837P Loop2310F;
    }
    public class All_NM1_837P_4
    {
        public Loop_2330A_837P Loop2330A;
        public Loop_2330B_837P Loop2330B;
        public List<Loop_2330C_837P> Loop2330C;
        public Loop_2330D_837P Loop2330D;
        public Loop_2330E_837P Loop2330E;
        public Loop_2330F_837P Loop2330F;
        public Loop_2330G_837P Loop2330G;
    }
    public class All_NM1_837P_5
    {
        public Loop_2420A_837P Loop2420A;
        public Loop_2420B_837P Loop2420B;
        public Loop_2420C_837P Loop2420C;
        public Loop_2420D_837P Loop2420D;
        public Loop_2420E_837P Loop2420E;
        public List<Loop_2420F_837P> Loop2420F;
        public Loop_2420G_837P Loop2420G;
        public Loop_2420H_837P Loop2420H;
    }
    public class All_NM1_837P_6
    {
        public Loop_1000A_837P Loop1000A;
        public Loop_1000B_837P Loop1000B;
    }
    public class All_NTE_837P
    {
        public NTE_LineNote NTE_LineNote;
        public NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes;
    }
    public class All_PWK_837P
    {
        public List<PWK_ClaimSupplementalInformation_2> PWK_LineSupplementalInformation;
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator;
    }
    public class All_QTY_837P
    {
        public QTY_AmbulancePatientCount QTY_AmbulancePatientCount;
        public QTY_ObstetricAnesthesiaAdditionalUnits QTY_ObstetricAnesthesiaAdditionalUnits;
    }
    public class All_REF_837P
    {
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier;
        public REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber;
        public REF_OtherPayerReferralNumber REF_OtherPayerReferralNumber;
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator;
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber;
    }
    public class All_REF_837P_2
    {
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber;
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber;
        public List<REF_OtherPayerPriorAuthorizationNumber> REF_PriorAuthorization;
        public REF_LineItemControlNumber REF_LineItemControlNumber;
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber;
        public REF_ClinicalLaboratoryImprovementAmendment REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number;
        public REF_ReferringClinicalLaboratoryImprovementAmendment REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification;
        public REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber;
        public List<REF_OtherPayerReferralNumber> REF_ReferralNumber;
    }
    public class All_REF_837P_3
    {
        public REF_Pay REF_Pay_ToPlanSecondaryIdentification;
        public REF_BillingProviderTaxIdentification_2 REF_Pay_ToPlanTaxIdentificationNumber;
    }
    public class All_REF_837P_4
    {
        public REF_OtherSubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification;
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber;
    }
    public class All_REF_837P_5
    {
        public List<REF_OtherPayerSecondaryIdentifier> REF_PayerSecondaryIdentification;
        public List<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification;
    }
    public class All_REF_837P_6
    {
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode;
        public REF_MandatoryMedicare REF_MandatoryMedicare_Section4081_CrossoverIndicator;
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber;
        public REF_OtherPayerReferralNumber REF_ReferralNumber;
        public REF_OtherPayerPriorAuthorizationNumber REF_PriorAuthorization;
        public REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber;
        public REF_ClinicalLaboratoryImprovementAmendment REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number;
        public REF_RepricedClaimNumber REF_RepricedClaimNumber;
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber;
        public REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber;
        public REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries;
        public REF_MedicalRecordNumber REF_MedicalRecordNumber;
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier;
        public REF_CarePlanOversight REF_CarePlanOversight;
    }
    public class All_REF_837P_7
    {
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber;
        public REF_PropertyandCasualtyPatientIdentifier REF_PropertyandCasualtyPatientIdentifier;
    }
    public class All_REF_837P_8
    {
        public REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification;
        public List<REF_BillingProviderUPIN> REF_BillingProviderUPIN_LicenseInformation;
    }
    public class Loop_1000A_837P
    {
        public NM1_InformationReceiverName_4 NM1_SubmitterName;
        public List<PER_BillingProviderContactInformation> PER_SubmitterEDIContactInformation;
    }
    public class Loop_1000B_837P
    {
        public NM1_ReceiverName NM1_ReceiverName;
    }
    public class Loop_2000A_837P
    {
        public HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel;
        public PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation;
        public CUR_ForeignCurrencyInformation_3 CUR_ForeignCurrencyInformation;
        public All_NM1_837P AllNM1;
        public List<Loop_2000B_837P> Loop2000B;
    }
    public class Loop_2000B_837P
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel;
        public SBR_SubscriberInformation SBR_SubscriberInformation;
        public PAT_PatientInformation_3 PAT_PatientInformation;
        public All_NM1_837P_2 AllNM1;
        public List<Loop_2300_837P> Loop2300;
        public List<Loop_2000C_837P> Loop2000C;
    }
    public class Loop_2000C_837P
    {
        public HL_DependentLevel HL_PatientHierarchicalLevel;
        public PAT_PatientInformation PAT_PatientInformation;
        public Loop_2010CA_837P Loop2010CA;
        public List<Loop_2300_837P> Loop2300;
    }
    public class Loop_2010AA_837P
    {
        public NM1_BillingProviderName_2 NM1_BillingProviderName;
        public N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress;
        public N4_AdditionalPatientInformationContactCity N4_BillingProviderCity_State_ZIPCode;
        public All_REF_837P_8 AllREF;
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation;
    }
    public class Loop_2010AB_837P
    {
        public NM1_Pay NM1_Pay_AddressName;
        public N3_AdditionalPatientInformationContactAddress N3_Pay_ToAddress_ADDRESS;
        public N4_AdditionalPatientInformationContactCity N4_Pay_AddressCity_State_ZIPCode;
    }
    public class Loop_2010AC_837P
    {
        public NM1_Pay_3 NM1_Pay_ToPlanName;
        public N3_AdditionalPatientInformationContactAddress N3_Pay_ToPlanAddress;
        public N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZIPCode;
        public All_REF_837P_3 AllREF;
    }
    public class Loop_2010BA_837P
    {
        public NM1_SubscriberName_5 NM1_SubscriberName;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress;
        public N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode;
        public DMG_PatientDemographicInformation DMG_SubscriberDemographicInformation;
        public All_REF_837P_4 AllREF;
        public PER_PropertyandCasualtyPatientContactInformation PER_PropertyandCasualtySubscriberContactInformation;
    }
    public class Loop_2010BB_837P
    {
        public NM1_OtherPayerName NM1_PayerName;
        public N3_AdditionalPatientInformationContactAddress N3_PayerAddress;
        public N4_AdditionalPatientInformationContactCity N4_PayerCity_State_ZIPCode;
        public All_REF_837P_5 AllREF;
    }
    public class Loop_2010CA_837P
    {
        public NM1_PatientName_3 NM1_PatientName;
        public N3_AdditionalPatientInformationContactAddress N3_PatientAddress;
        public N4_AdditionalPatientInformationContactCity N4_PatientCity_State_ZIPCode;
        public DMG_PatientDemographicInformation DMG_PatientDemographicInformation;
        public All_REF_837P_7 AllREF;
        public PER_PropertyandCasualtyPatientContactInformation PER_PropertyandCasualtyPatientContactInformation;
    }
    public class Loop_2300_837P
    {
        public CLM_ClaimInformation_3 CLM_ClaimInformation;
        public All_DTP_837P_2 AllDTP;
        public List<PWK_ClaimSupplementalInformation_3> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation_2 CN1_ContractInformation;
        public AMT_PatientAmountPaid AMT_PatientAmountPaid;
        public All_REF_837P_6 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public NTE_ClaimNote_2 NTE_ClaimNote;
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation;
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation;
        public All_CRC_837P_2 AllCRC;
        public All_HI_837P AllHI;
        public HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation;
        public All_NM1_837P_3 AllNM1;
        public List<Loop_2320_837P> Loop2320;
        public List<Loop_2400_837P> Loop2400;
    }
    public class Loop_2310A_837P
    {
        public NM1_ReferringProviderName NM1_ReferringProviderName;
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2310B_837P
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2310C_837P
    {
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocationName;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode;
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification;
        public PER_PropertyandCasualtyPatientContactInformation PER_ServiceFacilityContactInformation;
    }
    public class Loop_2310D_837P
    {
        public NM1_SupervisingProviderName NM1_SupervisingProviderName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification;
    }
    public class Loop_2310E_837P
    {
        public NM1_AmbulancePick NM1_AmbulancePick_Location;
        public N3_AdditionalPatientInformationContactAddress N3_AmbulancePick_LocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_AmbulancePick_LocationCity_State_ZipCode;
    }
    public class Loop_2310F_837P
    {
        public NM1_AmbulanceDrop NM1_AmbulanceDrop_Location;
        public N3_AdditionalPatientInformationContactAddress N3_AmbulanceDrop_LocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_AmbulanceDrop_LocationCity_State_ZipCode;
    }
    public class Loop_2320_837P
    {
        public SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation;
        public List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments;
        public All_AMT_837P_2 AllAMT;
        public OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation;
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation;
        public All_NM1_837P_4 AllNM1;
    }
    public class Loop_2330A_837P
    {
        public NM1_OtherSubscriberName NM1_OtherSubscriberName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress;
        public N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZIPCode;
        public REF_OtherSubscriberSecondaryIdentification REF_OtherSubscriberSecondaryIdentification;
    }
    public class Loop_2330B_837P
    {
        public NM1_OtherPayerName NM1_OtherPayerName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherPayerAddress;
        public N4_AdditionalPatientInformationContactCity N4_OtherPayerCity_State_ZIPCode;
        public DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckorRemittanceDate;
        public All_REF_837P AllREF;
    }
    public class Loop_2330C_837P
    {
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider;
        public List<REF_OrderingProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification;
    }
    public class Loop_2330D_837P
    {
        public NM1_OtherPayerRenderingProvider_2 NM1_OtherPayerRenderingProvider;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification;
    }
    public class Loop_2330E_837P
    {
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation;
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2330F_837P
    {
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerSupervisingProviderSecondaryIdentification;
    }
    public class Loop_2330G_837P
    {
        public NM1_OtherPayerBillingProvider NM1_OtherPayerBillingProvider;
        public List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification;
    }
    public class Loop_2400_837P
    {
        public LX_HeaderNumber LX_ServiceLineNumber;
        public SV1_ProfessionalService SV1_ProfessionalService;
        public SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService;
        public All_PWK_837P AllPWK;
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation;
        public CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification;
        public All_CRC_837P AllCRC;
        public All_DTP_837P AllDTP;
        public All_QTY_837P AllQTY;
        public List<MEA_TestResult> MEA_TestResult;
        public CN1_ContractInformation_2 CN1_ContractInformation;
        public All_REF_837P_2 AllREF;
        public All_AMT_837P AllAMT;
        public List<K3_FileInformation> K3_FileInformation;
        public All_NTE_837P AllNTE;
        public PS1_PurchasedServiceInformation PS1_PurchasedServiceInformation;
        public HCP_LinePricing_3 HCP_LinePricing_RepricingInformation;
        public Loop_2410_837P Loop2410;
        public All_NM1_837P_5 AllNM1;
        public List<Loop_2430_837P> Loop2430;
        public List<Loop_2440_837P> Loop2440;
    }
    public class Loop_2410_837P
    {
        public LIN_DrugIdentification_2 LIN_DrugIdentification;
        public CTP_DrugQuantity CTP_DrugQuantity;
        public REF_PrescriptionorCompoundDrugAssociationNumber REF_PrescriptionorCompoundDrugAssociationNumber;
    }
    public class Loop_2420A_837P
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2420B_837P
    {
        public NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName;
        public List<REF_OrderingProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification;
    }
    public class Loop_2420C_837P
    {
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode;
        public List<REF_BillingProviderSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2420D_837P
    {
        public NM1_SupervisingProviderName NM1_SupervisingProviderName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification;
    }
    public class Loop_2420E_837P
    {
        public NM1_OrderingProviderName NM1_OrderingProviderName;
        public N3_AdditionalPatientInformationContactAddress N3_OrderingProviderAddress;
        public N4_AdditionalPatientInformationContactCity N4_OrderingProviderCity_State_ZIPCode;
        public List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification;
        public PER_BillingProviderContactInformation PER_OrderingProviderContactInformation;
    }
    public class Loop_2420F_837P
    {
        public NM1_ReferringProviderName NM1_ReferringProviderName;
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2420G_837P
    {
        public NM1_AmbulancePick NM1_AmbulancePick_Location;
        public N3_AdditionalPatientInformationContactAddress N3_AmbulancePick_LocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_AmbulancePick_LocationCity_State_ZipCode;
    }
    public class Loop_2420H_837P
    {
        public NM1_AmbulanceDrop NM1_AmbulanceDrop_Location;
        public N3_AdditionalPatientInformationContactAddress N3_AmbulanceDrop_LocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_AmbulanceDrop_LocationCity_State_ZipCode;
    }
    public class Loop_2430_837P
    {
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation;
        public List<CAS_ClaimLevelAdjustments> CAS_LineAdjustment;
        public DTP_ClaimCheckOrRemittanceDate DTP_LineCheckorRemittanceDate;
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability;
    }
    public class Loop_2440_837P
    {
        public LQ_FormIdentificationCode LQ_FormIdentificationCode;
        public List<FRM_SupportingDocumentation> FRM_SupportingDocumentation;
    }
    public class TS837P 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_8 BHT_BeginningOfHierarchicalTransaction;
        public All_NM1_837P_6 AllNM1;
        public List<Loop_2000A_837P> Loop2000A;
        public SE SE;
    }
}
