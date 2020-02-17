namespace EdiNation.X12.HIPAA005010.Base
{
    using System.Collections.Generic;
    public class ST
    {
        public string TransactionSetIdentifierCode_01;
        public string TransactionSetControlNumber_02;
        public string ImplementationConventionPreference_03;
    }
    public class SE
    {
        public string NumberofIncludedSegments_01;
        public string TransactionSetControlNumber_02;
    }
    public class AK9
    {
        public string FunctionalGroupAcknowledgeCode_01;
        public string NumberofTransactionSetsIncluded_02;
        public string NumberofReceivedTransactionSets_03;
        public string NumberofAcceptedTransactionSets_04;
        public string FunctionalGroupSyntaxErrorCode_05;
        public string FunctionalGroupSyntaxErrorCode_06;
        public string FunctionalGroupSyntaxErrorCode_07;
        public string FunctionalGroupSyntaxErrorCode_08;
        public string FunctionalGroupSyntaxErrorCode_09;
    }
    public class AK5
    {
        public string TransactionSetAcknowledgmentCode_01;
        public string TransactionSetSyntaxErrorCode_02;
        public string TransactionSetSyntaxErrorCode_03;
        public string TransactionSetSyntaxErrorCode_04;
        public string TransactionSetSyntaxErrorCode_05;
        public string TransactionSetSyntaxErrorCode_06;
    }
    public class AK4
    {
        public C030 PositioninSegment_01;
        public string DataElementReferenceNumber_02;
        public string DataElementSyntaxErrorCode_03;
        public string CopyofBadDataElement_04;
    }
    public class AK3
    {
        public string SegmentIDCode_01;
        public string SegmentPositioninTransactionSet_02;
        public string LoopIdentifierCode_03;
        public string SegmentSyntaxErrorCode_04;
    }
    public class AK2
    {
        public string TransactionSetIdentifierCode_01;
        public string TransactionSetControlNumber_02;
        public string ImplementationConventionReference_03;
    }
    public class AK1
    {
        public string FunctionalIdentifierCode_01;
        public string GroupControlNumber_02;
        public string VersionReleaseIndustryIdentifierCode_03;
    }
    public class IK5
    {
        public string TransactionSetAcknowledgmentCode_01;
        public string ImplementationTransactionSetSyntaxErrorCode_02;
        public string ImplementationTransactionSetSyntaxErrorCode_03;
        public string ImplementationTransactionSetSyntaxErrorCode_04;
        public string ImplementationTransactionSetSyntaxErrorCode_05;
        public string ImplementationTransactionSetSyntaxErrorCode_06;
    }
    public class CTX
    {
        public List<C998> ContextIdentification_01;
        public string SegmentIDCode_02;
        public string SegmentPositioninTransactionSet_03;
        public string LoopIdentifierCode_04;
        public C030 PositioninSegment_05;
        public C999 ReferenceinSegment_06;
    }
    public class IK4
    {
        public C030 PositioninSegment_01;
        public string DataElementReferenceNumber_02;
        public string ImplementationDataElementSyntaxErrorCode_03;
        public string CopyofBadDataElement_04;
    }
    public class IK3
    {
        public string SegmentIDCode_01;
        public string SegmentPositioninTransactionSet_02;
        public string LoopIdentifierCode_03;
        public string ImplementationSegmentSyntaxErrorCode_04;
    }
    public class TA1
    {
        public string InterchangeControlNumber_1;
        public string InterchangeDate_2;
        public string InterchangeTime_3;
        public string InterchangeAcknowledgmentCode_4;
        public string InterchangeNoteCode_5;
    }      
}
