using UnityEngine;
using System.Collections;
using System.Linq;
using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using SchismDB;
using UMA;
public class LoadRecipes : MonoBehaviour 
{
  
    private SchismDB.MonoStrict db;
    private Character[] characterQuery;
    public UMARecipeBase recipe;
    public UMAContext context;
    public GameObject CharacterWeapon;


	void Start () 
    {
        SqliteConnection myConnect = new SqliteConnection("URI=file:./Assets/Database/SchismMasterDB.s3db");

        //Reference our datbase connection
        db = new SchismDB.MonoStrict(myConnect);

        //Query the database to get the proper GroupID from the "previous scene"?

        CharacterGroup myLastGroup = (from p in db.CharacterGroup
                                      where p.CharacterGroupID == 1
                                      select p).FirstOrDefault();

        int[] CharacterIDFromGroup = new int[6];
        CharacterIDFromGroup[0] = myLastGroup.Character1id.Value;
        CharacterIDFromGroup[1] = myLastGroup.Character2id.Value;
        CharacterIDFromGroup[2] = myLastGroup.Character3id.Value;
        CharacterIDFromGroup[3] = myLastGroup.Character4id.Value;
        CharacterIDFromGroup[4] = myLastGroup.Character5id.Value;
        CharacterIDFromGroup[5] = myLastGroup.Character6id.Value;

        characterQuery = (from p in db.Character
                          where CharacterIDFromGroup.Contains(p.CharacterID)
                          orderby p.CharacterID ascending
                          select p
                          ).ToArray<Character>();

        if(characterQuery == null)
        {
            Debug.Log("No character returned!!");
            return;

        }
        foreach(Character myCharacter in characterQuery)
        {
            Debug.Log("Name: " + myCharacter.CharacterName);

        }
        //find all UMADynamicAvatar's in this Group object and start assigning them to
        //the corresponding Character in the database:

        UMADynamicAvatar[] myCharacterAvatars = this.gameObject.GetComponentsInChildren<UMADynamicAvatar>();



        int x = 0;
        foreach(UMADynamicAvatar myAvatar in myCharacterAvatars)
        {
            Debug.Log("*3*I now have access to avatar: " + myAvatar.name);
            try {
             var asset = ScriptableObject.CreateInstance<UMATextRecipe>();
                asset.recipeString = characterQuery[x].UmA;

           
                 myAvatar.Load(asset);
                x++;
            }
            catch(UnityException f)
            {
                Debug.Log("Avatar failed to load with selected character's recipe" + f.Message);

            }

        }

        x = 1;
        foreach (UMADynamicAvatar myAvatar in myCharacterAvatars)
        {

            Transform HandSlot = myAvatar.umaData.animator.GetBoneTransform(HumanBodyBones.RightHand);
            GameObject myCharacterWeapon = Instantiate(CharacterWeapon, new Vector3(HandSlot.position.x, HandSlot.position.y, HandSlot.position.z), Quaternion.identity) as GameObject;


            myCharacterWeapon.name = "Gun" + x.ToString();
            myCharacterWeapon.transform.parent = HandSlot;
           
            if(HandSlot != null)
            {
                Debug.Log("Hand X:" + HandSlot.position.x.ToString());
            }
            else
            {
                Debug.Log("NO SLOT FOUND!!!!  YOU WASTE TOO MUCH TIME.");
            }
            x++;

        }

       

	}

    
	
	
}
