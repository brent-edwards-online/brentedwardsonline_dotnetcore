using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrentEdwardsOnlineDotNetCore.Entities
{
    public class Qualification
    {
        public int QualificationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CertificateUrl { get; set; }
        public string QualificationGroup { get; set; }
        public int SortOrder { get; set; }

        [ForeignKey("QualificationProvidersId")]
        public QualificationProvider Provider { get; set; }

        public int QualificationProviderId { get; set; }
    }
}
