using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;


public class EmployeeMapping : ClassMapping<Employee>
{
    public EmployeeMapping()
    {
        Table("employee");
        Id(x => x.ID, m => m.Generator(Generators.GuidComb));
        Property(x => x.Name, m =>
        {
            m.Length(50);
            m.NotNullable(true);
        });
        Property(x => x.Post, m =>
        {
            m.Length(200);
            m.NotNullable(true);
        });
        Property(x => x.EMail, m =>
        {
            m.Length(50);
            m.NotNullable(true);
        });
        Property(x => x.WhatsApp, m =>
        {
            m.Length(50);
            m.NotNullable(true);
        });
        Property(x => x.ImageName, m =>
        {
            m.Length(100);
            m.NotNullable(true);
        });

        ManyToOne(x => x.MunicipalEducation, m =>
        {
            m.Column("municipal_education_id");
            m.Cascade(Cascade.None);
        });

        Bag(x => x.NationalProjects, m =>
        {
            m.Cascade(Cascade.All);
            m.Inverse(true);
            m.Key(k => k.Column("EmployeeId"));
        });

        Bag(x => x.RegionalProjects, m =>
        {
            m.Cascade(Cascade.All);
            m.Inverse(true);
            m.Key(k => k.Column("EmployeeId"));
        });

    }
}
