namespace Zodiac;

public class ZodiacCalculator
{

    public static string GetZodiacSign(int day, int month)
    {
        //we check  the month first, check the day later
        switch (month)
        {
            case 1: //January
                if (day <= 19)
                    return "Capricorn - Ma Kết";
                else
                    return "Aquarius - Bảo Bình";
            case 2: //February
                if (day < 19)
                    return "Aquarius - Bảo Bình";
                else
                    return "Pisces - Song Ngư";
            case 3: //March

                break;
            default:
                return "Coming soon..";
        }
    }

}

