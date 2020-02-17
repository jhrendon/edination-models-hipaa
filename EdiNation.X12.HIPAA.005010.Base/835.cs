namespace EdiNation.X12.HIPAA005010.Base
{
    using System.Collections.Generic;
    public class All_DTM_835
    {
        public List<DTM_StatementFromorToDate> DTM_StatementFromorToDate;
        public DTM_CoverageExpirationDate DTM_CoverageExpirationDate;
        public DTM_ClaimReceivedDate DTM_ClaimReceivedDate;
    }
    public class All_N1_835
    {
        public Loop_1000A_835 Loop1000A;
        public Loop_1000B_835 Loop1000B;
    }
    public class All_NM1_835
    {
        public NM1_PatientName NM1_PatientName;
        public NM1_InsuredName NM1_InsuredName;
        public NM1_CorrectedPatient NM1_CorrectedPatient_InsuredName;
        public NM1_ServiceProviderName NM1_ServiceProviderName;
        public NM1_CrossoverCarrierName NM1_CrossoverCarrierName;
        public NM1_CorrectedPriorityPayerName NM1_CorrectedPriorityPayerName;
        public NM1_OtherSubscriberName_2 NM1_OtherSubscriberName;
    }
    public class All_PER_835
    {
        public PER_PayerBusinessContactInformation PER_PayerBusinessContactInformation;
        public List<PER_PayerTechnicalContactInformation> PER_PayerTechnicalContactInformation;
        public PER_PayerWEBSite PER_PayerWEBSite;
    }
    public class All_REF_835
    {
        public List<REF_OtherClaimRelatedIdentification> REF_OtherClaimRelatedIdentification;
        public List<REF_RenderingProviderIdentification> REF_RenderingProviderIdentification;
    }
    public class All_REF_835_2
    {
        public List<REF_ServiceIdentification> REF_ServiceIdentification;
        public REF_LineItemControlNumber REF_LineItemControlNumber;
        public List<REF_RenderingProviderInformation> REF_RenderingProviderInformation;
        public List<REF_HealthCarePolicyIdentification> REF_HealthCarePolicyIdentification;
    }
    public class All_REF_835_3
    {
        public REF_ReceiverIdentification REF_ReceiverIdentification;
        public REF_VersionIdentification REF_VersionIdentification;
    }
    public class Loop_1000A_835
    {
        public N1_PayerIdentification N1_PayerIdentification;
        public N3_AmbulanceDrop N3_PayerAddress;
        public N4_AmbulanceDrop N4_PayerCity_State_ZIPCode;
        public List<REF_AdditionalPayerIdentification> REF_AdditionalPayerIdentification;
        public All_PER_835 AllPER;
    }
    public class Loop_1000B_835
    {
        public N1_PayeeIdentification N1_PayeeIdentification;
        public N3_AmbulanceDrop N3_PayeeAddress;
        public N4_AmbulanceDrop N4_PayeeCity_State_ZIPCode;
        public List<REF_PayeeAdditionalIdentification> REF_PayeeAdditionalIdentification;
        public RDM_RemittanceDeliveryMethod RDM_RemittanceDeliveryMethod;
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
        public List<CAS_ClaimsAdjustment> CAS_ClaimsAdjustment;
        public All_NM1_835 AllNM1;
        public MIA_InpatientAdjudicationInformation MIA_InpatientAdjudicationInformation;
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation;
        public All_REF_835 AllREF;
        public All_DTM_835 AllDTM;
        public List<PER_ClaimContactInformation> PER_ClaimContactInformation;
        public List<AMT_ClaimSupplementalInformation> AMT_ClaimSupplementalInformation;
        public List<QTY_ClaimSupplementalInformationQuantity> QTY_ClaimSupplementalInformationQuantity;
        public List<Loop_2110_835> Loop2110;
    }
    public class Loop_2110_835
    {
        public SVC_ServicePaymentInformation SVC_ServicePaymentInformation;
        public List<DTM_ServiceDate> DTM_ServiceDate;
        public List<CAS_ClaimsAdjustment> CAS_ServiceAdjustment;
        public All_REF_835_2 AllREF;
        public List<AMT_ServiceSupplementalAmount> AMT_ServiceSupplementalAmount;
        public List<QTY_ServiceSupplementalQuantity> QTY_ServiceSupplementalQuantity;
        public List<LQ_HealthCareRemarkCodes> LQ_HealthCareRemarkCodes;
    }
    public class TS835 
    {
        public ST ST;
        public BPR_FinancialInformation BPR_FinancialInformation;
        public TRN_DependentTraceNumber TRN_ReassociationTraceNumber;
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation;
        public All_REF_835_3 AllREF;
        public DTM_ProductionDate DTM_ProductionDate;
        public All_N1_835 AllN1;
        public List<Loop_2000_835> Loop2000;
        public List<PLB_ProviderAdjustment> PLB_ProviderAdjustment;
        public SE SE;
    }
}
