using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

public class MunicipalEducationMapping : ClassMapping<MunicipalEducation>
{
    public MunicipalEducationMapping()
    {
        Table("municipal_education");
        Id(x => x.ID, m => m.Generator(Generators.GuidComb));
        Property(x => x.Name, m => { m.Length(100); m.NotNullable(true); });
        Property(x => x.OKTMOCode, m => { m.Length(20); m.NotNullable(true); });
    }
}
