using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroWarrior : HeroEntity
{
    protected override IActionProvider CreateActionProvider()
    {
        return new MeleeActionProvider(this, damageType);
    }

    protected override string GetAdditionalDescription()
    {
        return "Vida média, defesa média e dá dano em área em certo tempo.";
    }

    protected override string GetClassType() => "Melee";

    protected override int GetStartHealth() => HeroMeleeData.Instance.StartHealth + startHealthAdd;
}
