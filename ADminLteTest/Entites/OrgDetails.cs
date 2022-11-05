namespace ADminLteTest.Entites
{
    public class OrgDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string DirectorName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime FaoundationDate { get; set; } = DateTime.Now;
        public int CityNo { get; set; }
        public int DistrictNo { get; set; }
        public int OrgTypeNo { get; set; }
    }
}
