namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_2010A_837D
    {
        public Loop_2010AA_837D Loop2010AA;
        public Loop_2010AB_837D Loop2010AB;
    }
    public class All_2010B_837D
    {
        public Loop_2010BA_837D Loop2010BA;
        public Loop_2010BB_837D Loop2010BB;
        public Loop_2010BC_837D Loop2010BC;
    }
    public class All_2310_837D
    {
        public List<Loop_2310A_837D> Loop2310A;
        public Loop_2310B_837D Loop2310B;
        public Loop_2310C_837D Loop2310C;
        public Loop_2310D_837D Loop2310D;
    }
    public class All_2330_837D
    {
        public Loop_2330A_837D Loop2330A;
        public Loop_2330B_837D Loop2330B;
        public Loop_2330C_837D Loop2330C;
        public Loop_2330D_837D Loop2330D;
        public Loop_2330E_837D Loop2330E;
    }
    public class All_2420_837D
    {
        public Loop_2420A_837D Loop2420A;
        public Loop_2420B_837D Loop2420B;
        public Loop_2420C_837D Loop2420C;
    }
    public class All_AMT_837D
    {
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount AMT_PatientAmountPaid;
        public AMT_CreditDebitCardMaximumAmount AMT_CreditDebitCardMaximumAmount;
    }
    public class All_AMT_837D_2
    {
        public AMT_ApprovedAmount AMT_ApprovedAmount;
        public AMT_CoordinationOfBenefitsCOBTaxAmount AMT_SalesTaxAmount;
    }
    public class All_AMT_837D_3
    {
        public AMT_CoordinationOfBenefitsCOBPayerPaidAmount AMT_CoordinationOfBenefitsCOBPayerPaidAmount;
        public AMT_ApprovedAmount AMT_CoordinationOfBenefitsCOBApprovedAmount;
        public AMT_CoordinationOfBenefitsCOBAllowedAmount AMT_CoordinationOfBenefitsCOBAllowedAmount;
        public AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount;
        public AMT_CoordinationOfBenefitsCOBCoveredAmount AMT_CoordinationOfBenefitsCOBCoveredAmount;
        public AMT_CoordinationOfBenefitsCOBDiscountAmount AMT_CoordinationOfBenefitsCOBDiscountAmount;
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount AMT_CoordinationOfBenefitsCOBPatientPaidAmount;
    }
    public class All_DTP_837D
    {
        public DTP_DateAdmission DTP_DateAdmission;
        public DTP_DateDischarge DTP_DateDischarge;
        public DTP_DateReferral DTP_DateReferral;
        public DTP_AccidentDate DTP_DateAccident;
        public List<DTP_DateAppliancePlacement> DTP_DateAppliancePlacement;
        public DTP_DateService DTP_DateService;
    }
    public class All_DTP_837D_2
    {
        public DTP_DateService_2 DTP_DateService;
        public DTP_DatePriorPlacement DTP_DatePriorPlacement;
        public DTP_DateAppliancePlacement DTP_DateAppliancePlacement;
        public DTP_DateReplacement DTP_DateReplacement;
    }
    public class All_REF_837D
    {
        public List<REF_BillingProviderSecondaryIdentificationNumber> REF_BillingProviderSecondaryIdentificationNumber_2010AA;
        public List<REF_ClaimSubmitterCreditDebitCardInformation> REF_ClaimSubmitterCreditDebitCardInformation_2010AA;
    }
    public class All_REF_837D_2
    {
        public List<REF_OtherPayerPatientIdentification> REF_SubscriberSecondaryIdentification_2010BA;
        public REF_PropertyAndCasualtyClaimNumber REF_PropertyAndCasualtyClaimNumber_2010BA;
    }
    public class All_REF_837D_3
    {
        public List<REF_PredeterminationIdentification> REF_PredeterminationIdentification;
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode;
        public REF_OriginalReferenceNumberICNDCN REF_OriginalReferenceNumberICNDCN;
        public List<REF_DependentAdditionalInformation> REF_PriorAuthorizationOrReferralNumber;
        ///Intermediaries
        public REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries;
    }
    public class All_REF_837D_4
    {
        public REF_PredeterminationIdentification REF_ServicePredeterminationIdentification;
        public List<REF_DependentAdditionalInformation> REF_PriorAuthorizationOrReferralNumber;
        public REF_LineItemControlNumber REF_LineItemControlNumber;
    }
    public class All_REF_837D_5
    {
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier;
        public List<REF_DependentAdditionalInformation> REF_OtherPayerPriorAuthorizationOrReferralNumber;
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator;
    }
    public class Loop_1000A_837D
    {
        public NM1_SubmitterName NM1_SubmitterName;
        public List<PER_OtherPayerContactInformation> PER_SubmitterContactInformation;
    }
    public class Loop_1000B_837D
    {
        public NM1_ReceiverName NM1_ReceiverName;
    }
    public class Loop_2000A_837D
    {
        public HL_BillingPaytoProviderHierarchicalLevel HL_BillingPaytoProviderHierarchicalLevel;
        public PRV_BillingPaytoProviderSpecialtyInformation PRV_BillingPaytoProviderSpecialtyInformation;
        public CUR_ForeignCurrencyInformation_2 CUR_ForeignCurrencyInformation;
        public All_2010A_837D All2010A;
        public List<Loop_2000B_837D> Loop2000B;
    }
    public class Loop_2000B_837D
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel;
        public SBR_SubscriberInformation_2 SBR_SubscriberInformation;
        public All_2010B_837D All2010B;
        public List<Loop_2300_837D_2> Loop2300;
        public List<Loop_2000C_837D> Loop2000C;
    }
    public class Loop_2000C_837D
    {
        public HL_DependentLevel HL_PatientHierarchicalLevel;
        public PAT_PatientInformation_3 PAT_PatientInformation;
        public Loop_2010CA_837D Loop2010CA;
        public List<Loop_2300_837D> Loop2300;
    }
    public class Loop_2010AA_837D
    {
        public NM1_BillingProviderName NM1_BillingProviderName_2010AA;
        public N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress_2010AA;
        public N4_BillingProviderCityStateZIPCode N4_BillingProviderCityStateZIPCode_2010AA;
        public All_REF_837D AllREF;
    }
    public class Loop_2010AB_837D
    {
        public NM1_PaytoProviderName NM1_PaytoProvidersName_2010AB;
        public N3_AdditionalPatientInformationContactAddress N3_PaytoProvidersAddress_2010AB;
        public N4_BillingProviderCityStateZIPCode N4_PaytoProviderCityStateZip_2010AB;
        public List<REF_BillingProviderSecondaryIdentificationNumber> REF_PaytoProviderSecondaryIdentificationNumber_2010AB;
    }
    public class Loop_2010BA_837D
    {
        public NM1_SubscriberName_4 NM1_SubscriberName_2010BA;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress_2010BA;
        public N4_BillingProviderCityStateZIPCode N4_SubscriberCityStateZIPCode_2010BA;
        public DMG_DependentDemographicInformation_3 DMG_SubscriberDemographicInformation_2010BA;
        public All_REF_837D_2 AllREF;
    }
    public class Loop_2010BB_837D
    {
        public NM1_OtherPayerName NM1_PayerName_2010BB;
        public N3_AdditionalPatientInformationContactAddress N3_PayerAddress_2010BB;
        public N4_BillingProviderCityStateZIPCode N4_PayerCityStateZIPCode_2010BB;
        public List<REF_PayerSecondaryIdentification> REF_PayerSecondaryIdentificationNumber_2010BB;
    }
    public class Loop_2010BC_837D
    {
        public NM1_CreditDebitCardAccountHolderName NM1_CreditDebitCardHolderName_2010BC;
        public List<REF_CreditDebitCardInformation_2> REF_CreditDebitCardInformation_2010BC;
    }
    public class Loop_2010CA_837D
    {
        public NM1_PatientName_2 NM1_PatientName_2010CA;
        public N3_AdditionalPatientInformationContactAddress N3_PatientAddress_2010CA;
        public N4_BillingProviderCityStateZIPCode N4_PatientCityStateZIPCode_2010CA;
        public DMG_DependentDemographicInformation_3 DMG_PatientDemographicInformation_2010CA;
        public All_REF_837D_2 AllREF;
    }
    public class Loop_2300_837D
    {
        public CLM_ClaimInformation_2 CLM_ClaimInformation;
        public All_DTP_837D AllDTP;
        public DN1_OrthodonticTotalMonthsOfTreatment DN1_OrthodonticTotalMonthsOfTreatment;
        public List<DN2_ToothStatus> DN2_ToothStatus;
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation;
        public All_AMT_837D AllAMT;
        public All_REF_837D_3 AllREF;
        public List<NTE_BillingNote> NTE_ClaimNote;
        public All_2310_837D All2310;
        public List<Loop_2320_837D> Loop2320;
        public List<Loop_2400_837D> Loop2400;
    }
    public class Loop_2300_837D_2
    {
        public CLM_ClaimInformation_2 CLM_ClaimInformation;
        public All_DTP_837D AllDTP;
        public DN1_OrthodonticTotalMonthsOfTreatment DN1_OrthodonticTotalMonthsOfTreatment;
        public List<DN2_ToothStatus> DN2_ToothStatus;
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation;
        public All_AMT_837D AllAMT;
        public All_REF_837D_3 AllREF;
        public List<NTE_BillingNote> NTE_ClaimNote;
        public All_2310_837D All2310;
        public List<Loop_2320_837D> Loop2320;
        public List<Loop_2400_837D> Loop2400;
    }
    public class Loop_2310A_837D
    {
        public NM1_ReferringProviderName NM1_ReferringProviderName;
        public PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation;
        public List<REF_BillingProviderSecondaryIdentificationNumber> REF_ReferringProviderSecondaryIdentification;
    }
    public class Loop_2310B_837D
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_BillingProviderSecondaryIdentificationNumber> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2310C_837D
    {
        public NM1_ServiceFacilityLocation_2 NM1_ServiceFacilityLocation;
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2> REF_ServiceFacilityLocationSecondaryIdentification;
    }
    public class Loop_2310D_837D
    {
        public NM1_AssistantSurgeonName NM1_AssistantSurgeonName;
        public PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation;
        public REF_AssistantSurgeonSecondaryIdentification REF_AssistantSurgeonSecondaryIdentification;
    }
    public class Loop_2320_837D
    {
        public SBR_OtherSubscriberInformation_2 SBR_OtherSubscriberInformation;
        public List<CAS_ClaimAdjustment> CAS_ClaimAdjustment;
        public All_AMT_837D_3 AllAMT;
        public DMG_DependentDemographicInformation_3 DMG_OtherInsuredDemographicInformation;
        public OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation;
        public All_2330_837D All2330;
    }
    public class Loop_2330A_837D
    {
        public NM1_OtherSubscriberName_2 NM1_OtherSubscriberName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress;
        public N4_BillingProviderCityStateZIPCode N4_OtherSubscriberCityStateZipCode;
        public List<REF_OtherPayerPatientIdentification> REF_OtherSubscriberSecondaryIdentification;
    }
    public class Loop_2330B_837D
    {
        public NM1_OtherPayerName NM1_OtherPayerName;
        public List<PER_OtherPayerContactInformation> PER_OtherPayerContactInformation;
        public DTP_ClaimAdjudicationDate DTP_ClaimPaidDate;
        public All_REF_837D_5 AllREF;
    }
    public class Loop_2330C_837D
    {
        public NM1_OtherPayerPatientInformation NM1_OtherPayerPatientInformation;
        public List<REF_OtherPayerPatientIdentification> REF_OtherPayerPatientIdentification;
    }
    public class Loop_2330D_837D
    {
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider;
        public List<REF_BillingProviderSecondaryIdentificationNumber> REF_OtherPayerReferringProviderIdentification;
    }
    public class Loop_2330E_837D
    {
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider;
        public List<REF_BillingProviderSecondaryIdentificationNumber> REF_OtherPayerRenderingProviderIdentification;
    }
    public class Loop_2400_837D
    {
        public List<LX_HeaderNumber> LX_LineCounter;
        public SV3_DentalService SV3_DentalService;
        public List<TOO_ToothInformation> TOO_ToothInformation;
        public All_DTP_837D_2 AllDTP;
        public List<QTY_AnesthesiaQuantity> QTY_AnesthesiaQuantity;
        public All_REF_837D_4 AllREF;
        public All_AMT_837D_2 AllAMT;
        public List<NTE_BillingNote> NTE_LineNote;
        public All_2420_837D All2420;
        public List<Loop_2430_837D> Loop2430;
    }
    public class Loop_2420A_837D
    {
        public NM1_RenderingProviderName NM1_RenderingProviderName;
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation;
        public List<REF_BillingProviderSecondaryIdentificationNumber> REF_RenderingProviderSecondaryIdentification;
    }
    public class Loop_2420B_837D
    {
        public NM1_OtherPayerName NM1_OtherPayerReferralNumber;
        public List<REF_DependentAdditionalInformation> REF_OtherPayerPriorAuthorizationOrReferralNumber;
    }
    public class Loop_2420C_837D
    {
        public NM1_AssistantSurgeonName NM1_AssistantSurgeonName;
        public PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation;
        public REF_AssistantSurgeonSecondaryIdentification REF_AssistantSurgeonSecondaryIdentification;
    }
    public class Loop_2430_837D
    {
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation;
        public List<CAS_ClaimAdjustment> CAS_ServiceAdjustment;
        public DTP_ClaimAdjudicationDate DTP_LineAdjudicationDate;
    }
    public class TS837D 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_7 BHT_BeginningOfHierarchicalTransaction;
        public REF_TransmissionTypeIdentification REF_TransmissionTypeIdentification;
        public Loop_1000A_837D Loop1000A;
        public Loop_1000B_837D Loop1000B;
        public List<Loop_2000A_837D> Loop2000A;
        public SE SE;
    }
}
