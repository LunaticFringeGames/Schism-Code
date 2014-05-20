using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UMA;
using System.Linq;
using Mono.Data.Sqlite;
using SchismDB;


public class Avatar1Recipe : UMAAvatarBase
{
    public bool loadOnStart;
    public Character avatar1;
    private SchismDB.MonoStrict db;


    public override void Start()
    {
        avatar1 = (from p in db.Character
                          where p.CharacterID == 1
                          select p).FirstOrDefault();

        var asset = ScriptableObject.CreateInstance<UMATextRecipe>();
        asset.recipeString = avatar1.UmA;


        base.Start();
        if (loadOnStart)
        {
            Load(asset);
        }
    }
}