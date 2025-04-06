using System;
using System.Collections.Generic;
using System.IO;

public class Plant
{
    private string _name;
    private string _timeToGermination;
    private string _whenToHarvest;
    private bool _seeds;
    private string _depth;
    private bool _perennial;
    private string _description;

    public Plant(string name, string timeToGermination, string whenToHarvest, bool perennial, bool seeds, string depth)
    {
        _name = name;
        _timeToGermination = timeToGermination;
        _whenToHarvest = whenToHarvest;
        _perennial = perennial;
        _seeds = seeds;
        _depth = depth;
        _description = GetDescription();
    }

    public string GetDescription()
    {
        return $@"{_name}: 
- It is best to {DisplaySeeds()}
- You should plant the {SeedsOrStart()} evenly spaced apart and to a depth of {_depth}.
- Time to germination after planting or transplanting is between {_timeToGermination}.
- You should expect to be able to harvest {_whenToHarvest}.
- {_name} are a {DisplayPerennial()}
";
    }

    public override string ToString()
    {
        return GetName();
    }
    
    public string DisplayPerennial()
    {
        if (_perennial)
        {
            return "perennial plant, which means that it will regrow in the spring.";
        }
        else
        {
            return "annual plant, which means that it will not come back or regrow in the spring and must be replanted every year.";
        }
    }

    public static Plant Deserialize(string line)
    {
        Plant p;
        string[] parts = line.Split("|");
        p = new Plant(parts[0], parts[1], parts[2], bool.Parse(parts[3]), bool.Parse(parts[4]), parts[5]);
        return p;
    }

    public string DisplaySeeds()
    {
        if (_seeds)
        {
            return "start this plant from seeds, directly planted into the garden, 2 to 3 seeds per hole.";
        }
        else
        {
            return "use starts for this plant (that you have either purchased or grown from seed yourself.)";
        }
    }
    
    public string SeedsOrStart()
    {
        if (_seeds)
        {
            return "seeds";
        }
        else
        {
            return "starts";
        }
    }

    public string GetName()
    {
        return _name;
    }
}