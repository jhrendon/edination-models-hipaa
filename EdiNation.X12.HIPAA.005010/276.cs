namespace EdiNation.X12.HIPAA005010
{
    using System.Collections.Generic;
    public class All_REF_276
    {
        public REF_PayerClaimControlNumber REF_PayerClaimControlNumber;
        public REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification;
        public REF_ApplicationorLocationSystemIdentifier REF_ApplicationorLocationSystemIdentifier;
        public REF_GroupNumber REF_GroupNumber;
        public REF_PatientControlNumber REF_PatientControlNumber;
        public REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber;
        public REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries;
    }
    public class Loop_2000A_276
    {
        public HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel;
        public Loop_2100A_276 Loop2100A;
        public List<Loop_2000B_276> Loop2000B;
    }
    public class Loop_2000B_276
    {
        public HL_InformationReceiverLevel HL_InformationReceiverLevel;
        public Loop_2100B_276 Loop2100B;
        public List<Loop_2000C_276> Loop2000C;
    }
    public class Loop_2000C_276
    {
        public HL_ServiceProviderLevel HL_ServiceProviderLevel;
        public List<Loop_2100C_276> Loop2100C;
        public List<Loop_2000D_276> Loop2000D;
    }
    public class Loop_2000D_276
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel;
        public DMG_DependentDemographicInformation_3 DMG_SubscriberDemographicInformation;
        public Loop_2100D_276 Loop2100D;
        public List<Loop_2200D_276> Loop2200D;
        public List<Loop_2000E_276> Loop2000E;
    }
    public class Loop_2000E_276
    {
        public HL_DependentLevel_2 HL_DependentLevel;
        public DMG_DependentDemographicInformation_3 DMG_DependentDemographicInformation;
        public Loop_2100E_276 Loop2100E;
        public List<Loop_2200E_276> Loop2200E;
    }
    public class Loop_2100A_276
    {
        public NM1_OtherPayerName NM1_PayerName;
    }
    public class Loop_2100B_276
    {
        public NM1_InformationReceiverName_3 NM1_InformationReceiverName;
    }
    public class Loop_2100C_276
    {
        public NM1_ProviderName NM1_ProviderName;
    }
    public class Loop_2100D_276
    {
        public NM1_SubscriberName_2 NM1_SubscriberName;
    }
    public class Loop_2100E_276
    {
        public NM1_DependentName_2 NM1_DependentName;
    }
    public class Loop_2200D_276
    {
        public TRN_ClaimStatusTrackingNumber TRN_ClaimStatusTrackingNumber;
        public All_REF_276 AllREF;
        public AMT_ClaimSubmittedCharges AMT_ClaimSubmittedCharges;
        public DTP_ClaimLevelServiceDate DTP_ClaimServiceDate;
        public List<Loop_2210D_276> Loop2210D;
    }
    public class Loop_2200E_276
    {
        public TRN_ClaimStatusTrackingNumber TRN_ClaimStatusTrackingNumber;
        public All_REF_276 AllREF;
        public AMT_ClaimSubmittedCharges AMT_ClaimSubmittedCharges;
        public DTP_ClaimLevelServiceDate DTP_ClaimServiceDate;
        public List<Loop_2210E_276> Loop2210E;
    }
    public class Loop_2210D_276
    {
        public SVC_ServiceLineInformation SVC_ServiceLineInformation;
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification;
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate;
    }
    public class Loop_2210E_276
    {
        public SVC_ServiceLineInformation SVC_ServiceLineInformation;
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification;
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate;
    }
    public class TS276 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_3 BHT_BeginningOfHierarchicalTransaction;
        public List<Loop_2000A_276> Loop2000A;
        public SE SE;
    }
}
