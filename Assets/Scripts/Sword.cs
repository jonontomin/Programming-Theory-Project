using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    private void Awake()
    {
        Damage = 1;
        WeaponType type = WeaponType.Sword;
    }
}
