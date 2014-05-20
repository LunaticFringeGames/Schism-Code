using UnityEngine;
using System.Collections;
using Schism;

[System.Serializable]
public class Item 
{
	public string name;
    public int id;
    public string meshPath;
	public string description;
	public Texture2D icon;
    public ItemType type;
    public object subTypeData;
    public Rarity rarity;
    public int value;
    public int engineeringLevel;
}
[System.Serializable]
public class Weapon : Item
{
    public float minDamage;
    public float maxDamage;
    public DamageType damageType;
    public float minRange;
    public float maxRange;
}

[System.Serializable]
public class Ranged : Weapon
{
    public Barrel barrel;
    public Body body;
    public Magazine magazine;
    public Mechanism mechanism;
    public Sight sight;
    public Stock stock;

    public AmmoType ammoType;
    public float rateOfFire;
    public int capacity;
    public BurstType burstType;
    public float reloadSpeed;
    public float accuracy;
}
[System.Serializable]
public class GunComponent : Item
{
    public GunComponentType gunComponentType;
}
[System.Serializable]
public class Barrel : GunComponent
{
    public float accuracy;
    public float minDamage;
}
[System.Serializable]
public class Body : GunComponent
{
    public float maxDamage;
    public Ammo ammo;
}
[System.Serializable]
public class Magazine : GunComponent
{
    public float capacity;
    public float reloadSpeed;
}
[System.Serializable]
public class Mechanism : GunComponent
{
    public BurstType burstType;
    public float rateOfFire;
}
[System.Serializable]
public class Sight : GunComponent
{
    public float accuracy;
    public float range;
}
[System.Serializable]
public class Stock : GunComponent
{
    public float accuracy;
    public float reloadSpeed;
}
[System.Serializable]
public class MeleeComponent : Item
{
    public MeleeComponentType meleeComponentType;
}
[System.Serializable]
public class Hilt : MeleeComponent
{
    public float speed;
}
[System.Serializable]
public class PowerCell : MeleeComponent
{
    public float maxDamage;
}
[System.Serializable]
public class Guard : MeleeComponent
{
    public float block;
}
[System.Serializable]
public class FieldGenerator : MeleeComponent
{
    public float block;
    public float maxDamage;
}
[System.Serializable]
public class Insulator : MeleeComponent
{
    public float minDamage;
}
[System.Serializable]
public class Crystal : MeleeComponent
{
    public Color32 color;
    public float minDamage;
}
[System.Serializable]
public class Armor 
{ 

}
[System.Serializable]
public class Consumable
{

}
[System.Serializable]
public class Ammo
{

}
