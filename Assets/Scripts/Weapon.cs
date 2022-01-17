using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    protected enum WeaponType
    {
        Sword = 0,
        Lance = 1,
        Axe = 2
    }

    protected int Damage;
}
