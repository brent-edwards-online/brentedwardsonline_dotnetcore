using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrentEdwardsOnlineDotNetCore.Entities
{
    public class QualificationProvider
    {
        public int QualificationProviderId { get; set; }
        public string QualificationProviderName { get; set; }
        public string QualificationProviderUrl { get; set; }
        public string QualificationProviderImageUrl { get; set; }

        public List<Qualification> Qualifications { get; set; }
    }
}
