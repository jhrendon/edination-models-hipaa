namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_TS820A1_820
    {
        public DTM_ProcessDate DTM_ProcessDate;
        public DTM_DeliveryDate DTM_DeliveryDate;
        public DTM_CoveragePeriod DTM_CoveragePeriod;
    }
    public class Loop_1000A_820
    {
        public N1_PremiumReceiversName N1_PremiumReceiversName;
        public N2_PremiumPayerAdditionalName N2_PremiumReceiverAdditionalName;
        public N3_AdditionalPatientInformationContactAddress N3_PremiumReceiversAddress;
        public N4_BillingProviderCityStateZIPCode N4_PremiumReceiversCityStateZip;
    }
    public class Loop_1000B_820
    {
        public N1_PremiumPayersName N1_PremiumPayersName;
        public N2_PremiumPayerAdditionalName N2_PremiumPayerAdditionalName;
        public N3_AdditionalPatientInformationContactAddress N3_PremiumPayersAddress;
        public N4_BillingProviderCityStateZIPCode N4_PremiumPayersCityStateZip;
        public List<PER_PremiumPayersAdministrativeContact> PER_PremiumPayersAdministrativeContact;
    }
    public class Loop_2000A_820
    {
        public ENT_OrganizationSummaryRemittance ENT_OrganizationSummaryRemittance;
        public List<Loop_2300A_820> Loop2300A;
    }
    public class Loop_2000B_820
    {
        public ENT_IndividualRemittance ENT_IndividualRemittance;
        public List<Loop_2100B_820> Loop2100B;
        public List<Loop_2300B_820> Loop2300B;
    }
    public class Loop_2100B_820
    {
        public NM1_IndividualName NM1_IndividualName;
    }
    public class Loop_2300A_820
    {
        public RMR_OrganizationSummaryRemittanceDetail RMR_OrganizationSummaryRemittanceDetail;
        public Loop_2310A_820 Loop2310A;
        public List<Loop_2320A_820> Loop2320A;
    }
    public class Loop_2300B_820
    {
        public RMR_IndividualPremiumRemittanceDetail RMR_IndividualPremiumRemittanceDetail;
        public DTM_CoveragePeriod DTM_IndividualCoveragePeriod;
        public List<Loop_2320B_820> Loop2320B;
    }
    public class Loop_2310A_820
    {
        public IT1_SummaryLineItem IT1_SummaryLineItem;
        public List<Loop_2315A_820> Loop2315A;
    }
    public class Loop_2315A_820
    {
        public SLN_MemberCount SLN_MemberCount;
    }
    public class Loop_2320A_820
    {
        public ADX_OrganizationSummaryRemittanceLevelAdjustment ADX_OrganizationSummaryRemittanceLevelAdjustment;
    }
    public class Loop_2320B_820
    {
        public ADX_IndividualPremiumAdjustment ADX_IndividualPremiumAdjustment;
    }
    public class TS820 
    {
        public ST ST;
        public BPR_FinancialInformation BPR_FinancialInformation;
        public TRN_ReassociationKey TRN_ReassociationKey;
        public CUR_NonUSDollarsCurrency CUR_NonUSDollarsCurrency;
        public List<REF_PremiumReceiversIdentificationKey> REF_PremiumReceiversIdentificationKey;
        public All_TS820A1_820 AllTS820A1;
        public Loop_1000A_820 Loop1000A;
        public Loop_1000B_820 Loop1000B;
        public Loop_2000A_820 Loop2000A;
        public List<Loop_2000B_820> Loop2000B;
        public SE SE;
    }
}
