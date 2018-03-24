namespace diagram
{
    public partial class MainActivity
    {
        void Data_back()
        {
            if (index1 == 1 && index2 == 0 && index3 == 0)
            {
                if (hour == 0 && min <= 0)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:00" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:11" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "00:00";
                        textView11.Text = "00:11";
                        nexthour = 0;
                        nextmin = 0;
                        first = false;
                    }
                }
                if (hour == 0 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "00:06";
                        textView11.Text = "00:14";
                        nexthour = 0;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour == 0 && min <= 22)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "00:22";
                        textView11.Text = "00:30";
                        nexthour = 0;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour == 0 && min <= 33)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:42" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "00:33";
                        textView11.Text = "00:42";
                        nexthour = 0;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour == 0 && min <= 48)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:57" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "00:48";
                        textView11.Text = "00:57";
                        nexthour = 0;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 0 || hour == 1 && min <= 3)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "01:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "01:11" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "01:03";
                        textView11.Text = "01:11";
                        nexthour = 1;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 8)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:16" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:08";
                        textView11.Text = "05:16";
                        nexthour = 5;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 27)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:36" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:27";
                        textView11.Text = "05:36";
                        nexthour = 5;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 41)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:50" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:41";
                        textView11.Text = "05:50";
                        nexthour = 5;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 53)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:01" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:53";
                        textView11.Text = "06:01";
                        nexthour = 5;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 58)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:07" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:58";
                        textView11.Text = "06:07";
                        nexthour = 5;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 3)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:11" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:03";
                        textView11.Text = "06:11";
                        nexthour = 6;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 12)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:20" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:12";
                        textView11.Text = "06:20";
                        nexthour = 6;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 19)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:19" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:28" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:19";
                        textView11.Text = "06:28";
                        nexthour = 6;
                        nextmin = 19;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 27)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:36" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:27";
                        textView11.Text = "06:36";
                        nexthour = 6;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 34)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:43" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:34";
                        textView11.Text = "06:43";
                        nexthour = 6;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 42)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:42" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:50" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:42";
                        textView11.Text = "06:50";
                        nexthour = 6;
                        nextmin = 42;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 49)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:58" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:49";
                        textView11.Text = "06:58";
                        nexthour = 6;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 57)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:05" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:57";
                        textView11.Text = "07:05";
                        nexthour = 6;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 6)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:06";
                        textView11.Text = "07:14";
                        nexthour = 7;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 12)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:20" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:12";
                        textView11.Text = "07:20";
                        nexthour = 7;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 23)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:31" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:23";
                        textView11.Text = "07:31";
                        nexthour = 7;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 26)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:36" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:26";
                        textView11.Text = "07:36";
                        nexthour = 7;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 40)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:48" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:40";
                        textView11.Text = "07:48";
                        nexthour = 7;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 45)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:56" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:45";
                        textView11.Text = "07:56";
                        nexthour = 7;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 55)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:55" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:03" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:55";
                        textView11.Text = "08:03";
                        nexthour = 7;
                        nextmin = 55;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 58)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:07" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:58";
                        textView11.Text = "08:07";
                        nexthour = 7;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 4)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:04";
                        textView11.Text = "08:13";
                        nexthour = 8;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 11)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:19" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:11";
                        textView11.Text = "08:19";
                        nexthour = 8;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 14)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:14";
                        textView11.Text = "08:22";
                        nexthour = 8;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 16)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:27" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:16";
                        textView11.Text = "08:27";
                        nexthour = 8;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 22)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:22";
                        textView11.Text = "08:30";
                        nexthour = 8;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 26)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:34" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:26";
                        textView11.Text = "08:34";
                        nexthour = 8;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 34)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:43" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:34";
                        textView11.Text = "08:43";
                        nexthour = 8;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 37)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:37" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:37";
                        textView11.Text = "08:45";
                        nexthour = 8;
                        nextmin = 37;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 39)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:39" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:48" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:39";
                        textView11.Text = "08:48";
                        nexthour = 8;
                        nextmin = 39;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 42)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:42" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:50" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:42";
                        textView11.Text = "08:50";
                        nexthour = 8;
                        nextmin = 42;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 47)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:47" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:57" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:47";
                        textView11.Text = "08:57";
                        nexthour = 8;
                        nextmin = 47;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:51";
                        textView11.Text = "09:00";
                        nexthour = 8;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 53)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:02" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:53";
                        textView11.Text = "09:02";
                        nexthour = 8;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 56)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:05" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:56";
                        textView11.Text = "09:05";
                        nexthour = 8;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 5)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:05";
                        textView11.Text = "09:14";
                        nexthour = 9;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 8)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:17" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:08";
                        textView11.Text = "09:17";
                        nexthour = 9;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 11)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:20" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:11";
                        textView11.Text = "09:20";
                        nexthour = 9;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 20)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:29" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:20";
                        textView11.Text = "09:29";
                        nexthour = 9;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 23)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:32" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:23";
                        textView11.Text = "09:32";
                        nexthour = 9;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 27)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:36" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:27";
                        textView11.Text = "09:36";
                        nexthour = 9;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 35)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:35" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:35";
                        textView11.Text = "09:44";
                        nexthour = 9;
                        nextmin = 35;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 39)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:39" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:47" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:39";
                        textView11.Text = "09:47";
                        nexthour = 9;
                        nextmin = 39;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 42)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:42" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:50" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:42";
                        textView11.Text = "09:50";
                        nexthour = 9;
                        nextmin = 42;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 49)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:58" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:49";
                        textView11.Text = "09:58";
                        nexthour = 9;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 53)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:01" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:53";
                        textView11.Text = "10:01";
                        nexthour = 9;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 57)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:05" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:57";
                        textView11.Text = "10:05";
                        nexthour = 9;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 0)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:00" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:11" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:00";
                        textView11.Text = "10:11";
                        nexthour = 10;
                        nextmin = 0;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 6)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:06";
                        textView11.Text = "19:14";
                        nexthour = 10;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 12)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:20" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:12";
                        textView11.Text = "10:20";
                        nexthour = 10;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 20)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:29" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:20";
                        textView11.Text = "10:29";
                        nexthour = 10;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 31)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:39" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:31";
                        textView11.Text = "10:39";
                        nexthour = 10;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:47" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:38";
                        textView11.Text = "10:47";
                        nexthour = 10;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 43)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:51" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:43";
                        textView11.Text = "10:51";
                        nexthour = 10;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 52)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:52";
                        textView11.Text = "11:00";
                        nexthour = 10;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:01";
                        textView11.Text = "11:10";
                        nexthour = 11;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:15" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:06";
                        textView11.Text = "11:15";
                        nexthour = 11;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:14";
                        textView11.Text = "11:22";
                        nexthour = 11;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:21";
                        textView11.Text = "11:30";
                        nexthour = 11;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:32";
                        textView11.Text = "11:40";
                        nexthour = 11;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:36";
                        textView11.Text = "11:45";
                        nexthour = 11;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:44";
                        textView11.Text = "11:52";
                        nexthour = 11;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:51";
                        textView11.Text = "12:00";
                        nexthour = 11;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:02";
                        textView11.Text = "12:10";
                        nexthour = 12;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:15" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:06";
                        textView11.Text = "12:15";
                        nexthour = 12;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:14";
                        textView11.Text = "12:22";
                        nexthour = 12;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:21";
                        textView11.Text = "12:30";
                        nexthour = 12;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:32";
                        textView11.Text = "12:40";
                        nexthour = 12;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:36";
                        textView11.Text = "12:45";
                        nexthour = 12;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:44";
                        textView11.Text = "12:52";
                        nexthour = 12;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:51";
                        textView11.Text = "13:00";
                        nexthour = 12;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:02";
                        textView11.Text = "13:10";
                        nexthour = 13;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:15" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:06";
                        textView11.Text = "13:15";
                        nexthour = 13;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:14";
                        textView11.Text = "13:22";
                        nexthour = 13;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:21";
                        textView11.Text = "13:30";
                        nexthour = 13;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:32";
                        textView11.Text = "13:40";
                        nexthour = 13;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:36";
                        textView11.Text = "13:45";
                        nexthour = 13;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:44";
                        textView11.Text = "13:52";
                        nexthour = 13;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:51";
                        textView11.Text = "14:00";
                        nexthour = 13;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:02";
                        textView11.Text = "14:10";
                        nexthour = 14;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:15" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:06";
                        textView11.Text = "14:15";
                        nexthour = 14;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:14";
                        textView11.Text = "14:22";
                        nexthour = 14;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:21";
                        textView11.Text = "14:30";
                        nexthour = 14;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:32";
                        textView11.Text = "14:40";
                        nexthour = 14;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:36";
                        textView11.Text = "14:45";
                        nexthour = 14;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:44";
                        textView11.Text = "14:52";
                        nexthour = 14;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:51";
                        textView11.Text = "15:00";
                        nexthour = 14;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:02";
                        textView11.Text = "15:10";
                        nexthour = 15;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:15" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:06";
                        textView11.Text = "15:15";
                        nexthour = 15;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:14";
                        textView11.Text = "15:22";
                        nexthour = 15;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:21";
                        textView11.Text = "15:30";
                        nexthour = 15;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:32";
                        textView11.Text = "15:40";
                        nexthour = 15;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:36";
                        textView11.Text = "15:45";
                        nexthour = 15;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:44";
                        textView11.Text = "15:52";
                        nexthour = 15;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:51";
                        textView11.Text = "16:00";
                        nexthour = 15;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:02";
                        textView11.Text = "16:10";
                        nexthour = 16;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:15" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:06";
                        textView11.Text = "16:15";
                        nexthour = 16;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:14";
                        textView11.Text = "16:22";
                        nexthour = 16;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:21";
                        textView11.Text = "16:30";
                        nexthour = 16;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:32";
                        textView11.Text = "16:40";
                        nexthour = 16;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:36";
                        textView11.Text = "16:45";
                        nexthour = 16;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:44";
                        textView11.Text = "16:52";
                        nexthour = 16;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:51";
                        textView11.Text = "17:00";
                        nexthour = 16;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:02";
                        textView11.Text = "17:10";
                        nexthour = 17;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:06";
                        textView11.Text = "17:14";
                        nexthour = 17;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:14";
                        textView11.Text = "17:22";
                        nexthour = 17;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 23)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:31" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:23";
                        textView11.Text = "17:31";
                        nexthour = 17;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 31)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:31";
                        textView11.Text = "17:40";
                        nexthour = 17;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:47" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:38";
                        textView11.Text = "17:47";
                        nexthour = 17;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 41)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:50" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:41";
                        textView11.Text = "17:50";
                        nexthour = 17;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 50)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:59" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:50";
                        textView11.Text = "17:59";
                        nexthour = 17;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 54)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:03" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:54";
                        textView11.Text = "18:03";
                        nexthour = 17;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:01";
                        textView11.Text = "18:10";
                        nexthour = 18;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 5)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:05";
                        textView11.Text = "18:13";
                        nexthour = 18;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 12)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:12";
                        textView11.Text = "18:22";
                        nexthour = 18;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 22)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:31" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:22";
                        textView11.Text = "18:31";
                        nexthour = 18;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 26)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:35" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:26";
                        textView11.Text = "18:35";
                        nexthour = 18;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 29)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:38" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:29";
                        textView11.Text = "18:38";
                        nexthour = 18;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 36)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:36";
                        textView11.Text = "18:45";
                        nexthour = 18;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 41)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:41";
                        textView11.Text = "18:52";
                        nexthour = 18;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 50)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:59" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:50";
                        textView11.Text = "18:59";
                        nexthour = 18;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 55)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:55" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:04" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:55";
                        textView11.Text = "19:04";
                        nexthour = 18;
                        nextmin = 55;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:01";
                        textView11.Text = "19:10";
                        nexthour = 19;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 5)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:05";
                        textView11.Text = "19:13";
                        nexthour = 19;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 12)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:12";
                        textView11.Text = "19:22";
                        nexthour = 19;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:31" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:21";
                        textView11.Text = "19:31";
                        nexthour = 19;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 29)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:38" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:29";
                        textView11.Text = "19:38";
                        nexthour = 19;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 36)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:36";
                        textView11.Text = "19:45";
                        nexthour = 19;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 41)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:41";
                        textView11.Text = "19:52";
                        nexthour = 19;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 50)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:59" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:50";
                        textView11.Text = "19:59";
                        nexthour = 19;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 55)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:55" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:04" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:55";
                        textView11.Text = "20:04";
                        nexthour = 19;
                        nextmin = 55;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:01";
                        textView11.Text = "20:10";
                        nexthour = 20;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 5)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:05";
                        textView11.Text = "20:13";
                        nexthour = 20;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 12)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:12";
                        textView11.Text = "20:22";
                        nexthour = 20;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 22)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:31" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:22";
                        textView11.Text = "20:31";
                        nexthour = 20;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 29)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:37" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:29";
                        textView11.Text = "20:37";
                        nexthour = 20;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 36)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:36";
                        textView11.Text = "20:45";
                        nexthour = 20;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 41)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:41";
                        textView11.Text = "20:52";
                        nexthour = 20;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 50)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:59" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:50";
                        textView11.Text = "20:59";
                        nexthour = 20;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 55)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:55" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:04" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:55";
                        textView11.Text = "21:04";
                        nexthour = 20;
                        nextmin = 55;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:01";
                        textView11.Text = "21:10";
                        nexthour = 21;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 5)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:05";
                        textView11.Text = "21:13";
                        nexthour = 21;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 13)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:23" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:13";
                        textView11.Text = "21:23";
                        nexthour = 21;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:21";
                        textView11.Text = "21:30";
                        nexthour = 21;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 29)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:38" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:29";
                        textView11.Text = "21:38";
                        nexthour = 21;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 36)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:36";
                        textView11.Text = "21:45";
                        nexthour = 21;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 41)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:51" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:41";
                        textView11.Text = "21:51";
                        nexthour = 21;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:51";
                        textView11.Text = "22:00";
                        nexthour = 21;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 59)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:07" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:59";
                        textView11.Text = "22:07";
                        nexthour = 21;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 4)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:04";
                        textView11.Text = "22:13";
                        nexthour = 22;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 12)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:12";
                        textView11.Text = "22:22";
                        nexthour = 22;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 18)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:29" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:18";
                        textView11.Text = "22:29";
                        nexthour = 22;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 26)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:35" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:26";
                        textView11.Text = "22:35";
                        nexthour = 22;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 29)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:38" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:29";
                        textView11.Text = "22:38";
                        nexthour = 22;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 36)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:36";
                        textView11.Text = "22:45";
                        nexthour = 22;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 41)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:51" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:41";
                        textView11.Text = "22:51";
                        nexthour = 22;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:51";
                        textView11.Text = "23:00";
                        nexthour = 22;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 57)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:06" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:57";
                        textView11.Text = "23:06";
                        nexthour = 22;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 3)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:11" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:03";
                        textView11.Text = "23:11";
                        nexthour = 23;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 12)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "23:12";
                        textView11.Text = "23:22";
                        nexthour = 23;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "23:21";
                        textView11.Text = "23:30";
                        nexthour = 23;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 29)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:37" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:29";
                        textView11.Text = "23:37";
                        nexthour = 23;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 34)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:43" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "23:34";
                        textView11.Text = "23:43";
                        nexthour = 23;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 41)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "23:41";
                        textView11.Text = "23:52";
                        nexthour = 23;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 51)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:59" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:51";
                        textView11.Text = "23:59";
                        nexthour = 23;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 57)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:05" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "23:57";
                        textView11.Text = "00:05";
                        nexthour = 23;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour != 0 && hour != 1 && hour <= 24)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:00" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:11" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:14" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:30" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:42" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:57" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "準急";
                    textView17.Text = textView17.Text + "01:03";
                    textView18.Text = textView18.Text + "01:11";
                }
            }
            else if (index1 == 1 && index2 == 0 && index3 == 1)
            {
                if (hour == 0 && min <= 18)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "00:18";
                        textView11.Text = "00:28";
                        textView12.Text = "";
                        nexthour = 0;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour == 0 && min <= 40)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢止まり" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "00:40";
                        textView11.Text = "--:--";
                        textView12.Text = "東所沢止まり";
                        nexthour = 0;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 14)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "05:14";
                        textView11.Text = "05:24";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 29)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:39" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "05:29";
                        textView11.Text = "05:39";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "05:43";
                        textView11.Text = "05:54";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 2)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:02";
                        textView11.Text = "06:14";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:13";
                        textView11.Text = "06:15";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 22)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:33" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:22";
                        textView11.Text = "06:33";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 30)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:30" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:41" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:30";
                        textView11.Text = "06:41";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 30;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 40)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:51" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:40";
                        textView11.Text = "06:51";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 52)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:03" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:52";
                        textView11.Text = "07:03";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 1)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:12" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:01";
                        textView11.Text = "07:12";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:20" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:09";
                        textView11.Text = "07:20";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 17)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:17" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:29" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:17";
                        textView11.Text = "07:29";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 17;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:35" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:23";
                        textView11.Text = "07:35";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 31)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:42" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:31";
                        textView11.Text = "07:42";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 39)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:39" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:50" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:39";
                        textView11.Text = "07:50";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 39;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 45)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:56" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:45";
                        textView11.Text = "07:56";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 50)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:00" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:50";
                        textView11.Text = "08:00";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:54";
                        textView11.Text = "08:05";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 2)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:13" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:02";
                        textView11.Text = "08:13";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 8)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:08";
                        textView11.Text = "08:19";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 16)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:27" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:16";
                        textView11.Text = "08:27";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:21";
                        textView11.Text = "08:32";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 26)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:37" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:26";
                        textView11.Text = "08:37";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 30)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:30" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:46" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:30";
                        textView11.Text = "08:46";
                        textView12.Text = "東所沢乗換";
                        nexthour = 8;
                        nextmin = 30;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 35)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:35" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:46" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:35";
                        textView11.Text = "08:46";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 35;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 40)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:40";
                        textView11.Text = "08:55";
                        textView12.Text = "東所沢乗換";
                        nexthour = 8;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 44)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:44";
                        textView11.Text = "08:55";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 49)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:03" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:49";
                        textView11.Text = "09:03";
                        textView12.Text = "東所沢乗換";
                        nexthour = 8;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:03" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:53";
                        textView11.Text = "09:03";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 1)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:11" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:01";
                        textView11.Text = "09:11";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 5)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:18" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:05";
                        textView11.Text = "09:18";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 11)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:11";
                        textView11.Text = "09:28";
                        textView12.Text = "東所沢乗換";
                        nexthour = 9;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 17)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:17" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:17";
                        textView11.Text = "09:28";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 17;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 22)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:22";
                        textView11.Text = "09:38";
                        textView12.Text = "東所沢乗換";
                        nexthour = 9;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 27)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:27";
                        textView11.Text = "09:38";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:34";
                        textView11.Text = "09:45";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:43";
                        textView11.Text = "09:54";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:53";
                        textView11.Text = "19:04";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:03";
                        textView11.Text = "10:14";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:13";
                        textView11.Text = "10:24";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:23";
                        textView11.Text = "10:34";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:33";
                        textView11.Text = "10:44";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:43";
                        textView11.Text = "10:54";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:53";
                        textView11.Text = "11:04";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:03";
                        textView11.Text = "11:14";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:13";
                        textView11.Text = "11:24";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:23";
                        textView11.Text = "11:34";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:33";
                        textView11.Text = "11:44";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:43";
                        textView11.Text = "11:54";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:54";
                        textView11.Text = "12:05";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:03";
                        textView11.Text = "12:14";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 14)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:14";
                        textView11.Text = "12:25";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:23";
                        textView11.Text = "12:34";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:34";
                        textView11.Text = "12:45";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:43";
                        textView11.Text = "12:54";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:54";
                        textView11.Text = "13:05";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:03";
                        textView11.Text = "13:14";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:13";
                        textView11.Text = "13:24";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:23";
                        textView11.Text = "13:34";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:33";
                        textView11.Text = "13:44";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:43";
                        textView11.Text = "13:54";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:53";
                        textView11.Text = "14:04";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:03";
                        textView11.Text = "14:14";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 14)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:14";
                        textView11.Text = "14:25";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:23";
                        textView11.Text = "14:34";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:34";
                        textView11.Text = "14:45";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:43";
                        textView11.Text = "14:54";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:53";
                        textView11.Text = "15:04";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:03";
                        textView11.Text = "15:14";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:13";
                        textView11.Text = "15:24";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 24)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:35" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:24";
                        textView11.Text = "15:35";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:33";
                        textView11.Text = "15:44";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 42)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:42" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:53" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:42";
                        textView11.Text = "15:53";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 42;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 56)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:08" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:56";
                        textView11.Text = "16:08";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 8)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:08";
                        textView11.Text = "16:19";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 20)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:30" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:20";
                        textView11.Text = "16:30";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 29)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:40" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:29";
                        textView11.Text = "16:40";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 41)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:51" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:41";
                        textView11.Text = "16:51";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:54";
                        textView11.Text = "17:05";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 5)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:16" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:05";
                        textView11.Text = "17:16";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 16)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:27" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:16";
                        textView11.Text = "17:27";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 20)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:31" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:20";
                        textView11.Text = "17:31";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 25)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:25" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:35" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:25";
                        textView11.Text = "17:35";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 25;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 31)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:42" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:31";
                        textView11.Text = "17:42";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 38)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:49" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:38";
                        textView11.Text = "17:49";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 45)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:45";
                        textView11.Text = "17:55";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:03" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:53";
                        textView11.Text = "18:03";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 1)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:12" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:01";
                        textView11.Text = "18:12";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 8)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:18" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:08";
                        textView11.Text = "18:18";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 15)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:15" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:26" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:15";
                        textView11.Text = "18:26";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 15;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 24)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:35" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:24";
                        textView11.Text = "18:35";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 32)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:32";
                        textView11.Text = "18:43";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 39)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:39" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:50" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:39";
                        textView11.Text = "18:50";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 39;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 46)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:57" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:46";
                        textView11.Text = "18:57";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:54";
                        textView11.Text = "19:05";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:03";
                        textView11.Text = "19:14";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 12)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:23" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:12";
                        textView11.Text = "19:23";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 22)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:22";
                        textView11.Text = "19:32";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 26)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:37" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:26";
                        textView11.Text = "19:37";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 31)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:41" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:31";
                        textView11.Text = "19:41";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 40)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:51" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:40";
                        textView11.Text = "19:51";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 50)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:00" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:50";
                        textView11.Text = "20:00";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 59)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:10" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:59";
                        textView11.Text = "20:10";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 4)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:04";
                        textView11.Text = "20:19";
                        textView12.Text = "東所沢乗換";
                        nexthour = 20;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 8)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:08";
                        textView11.Text = "20:19";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 16)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:27" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:16";
                        textView11.Text = "20:27";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 25)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:25" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:36" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:25";
                        textView11.Text = "20:36";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 25;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:34";
                        textView11.Text = "20:45";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 45)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:56" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:45";
                        textView11.Text = "20:56";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 57)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:08" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:57";
                        textView11.Text = "21:08";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:20" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:09";
                        textView11.Text = "21:20";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:13";
                        textView11.Text = "21:32";
                        textView12.Text = "東所沢乗換";
                        nexthour = 21;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 22)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:22";
                        textView11.Text = "21:32";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:34";
                        textView11.Text = "21:45";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 46)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:57" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:46";
                        textView11.Text = "21:57";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 58)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:08" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:58";
                        textView11.Text = "22:08";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 10)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:10" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:21" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:10";
                        textView11.Text = "22:21";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 10;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 20)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:30" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:20";
                        textView11.Text = "22:30";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 24)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:24";
                        textView11.Text = "22:43";
                        textView12.Text = "東所沢乗換";
                        nexthour = 22;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 32)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:32";
                        textView11.Text = "22:43";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:43";
                        textView11.Text = "22:54";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 56)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:56";
                        textView11.Text = "23:07";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:03";
                        textView11.Text = "23:28";
                        textView12.Text = "東所沢乗換";
                        nexthour = 23;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 17)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:17" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:17";
                        textView11.Text = "23:28";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 17;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 32)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:32";
                        textView11.Text = "23:43";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 50)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:00" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:50";
                        textView11.Text = "00:00";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour != 0 && hour <= 24)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "各停";
                    textView17.Text = textView17.Text + "00:40";
                    textView18.Text = textView18.Text + "--:--";
                    textView19.Text = textView19.Text + "東所沢止まり";
                }
            }
            else if (index1 == 1 && index2 == 0 && index3 == 2)
            {
                if (hour <= 4 || hour == 5 && min <= 6)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:31" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "05:06";
                        textView11.Text = "05:31";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 24)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:53" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "05:24";
                        textView11.Text = "05:53";
                        textView12.Text = "小手指乗換";
                        nexthour = 5;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 38)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "05:38";
                        textView11.Text = "06:05";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 52)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "05:52";
                        textView11.Text = "06:22";
                        textView12.Text = "小手指乗換";
                        nexthour = 5;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 4)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:30" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "06:04";
                        textView11.Text = "06:30";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 12)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:40" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "06:12";
                        textView11.Text = "06:40";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 20)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "06:20";
                        textView11.Text = "06:48";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 31)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:02" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "06:31";
                        textView11.Text = "07:02";
                        textView12.Text = "所沢乗換";
                        nexthour = 6;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 41)
                {
                    textView16.Text = textView16.Text + "通急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:11" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "通急";
                        textView10.Text = "06:41";
                        textView11.Text = "07:11";
                        textView12.Text = "小手指乗換";
                        nexthour = 6;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 46)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:17" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "06:46";
                        textView11.Text = "07:17";
                        textView12.Text = "小手指乗換";
                        nexthour = 6;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 51)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:17" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "06:51";
                        textView11.Text = "07:17";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 56)
                {
                    textView16.Text = textView16.Text + "通急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:26" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "通急";
                        textView10.Text = "06:56";
                        textView11.Text = "07:26";
                        textView12.Text = "小手指乗換";
                        nexthour = 6;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 1)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:29" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "07:01";
                        textView11.Text = "07:29";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 11)
                {
                    textView16.Text = textView16.Text + "通急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:41" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "通急";
                        textView10.Text = "07:11";
                        textView11.Text = "07:41";
                        textView12.Text = "小手指乗換";
                        nexthour = 7;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 17)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:17" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "07:17";
                        textView11.Text = "07:47";
                        textView12.Text = "小手指乗換";
                        nexthour = 7;
                        nextmin = 17;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 21)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "07:21";
                        textView11.Text = "07:47";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 26)
                {
                    textView16.Text = textView16.Text + "通急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:56" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "通急";
                        textView10.Text = "07:26";
                        textView11.Text = "07:56";
                        textView12.Text = "小手指乗換";
                        nexthour = 7;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 32)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:59" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "07:32";
                        textView11.Text = "07:59";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 41)
                {
                    textView16.Text = textView16.Text + "通急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:10" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "通急";
                        textView10.Text = "07:41";
                        textView11.Text = "08:10";
                        textView12.Text = "小手指乗換";
                        nexthour = 7;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 47)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:47" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:16" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "07:47";
                        textView11.Text = "08:16";
                        textView12.Text = "小手指乗換";
                        nexthour = 7;
                        nextmin = 47;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 54)
                {
                    textView16.Text = textView16.Text + "通急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "通急";
                        textView10.Text = "07:54";
                        textView11.Text = "08:22";
                        textView12.Text = "所沢乗換";
                        nexthour = 7;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 0)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:00" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "08:00";
                        textView11.Text = "08:25";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 0;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 10)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:10" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "08:10";
                        textView11.Text = "08:38";
                        textView12.Text = "小手指乗換";
                        nexthour = 8;
                        nextmin = 10;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 20)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "08:20";
                        textView11.Text = "08:45";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 30)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:30" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:01" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "08:30";
                        textView11.Text = "09:01";
                        textView12.Text = "小手指乗換";
                        nexthour = 8;
                        nextmin = 30;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 40)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "08:40";
                        textView11.Text = "09:05";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 50)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "08:50";
                        textView11.Text = "09:22";
                        textView12.Text = "小手指乗換";
                        nexthour = 8;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 0)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:00" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:26" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "09:00";
                        textView11.Text = "09:26";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 0;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 11)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:42" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "09:11";
                        textView11.Text = "09:42";
                        textView12.Text = "小手指乗換";
                        nexthour = 9;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 21)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:51" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "09:21";
                        textView11.Text = "09:51";
                        textView12.Text = "小手指乗換";
                        nexthour = 9;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 33)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:58" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "09:33";
                        textView11.Text = "09:58";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 46)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:18" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "09:46";
                        textView11.Text = "10:18";
                        textView12.Text = "小手指乗換";
                        nexthour = 9;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:58";
                        textView11.Text = "10:22";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:09";
                        textView11.Text = "10:38";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "10:18";
                        textView11.Text = "10:47";
                        textView12.Text = "所沢乗換";
                        nexthour = 10;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "10:28";
                        textView11.Text = "10:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 10;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:38";
                        textView11.Text = "11:07";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "10:48";
                        textView11.Text = "11:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 10;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:58";
                        textView11.Text = "11:22";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:09" + System.Environment.NewLine;
                    textView18.Text = textView17.Text + "11:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:09";
                        textView11.Text = "11:38";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:18" + System.Environment.NewLine;
                    textView18.Text = textView17.Text + "11:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "11:18";
                        textView11.Text = "11:47";
                        textView12.Text = "所沢乗換";
                        nexthour = 11;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "11:28";
                        textView11.Text = "11:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 11;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:38";
                        textView11.Text = "12:07";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "11:48";
                        textView11.Text = "12:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 11;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:58";
                        textView11.Text = "12:22";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:09";
                        textView11.Text = "12:38";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "12:18";
                        textView11.Text = "12:47";
                        textView12.Text = "所沢乗換";
                        nexthour = 12;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "12:28";
                        textView11.Text = "12:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 12;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:38";
                        textView11.Text = "13:07";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "12:48";
                        textView11.Text = "13:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 12;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:58";
                        textView11.Text = "13:22";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:09";
                        textView11.Text = "13:38";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "13:18";
                        textView11.Text = "13:47";
                        textView12.Text = "所沢乗換";
                        nexthour = 13;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "13:28";
                        textView11.Text = "13:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 13;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:38";
                        textView11.Text = "14:07";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "13:48";
                        textView11.Text = "14:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 13;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:58";
                        textView11.Text = "14:22";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:09";
                        textView11.Text = "14:38";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "14:18";
                        textView11.Text = "14:47";
                        textView12.Text = "所沢乗換";
                        nexthour = 14;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "14:28";
                        textView11.Text = "14:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 14;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:38";
                        textView11.Text = "15:07";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "14:48";
                        textView11.Text = "15:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 14;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:58";
                        textView11.Text = "15:22";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:09";
                        textView11.Text = "15:38";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "15:18";
                        textView11.Text = "15:47";
                        textView12.Text = "所沢乗換";
                        nexthour = 15;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "15:28";
                        textView11.Text = "15:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 15;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:38";
                        textView11.Text = "16:07";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "15:48";
                        textView11.Text = "16:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 15;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:58";
                        textView11.Text = "16:22";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 9)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:09";
                        textView11.Text = "16:38";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 19)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:19" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "16:19";
                        textView11.Text = "16:47";
                        textView12.Text = "所沢乗換";
                        nexthour = 16;
                        nextmin = 19;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 30)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:30" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "16:30";
                        textView11.Text = "16:55";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 30;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 41)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:11" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "16:41";
                        textView11.Text = "17:11";
                        textView12.Text = "小手指乗換";
                        nexthour = 16;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 51)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "16:51";
                        textView11.Text = "17:19";
                        textView12.Text = "小手指乗換";
                        nexthour = 16;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 1)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "17:01";
                        textView11.Text = "17:25";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 11)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:41" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "17:11";
                        textView11.Text = "17:41";
                        textView12.Text = "小手指乗換";
                        nexthour = 17;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 21)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:49" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "17:21";
                        textView11.Text = "17:49";
                        textView12.Text = "小手指乗換";
                        nexthour = 17;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 31)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "17:31";
                        textView11.Text = "17:55";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 41)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:11" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "17:41";
                        textView11.Text = "18:11";
                        textView12.Text = "所沢乗換";
                        nexthour = 17;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 51)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "17:51";
                        textView11.Text = "18:19";
                        textView12.Text = "小手指乗換";
                        nexthour = 17;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 1)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "18:01";
                        textView11.Text = "18:25";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 11)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:41" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "18:11";
                        textView11.Text = "18:41";
                        textView12.Text = "小手指乗換";
                        nexthour = 18;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 21)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:49" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "18:21";
                        textView11.Text = "18:49";
                        textView12.Text = "小手指乗換";
                        nexthour = 18;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 31)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "18:31";
                        textView11.Text = "18:55";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 41)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:11" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "18:41";
                        textView11.Text = "19:11";
                        textView12.Text = "小手指乗換";
                        nexthour = 18;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 51)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "18:51";
                        textView11.Text = "19:19";
                        textView12.Text = "小手指乗換";
                        nexthour = 18;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 3)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:27" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "19:03";
                        textView11.Text = "19:27";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 16)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "19:16";
                        textView11.Text = "19:43";
                        textView12.Text = "所沢乗換";
                        nexthour = 19;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 31)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "19:31";
                        textView11.Text = "19:55";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 46)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:13" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "19:46";
                        textView11.Text = "20:13";
                        textView12.Text = "所沢乗換";
                        nexthour = 19;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 1)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "20:01";
                        textView11.Text = "20:25";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 16)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "20:16";
                        textView11.Text = "20:43";
                        textView12.Text = "所沢乗換";
                        nexthour = 20;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 31)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:31";
                        textView11.Text = "20:55";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 46)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:13" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "20:46";
                        textView11.Text = "21:13";
                        textView12.Text = "小手指乗換";
                        nexthour = 20;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 1)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:01";
                        textView11.Text = "21:25";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 16)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "21:16";
                        textView11.Text = "21:43";
                        textView12.Text = "小手指乗換";
                        nexthour = 21;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 31)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:31";
                        textView11.Text = "21:55";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 46)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:13" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "21:46";
                        textView11.Text = "22:13";
                        textView12.Text = "小手指乗換";
                        nexthour = 21;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 1)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:01";
                        textView11.Text = "22:25";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 16)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "22:16";
                        textView11.Text = "22:43";
                        textView12.Text = "小手指乗換";
                        nexthour = 22;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 31)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:31";
                        textView11.Text = "22:55";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 53)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:17" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:53";
                        textView11.Text = "23:17";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 15)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:15" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "23:15";
                        textView11.Text = "23:45";
                        textView12.Text = "小手指乗換";
                        nexthour = 23;
                        nextmin = 15;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 35)
                {
                    textView16.Text = textView16.Text + "準急";
                    textView17.Text = textView17.Text + "23:35";
                    textView18.Text = textView18.Text + "00:01";
                    textView19.Text = textView19.Text + "";
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:35";
                        textView11.Text = "00:01";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 35;
                        first = false;
                    }
                }
                else if (hour == 23 && min > 35)
                {
                    textView9.Text = "";
                    textView10.Text = "終";
                    textView11.Text = "電";
                    textView12.Text = "";
                    textView15.Text = "";
                    textView16.Text = "";
                    textView17.Text = "";
                    textView18.Text = "";
                    textView19.Text = "";
                }
            }
            else if (index1 == 1 && index2 == 1 && index3 == 0)
            {
                if (hour == 0 && min <= 5)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "00:05";
                        textView11.Text = "00:13";
                        nexthour = 0;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour == 0 && min <= 22)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "00:22";
                        textView11.Text = "00:30";
                        nexthour = 0;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour == 0 && min <= 33)
                {
                    textView16.Text = textView16.Text + "準急";
                    textView17.Text = textView17.Text + "00:33";
                    textView18.Text = textView18.Text + "00:42";
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "00:33";
                        textView11.Text = "00:42";
                        nexthour = 0;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 8)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:16" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:08";
                        textView11.Text = "05:16";
                        nexthour = 5;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 27)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:36" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:27";
                        textView11.Text = "05:36";
                        nexthour = 5;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 48)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:56" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "05:48";
                        textView11.Text = "05:56";
                        nexthour = 5;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 58)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:07" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "05:58";
                        textView11.Text = "06:07";
                        nexthour = 5;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 3)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:11" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:03";
                        textView11.Text = "06:11";
                        nexthour = 6;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 11)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:19" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:11";
                        textView11.Text = "06:19";
                        nexthour = 6;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 23)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:32" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:23";
                        textView11.Text = "06:32";
                        nexthour = 6;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 26)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:34" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:26";
                        textView11.Text = "06:34";
                        nexthour = 6;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:36";
                        textView11.Text = "06:44";
                        nexthour = 6;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 40)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:49" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:40";
                        textView11.Text = "06:49";
                        nexthour = 6;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 49)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:57" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:49";
                        textView11.Text = "06:57";
                        nexthour = 6;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 52)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "06:52";
                        textView11.Text = "07:00";
                        nexthour = 6;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 56)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:04" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:56";
                        textView11.Text = "07:04";
                        nexthour = 6;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:06";
                        textView11.Text = "07:14";
                        nexthour = 7;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 14)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:24" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:14";
                        textView11.Text = "07:24";
                        nexthour = 7;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 19)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:19" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:28" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:19";
                        textView11.Text = "07:28";
                        nexthour = 7;
                        nextmin = 19;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 23)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:31" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:23";
                        textView11.Text = "07:31";
                        nexthour = 7;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 26)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:35" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:26";
                        textView11.Text = "07:35";
                        nexthour = 7;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:36";
                        textView11.Text = "07:44";
                        nexthour = 7;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 40)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:48" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:40";
                        textView11.Text = "07:48";
                        nexthour = 7;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 49)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:57" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:49";
                        textView11.Text = "07:57";
                        nexthour = 7;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 57)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:05" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "07:57";
                        textView11.Text = "08:05";
                        nexthour = 7;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:06";
                        textView11.Text = "08:14";
                        nexthour = 8;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 13)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:24" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:13";
                        textView11.Text = "08:24";
                        nexthour = 8;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 20)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:28" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:20";
                        textView11.Text = "08:28";
                        nexthour = 8;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 26)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:34" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:26";
                        textView11.Text = "08:34";
                        nexthour = 8;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 33)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:42" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:33";
                        textView11.Text = "08:42";
                        nexthour = 8;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:45" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:36";
                        textView11.Text = "08:45";
                        nexthour = 8;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 41)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:49" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:41";
                        textView11.Text = "08:49";
                        nexthour = 8;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 48)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:56" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:48";
                        textView11.Text = "08:56";
                        nexthour = 8;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 52)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:52";
                        textView11.Text = "09:00";
                        nexthour = 8;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 56)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:05" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:56";
                        textView11.Text = "09:05";
                        nexthour = 8;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 5)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:05";
                        textView11.Text = "09:14";
                        nexthour = 9;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 9)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:18" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:09";
                        textView11.Text = "09:18";
                        nexthour = 9;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 17)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:17" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:25" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:17";
                        textView11.Text = "09:25";
                        nexthour = 9;
                        nextmin = 17;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:21";
                        textView11.Text = "09:30";
                        nexthour = 9;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 31)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:39" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:31";
                        textView11.Text = "09:39";
                        nexthour = 9;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:36";
                        textView11.Text = "09:44";
                        nexthour = 9;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:44";
                        textView11.Text = "09:52";
                        nexthour = 9;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:51";
                        textView11.Text = "10:00";
                        nexthour = 9;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 59)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:08" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "09:59";
                        textView11.Text = "10:08";
                        nexthour = 9;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:06";
                        textView11.Text = "10:14";
                        nexthour = 10;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:14";
                        textView11.Text = "10:22";
                        nexthour = 10;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:21";
                        textView11.Text = "10:30";
                        nexthour = 10;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 31)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:31";
                        textView11.Text = "10:40";
                        nexthour = 10;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:36";
                        textView11.Text = "10:44";
                        nexthour = 10;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:44";
                        textView11.Text = "10:52";
                        nexthour = 10;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:51";
                        textView11.Text = "11:00";
                        nexthour = 10;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:01";
                        textView11.Text = "11:10";
                        nexthour = 11;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:06";
                        textView11.Text = "11:14";
                        nexthour = 11;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:14";
                        textView11.Text = "11:22";
                        nexthour = 11;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:21";
                        textView11.Text = "11:30";
                        nexthour = 11;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:32";
                        textView11.Text = "11:40";
                        nexthour = 11;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:36";
                        textView11.Text = "11:44";
                        nexthour = 11;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:44";
                        textView11.Text = "11:52";
                        nexthour = 11;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "11:51";
                        textView11.Text = "12:00";
                        nexthour = 11;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:02";
                        textView11.Text = "12:10";
                        nexthour = 12;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:06";
                        textView11.Text = "12:14";
                        nexthour = 12;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:14";
                        textView11.Text = "12:22";
                        nexthour = 12;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:21";
                        textView11.Text = "12:30";
                        nexthour = 12;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:32";
                        textView11.Text = "12:40";
                        nexthour = 12;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:36";
                        textView11.Text = "12:44";
                        nexthour = 12;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:44";
                        textView11.Text = "12:52";
                        nexthour = 12;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "12:51";
                        textView11.Text = "13:00";
                        nexthour = 12;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:02";
                        textView11.Text = "13:10";
                        nexthour = 13;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:06";
                        textView11.Text = "13:14";
                        nexthour = 13;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:14";
                        textView11.Text = "13:22";
                        nexthour = 13;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:21";
                        textView11.Text = "13:30";
                        nexthour = 13;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:32";
                        textView11.Text = "13:40";
                        nexthour = 13;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:36";
                        textView11.Text = "13:44";
                        nexthour = 13;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:44";
                        textView11.Text = "13:52";
                        nexthour = 13;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "13:51";
                        textView11.Text = "14:00";
                        nexthour = 13;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:02";
                        textView11.Text = "14:10";
                        nexthour = 14;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:06";
                        textView11.Text = "14:14";
                        nexthour = 14;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:14";
                        textView11.Text = "14:22";
                        nexthour = 14;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:21";
                        textView11.Text = "14:30";
                        nexthour = 14;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 32)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:32";
                        textView11.Text = "14:40";
                        nexthour = 14;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:36";
                        textView11.Text = "14:44";
                        nexthour = 14;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:44";
                        textView11.Text = "14:52";
                        nexthour = 14;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "14:51";
                        textView11.Text = "15:00";
                        nexthour = 14;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 2)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:02";
                        textView11.Text = "15:10";
                        nexthour = 15;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:06";
                        textView11.Text = "15:14";
                        nexthour = 15;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:14";
                        textView11.Text = "15:22";
                        nexthour = 15;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:21";
                        textView11.Text = "15:30";
                        nexthour = 15;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 31)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:31";
                        textView11.Text = "15:40";
                        nexthour = 15;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:36";
                        textView11.Text = "15:44";
                        nexthour = 15;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:44";
                        textView11.Text = "14:52";
                        nexthour = 14;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "15:51";
                        textView11.Text = "16:00";
                        nexthour = 15;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:10" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:01";
                        textView11.Text = "16:10";
                        nexthour = 16;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:14" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:06";
                        textView11.Text = "16:14";
                        nexthour = 16;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 14)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:14";
                        textView11.Text = "16:22";
                        nexthour = 16;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:21";
                        textView11.Text = "16:30";
                        nexthour = 16;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 31)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:40" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:31";
                        textView11.Text = "16:40";
                        nexthour = 16;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 36)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:44" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:36";
                        textView11.Text = "16:44";
                        nexthour = 16;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 44)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:44";
                        textView11.Text = "16:52";
                        nexthour = 16;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 51)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "16:51";
                        textView11.Text = "17:00";
                        nexthour = 16;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 1)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:09" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:01";
                        textView11.Text = "17:09";
                        nexthour = 17;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 4)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:04";
                        textView11.Text = "17:13";
                        nexthour = 17;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 14)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:23" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:14";
                        textView11.Text = "17:23";
                        nexthour = 17;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 21)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:21";
                        textView11.Text = "17:30";
                        nexthour = 17;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 30)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:30" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:38" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:30";
                        textView11.Text = "17:38";
                        nexthour = 17;
                        nextmin = 30;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 34)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:42" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:34";
                        textView11.Text = "17:42";
                        nexthour = 17;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 44)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:53" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:44";
                        textView11.Text = "17:53";
                        nexthour = 17;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 51)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:51";
                        textView11.Text = "18:00";
                        nexthour = 17;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 59)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:08" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:59";
                        textView11.Text = "18:08";
                        nexthour = 17;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 4)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:12" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:04";
                        textView11.Text = "18:12";
                        nexthour = 18;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 14)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:23" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:14";
                        textView11.Text = "18:23";
                        nexthour = 18;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 21)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:29" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:21";
                        textView11.Text = "18:29";
                        nexthour = 18;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 29)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:37" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:29";
                        textView11.Text = "18:37";
                        nexthour = 18;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 34)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:42" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:34";
                        textView11.Text = "18:42";
                        nexthour = 18;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 41)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:41";
                        textView11.Text = "18:52";
                        nexthour = 18;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 51)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:51";
                        textView11.Text = "19:00";
                        nexthour = 18;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 59)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:07" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:59";
                        textView11.Text = "19:07";
                        nexthour = 18;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 4)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:04";
                        textView11.Text = "19:13";
                        nexthour = 19;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 10)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:10" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:18" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:10";
                        textView11.Text = "19:18";
                        nexthour = 19;
                        nextmin = 10;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 21)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:21";
                        textView11.Text = "19:30";
                        nexthour = 19;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 30)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:30" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:38" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:30";
                        textView11.Text = "19:38";
                        nexthour = 19;
                        nextmin = 30;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 34)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:43" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:34";
                        textView11.Text = "19:43";
                        nexthour = 19;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 40)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:40" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:40";
                        textView11.Text = "19:52";
                        nexthour = 19;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 51)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:51";
                        textView11.Text = "20:00";
                        nexthour = 19;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 59)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:08" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "19:59";
                        textView11.Text = "20:08";
                        nexthour = 19;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 4)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:04";
                        textView11.Text = "20:13";
                        nexthour = 20;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 11)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:11";
                        textView11.Text = "20:22";
                        nexthour = 20;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 21)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:21";
                        textView11.Text = "20:30";
                        nexthour = 20;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 29)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:37" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:29";
                        textView11.Text = "20:37";
                        nexthour = 20;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 34)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:43" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:34";
                        textView11.Text = "20:43";
                        nexthour = 20;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 41)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:52" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:41";
                        textView11.Text = "20:52";
                        nexthour = 20;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 48)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:57" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:48";
                        textView11.Text = "20:57";
                        nexthour = 20;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 51)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:00" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:51";
                        textView11.Text = "21:00";
                        nexthour = 20;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 59)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:07" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "20:59";
                        textView11.Text = "21:07";
                        nexthour = 20;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 4)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:13" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:04";
                        textView11.Text = "21:13";
                        nexthour = 21;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 11)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:11" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:11";
                        textView11.Text = "21:22";
                        nexthour = 21;
                        nextmin = 11;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 18)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:27" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:18";
                        textView11.Text = "21:27";
                        nexthour = 21;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 27)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:35" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:27";
                        textView11.Text = "21:35";
                        nexthour = 21;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 35)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:35" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:43" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:35";
                        textView11.Text = "21:43";
                        nexthour = 21;
                        nextmin = 35;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 42)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:42" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:50" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:42";
                        textView11.Text = "21:50";
                        nexthour = 21;
                        nextmin = 42;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 48)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:57" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "21:48";
                        textView11.Text = "21:57";
                        nexthour = 21;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 56)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:05" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:56";
                        textView11.Text = "22:05";
                        nexthour = 21;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 3)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:12" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:03";
                        textView11.Text = "22:12";
                        nexthour = 22;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 12)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:20" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:12";
                        textView11.Text = "22:20";
                        nexthour = 22;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 18)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:27" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:18";
                        textView11.Text = "22:27";
                        nexthour = 22;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 27)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:36" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:27";
                        textView11.Text = "22:36";
                        nexthour = 22;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 33)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:42" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "22:33";
                        textView11.Text = "22:42";
                        nexthour = 22;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 42)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:42" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:50" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:42";
                        textView11.Text = "22:50";
                        nexthour = 22;
                        nextmin = 42;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:06" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:58";
                        textView11.Text = "23:06";
                        nexthour = 22;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 8)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:16" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:08";
                        textView11.Text = "23:16";
                        nexthour = 23;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 13)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:22" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "23:13";
                        textView11.Text = "23:22";
                        nexthour = 23;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:30" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "23:21";
                        textView11.Text = "23:30";
                        nexthour = 23;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 33)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:41" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:33";
                        textView11.Text = "23:41";
                        nexthour = 23;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 48)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:56" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:48";
                        textView11.Text = "23:56";
                        nexthour = 23;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour != 0 && hour <= 24)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:13" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:30" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "準急";
                    textView17.Text = textView17.Text + "00:33";
                    textView18.Text = textView18.Text + "00:42";
                }
            }
            else if (index1 == 1 && index2 == 1 && index3 == 1)
            {
                if (hour <= -1 || hour == 0 && min <= 18)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "00:18";
                        textView11.Text = "00:28";
                        textView12.Text = "";
                        nexthour = 0;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= -1 || hour == 0 && min <= 40)
                {
                    textView16.Text = textView16.Text + "各停";
                    textView17.Text = textView17.Text + "00:40";
                    textView18.Text = textView18.Text + "--:--";
                    textView19.Text = textView19.Text + "東所沢止まり";
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "00:40";
                        textView11.Text = "--:--";
                        textView12.Text = "東所沢止まり";
                        nexthour = 0;
                        nextmin = 40;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 14)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "05:14";
                        textView11.Text = "05:24";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 29)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:39" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "05:29";
                        textView11.Text = "05:39";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 45)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "05:45";
                        textView11.Text = "05:55";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 55)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:55" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:06" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "05:55";
                        textView11.Text = "06:06";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 55;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 12)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:12" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:23" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:12";
                        textView11.Text = "06:23";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 12;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 22)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:22";
                        textView11.Text = "06:32";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 37)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:37" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:37";
                        textView11.Text = "06:47";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 37;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 48)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:58" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:48";
                        textView11.Text = "06:58";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 57)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:08" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "06:57";
                        textView11.Text = "07:08";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 5)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:05";
                        textView11.Text = "07:15";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 15)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:15" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:15";
                        textView11.Text = "07:25";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 15;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:33" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:23";
                        textView11.Text = "07:33";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 29)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:39" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:29";
                        textView11.Text = "07:39";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 37)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:37" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:37";
                        textView11.Text = "07:47";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 37;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 44)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:44";
                        textView11.Text = "07:55";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 49)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:59" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "07:49";
                        textView11.Text = "07:59";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "07:53";
                        textView11.Text = "08:04";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 1)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:12" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:01";
                        textView11.Text = "08:12";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:20" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:09";
                        textView11.Text = "08:20";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 17)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:17" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:17";
                        textView11.Text = "08:28";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 17;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 25)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:25" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:36" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:25";
                        textView11.Text = "08:36";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 25;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 35)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:35" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:35";
                        textView11.Text = "08:45";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 35;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 39)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:39" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:50" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "08:39";
                        textView11.Text = "08:50";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 39;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 45)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:45";
                        textView11.Text = "08:55";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 57)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "08:57";
                        textView11.Text = "09:07";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 2)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:21" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:02";
                        textView11.Text = "09:21";
                        textView12.Text = "東所沢乗換";
                        nexthour = 9;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 10)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:10" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:21" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:10";
                        textView11.Text = "09:21";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 10;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 16)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:16" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:16";
                        textView11.Text = "09:32";
                        textView12.Text = "東所沢乗換";
                        nexthour = 9;
                        nextmin = 16;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 22)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:22";
                        textView11.Text = "09:32";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:33";
                        textView11.Text = "09:44";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:43";
                        textView11.Text = "09:54";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "09:53";
                        textView11.Text = "10:04";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 1)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:01" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:12" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:01";
                        textView11.Text = "10:12";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 1;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:09";
                        textView11.Text = "10:24";
                        textView12.Text = "東所沢乗換";
                        nexthour = 10;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:13";
                        textView11.Text = "10:24";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 18)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "10:18";
                        textView11.Text = "10:28";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:23";
                        textView11.Text = "10:34";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:33";
                        textView11.Text = "10:44";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:43";
                        textView11.Text = "10:54";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:53";
                        textView11.Text = "11:04";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:03";
                        textView11.Text = "11:14";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:13";
                        textView11.Text = "11:24";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:23";
                        textView11.Text = "11:34";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:33";
                        textView11.Text = "11:44";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:43";
                        textView11.Text = "11:54";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:54";
                        textView11.Text = "12:05";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:03";
                        textView11.Text = "12:14";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 14)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:14";
                        textView11.Text = "12:25";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:23";
                        textView11.Text = "12:34";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:34";
                        textView11.Text = "12:45";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:43";
                        textView11.Text = "12:54";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:54";
                        textView11.Text = "13:05";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:03";
                        textView11.Text = "13:14";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:13";
                        textView11.Text = "13:24";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:23";
                        textView11.Text = "13:34";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:33";
                        textView11.Text = "13:44";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:43";
                        textView11.Text = "13:54";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:53";
                        textView11.Text = "14:04";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:03";
                        textView11.Text = "14:14";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 14)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:14";
                        textView11.Text = "14:25";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 23)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:23" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:23";
                        textView11.Text = "14:34";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 23;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:34";
                        textView11.Text = "14:45";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 43)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:43";
                        textView11.Text = "14:54";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 53)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:04" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:53";
                        textView11.Text = "15:04";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:03";
                        textView11.Text = "15:14";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:24" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:13";
                        textView11.Text = "15:24";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 24)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:35" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:24";
                        textView11.Text = "15:35";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:34";
                        textView11.Text = "15:45";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 44)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:44";
                        textView11.Text = "15:54";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 54)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:05" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:54";
                        textView11.Text = "16:05";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 4)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:04" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:04";
                        textView11.Text = "16:15";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 4;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 13)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:23" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:13";
                        textView11.Text = "16:23";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 24)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:34" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:24";
                        textView11.Text = "16:34";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:33";
                        textView11.Text = "16:44";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 44)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:44";
                        textView11.Text = "16:54";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 52)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:03" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:52";
                        textView11.Text = "17:03";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:03";
                        textView11.Text = "17:14";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 15)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:15" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:25" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:15";
                        textView11.Text = "17:25";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 15;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 21)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "17:21";
                        textView11.Text = "17:32";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 26)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:36" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:26";
                        textView11.Text = "17:36";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:34";
                        textView11.Text = "17:45";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 42)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:42" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:53" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:42";
                        textView11.Text = "17:53";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 42;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 50)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:01" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "17:50";
                        textView11.Text = "18:01";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 0)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:00" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:11" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:00";
                        textView11.Text = "18:11";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 0;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 8)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:08" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:08";
                        textView11.Text = "18:19";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 8;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 13)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:23" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:13";
                        textView11.Text = "18:23";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 18)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:18";
                        textView11.Text = "18:28";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 26)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:36" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:26";
                        textView11.Text = "18:36";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 32)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:42" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:32";
                        textView11.Text = "18:42";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 36)
                {
                    textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:36" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "普通";
                        textView10.Text = "18:36";
                        textView11.Text = "18:47";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 36;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 41)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:52" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:41";
                        textView11.Text = "18:52";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 49)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:59" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:49";
                        textView11.Text = "18:59";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 58)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:09" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "18:58";
                        textView11.Text = "19:09";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 2)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:20" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:02";
                        textView11.Text = "19:20";
                        textView12.Text = "東所沢乗換";
                        nexthour = 19;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 10)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:10" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:20" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:10";
                        textView11.Text = "19:20";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 10;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 22)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:22";
                        textView11.Text = "19:32";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:33";
                        textView11.Text = "19:43";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 44)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:44";
                        textView11.Text = "19:54";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 51)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:51" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:06" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:51";
                        textView11.Text = "20:06";
                        textView12.Text = "東所沢乗換";
                        nexthour = 19;
                        nextmin = 51;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 56)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:06" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "19:56";
                        textView11.Text = "20:06";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 0)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:00" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:00";
                        textView11.Text = "20:19";
                        textView12.Text = "東所沢乗換";
                        nexthour = 20;
                        nextmin = 0;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:09";
                        textView11.Text = "20:19";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 21)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:31" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:21";
                        textView11.Text = "20:31";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 26)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:26" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:26";
                        textView11.Text = "20:44";
                        textView12.Text = "東所沢乗換";
                        nexthour = 20;
                        nextmin = 26;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:33";
                        textView11.Text = "20:44";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 45)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:45";
                        textView11.Text = "20:55";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 58)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:08" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "20:58";
                        textView11.Text = "21:08";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:20" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:09";
                        textView11.Text = "21:20";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 21)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:21" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:32" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:21";
                        textView11.Text = "21:32";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 21;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 28)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:28";
                        textView11.Text = "21:44";
                        textView12.Text = "東所沢乗換";
                        nexthour = 21;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 33)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:33" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:33";
                        textView11.Text = "21:44";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 33;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 46)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:56" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:46";
                        textView11.Text = "21:56";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 57)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "21:57";
                        textView11.Text = "22:07";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:20" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:09";
                        textView11.Text = "22:20";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 14)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:30" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:14";
                        textView11.Text = "22:30";
                        textView12.Text = "東所沢乗換";
                        nexthour = 22;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 20)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:20" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:30" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:20";
                        textView11.Text = "22:30";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 20;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 32)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:42" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:32";
                        textView11.Text = "22:42";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 44)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:44" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:54" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:44";
                        textView11.Text = "22:54";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 44;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 56)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "22:56";
                        textView11.Text = "23:07";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 3)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:03";
                        textView11.Text = "23:28";
                        textView12.Text = "東所沢乗換";
                        nexthour = 23;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 17)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:17" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:17";
                        textView11.Text = "23:28";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 17;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 32)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:32";
                        textView11.Text = "23:43";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 50)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:50" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:00" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:50";
                        textView11.Text = "00:00";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 50;
                        first = false;
                    }
                }
                if (hour !=0 && hour <= 24)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "00:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "00:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    textView16.Text = textView16.Text + "各停";
                    textView17.Text = textView17.Text + "00:40";
                    textView18.Text = textView18.Text + "--:--";
                    textView19.Text = textView19.Text + "東所沢止まり";
                }
            }
            else if (index1 == 1 && index2 == 1 && index3 == 2)
            {

                if (hour <= 4 || hour == 5 && min <= 6)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:31" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "05:06";
                        textView11.Text = "05:31";
                        textView12.Text = "";
                        nexthour = 5;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 24)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "05:52" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "05:24";
                        textView11.Text = "05:52";
                        textView12.Text = "小手指乗換";
                        nexthour = 5;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 39)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:39" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "05:39";
                        textView11.Text = "06:07";
                        textView12.Text = "小手指乗換";
                        nexthour = 5;
                        nextmin = 39;
                        first = false;
                    }
                }
                if (hour <= 4 || hour == 5 && min <= 55)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "05:55" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:23" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "05:55";
                        textView11.Text = "06:23";
                        textView12.Text = "所沢乗換";
                        nexthour = 5;
                        nextmin = 55;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 9)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:39" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "06:09";
                        textView11.Text = "06:39";
                        textView12.Text = "小手指乗換";
                        nexthour = 6;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 22)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:22" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "06:46" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:22";
                        textView11.Text = "06:46";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 22;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 35)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:35" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:03" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "06:35";
                        textView11.Text = "07:03";
                        textView12.Text = "所沢乗換";
                        nexthour = 6;
                        nextmin = 35;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 43)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "06:43";
                        textView11.Text = "07:07";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 5 || hour == 6 && min <= 52)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "06:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:17" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "06:52";
                        textView11.Text = "07:17";
                        textView12.Text = "";
                        nexthour = 6;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 5)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:29" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "07:05";
                        textView11.Text = "07:29";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 14)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "07:14";
                        textView11.Text = "07:43";
                        textView12.Text = "小手指乗換";
                        nexthour = 7;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 25)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:25" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:49" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "07:25";
                        textView11.Text = "07:49";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 25;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 35)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:35" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "07:59" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "07:35";
                        textView11.Text = "07:59";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 35;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 45)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "07:45";
                        textView11.Text = "08:14";
                        textView12.Text = "小手指乗換";
                        nexthour = 7;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 6 || hour == 7 && min <= 52)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "07:52" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:17" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "07:52";
                        textView11.Text = "08:17";
                        textView12.Text = "";
                        nexthour = 7;
                        nextmin = 52;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 2)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:02" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:28" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "08:02";
                        textView11.Text = "08:28";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 2;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 15)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:15" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "08:15";
                        textView11.Text = "08:44";
                        textView12.Text = "小手指乗換";
                        nexthour = 8;
                        nextmin = 15;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 25)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:25" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:52" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "08:25";
                        textView11.Text = "08:52";
                        textView12.Text = "小手指乗換";
                        nexthour = 8;
                        nextmin = 25;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 32)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "08:56" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "08:32";
                        textView11.Text = "08:56";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 43)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:14" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "08:43";
                        textView11.Text = "09:14";
                        textView12.Text = "小手指乗換";
                        nexthour = 8;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 7 || hour == 8 && min <= 54)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "08:54" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:19" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "08:54";
                        textView11.Text = "09:19";
                        textView12.Text = "";
                        nexthour = 8;
                        nextmin = 54;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 6)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:06" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:33" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:06";
                        textView11.Text = "09:33";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 6;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 13)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "09:13";
                        textView11.Text = "09:43";
                        textView12.Text = "小手指乗換";
                        nexthour = 9;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 24)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:24" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "09:24";
                        textView11.Text = "09:48";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 24;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 32)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "09:58" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:32";
                        textView11.Text = "09:58";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "09:48";
                        textView11.Text = "10:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 9;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 8 || hour == 9 && min <= 57)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "09:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:21" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "09:57";
                        textView11.Text = "10:21";
                        textView12.Text = "";
                        nexthour = 9;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "10:09";
                        textView11.Text = "10:38";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "10:18";
                        textView11.Text = "10:48";
                        textView12.Text = "小手指乗換";
                        nexthour = 10;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "10:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "10:28";
                        textView11.Text = "10:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 10;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:38";
                        textView11.Text = "11:07";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "10:48";
                        textView11.Text = "11:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 10;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 9 || hour == 10 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "10:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "10:58";
                        textView11.Text = "11:22";
                        textView12.Text = "";
                        nexthour = 10;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "11:09";
                        textView11.Text = "11:38";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "11:18";
                        textView11.Text = "11:48";
                        textView12.Text = "小手指乗換";
                        nexthour = 11;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "11:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "11:28";
                        textView11.Text = "11:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 11;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:38";
                        textView11.Text = "12:07";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "11:48";
                        textView11.Text = "12:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 11;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 10 || hour == 11 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "11:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "11:58";
                        textView11.Text = "12:22";
                        textView12.Text = "";
                        nexthour = 11;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "12:09";
                        textView11.Text = "12:38";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "12:18";
                        textView11.Text = "12:48";
                        textView12.Text = "小手指乗換";
                        nexthour = 12;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "12:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "12:28";
                        textView11.Text = "12:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 12;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:38";
                        textView11.Text = "13:07";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "12:48";
                        textView11.Text = "13:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 12;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 11 || hour == 12 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "12:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "12:58";
                        textView11.Text = "13:22";
                        textView12.Text = "";
                        nexthour = 12;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "13:09";
                        textView11.Text = "13:38";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "13:18";
                        textView11.Text = "13:48";
                        textView12.Text = "小手指乗換";
                        nexthour = 13;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "13:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "13:28";
                        textView11.Text = "13:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 13;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:38";
                        textView11.Text = "14:07";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "13:48";
                        textView11.Text = "14:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 13;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 12 || hour == 13 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "13:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "13:58";
                        textView11.Text = "14:22";
                        textView12.Text = "";
                        nexthour = 13;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "14:09";
                        textView11.Text = "14:38";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "14:18";
                        textView11.Text = "14:48";
                        textView12.Text = "小手指乗換";
                        nexthour = 14;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "14:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "14:28";
                        textView11.Text = "14:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 14;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:38";
                        textView11.Text = "15:07";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "14:48";
                        textView11.Text = "15:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 14;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 13 || hour == 14 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "14:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "14:58";
                        textView11.Text = "15:22";
                        textView12.Text = "";
                        nexthour = 14;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "15:09";
                        textView11.Text = "15:38";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "15:18";
                        textView11.Text = "15:48";
                        textView12.Text = "小手指乗換";
                        nexthour = 15;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 28)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:28" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "15:55" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "15:28";
                        textView11.Text = "15:55";
                        textView12.Text = "所沢乗換";
                        nexthour = 15;
                        nextmin = 28;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 38)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:38" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:38";
                        textView11.Text = "16:07";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 38;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 48)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:48" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "15:48";
                        textView11.Text = "16:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 15;
                        nextmin = 48;
                        first = false;
                    }
                }
                if (hour <= 14 || hour == 15 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "15:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "15:58";
                        textView11.Text = "16:22";
                        textView12.Text = "";
                        nexthour = 15;
                        nextmin = 58;
                        first = false;
                    }
                }

                if (hour <= 15 || hour == 16 && min <= 9)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:09" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:37" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:09";
                        textView11.Text = "16:37";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 9;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:48" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "16:18";
                        textView11.Text = "16:48";
                        textView12.Text = "小手指乗換";
                        nexthour = 16;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 27)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "16:52" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:27";
                        textView11.Text = "16:52";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 34)
                {
                    textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:34" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:06" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "16:34";
                        textView11.Text = "17:06";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 34;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 45)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:16" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "16:45";
                        textView11.Text = "17:16";
                        textView12.Text = "小手指乗換";
                        nexthour = 16;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 15 || hour == 16 && min <= 56)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "16:56" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "16:56";
                        textView11.Text = "17:22";
                        textView12.Text = "";
                        nexthour = 16;
                        nextmin = 56;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 3)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:03" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "17:03";
                        textView11.Text = "17:38";
                        textView12.Text = "所沢乗換";
                        nexthour = 17;
                        nextmin = 3;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:47" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "17:18";
                        textView11.Text = "17:47";
                        textView12.Text = "小手指乗換";
                        nexthour = 17;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 29)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:29" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "17:53" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:29";
                        textView11.Text = "17:53";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 29;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 35)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:35" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:35";
                        textView11.Text = "18:07";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 35;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 45)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:13" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "17:45";
                        textView11.Text = "18:13";
                        textView12.Text = "所沢乗換";
                        nexthour = 17;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 16 || hour == 17 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "17:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:23" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "17:58";
                        textView11.Text = "18:23";
                        textView12.Text = "";
                        nexthour = 17;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 5)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:05" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:38" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "18:05";
                        textView11.Text = "18:38";
                        textView12.Text = "小手指乗換";
                        nexthour = 18;
                        nextmin = 5;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 18)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:18" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:45" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "18:18";
                        textView11.Text = "18:45";
                        textView12.Text = "所沢乗換";
                        nexthour = 18;
                        nextmin = 18;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 31)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:31" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "18:58" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "18:31";
                        textView11.Text = "18:58";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 31;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 41)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:41" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:07" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "18:41";
                        textView11.Text = "19:07";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 41;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 49)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:49" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:15" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "18:49";
                        textView11.Text = "19:15";
                        textView12.Text = "所沢乗換";
                        nexthour = 18;
                        nextmin = 49;
                        first = false;
                    }
                }
                if (hour <= 17 || hour == 18 && min <= 59)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "18:59" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:23" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "18:59";
                        textView11.Text = "19:23";
                        textView12.Text = "";
                        nexthour = 18;
                        nextmin = 59;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 14)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "19:14";
                        textView11.Text = "19:43";
                        textView12.Text = "所沢乗換";
                        nexthour = 19;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 27)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "19:51" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:27";
                        textView11.Text = "19:51";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 45)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:45" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:13" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "19:45";
                        textView11.Text = "20:13";
                        textView12.Text = "所沢乗換";
                        nexthour = 19;
                        nextmin = 45;
                        first = false;
                    }
                }
                if (hour <= 18 || hour == 19 && min <= 57)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "19:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:21" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "19:57";
                        textView11.Text = "20:21";
                        textView12.Text = "";
                        nexthour = 19;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 15)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:15" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "20:15";
                        textView11.Text = "20:43";
                        textView12.Text = "所沢乗換";
                        nexthour = 20;
                        nextmin = 15;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 27)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:51" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:27";
                        textView11.Text = "20:51";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 46)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:46" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "20:13" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "20:46";
                        textView11.Text = "20:13";
                        textView12.Text = "所沢乗換";
                        nexthour = 20;
                        nextmin = 46;
                        first = false;
                    }
                }
                if (hour <= 19 || hour == 20 && min <= 57)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "20:57" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:21" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "20:57";
                        textView11.Text = "21:21";
                        textView12.Text = "";
                        nexthour = 20;
                        nextmin = 57;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 14)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:14" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:43" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "21:14";
                        textView11.Text = "21:43";
                        textView12.Text = "所沢乗換";
                        nexthour = 21;
                        nextmin = 14;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 27)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:27" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "21:51" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:27";
                        textView11.Text = "21:51";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 27;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 43)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:43" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:11" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "21:43";
                        textView11.Text = "22:11";
                        textView12.Text = "所沢乗換";
                        nexthour = 21;
                        nextmin = 43;
                        first = false;
                    }
                }
                if (hour <= 20 || hour == 21 && min <= 58)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "21:58" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:22" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "21:58";
                        textView11.Text = "22:22";
                        textView12.Text = "";
                        nexthour = 21;
                        nextmin = 58;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 13)
                {
                    textView16.Text = textView16.Text + "急行" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:44" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "急行";
                        textView10.Text = "22:13";
                        textView11.Text = "22:44";
                        textView12.Text = "所沢乗換";
                        nexthour = 22;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 32)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:32" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "22:57" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "22:32";
                        textView11.Text = "22:57";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 32;
                        first = false;
                    }
                }
                if (hour <= 21 || hour == 22 && min <= 53)
                {
                    textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "22:53" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:18" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "快速";
                        textView10.Text = "22:53";
                        textView11.Text = "23:18";
                        textView12.Text = "";
                        nexthour = 22;
                        nextmin = 53;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 13)
                {
                    textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                    textView17.Text = textView17.Text + "23:13" + System.Environment.NewLine;
                    textView18.Text = textView18.Text + "23:37" + System.Environment.NewLine;
                    textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                    if (first == true)
                    {
                        textView9.Text = "準急";
                        textView10.Text = "23:13";
                        textView11.Text = "23:37";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 13;
                        first = false;
                    }
                }
                if (hour <= 22 || hour == 23 && min <= 28)
                {
                    textView16.Text = textView16.Text + "各停";
                    textView17.Text = textView17.Text + "23:28";
                    textView18.Text = textView18.Text + "23:52";
                    textView19.Text = textView19.Text + "";
                    if (first == true)
                    {
                        textView9.Text = "各停";
                        textView10.Text = "23:28";
                        textView11.Text = "23:52";
                        textView12.Text = "";
                        nexthour = 23;
                        nextmin = 28;
                        first = false;
                    }
                }
                else if (hour == 23 && min > 28)
                {
                    textView9.Text = "";
                    textView10.Text = "終";
                    textView11.Text = "電";
                    textView12.Text = "";
                    textView16.Text = "";
                    textView17.Text = "";
                    textView18.Text = "";
                    textView19.Text = "";
                }
            }
        }
    }
}