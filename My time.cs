using System;

public class MyTime
{
    private int _hour;
    private int _minute;
    private int _second;

    public MyTime()
    {
        _hour = 0;
        _minute = 0;
        _second = 0;
    }

    public MyTime(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
    }

    public void SetTime(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
    }

    public void SetHour(int hour)
    {
        try
        {
            if (!(hour >= 0 && hour <= 24))
            {
                throw new ArgumentException("INVALID HOUR!");
            }
            else
            {
                _hour = hour;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void SetMinute(int minute)
    {
        try
        {
            if (!(minute >= 0 && minute <= 59))
            {
                throw new ArgumentException("INVALID MINUTES!");
            }
            else
            {
                _minute = minute;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void SetSecond(int second)
    {
        try
        {
            if (!(second >= 0 && second <= 59))
            {
                throw new ArgumentException("INVALID SECONDS!");
            }
            else
            {
                _second = second;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public int GetHour()
    {
        return _hour;
    }

    public int GetMinute()
    {
        return _minute;
    }

    public int GetSecond()
    {
        return _second;
    }

    public string toString()
    {
        string ans = "";
        if (_hour < 10)
            ans += "0";
        ans += (_hour.ToString()) + ":";
        if (_minute < 10)
            ans += "0";
        ans += (_minute.ToString()) + ":";
        if (_second < 10)
            ans += "0";
        ans += (_second.ToString());

        return ans;

    }
    public MyTime NextSecond()
    {

        if (_second < 59)
        {
            _second += 1;

        }
        else
        {
            _second = 0;
            NextMinute();
        }

        return this;

    }
    public MyTime NextMinute()
    {
        if (_minute < 59)
        {
            _minute += 1;

        }
        else
        {
            _minute = 0;
            NextHour();
        }


        return this;
    }
    public MyTime NextHour()
    {
        if (_hour == 23)
        {
            _hour = 0;
        }
        else

            _hour += 1;
        return this;
    }
    public MyTime PreviousSecond()
    {
        if (_second == 0)
        {
            _second = 59;
            PreviousMinute();
        }
        else
        {
            _second -= 1;
        }
        return this;
    }

    public MyTime PreviousMinute()
    {
        if (_minute == 0)
        {
            _minute = 59;
            PreviousHour();
        }
        else
        {
            _minute -= 1;
        }
        return this;
    }
    public MyTime PreviousHour()
    {
        if (_hour == 0)
            _hour = 23;
        else
        {
            _hour -= 1;
        }
        return this;
    }

}
