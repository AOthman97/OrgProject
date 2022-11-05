namespace ADminLteTest.Entites
{
    public class OrgnaizationsApplication
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public int OrgDetailsNo { get; set; }
        public int WorkNutureNo { get; set; }
        public int StaffNo { get; set; }
        public bool IsApproched { get; set; }
        public string ApprochNature { get; set; }
        public  bool ResourcesRoom { get; set; }
        public int QualificationPeriod { get; set; }
        public bool IsProgreessed { get; set; }
        public int ProgressTypeNo { get; set; }
        public string Comment { get; set; }
        public int CommunicationTypeNo { get; set; }
        public string IdeasAndRecommondaions { get; set; }
    }
}
