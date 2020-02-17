namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class Loop_2000A_271
    {
        public HL_InformationSourceLevel HL_InformationSourceLevel;
        public List<AAA_RequestValidation> AAA_RequestValidation;
        public Loop_2100A_271 Loop2100A;
        public List<Loop_2000B_271> Loop2000B;
    }
    public class Loop_2000B_271
    {
        public HL_InformationReceiverLevel_2 HL_InformationReceiverLevel;
        public Loop_2100B_271 Loop2100B;
        public List<Loop_2000C_271> Loop2000C;
    }
    public class Loop_2000C_271
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel;
        public List<TRN_DependentTraceNumber_2> TRN_SubscriberTraceNumber;
        public Loop_2100C_271 Loop2100C;
        public List<Loop_2000D_271> Loop2000D;
    }
    public class Loop_2000D_271
    {
        public HL_DependentLevel HL_DependentLevel;
        public List<TRN_DependentTraceNumber_2> TRN_DependentTraceNumber;
        public Loop_2100D_271 Loop2100D;
    }
    public class Loop_2100A_271
    {
        public NM1_InformationSourceName NM1_InformationSourceName;
        public List<REF_InformationSourceAdditionalIdentification> REF_InformationSourceAdditionalIdentification;
        public List<PER_InformationReceiverContactInformation> PER_InformationSourceContactInformation;
        public List<AAA_RequestValidation_2> AAA_RequestValidation;
    }
    public class Loop_2100B_271
    {
        public NM1_InformationReceiverName NM1_InformationReceiverName;
        public List<REF_InformationReceiverAdditionalIdentification> REF_InformationReceiverAdditionalIdentification;
        public List<AAA_InformationReceiverRequestValidation> AAA_InformationReceiverRequestValidation;
    }
    public class Loop_2100C_271
    {
        public NM1_SubscriberName NM1_SubscriberName;
        public List<REF_SubscriberAdditionalIdentification_2> REF_SubscriberAdditionalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress;
        public N4_SubscriberCityStateZIPCode N4_SubscriberCityStateZIPCode;
        public List<PER_DependentContactInformation> PER_SubscriberContactInformation;
        public List<AAA_SubscriberRequestValidation> AAA_SubscriberRequestValidation;
        public DMG_DependentDemographicInformation_2 DMG_SubscriberDemographicInformation;
        public INS_SubscriberRelationship_2 INS_SubscriberRelationship;
        public List<DTP_SubscriberDate> DTP_SubscriberDate;
        public List<Loop_2110C_271> Loop2110C;
    }
    public class Loop_2100D_271
    {
        public NM1_DependentName_2 NM1_DependentName;
        public List<REF_DependentAdditionalIdentification_2> REF_DependentAdditionalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_DependentAddress;
        public N4_DependentCityStateZIPCode N4_DependentCityStateZIPCode;
        public List<PER_DependentContactInformation> PER_DependentContactInformation;
        public List<AAA_DependentRequestValidation> AAA_DependentRequestValidation;
        public DMG_DependentDemographicInformation_2 DMG_DependentDemographicInformation;
        public INS_DependentRelationship_2 INS_DependentRelationship;
        public List<DTP_DependentDate_2> DTP_DependentDate;
        public List<Loop_2110D_271> Loop2110D;
    }
    public class Loop_2110C_271
    {
        public EB_SubscriberEligibilityOrBenefitInformation EB_SubscriberEligibilityOrBenefitInformation;
        public List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery;
        public List<REF_DependentAdditionalIdentification_3> REF_SubscriberAdditionalIdentification;
        public List<DTP_SubscriberEligibilityBenefitDate> DTP_SubscriberEligibilityBenefitDate;
        public List<AAA_DependentRequestValidation_2> AAA_SubscriberRequestValidation;
        public List<MSG_MessageText> MSG_MessageText;
        public List<Loop_2115C_271> Loop2115C;
        public Loop_LS_271 LoopLS;
    }
    public class Loop_2110D_271
    {
        public EB_DependentEligibilityOrBenefitInformation EB_DependentEligibilityOrBenefitInformation;
        public List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery;
        public List<REF_DependentAdditionalIdentification_3> REF_DependentAdditionalIdentification;
        public List<DTP_DependentEligibilityBenefitDate_2> DTP_DependentEligibilityBenefitDate;
        public List<AAA_DependentRequestValidation_2> AAA_DependentRequestValidation;
        public List<MSG_MessageText> MSG_MessageText;
        public List<Loop_2115D_271> Loop2115D;
        public Loop_LS_271_2 LoopLS;
    }
    public class Loop_2115C_271
    {
        public III_DependentEligibilityOrBenefitAdditionalInformation III_SubscriberEligibilityOrBenefitAdditionalInformation;
    }
    public class Loop_2115D_271
    {
        public III_DependentEligibilityOrBenefitAdditionalInformation III_DependentEligibilityOrBenefitAdditionalInformation;
    }
    public class Loop_2120C_271
    {
        public NM1_DependentBenefitRelatedEntityName NM1_SubscriberBenefitRelatedEntityName;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberBenefitRelatedEntityAddress;
        public N4_DependentBenefitRelatedEntityCityStateZIPCode N4_SubscriberBenefitRelatedCityStateZIPCode;
        public List<PER_DependentBenefitRelatedEntityContactInformation> PER_SubscriberBenefitRelatedEntityContactInformation;
        public PRV_SubscriberBenefitRelatedProviderInformation PRV_SubscriberBenefitRelatedProviderInformation;
    }
    public class Loop_2120D_271
    {
        public NM1_DependentBenefitRelatedEntityName NM1_DependentBenefitRelatedEntityName;
        public N3_AdditionalPatientInformationContactAddress N3_DependentBenefitRelatedEntityAddress;
        public N4_DependentBenefitRelatedEntityCityStateZIPCode N4_DependentBenefitRelatedEntityCityStateZIPCode;
        public List<PER_DependentBenefitRelatedEntityContactInformation> PER_DependentBenefitRelatedEntityContactInformation;
        public PRV_DependentBenefitRelatedProviderInformation PRV_DependentBenefitRelatedProviderInformation;
    }
    public class Loop_LS_271
    {
        public LS_DependentEligibilityOrBenefitInformation LS_Header;
        public Loop_2120C_271 Loop2120C;
        public LE_Trailer LE_Trailer;
    }
    public class Loop_LS_271_2
    {
        public LS_DependentEligibilityOrBenefitInformation LS_DependentEligibilityOrBenefitInformation;
        public Loop_2120D_271 Loop2120D;
        public LE_Trailer LE_Trailer;
    }
    public class TS271 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_2 BHT_BeginningOfHierarchicalTransaction;
        public List<Loop_2000A_271> Loop2000A;
        public SE SE;
    }
}
