using System;
using System.Collections.Generic;
using System.IO;

public class Plant
{
    private string _name;
    private string _description;
    private int _sqFtAmount;
    private int _expectedHarvest;
    private string _harvestUnits;
    private bool _perennial;
    private bool _seeds;
    private string _depth;

    public Plant(string name, int sqFtAmount, int expectedHarvest, string harvestUnits, bool perennial, bool seeds, string depth)
    {
        _name = name;
        _sqFtAmount = sqFtAmount;
        _expectedHarvest = expectedHarvest;
        _harvestUnits = harvestUnits;
        _perennial = perennial;
        _seeds = seeds;
        _depth = depth;
        _description = SetDescription();
    }

    public string SetDescription()
    {
        return $@"
{_name} 
    - {_name} are a {DisplayPerennial()}
    - It is best to {DisplaySeeds()}
    - You should plant {_sqFtAmount} {SeedsOrStart()} per 1 square foot of garden space, evenly spaced apart and to a depth of {_depth}.
    - You should expect to get up to {_expectedHarvest} {_harvestUnits} from this plant by the end of the growing season.";
    }

    public string DisplayPerennial()
    {
        if (_perennial)
        {
            return "perennial plant, which means that it will regrow in the spring.";
        }
        else
        {
            return "annual plant, which means that it will not come regrow in the spring and must be replanted every year.";
        }
    }
        
    public string DisplaySeeds()
    {
        if (_seeds)
        {
            return "start this plant from seeds, directly planted into the garden, 2 to 3 seeds per hole.";
        }
        else
        {
            return "use starts for this plant (that you have either purchased or grown from seed yourself.";
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