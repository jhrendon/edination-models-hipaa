namespace EdiNation.X12.HIPAA005010
{
    using System.Collections.Generic;
    public class Loop_2000A_277A
    {
        public HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel;
        public Loop_2100A_277A Loop2100A;
        public Loop_2200A_277A Loop2200A;
        public Loop_2000B_277A Loop2000B;
    }
    public class Loop_2000B_277A
    {
        public HL_InformationReceiverLevel_2 HL_InformationReceiverLevel;
        public Loop_2100B_277A Loop2100B;
        public Loop_2200B_277A Loop2200B;
        public List<Loop_2000C_277A> Loop2000C;
    }
    public class Loop_2000C_277A
    {
        public HL_BillingProviderOfServiceLevel HL_BillingProviderOfServiceLevel;
        public Loop_2100C_277A Loop2100C;
        public Loop_2200C_277A Loop2200C;
        public List<Loop_2000D_277A> Loop2000D;
    }
    public class Loop_2000D_277A
    {
        public HL_PatientLevel HL_PatientLevel;
        public Loop_2100D_277A Loop2100D;
        public List<Loop_2200D_277A> Loop2200D;
    }
    public class Loop_2100A_277A
    {
        public NM1_InformationSourceName_2 NM1_InformationSourceName;
    }
    public class Loop_2100B_277A
    {
        public NM1_InformationReceiverName_4 NM1_InformationReceiverName;
    }
    public class Loop_2100C_277A
    {
        public NM1_BillingProviderName NM1_BillingProviderName;
    }
    public class Loop_2100D_277A
    {
        public NM1_PatientName NM1_PatientName;
    }
    public class Loop_2200A_277A
    {
        public TRN_ClaimStatusTrackingNumber TRN_TransmissionReceiptControlIdentifier;
        public DTP_RepricerReceivedDate DTP_InformationSourceReceiptDate;
        public DTP_InformationSourceProcessDate DTP_InformationSourceProcessDate;
    }
    public class Loop_2200B_277A
    {
        public TRN_ClaimStatusTrackingNumber_2 TRN_InformationReceiverApplicationTraceIdentifier;
        public List<STC_ClaimLevelStatusInformation_2> STC_InformationReceiverStatusInformation;
        public QTY_TotalAcceptedQuantity_2 QTY_TotalAcceptedQuantity;
        public QTY_TotalRejectedQuantity_2 QTY_TotalRejectedQuantity;
        public AMT_TotalAcceptedAmount AMT_TotalAcceptedAmount;
        public AMT_TotalRejectedAmount AMT_TotalRejectedAmount;
    }
    public class Loop_2200C_277A
    {
        public TRN_ClaimStatusTrackingNumber TRN_ProviderOfServiceInformationTraceIdentifier;
        public List<STC_BillingProviderStatusInformation> STC_BillingProviderStatusInformation;
        public List<REF_ProviderSecondaryIdentifier> REF_ProviderSecondaryIdentifier;
        public QTY_TotalAcceptedQuantity QTY_TotalAcceptedQuantity;
        public QTY_TotalRejectedQuantity QTY_TotalRejectedQuantity;
        public AMT_TotalAcceptedAmount AMT_TotalAcceptedAmount;
        public AMT_TotalRejectedAmount AMT_TotalRejectedAmount;
    }
    public class Loop_2200D_277A
    {
        public TRN_ClaimStatusTrackingNumber_2 TRN_ClaimStatusTrackingNumber;
        public List<STC_ClaimLevelStatusInformation_2> STC_ClaimLevelStatusInformation;
        public REF_PayerClaimControlNumber REF_PayerClaimControlNumber;
        public REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries;
        public REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification;
        public DTP_ClaimLevelServiceDate DTP_ClaimLevelServiceDate;
        public List<Loop_2220D_277A> Loop2220D;
    }
    public class Loop_2220D_277A
    {
        public SVC_ServiceLineInformation_3 SVC_ServiceLineInformation;
        public List<STC_ServiceLineLevelStatusInformation> STC_ServiceLineLevelStatusInformation;
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification;
        public REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber;
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate;
    }
    public class TS277A
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_5 BHT_BeginningOfHierarchicalTransaction;
        public Loop_2000A_277A Loop2000A;
        public SE SE;
    }
}
