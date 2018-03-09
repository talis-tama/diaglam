using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace diagram
{
    [Activity(Label = "時刻表", MainLauncher = true)]
    public partial class MainActivity : Activity
    {
        TextView textView2, textView3, textView6, textView7, textView8, textView9, textView10, textView11, textView12, textView13, textView15, textView16, textView17, textView18, textView19;
        Spinner spinner1, spinner2, spinner3;
        ArrayAdapter adapter1, adapter2, adapter3;
        TextClock textClock2;
        DateTime tim;
        int weekNo = 0, hour = 0, min = 0, second = 0, nexthour = 0, nextmin = 0, index1 = 0, index2 = 0, index3 = 0, buff = 0, var = 0;
        string gyapmin, gyapsecond;
        bool initiliz = true, first = true;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            Initilizing();
        }
        void Initilizing()
        {
            tim = new DateTime();
            tim = DateTime.Now;
            weekNo = (int)tim.DayOfWeek;
            textView2 = (TextView)FindViewById(Resource.Id.textView2);
            textView3 = (TextView)FindViewById(Resource.Id.textView3);
            textView6 = (TextView)FindViewById(Resource.Id.textView6);
            textView7 = (TextView)FindViewById(Resource.Id.textView7);
            textView8 = (TextView)FindViewById(Resource.Id.textView8);
            textView9 = (TextView)FindViewById(Resource.Id.textView9);
            textView10 = (TextView)FindViewById(Resource.Id.textView10);
            textView11 = (TextView)FindViewById(Resource.Id.textView11);
            textView12 = (TextView)FindViewById(Resource.Id.textView12);
            textView13 = (TextView)FindViewById(Resource.Id.textView13);
            textView15 = (TextView)FindViewById(Resource.Id.textView15);
            textView16 = (TextView)FindViewById(Resource.Id.textView16);
            textView17 = (TextView)FindViewById(Resource.Id.textView17);
            textView18 = (TextView)FindViewById(Resource.Id.textView18);
            textView19 = (TextView)FindViewById(Resource.Id.textView19);
            spinner1 = (Spinner)FindViewById(Resource.Id.spinner1);
            spinner2 = (Spinner)FindViewById(Resource.Id.spinner2);
            spinner3 = (Spinner)FindViewById(Resource.Id.spinner3);
            textClock2 = (TextClock)FindViewById(Resource.Id.textClock2);
            Initalizing_Spinner();
            textView2.Text = tim.ToString("ddd");
            WeekReader();
            hour = tim.Hour;
            min = tim.Minute;
            second = tim.Second;
            Data();
            spinner1.ItemSelected += Spinner1_ItemSelected;
            spinner2.ItemSelected += Spinner2_ItemSelected;
            spinner3.ItemSelected += Spinner3_ItemSelected;
            textClock2.TextChanged += TextClock2_TextChanged;
        }
        void Initalizing_Spinner()
        {
            adapter1 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerDropDownItem);
            adapter1.Add("行き");
            adapter1.Add("帰り");
            adapter1.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner1.Adapter = adapter1;
            adapter2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerDropDownItem);
            adapter2.Add("平日");
            adapter2.Add("休日");
            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner2.Adapter = adapter2;
            adapter3 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerDropDownItem);
            adapter3.Add("東武東上線");
            adapter3.Add("JR武蔵野線");
            adapter3.Add("西武池袋線");
            adapter3.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner3.Adapter = adapter3;
        }
        void TextClock2_TextChanged(object sender,EventArgs e)
        {
            tim = DateTime.Now;
            hour = tim.Hour;
            min = tim.Minute;
            second = tim.Second;
            NextTime();
            if (textClock2.Text == ")00:00:00") { textView2.Text = tim.ToString("ddd"); }
            if (second == 0) { Data(); }
        }
        void Spinner1_ItemSelected(object sender,AdapterView.ItemSelectedEventArgs e)
        {
            index1 = e.Position;
            ItemSelected();
        }
        void Spinner2_ItemSelected(object sender,AdapterView.ItemSelectedEventArgs e)
        {
            index2 = e.Position;
            ItemSelected();
        }
        void Spinner3_ItemSelected(object sender,AdapterView.ItemSelectedEventArgs e)
        {
            index3 = e.Position;
            ItemSelected();
        }
        void ItemSelected()
        {
            initiliz = true;
            if (index1 == 0 && index3 == 0)
            {
                textView6.Text = "鶴瀬駅発　";
                textView7.Text = "朝霞台駅着";
            }
            else if (index1 == 0 && index3 == 1)
            {
                textView6.Text = "北朝霞駅発";
                textView7.Text = "新秋津駅着";
            }
            else if (index1 == 0 && index3 == 2)
            {
                textView6.Text = "秋津駅発　";
                textView7.Text = "元加治駅着";
            }
            else if (index1 == 1 && index3 == 0)
            {
                textView6.Text = "朝霞台駅発";
                textView7.Text = "鶴瀬駅着　";
            }
            else if (index1 == 1 && index3 == 1)
            {
                textView6.Text = "新秋津駅発";
                textView7.Text = "北朝霞駅着";
            }
            else if (index1 == 1 && index3 == 2)
            {
                textView6.Text = "元加治駅発";
                textView7.Text = "秋津駅着　";
            }
            if ((index3 == 1 && index1 == 0) || index3 == 2) { textView8.Text = "備考"; }
            else
            {
                textView8.Text = "";
                textView12.Text = "";
                textView19.Text = "";
            }
            Data();
        }
        void WeekReader()
        {
            if ((int)tim.DayOfWeek == 0 || (int)tim.DayOfWeek == 6) { spinner2.SetSelection(1); }
            else { spinner2.SetSelection(0); }
            int month = tim.Month, day = tim.Day, weeknumber = ((int)(new DateTime(tim.Year, tim.Month, 1).DayOfWeek) + tim.Day - 1) / 7 + 1, week = (int)tim.DayOfWeek;
            if (month == 1 && day == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "元旦";
                index2 = 1;
            }
            else if (month == 1 && day == 2 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else if (month == 1 && weeknumber == 2 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "成人の日";
                index2 = 1;
            }
            else if (month == 2 && day == 11)
            {
                spinner2.SetSelection(1);
                textView3.Text = "建国記念の日";
                index2 = 1;
            }
            else if (month == 2 && day == 12 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else if (month == 4 && day == 29)
            {
                spinner2.SetSelection(1);
                textView3.Text = "昭和の日";
                index2 = 1;
            }
            else if (month == 4 && day == 30 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else if (month == 5 && day == 3)
            {
                spinner2.SetSelection(1);
                textView3.Text = "憲法記念日";
                index2 = 1;
            }
            else if (month == 5 && day == 4)
            {
                spinner2.SetSelection(1);
                textView3.Text = "みどりの日";
                index2 = 1;
            }
            else if (month == 5 && day == 5)
            {
                spinner2.SetSelection(1);
                textView3.Text = "こどもの日";
                index2 = 1;
            }
            else if (month == 5 && day == 6 && week >= 1 && week <= 3)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else if (month == 7 && weeknumber == 3 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "海の日";
                index2 = 1;
            }
            else if (month == 8 && day == 11)
            {
                spinner2.SetSelection(1);
                textView3.Text = "山の日";
                index2 = 1;
            }
            else if (month == 8 && day == 12 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else if (month == 9 && weeknumber == 3 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "敬老の日";
                index2 = 1;
            }
            else if (month == 10 && weeknumber == 2 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "体育の日";
                index2 = 1;
            }
            else if (month == 11 && day == 3)
            {
                spinner2.SetSelection(1);
                textView3.Text = "文化の日";
                index2 = 1;
            }
            else if (month == 11 && day == 4 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else if (month == 11 && day == 23)
            {
                spinner2.SetSelection(1);
                textView3.Text = "勤労感謝の日";
                index2 = 1;
            }
            else if (month == 11 && day == 24 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else if (month == 12 && day == 23)
            {
                spinner2.SetSelection(1);
                textView3.Text = "天皇誕生日";
                index2 = 1;
            }
            else if (month == 12 && day == 24 && week == 1)
            {
                spinner2.SetSelection(1);
                textView3.Text = "振替休日";
                index2 = 1;
            }
            else { textView3.Text = ""; }
        }
        void NextTime()
        {
            TimeSpan date = new TimeSpan(hour, min, second);
            TimeSpan next = new TimeSpan(nexthour, nextmin, 0);
            TimeSpan span = next - date;
            if (nextmin == min) { textView13.Text = "至近"; }
            else
            {
                buff = span.Hours;
                var = span.Minutes;
                var = var + (buff * 60);
                gyapmin = var.ToString();
                gyapsecond = span.Seconds.ToString();
                if (gyapmin.Length == 1) { gyapmin = "0" + gyapmin; }
                if (gyapsecond.Length == 1) { gyapsecond = "0" + gyapsecond; }
                textView13.Text = gyapmin + ":" + gyapsecond;
            }
        }
    }
}