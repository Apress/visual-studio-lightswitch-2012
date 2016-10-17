//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 11-6. Code-Behind for the DurationEditorInternal Control
using System;
using System.Windows;
using System.Windows.Controls;

namespace ApressControlsCS
{
    public partial class DurationEditorInternal : UserControl
    {
        public DurationEditorInternal()
        {
            InitializeComponent();
        }

        // 1 Code that registers the Dependency Property
        public static readonly DependencyProperty DurationProperty =
            DependencyProperty.Register(
                "Duration",
                typeof(int),
                typeof(DurationEditorInternal),
                new PropertyMetadata(0, OnDurationPropertyChanged));

        public int Duration
        {
            get
            {
                return (int)base.GetValue(
                    DurationEditorInternal.DurationProperty);
            }
            set
            {
                base.SetValue(
                    DurationEditorInternal.DurationProperty, value);
            }
        }

        // 2 Code that runs when the underlying data value changes
        public static void OnDurationPropertyChanged(
             DependencyObject re, DependencyPropertyChangedEventArgs e)
        {
            DurationEditorInternal de = (DurationEditorInternal)re;
            TimeSpan ts = TimeSpan.FromMinutes(int.Parse(e.NewValue.ToString()));
            de.HourTextbox.Text = Math.Floor(ts.TotalHours).ToString();
            de.MinuteTextbox.Text = ts.Minutes.ToString();
        }

        //  3 Code that runs when the user changes the value
        private void HourTextbox_TextChanged(
            object sender, TextChangedEventArgs e)
        {
            Duration = CalculateDuration();
        }

        private void MinuteTextbox_TextChanged(
            object sender, TextChangedEventArgs e)
        {
            Duration = CalculateDuration();
        }

        private int CalculateDuration()
        {
            int dur = 0;
            try
            {
                dur = (int.Parse(HourTextbox.Text) * 60) +
                         int.Parse(MinuteTextbox.Text);
            }
            catch (Exception ex)
            {

            }
            return dur;
        }
    }
}
