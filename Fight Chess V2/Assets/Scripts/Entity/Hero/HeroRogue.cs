using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRogue : HeroEntity
{
    protected override IActionProvider CreateActionProvider()
    {
        return new MeleeRogueActionProvider(this, damageType);
    }

    protected override string GetAdditionalDescription()
    {
        return "Vida baixa, defesa baixa, alto dano em pouco tempo. Ao gastar sua energia, pula no alvo e desvia de TODOS os ataques por um curto período de tempo.";
    }

    protected override string GetClassType() => "Corpo-a-Corpo";

    protected override int GetStartHealth() => HeroMeleeData.Instance.StartHealth + startHealthAdd;
}
