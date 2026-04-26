using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace FuryAutoPatcher;

public class RaceDamage
{
    public IFormLinkGetter<IRaceGetter> Race = FormLink<IRaceGetter>.Null;
    public float Damage = 1.0f;
}

public class Settings {
    public List<ModKey> TargetMods {get; set;} = new();
    public HashSet<FormLink<Race>> ExcludeRaces {get; set;} = new();
    [Tooltip("Adjust individual race damage.")]
    public List<RaceDamage> CustomRaceDamage {get; set;} = new();
}

