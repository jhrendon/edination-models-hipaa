namespace EdiNation.X12.HIPAA005010.Base
{
    using System.Collections.Generic;
    public class All_AMT_270
    {
        public AMT_SubscriberSpendDownAmount AMT_SubscriberSpendDownAmount;
        public AMT_SubscriberSpendDownTotalBilledAmount AMT_SubscriberSpendDownTotalBilledAmount;
    }
    public class Loop_2000A_270
    {
        public HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel;
        public Loop_2100A_270 Loop2100A;
        public List<Loop_2000B_270> Loop2000B;
    }
    public class Loop_2000B_270
    {
        public HL_InformationReceiverLevel HL_InformationReceiverLevel;
        public Loop_2100B_270 Loop2100B;
        public List<Loop_2000C_270> Loop2000C;
    }
    public class Loop_2000C_270
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel;
        public List<TRN_DependentTraceNumber> TRN_SubscriberTraceNumber;
        public Loop_2100C_270 Loop2100C;
        public List<Loop_2000D_270> Loop2000D;
    }
    public class Loop_2000D_270
    {
        public HL_DependentLevel HL_DependentLevel;
        public List<TRN_DependentTraceNumber> TRN_DependentTraceNumber;
        public Loop_2100D_270 Loop2100D;
    }
    public class Loop_2100A_270
    {
        public NM1_InformationSourceName NM1_InformationSourceName;
    }
    public class Loop_2100B_270
    {
        public NM1_InformationReceiverName NM1_InformationReceiverName;
        public List<REF_InformationReceiverAdditionalIdentification> REF_InformationReceiverAdditionalIdentification;
        public N3_AmbulanceDrop N3_InformationReceiverAddress;
        public N4_AmbulanceDrop N4_InformationReceiverCity_State_ZIPCode;
        public PRV_DependentBenefitRelatedProviderInformation PRV_InformationReceiverProviderInformation;
    }
    public class Loop_2100C_270
    {
        public NM1_SubscriberName NM1_SubscriberName;
        public List<REF_SubscriberAdditionalIdentification_2> REF_SubscriberAdditionalIdentification;
        public N3_AmbulanceDrop N3_SubscriberAddress;
        public N4_AmbulanceDrop N4_SubscriberCity_State_ZIPCode;
        public PRV_ProviderInformation PRV_ProviderInformation;
        public DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation;
        public INS_MultipleBirthSequenceNumber INS_MultipleBirthSequenceNumber;
        public HI_DependentHealthCareDiagnosisCode HI_SubscriberHealthCareDiagnosisCode;
        public List<DTP_DependentDate> DTP_SubscriberDate;
        public List<Loop_2110C_270> Loop2110C;
    }
    public class Loop_2100D_270
    {
        public NM1_DependentName NM1_DependentName;
        public List<REF_DependentAdditionalIdentification_2> REF_DependentAdditionalIdentification;
        public N3_AmbulanceDrop N3_DependentAddress;
        public N4_AmbulanceDrop N4_DependentCity_State_ZIPCode;
        public PRV_ProviderInformation PRV_ProviderInformation;
        public DMG_DependentDemographicInformation DMG_DependentDemographicInformation;
        public INS_DependentRelationship INS_DependentRelationship;
        public HI_DependentHealthCareDiagnosisCode HI_DependentHealthCareDiagnosisCode;
        public List<DTP_DependentDate> DTP_DependentDate;
        public List<Loop_2110D_270> Loop2110D;
    }
    public class Loop_2110C_270
    {
        public EQ_SubscriberEligibilityorBenefitInquiry EQ_SubscriberEligibilityorBenefitInquiry;
        public All_AMT_270 AllAMT;
        public III_DependentEligibilityorBenefitAdditionalInquiryInformation III_SubscriberEligibilityorBenefitAdditionalInquiryInformation;
        public REF_DependentAdditionalInformation REF_SubscriberAdditionalInformation;
        public DTP_DependentEligibility DTP_SubscriberEligibility_BenefitDate;
    }
    public class Loop_2110D_270
    {
        public EQ_DependentEligibilityorBenefitInquiry EQ_DependentEligibilityorBenefitInquiry;
        public III_DependentEligibilityorBenefitAdditionalInquiryInformation III_DependentEligibilityorBenefitAdditionalInquiryInformation;
        public REF_DependentAdditionalInformation REF_DependentAdditionalInformation;
        public DTP_DependentEligibility DTP_DependentEligibility_BenefitDate;
    }
    public class TS270 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction;
        public List<Loop_2000A_270> Loop2000A;
        public SE SE;
    }
}
