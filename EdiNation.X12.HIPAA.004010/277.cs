namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_REF_277
    {
        public REF_PayerClaimIdentificationNumber REF_PayerClaimIdentificationNumber;
        public REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification;
        public REF_MedicalRecordIdentification REF_MedicalRecordIdentification;
    }
    public class All_REF_277_2
    {
        public REF_PayerClaimIdentificationNumber REF_PayerClaimIdentificationNumber;
        public REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification;
        public REF_MedicalRecordIdentification REF_MedicalRecordIdentification;
    }
    public class Loop_2000A_277
    {
        public HL_BillingPaytoProviderHierarchicalLevel HL_InformationSourceLevel;
        public List<Loop_2100A_277> Loop2100A;
        public List<Loop_2000B_277> Loop2000B;
    }
    public class Loop_2000B_277
    {
        public HL_InformationReceiverLevel HL_InformationReceiverLevel;
        public List<Loop_2100B_277> Loop2100B;
        public List<Loop_2000C_277> Loop2000C;
    }
    public class Loop_2000C_277
    {
        public HL_ServiceProviderLevel HL_ServiceProviderLevel;
        public List<Loop_2100C_277> Loop2100C;
        public List<Loop_2000D_277> Loop2000D;
    }
    public class Loop_2000D_277
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel;
        public DMG_DependentDemographicInformation_3 DMG_SubscriberDemographicInformation;
        public Loop_2100D_277 Loop2100D;
        public List<Loop_2200D_277> Loop2200D;
        public List<Loop_2000E_277> Loop2000E;
    }
    public class Loop_2000E_277
    {
        public HL_DependentLevel_2 HL_DependentLevel;
        public DMG_DependentDemographicInformation_3 DMG_DependentDemographicInformation;
        public Loop_2100E_277 Loop2100E;
        public List<Loop_2200E_277> Loop2200E;
    }
    public class Loop_2100A_277
    {
        public NM1_PayerName NM1_PayerName;
        public PER_PayerContactInformation PER_PayerContactInformation;
    }
    public class Loop_2100B_277
    {
        public NM1_InformationReceiverName_2 NM1_InformationReceiverName;
    }
    public class Loop_2100C_277
    {
        public NM1_ProviderName NM1_ProviderName;
    }
    public class Loop_2100D_277
    {
        public NM1_SubscriberName_2 NM1_SubscriberName;
    }
    public class Loop_2100E_277
    {
        public NM1_DependentName_3 NM1_DependentName;
    }
    public class Loop_2200D_277
    {
        public TRN_ClaimSubmitterTraceNumber_2 TRN_ClaimSubmitterTraceNumber;
        public STC_ClaimLevelStatusInformation STC_ClaimLevelStatusInformation;
        public All_REF_277 AllREF;
        public DTP_ClaimServiceDate DTP_ClaimServiceDate;
        public List<Loop_2220D_277> Loop2220D;
    }
    public class Loop_2200E_277
    {
        public TRN_ClaimSubmitterTraceNumber_2 TRN_ClaimSubmitterTraceNumber;
        public STC_ClaimLevelStatusInformation STC_ClaimLevelStatusInformation;
        public All_REF_277_2 AllREF;
        public DTP_ClaimServiceDate DTP_ClaimServiceDate;
        public List<Loop_2220E_277> Loop2220E;
    }
    public class Loop_2220D_277
    {
        public SVC_ServiceLineInformation_2 SVC_ServiceLineInformation;
        public STC_ServiceLineStatusInformation STC_ServiceLineStatusInformation;
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification;
        public DTP_ServiceLineDate DTP_ServiceLineDate;
    }
    public class Loop_2220E_277
    {
        public SVC_ServiceLineInformation_2 SVC_ServiceLineInformation;
        public STC_ServiceLineStatusInformation STC_ServiceLineStatusInformation;
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification;
        public DTP_ServiceLineDate DTP_ServiceLineDate;
    }
    public class TS277 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_4 BHT_BeginningOfHierarchicalTransaction;
        public List<Loop_2000A_277> Loop2000A;
        public SE SE;
    }
}
