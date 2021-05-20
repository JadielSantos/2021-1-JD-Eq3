using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMagicRanger : HeroRanger
{
    protected override IActionProvider CreateActionProvider()
    {
        return new MagicRangedActionProvider(this, damageType, projectilePrefab);
    }

    protected override string GetAdditionalDescription()
    {
        return "Longo alcance, atira raios com sua pistola. Atira 3 balas de uma vez em certo período de tempo";
    }
}