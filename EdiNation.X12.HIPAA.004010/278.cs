namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_2010C_278
    {
        public Loop_2010CA_278_2 Loop2010CA;
        public Loop_2010CB_278 Loop2010CB;
    }
    public class All_2010D_278
    {
        public Loop_2010DA_278_2 Loop2010DA;
        public Loop_2010DB_278 Loop2010DB;
    }
    public class All_DTP_278
    {
        public DTP_AccidentDate DTP_AccidentDate;
        public DTP_DateLastMenstrualPeriod DTP_LastMenstrualPeriodDate;
        public DTP_EstimatedDateOfBirth DTP_EstimatedDateOfBirth;
        public DTP_DateOnsetOfCurrentIllnessSymptom DTP_OnsetOfCurrentSymptomsOrIllnessDate;
    }
    public class All_DTP_278_2
    {
        public DTP_DateService DTP_ServiceDate;
        public DTP_AdmissionDate DTP_AdmissionDate;
        public DTP_DateDischarge DTP_DischargeDate;
        public DTP_SurgeryDate DTP_SurgeryDate;
        public DTP_CertificationIssueDate DTP_CertificationIssueDate;
        public DTP_CertificationExpirationDate DTP_CertificationExpirationDate;
        public DTP_CertificationEffectiveDate DTP_CertificationEffectiveDate;
    }
    public class All_DTP_278_3
    {
        public DTP_DateService DTP_ServiceDate;
        public DTP_AdmissionDate DTP_AdmissionDate;
        public DTP_DateDischarge DTP_DischargeDate;
        public DTP_SurgeryDate DTP_SurgeryDate;
    }
    public class Loop_2000A_278
    {
        public HL_BillingPaytoProviderHierarchicalLevel HL_UtilizationManagementOrganizationUMOLevel;
        public Loop_2010A_278 Loop2010A;
        public Loop_2000B_278 Loop2000B;
    }
    public class Loop_2000A_278_2
    {
        public HL_BillingPaytoProviderHierarchicalLevel HL_UtilizationManagementOrganizationUMOLevel;
        public List<AAA_RequestValidation_3> AAA_RequestValidation;
        public Loop_2010A_278_2 Loop2010A;
        public Loop_2000B_278_2 Loop2000B;
    }
    public class Loop_2000B_278
    {
        public HL_InformationReceiverLevel HL_RequesterLevel;
        public Loop_2010B_278 Loop2010B;
        public Loop_2000C_278 Loop2000C;
    }
    public class Loop_2000B_278_2
    {
        public HL_InformationReceiverLevel HL_RequesterLevel;
        public Loop_2010B_278_2 Loop2010B;
        public Loop_2000C_278_2 Loop2000C;
    }
    public class Loop_2000C_278
    {
        public HL_SubscriberLevel HL_SubscriberLevel;
        public List<TRN_DependentTraceNumber> TRN_PatientEventTrackingNumber;
        public All_DTP_278 AllDTP;
        public HI_DependentDiagnosis HI_SubscriberDiagnosis;
        public List<PWK_AdditionalPatientInformation> PWK_AdditionalPatientInformation;
        public Loop_2010CA_278 Loop2010CA;
        public Loop_2000D_278 Loop2000D;
        public List<Loop_2000E_278> Loop2000E;
    }
    public class Loop_2000C_278_2
    {
        public HL_SubscriberLevel HL_SubscriberLevel;
        public List<TRN_DependentTraceNumber_2> TRN_PatientEventTrackingNumber;
        public List<AAA_DependentRequestValidation_3> AAA_SubscriberRequestValidation;
        public All_DTP_278 AllDTP;
        public HI_DependentDiagnosis_2 HI_SubscriberDiagnosis;
        public List<PWK_AdditionalPatientInformation_2> PWK_AdditionalPatientInformation;
        public All_2010C_278 All2010C;
        public Loop_2000D_278_2 Loop2000D;
        public List<Loop_2000E_278_3> Loop2000E;
    }
    public class Loop_2000D_278
    {
        public HL_DependentLevel_3 HL_DependentLevel;
        public List<TRN_DependentTraceNumber> TRN_PatientEventTrackingNumber;
        public All_DTP_278 AllDTP;
        public HI_DependentDiagnosis HI_DependentDiagnosis;
        public List<PWK_AdditionalPatientInformation> PWK_AdditionalPatientInformation;
        public Loop_2010DA_278 Loop2010DA;
        public List<Loop_2000E_278> Loop2000E;
    }
    public class Loop_2000D_278_2
    {
        public HL_DependentLevel_3 HL_DependentLevel;
        public List<TRN_DependentTraceNumber_2> TRN_PatientEventTrackingNumber;
        public List<AAA_DependentRequestValidation_3> AAA_DependentRequestValidation;
        public All_DTP_278 AllDTP;
        public HI_DependentDiagnosis_2 HI_DependentDiagnosis;
        public List<PWK_AdditionalPatientInformation_2> PWK_AdditionalPatientInformation;
        public All_2010D_278 All2010D;
        public List<Loop_2000E_278_2> Loop2000E;
    }
    public class Loop_2000E_278
    {
        public HL_ServiceProviderLevel HL_ServiceProviderLevel;
        public MSG_MessageText MSG_MessageText;
        public List<Loop_2010E_278> Loop2010E;
        public List<Loop_2000F_278> Loop2000F;
    }
    public class Loop_2000E_278_2
    {
        public HL_ServiceProviderLevel HL_ServiceProviderLevel;
        public MSG_MessageText MSG_MessageText;
        public List<Loop_2010E_278_2> Loop2010E;
        public List<Loop_2000F_278_2> Loop2000F;
    }
    public class Loop_2000E_278_3
    {
        public HL_ServiceProviderLevel HL_ServiceProviderLevel;
        public MSG_MessageText MSG_MessageText;
        public List<Loop_2010E_278_2> Loop2010E;
        public List<Loop_2000F_278_2> Loop2000F;
    }
    public class Loop_2000F_278
    {
        public HL_ServiceLevel HL_ServiceLevel;
        public List<TRN_DependentTraceNumber> TRN_ServiceTraceNumber;
        public UM_HealthCareServicesReviewInformation UM_HealthCareServicesReviewInformation;
        public REF_CreditDebitCardInformation_2 REF_PreviousCertificationIdentification;
        public All_DTP_278_3 AllDTP;
        public HI_Procedures HI_Procedures;
        public HSD_HealthCareServicesDelivery_2 HSD_HealthCareServicesDelivery;
        public List<CRC_PatientConditionInformation> CRC_PatientConditionInformation;
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode;
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation;
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation;
        public CR5_HomeOxygenTherapyInformation CR5_HomeOxygenTherapyInformation;
        public CR6_HomeHealthCareInformation CR6_HomeHealthCareInformation;
        public List<PWK_AdditionalPatientInformation> PWK_AdditionalServiceInformation;
        public MSG_MessageText MSG_MessageText;
    }
    public class Loop_2000F_278_2
    {
        public HL_ServiceLevel HL_ServiceLevel;
        public List<TRN_DependentTraceNumber_2> TRN_ServiceTraceNumber;
        public List<AAA_ServiceRequestValidation> AAA_ServiceRequestValidation;
        public UM_HealthCareServicesReviewInformation_2 UM_HealthCareServicesReviewInformation;
        public HCR_HealthCareServicesReview HCR_HealthCareServicesReview;
        public REF_CreditDebitCardInformation_2 REF_PreviousCertificationIdentification;
        public All_DTP_278_2 AllDTP;
        public HI_Procedures_2 HI_Procedures;
        public HSD_HealthCareServicesDelivery_3 HSD_HealthCareServicesDelivery;
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode;
        public CR1_AmbulanceTransportInformation_2 CR1_AmbulanceTransportInformation;
        public CR2_SpinalManipulationServiceInformation_2 CR2_SpinalManipulationServiceInformation;
        public CR5_HomeOxygenTherapyInformation_2 CR5_HomeOxygenTherapyInformation;
        public CR6_HomeHealthCareInformation_2 CR6_HomeHealthCareInformation;
        public List<PWK_AdditionalPatientInformation_2> PWK_AdditionalServiceInformation;
        public MSG_MessageText MSG_MessageText;
        public Loop_2010F_278 Loop2010F;
    }
    public class Loop_2010A_278
    {
        public NM1_UtilizationManagementOrganizationUMOName NM1_UtilizationManagementOrganizationUMOName;
    }
    public class Loop_2010A_278_2
    {
        public NM1_UtilizationManagementOrganizationUMOName NM1_UtilizationManagementOrganizationUMOName;
        public PER_AdditionalPatientInformationContactInformation PER_UtilizationManagementOrganizationUMOContactInformation;
        public List<AAA_UtilizationManagementOrganizationUMORequestValidation> AAA_UtilizationManagementOrganizationUMORequestValidation;
    }
    public class Loop_2010B_278
    {
        public NM1_RequesterName NM1_RequesterName;
        public List<REF_RequesterSupplementalIdentification> REF_RequesterSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_RequesterAddress;
        public N4_DependentCityStateZIPCode N4_RequesterCityStateZIPCode;
        public PER_AdditionalPatientInformationContactInformation PER_RequesterContactInformation;
        public PRV_RequesterProviderInformation PRV_RequesterProviderInformation;
    }
    public class Loop_2010B_278_2
    {
        public NM1_RequesterName NM1_RequesterName;
        public List<REF_RequesterSupplementalIdentification> REF_RequesterSupplementalIdentification;
        public List<AAA_RequesterRequestValidation> AAA_RequesterRequestValidation;
        public PRV_RequesterProviderInformation PRV_RequesterProviderInformation;
    }
    public class Loop_2010CA_278
    {
        public NM1_SubscriberName_3 NM1_SubscriberName_2010CA;
        public List<REF_SubscriberSupplementalIdentification> REF_SubscriberSupplementalIdentification_2010CA;
        public DMG_DependentDemographicInformation_4 DMG_SubscriberDemographicInformation_2010CA;
    }
    public class Loop_2010CA_278_2
    {
        public NM1_SubscriberName_3 NM1_SubscriberName_2010CA;
        public List<REF_SubscriberSupplementalIdentification> REF_SubscriberSupplementalIdentification_2010CA;
        public List<AAA_SubscriberRequestValidation_2> AAA_SubscriberRequestValidation_2010CA;
        public DMG_DependentDemographicInformation_4 DMG_SubscriberDemographicInformation_2010CA;
    }
    public class Loop_2010CB_278
    {
        public NM1_AdditionalPatientInformationContactName NM1_AdditionalPatientInformationContactName_2010CB;
        public N3_AdditionalPatientInformationContactAddress N3_AdditionalPatientInformationContactAddress_2010CB;
        public N4_AdditionalPatientInformationContactCityStateZipCode N4_AdditionalPatientInformationContactCityStateZipCode_2010CB;
        public PER_AdditionalPatientInformationContactInformation PER_AdditionalPatientInformationContactInformation_2010CB;
    }
    public class Loop_2010DA_278
    {
        public NM1_DependentName_4 NM1_DependentName_2010DA;
        public List<REF_DependentSupplementalIdentification> REF_DependentSupplementalIdentification_2010DA;
        public DMG_DependentDemographicInformation_4 DMG_DependentDemographicInformation_2010DA;
        public INS_DependentRelationship_3 INS_DependentRelationship_2010DA;
    }
    public class Loop_2010DA_278_2
    {
        public NM1_DependentName_5 NM1_DependentName_2010DA;
        public List<REF_DependentSupplementalIdentification> REF_DependentSupplementalIdentification_2010DA;
        public List<AAA_DependentRequestValidation_4> AAA_DependentRequestValidation_2010DA;
        public DMG_DependentDemographicInformation_4 DMG_DependentDemographicInformation_2010DA;
        public INS_DependentRelationship_4 INS_DependentRelationship_2010DA;
    }
    public class Loop_2010DB_278
    {
        public NM1_AdditionalPatientInformationContactName NM1_AdditionalPatientInformationContactName_2010DB;
        public N3_AdditionalPatientInformationContactAddress N3_AdditionalPatientInformationContactAddress_2010DB;
        public N4_AdditionalPatientInformationContactCityStateZipCode N4_AdditionalPatientInformationContactCityStateZipCode_2010DB;
        public PER_AdditionalPatientInformationContactInformation PER_AdditionalPatientInformationContactInformation_2010DB;
    }
    public class Loop_2010E_278
    {
        public NM1_ServiceProviderName NM1_ServiceProviderName;
        public List<REF_ServiceProviderSupplementalIdentification> REF_ServiceProviderSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress;
        public N4_DependentCityStateZIPCode N4_ServiceProviderCityStateZIPCode;
        public PER_AdditionalPatientInformationContactInformation PER_ServiceProviderContactInformation;
        public PRV_ServiceProviderInformation PRV_ServiceProviderInformation;
    }
    public class Loop_2010E_278_2
    {
        public NM1_ServiceProviderName NM1_ServiceProviderName;
        public List<REF_ServiceProviderSupplementalIdentification> REF_ServiceProviderSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress;
        public N4_DependentCityStateZIPCode N4_ServiceProviderCityStateZIPCode;
        public PER_AdditionalPatientInformationContactInformation PER_ServiceProviderContactInformation;
        public List<AAA_ServiceProviderRequestValidation> AAA_ServiceProviderRequestValidation;
        public PRV_ServiceProviderInformation PRV_ServiceProviderInformation;
    }
    public class Loop_2010F_278
    {
        public NM1_AdditionalPatientInformationContactName NM1_AdditionalServiceInformationContactName;
        public N3_AdditionalPatientInformationContactAddress N3_AdditionalServiceInformationContactAddress;
        public N4_AdditionalPatientInformationContactCityStateZipCode N4_AdditionalServiceInformationContactCityStateZipCode;
        public PER_AdditionalPatientInformationContactInformation PER_AdditionalServiceInformationContactInformation;
    }
    public class Loop_BHT_278
    {
        public BHT_BeginningOfHierarchicalTransaction_5 BHT_BeginningOfHierarchicalTransaction;
        public Loop_2000A_278 Loop2000A;
    }
    public class Loop_BHT_278_2
    {
        public BHT_BeginningOfHierarchicalTransaction_6 BHT_BeginningOfHierarchicalTransaction;
        public Loop_2000A_278_2 Loop2000A;
    }
    public class TS278 
    {
        public ST ST;
        public Loop_BHT_278 LoopBHT;
        public Loop_BHT_278_2 LoopBHT2;
        public SE SE;
    }
}
