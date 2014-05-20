

namespace Schism 
{
    public enum DamageType
    {
        piercing,
        slashing,
        bludgeoning,
        projectile,
        explosive,
        quantum,
        nano,
        heat,
        cold,
        poison
    };


    public enum ItemType
    {
        headGear,
        jacket,
        shirt,
        gloves,
        pants,
        shoes,
        weapon,
        armGear,
        glasses,
        belt,
        gunComponent
    };

    public enum GunComponentType
    {
        barrel,
        body,
        magazine,
        mechanism,
        sight,
        stock
    };

    public enum MeleeComponentType
    {
        hilt,
        powerCell,
        guard,
        fieldGenerator,
        insulator,
        crystal
    };

    public enum RangedType
    {
        pistol,
        rifle,
        assaultRifle,
        subMachineGun,
        shotgun
    };

    public enum AmmoType
    {
        pointNine,
        fivePointFiveSix,
        twoSeventy,
        twentyTwo,
        twelveGuage,
        fourTen,
        twentyGuage
    };

    public enum Rarity
    {
        junk,
        cheap,
        common,
        quality,
        specialEdition,
        handCrafted,
        priceless        
    };

    public enum BurstType
    {
        single,
        auto,
        threeRound,
        fullAuto,
        doubleBarrel
    };

    public enum NPCType
    {
        enemy,
        merchant,
        quest
    };

    public enum CharacterType
    {
        player,
        NPC
    };
    
}
