namespace Stones2Stars.Backend.Domain.InfoModels.Units;
public class UnitInfo
{
    public List<CombatType> CombatTypes { get; set; } = [];
    public List<UnitAction> AvailableActions { get; set; } = [];
    public List<string> AvailableMapCategories { get; set; } = []; // sea, land, space, air, etc
    public List<string> AllowedUnitAis { get; set; } = ["UNITAI_ATTACK", "UNITAI_DEFENCE"];
    public List<string> RequiredBonuses { get; set; } = [];

    public string Name { get; set; } = string.Empty;
    public int Cost { get; set; } = 1;
    public int BaseUpKeep { get; set; }
    public int MovementPoints { get; set; } // if 0 it's a plane, or other unit that can only move with unitActions
    public CombatStats? CombatStats { get; set; } = null;
    public CivilianStats? CivilianStats { get; set; } = null;
    public List<IUnitModule> Modules { get; set; } = [];
}

public class CombatStats
{
    public double Strength { get; set; }
    public int Size { get; set; }
}

public class CivilianStats
{
    public int WorkPoints { get; set; }
    public List<UnitMission> AvailableMissions { get; set; } = [];
}

public class UnitMission
{
    public string Name { get; set; } = "BUILD_FARM";
    public int Cost { get; set; }
    public List<MissionRequirement> Requires { get; set; } = [];
    public MissionOutcome OutCome { get; set; } = null!;
}

public class MissionRequirement
{
    public string Requirement { get; set; } = string.Empty;
    public bool IsRequired { get; set; }
    public string Location { get; set; } = "ON_PLOT"; // "IN_NATION", "IN_CITY" etc
    public bool CreatesBuilding { get; set; } // if it creates building, it needs to be in a city.
}

// TODO: this needs a rethink on how to do intelligently
public class MissionOutcome
{
    private string Name { get; set; } = "IMPROVEMENT_FARM";
    public UnitAction? UnitAction { get; set; }
    public string Target { get; set; } = "PLOT";
}

public class UnitAction
{
    public string Type { get; set; } = "ACTION_NUKE_TILE";
    public bool IsSuicide { get; set; } = false;
    public int Range { get; set; } = 5;
    public int Power { get; set; }
}

public class CombatType
{
    public string Name { get; set; } = string.Empty;
    public List<string> AvailableSubTypes { get; set; } = [];
    public int CaptureChanceModifier { get; set; } = 0;
    public int SurrenderChanceModifier { get; set; } = 0;
}

public class CombatModifier
{
    public int StrengthPercentage { get; set; }
    public string CombatType { get; set; } = string.Empty;
}