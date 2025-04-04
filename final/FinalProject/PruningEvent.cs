using System;
using System.ComponentModel;

public class PruningEvent : GardenEvent
{
    private string _amount;

    public PruningEvent(Plant plantType, string eventDate, string amount) 
    : base("Pruned", plantType, eventDate)
    {
        _eventDate = eventDate;
        _amount = amount;
    }

    public static PruningEvent CreateEvent()
    {
        Console.Write("What plant did you prune in your garden? ");
        string plant = Console.ReadLine();
        string eventDate = GetDate();
        string amount = null;

        while (amount == null)
        {   
            Console.Write(@"How much did you prune?
    1 - Minimal (just a bit)
    2 - Average
    3 - Agressive (as much as possible) ");
            string response = Console.ReadLine();
            if (response == "1")
            {
                amount = "Minimal";
            }
            else if (response == "2")
            {
                amount = "Average";
            }
            else if (response == "3")
            {
                amount = "Agressive";
            }
            else 
            {
                Console.WriteLine("Please enter 1, 2, or 3: ");
            }
        }

        PruningEvent p = new PruningEvent(plant, eventDate, amount);
        return p;
    }

    public override string ToString()
    {
        string displayEvent = $@"
Date: {_eventDate} -
    {_name}: {_plantType.GetName}
    Amount: {_amount}
";
        return displayEvent;
    }
        public override string Serialize()
    {
       return base.Serialize() + $"|{_amount}";
    }
}