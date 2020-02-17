namespace EdiNation.X12.HIPAA005010.Base
{
    using System.Collections.Generic;
    public class All_N1_834
    {
        public Loop_1000A_834 Loop1000A;
        public Loop_1000B_834 Loop1000B;
        public List<Loop_1000C_834> Loop1000C;
    }
    public class All_NM1_834
    {
        public Loop_2100A_834 Loop2100A;
        public Loop_2100B_834 Loop2100B;
        public Loop_2100C_834 Loop2100C;
        public List<Loop_2100D_834> Loop2100D;
        public List<Loop_2100E_834> Loop2100E;
        public Loop_2100F_834 Loop2100F;
        public List<Loop_2100G_834> Loop2100G;
        public Loop_2100H_834 Loop2100H;
    }
    public class All_REF_834
    {
        public List<REF_HealthCoveragePolicyNumber> REF_HealthCoveragePolicyNumber;
        public REF_PriorCoverageMonths REF_PriorCoverageMonths;
    }
    public class All_REF_834_2
    {
        public REF_SubscriberIdentifier REF_SubscriberIdentifier;
        public REF_MemberPolicyNumber REF_MemberPolicyNumber;
        public List<REF_MemberSupplementalIdentifier> REF_MemberSupplementalIdentifier;
    }
    public class Loop_1000A_834
    {
        public N1_SponsorName N1_SponsorName;
    }
    public class Loop_1000B_834
    {
        public N1_Payer N1_Payer;
    }
    public class Loop_1000C_834
    {
        public N1_TPA N1_TPA_BrokerName;
        public Loop_1100C_834 Loop1100C;
    }
    public class Loop_1100C_834
    {
        public ACT_TPA ACT_TPA_BrokerAccountInformation;
    }
    public class Loop_2000_834
    {
        public INS_MemberLevelDetail INS_MemberLevelDetail;
        public All_REF_834_2 AllREF;
        public List<DTP_MemberLevelDates> DTP_MemberLevelDates;
        public All_NM1_834 AllNM1;
        public List<Loop_2200_834> Loop2200;
        public List<Loop_2300_834> Loop2300;
        public Loop_LS_834 LoopLS;
    }
    public class Loop_2100A_834
    {
        public NM1_MemberName NM1_MemberName;
        public PER_MemberCommunicationsNumbers PER_MemberCommunicationsNumbers;
        public N3_AmbulanceDrop N3_MemberResidenceStreetAddress;
        public N4_MemberCity N4_MemberCity_State_ZIPCode;
        public DMG_MemberDemographics DMG_MemberDemographics;
        public List<EC_EmploymentClass> EC_EmploymentClass;
        public ICM_MemberIncome ICM_MemberIncome;
        public List<AMT_HealthCoveragePolicy> AMT_MemberPolicyAmounts;
        public HLH_MemberHealthInformation HLH_MemberHealthInformation;
        public List<LUI_MemberLanguage> LUI_MemberLanguage;
    }
    public class Loop_2100B_834
    {
        public NM1_IncorrectMemberName NM1_IncorrectMemberName;
        public DMG_DependentDemographicInformation_2 DMG_IncorrectMemberDemographics;
    }
    public class Loop_2100C_834
    {
        public NM1_MemberMailingAddress NM1_MemberMailingAddress;
        public N3_AmbulanceDrop N3_MemberMailStreetAddress;
        public N4_AmbulanceDrop N4_MemberMailCity_State_ZIPCode;
    }
    public class Loop_2100D_834
    {
        public NM1_MemberEmployer NM1_MemberEmployer;
        public PER_MemberEmployerCommunicationsNumbers PER_MemberEmployerCommunicationsNumbers;
        public N3_AmbulanceDrop N3_MemberEmployerStreetAddress;
        public N4_AmbulanceDrop N4_MemberEmployerCity_State_ZIPCode;
    }
    public class Loop_2100E_834
    {
        public NM1_MemberSchool NM1_MemberSchool;
        public PER_MemberSchoolCommmunicationsNumbers PER_MemberSchoolCommmunicationsNumbers;
        public N3_AmbulanceDrop N3_MemberSchoolStreetAddress;
        public N4_AmbulanceDrop N4_MemberSchoolCity_State_ZIPCode;
    }
    public class Loop_2100F_834
    {
        public NM1_CustodialParent NM1_CustodialParent;
        public PER_CustodialParentCommunicationsNumbers PER_CustodialParentCommunicationsNumbers;
        public N3_AmbulanceDrop N3_CustodialParentStreetAddress;
        public N4_AmbulanceDrop N4_CustodialParentCity_State_ZIPCode;
    }
    public class Loop_2100G_834
    {
        public NM1_ResponsiblePerson NM1_ResponsiblePerson;
        public PER_ResponsiblePersonCommunicationsNumbers PER_ResponsiblePersonCommunicationsNumbers;
        public N3_AmbulanceDrop N3_ResponsiblePersonStreetAddress;
        public N4_AmbulanceDrop N4_ResponsiblePersonCity_State_ZIPCode;
    }
    public class Loop_2100H_834
    {
        public NM1_DropOffLocation NM1_DropOffLocation;
        public N3_AmbulanceDrop N3_DropOffLocationStreetAddress;
        public N4_AmbulanceDrop N4_DropOffLocationCity_State_ZIPCode;
    }
    public class Loop_2200_834
    {
        public DSB_DisabilityInformation DSB_DisabilityInformation;
        public List<DTP_DisabilityEligibilityDates> DTP_DisabilityEligibilityDates;
    }
    public class Loop_2300_834
    {
        public HD_HealthCoverage HD_HealthCoverage;
        public List<DTP_HealthCoverageDates> DTP_HealthCoverageDates;
        public List<AMT_HealthCoveragePolicy> AMT_HealthCoveragePolicy;
        public All_REF_834 AllREF;
        public List<IDC_IdentificationCard> IDC_IdentificationCard;
        public List<Loop_2310_834> Loop2310;
        public List<Loop_2320_834> Loop2320;
    }
    public class Loop_2310_834
    {
        public LX_HeaderNumber LX_ProviderInformation;
        public NM1_ProviderName NM1_ProviderName;
        public List<N3_AmbulanceDrop> N3_ProviderAddress;
        public N4_ProviderCity N4_ProviderCity_State_ZIPCode;
        public List<PER_ProviderCommunicationsNumbers> PER_ProviderCommunicationsNumbers;
        public PLA_ProviderChangeReason PLA_ProviderChangeReason;
    }
    public class Loop_2320_834
    {
        public COB_CoordinationofBenefits COB_CoordinationofBenefits;
        public List<REF_AdditionalCoordinationofBenefitsIdentifiers> REF_AdditionalCoordinationofBenefitsIdentifiers;
        public List<DTP_CoordinationofBenefitsEligibilityDates> DTP_CoordinationofBenefitsEligibilityDates;
        public List<Loop_2330_834> Loop2330;
    }
    public class Loop_2330_834
    {
        public NM1_CoordinationofBenefitsRelatedEntity NM1_CoordinationofBenefitsRelatedEntity;
        public N3_AmbulanceDrop N3_CoordinationofBenefitsRelatedEntityAddress;
        public N4_AmbulanceDrop N4_CoordinationofBenefitsOtherInsuranceCompanyCity_State_ZIPCode;
        public PER_AdministrativeCommunicationsContact PER_AdministrativeCommunicationsContact;
    }
    public class Loop_2700_834
    {
        public LX_HeaderNumber LX_MemberReportingCategories;
        public Loop_2750_834 Loop2750;
    }
    public class Loop_2750_834
    {
        public N1_ReportingCategory N1_ReportingCategory;
        public List<REF_ReportingCategoryReference> REF_ReportingCategoryReference;
        public DTP_ReportingCategoryDate DTP_ReportingCategoryDate;
    }
    public class Loop_LS_834
    {
        public LS_AdditionalReportingCategories LS_AdditionalReportingCategories;
        public List<Loop_2700_834> Loop2700;
        public LE_AdditionalReportingCategoriesTermination LE_AdditionalReportingCategoriesTermination;
    }
    public class TS834 
    {
        public ST ST;
        public BGN_BeginningSegment BGN_BeginningSegment;
        public REF_TransactionSetPolicyNumber REF_TransactionSetPolicyNumber;
        public List<DTP_FileEffectiveDate> DTP_FileEffectiveDate;
        public List<QTY_TransactionSetControlTotals> QTY_TransactionSetControlTotals;
        public All_N1_834 AllN1;
        public List<Loop_2000_834> Loop2000;
        public SE SE;
    }
}
