namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_REF_834
    {
        public REF_SubscriberNumber REF_SubscriberNumber;
        public REF_MemberPolicyNumber REF_MemberPolicyNumber;
        public List<REF_MemberIdentificationNumber> REF_MemberIdentificationNumber;
        public REF_PriorCoverageMonths REF_PriorCoverageMonths;
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
        public N1_TPABrokerName N1_TPABrokerName;
        public Loop_1100C_834 Loop1100C;
    }
    public class Loop_1100C_834
    {
        public ACT_TPABrokerAccountInformation ACT_TPABrokerAccountInformation;
    }
    public class Loop_2000_834
    {
        public INS_MemberLevelDetail INS_MemberLevelDetail;
        public All_REF_834 AllREF;
        public List<DTP_MemberLevelDates> DTP_MemberLevelDates;
        public Loop_2100A_834 Loop2100A;
        public Loop_2100B_834 Loop2100B;
        public Loop_2100C_834 Loop2100C;
        public List<Loop_2100D_834> Loop2100D;
        public List<Loop_2100E_834> Loop2100E;
        public Loop_2100F_834 Loop2100F;
        public Loop_2100G_834 Loop2100G;
        public Loop_2200_834 Loop2200;
        public List<Loop_2300_834> Loop2300;
    }
    public class Loop_2100A_834
    {
        public NM1_MemberName NM1_MemberName;
        public PER_MemberCommunicationsNumbers PER_MemberCommunicationsNumbers;
        public N3_AdditionalPatientInformationContactAddress N3_MemberResidenceStreetAddress;
        public N4_MemberResidenceCityStateZIPCode N4_MemberResidenceCityStateZIPCode;
        public DMG_MemberDemographics DMG_MemberDemographics;
        public ICM_MemberIncome ICM_MemberIncome;
        public List<AMT_HealthCoveragePolicy> AMT_MemberPolicyAmounts;
        public HLH_MemberHealthInformation HLH_MemberHealthInformation;
        public List<LUI_MemberLanguage> LUI_MemberLanguage;
    }
    public class Loop_2100B_834
    {
        public NM1_IncorrectMemberName NM1_IncorrectMemberName;
        public DMG_DependentDemographicInformation_3 DMG_IncorrectMemberDemographics;
    }
    public class Loop_2100C_834
    {
        public NM1_MemberMailingAddress NM1_MemberMailingAddress;
        public N3_AdditionalPatientInformationContactAddress N3_MemberMailStreetAddress;
        public N4_BillingProviderCityStateZIPCode N4_MemberMailCityStateZip;
    }
    public class Loop_2100D_834
    {
        public NM1_MemberEmployer NM1_MemberEmployer;
        public PER_MemberEmployerCommunicationsNumbers PER_MemberEmployerCommunicationsNumbers;
        public N3_AdditionalPatientInformationContactAddress N3_MemberEmployerStreetAddress;
        public N4_BillingProviderCityStateZIPCode N4_MemberEmployerCityStateZip;
    }
    public class Loop_2100E_834
    {
        public NM1_MemberSchool NM1_MemberSchool;
        public PER_MemberSchoolCommmunicationsNumbers PER_MemberSchoolCommmunicationsNumbers;
        public N3_AdditionalPatientInformationContactAddress N3_MemberSchoolStreetAddress;
        public N4_BillingProviderCityStateZIPCode N4_MemberSchoolCityStateZip;
    }
    public class Loop_2100F_834
    {
        public NM1_CustodialParent NM1_CustodialParent;
        public PER_CustodialParentCommunicationsNumbers PER_CustodialParentCommunicationsNumbers;
        public N3_AdditionalPatientInformationContactAddress N3_CustodialParentStreetAddress;
        public N4_BillingProviderCityStateZIPCode N4_CustodialParentCityStateZip;
    }
    public class Loop_2100G_834
    {
        public NM1_ResponsiblePerson NM1_ResponsiblePerson;
        public PER_ResponsiblePersonCommunicationsNumbers PER_ResponsiblePersonCommunicationsNumbers;
        public N3_AdditionalPatientInformationContactAddress N3_ResponsiblePersonStreetAddress;
        public N4_BillingProviderCityStateZIPCode N4_ResponsiblePersonCityStateZip;
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
        public List<REF_HealthCoveragePolicyNumber> REF_HealthCoveragePolicyNumber;
        public List<IDC_IdentificationCard> IDC_IdentificationCard;
        public List<Loop_2310_834> Loop2310;
        public List<Loop_2320_834> Loop2320;
    }
    public class Loop_2310_834
    {
        public LX_HeaderNumber LX_ProviderInformation;
        public NM1_ProviderName_2 NM1_ProviderName;
        public N4_ProviderCityStateZIPCode N4_ProviderCityStateZIPCode;
        public List<PER_ProviderCommunicationsNumbers> PER_ProviderCommunicationsNumbers;
        public PLA_PCPChangeReason PLA_PCPChangeReason;
    }
    public class Loop_2320_834
    {
        public COB_CoordinationOfBenefits COB_CoordinationOfBenefits;
        public List<REF_AdditionalCoordinationOfBenefitsIdentifiers> REF_AdditionalCoordinationOfBenefitsIdentifiers;
        public N1_OtherInsuranceCompanyName N1_OtherInsuranceCompanyName;
        public List<DTP_CoordinationOfBenefitsEligibilityDates> DTP_CoordinationOfBenefitsEligibilityDates;
    }
    public class TS834 
    {
        public ST ST;
        public BGN_BeginningSegment BGN_BeginningSegment;
        public REF_TransactionSetPolicyNumber REF_TransactionSetPolicyNumber;
        public List<DTP_FileEffectiveDate> DTP_FileEffectiveDate;
        public Loop_1000A_834 Loop1000A;
        public Loop_1000B_834 Loop1000B;
        public List<Loop_1000C_834> Loop1000C;
        public List<Loop_2000_834> Loop2000;
        public SE SE;
    }
}
