using System;
using System.Collections.ObjectModel;

namespace MVP.Models
{
    public partial class Contribution
    {
        public int? ContributionId { get; set; }
        public string ContributionTypeName { get; set; }
        public ContributionType ContributionType { get; set; }
        public ContributionTechnology ContributionTechnology { get; set; }
        public ObservableCollection<ContributionTechnology> AdditionalTechnologies { get; set; }
        public DateTime? StartDate { get; set; }
        public string Title { get; set; }
        public string ReferenceUrl { get; set; }
        public Visibility Visibility { get; set; }
        public int? AnnualQuantity { get; set; }
        public int? SecondAnnualQuantity { get; set; }
        public int? AnnualReach { get; set; }
        public string Description { get; set; }
    }
}
