using Contracts;
using Repository;

namespace Services;

public class ClockDateService : IClockDate
{
    public DateTime GetCurrnetDate()
    {
        return DateTime.Now;
    }
}