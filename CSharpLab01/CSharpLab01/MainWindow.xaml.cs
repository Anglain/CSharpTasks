using System;
//Unused usings
using System.Windows;

namespace CSharpLab01
{

    public enum ChineseZodiac
    {
        Rat = 1996,
        Ox = 1997,
        Tiger = 1998,
        Rabbit = 1999,
        Dragon = 2000,
        Snake = 2001,
        Horse = 2002,
        Goat = 2003,
        Monkey = 2004,
        Rooster = 2005,
        Dog = 2006,
        Pig = 2007
    }
    //I will not fix your app, because didn't even tried to make it using MVVM
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BirthDatePicker.SelectedDate = DateTime.Now;
        }

        private void BirthDatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            //Possible null reference
            DateTime dt = (DateTime)BirthDatePicker.SelectedDate;
            int age = CalculateAge(dt);

            if (age == -1)
            {
                MessageBox.Show("Error! Something is wrong with your birth date.", "ERROR!");
            }
            else
            {
                ZodiacSignText.Text = CalculateWesternZodiac(dt);
                ChineseSignText.Text = CalculateChineseZodiac(dt);
                BirthYearsText.Text = age.ToString();
            }
        }

        private int CalculateAge(DateTime dt)
        {
            int result = 0;

            int currentDay = DateTime.Now.Day;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            if (currentYear < dt.Year
                || (currentYear == dt.Year && currentMonth < dt.Month)
                || (currentYear == dt.Year && currentMonth == dt.Month && currentDay < dt.Day)
                || (dt.Year < (currentYear - 130)))
            {
                result = -1;
            }
            else if (currentDay == dt.Day && currentMonth == dt.Month)
            {
                MessageBox.Show("Happy birthday! You're awesome!", "Yay!");
                result = currentYear - dt.Year;
            }
            else
            {
                if (currentMonth > dt.Month
                    || (currentMonth == dt.Month && currentDay > dt.Day))
                {
                    result = currentYear - dt.Year;
                }
                else
                {
                    result = currentYear - dt.Year - 1;
                }
            }

            return result;
        }

        private string CalculateWesternZodiac(DateTime dt)
        {
            string result = "";

            if ((dt.Month == 1 && dt.Day >= 20) || (dt.Month == 2 && dt.Day <= 18))
            {
                result = "Aquarius";
            }
            else if ((dt.Month == 2 && dt.Day >= 19) || (dt.Month == 3 && dt.Day <= 20))
            {
                result = "Pisces";
            }
            else if ((dt.Month == 3 && dt.Day >= 21) || (dt.Month == 4 && dt.Day <= 19))
            {
                result = "Aries";
            }
            else if ((dt.Month == 4 && dt.Day >= 20) || (dt.Month == 5 && dt.Day <= 20))
            {
                result = "Taurus";
            }
            else if ((dt.Month == 5 && dt.Day >= 21) || (dt.Month == 6 && dt.Day <= 20))
            {
                result = "Gemini";
            }
            else if ((dt.Month == 6 && dt.Day >= 21) || (dt.Month == 7 && dt.Day <= 22))
            {
                result = "Cancer";
            }
            else if ((dt.Month == 7 && dt.Day >= 23) || (dt.Month == 8 && dt.Day <= 22))
            {
                result = "Leo";
            }
            else if ((dt.Month == 8 && dt.Day >= 23) || (dt.Month == 9 && dt.Day <= 22))
            {
                result = "Virgo";
            }
            else if ((dt.Month == 9 && dt.Day >= 23) || (dt.Month == 10 && dt.Day <= 22))
            {
                result = "Libra";
            }
            else if ((dt.Month == 10 && dt.Day >= 23) || (dt.Month == 11 && dt.Day <= 21))
            {
                result = "Scorpio";
            }
            else if ((dt.Month == 11 && dt.Day >= 22) || (dt.Month == 12 && dt.Day <= 21))
            {
                result = "Sagittarius";
            }
            else if ((dt.Month == 12 && dt.Day >= 22) || (dt.Month == 1 && dt.Day <= 19))
            {
                result = "Capricorn";
            }

            return result;
        }

        private string CalculateChineseZodiac(DateTime dt)
        {
            string result = "";

            if ((Math.Abs((int)ChineseZodiac.Rat - dt.Year) % 12) == 0)
            {
                result = "Rat";
            }
            else if ((Math.Abs((int)ChineseZodiac.Ox - dt.Year) % 12) == 0)
            {
                result = "Ox";
            }
            else if ((Math.Abs((int)ChineseZodiac.Tiger - dt.Year) % 12) == 0)
            {
                result = "Tiger";
            }
            else if ((Math.Abs((int)ChineseZodiac.Rabbit - dt.Year) % 12) == 0)
            {
                result = "Rabbit";
            }
            else if ((Math.Abs((int)ChineseZodiac.Dragon - dt.Year) % 12) == 0)
            {
                result = "Dragon";
            }
            else if ((Math.Abs((int)ChineseZodiac.Snake - dt.Year) % 12) == 0)
            {
                result = "Snake";
            }
            else if ((Math.Abs((int)ChineseZodiac.Horse - dt.Year) % 12) == 0)
            {
                result = "Horse";
            }
            else if ((Math.Abs((int)ChineseZodiac.Goat - dt.Year) % 12) == 0)
            {
                result = "Goat";
            }
            else if ((Math.Abs((int)ChineseZodiac.Monkey - dt.Year) % 12) == 0)
            {
                result = "Monkey";
            }
            else if ((Math.Abs((int)ChineseZodiac.Rooster - dt.Year) % 12) == 0)
            {
                result = "Rooster";
            }
            else if ((Math.Abs((int)ChineseZodiac.Dog - dt.Year) % 12) == 0)
            {
                result = "Dog";
            }
            else if ((Math.Abs((int)ChineseZodiac.Pig - dt.Year) % 12) == 0)
            {
                result = "Pig";
            }


            return result;
        }
    }
}