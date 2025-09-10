namespace PRELIM_LAB3_BSIT_31A3Daniel_Red.Models;

public abstract class BaseEntity : IDescribeable
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }

    public int GetAge()
    {
        return DateTime.Now.Year - BirthDay.Year -
               (DateTime.Now.DayOfYear < BirthDay.DayOfYear ? 1 : 0);
    }

    public string GetFullName()
    {
        return $"{FirstName} {MiddleName[0]}. {LastName}";
    }

    public virtual string GetDescription()
    {
        return $"{GetFullName()} {GetAge()}";
    }
}
