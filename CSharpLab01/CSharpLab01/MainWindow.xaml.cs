using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpLab01
{
    /*
    public enum WesternZodiac
    {
        Aquarius,
        Pisces,
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virigo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn
    }*/

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

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BirthDatePicker.SelectedDate = DateTime.Now;
        }

        private void BirthDatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            DateTime dt = (DateTime)BirthDatePicker.SelectedDate;
            int age = CalculateAge(dt);

            if (age == -1)
            {
                MessageBox.Show("Error! Something is wrong with your birth date.","ERROR!");
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

            if (    currentYear < dt.Year
                || (currentYear == dt.Year && currentMonth < dt.Month) 
                || (currentYear == dt.Year && currentMonth == dt.Month && currentDay < dt.Day)
                || (dt.Year < (currentYear-130)) )
            {
                result = -1;
            }
            else if (currentDay == dt.Day && currentMonth == dt.Month)
            {
                MessageBox.Show("Happy birthday!","Yay!");
                result = currentYear - dt.Year;
            }

            return result;
        }
        
        private string CalculateWesternZodiac(DateTime dt)
        {
            string result = "";

            return result;
        }

        private string CalculateChineseZodiac(DateTime dt)
        {
            string result = "";
            int currentYear = DateTime.Now.Year;
            

            return result;
        }
    }
}