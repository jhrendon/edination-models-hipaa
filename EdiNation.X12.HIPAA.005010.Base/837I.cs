namespace EdiNation.X12.HIPAA005010.Base
{
    using System.Collections.Generic;
    public class All_AMT_837I
    {
        public AMT_ServiceTaxAmount AMT_ServiceTaxAmount;
        public AMT_FacilityTaxAmount AMT_FacilityTaxAmount;
    }
    public class All_AMT_837I_2
    {
        public AMT_CoordinationofBenefits AMT_CoordinationofBenefits_COB_PayerPaidAmount;
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability;
        public AMT_CoordinationofBenefits_2 AMT_CoordinationofBenefits_COB_TotalNon_Amount;
    }
    public class All_DTP_837I
    {
        public DTP_DischargeHour DTP_DischargeHour;
        public DTP_StatementDates DTP_StatementDates;
        public DTP_AdmissionDate DTP_AdmissionDate_Hour;
        public DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate;
    }
    public class All_HI_837I
    {
        public HI_PrincipalDiagnosis HI_PrincipalDiagnosis;
        public HI_AdmittingDiagnosis HI_AdmittingDiagnosis;
        public HI_Patient HI_Patient_ReasonForVisit;
        public HI_ExternalCauseofInjury HI_ExternalCauseofInjury;
        public HI_DiagnosisRelatedGroup HI_DiagnosisRelatedGroup_DRG_Information;
        public List<HI_OtherDiagnosisInformation> HI_OtherDiagnosisInformation;
        public HI_PrincipalProcedureInformation HI_PrincipalProcedureInformation;
        public List<HI_OtherProcedureInformation> HI_OtherProcedureInformation;
        public List<HI_OccurrenceSpanInformation> HI_OccurrenceSpanInformation;
        public List<HI_OccurrenceInformation> HI_OccurrenceInformation;
        public List<HI_ValueInformation> HI_ValueInformation;
        public List<HI_ConditionInformation> HI_ConditionInformation;
        public List<HI_TreatmentCodeInformation> HI_TreatmentCodeInformation;
    }
    public class All_NM1_837I
    {
        public Loop_2010AA_837I Loop2010AA;
        public Loop_2010AB_837I Loop2010AB;
        public Loop_2010AC_837I Loop2010AC;
    }
    public class All_NM1_837I_2
    {
        public Loop_2010BA_837I Loop2010BA;
        public Loop_2010BB_837I Loop2010BB;
    }
    public class All_NM1_837I_3
    {
        public Loop_2310A_837I Loop2310A;
        public Loop_2310B_837I Loop2310B;
        public Loop_2310C_837I Loop2310C;
        public Loop_2310D_837I Loop2310D;
        public Loop_2310E_837I Loop2310E;
        public Loop_2310F_837I Loop2310F;
    }
    public class All_NM1_837I_4
    {
        public Loop_2330A_837I Loop2330A;
        public Loop_2330B_837I Loop2330B;
        public Loop_2330C_837I Loop2330C;
        public Loop_2330D_837I Loop2330D;
        public Loop_2330E_837I Loop2330E;
        public Loop_2330F_837I Loop2330F;
        public Loop_2330G_837I Loop2330G;
        public Loop_2330H_837I Loop2330H;
        public Loop_2330I_837I Loop2330I;
    }
    public class All_NM1_837I_5
    {
        public Loop_2420A_837I Loop2420A;
        public Loop_2420B_837I Loop2420B;
        public Loop_2420C_837I Loop2420C;
        public Loop_2420D_837I Loop2420D;
    }
    public class All_NM1_837I_6
    {
        public Loop_1000A_837I Loop1000A;
        public Loop_1000B_837I Loop1000B;
    }
    public class All_NTE_837I
    {
        public List<NTE_ClaimNote> NTE_ClaimNote;
        public NTE_BillingNote NTE_BillingNote;
    }
    public class All_REF_837I
    {
        public REF_OtherSubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification;
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber;
    }
    public class All_REF_837I_2
    {
        public List<REF_OtherPayerSecondaryIdentifier> REF_PayerSecondaryIdentification;
        public REF_BillingProviderSecondaryIdentification REF_BillingProviderSecondaryIdentification;
    }
    public class All_REF_837I_3
    {
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode;
        public REF_OtherPayerReferralNumber REF_ReferralNumber;
        public REF_OtherPayerPriorAuthorizationNumber REF_PriorAuthorization;
        public REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber;
        public REF_RepricedClaimNumber REF_RepricedClaimNumber;
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber;
        public List<REF_InvestigationalDeviceExemptionNumber> REF_InvestigationalDeviceExemptionNumber;
        public REF_ClaimIdentifierForTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries;
        public REF_AutoAccidentState REF_AutoAccidentState;
        public REF_MedicalRecordNumber REF_MedicalRecordNumber;
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier;
        public REF_PeerReviewOrganization REF_PeerReviewOrganization_PRO_ApprovalNumber;
    }
    public class All_REF_837I_4
    {
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier;
        public REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber;
        public List<REF_OtherPayerReferralNumber> REF_OtherPayerReferralNumber;
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator;
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber;
    }
    public class All_REF_837I_5
    {
        public REF_LineItemControlNumber REF_LineItemControlNumber;
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber;
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber;
    }
    public class All_REF_837I_6
    {
        public REF_Pay REF_Pay_ToPlanSecondaryIdentification;
        public REF_BillingProviderTaxIdentification_2 REF_Pay_ToTaxIdentificationNumber;
    }
    public class Loop_1000A_837I
    {
        public NM1_SubmitterName NM1_SubmitterName;
        public List<PER_BillingProviderContactInformation> PER_SubmitterEDIContactInformation;
    }
    public class Loop_1000B_837I
    {
        public NM1_ReceiverName NM1_ReceiverName;
    }
    public class Loop_2000A_837I
    {
        public HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel;
        public PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation;
        public CUR_ForeignCurrencyInformation_2 CUR_ForeignCurrencyInformation;
        public All_NM1_837I AllNM1;
        public List<Loop_2000B_837I> Loop2000B;
    }
    public class Loop_2000B_837I
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel;
        public SBR_SubscriberInformation_2 SBR_SubscriberInformation;
        public All_NM1_837I_2 AllNM1;
        public List<Loop_2300_837I_2> Loop2300;
        public List<Loop_2000C_837I> Loop2000C;
    }
    public class Loop_2000C_837I
    {
        public HL_DependentLevel HL_PatientHierarchicalLevel;
        public PAT_PatientInformation_2 PAT_PatientInformation;
        public Loop_2010CA_837I Loop2010CA;
        public List<Loop_2300_837I> Loop2300;
    }
    public class Loop_2010AA_837I
    {
        public NM1_BillingProviderName_2 NM1_BillingProviderName;
        public N3_AmbulanceDrop N3_BillingProviderAddress;
        public N4_AmbulanceDrop N4_BillingProviderCity_State_ZIPCode;
        public REF_BillingProviderTaxIdentification_2 REF_BillingProviderTaxIdentification;
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation;
    }
    public class Loop_2010AB_837I
    {
        public NM1_Pay_2 NM1_Pay_AddressName;
        public N3_AmbulanceDrop N3_Pay_ToAddress_ADDRESS;
        public N4_AmbulanceDrop N4_Pay_AddressCity_State_ZIPCode;
    }
    public class Loop_2010AC_837I
    {
        public NM1_Pay_3 NM1_Pay_ToPlanName;
        public N3_AmbulanceDrop N3_Pay_ToPlanAddress;
        public N4_AmbulanceDrop N4_Pay_ToPlanCity_State_ZipCode;
        public All_REF_837I_6 AllREF;
    }
    public class Loop_2010BA_837I
    {
        public NM1_OtherSubscriberName NM1_SubscriberName;
        public N3_AmbulanceDrop N3_SubscriberAddress;
        public N4_AmbulanceDrop N4_SubscriberCity_State_ZIPCode;
        public DMG_PatientDemographicInformation DMG_SubscriberDemographicInformation;
        public All_REF_837I AllREF;
    }
    public class Loop_2010BB_837I
    {
        public NM1_OtherPayerName NM1_PayerName;
        public N3_AmbulanceDrop N3_PayerAddress;
        public N4_AmbulanceDrop N4_PayerCity_State_ZIPCode;
        public All_REF_837I_2 AllREF;
    }
    public class Loop_2010CA_837I
    {
        public NM1_PatientName_2 NM1_PatientName;
        public N3_AmbulanceDrop N3_PatientAddress;
        public N4_AmbulanceDrop N4_PatientCity_State_ZIPCode;
        public DMG_PatientDemographicInformation DMG_PatientDemographicInformation;
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber;
    }
    public class Loop_2300_837I
    {
        public CLM_ClaimInformation_2 CLM_ClaimInformation;
        public All_DTP_837I AllDTP;
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode;
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation_2 CN1_ContractInformation;
        public AMT_PatientEstimatedAmountDue AMT_PatientEstimatedAmountDue;
        public All_REF_837I_3 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public All_NTE_837I AllNTE;
        public CRC_EPSDTReferral CRC_EPSDTReferral;
        public All_HI_837I AllHI;
        public HCP_ClaimPricing_2 HCP_ClaimPricing_RepricingInformation;
        public All_NM1_837I_3 AllNM1;
        public List<Loop_2320_837I> Loop2320;
        public List<Loop_2400_837I> Loop2400;
    }
    public class Loop_2300_837I_2
    {
        public CLM_ClaimInformation_2 CLM_ClaimInformation;
        public All_DTP_837I AllDTP;
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode;
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation_2 CN1_ContractInformation;
        public AMT_PatientEstimatedAmountDue AMT_PatientEstimatedAmountDue;
        public All_REF_837I_3 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public All_NTE_837I AllNTE;
        public CRC_EPSDTReferral CRC_EPSDTReferral;
        public All_HI_837I AllHI;
        public HCP_ClaimPricing_2 HCP_ClaimPricing_RepricingInformation;
        public All_NM1_837I_3 AllNM1;
        public List<Loop_2320_837I> Loop2320;
        public List<Loop_2400_837I> Loop2400;
    }
    public class Loop_2310A_837I
    {
        public NM1_AttendingProviderName NM1_AttendingProviderName;
        public PRV_AttendingProviderSpecialtyInformation PRV_AttendingProviderSpecialtyInformation;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_AttendingProviderSecondaryIdentification;
    }
    public class Loop_2310B_837I
    {
        public NM1_OperatingPhysicianName NM1_OperatingPhysicianName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2310C_837I
    {
        public NM1_OtherOperatingPhysicianName NM1_OtherOperatingPhysicianName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherOperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2310D_837I
    {
        public NM1_RenderingProviderName_2 NM1_RenderingProviderName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2310E_837I
    {
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocationName;
        public N3_AmbulanceDrop N3_ServiceFacilityLocationAddress;
        public N4_AmbulanceDrop N4_ServiceFacilityLocationCity_State_ZIP;
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilitySecondaryIdentification;
    }
    public class Loop_2310F_837I
    {
        public NM1_ReferringProviderName_2 NM1_ReferringProviderName;
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2320_837I
    {
        public SBR_OtherSubscriberInformation_2 SBR_OtherSubscriberInformation;
        public List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments;
        public All_AMT_837I_2 AllAMT;
        public OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation;
        public MIA_InpatientAdjudicationInformation MIA_InpatientAdjudicationInformation;
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation;
        public All_NM1_837I_4 AllNM1;
    }
    public class Loop_2330A_837I
    {
        public NM1_OtherSubscriberName NM1_OtherSubscriberName;
        public N3_AmbulanceDrop N3_OtherSubscriberAddress;
        public N4_AmbulanceDrop N4_OtherSubscriberCity_State_ZIPCode;
        public List<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryInformation;
    }
    public class Loop_2330B_837I
    {
        public NM1_OtherPayerName NM1_OtherPayerName;
        public N3_AmbulanceDrop N3_OtherPayerAddress;
        public N4_AmbulanceDrop N4_OtherPayerCity_State_ZIPCode;
        public DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckOrRemittanceDate;
        public All_REF_837I_4 AllREF;
    }
    public class Loop_2330C_837I
    {
        public NM1_OtherPayerAttendingProvider NM1_OtherPayerAttendingProvider;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerAttendingProviderSecondaryIdentification;
    }
    public class Loop_2330D_837I
    {
        public NM1_OtherPayerOperatingPhysician NM1_OtherPayerOperatingPhysician;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerOperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2330E_837I
    {
        public NM1_OtherPayerOtherOperatingPhysician NM1_OtherPayerOtherOperatingPhysician;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerOtherOperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2330F_837I
    {
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation;
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2330G_837I
    {
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProviderName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentifier;
    }
    public class Loop_2330H_837I
    {
        public NM1_OtherPayerReferringProvider_2 NM1_OtherPayerReferringProvider;
        public List<REF_OrderingProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification;
    }
    public class Loop_2330I_837I
    {
        public NM1_OtherPayerBillingProvider_2 NM1_OtherPayerBillingProvider;
        public List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentifier;
    }
    public class Loop_2400_837I
    {
        public LX_HeaderNumber LX_ServiceLineNumber;
        public SV2_InstitutionalServiceLine SV2_InstitutionalServiceLine;
        public List<PWK_ClaimSupplementalInformation_2> PWK_LineSupplementalInformation;
        public DTP_ServiceDate_2 DTP_Date_ServiceDate;
        public All_REF_837I_5 AllREF;
        public All_AMT_837I AllAMT;
        public NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes;
        public HCP_LinePricing_2 HCP_LinePricing_RepricingInformation;
        public Loop_2410_837I Loop2410;
        public All_NM1_837I_5 AllNM1;
        public List<Loop_2430_837I> Loop2430;
    }
    public class Loop_2410_837I
    {
        public LIN_DrugIdentification LIN_DrugIdentification;
        public CTP_DrugQuantity CTP_DrugQuantity;
        public REF_PrescriptionorCompoundDrugAssociationNumber REF_PrescriptionorCompoundDrugAssociationNumber;
    }
    public class Loop_2420A_837I
    {
        public NM1_OperatingPhysicianName NM1_OperatingPhysicianName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2420B_837I
    {
        public NM1_OtherOperatingPhysicianName NM1_OtherOperatingPhysicianName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherOperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2420C_837I
    {
        public NM1_RenderingProviderName_2 NM1_RenderingProviderName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2420D_837I
    {
        public NM1_ReferringProviderName_2 NM1_ReferringProviderName;
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2430_837I
    {
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation;
        public List<CAS_ClaimLevelAdjustments> CAS_LineAdjustment;
        public DTP_ClaimCheckOrRemittanceDate DTP_LineCheckorRemittanceDate;
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability;
    }
    public class TS837I 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_3 BHT_BeginningOfHierarchicalTransaction;
        public All_NM1_837I_6 AllNM1;
        public List<Loop_2000A_837I> Loop2000A;
        public SE SE;
    }
}
