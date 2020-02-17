namespace EdiNation.X12.HIPAA005010
{
    using System.Collections.Generic;
    public class All_AMT_837D
    {
        public AMT_CoordinationofBenefits AMT_CoordinationofBenefits_COB_PayerPaidAmount;
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability;
        public AMT_CoordinationofBenefits_2 AMT_CoordinationofBenefits_COB_TotalNon_Amount;
    }
    public class All_DTP_837D
    {
        public DTP_ServiceDate DTP_Date_ServiceDate;
        public DTP_PriorPlacement DTP_Date_PriorPlacement;
        public DTP_AppliancePlacement DTP_Date_AppliancePlacement;
        public DTP_Replacement DTP_Date_Replacement;
        public DTP_TreatmentStart DTP_Date_TreatmentStart;
        public DTP_TreatmentCompletion DTP_Date_TreatmentCompletion;
    }
    public class All_DTP_837D_2
    {
        public DTP_AccidentDate_2 DTP_Date_Accident;
        public DTP_AppliancePlacement DTP_Date_AppliancePlacement;
        public DTP_ClaimLevelServiceDate DTP_Date_ServiceDate;
        public DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate;
    }
    public class All_NM1_837D
    {
        public Loop_2010AA_837D Loop2010AA;
        public Loop_2010AB_837D Loop2010AB;
        public Loop_2010AC_837D Loop2010AC;
    }
    public class All_NM1_837D_2
    {
        public Loop_2010BA_837D Loop2010BA;
        public Loop_2010BB_837D Loop2010BB;
    }
    public class All_NM1_837D_3
    {
        public List<Loop_2310A_837D> Loop2310A;
        public Loop_2310B_837D Loop2310B;
        public Loop_2310C_837D Loop2310C;
        public Loop_2310D_837D Loop2310D;
        public Loop_2310E_837D Loop2310E;
    }
    public class All_NM1_837D_4
    {
        public Loop_2330A_837D Loop2330A;
        public Loop_2330B_837D Loop2330B;
        public List<Loop_2330C_837D> Loop2330C;
        public Loop_2330D_837D Loop2330D;
        public Loop_2330E_837D Loop2330E;
        public Loop_2330F_837D Loop2330F;
        public Loop_2330G_837D Loop2330G;
        public Loop_2330H_837D Loop2330H;
    }
    public class All_NM1_837D_5
    {
        public Loop_2420A_837D Loop2420A;
        public Loop_2420B_837D Loop2420B;
        public Loop_2420C_837D Loop2420C;
        public Loop_2420D_837D Loop2420D;
    }
    public class All_NM1_837D_6
    {
        public Loop_1000A_837D Loop1000A;
        public Loop_1000B_837D Loop1000B;
    }
    public class All_REF_837D
    {
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier;
        public REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber;
        public REF_OtherPayerReferralNumber REF_OtherPayerReferralNumber;
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator;
        public REF_OtherPayerPredeterminationIdentification REF_OtherPayerPredeterminationIdentification;
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber;
    }
    public class All_REF_837D_2
    {
        public List<REF_OtherPayerPredeterminationIdentification> REF_ServicePredeterminationIdentification;
        public List<REF_OtherPayerPriorAuthorizationNumber> REF_PriorAuthorization;
        public REF_LineItemControlNumber REF_LineItemControlNumber;
        public REF_RepricedClaimNumber REF_RepricedClaimNumber;
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber;
        public List<REF_OtherPayerReferralNumber> REF_ReferralNumber;
    }
    public class All_REF_837D_3
    {
        public REF_Pay REF_Pay_ToPlanSecondaryIdentification;
        public REF_BillingProviderTaxIdentification_2 REF_Pay_ToPlanTaxIdentificationNumber;
    }
    public class All_REF_837D_4
    {
        public REF_OtherSubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification;
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber;
    }
    public class All_REF_837D_5
    {
        public List<REF_OtherPayerSecondaryIdentifier> REF_PayerSecondaryIdentification;
        public REF_BillingProviderSecondaryIdentification REF_BillingProviderSecondaryIdentification;
    }
    public class All_REF_837D_6
    {
        public REF_OtherPayerPredeterminationIdentification REF_PredeterminationIdentification;
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode;
        public REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber;
        public REF_OtherPayerReferralNumber REF_ReferralNumber;
        public REF_OtherPayerPriorAuthorizationNumber REF_PriorAuthorization;
        public REF_RepricedClaimNumber REF_RepricedClaimNumber;
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber;
        public REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries;
    }
    public class All_REF_837D_7
    {
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber;
        public REF_PropertyandCasualtyPatientIdentifier REF_PropertyandCasualtyPatientIdentifier;
    }
    public class All_REF_837D_8
    {
        public REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification;
        public List<REF_BillingProviderUPIN> REF_BillingProviderUPIN_LicenseInformation;
    }
    public class Loop_1000A_837D
    {
        public NM1_InformationReceiverName_4 NM1_SubmitterName;
        public List<PER_BillingProviderContactInformation> PER_SubmitterEDIContactInformation;
    }
    public class Loop_1000B_837D
    {
        public NM1_ReceiverName NM1_ReceiverName;
    }
    public class Loop_2000A_837D
    {
        public HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel;
        public PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation;
        public CUR_ForeignCurrencyInformation_3 CUR_ForeignCurrencyInformation;
        public All_NM1_837D AllNM1;
        public List<Loop_2000B_837D> Loop2000B;
    }
    public class Loop_2000B_837D
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel;
        public SBR_SubscriberInformation SBR_SubscriberInformation;
        public All_NM1_837D_2 AllNM1;
        public List<Loop_2300_837D> Loop2300;
        public List<Loop_2000C_837D> Loop2000C;
    }
    public class Loop_2000C_837D
    {
        public HL_DependentLevel HL_PatientHierarchicalLevel;
        public PAT_PatientInformation_2 PAT_PatientInformation;
        public Loop_2010CA_837D Loop2010CA;
        public List<Loop_2300_837D> Loop2300;
    }
    public class Loop_2010AA_837D
    {
        public NM1_BillingProviderName_2 NM1_BillingProviderName;
        public N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress;
        public N4_AdditionalPatientInformationContactCity N4_BillingProviderCity_State_ZIPCode;
        public All_REF_837D_8 AllREF;
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation;
    }
    public class Loop_2010AB_837D
    {
        public NM1_Pay NM1_Pay_AddressName;
        public N3_AdditionalPatientInformationContactAddress N3_Pay_Address_ADDRESS;
        public N4_AdditionalPatientInformationContactCity N4_Pay_Address_City_State_ZIPCode;
    }
    public class Loop_2010AC_837D
    {
        public NM1_Pay_3 NM1_Pay_ToPlanName;
        public N3_AdditionalPatientInformationContactAddress N3_Pay_ToPlanAddress;
        public N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZipCode;
        public All_REF_837D_3 AllREF;
    }
    public class Loop_2010BA_837D
    {
        public NM1_SubscriberName_5 NM1_SubscriberName;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress;
        public N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode;
        public DMG_PatientDemographicInformation DMG_SubscriberDemographicInformation;
        public All_REF_837D_4 AllREF;
    }
    public class Loop_2010BB_837D
    {
        public NM1_OtherPayerName NM1_PayerName;
        public N3_AdditionalPatientInformationContactAddress N3_PayerAddress;
        public N4_AdditionalPatientInformationContactCity N4_PayerCity_State_ZIPCode;
        public All_REF_837D_5 AllREF;
    }
    public class Loop_2010CA_837D
    {
        public NM1_PatientName_3 NM1_PatientName;
        public N3_AdditionalPatientInformationContactAddress N3_PatientAddress;
        public N4_AdditionalPatientInformationContactCity N4_PatientCity_State_ZIPCode;
        public DMG_PatientDemographicInformation DMG_PatientDemographicInformation;
        public All_REF_837D_7 AllREF;
    }
    public class Loop_2300_837D
    {
        public CLM_ClaimInformation CLM_ClaimInformation;
        public All_DTP_837D_2 AllDTP;
        public DN1_OrthodonticTotalMonthsofTreatment DN1_OrthodonticTotalMonthsofTreatment;
        public List<DN2_ToothStatus> DN2_ToothStatus;
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation CN1_ContractInformation;
        public AMT_PatientAmountPaid AMT_PatientAmountPaid;
        public All_REF_837D_6 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public List<NTE_BillingNote> NTE_ClaimNote;
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode;
        public HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation;
        public All_NM1_837D_3 AllNM1;
        public List<Loop_2320_837D> Loop2320;
        public List<Loop_2400_837D> Loop2400;
    }
    public class Loop_2310A_837D
    {
        public NM1_ReferringProviderName NM1_ReferringProviderName;
        public PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation;
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2310B_837D
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2310C_837D
    {
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocationName;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZipCode;
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2310D_837D
    {
        public NM1_AssistantSurgeonName NM1_AssistantSurgeonName;
        public PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_AssistantSurgeonSecondaryIdentification;
    }
    public class Loop_2310E_837D
    {
        public NM1_SupervisingProviderName NM1_SupervisingProviderName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification;
    }
    public class Loop_2320_837D
    {
        public SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation;
        public List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments;
        public All_AMT_837D AllAMT;
        public OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation;
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation;
        public All_NM1_837D_4 AllNM1;
    }
    public class Loop_2330A_837D
    {
        public NM1_OtherSubscriberName NM1_OtherSubscriberName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress;
        public N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZipCode;
        public List<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryIdentification;
    }
    public class Loop_2330B_837D
    {
        public NM1_OtherPayerName NM1_OtherPayerName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherPayerAddress;
        public N4_AdditionalPatientInformationContactCity N4_OtherPayerCity_State_ZIPCode;
        public DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckOrRemittanceDate;
        public All_REF_837D AllREF;
    }
    public class Loop_2330C_837D
    {
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider;
        public List<REF_OrderingProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification;
    }
    public class Loop_2330D_837D
    {
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification;
    }
    public class Loop_2330E_837D
    {
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerSupervisingProviderIdentification;
    }
    public class Loop_2330F_837D
    {
        public NM1_OtherPayerBillingProvider NM1_OtherPayerBillingProvider;
        public List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification;
    }
    public class Loop_2330G_837D
    {
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation;
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2330H_837D
    {
        public NM1_OtherPayerAssistantSurgeon NM1_OtherPayerAssistantSurgeon;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerAssistantSurgeonSecondaryIdentifier;
    }
    public class Loop_2400_837D
    {
        public LX_HeaderNumber LX_ServiceLineNumber;
        public SV3_DentalService SV3_DentalService;
        public List<TOO_ToothInformation> TOO_ToothInformation;
        public All_DTP_837D AllDTP;
        public CN1_ContractInformation CN1_ContractInformation;
        public All_REF_837D_2 AllREF;
        public AMT_SalesTaxAmount AMT_SalesTaxAmount;
        public List<K3_FileInformation> K3_FileInformation;
        public HCP_LinePricing HCP_LinePricing_RepricingInformation;
        public All_NM1_837D_5 AllNM1;
        public List<Loop_2430_837D> Loop2430;
    }
    public class Loop_2420A_837D
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2420B_837D
    {
        public NM1_AssistantSurgeonName NM1_AssistantSurgeonName;
        public PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_AssistantSurgeonSecondaryIdentification;
    }
    public class Loop_2420C_837D
    {
        public NM1_SupervisingProviderName NM1_SupervisingProviderName;
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification;
    }
    public class Loop_2420D_837D
    {
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocationName;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress;
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode;
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2430_837D
    {
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation;
        public List<CAS_ClaimLevelAdjustments> CAS_LineAdjustment;
        public DTP_ClaimCheckOrRemittanceDate DTP_LineCheckorRemittanceDate;
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability;
    }
    public class TS837D 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_8 BHT_BeginningOfHierarchicalTransaction;
        public All_NM1_837D_6 AllNM1;
        public List<Loop_2000A_837D> Loop2000A;
        public SE SE;
    }
}
