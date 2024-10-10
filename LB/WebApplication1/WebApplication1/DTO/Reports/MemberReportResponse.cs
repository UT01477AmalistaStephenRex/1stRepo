namespace WebApplication1.DTO.Reports
{
    public class MemberReportResponse
    {
        public List<MemberInfo> Members { get; set; }
    }

    public class MemberInfo
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string NICNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
