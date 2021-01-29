using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GettingStartedCalendar
{
    public class CalendarBehavior : Behavior<SfCalendar>
    {
        SfCalendar calendar;
        protected override void OnAttachedTo(SfCalendar bindable)
        {
            calendar = bindable;
            calendar.MoveToDate = new DateTime(2018, 12, 31);
            calendar.MinDate = new DateTime(2018, 10, 25);
            calendar.MaxDate = new DateTime(2018, 12, 31);
            List<DateTime> black_dates = new List<DateTime>();
            for (int i = 0; i < 5; i++)
            {
                DateTime date = new DateTime(2018, 12, 1 + i);
                black_dates.Add(date);
            }
            calendar.BlackoutDates = black_dates;
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}


