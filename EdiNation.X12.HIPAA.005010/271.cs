namespace EdiNation.X12.HIPAA005010
{
    using System.Collections.Generic;
    public class Loop_2000A_271
    {
        public HL_InformationSourceLevel HL_InformationSourceLevel;
        public List<AAA_RequestValidation_2> AAA_RequestValidation;
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
        public List<PER_InformationSourceContactInformation> PER_InformationSourceContactInformation;
        public List<AAA_RequestValidation> AAA_RequestValidation;
    }
    public class Loop_2100B_271
    {
        public NM1_InformationReceiverName_2 NM1_InformationReceiverName;
        public List<REF_InformationReceiverAdditionalIdentification> REF_InformationReceiverAdditionalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_InformationReceiverAddress;
        public N4_AdditionalPatientInformationContactCity N4_InformationReceiverCity_State_ZIPCode;
        public List<AAA_InformationReceiverRequestValidation> AAA_InformationReceiverRequestValidation;
        public PRV_DependentBenefitRelatedProviderInformation PRV_InformationReceiverProviderInformation;
    }
    public class Loop_2100C_271
    {
        public NM1_SubscriberName NM1_SubscriberName;
        public List<REF_SubscriberAdditionalIdentification_3> REF_SubscriberAdditionalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress;
        public N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode;
        public List<AAA_SubscriberRequestValidation> AAA_SubscriberRequestValidation;
        public PRV_ProviderInformation_2 PRV_ProviderInformation;
        public DMG_DependentDemographicInformation_2 DMG_SubscriberDemographicInformation;
        public INS_SubscriberRelationship INS_SubscriberRelationship;
        public HI_DependentHealthCareDiagnosisCode HI_SubscriberHealthCareDiagnosisCode;
        public List<DTP_EligibilityOrBenefitDate> DTP_SubscriberDate;
        public MPI_DependentMilitaryPersonnelInformation MPI_SubscriberMilitaryPersonnelInformation;
        public List<Loop_2110C_271> Loop2110C;
    }
    public class Loop_2100D_271
    {
        public NM1_DependentName NM1_DependentName;
        public List<REF_DependentAdditionalIdentification_3> REF_DependentAdditionalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_DependentAddress;
        public N4_AdditionalPatientInformationContactCity N4_DependentCity_State_ZIPCode;
        public List<AAA_DependentRequestValidation_2> AAA_DependentRequestValidation;
        public PRV_ProviderInformation_2 PRV_ProviderInformation;
        public DMG_DependentDemographicInformation_2 DMG_DependentDemographicInformation;
        public INS_DependentRelationship_2 INS_DependentRelationship;
        public HI_DependentHealthCareDiagnosisCode HI_DependentHealthCareDiagnosisCode;
        public List<DTP_EligibilityOrBenefitDate> DTP_DependentDate;
        public MPI_DependentMilitaryPersonnelInformation MPI_DependentMilitaryPersonnelInformation;
        public List<Loop_2110D_271> Loop2110D;
    }
    public class Loop_2110C_271
    {
        public EB_SubscriberEligibilityorBenefitInformation EB_SubscriberEligibilityorBenefitInformation;
        public List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery;
        public List<REF_SubscriberAdditionalIdentification> REF_SubscriberAdditionalIdentification;
        public List<DTP_DependentEligibility_2> DTP_SubscriberEligibility_BenefitDate;
        public List<AAA_DependentRequestValidation> AAA_SubscriberRequestValidation;
        public List<MSG_MessageText> MSG_MessageText;
        public List<Loop_2115C_271> Loop2115C;
        public Loop_LS_271_2 LoopLS;
    }
    public class Loop_2110D_271
    {
        public EB_DependentEligibilityorBenefitInformation EB_DependentEligibilityorBenefitInformation;
        public List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery;
        public List<REF_DependentAdditionalIdentification> REF_DependentAdditionalIdentification;
        public List<DTP_DependentEligibility_2> DTP_DependentEligibility_BenefitDate;
        public List<AAA_DependentRequestValidation> AAA_DependentRequestValidation;
        public List<MSG_MessageText> MSG_MessageText;
        public List<Loop_2115D_271> Loop2115D;
        public Loop_LS_271 LoopLS;
    }
    public class Loop_2115C_271
    {
        public III_DependentEligibilityorBenefitAdditionalInformation III_SubscriberEligibilityorBenefitAdditionalInformation;
    }
    public class Loop_2115D_271
    {
        public III_DependentEligibilityorBenefitAdditionalInformation III_DependentEligibilityorBenefitAdditionalInformation;
    }
    public class Loop_2120C_271
    {
        public NM1_DependentBenefitRelatedEntityName NM1_SubscriberBenefitRelatedEntityName;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberBenefitRelatedEntityAddress;
        public N4_DependentBenefitRelatedEntityCity N4_SubscriberBenefitRelatedEntityCity_State_ZIPCode;
        public List<PER_DependentBenefitRelatedEntityContactInformation> PER_SubscriberBenefitRelatedEntityContactInformation;
        public PRV_DependentBenefitRelatedProviderInformation PRV_SubscriberBenefitRelatedProviderInformation;
    }
    public class Loop_2120D_271
    {
        public NM1_DependentBenefitRelatedEntityName NM1_DependentBenefitRelatedEntityName;
        public N3_AdditionalPatientInformationContactAddress N3_DependentBenefitRelatedEntityAddress;
        public N4_DependentBenefitRelatedEntityCity N4_DependentBenefitRelatedEntityCity_State_ZIPCode;
        public List<PER_DependentBenefitRelatedEntityContactInformation> PER_DependentBenefitRelatedEntityContactInformation;
        public PRV_DependentBenefitRelatedProviderInformation PRV_DependentBenefitRelatedProviderInformation;
    }
    public class Loop_LS_271
    {
        public LS_AdditionalReportingCategories LS_Header;
        public List<Loop_2120D_271> Loop2120D;
        public LE_AdditionalReportingCategoriesTermination LE_Trailer;
    }
    public class Loop_LS_271_2
    {
        public LS_AdditionalReportingCategories LS_Header;
        public List<Loop_2120C_271> Loop2120C;
        public LE_AdditionalReportingCategoriesTermination LE_Trailer;
    }
    public class TS271 
    {
        public ST ST;
        public BHT_BeginningOfHierarchicalTransaction_2 BHT_BeginningOfHierarchicalTransaction;
        public List<Loop_2000A_271> Loop2000A;
        public SE SE;
    }
}
