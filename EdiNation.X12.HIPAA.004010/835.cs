namespace EdiNation.X12.HIPAA004010
{
    using System.Collections.Generic;
    public class All_NM1_835
    {
        public NM1_PatientName NM1_PatientName;
        public NM1_InsuredName NM1_InsuredName;
        public NM1_CorrectedPatientInsuredName NM1_CorrectedPatientInsuredName;
        public NM1_ServiceProviderName_2 NM1_ServiceProviderName;
        public NM1_CrossoverCarrierName NM1_CrossoverCarrierName;
        public List<NM1_CorrectedPriorityPayerName> NM1_CorrectedPriorityPayerName;
    }
    public class All_REF_835
    {
        public List<REF_OtherClaimRelatedIdentification> REF_OtherClaimRelatedIdentification;
        public List<REF_RenderingProviderIdentification> REF_RenderingProviderIdentification;
    }
    public class All_REF_835_2
    {
        public List<REF_ServiceIdentification> REF_ServiceIdentification;
        public List<REF_RenderingProviderInformation> REF_RenderingProviderInformation;
    }
    public class All_TS835W1_835
    {
        public REF_ReceiverIdentification REF_ReceiverIdentification;
        public REF_VersionIdentification REF_VersionIdentification;
    }
    public class Loop_1000A_835
    {
        public N1_PayerIdentification N1_PayerIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_PayerAddress;
        public N4_BillingProviderCityStateZIPCode N4_PayerCityStateZIPCode;
        public List<REF_AdditionalPayerIdentification> REF_AdditionalPayerIdentification;
        public PER_ClaimContactInformation PER_PayerContactInformation;
    }
    public class Loop_1000B_835
    {
        public N1_PayeeIdentification N1_PayeeIdentification;
        public N3_AdditionalPatientInformationContactAddress N3_PayeeAddress;
        public N4_BillingProviderCityStateZIPCode N4_PayeeCityStateZIPCode;
        public List<REF_PayeeAdditionalIdentification> REF_PayeeAdditionalIdentification;
    }
    public class Loop_2000_835
    {
        public LX_HeaderNumber LX_HeaderNumber;
        public TS3_ProviderSummaryInformation TS3_ProviderSummaryInformation;
        public TS2_ProviderSupplementalSummaryInformation TS2_ProviderSupplementalSummaryInformation;
        public List<Loop_2100_835> Loop2100;
    }
    public class Loop_2100_835
    {
        public CLP_ClaimPaymentInformation CLP_ClaimPaymentInformation;
        public List<CAS_ClaimAdjustment> CAS_ClaimAdjustment;
        public All_NM1_835 AllNM1;
        public MIA_InpatientAdjudicationInformation MIA_InpatientAdjudicationInformation;
        public MOA_MedicareOutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation;
        public All_REF_835 AllREF;
        public List<DTM_ClaimDate> DTM_ClaimDate;
        public List<PER_ClaimContactInformation> PER_ClaimContactInformation;
        public List<AMT_ClaimSupplementalInformation> AMT_ClaimSupplementalInformation;
        public List<QTY_ClaimSupplementalInformationQuantity> QTY_ClaimSupplementalInformationQuantity;
        public List<Loop_2110_835> Loop2110;
    }
    public class Loop_2110_835
    {
        public SVC_ServicePaymentInformation SVC_ServicePaymentInformation;
        public List<DTM_ServiceDate> DTM_ServiceDate;
        public List<CAS_ClaimAdjustment> CAS_ServiceAdjustment;
        public All_REF_835_2 AllREF;
        public List<AMT_ServiceSupplementalAmount> AMT_ServiceSupplementalAmount;
        public List<QTY_ServiceSupplementalQuantity> QTY_ServiceSupplementalQuantity;
        public List<LQ_HealthCareRemarkCodes> LQ_HealthCareRemarkCodes;
    }
    public class TS835 
    {
        public ST ST;
        public BPR_FinancialInformation_2 BPR_FinancialInformation;
        public TRN_DependentTraceNumber TRN_ReassociationTraceNumber;
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation;
        public All_TS835W1_835 AllTS835W1;
        public DTM_ProductionDate DTM_ProductionDate;
        public Loop_1000A_835 Loop1000A;
        public Loop_1000B_835 Loop1000B;
        public List<Loop_2000_835> Loop2000;
        public List<PLB_ProviderAdjustment> PLB_ProviderAdjustment;
        public SE SE;
    }
}
