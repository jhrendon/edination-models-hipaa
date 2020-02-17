namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class Loop_2000A_270
    {
        public HL_BillingPaytoProviderHierarchicalLevel HL_InformationSourceLevel;
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
        public N3_AdditionalPatientInformationContactAddress N3_InformationReceiverAddress;
        public N4_BillingProviderCityStateZIPCode N4_InformationReceiverCityStateZIPCode;
        public List<PER_InformationReceiverContactInformation> PER_InformationReceiverContactInformation;
        public PRV_InformationReceiverProviderInformation PRV_InformationReceiverProviderInformation;
    }
    public class Loop_2100C_270
    {
        public NM1_SubscriberName NM1_SubscriberName;
        public List<REF_SubscriberAdditionalIdentification> REF_SubscriberAdditionalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress;
        public N4_DependentCityStateZIPCode N4_SubscriberCityStateZIPCode;
        public PRV_DependentBenefitRelatedProviderInformation PRV_ProviderInformation;
        public DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation;
        public INS_SubscriberRelationship INS_SubscriberRelationship;
        public List<DTP_DependentDate> DTP_SubscriberDate;
        public List<Loop_2110C_270> Loop2110C;
    }
    public class Loop_2100D_270
    {
        public NM1_DependentName NM1_DependentName;
        public List<REF_DependentAdditionalIdentification> REF_DependentAdditionalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_DependentAddress;
        public N4_DependentCityStateZIPCode N4_DependentCityStateZIPCode;
        public PRV_DependentBenefitRelatedProviderInformation PRV_ProviderInformation;
        public DMG_DependentDemographicInformation DMG_DependentDemographicInformation;
        public INS_DependentRelationship INS_DependentRelationship;
        public List<DTP_DependentDate> DTP_DependentDate;
        public List<Loop_2110D_270> Loop2110D;
    }
    public class Loop_2110C_270
    {
        public EQ_SubscriberEligibilityOrBenefitInquiryInformation EQ_SubscriberEligibilityOrBenefitInquiryInformation;
        public AMT_SubscriberSpendDownAmount AMT_SubscriberSpendDownAmount;
        public List<III_DependentEligibilityOrBenefitAdditionalInformation> III_SubscriberEligibilityOrBenefitAdditionalInquiryInformation;
        public REF_DependentAdditionalInformation REF_SubscriberAdditionalInformation;
        public DTP_DependentEligibilityBenefitDate DTP_SubscriberEligibilityBenefitDate;
    }
    public class Loop_2110D_270
    {
        public EQ_DependentEligibilityOrBenefitInquiryInformation EQ_DependentEligibilityOrBenefitInquiryInformation;
        public List<III_DependentEligibilityOrBenefitAdditionalInformation> III_DependentEligibilityOrBenefitAdditionalInquiryInformation;
        public REF_DependentAdditionalInformation REF_DependentAdditionalInformation;
        public DTP_DependentEligibilityBenefitDate DTP_DependentEligibilityBenefitDate;
    }
    public class TS270 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction;
        public List<Loop_2000A_270> Loop2000A;
        public SE SE;
    }
}
