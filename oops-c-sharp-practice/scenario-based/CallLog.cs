using System;

class CallLog{
    public string PhoneNumber;
    public string Message;
    public DateTime Time;
}

class CallLogManager{
    CallLog[] logs = new CallLog[50];
    int size = 0;

    public void AddCallLog(string phone, string msg, DateTime time)
    {
        if (size < logs.Length)
        {
            logs[size] = new CallLog();
            logs[size].PhoneNumber = phone;
            logs[size].Message = msg;
            logs[size].Time = time;
            size++;
        }
        else
        {
            Console.WriteLine("Log storage full");
        }
    }

    public void SearchByKeyword(string keyword)
    {
        for (int i = 0; i < size; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                Print(logs[i]);
            }
        }
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        for (int i = 0; i < size; i++)
        {
            if (logs[i].Time >= start && logs[i].Time <= end)
            {
                Print(logs[i]);
            }
        }
    }

    void Print(CallLog log)
    {
        Console.WriteLine(log.PhoneNumber + "  " +log.Message + "  " +log.Time);
    }
}

class Program
{
    static void Main()
    {
        CallLogManager manager = new CallLogManager();

        manager.AddCallLog("9876543210", "Network issue", DateTime.Now.AddMinutes(-30));
        manager.AddCallLog("9123456780", "Recharge failed", DateTime.Now.AddMinutes(-10));
        manager.AddCallLog("9988776655", "Network very slow", DateTime.Now);

        Console.WriteLine("Search result:");
        manager.SearchByKeyword("Network");

        Console.WriteLine("Filtered by time:");
        manager.FilterByTime(DateTime.Now.AddMinutes(-20), DateTime.Now);
    }
}
