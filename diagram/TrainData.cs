namespace diagram
{
    public partial class MainActivity
    {
        void Data()
        {
            textView16.Text = "";
            textView17.Text = "";
            textView18.Text = "";
            textView19.Text = "";
            if (initiliz == true || hour == nexthour && min == nextmin + 1)
            {
                if (index1 == 0 && index2 == 0 && index3 == 0)
                {
                    if (hour <= 4 || hour == 5 && min <= 2)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:02" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:10" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "05:02";
                            textView11.Text = "05:10";
                            nexthour = 5;
                            nextmin = 2;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:22" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "05:14";
                            textView11.Text = "05:22";
                            nexthour = 5;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 25)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:25" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:33" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "05:25";
                            textView11.Text = "05:33";
                            nexthour = 5;
                            nextmin = 25;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:48" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "05:40";
                            textView11.Text = "05:48";
                            nexthour = 5;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:56" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "05:47";
                            textView11.Text = "05:56";
                            nexthour = 5;
                            nextmin = 47;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:04" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "05:52";
                            textView11.Text = "06:04";
                            nexthour = 5;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 58)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:58" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:06" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "05:58";
                            textView11.Text = "06:06";
                            nexthour = 5;
                            nextmin = 58;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 2)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:02" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:10" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "06:02";
                            textView11.Text = "06:10";
                            nexthour = 6;
                            nextmin = 2;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:14" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "06:06";
                            textView11.Text = "06:14";
                            nexthour = 6;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 17)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:17" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:26" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "06:17";
                            textView11.Text = "06:26";
                            nexthour = 6;
                            nextmin = 17;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 24)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:24" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:33" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "06:24";
                            textView11.Text = "06:33";
                            nexthour = 6;
                            nextmin = 24;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "06:28";
                            textView11.Text = "06:38";
                            nexthour = 6;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 33)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:33" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:42" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "06:33";
                            textView11.Text = "06:42";
                            nexthour = 6;
                            nextmin = 33;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:45" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "06:36";
                            textView11.Text = "06:45";
                            nexthour = 6;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:51" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "06:39";
                            textView11.Text = "06:51";
                            nexthour = 6;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:56" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "06:47";
                            textView11.Text = "06:56";
                            nexthour = 6;
                            nextmin = 47;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:02" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "06:52";
                            textView11.Text = "07:02";
                            nexthour = 6;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:04" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "06:55";
                            textView11.Text = "07:04";
                            nexthour = 6;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if(hour <= 6 || hour == 7 && min <= 1)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:01" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:10" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:01";
                            textView11.Text = "07:10";
                            nexthour =7;
                            nextmin =1;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 3)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:03" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:14" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:03";
                            textView11.Text = "07:14";
                            nexthour =7;
                            nextmin =3;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:06";
                            textView11.Text = "07:16";
                            nexthour = 7;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:17" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:08";
                            textView11.Text = "07:17";
                            nexthour = 7;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 11)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:11" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:21" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:11";
                            textView11.Text = "07:21";
                            nexthour = 7;
                            nextmin = 11;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 17)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:17" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:26" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:17";
                            textView11.Text = "07:26";
                            nexthour = 7;
                            nextmin = 17;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:30" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:20";
                            textView11.Text = "07:30";
                            nexthour = 7;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:32" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:23";
                            textView11.Text = "07:32";
                            nexthour = 7;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 26)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:26" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:35" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:26";
                            textView11.Text = "07:35";
                            nexthour = 7;
                            nextmin = 26;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 32)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:32" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:41" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:32";
                            textView11.Text = "07:41";
                            nexthour = 7;
                            nextmin = 32;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 35)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:45" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:35";
                            textView11.Text = "07:45";
                            nexthour = 7;
                            nextmin = 35;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:47" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:38";
                            textView11.Text = "07:47";
                            nexthour = 7;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 41)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:51" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:41";
                            textView11.Text = "07:51";
                            nexthour = 7;
                            nextmin = 41;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:56" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:47";
                            textView11.Text = "07:56";
                            nexthour = 7;
                            nextmin = 47;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:50";
                            textView11.Text = "08:01";
                            nexthour = 7;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:02" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:53";
                            textView11.Text = "08:02";
                            nexthour = 7;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 56)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:56" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:06" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "07:56";
                            textView11.Text = "08:06";
                            nexthour = 7;
                            nextmin = 56;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 4)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:04" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:12" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:04";
                            textView11.Text = "08:12";
                            nexthour = 8;
                            nextmin = 4;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:15" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "08:06";
                            textView11.Text = "08:15";
                            nexthour = 8;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 11)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:11" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:20" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "08:11";
                            textView11.Text = "08:20";
                            nexthour = 8;
                            nextmin = 11;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 17)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:17" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:26" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:17";
                            textView11.Text = "08:26";
                            nexthour = 8;
                            nextmin = 17;
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
                    if (hour <= 7 || hour == 8 && min <= 31)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:31" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:40" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:31";
                            textView11.Text = "08:40";
                            nexthour = 8;
                            nextmin = 31;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 35)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:43" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "08:35";
                            textView11.Text = "08:43";
                            nexthour = 8;
                            nextmin = 35;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:47" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "08:38";
                            textView11.Text = "08:47";
                            nexthour = 8;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 46)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:46" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:58" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:46";
                            textView11.Text = "08:58";
                            nexthour = 8;
                            nextmin = 46;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 54)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:54" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:02" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "08:54";
                            textView11.Text = "09:02";
                            nexthour = 8;
                            nextmin = 54;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 1)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:01" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:10" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "09:01";
                            textView11.Text = "09:10";
                            nexthour = 9;
                            nextmin = 1;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "09:08";
                            textView11.Text = "09:16";
                            nexthour = 9;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 16)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:16" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:24" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "09:16";
                            textView11.Text = "09:24";
                            nexthour = 9;
                            nextmin = 16;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:30" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "09:22";
                            textView11.Text = "09:30";
                            nexthour = 9;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "09:30";
                            textView11.Text = "09:38";
                            nexthour = 9;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 33)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:33" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:45" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "09:33";
                            textView11.Text = "09:45";
                            nexthour = 9;
                            nextmin = 33;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 43)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:43" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:52" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "09:43";
                            textView11.Text = "09:52";
                            nexthour = 9;
                            nextmin = 43;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "09:52";
                            textView11.Text = "10:01";
                            nexthour = 9;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "10:00";
                            textView11.Text = "10:08";
                            nexthour = 10;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 3)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:03" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:15" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "10:03";
                            textView11.Text = "10:15";
                            nexthour = 10;
                            nextmin = 3;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 13)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:13" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:22" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "10:13";
                            textView11.Text = "10:22";
                            nexthour = 10;
                            nextmin = 13;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:31" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "10:22";
                            textView11.Text = "10:31";
                            nexthour = 10;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "10:30";
                            textView11.Text = "10:38";
                            nexthour = 10;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 33)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:33" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:45" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "10:33";
                            textView11.Text = "10:45";
                            nexthour = 10;
                            nextmin = 33;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 43)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:43" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:52" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "10:43";
                            textView11.Text = "10:52";
                            nexthour = 10;
                            nextmin = 43;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "10:52";
                            textView11.Text = "11:01";
                            nexthour = 10;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "11:00";
                            textView11.Text = "11:08";
                            nexthour = 11;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "11:08";
                            textView11.Text = "11:16";
                            nexthour = 11;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:23" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "11:15";
                            textView11.Text = "11:23";
                            nexthour = 11;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:31" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "11:22";
                            textView11.Text = "11:31";
                            nexthour = 11;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "11:30";
                            textView11.Text = "11:38";
                            nexthour = 11;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:46" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "11:38";
                            textView11.Text = "11:46";
                            nexthour = 11;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:53" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "11:45";
                            textView11.Text = "11:53";
                            nexthour = 11;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "11:52";
                            textView11.Text = "12:01";
                            nexthour = 11;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "12:00";
                            textView11.Text = "12:08";
                            nexthour = 12;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "12:08";
                            textView11.Text = "12:16";
                            nexthour = 12;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:23" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "12:15";
                            textView11.Text = "12:23";
                            nexthour = 12;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:21" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:31" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "12:22";
                            textView11.Text = "12:31";
                            nexthour = 12;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "12:30";
                            textView11.Text = "12:38";
                            nexthour = 12;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:46" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "12:38";
                            textView11.Text = "12:46";
                            nexthour = 12;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:53" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "12:45";
                            textView11.Text = "12:53";
                            nexthour = 12;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "12:52";
                            textView11.Text = "13:01";
                            nexthour = 12;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "13:00";
                            textView11.Text = "13:08";
                            nexthour = 13;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "13:08";
                            textView11.Text = "13:16";
                            nexthour = 13;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:23" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "13:15";
                            textView11.Text = "13:23";
                            nexthour = 13;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:31" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "13:22";
                            textView11.Text = "13:31";
                            nexthour = 13;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "13:30";
                            textView11.Text = "13:38";
                            nexthour = 13;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:46" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "13:38";
                            textView11.Text = "13:46";
                            nexthour = 13;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:53" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "13:45";
                            textView11.Text = "13:53";
                            nexthour = 13;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "13:52";
                            textView11.Text = "14:01";
                            nexthour = 13;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "14:00";
                            textView11.Text = "14:08";
                            nexthour = 14;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "14:08";
                            textView11.Text = "14:16";
                            nexthour = 14;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:23" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "14:15";
                            textView11.Text = "14:23";
                            nexthour = 14;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:31" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "14:22";
                            textView11.Text = "14:31";
                            nexthour = 14;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "14:30";
                            textView11.Text = "14:38";
                            nexthour = 14;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:46" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "14:38";
                            textView11.Text = "14:46";
                            nexthour = 14;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:53" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "14:45";
                            textView11.Text = "14:53";
                            nexthour = 14;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "14:52";
                            textView11.Text = "15:01";
                            nexthour = 14;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "15:00";
                            textView11.Text = "15:08";
                            nexthour = 15;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:08";
                            textView11.Text = "15:16";
                            nexthour = 15;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:23" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:15";
                            textView11.Text = "15:23";
                            nexthour = 15;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:31" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "15:22";
                            textView11.Text = "15:31";
                            nexthour = 15;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "15:30";
                            textView11.Text = "15:38";
                            nexthour = 15;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 37)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:37" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:46" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:37";
                            textView11.Text = "15:46";
                            nexthour = 15;
                            nextmin = 37;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 42)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:42" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:50" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:42";
                            textView11.Text = "15:50";
                            nexthour = 15;
                            nextmin = 42;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "15:52";
                            textView11.Text = "16:01";
                            nexthour = 15;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "16:00";
                            textView11.Text = "16:08";
                            nexthour = 16;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 7)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:07" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:16" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "16:07";
                            textView11.Text = "16:16";
                            nexthour = 16;
                            nextmin = 7;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 12)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:12" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:20" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "16:12";
                            textView11.Text = "16:20";
                            nexthour = 16;
                            nextmin = 12;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:30" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "16:22";
                            textView11.Text = "16:30";
                            nexthour = 16;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:37" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "16:29";
                            textView11.Text = "16:37";
                            nexthour = 16;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 37)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:37" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:46" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "16:37";
                            textView11.Text = "16:46";
                            nexthour = 16;
                            nextmin = 37;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:52" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "16:44";
                            textView11.Text = "16:52";
                            nexthour = 16;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:01" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "16:52";
                            textView11.Text = "17:01";
                            nexthour = 16;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:08" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "17:00";
                            textView11.Text = "17:08";
                            nexthour = 17;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:18" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "17:08";
                            textView11.Text = "17:18";
                            nexthour = 17;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:22" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "17:14";
                            textView11.Text = "17:22";
                            nexthour = 17;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:25" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "17:22";
                            textView11.Text = "17:25";
                            nexthour = 17;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:39" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "17:29";
                            textView11.Text = "17:39";
                            nexthour = 17;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 33)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:33" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:44" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "17:33";
                            textView11.Text = "17:44";
                            nexthour = 17;
                            nextmin = 33;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:47" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "17:39";
                            textView11.Text = "17:47";
                            nexthour = 17;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:53" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "17:45";
                            textView11.Text = "17:53";
                            nexthour = 17;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 51)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:51" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:00" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "17:51";
                            textView11.Text = "18:00";
                            nexthour = 17;
                            nextmin = 51;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 57)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:57" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:05" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "17:57";
                            textView11.Text = "18:05";
                            nexthour = 17;
                            nextmin = 57;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 2)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:02" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:14" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "18:02";
                            textView11.Text = "18:14";
                            nexthour = 18;
                            nextmin = 2;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 9)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:09" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:17" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:09";
                            textView11.Text = "18:17";
                            nexthour = 18;
                            nextmin = 9;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:22" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "18:14";
                            textView11.Text = "18:22";
                            nexthour = 18;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 21)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:21" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:34" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:21";
                            textView11.Text = "18:34";
                            nexthour = 18;
                            nextmin = 21;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:36" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "18:28";
                            textView11.Text = "18:36";
                            nexthour = 18;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 32)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:32" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:40" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "18:32";
                            textView11.Text = "18:40";
                            nexthour = 18;
                            nextmin = 32;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:47" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:39";
                            textView11.Text = "18:47";
                            nexthour = 18;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:52" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "18:44";
                            textView11.Text = "18:52";
                            nexthour = 18;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 51)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:51" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:59" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "18:51";
                            textView11.Text = "18:59";
                            nexthour = 18;
                            nextmin = 51;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 57)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:57" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:05" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:57";
                            textView11.Text = "19:05";
                            nexthour = 18;
                            nextmin = 57;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 1)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:01" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:09" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "19:01";
                            textView11.Text = "19:09";
                            nexthour = 19;
                            nextmin = 1;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 9)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:09" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:18" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:09";
                            textView11.Text = "19:18";
                            nexthour = 19;
                            nextmin = 9;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:23" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "19:14";
                            textView11.Text = "19:23";
                            nexthour = 19;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 21)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:21" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:34" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:21";
                            textView11.Text = "19:34";
                            nexthour = 19;
                            nextmin = 21;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:36" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "19:28";
                            textView11.Text = "19:36";
                            nexthour = 19;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 32)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:32" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:40" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "19:32";
                            textView11.Text = "19:40";
                            nexthour = 19;
                            nextmin = 32;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:47" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:39";
                            textView11.Text = "19:47";
                            nexthour = 19;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 43)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:43" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:52" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "19:43";
                            textView11.Text = "19:52";
                            nexthour = 19;
                            nextmin = 43;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:04" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:52";
                            textView11.Text = "20:04";
                            nexthour = 19;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 58)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:58" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:07" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "19:58";
                            textView11.Text = "20:07";
                            nexthour = 19;
                            nextmin = 58;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 3)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:03" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:14" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "20:03";
                            textView11.Text = "20:14";
                            nexthour = 20;
                            nextmin = 3;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 9)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:09" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:17" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:09";
                            textView11.Text = "20:17";
                            nexthour = 20;
                            nextmin = 9;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:23" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "20:14";
                            textView11.Text = "20:23";
                            nexthour = 20;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:34" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:22";
                            textView11.Text = "20:34";
                            nexthour = 20;
                            nextmin = 22;
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
                    if (hour <= 19 || hour == 20 && min <= 33)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:33" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:44" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "20:33";
                            textView11.Text = "20:44";
                            nexthour = 20;
                            nextmin = 33;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:47" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:39";
                            textView11.Text = "20:47";
                            nexthour = 20;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:52" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "20:44";
                            textView11.Text = "20:52";
                            nexthour = 20;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 51)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:51" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:04" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "20:51";
                            textView11.Text = "21:04";
                            nexthour = 20;
                            nextmin = 51;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 59)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:07" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:59";
                            textView11.Text = "21:07";
                            nexthour = 20;
                            nextmin = 59;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 3)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:03" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:11" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "21:03";
                            textView11.Text = "21:11";
                            nexthour = 21;
                            nextmin = 3;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:19" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "21:06";
                            textView11.Text = "21:19";
                            nexthour = 21;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 13)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:13" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:22" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "21:13";
                            textView11.Text = "21:22";
                            nexthour = 21;
                            nextmin = 13;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 21)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:21" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:33" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "21:21";
                            textView11.Text = "21:33";
                            nexthour = 21;
                            nextmin = 21;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:37" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "21:28";
                            textView11.Text = "21:37";
                            nexthour = 21;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:47" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "21:39";
                            textView11.Text = "21:47";
                            nexthour = 21;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 42)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:42" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:51" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "21:42";
                            textView11.Text = "21:51";
                            nexthour = 21;
                            nextmin = 42;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:56" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "21:45";
                            textView11.Text = "21:56";
                            nexthour = 21;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:03" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "21:52";
                            textView11.Text = "22:03";
                            nexthour = 21;
                            nextmin = 52;
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
                        textView18.Text = textView18.Text + "22:17" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "22:04";
                            textView11.Text = "22:17";
                            nexthour = 22;
                            nextmin = 4;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 12)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:12" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:21" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "22:12";
                            textView11.Text = "22:21";
                            nexthour = 22;
                            nextmin = 12;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 16)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:16" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:24" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "22:16";
                            textView11.Text = "22:24";
                            nexthour = 22;
                            nextmin = 16;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 21)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:21" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:32" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "22:21";
                            textView11.Text = "22:32";
                            nexthour = 22;
                            nextmin = 21;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:37" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "22:28";
                            textView11.Text = "22:37";
                            nexthour = 22;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 34)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:34" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:43" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "22:34";
                            textView11.Text = "22:43";
                            nexthour = 22;
                            nextmin = 34;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:53" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "22:45";
                            textView11.Text = "22:53";
                            nexthour = 22;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:58" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "22:49";
                            textView11.Text = "22:58";
                            nexthour = 22;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 59)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:07" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "22:59";
                            textView11.Text = "23:07";
                            nexthour = 22;
                            nextmin = 59;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 3)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:03" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:12" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "23:03";
                            textView11.Text = "23:12";
                            nexthour = 23;
                            nextmin = 3;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 9)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:09" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:21" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "23:09";
                            textView11.Text = "23:21";
                            nexthour = 23;
                            nextmin = 9;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 18)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:18" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:28" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "23:18";
                            textView11.Text = "23:28";
                            nexthour = 23;
                            nextmin = 18;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:35" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "23:23";
                            textView11.Text = "23:35";
                            nexthour = 23;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:38" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "23:30";
                            textView11.Text = "23:38";
                            nexthour = 23;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:45" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "23:36";
                            textView11.Text = "23:45";
                            nexthour = 23;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:55" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "23:47";
                            textView11.Text = "23:55";
                            nexthour = 23;
                            nextmin = 47;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 54)
                    {
                        textView16.Text = textView16.Text + "準急";
                        textView17.Text = textView17.Text + "23:54";
                        textView18.Text = textView18.Text + "00:02";
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "23:54";
                            textView11.Text = "00:02";
                            nexthour = 23;
                            nextmin = 54;
                            first = false;
                        }
                    }
                    else if (hour == 23 && min > 54)
                    {
                        textView9.Text = "";
                        textView10.Text = "終";
                        textView11.Text = "電";
                        textView15.Text = "";
                        textView16.Text = "";
                        textView17.Text = "";
                        textView18.Text = "";
                    }
                }
                else if (index1 == 0 && index2 == 0 && index3 == 1)
                {
                    if (hour == 0 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢止まり" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "00:22";
                            textView11.Text = "--:--";
                            textView12.Text = "東所沢止まり";
                            nexthour = 0;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 41)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢止まり" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "00:41";
                            textView11.Text = "--:--";
                            textView12.Text = "東所沢止まり";
                            nexthour = 0;
                            nextmin = 41;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 56)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:56" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢止まり" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "00:56";
                            textView11.Text = "--:--";
                            textView12.Text = "東所沢止まり";
                            nexthour = 0;
                            nextmin = 56;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:29" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "05:19";
                            textView11.Text = "05:29";
                            textView12.Text = "";
                            nexthour = 5;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 35)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:45" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "05:35";
                            textView11.Text = "05:45";
                            textView12.Text = "";
                            nexthour = 5;
                            nextmin = 35;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 52)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:52" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:02" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "05:52";
                            textView11.Text = "06:02";
                            textView12.Text = "";
                            nexthour = 5;
                            nextmin = 52;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 13)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:13" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:23" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:13";
                            textView11.Text = "06:23";
                            textView12.Text = "";
                            nexthour = 6;
                            nextmin = 13;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:29";
                            textView11.Text = "06:40";
                            textView12.Text = "";
                            nexthour = 6;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:49" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:39";
                            textView11.Text = "06:49";
                            textView12.Text = "";
                            nexthour = 6;
                            nextmin = 39;
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
                    if (hour <= 5 || hour == 6 && min <= 56)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:56" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:56";
                            textView11.Text = "07:07";
                            textView12.Text = "";
                            nexthour = 6;
                            nextmin = 56;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 4)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:04" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:15" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:04";
                            textView11.Text = "07:15";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 4;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 12)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:12" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:23" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:12";
                            textView11.Text = "07:23";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 12;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:19";
                            textView11.Text = "07:30";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 25)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:25" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:36" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:25";
                            textView11.Text = "07:36";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 25;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 31)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:31" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:41" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:31";
                            textView11.Text = "07:41";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 31;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:46" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:36";
                            textView11.Text = "07:46";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:51" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:40";
                            textView11.Text = "07:51";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 40;
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
                    if (hour <= 6 || hour == 7 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:49";
                            textView11.Text = "08:00";
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
                    if (hour <= 6 || hour == 7 && min <= 58)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:58" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:09" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:58";
                            textView11.Text = "08:09";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 58;
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
                    if (hour <= 7 || hour == 8 && min <= 7)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:07" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:07";
                            textView11.Text = "08:18";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 7;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 11)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:11" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:22" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:11";
                            textView11.Text = "08:22";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 11;
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
                    if (hour <= 7 || hour == 8 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:23";
                            textView11.Text = "08:34";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 27)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:27" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:38" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:27";
                            textView11.Text = "08:38";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 27;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 32)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:32" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:43" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:32";
                            textView11.Text = "08:43";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 32;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:47" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:36";
                            textView11.Text = "08:47";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:45";
                            textView11.Text = "08:57";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:08" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:50";
                            textView11.Text = "09:08";
                            textView12.Text = "東所沢乗換";
                            nexthour = 8;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 57)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:57" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:08" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:57";
                            textView11.Text = "09:08";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 57;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:06";
                            textView11.Text = "09:17";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:21" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "09:10";
                            textView11.Text = "09:21";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:28" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:14";
                            textView11.Text = "09:28";
                            textView12.Text = "東所沢乗換";
                            nexthour = 9;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 18)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:18" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:28" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:18";
                            textView11.Text = "09:28";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 18;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 26)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:26" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:36" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:26";
                            textView11.Text = "09:36";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 26;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:46" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:30";
                            textView11.Text = "09:46";
                            textView12.Text = "東所沢乗換";
                            nexthour = 9;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:46" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:36";
                            textView11.Text = "09:46";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:45";
                            textView11.Text = "09:56";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:06" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:49";
                            textView11.Text = "10:06";
                            textView12.Text = "東所沢乗換";
                            nexthour = 9;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:06" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:55";
                            textView11.Text = "10:06";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 3)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:03" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:03";
                            textView11.Text = "10:18";
                            textView12.Text = "東所沢乗換";
                            nexthour = 10;
                            nextmin = 3;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 7)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:07" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:07";
                            textView11.Text = "10:18";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 7;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 13)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:13" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:29" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:13";
                            textView11.Text = "10:29";
                            textView12.Text = "東所沢乗換";
                            nexthour = 10;
                            nextmin = 13;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:29" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:19";
                            textView11.Text = "10:29";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:30";
                            textView11.Text = "10:40";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 34)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:34" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:51" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:34";
                            textView11.Text = "10:51";
                            textView12.Text = "東所沢乗換";
                            nexthour = 10;
                            nextmin = 34;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 41)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:51" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:41";
                            textView11.Text = "10:51";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 41;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:50";
                            textView11.Text = "11:00";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:00";
                            textView11.Text = "11:10";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:20" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:10";
                            textView11.Text = "11:20";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:20";
                            textView11.Text = "11:30";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:30";
                            textView11.Text = "11:40";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:40";
                            textView11.Text = "11:50";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:50";
                            textView11.Text = "12:00";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:00";
                            textView11.Text = "12:10";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:20" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:10";
                            textView11.Text = "12:20";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:20";
                            textView11.Text = "12:30";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:30";
                            textView11.Text = "12:40";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:40";
                            textView11.Text = "12:50";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:50";
                            textView11.Text = "13:00";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:00";
                            textView11.Text = "13:10";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:20" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:10";
                            textView11.Text = "13:20";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:20";
                            textView11.Text = "13:30";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:30";
                            textView11.Text = "13:40";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:40";
                            textView11.Text = "13:50";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:50";
                            textView11.Text = "14:00";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:00";
                            textView11.Text = "14:10";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:20" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:10";
                            textView11.Text = "14:20";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:20";
                            textView11.Text = "14:30";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:30";
                            textView11.Text = "14:40";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:40";
                            textView11.Text = "14:50";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:50";
                            textView11.Text = "15:00";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:00";
                            textView11.Text = "15:10";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:20" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:10";
                            textView11.Text = "15:20";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:20";
                            textView11.Text = "15:30";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:30";
                            textView11.Text = "15:40";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:40";
                            textView11.Text = "15:50";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:50";
                            textView11.Text = "16:00";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:00";
                            textView11.Text = "16:10";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:20" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:10";
                            textView11.Text = "16:20";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:30" + System.Environment.NewLine;
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
                    if (hour <= 15 || hour == 16 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:30";
                            textView11.Text = "16:40";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:40";
                            textView11.Text = "16:50";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:50";
                            textView11.Text = "17:00";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:00";
                            textView11.Text = "17:10";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:20" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:10";
                            textView11.Text = "17:20";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:20";
                            textView11.Text = "17:30";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 32)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:32" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:42" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:32";
                            textView11.Text = "17:42";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 32;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 43)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:43" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:53" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:43";
                            textView11.Text = "17:53";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 43;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 50)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:50" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:50";
                            textView11.Text = "18:00";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 50;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 58)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:58" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:09" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:58";
                            textView11.Text = "18:09";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 58;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:06";
                            textView11.Text = "18:17";
                            textView12.Text = "";
                            nexthour = 18;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:25" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:15";
                            textView11.Text = "18:25";
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
                        textView18.Text = textView18.Text + "18:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:24";
                            textView11.Text = "18:34";
                            textView12.Text = "";
                            nexthour = 18;
                            nextmin = 24;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 34)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:34" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:34";
                            textView11.Text = "18:44";
                            textView12.Text = "";
                            nexthour = 18;
                            nextmin = 34;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:51" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:40";
                            textView11.Text = "18:51";
                            textView12.Text = "";
                            nexthour = 18;
                            nextmin = 40;
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
                    if (hour <= 17 || hour == 18 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:06" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:55";
                            textView11.Text = "19:06";
                            textView12.Text = "";
                            nexthour = 18;
                            nextmin = 55;
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
                    if (hour <= 18 || hour == 19 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "19:08";
                            textView11.Text = "19:18";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 8;
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
                    if (hour <= 18 || hour == 19 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:31" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:20";
                            textView11.Text = "19:31";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:29";
                            textView11.Text = "19:40";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:48" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:38";
                            textView11.Text = "19:48";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 46)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:46" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:46";
                            textView11.Text = "19:57";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 46;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 51)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:51" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:51";
                            textView11.Text = "20:07";
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
                        textView18.Text = textView18.Text + "20:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:56";
                            textView11.Text = "20:07";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 56;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:06";
                            textView11.Text = "20:17";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:25" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:15";
                            textView11.Text = "20:25";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 25)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:25" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:25";
                            textView11.Text = "20:35";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 25;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 35)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:45" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:35";
                            textView11.Text = "20:45";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 35;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 43)
                    {
                        textView16.Text = textView16.Text + "普通" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:43" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:53" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "普通";
                            textView10.Text = "20:43";
                            textView11.Text = "20:53";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 43;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:58" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:47";
                            textView11.Text = "20:58";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 47;
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
                    if (hour <= 20 || hour == 21 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:19" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:08";
                            textView11.Text = "21:19";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:30" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:20";
                            textView11.Text = "21:30";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:39" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:29";
                            textView11.Text = "21:39";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 37)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:37" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:48" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:37";
                            textView11.Text = "21:48";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 37;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 43)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:43" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:54" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:43";
                            textView11.Text = "21:54";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 43;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:53";
                            textView11.Text = "22:04";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:06";
                            textView11.Text = "22:17";
                            textView12.Text = "";
                            nexthour = 22;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 16)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:16" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:16";
                            textView11.Text = "22:27";
                            textView12.Text = "";
                            nexthour = 22;
                            nextmin = 16;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:29";
                            textView11.Text = "22:40";
                            textView12.Text = "";
                            nexthour = 22;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 41)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:52" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:41";
                            textView11.Text = "22:52";
                            textView12.Text = "";
                            nexthour = 22;
                            nextmin = 41;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 54)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:54" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:54";
                            textView11.Text = "23:04";
                            textView12.Text = "";
                            nexthour = 22;
                            nextmin = 54;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:06";
                            textView11.Text = "23:26";
                            textView12.Text = "東所沢乗換";
                            nexthour = 23;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 16)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:16" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:16";
                            textView11.Text = "23:26";
                            textView12.Text = "";
                            nexthour = 23;
                            nextmin = 16;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:30";
                            textView11.Text = "23:40";
                            textView12.Text = "";
                            nexthour = 23;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 46)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:46" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:46";
                            textView11.Text = "23:57";
                            textView12.Text = "";
                            nexthour = 23;
                            nextmin = 46;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 59)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:59";
                            textView11.Text = "00:10";
                            textView12.Text = "";
                            nexthour = 23;
                            nextmin = 59;
                            first = false;
                        }
                    }
                    if (hour != 0 && hour <= 24)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢止まり" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "東所沢止まり" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "各停";
                        textView17.Text = textView17.Text + "00:56";
                        textView18.Text = textView18.Text + "--:--";
                        textView19.Text = textView19.Text + "東所沢止まり";
                    }
                }
                else if (index1 == 0 && index2 == 0 && index3 == 2)
                {
                    if (hour == 0 && min <= 1)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:01" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "00:01";
                            textView11.Text = "00:35";
                            textView12.Text = "小手指乗換";
                            nexthour = 0;
                            nextmin = 1;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "00:10";
                            textView11.Text = "00:35";
                            textView12.Text = "";
                            nexthour = 0;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 20)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "00:20";
                            textView11.Text = "00:50";
                            textView12.Text = "";
                            nexthour = 0;
                            nextmin = 20;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 27)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:27" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "01:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "00:27";
                            textView11.Text = "01:00";
                            textView12.Text = "小手指乗換";
                            nexthour = 0;
                            nextmin = 27;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 35)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "01:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "00:35";
                            textView11.Text = "01:00";
                            textView12.Text = "";
                            nexthour = 0;
                            nextmin = 35;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 41)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指止まり" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "00:41";
                            textView11.Text = "--:--";
                            textView12.Text = "小手指止まり";
                            nexthour = 0;
                            nextmin = 41;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指止まり" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "00:49";
                            textView11.Text = "--:--";
                            textView12.Text = "小手指止まり";
                            nexthour = 0;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour == 0 && min <= 59)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指止まり" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "00:59";
                            textView11.Text = "--:--";
                            textView12.Text = "小手指止まり";
                            nexthour = 0;
                            nextmin = 59;
                            first = false;
                        }
                    }
                    if (hour <= 0 || hour == 1 && min <= 10)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "01:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指止まり" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "01:10";
                            textView11.Text = "--:--";
                            textView12.Text = "小手指止まり";
                            nexthour = 1;
                            nextmin = 10;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 2)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:02" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "05:02";
                            textView11.Text = "05:26";
                            textView12.Text = "";
                            nexthour = 5;
                            nextmin = 2;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 31)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:31" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "05:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "05:31";
                            textView11.Text = "05:56";
                            textView12.Text = "小手指乗換";
                            nexthour = 5;
                            nextmin = 31;
                            first = false;
                        }
                    }
                    if (hour <= 4 || hour == 5 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "05:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:12" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "05:47";
                            textView11.Text = "06:12";
                            textView12.Text = "";
                            nexthour = 5;
                            nextmin = 47;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 4)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:04" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:29" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "06:04";
                            textView11.Text = "06:29";
                            textView12.Text = "";
                            nexthour = 6;
                            nextmin = 4;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:43" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:14";
                            textView11.Text = "06:43";
                            textView12.Text = "小手指乗換";
                            nexthour = 6;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:22";
                            textView11.Text = "06:57";
                            textView12.Text = "小手指乗換";
                            nexthour = 6;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "06:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "06:29";
                            textView11.Text = "06:57";
                            textView12.Text = "";
                            nexthour = 6;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:36";
                            textView11.Text = "07:14";
                            textView12.Text = "小手指乗換";
                            nexthour = 6;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "06:47";
                            textView11.Text = "07:14";
                            textView12.Text = "";
                            nexthour = 6;
                            nextmin = 47;
                            first = false;
                        }
                    }
                    if (hour <= 5 || hour == 6 && min <= 54)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "06:54" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "06:54";
                            textView11.Text = "07:27";
                            textView12.Text = "小手指乗換";
                            nexthour = 6;
                            nextmin = 54;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 3)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:03" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:03";
                            textView11.Text = "07:27";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 3;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 12)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:12" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:36" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:12";
                            textView11.Text = "07:36";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 12;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 18)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:18" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:18";
                            textView11.Text = "07:44";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 18;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:23";
                            textView11.Text = "07:56";
                            textView12.Text = "小手指乗換";
                            nexthour = 7;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "07:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:28";
                            textView11.Text = "07:56";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 35)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:35";
                            textView11.Text = "08:07";
                            textView12.Text = "小手指乗換";
                            nexthour = 7;
                            nextmin = 35;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 41)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:41";
                            textView11.Text = "08:07";
                            textView12.Text = "";
                            nexthour = 7;
                            nextmin = 41;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 46)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:46" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:16" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:46";
                            textView11.Text = "08:16";
                            textView12.Text = "小手指乗換";
                            nexthour = 7;
                            nextmin = 46;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 54)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:54" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "07:54";
                            textView11.Text = "08:26";
                            textView12.Text = "小手指乗換";
                            nexthour = 7;
                            nextmin = 54;
                            first = false;
                        }
                    }
                    if (hour <= 6 || hour == 7 && min <= 58)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "07:58" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "07:58";
                            textView11.Text = "08:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 7;
                            nextmin = 58;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 4)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:04" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:36" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:04";
                            textView11.Text = "08:36";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 4;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:36" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:08";
                            textView11.Text = "08:36";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 13)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:13" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:46" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:13";
                            textView11.Text = "08:46";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 13;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 17)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:17" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:46" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:17";
                            textView11.Text = "08:46";
                            textView12.Text = "所沢乗換";
                            nexthour = 8;
                            nextmin = 17;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:23";
                            textView11.Text = "08:56";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 26)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:26" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:26";
                            textView11.Text = "08:56";
                            textView12.Text = "";
                            nexthour = 8;
                            nextmin = 26;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "08:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:29";
                            textView11.Text = "08:56";
                            textView12.Text = "所沢乗換";
                            nexthour = 8;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 34)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:34" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:06" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:34";
                            textView11.Text = "09:06";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 34;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 38)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:38" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:06" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:38";
                            textView11.Text = "09:06";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 38;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:44";
                            textView11.Text = "09:18";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 47)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:47" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:47";
                            textView11.Text = "09:18";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 47;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 54)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:54" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "08:54";
                            textView11.Text = "09:26";
                            textView12.Text = "小手指乗換";
                            nexthour = 8;
                            nextmin = 54;
                            first = false;
                        }
                    }
                    if (hour <= 7 || hour == 8 && min <= 57)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "08:57" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "08:57";
                            textView11.Text = "09:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 8;
                            nextmin = 57;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 2)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:02" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "09:02";
                            textView11.Text = "09:35";
                            textView12.Text = "小手指乗換";
                            nexthour = 9;
                            nextmin = 2;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 5)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:05" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:05";
                            textView11.Text = "09:35";
                            textView12.Text = "小手指乗換";
                            nexthour = 9;
                            nextmin = 5;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 8)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:08" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:08";
                            textView11.Text = "09:35";
                            textView12.Text = "所沢乗換";
                            nexthour = 9;
                            nextmin = 8;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 13)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:13" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:13";
                            textView11.Text = "09:44";
                            textView12.Text = "小手指乗換";
                            nexthour = 9;
                            nextmin = 13;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 18)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:18" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:18";
                            textView11.Text = "09:44";
                            textView12.Text = "小手指乗換";
                            nexthour = 9;
                            nextmin = 18;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 25)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:25" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "09:54" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "09:25";
                            textView11.Text = "09:54";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 25;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 30)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:30" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:30";
                            textView11.Text = "10:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 9;
                            nextmin = 30;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:36";
                            textView11.Text = "10:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 9;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:39";
                            textView11.Text = "10:04";
                            textView12.Text = "所沢乗換";
                            nexthour = 9;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "09:44";
                            textView11.Text = "10:14";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:31" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "09:53";
                            textView11.Text = "10:31";
                            textView12.Text = "所沢乗換";
                            nexthour = 9;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 8 || hour == 9 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "09:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "09:55";
                            textView11.Text = "10:27";
                            textView12.Text = "";
                            nexthour = 9;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 5)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:05" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:05";
                            textView11.Text = "10:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 10;
                            nextmin = 5;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "10:14";
                            textView11.Text = "10:44";
                            textView12.Text = "小手指乗換";
                            nexthour = 10;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:55" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "西所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:23";
                            textView11.Text = "10:55";
                            textView12.Text = "西所沢乗換";
                            nexthour = 10;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:55" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:28";
                            textView11.Text = "10:55";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:36";
                            textView11.Text = "11:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 10;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "10:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "10:44";
                            textView11.Text = "10:14";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "10:53";
                            textView11.Text = "11:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 10;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 9 || hour == 10 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "10:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "10:55";
                            textView11.Text = "11:26";
                            textView12.Text = "";
                            nexthour = 10;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:06";
                            textView11.Text = "11:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 11;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "11:14";
                            textView11.Text = "11:44";
                            textView12.Text = "所沢乗換";
                            nexthour = 11;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "西所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:23";
                            textView11.Text = "11:57";
                            textView12.Text = "西所沢乗換";
                            nexthour = 11;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "11:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:28";
                            textView11.Text = "11:57";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:36";
                            textView11.Text = "12:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 11;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "11:44";
                            textView11.Text = "12:14";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:16" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "11:53";
                            textView11.Text = "12:16";
                            textView12.Text = "所沢乗換";
                            nexthour = 11;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 10 || hour == 11 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "11:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "11:55";
                            textView11.Text = "12:26";
                            textView12.Text = "";
                            nexthour = 11;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:06";
                            textView11.Text = "12:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 12;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "12:14";
                            textView11.Text = "12:44";
                            textView12.Text = "所沢乗換";
                            nexthour = 12;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "西所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:23";
                            textView11.Text = "12:57";
                            textView12.Text = "西所沢乗換";
                            nexthour = 12;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "12:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:28";
                            textView11.Text = "12:57";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:36";
                            textView11.Text = "13:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 12;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "12:44";
                            textView11.Text = "13:14";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "12:53";
                            textView11.Text = "13:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 12;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 11 || hour == 12 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "12:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "12:55";
                            textView11.Text = "13:26";
                            textView12.Text = "";
                            nexthour = 12;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:06";
                            textView11.Text = "13:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 13;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "13:14";
                            textView11.Text = "13:44";
                            textView12.Text = "所沢乗換";
                            nexthour = 13;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "西所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:23";
                            textView11.Text = "13:56";
                            textView12.Text = "西所沢乗換";
                            nexthour = 13;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "13:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:28";
                            textView11.Text = "13:56";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:36";
                            textView11.Text = "14:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 13;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "13:44";
                            textView11.Text = "14:14";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "13:53";
                            textView11.Text = "14:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 13;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 12 || hour == 13 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "13:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "13:55";
                            textView11.Text = "14:26";
                            textView12.Text = "";
                            nexthour = 13;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:06";
                            textView11.Text = "14:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 14;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "14:14";
                            textView11.Text = "14:44";
                            textView12.Text = "所沢乗換";
                            nexthour = 14;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "西所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:23";
                            textView11.Text = "14:57";
                            textView12.Text = "西所沢乗換";
                            nexthour = 14;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "14:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:28";
                            textView11.Text = "14:57";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:36";
                            textView11.Text = "15:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 14;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "14:44";
                            textView11.Text = "15:14";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "14:53";
                            textView11.Text = "15:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 14;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 13 || hour == 14 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "14:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "14:55";
                            textView11.Text = "15:26";
                            textView12.Text = "";
                            nexthour = 14;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:06";
                            textView11.Text = "15:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 15;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:14";
                            textView11.Text = "15:44";
                            textView12.Text = "所沢乗換";
                            nexthour = 15;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "西所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:23";
                            textView11.Text = "15:56";
                            textView12.Text = "西所沢乗換";
                            nexthour = 15;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "15:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:28";
                            textView11.Text = "15:56";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:36";
                            textView11.Text = "16:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 15;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:44";
                            textView11.Text = "16:14";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "15:53";
                            textView11.Text = "16:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 15;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 14 || hour == 15 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "15:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "15:55";
                            textView11.Text = "16:26";
                            textView12.Text = "";
                            nexthour = 15;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:06";
                            textView11.Text = "16:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 16;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "16:14";
                            textView11.Text = "16:44";
                            textView12.Text = "所沢乗換";
                            nexthour = 16;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "西所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:23";
                            textView11.Text = "16:56";
                            textView12.Text = "西所沢乗換";
                            nexthour = 16;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 28)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:28" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "16:56" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:28";
                            textView11.Text = "16:56";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 28;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:36";
                            textView11.Text = "17:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 16;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 44)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:44" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:14" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "16:44";
                            textView11.Text = "17:14";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 44;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "16:53";
                            textView11.Text = "17:26";
                            textView12.Text = "所沢乗換";
                            nexthour = 16;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 15 || hour == 16 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "16:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:26" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "16:55";
                            textView11.Text = "17:26";
                            textView12.Text = "";
                            nexthour = 16;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:34" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:06";
                            textView11.Text = "17:34";
                            textView12.Text = "小手指乗換";
                            nexthour = 17;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:44" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "17:14";
                            textView11.Text = "17:44";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 23)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:23" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:55" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:23";
                            textView11.Text = "17:55";
                            textView12.Text = "所沢乗換";
                            nexthour = 17;
                            nextmin = 23;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "17:55" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "17:29";
                            textView11.Text = "17:55";
                            textView12.Text = "所沢乗換";
                            nexthour = 17;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 35)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:35";
                            textView11.Text = "18:04";
                            textView12.Text = "小手指乗換";
                            nexthour = 17;
                            nextmin = 35;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 39)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:39" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:04" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:39";
                            textView11.Text = "18:04";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 39;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 46)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:46" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:16" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "17:46";
                            textView11.Text = "18:16";
                            textView12.Text = "小手指乗換";
                            nexthour = 17;
                            nextmin = 46;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:16" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "17:49";
                            textView11.Text = "18:16";
                            textView12.Text = "";
                            nexthour = 17;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 54)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:54" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢、小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:54";
                            textView11.Text = "18:27";
                            textView12.Text = "所沢、小手指乗換";
                            nexthour = 17;
                            nextmin = 54;
                            first = false;
                        }
                    }
                    if (hour <= 16 || hour == 17 && min <= 59)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "17:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "17:59";
                            textView11.Text = "18:27";
                            textView12.Text = "小手指乗換";
                            nexthour = 17;
                            nextmin = 59;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:06";
                            textView11.Text = "18:27";
                            textView12.Text = "小手指乗換";
                            nexthour = 18;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:47" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:15";
                            textView11.Text = "18:47";
                            textView12.Text = "小手指乗換";
                            nexthour = 18;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:47" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:19";
                            textView11.Text = "18:47";
                            textView12.Text = "";
                            nexthour = 18;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 25)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:25" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢、小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:25";
                            textView11.Text = "18:57";
                            textView12.Text = "所沢、小手指乗換";
                            nexthour = 18;
                            nextmin = 25;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "18:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "18:29";
                            textView11.Text = "18:57";
                            textView12.Text = "小手指乗換";
                            nexthour = 18;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:36";
                            textView11.Text = "19:07";
                            textView12.Text = "小手指乗換";
                            nexthour = 18;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:45";
                            textView11.Text = "19:17";
                            textView12.Text = "小手指乗換";
                            nexthour = 18;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "18:49";
                            textView11.Text = "19:17";
                            textView12.Text = "";
                            nexthour = 18;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢、小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "18:55";
                            textView11.Text = "19:27";
                            textView12.Text = "所沢、小手指乗換";
                            nexthour = 18;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 17 || hour == 18 && min <= 59)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "18:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "18:59";
                            textView11.Text = "19:27";
                            textView12.Text = "小手指乗換";
                            nexthour = 18;
                            nextmin = 59;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:37" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:06";
                            textView11.Text = "19:37";
                            textView12.Text = "小手指乗換";
                            nexthour = 19;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:47" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:15";
                            textView11.Text = "19:47";
                            textView12.Text = "小手指乗換";
                            nexthour = 19;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:47" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:19";
                            textView11.Text = "19:47";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 25)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:25" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢、小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:25";
                            textView11.Text = "19:57";
                            textView12.Text = "所沢、小手指乗換";
                            nexthour = 19;
                            nextmin = 25;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "19:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "19:29";
                            textView11.Text = "19:57";
                            textView12.Text = "小手指乗換";
                            nexthour = 19;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:36";
                            textView11.Text = "20:07";
                            textView12.Text = "小手指乗換";
                            nexthour = 19;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:45";
                            textView11.Text = "20:17";
                            textView12.Text = "小手指乗換";
                            nexthour = 19;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "19:49";
                            textView11.Text = "20:17";
                            textView12.Text = "";
                            nexthour = 19;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 55)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:55" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢、小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "19:55";
                            textView11.Text = "20:27";
                            textView12.Text = "所沢、小手指乗換";
                            nexthour = 19;
                            nextmin = 55;
                            first = false;
                        }
                    }
                    if (hour <= 18 || hour == 19 && min <= 59)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "19:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "19:59";
                            textView11.Text = "20:27";
                            textView12.Text = "小手指乗換";
                            nexthour = 19;
                            nextmin = 59;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:37" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:06";
                            textView11.Text = "20:37";
                            textView12.Text = "小手指乗換";
                            nexthour = 20;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:47" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:15";
                            textView11.Text = "20:47";
                            textView12.Text = "小手指乗換";
                            nexthour = 20;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:47" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:19";
                            textView11.Text = "20:47";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 25)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:25" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢、小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:25";
                            textView11.Text = "20:57";
                            textView12.Text = "所沢、小手指乗換";
                            nexthour = 20;
                            nextmin = 25;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "20:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "20:29";
                            textView11.Text = "20:57";
                            textView12.Text = "小手指乗換";
                            nexthour = 20;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:36";
                            textView11.Text = "21:07";
                            textView12.Text = "小手指乗換";
                            nexthour = 20;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:45";
                            textView11.Text = "21:17";
                            textView12.Text = "小手指乗換";
                            nexthour = 20;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:17" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "20:49";
                            textView11.Text = "21:17";
                            textView12.Text = "";
                            nexthour = 20;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour <= 19 || hour == 20 && min <= 58)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "20:58" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "20:58";
                            textView11.Text = "21:27";
                            textView12.Text = "小手指乗換";
                            nexthour = 20;
                            nextmin = 58;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:37" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "21:06";
                            textView11.Text = "21:37";
                            textView12.Text = "小手指乗換";
                            nexthour = 21;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:48" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "21:15";
                            textView11.Text = "21:48";
                            textView12.Text = "小手指乗換";
                            nexthour = 21;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:48" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:19";
                            textView11.Text = "21:48";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 27)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:27" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "21:58" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "21:27";
                            textView11.Text = "21:58";
                            textView12.Text = "小手指乗換";
                            nexthour = 21;
                            nextmin = 27;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:07" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "21:36";
                            textView11.Text = "22:07";
                            textView12.Text = "小手指乗換";
                            nexthour = 21;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "21:45";
                            textView11.Text = "22:18";
                            textView12.Text = "小手指乗換";
                            nexthour = 21;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 49)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:18" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "21:49";
                            textView11.Text = "22:18";
                            textView12.Text = "";
                            nexthour = 21;
                            nextmin = 49;
                            first = false;
                        }
                    }
                    if (hour <= 20 || hour == 21 && min <= 57)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "21:57" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:27" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "21:57";
                            textView11.Text = "22:27";
                            textView12.Text = "小手指乗換";
                            nexthour = 21;
                            nextmin = 57;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 6)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:06" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:37" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "22:06";
                            textView11.Text = "22:37";
                            textView12.Text = "小手指乗換";
                            nexthour = 22;
                            nextmin = 6;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 14)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:14" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:48" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:14";
                            textView11.Text = "22:48";
                            textView12.Text = "小手指乗換";
                            nexthour = 22;
                            nextmin = 14;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 19)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:19" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:48" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "22:19";
                            textView11.Text = "22:48";
                            textView12.Text = "";
                            nexthour = 22;
                            nextmin = 19;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 27)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:27" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "22:57" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:27";
                            textView11.Text = "22:57";
                            textView12.Text = "小手指乗換";
                            nexthour = 22;
                            nextmin = 27;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 36)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:36" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:10" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "22:36";
                            textView11.Text = "23:10";
                            textView12.Text = "小手指乗換";
                            nexthour = 22;
                            nextmin = 36;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 45)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:45" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:22" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:45";
                            textView11.Text = "23:22";
                            textView12.Text = "小手指乗換";
                            nexthour = 22;
                            nextmin = 45;
                            first = false;
                        }
                    }
                    if (hour <= 21 || hour == 22 && min <= 53)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "22:53" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:22" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "22:53";
                            textView11.Text = "23:22";
                            textView12.Text = "所沢乗換";
                            nexthour = 22;
                            nextmin = 53;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 0)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:00" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:00";
                            textView11.Text = "23:40";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 0;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 7)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:07" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:40" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "23:07";
                            textView11.Text = "23:40";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 7;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 15)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:15" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:59" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:15";
                            textView11.Text = "23:59";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 15;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 22)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:22" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:59" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:22";
                            textView11.Text = "23:59";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 22;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 29)
                    {
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:29" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "23:59" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "準急";
                            textView10.Text = "23:29";
                            textView11.Text = "23:59";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 29;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 37)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:37" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:19" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "所沢、小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:37";
                            textView11.Text = "00:19";
                            textView12.Text = "所沢、小手指乗換";
                            nexthour = 23;
                            nextmin = 37;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 40)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:40" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:19" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:40";
                            textView11.Text = "00:19";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 40;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 46)
                    {
                        textView16.Text = textView16.Text + "快速" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:46" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:19" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "快速";
                            textView10.Text = "23:46";
                            textView11.Text = "00:19";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 46;
                            first = false;
                        }
                    }
                    if (hour <= 22 || hour == 23 && min <= 56)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "23:56" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        if (first == true)
                        {
                            textView9.Text = "各停";
                            textView10.Text = "23:56";
                            textView11.Text = "00:35";
                            textView12.Text = "小手指乗換";
                            nexthour = 23;
                            nextmin = 56;
                            first = false;
                        }
                    }
                    if (hour != 0 && hour != 1 && hour <= 24)
                    {
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:01" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:10" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:35" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:20" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "00:50" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:27" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "01:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指乗換" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:35" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "01:00" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:41" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指止まり" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "各停" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:49" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指止まり" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "準急" + System.Environment.NewLine;
                        textView17.Text = textView17.Text + "00:59" + System.Environment.NewLine;
                        textView18.Text = textView18.Text + "--:--" + System.Environment.NewLine;
                        textView19.Text = textView19.Text + "小手指止まり" + System.Environment.NewLine;
                        textView16.Text = textView16.Text + "準急";
                        textView17.Text = textView17.Text + "01:10";
                        textView18.Text = textView18.Text + "--:--";
                        textView19.Text = textView19.Text + "小手指止まり";
                    }
                }
                else if (index1 == 0 && index2 == 1 && index3 == 0) { }
                else if (index1 == 0 && index2 == 1 && index3 == 1) { }
                else if (index1 == 0 && index2 == 1 && index3 == 2) { }
                else if (index1 == 1 && index2 == 0 && index3 == 0)
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
                    if (hour != 0 && hour != 1 && min <= 24)
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
                else if (index1 == 1 && index2 == 0 && index3 == 1) { }
                else if (index1 == 1 && index2 == 0 && index3 == 2) { }
                else if (index1 == 1 && index2 == 1 && index3 == 0) { }
                else if (index1 == 1 && index2 == 1 && index3 == 1) { }
                else if (index1 == 1 && index2 == 1 && index3 == 2) { }
                first = true;
                NextTime();
            }
        }
    }
}