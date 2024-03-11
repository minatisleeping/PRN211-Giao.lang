﻿namespace Zodiac;
    //today we will study how to make a document/a guidleline for using
    //a library. -- comment in
    /// <summary>
    /// This class will compute and return a zodiac sign based on
    ///day and month of birth. The zodiac sign is in English, Vietnamese, French
    /// <returns></returns>
public class ZodiacCalculator
{

    /// <summary>
    /// This method will return zodiac sign based on the day and month of birth.
    ///The zodiac sign is in English
    /// </summary>
    /// <param name="day">The day must be between 1..31</param>
    /// <param name="month">The mon th must be between 1..12</param>
    /// <returns></returns>
    public static string GetZodiacSign(int day, int month)
    {
        //we check the month first, check the day later
        switch (month)
        {
            case 1:  //Jan
                if (day < 20)
                    return "Capricorn"; //Ma Kết   
                return "Aquarius";      //Bảo Bình

            case 2:  //Feb 
                if (day < 19)
                    return "Aquarius"; //Bảo Bình    
                return "Pisces";       //Song Ngư

            case 3:  //Mar
                if (day < 21)
                    return "Pisces";   //Song Ngư 
                return "Aries";        //Bạch Dương

            case 4:  //Apr
                if (day < 20)
                    return "Aries";   //Bạch Dương  
                return "Taurus";      //Kim Ngưu  

            case 5:  //May
                if (day < 21)
                    return "Taurus";  //Kim Ngưu 
                return "Gemini";      //Song Tử 

            case 6:  //Jun
                if (day < 21)
                    return "Gemini";  //Song Tử   
                return "Cancer";      //Cự Giải   

            case 7:  //Jul            
                if (day < 23)
                    return "Cancer";  //Cự Giải 
                return "Leo";         //Sư Tử  

            case 8:  //Aug
                if (day < 23)
                    return "Leo";     //Sư Tử  
                return "Virgo";       //Xử Nữ  

            case 9:  //Sep
                if (day < 23)
                    return "Virgo";   //Xử Nữ     
                return "Libra";       //Thiên Bình  

            case 10:  //Oct
                if (day < 23)
                    return "Libra";   //Thiên Bình
                return "Scorpio";     //Bọ Cạp   

            case 11:  //Nov
                if (day < 22)
                    return "Scorpio"; //Bọ Cạp  
                return "Sagittarius"; //Nhân Mã 

            case 12:  //Dec
                if (day < 22)
                    return "Sagittarius";  //Nhân Mã
                return "Capricorn";        //Ma Kết

            default: //Wrong month
                return "HotGirl";
        }
    }

    /// <summary>
    /// This method converts/translates English zodiac sign to Vietnamese zodiac sign 
    /// </summary>
    /// <param name="zodiacEnglish">zodiac sign in English</param>
    /// <returns>The zodiac sign in Vietnamese</returns>
    public static string GetZodiacVietnamese(string zodiacEnglish)
    {
        switch (zodiacEnglish)
        {
            case "Capricorn":
                return "Ma Kết";
            case "Aquarius":
                return "Bảo Bình";
            case "Pisces":
                return "Song Ngư";
            case "Aries":
                return "Bạch Dương";
            case "Taurus":
                return "Kim Ngưu";
            case "Gemini":
                return "Song Tử";
            case "Cancer":
                return "Cự Giải";
            case "Leo":
                return "Sư Tử";
            case "Virgo":
                return "Xử Nữ";
            case "Libra":
                return "Thiên Bình";
            case "Scorpio":
                return "Bọ Cạp";
            case "Sagittarius":
                return "Nhân Mã";
            default:
                return "Ngọc Trinh";  //one of my dream girls
        }
    }
}

