namespace testing_1.Services
{
    public class MunicipalEducationService
    {
        public IEnumerable<MunicipalEducation> GetAll()
        {
            return new List<MunicipalEducation>
            {
                new MunicipalEducation { Name = "City A", OKTMOCode = "123456" }
            };
        }

        public MunicipalEducation Create(MunicipalEducation education)
        {
            return education;
        }
    }
}