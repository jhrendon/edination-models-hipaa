namespace EdiNation.X12.HIPAA005010.Base
{
    using System.Collections.Generic;
    public class TS997 
    {
        public ST ST;
        public AK1 AK1;
        public List<TS997_AK2Loop1> AK2Loop1;
        public AK9 AK9;
        public SE SE;
    }
    public class TS997_AK2Loop1
    {
        public AK2 AK2;
        public List<TS997_AK3Loop1> AK3Loop1;
        public AK5 AK5;
    }
    public class TS997_AK3Loop1
    {
        public AK3 AK3;
        public List<AK4> AK4;
    }
}
