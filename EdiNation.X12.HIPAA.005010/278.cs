namespace EdiNation.X12.HIPAA005010
{
    using System.Collections.Generic;
    public class All_CRC_278
    {
        public CRC_AmbulanceCertificationInformation CRC_AmbulanceCertificationInformation;
        public CRC_ChiropracticCertificationInformation CRC_ChiropracticCertificationInformation;
        public CRC_DurableMedicalEquipmentInformation CRC_DurableMedicalEquipmentInformation;
        public CRC_OxygenTherapyCertificationInformation CRC_OxygenTherapyCertificationInformation;
        public CRC_FunctionalLimitationsInformation CRC_FunctionalLimitationsInformation;
        public CRC_ActivitiesPermittedInformation CRC_ActivitiesPermittedInformation;
        public CRC_MentalStatusInformation CRC_MentalStatusInformation;
    }
    public class All_DTP_278
    {
        public DTP_ClaimLevelServiceDate DTP_ServiceDate;
        public DTP_CertificationIssueDate DTP_CertificationIssueDate;
        public DTP_CertificationExpirationDate DTP_CertificationExpirationDate;
        public DTP_CertificationEffectiveDate DTP_CertificationEffectiveDate;
    }
    public class All_DTP_278_2
    {
        public DTP_AccidentDate DTP_AccidentDate;
        public DTP_LastMenstrualPeriodDate DTP_LastMenstrualPeriodDate;
        public DTP_EstimatedDateofBirth DTP_EstimatedDateofBirth;
        public DTP_OnsetofCurrentSymptomsorIllnessDate DTP_OnsetofCurrentSymptomsorIllnessDate;
        public DTP_EventDate DTP_EventDate;
        public DTP_AdmissionDate_2 DTP_AdmissionDate;
        public DTP_DischargeDate DTP_DischargeDate;
    }
    public class All_DTP_278_3
    {
        public DTP_AccidentDate_2 DTP_AccidentDate;
        public DTP_LastMenstrualPeriod DTP_LastMenstrualPeriodDate;
        public DTP_EstimatedDateofBirth_2 DTP_EstimatedDateofBirth;
        public DTP_OnsetofCurrentIllnessorSymptom DTP_OnsetofCurrentSymptomsorIllnessDate;
        public DTP_EventDate_2 DTP_EventDate;
        public DTP_AdmissionDate_3 DTP_AdmissionDate;
        public DTP_Discharge DTP_DischargeDate;
        public DTP_CertificationIssueDate DTP_CertificationIssueDate;
        public DTP_CertificationExpirationDate DTP_CertificationExpirationDate;
        public DTP_CertificationEffectiveDate DTP_CertificationEffectiveDate;
    }
    public class All_NM1_278
    {
        public List<Loop_2010FA_278> Loop2010FA;
        public Loop_2010FB_278 Loop2010FB;
    }
    public class All_NM1_278_2
    {
        public List<Loop_2010EA_278> Loop2010EA;
        public List<Loop_2010EB_278> Loop2010EB;
        public List<Loop_2010EC_278> Loop2010EC;
    }
    public class All_NM1_278_3
    {
        public List<Loop_2010EA_278_2> Loop2010EA;
        public Loop_2010EB_278_2 Loop2010EB;
        public List<Loop_2010EC_278_2> Loop2010EC;
    }
    public class All_REF_278
    {
        public REF_PreviousReviewAuthorizationNumber REF_PreviousReviewAuthorizationNumber;
        public REF_PreviousReviewAdministrativeReferenceNumber REF_PreviousReviewAdministrativeReferenceNumber;
    }
    public class All_REF_278_2
    {
        public REF_AdministrativeReferenceNumber REF_AdministrativeReferenceNumber;
        public REF_PreviousReviewAuthorizationNumber_2 REF_PreviousReviewAuthorizationNumber;
    }
    public class Loop_2000A_278
    {
        public HL_UtilizationManagementOrganization HL_UtilizationManagementOrganization_UMO_Level;
        public Loop_2010A_278 Loop2010A;
        public Loop_2000B_278 Loop2000B;
    }
    public class Loop_2000A_278_2
    {
        public HL_InformationSourceLevel HL_UtilizationManagementOrganization_UMO_Level;
        public List<AAA_RequestValidation_3> AAA_RequestValidation;
        public Loop_2010A_278_2 Loop2010A;
        public Loop_2000B_278_2 Loop2000B;
    }
    public class Loop_2000B_278
    {
        public HL_RequesterLevel HL_RequesterLevel;
        public Loop_2010B_278 Loop2010B;
        public Loop_2000C_278 Loop2000C;
    }
    public class Loop_2000B_278_2
    {
        public HL_InformationReceiverLevel_2 HL_RequesterLevel;
        public List<Loop_2010B_278_2> Loop2010B;
        public Loop_2000C_278_2 Loop2000C;
    }
    public class Loop_2000C_278
    {
        public HL_SubscriberLevel HL_SubscriberLevel;
        public Loop_2010C_278 Loop2010C;
        public Loop_2000D_278 Loop2000D;
        public Loop_2000E_278 Loop2000E;
    }
    public class Loop_2000C_278_2
    {
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel;
        public Loop_2010C_278_2 Loop2010C;
        public List<Loop_2000E_278_2> Loop2000E;
        public Loop_2000D_278_2 Loop2000D;
    }
    public class Loop_2000D_278
    {
        public HL_DependentLevel_3 HL_DependentLevel;
        public Loop_2010D_278 Loop2010D;
        public Loop_2000E_278 Loop2000E;
    }
    public class Loop_2000D_278_2
    {
        public HL_DependentLevel_4 HL_DependentLevel;
        public Loop_2010D_278_2 Loop2010D;
        public List<Loop_2000E_278_2> Loop2000E;
    }
    public class Loop_2000E_278
    {
        public HL_PatientEventLevel HL_PatientEventLevel;
        public List<TRN_PatientEventTrackingNumber> TRN_PatientEventTrackingNumber;
        public UM_HealthCareServicesReviewInformation_3 UM_HealthCareServicesReviewInformation;
        public All_REF_278 AllREF;
        public All_DTP_278_2 AllDTP;
        public HI_PatientDiagnosis HI_PatientDiagnosis;
        public HSD_HealthCareServicesDelivery_2 HSD_HealthCareServicesDelivery;
        public All_CRC_278 AllCRC;
        public CL1_InstitutionalClaimCode_2 CL1_InstitutionalClaimCode;
        public CR1_AmbulanceTransportInformation_2 CR1_AmbulanceTransportInformation;
        public CR2_SpinalManipulationServiceInformation_2 CR2_SpinalManipulationServiceInformation;
        public CR5_HomeOxygenTherapyInformation CR5_HomeOxygenTherapyInformation;
        public CR6_HomeHealthCareInformation CR6_HomeHealthCareInformation;
        public List<PWK_AdditionalPatientInformation> PWK_AdditionalPatientInformation;
        public MSG_MessageText_2 MSG_MessageText;
        public All_NM1_278_2 AllNM1;
        public List<Loop_2000F_278> Loop2000F;
    }
    public class Loop_2000E_278_2
    {
        public HL_PatientEventLevel_2 HL_PatientEventLevel;
        public List<TRN_DependentTraceNumber_2> TRN_PatientEventTrackingNumber;
        public List<AAA_PatientEventRequestValidation> AAA_PatientEventRequestValidation;
        public UM_HealthCareServicesReviewInformation_4 UM_HealthCareServicesReviewInformation;
        public HCR_HealthCareServicesReview_2 HCR_HealthCareServicesReview;
        public All_REF_278_2 AllREF;
        public All_DTP_278_3 AllDTP;
        public HI_PatientDiagnosis_2 HI_PatientDiagnosis;
        public HSD_HealthCareServicesDelivery_4 HSD_HealthCareServicesDelivery;
        public CL1_InstitutionalClaimCode_3 CL1_InstitutionalClaimCode;
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation;
        public CR2_SpinalManipulationServiceInformation_3 CR2_SpinalManipulationServiceInformation;
        public CR5_HomeOxygenTherapyInformation_2 CR5_HomeOxygenTherapyInformation;
        public CR6_HomeHealthCareInformation_2 CR6_HomeHealthCareInformation;
        public List<PWK_AdditionalPatientInformation_2> PWK_AdditionalPatientInformation;
        public MSG_MessageText MSG_MessageText;
        public All_NM1_278_3 AllNM1;
        public List<Loop_2000F_278_2> Loop2000F;
    }
    public class Loop_2000F_278
    {
        public HL_ServiceLevel HL_ServiceLevel;
        public List<TRN_PatientEventTrackingNumber> TRN_ServiceTraceNumber;
        public UM_HealthCareServicesReviewInformation UM_HealthCareServicesReviewInformation;
        public All_REF_278 AllREF;
        public DTP_ServiceDate_2 DTP_ServiceDate;
        public SV1_ProfessionalService_2 SV1_ProfessionalService;
        public SV2_InstitutionalServiceLine_2 SV2_InstitutionalServiceLine;
        public SV3_DentalService_2 SV3_DentalService;
        public List<TOO_ToothInformation_2> TOO_ToothInformation;
        public HSD_HealthCareServicesDelivery_2 HSD_HealthCareServicesDelivery;
        public List<PWK_AdditionalPatientInformation> PWK_AdditionalServiceInformation;
        public MSG_MessageText_2 MSG_MessageText;
        public List<Loop_2010F_278> Loop2010F;
    }
    public class Loop_2000F_278_2
    {
        public HL_ServiceLevel_2 HL_ServiceLevel;
        public List<TRN_DependentTraceNumber_2> TRN_ServiceTraceNumber;
        public List<AAA_ServiceRequestValidation> AAA_ServiceRequestValidation;
        public UM_HealthCareServicesReviewInformation_2 UM_HealthCareServicesReviewInformation;
        public HCR_HealthCareServicesReview HCR_HealthCareServicesReview;
        public All_REF_278_2 AllREF;
        public All_DTP_278 AllDTP;
        public HI_RequestForAdditionalInformation HI_RequestForAdditionalInformation;
        public SV1_ProfessionalService_3 SV1_ProfessionalService;
        public SV2_InstitutionalServiceLine_3 SV2_InstitutionalServiceLine;
        public SV3_DentalService_3 SV3_DentalService;
        public List<TOO_ToothInformation> TOO_ToothInformation;
        public HSD_HealthCareServicesDelivery_3 HSD_HealthCareServicesDelivery;
        public List<PWK_AdditionalPatientInformation_2> PWK_AdditionalServiceInformation;
        public MSG_MessageText MSG_MessageText;
        public All_NM1_278 AllNM1;
    }
    public class Loop_2010A_278
    {
        public NM1_UtilizationManagementOrganization NM1_UtilizationManagementOrganization_UMO_Name;
    }
    public class Loop_2010A_278_2
    {
        public NM1_UtilizationManagementOrganization_2 NM1_UtilizationManagementOrganization_UMO_Name;
        public PER_AdditionalServiceInformationContactInformation PER_UtilizationManagementOrganization_UMO_ContactInformation;
        public List<AAA_UtilizationManagementOrganization> AAA_UtilizationManagementOrganization_UMO_RequestValidation;
    }
    public class Loop_2010B_278
    {
        public NM1_RequesterName NM1_RequesterName;
        public List<REF_RequesterSupplementalIdentification> REF_RequesterSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_RequesterAddress;
        public N4_DependentCity N4_RequesterCity_State_ZIPCode;
        public PER_PatientEventProviderContactInformation PER_RequesterContactInformation;
        public PRV_RequesterProviderInformation PRV_RequesterProviderInformation;
    }
    public class Loop_2010B_278_2
    {
        public NM1_RequesterName_2 NM1_RequesterName;
        public List<REF_RequesterSupplementalIdentification_2> REF_RequesterSupplementalIdentification;
        public List<AAA_RequesterRequestValidation> AAA_RequesterRequestValidation;
        public PRV_RequesterProviderInformation_2 PRV_RequesterProviderInformation;
    }
    public class Loop_2010C_278
    {
        public NM1_SubscriberName_3 NM1_SubscriberName;
        public List<REF_SubscriberSupplementalIdentification> REF_SubscriberSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress;
        public N4_DependentCity N4_SubscriberCity_State_ZIPCode;
        public DMG_DependentDemographicInformation_4 DMG_SubscriberDemographicInformation;
        public INS_SubscriberRelationship_2 INS_SubscriberRelationship;
    }
    public class Loop_2010C_278_2
    {
        public NM1_SubscriberName_4 NM1_SubscriberName;
        public List<REF_SubscriberSupplementalIdentification_2> REF_SubscriberSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberMailingAddress;
        public N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode;
        public List<AAA_SubscriberRequestValidation_2> AAA_SubscriberRequestValidation;
        public DMG_DependentDemographicInformation_5 DMG_SubscriberDemographicInformation;
        public INS_SubscriberRelationship_3 INS_SubscriberRelationship;
    }
    public class Loop_2010D_278
    {
        public NM1_DependentName_3 NM1_DependentName;
        public List<REF_DependentSupplementalIdentification> REF_DependentSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_DependentAddress;
        public N4_DependentCity N4_DependentCity_State_ZIPCode;
        public DMG_DependentDemographicInformation_4 DMG_DependentDemographicInformation;
        public INS_DependentRelationship_3 INS_DependentRelationship;
    }
    public class Loop_2010D_278_2
    {
        public NM1_DependentName_4 NM1_DependentName;
        public List<REF_DependentSupplementalIdentification_2> REF_DependentSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_DependentAddress;
        public N4_AdditionalPatientInformationContactCity N4_DependentCity_State_ZIPCode;
        public List<AAA_DependentRequestValidation_3> AAA_DependentRequestValidation;
        public DMG_DependentDemographicInformation_5 DMG_DependentDemographicInformation;
        public INS_DependentRelationship_4 INS_DependentRelationship;
    }
    public class Loop_2010EA_278
    {
        public NM1_PatientEventProviderName NM1_PatientEventProviderName;
        public List<REF_PatientEventProviderSupplementalInformation> REF_PatientEventProviderSupplementalInformation;
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventProviderAddress;
        public N4_DependentCity N4_PatientEventProviderCity_State_ZipCode;
        public PER_PatientEventProviderContactInformation PER_PatientEventProviderContactInformation;
        public PRV_PatientEventProviderInformation PRV_PatientEventProviderInformation;
    }
    public class Loop_2010EA_278_2
    {
        public NM1_PatientEventProviderName_2 NM1_PatientEventProviderName;
        public List<REF_PatientEventProviderSupplementalIdentification> REF_PatientEventProviderSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventProviderAddress;
        public N4_AdditionalPatientInformationContactCity N4_PatientEventProviderCity_State_ZIPCode;
        public PER_AdditionalServiceInformationContactInformation PER_ProviderContactInformation;
        public List<AAA_PatientEventProviderRequestValidation> AAA_PatientEventProviderRequestValidation;
        public PRV_PatientEventProviderInformation_2 PRV_PatientEventProviderInformation;
    }
    public class Loop_2010EB_278
    {
        public NM1_PatientEventTransportInformation NM1_PatientEventTransportInformation;
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventTransportLocationAddress;
        public N4_PatientEventTransportLocationCity N4_PatientEventTransportLocationCity_State_ZIPCode;
    }
    public class Loop_2010EB_278_2
    {
        public NM1_AdditionalPatientInformationContactName NM1_AdditionalPatientInformationContactName;
        public N3_AdditionalPatientInformationContactAddress N3_AdditionalPatientInformationContactAddress;
        public N4_AdditionalPatientInformationContactCity N4_AdditionalPatientInformationContactCity_State_ZIPCode;
        public PER_AdditionalPatientInformationContactInformation PER_AdditionalPatientInformationContactInformation;
    }
    public class Loop_2010EC_278
    {
        public NM1_PatientEventOtherUMOName NM1_PatientEventOtherUMOName;
        public REF_OtherUMODenialReason REF_OtherUMODenialReason;
        public DTP_OtherUMODenialDate DTP_OtherUMODenialDate;
    }
    public class Loop_2010EC_278_2
    {
        public NM1_PatientEventTransportInformation_2 NM1_PatientEventTransportInformation;
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventTransportLocationAddress;
        public N4_PatientEventTransportLocationCity_2 N4_PatientEventTransportLocationCity_State_ZIPCode;
        public List<AAA_PatientEventTransportLocationRequestValidation> AAA_PatientEventTransportLocationRequestValidation;
    }
    public class Loop_2010F_278
    {
        public NM1_ServiceProviderName NM1_ServiceProviderName;
        public List<REF_PatientEventProviderSupplementalInformation> REF_ServiceProviderSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress;
        public N4_DependentCity N4_ServiceProviderCity_State_ZIPCode;
        public PER_PatientEventProviderContactInformation PER_ServiceProviderContactInformation;
        public PRV_ServiceProviderInformation PRV_ServiceProviderInformation;
    }
    public class Loop_2010FA_278
    {
        public NM1_ServiceProviderName_2 NM1_ServiceProviderName;
        public List<REF_ServiceProviderSupplementalIdentification> REF_ServiceProviderSupplementalIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress;
        public N4_AdditionalPatientInformationContactCity N4_ServiceProviderCity_State_ZIPCode;
        public PER_AdditionalServiceInformationContactInformation PER_ServiceProviderContactInformation;
        public List<AAA_PatientEventProviderRequestValidation> AAA_ServiceProviderRequestValidation;
        public PRV_ServiceProviderInformation_2 PRV_ServiceProviderInformation;
    }
    public class Loop_2010FB_278
    {
        public NM1_AdditionalPatientInformationContactName NM1_AdditionalServiceInformationContactName;
        public N3_AdditionalPatientInformationContactAddress N3_AdditionalServiceInformationContactAddress;
        public N4_AdditionalPatientInformationContactCity N4_AdditionalServiceInformationContactCity_State_ZIPCode;
        public PER_AdditionalServiceInformationContactInformation PER_AdditionalServiceInformationContactInformation;
    }
    public class Loop_BHT_278
    {
        public BHT_BeginningOfHierarchicalTransaction_6 BHT_BeginningOfHierarchicalTransaction;
        public Loop_2000A_278 Loop2000A;
    }
    public class Loop_BHT_278_2
    {
        public BHT_BeginningOfHierarchicalTransaction_7 BHT_BeginningOfHierarchicalTransaction;
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
