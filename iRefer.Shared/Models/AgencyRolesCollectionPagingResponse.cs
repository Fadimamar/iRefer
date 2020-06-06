namespace iRefer.Shared.Models
{
    public class AgencyRolesCollectionPagingResponse : BaseAPIResponse
    {
        public AgencyRole[] Records { get; set; }
      
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int? NextPage { get; set; }
        public int Count { get; set; }
    }
}
