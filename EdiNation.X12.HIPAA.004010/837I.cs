namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_2010A_837I
    {
        public Loop_2010AA_837I Loop2010AA;
        public Loop_2010AB_837I Loop2010AB;
    }
    public class All_2010B_837I
    {
        public Loop_2010BA_837I Loop2010BA;
        public Loop_2010BB_837I Loop2010BB;
        public Loop_2010BC_837I Loop2010BC;
        public Loop_2010BD_837I Loop2010BD;
    }
    public class All_2310_837I
    {
        public Loop_2310A_837I Loop2310A;
        public Loop_2310B_837I Loop2310B;
        public Loop_2310C_837I Loop2310C;
        public Loop_2310E_837I Loop2310E;
    }
    public class All_2330_837I
    {
        public Loop_2330A_837I Loop2330A;
        public Loop_2330B_837I Loop2330B;
        public Loop_2330C_837I Loop2330C;
        public Loop_2330D_837I Loop2330D;
        public Loop_2330E_837I Loop2330E;
        public Loop_2330F_837I Loop2330F;
        public Loop_2330H_837I Loop2330H;
    }
    public class All_2420_837I
    {
        public Loop_2420A_837I Loop2420A;
        public Loop_2420B_837I Loop2420B;
        public Loop_2420C_837I Loop2420C;
    }
    public class All_AMT_837I
    {
        public AMT_PayerEstimatedAmountDue AMT_PayerEstimatedAmountDue;
        public AMT_PatientEstimatedAmountDue AMT_PatientEstimatedAmountDue;
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount AMT_PatientPaidAmount;
        public AMT_CreditDebitCardMaximumAmount AMT_CreditDebitCardMaximumAmount;
    }
    public class All_AMT_837I_2
    {
        public AMT_PayerPriorPayment AMT_PayerPriorPayment;
        public AMT_CoordinationOfBenefitsCOBAllowedAmount AMT_CoordinationOfBenefitsCOBTotalAllowedAmount;
        public AMT_ClaimSubmittedCharges AMT_CoordinationOfBenefitsCOBTotalSubmittedCharges;
        public AMT_DiagnosticRelatedGroupDRGOutlierAmount AMT_DiagnosticRelatedGroupDRGOutlierAmount;
        public AMT_CoordinationOfBenefitsCOBTotalMedicarePaidAmount AMT_CoordinationOfBenefitsCOBTotalMedicarePaidAmount;
        public AMT_MedicarePaidAmount100 AMT_MedicarePaidAmount100;
        public AMT_MedicarePaidAmount80 AMT_MedicarePaidAmount80;
        public AMT_CoordinationOfBenefitsCOBMedicareATrustFundPaidAmount AMT_CoordinationOfBenefitsCOBMedicareATrustFundPaidAmount;
        public AMT_CoordinationOfBenefitsCOBMedicareBTrustFundPaidAmount AMT_CoordinationOfBenefitsCOBMedicareBTrustFundPaidAmount;
        public AMT_CoordinationOfBenefitsCOBTotalNoncoveredAmount AMT_CoordinationOfBenefitsCOBTotalNoncoveredAmount;
        public AMT_CoordinationOfBenefitsCOBTotalDeniedAmount AMT_CoordinationOfBenefitsCOBTotalDeniedAmount;
    }
    public class All_AMT_837I_3
    {
        public AMT_ServiceTaxAmount AMT_ServiceTaxAmount;
        public AMT_FacilityTaxAmount AMT_FacilityTaxAmount;
    }
    public class All_CRC_837I
    {
        public List<CRC_HomeHealthFunctionalLimitations> CRC_HomeHealthFunctionalLimitations;
        public List<CRC_HomeHealthActivitiesPermitted> CRC_HomeHealthActivitiesPermitted;
        public List<CRC_HomeHealthMentalStatus> CRC_HomeHealthMentalStatus;
    }
    public class All_DTP_837I
    {
        public DTP_DischargeHour DTP_DischargeHour;
        public DTP_StatementDates DTP_StatementDates;
        public DTP_AdmissionDateHour DTP_AdmissionDateHour;
    }
    public class All_DTP_837I_2
    {
        public DTP_DateService DTP_ServiceLineDate;
        public DTP_AssessmentDate DTP_AssessmentDate;
    }
    public class All_HI_837I
    {
        ///Information
        public HI_PrincipalAdmittingECodeAndPatientReasonForVisitDiagnosisInformation HI_PrincipalAdmittingECodeAndPatientReasonForVisitDiagnosisInformation;
        public HI_DiagnosisRelatedGroupDRGInformation HI_DiagnosisRelatedGroupDRGInformation;
        public List<HI_OtherDiagnosisInformation> HI_OtherDiagnosisInformation;
        public HI_PrincipalProcedureInformation HI_PrincipalProcedureInformation;
        public List<HI_OtherProcedureInformation> HI_OtherProcedureInformation;
        public List<HI_OccurrenceSpanInformation> HI_OccurrenceSpanInformation;
        public List<HI_OccurrenceInformation> HI_OccurrenceInformation;
        public List<HI_ValueInformation> HI_ValueInformation;
        public List<HI_ConditionInformation> HI_ConditionInformation;
        public List<HI_TreatmentCodeInformation> HI_TreatmentCodeInformation;
    }
    public class All_NTE_837I
    {
        public List<NTE_ClaimNote_2> NTE_ClaimNote;
        public NTE_BillingNote NTE_BillingNote;
    }
    public class All_REF_837I
    {
        public List<REF_BillingProviderSecondaryIdentification_2> REF_BillingProviderSecondaryIdentification_2010AA;
        public List<REF_ClaimSubmitterCreditDebitCardInformation> REF_CreditDebitCardBillingInformation_2010AA;
    }
    public class All_REF_837I_2
    {
        public List<REF_OtherPayerPatientIdentification> REF_SubscriberSecondaryIdentification_2010BA;
        public REF_PropertyAndCasualtyClaimNumber REF_PropertyAndCasualtyClaimNumber_2010BA;
    }
    public class All_REF_837I_3
    {
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber;
        public REF_RepricedClaimNumber REF_RepricedClaimNumber;
        ///Intermediaries
        public REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries;
        public List<REF_DocumentIdentificationCode> REF_DocumentIdentificationCode;
        public REF_OriginalReferenceNumberICNDCN REF_OriginalReferenceNumberICNDCN;
        public REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber;
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode;
        public REF_PeerReviewOrganizationPROApprovalNumber REF_PeerReviewOrganizationPROApprovalNumber;
        public List<REF_DependentAdditionalInformation> REF_PriorAuthorizationOrReferralNumber;
        public REF_MedicalRecordIdentification REF_MedicalRecordNumber;
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier;
    }
    public class All_REF_837I_4
    {
        public List<REF_OtherPayerSecondaryIdentificationAndReferenceNumber> REF_OtherPayerSecondaryIdentificationAndReferenceNumber;
        public REF_DependentAdditionalInformation REF_OtherPayerPriorAuthorizationOrReferralNumber;
    }
    public class Loop_1000A_837I
    {
        public NM1_SubmitterName NM1_SubmitterName;
        public List<PER_OtherPayerContactInformation> PER_SubmitterEDIContactInformation;
    }
    public class Loop_1000B_837I
    {
        public NM1_ReceiverName NM1_ReceiverName;
    }
    public class Loop_2000A_837I
    {
        public HL_BillingPaytoProviderHierarchicalLevel HL_BillingPayToProviderHierarchicalLevel;
        public PRV_BillingPaytoProviderSpecialtyInformation PRV_BillingPayToProviderSpecialtyInformation;
        public CUR_ForeignCurrencyInformation_2 CUR_ForeignCurrencyInformation;
        public All_2010A_837I All2010A;
        public List<Loop_2000B_837I> Loop2000B;
    }
    public class Loop_2000B_837I
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel;
        public SBR_SubscriberInformation_3 SBR_SubscriberInformation;
        public All_2010B_837I All2010B;
        public List<Loop_2300_837I_2> Loop2300;
        public List<Loop_2000C_837I> Loop2000C;
    }
    public class Loop_2000C_837I
    {
        public HL_DependentLevel HL_PatientHierarchicalLevel;
        public PAT_PatientInformation_4 PAT_PatientInformation;
        public Loop_2010CA_837I Loop2010CA;
        public List<Loop_2300_837I> Loop2300;
    }
    public class Loop_2010AA_837I
    {
        public NM1_BillingProviderName_2 NM1_BillingProviderName_2010AA;
        public N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress_2010AA;
        public N4_BillingProviderCityStateZIPCode N4_BillingProviderCityStateZIPCode_2010AA;
        public All_REF_837I AllREF;
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation_2010AA;
    }
    public class Loop_2010AB_837I
    {
        public NM1_PayToProviderName NM1_PayToProviderName_2010AB;
        public N3_AdditionalPatientInformationContactAddress N3_PayToProviderAddress_2010AB;
        public N4_BillingProviderCityStateZIPCode N4_PayToProviderCityStateZIPCode_2010AB;
        public List<REF_BillingProviderSecondaryIdentification_2> REF_PayToProviderSecondaryIdentification_2010AB;
    }
    public class Loop_2010BA_837I
    {
        public NM1_SubscriberName_4 NM1_SubscriberName_2010BA;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress_2010BA;
        public N4_BillingProviderCityStateZIPCode N4_SubscriberCityStateZIPCode_2010BA;
        public DMG_DependentDemographicInformation_3 DMG_SubscriberDemographicInformation_2010BA;
        public All_REF_837I_2 AllREF;
    }
    public class Loop_2010BB_837I
    {
        public NM1_CreditDebitCardAccountHolderName NM1_CreditDebitCardAccountHolderName_2010BB;
        public List<REF_CreditDebitCardInformation> REF_CreditDebitCardInformation_2010BB;
    }
    public class Loop_2010BC_837I
    {
        public NM1_OtherPayerName NM1_PayerName_2010BC;
        public N3_AdditionalPatientInformationContactAddress N3_PayerAddress_2010BC;
        public N4_BillingProviderCityStateZIPCode N4_PayerCityStateZIPCode_2010BC;
        public List<REF_PayerSecondaryIdentification> REF_PayerSecondaryIdentification_2010BC;
    }
    public class Loop_2010BD_837I
    {
        public NM1_ResponsiblePartyName NM1_ResponsiblePartyName_2010BD;
        public N3_AdditionalPatientInformationContactAddress N3_ResponsiblePartyAddress_2010BD;
        public N4_BillingProviderCityStateZIPCode N4_ResponsiblePartyCityStateZIPCode_2010BD;
    }
    public class Loop_2010CA_837I
    {
        public NM1_PatientName_2 NM1_PatientName_2010CA;
        public N3_AdditionalPatientInformationContactAddress N3_PatientAddress_2010CA;
        public N4_BillingProviderCityStateZIPCode N4_PatientCityStateZIPCode_2010CA;
        public DMG_DependentDemographicInformation_3 DMG_PatientDemographicInformation_2010CA;
        public All_REF_837I_2 AllREF;
    }
    public class Loop_2300_837I
    {
        public CLM_ClaimInformation_3 CLM_ClaimInformation;
        public All_DTP_837I AllDTP;
        public CL1_InstitutionalClaimCode_2 CL1_InstitutionalClaimCode;
        public List<PWK_ClaimSupplementalInformation_3> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation_2 CN1_ContractInformation;
        public All_AMT_837I AllAMT;
        public All_REF_837I_3 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public All_NTE_837I AllNTE;
        public CR6_HomeHealthCareInformation_3 CR6_HomeHealthCareInformation;
        public All_CRC_837I AllCRC;
        public All_HI_837I AllHI;
        public List<QTY_ClaimQuantity> QTY_ClaimQuantity;
        public HCP_ClaimPricingRepricingInformation_2 HCP_ClaimPricingRepricingInformation;
        public List<Loop_2305_837I> Loop2305;
        public All_2310_837I All2310;
        public List<Loop_2320_837I> Loop2320;
        public List<Loop_2400_837I> Loop2400;
    }
    public class Loop_2300_837I_2
    {
        public CLM_ClaimInformation_3 CLM_ClaimInformation;
        public All_DTP_837I AllDTP;
        public CL1_InstitutionalClaimCode_2 CL1_InstitutionalClaimCode;
        public List<PWK_ClaimSupplementalInformation_3> PWK_ClaimSupplementalInformation;
        public CN1_ContractInformation_2 CN1_ContractInformation;
        public All_AMT_837I AllAMT;
        public All_REF_837I_3 AllREF;
        public List<K3_FileInformation> K3_FileInformation;
        public All_NTE_837I AllNTE;
        public CR6_HomeHealthCareInformation_3 CR6_HomeHealthCareInformation;
        public All_CRC_837I AllCRC;
        public All_HI_837I AllHI;
        public List<QTY_ClaimQuantity> QTY_ClaimQuantity;
        public HCP_ClaimPricingRepricingInformation_2 HCP_ClaimPricingRepricingInformation;
        public List<Loop_2305_837I> Loop2305;
        public All_2310_837I All2310;
        public List<Loop_2320_837I> Loop2320;
        public List<Loop_2400_837I> Loop2400;
    }
    public class Loop_2305_837I
    {
        public CR7_HomeHealthCarePlanInformation CR7_HomeHealthCarePlanInformation;
        public List<HSD_HealthCareServicesDelivery_6> HSD_HealthCareServicesDelivery;
    }
    public class Loop_2310A_837I
    {
        public NM1_AttendingPhysicianName NM1_AttendingPhysicianName;
        public PRV_AttendingPhysicianSpecialtyInformation PRV_AttendingPhysicianSpecialtyInformation;
        public List<REF_AttendingPhysicianSecondaryIdentification> REF_AttendingPhysicianSecondaryIdentification;
    }
    public class Loop_2310B_837I
    {
        public NM1_OperatingPhysicianName NM1_OperatingPhysicianName;
        public List<REF_AttendingPhysicianSecondaryIdentification> REF_OperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2310C_837I
    {
        public NM1_OtherProviderName NM1_OtherProviderName;
        public List<REF_AttendingPhysicianSecondaryIdentification> REF_OtherProviderSecondaryIdentification;
    }
    public class Loop_2310E_837I
    {
        public NM1_ServiceFacilityName NM1_ServiceFacilityName;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityAddress;
        public N4_BillingProviderCityStateZIPCode N4_ServiceFacilityCityStateZipCode;
        public List<REF_ServiceFacilitySecondaryIdentification> REF_ServiceFacilitySecondaryIdentification;
    }
    public class Loop_2320_837I
    {
        public SBR_OtherSubscriberInformation_3 SBR_OtherSubscriberInformation;
        public List<CAS_ClaimAdjustment> CAS_ClaimLevelAdjustment;
        public All_AMT_837I_2 AllAMT;
        public DMG_DependentDemographicInformation_3 DMG_OtherSubscriberDemographicInformation;
        public OI_OtherInsuranceCoverageInformation_3 OI_OtherInsuranceCoverageInformation;
        public MIA_InpatientAdjudicationInformation MIA_MedicareInpatientAdjudicationInformation;
        public MOA_MedicareOutpatientAdjudicationInformation MOA_MedicareOutpatientAdjudicationInformation;
        public All_2330_837I All2330;
    }
    public class Loop_2330A_837I
    {
        public NM1_OtherSubscriberName NM1_OtherSubscriberName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress;
        public N4_BillingProviderCityStateZIPCode N4_OtherSubscriberCityStateZIPCode;
        public List<REF_OtherPayerPatientIdentification> REF_OtherSubscriberSecondaryInformation;
    }
    public class Loop_2330B_837I
    {
        public NM1_OtherPayerName NM1_OtherPayerName;
        public N3_AdditionalPatientInformationContactAddress N3_OtherPayerAddress;
        public N4_BillingProviderCityStateZIPCode N4_OtherPayerCityStateZIPCode;
        public DTP_ClaimAdjudicationDate DTP_ClaimAdjudicationDate;
        public All_REF_837I_4 AllREF;
    }
    public class Loop_2330C_837I
    {
        public NM1_OtherPayerPatientInformation_2 NM1_OtherPayerPatientInformation;
        public List<REF_OtherPayerPatientIdentificationNumber> REF_OtherPayerPatientIdentificationNumber;
    }
    public class Loop_2330D_837I
    {
        public NM1_OtherPayerAttendingProvider NM1_OtherPayerAttendingProvider;
        public List<REF_OtherPayerAttendingProviderIdentification> REF_OtherPayerAttendingProviderIdentification;
    }
    public class Loop_2330E_837I
    {
        public NM1_OtherPayerOperatingProvider NM1_OtherPayerOperatingProvider;
        public List<REF_OtherPayerAttendingProviderIdentification> REF_OtherPayerOperatingProviderIdentification;
    }
    public class Loop_2330F_837I
    {
        public NM1_OtherPayerOtherProvider NM1_OtherPayerOtherProvider;
        public List<REF_OtherPayerOtherProviderIdentification> REF_OtherPayerOtherProviderIdentification;
    }
    public class Loop_2330H_837I
    {
        public NM1_OtherPayerServiceFacilityProvider NM1_OtherPayerServiceFacilityProvider;
        public List<REF_OtherPayerReferringProviderIdentification> REF_OtherPayerServiceFacilityProviderIdentification;
    }
    public class Loop_2400_837I
    {
        public LX_HeaderNumber LX_ServiceLineNumber;
        public SV2_InstitutionalServiceLine SV2_InstitutionalServiceLine;
        public List<PWK_LineSupplementalInformation> PWK_LineSupplementalInformation;
        public All_DTP_837I_2 AllDTP;
        public All_AMT_837I_3 AllAMT;
        public HCP_ClaimPricingRepricingInformation_2 HCP_LinePricingRepricingInformation;
        public List<Loop_2410_837I> Loop2410;
        public All_2420_837I All2420;
        public List<Loop_2430_837I> Loop2430;
    }
    public class Loop_2410_837I
    {
        public LIN_DrugIdentification LIN_DrugIdentification;
        public CTP_DrugPricing CTP_DrugPricing;
        public REF_PrescriptionNumber REF_PrescriptionNumber;
    }
    public class Loop_2420A_837I
    {
        public NM1_AttendingPhysicianName NM1_AttendingPhysicianName;
        public REF_AttendingPhysicianSecondaryIdentification REF_AttendingPhysicianSecondaryIdentification;
    }
    public class Loop_2420B_837I
    {
        public NM1_OperatingPhysicianName NM1_OperatingPhysicianName;
        public REF_AttendingPhysicianSecondaryIdentification REF_OperatingPhysicianSecondaryIdentification;
    }
    public class Loop_2420C_837I
    {
        public NM1_OtherProviderName NM1_OtherProviderName;
        public REF_AttendingPhysicianSecondaryIdentification REF_OtherProviderSecondaryIdentification;
    }
    public class Loop_2430_837I
    {
        public SVD_ServiceLineAdjudicationInformation SVD_ServiceLineAdjudicationInformation;
        public List<CAS_ClaimAdjustment> CAS_ServiceLineAdjustment;
        public DTP_ClaimAdjudicationDate DTP_ServiceAdjudicationDate;
    }
    public class TS837I 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_7 BHT_BeginningOfHierarchicalTransaction;
        public REF_TransmissionTypeIdentification REF_TransmissionTypeIdentification;
        public Loop_1000A_837I Loop1000A;
        public Loop_1000B_837I Loop1000B;
        public List<Loop_2000A_837I> Loop2000A;
        public SE SE;
    }
}
