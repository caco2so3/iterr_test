namespace testing_1.Models;
public class Employee : DomainObject
{
    public virtual string Name { get; set; }
    public virtual string Post { get; set; }
    public virtual string EMail { get; set; }
    public virtual string WhatsApp { get; set; }
    public virtual string ImageName { get; set; }
    public virtual IList<NationalProject> NationalProjects { get; set; }
    public virtual IList<RegionalProject> RegionalProjects { get; set; }
    public virtual MunicipalEducation MunicipalEducation { get; set; }

    public Employee()
    {
        NationalProjects = new List<NationalProject>();
        RegionalProjects = new List<RegionalProject>();
    }
}
