namespace EdiNation.X12.HIPAA005010
{
    using System.Collections.Generic;
    public class All_DTM_820
    {
        public DTM_ProcessDate DTM_ProcessDate;
        public DTM_DeliveryDate DTM_DeliveryDate;
        public DTM_CoveragePeriod DTM_CoveragePeriod;
        public DTM_CreationDate DTM_CreationDate;
    }
    public class All_ENT_820
    {
        public Loop_2000A_820 Loop2000A;
        public List<Loop_2000B_820> Loop2000B;
    }
    public class All_N1_820
    {
        public Loop_1000A_820 Loop1000A;
        public Loop_1000B_820 Loop1000B;
        public List<Loop_1000C_820> Loop1000C;
    }
    public class Loop_1000A_820
    {
        public N1_PremiumReceiver N1_PremiumReceiver_Name;
        public N2_IntermediaryBankAdditionalName N2_PremiumReceiverAdditionalName;
        public N3_AdditionalPatientInformationContactAddress N3_PremiumReceiver_Address;
        public N4_AdditionalPatientInformationContactCity N4_PremiumReceiver_City_State_ZIPCode;
        public RDM_PremiumReceiver RDM_PremiumReceiver_RemittanceDeliveryMethod;
    }
    public class Loop_1000B_820
    {
        public N1_PremiumPayer N1_PremiumPayer_Name;
        public N2_IntermediaryBankAdditionalName N2_PremiumPayerAdditionalName;
        public N3_AdditionalPatientInformationContactAddress N3_PremiumPayer_Address;
        public N4_AdditionalPatientInformationContactCity N4_PremiumPayer_City_State_ZIPCode;
        public List<PER_IntermediaryBank> PER_PremiumPayer_AdministrativeContact;
    }
    public class Loop_1000C_820
    {
        public N1_IntermediaryBankInformation N1_IntermediaryBankInformation;
        public N2_IntermediaryBankAdditionalName N2_IntermediaryBankAdditionalName;
        public N3_AdditionalPatientInformationContactAddress N3_IntermediaryBank_Address;
        public N4_AdditionalPatientInformationContactCity N4_IntermediaryBank_City_State_ZIPCode;
        public List<PER_IntermediaryBank> PER_IntermediaryBank_AdministrativeContact;
    }
    public class Loop_2000A_820
    {
        public ENT_OrganizationSummaryRemittance ENT_OrganizationSummaryRemittance;
        public List<Loop_2200A_820> Loop2200A;
        public List<Loop_2300A_820> Loop2300A;
    }
    public class Loop_2000B_820
    {
        public ENT_IndividualRemittance ENT_IndividualRemittance;
        public List<Loop_2100B_820> Loop2100B;
        public List<Loop_2200B_820> Loop2200B;
        public List<Loop_2300B_820> Loop2300B;
    }
    public class Loop_2100B_820
    {
        public NM1_IndividualName NM1_IndividualName;
    }
    public class Loop_2200A_820
    {
        public ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment;
    }
    public class Loop_2200B_820
    {
        public ADX_IndividualPremiumAdjustmentforPreviousPayment ADX_IndividualPremiumAdjustmentforPreviousPayment;
    }
    public class Loop_2300A_820
    {
        public RMR_OrganizationSummaryRemittanceDetail RMR_OrganizationSummaryRemittanceDetail;
        public List<REF_ReferenceInformation_2> REF_ReferenceInformation;
        public DTM_IndividualCoveragePeriod DTM_OrganizationalCoveragePeriod;
        public Loop_2310A_820 Loop2310A;
        public List<Loop_2320A_820> Loop2320A;
    }
    public class Loop_2300B_820
    {
        public RMR_IndividualPremiumRemittanceDetail RMR_IndividualPremiumRemittanceDetail;
        public List<REF_ReferenceInformation> REF_ReferenceInformation;
        public DTM_IndividualCoveragePeriod DTM_IndividualCoveragePeriod;
        public List<Loop_2320B_820> Loop2320B;
    }
    public class Loop_2310A_820
    {
        public IT1_SummaryLineItem IT1_SummaryLineItem;
        public List<Loop_2312A_820> Loop2312A;
        public List<Loop_2315A_820> Loop2315A;
    }
    public class Loop_2312A_820
    {
        public SAC_Service SAC_Service_Promotion_Allowance_ChargeInformation;
    }
    public class Loop_2315A_820
    {
        public SLN_MemberCount SLN_MemberCount;
    }
    public class Loop_2320A_820
    {
        public ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_OrganizationSummaryRemittanceLevelAdjustmentforCurrentPayment;
    }
    public class Loop_2320B_820
    {
        public ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_IndividualPremiumAdjustmentforCurrentPayment;
    }
    public class TS820 
    {
        public ST ST;
        public BPR_FinancialInformation BPR_FinancialInformation;
        public TRN_ReassociationTraceNumber TRN_ReassociationTraceNumber;
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation;
        public List<REF_PremiumReceiversIdentificationKey> REF_PremiumReceiversIdentificationKey;
        public All_DTM_820 AllDTM;
        public All_N1_820 AllN1;
        public All_ENT_820 AllENT;
        public SE SE;
    }
}
