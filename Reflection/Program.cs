using System;
using System.Diagnostics;
using System.Configuration;
public class Logs
{
    private Exception Error {  get; set; }
    private const string sourceName = "MyApp";

    public Logs(Exception message)
    {
        Error = message;
    }
    public bool CreateEventLog(EventLogEntryType eventLogEntryType)
    {
        if (!EventLog.SourceExists(sourceName))
        {
            EventLog.CreateEventSource(sourceName, "Application");
        }

        switch (eventLogEntryType)
        {
            case EventLogEntryType.Error: EventLog.WriteEntry(sourceName, Error.Message, eventLogEntryType);return true;
            case EventLogEntryType.Warning: EventLog.WriteEntry(sourceName, Error.Message, eventLogEntryType); return true;
            case EventLogEntryType.Information: EventLog.WriteEntry(sourceName, Error.Message, eventLogEntryType); return true;

        }
        return false;
    }
}
class Program
{
    
    static void Main()
    {
       
        try
        {
            // تجربة توليد استثناء
            int x = int.Parse("not_a_number");
        }
        catch (Exception ex)
        {
            Logs log = new Logs(ex);
            log.CreateEventLog(EventLogEntryType.Error);
        }
        
        

    }
}

