/* Ethan Shipston
 * June 17, 2019
 * ICS4U
 * A program which counts every sunday in the 20th century
 */
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

namespace _184988CountingSundays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            int year = 1901;
            string month = "Jan";
            int day = 0;
            int sundayDayCount = 0;
            int sundayCount = 0;
            bool yearEnd = false;

            while (year < 2001)
            {
                while (yearEnd == false)
                {
                    if (month == "Jan")
                    {
                        if (day < 31)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Feb";
                            day = 0;
                        }
                    }

                    if (month == "Feb")
                    {
                        if (year % 4 == 0 || year % 400 == 0)
                        {
                            if (day < 29)
                            {
                                day++;
                                sundayDayCount++;
                                if (sundayDayCount == 7)
                                {
                                    sundayDayCount = 0;
                                    if (day == 1)
                                        sundayCount++;
                                }
                            }
                            else
                            {
                                month = "Mar";
                                day = 0;
                            }
                        }
                        else
                        {
                            if (day < 28)
                            {
                                day++;
                                sundayDayCount++;
                                if (sundayDayCount == 7)
                                {
                                    sundayDayCount = 0;
                                    if (day == 1)
                                        sundayCount++;

                                }
                            }
                            else
                            {
                                month = "Mar";
                                day = 0;
                            }
                        }
                    }

                    if (month == "Mar")
                    {
                        if (day < 31)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Apr";
                            day = 0;
                        }
                    }

                    if (month == "Apr")
                    {
                        if (day < 30)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "May";
                            day = 0;
                        }
                    }

                    if (month == "May")
                    {
                        if (day < 31)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Jun";
                            day = 0;
                        }
                    }

                    if (month == "Jun")
                    {
                        if (day < 30)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Jul";
                            day = 0;
                        }
                    }

                    if (month == "Jul")
                    {
                        if (day < 31)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Aug";
                            day = 0;
                        }
                    }

                    if (month == "Aug")
                    {
                        if (day < 31)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Sep";
                            day = 0;
                        }
                    }

                    if (month == "Sep")
                    {
                        if (day < 30)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Oct";
                            day = 0;
                        }
                    }

                    if (month == "Oct")
                    {
                        if (day < 31)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Nov";
                            day = 0;
                        }
                    }

                    if (month == "Nov")
                    {
                        if (day < 30)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Dec";
                            day = 0;
                        }
                    }

                    if (month == "Dec")
                    {
                        if (day < 31)
                        {
                            day++;
                            sundayDayCount++;
                            if (sundayDayCount == 7)
                            {
                                sundayDayCount = 0;
                                if (day == 1)
                                    sundayCount++;
                            }
                        }
                        else
                        {
                            month = "Jan";
                            day = 0;
                            yearEnd = true;
                        }
                    }
                }
                yearEnd = false;
                year++;
            }

            MessageBox.Show(sundayCount.ToString());
        }
    }
}
