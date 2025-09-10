namespace PRELIM_LAB3_BSIT_31A3Daniel_Red.Models;

public class VipCustomer : Customer
{
    public bool IsVip { get; set; } = true;

    public override string GetDescription()
    {
        return $"VIP Customer, {GetFullName()} {GetAge()} {CustomerId}";
    }
}