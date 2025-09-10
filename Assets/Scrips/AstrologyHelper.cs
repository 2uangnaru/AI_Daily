using UnityEngine;

public static class AstrologyHelper
{
    // Xác định cung hoàng đạo
    public static string GetZodiacSign(int day, int month)
    {
        if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "Aries";
        if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "Taurus";
        if ((month == 5 && day >= 21) || (month == 6 && day <= 20)) return "Gemini";
        if ((month == 6 && day >= 21) || (month == 7 && day <= 22)) return "Cancer";
        if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "Leo";
        if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "Virgo";
        if ((month == 9 && day >= 23) || (month == 10 && day <= 22)) return "Libra";
        if ((month == 10 && day >= 23) || (month == 11 && day <= 21)) return "Scorpio";
        if ((month == 11 && day >= 22) || (month == 12 && day <= 21)) return "Sagittarius";
        if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) return "Capricorn";
        if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "Aquarius";
        if ((month == 2 && day >= 19) || (month == 3 && day <= 20)) return "Pisces";

        return "Unknown";
    }

    // Tính thần số học (Life Path Number)
    public static int GetLifePathNumber(int day, int month, int year)
    {
        int sum = SumDigits(day) + SumDigits(month) + SumDigits(year);

        // Rút gọn
        while (sum > 9 && sum != 11 && sum != 22 && sum != 33)
        {
            sum = SumDigits(sum);
        }

        return sum;
    }

    private static int SumDigits(int number)
    {
        int total = 0;
        while (number > 0)
        {
            total += number % 10;
            number /= 10;
        }
        return total;
    }
}
