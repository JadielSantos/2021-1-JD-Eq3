using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRanger : HeroEntity
{
    protected override IActionProvider CreateActionProvider()
    {
        return new RangedActionProvider(this, damageType, projectilePrefab);
    }

    protected override string GetAdditionalDescription()
    {
        return "Dano a distância, pouca vida, porém dá um dano consideravelmente alto. Têm habilidade de dar tiros em cone ao gastar energia.";
    }

    protected override string GetClassType() => "Ranged";

    protected override int GetStartHealth() => HeroRangedData.Instance.StartHealth + startHealthAdd;
}
