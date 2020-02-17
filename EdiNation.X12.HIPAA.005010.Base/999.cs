namespace EdiNation.X12.HIPAA005010.Base
{
    using System.Collections.Generic;
    public class TS999 
    {
        public ST ST;
        public AK1 AK1;
        public List<TS999_AK2Loop1> AK2Loop1;
        public AK9 AK9;
        public SE SE;
    }
    public class TS999_AK2Loop1
    {
        public AK2 AK2;
        public List<TS999_IK3Loop1> IK3Loop1;
        public IK5 IK5;
    }
    public class TS999_IK3Loop1
    {
        public IK3 IK3;
        public List<CTX> CTX;
        public List<TS999_IK4Loop1> IK4Loop1;
    }
    public class TS999_IK4Loop1
    {
        public IK4 IK4;
        public List<CTX> CTX;
    }
}
