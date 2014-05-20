using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UMA;

public class SchismUMACrowd : MonoBehaviour
{
    public UMACrowdRandomSet[] randomPool;
    public UMAGeneratorBase generator;
    public UMAData umaData;
    public SlotLibrary slotLibrary;
    public OverlayLibrary overlayLibrary;
    public RaceLibrary raceLibrary;
    public RuntimeAnimatorController animationController;

    public float atlasResolutionScale;
    public bool generateUMA;
    
    public Vector2 umaCrowdSize;
    public bool randomDna;

    public float space = 1;
    public Transform zeroPoint;

    private Transform tempUMA;
    private int X;
    private int Y;
    private float umaTimer;
    public string[] keywords;
    public float skinTone;
    public Color skinColor;
    public Color HairColor;

    public int head = 1;
    public int hair = 1;
    public int beard = 1;
    public int eyebrow = 1;
    public int body = 1;
    public int shirt = 1;
    public Color shirtColor;
    public Color pantsColor;
    public Color eyeColor;
    public Color lipsColor = Color.red;

    public CreatePartyRedux createParty;

    public Color32 hairColor = new Color32(0, 0, 0, 0);
   

    void Awake()
    {
        if (space == 0) space = 1;
        string tempVersion = Application.unityVersion;
        tempVersion = tempVersion.Substring(0, 3);

        //Define the skin color, then define a random skin tone, then define a new skin color based on the skin tone added to each random color value
        skinColor = new Color(1, 1, 1, 1);
        skinTone = Random.Range(0.1f, 0.6f);
        skinColor = new Color(skinTone + skinColor.r, skinTone + skinColor.g, skinTone + skinColor.b, 1);

    }

    void Update()
    {
        //If the generateUMA bool is true, call the GenerateOneUma method, then make generateUMA false so we only call it once.
        if (generateUMA)
        {
            GenerateOneUMA();
            generateUMA = false;
        }
    }

    void umaData_OnUpdated(UMAData obj)
    {
        if (obj.cancelled)
        {
            Object.Destroy(obj.gameObject);
        }
        else
        {
            if (zeroPoint)
            {
                tempUMA.position = new Vector3(X * space + zeroPoint.position.x - umaCrowdSize.x * space * 0.5f + 0.5f, zeroPoint.position.y, Y * space + zeroPoint.position.z - umaCrowdSize.y * space * 0.5f + 0.5f);
            }
            else
            {
                tempUMA.position = new Vector3(X * space - umaCrowdSize.x * space * 0.5f + 0.5f, 0, Y * space - umaCrowdSize.y * space * 0.5f + 0.5f);
            }
        }
    }

    //This is an overload method for DefineSlots() that allows you pass in a specific race
    private void DefineSlots(UMACrowdRandomSet.CrowdRaceData race)
    {
        //Randomize the skin and hair colors
        skinTone = Random.Range(0.1f, 0.6f);
        skinColor = new Color(skinTone + Random.Range(0.35f, 0.4f), skinTone + Random.Range(0.25f, 0.4f), skinTone + Random.Range(0.35f, 0.4f), 1);
        HairColor = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), 1);

        //Build a HashSet of keywords (not sure what this is for yet)
        var keywordsLookup = new HashSet<string>(keywords);

        //Apply all of the values to the UMACrowdRandomSet
        UMACrowdRandomSet.Apply(umaData, race, skinColor, HairColor, keywordsLookup, slotLibrary, overlayLibrary);
    }

    //This is the default DefineSlots() Method.  It does just what it says, defines all of the slots and which overlays to use in each slot
    public void DefineSlots()
    {
        
        //Randomize each value for the hair color
        Color HairColor = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), 1);

        //This is the slot information for the Human Male Avatar
        if (umaData.umaRecipe.raceData.raceName == "HumanMale")
        {
       
            //Define the slots as an array
            umaData.umaRecipe.slotDataList = new SlotData[15];

            //Slot 0 is Male Eyes
            umaData.umaRecipe.slotDataList[0] = slotLibrary.InstantiateSlot("MaleEyes");

            //Add 2 overlays to the Male Eyes Slot
            umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlay"));
            umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlayAdjust", eyeColor));

           //Slot 1 is the male head (face)
            umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot("MaleFace");
            
            //We have 3 head overlays we can select from
            if (head == 1)
            {   
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleHead01", skinColor));
            }
                
            else if (head == 2)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleHead02", skinColor));
            }

            else if (head == 3)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("FR_DH", skinColor));            //This is the Dionysus Head
            }

            //Slot 7 is Eyes (I think is actually the part of the face around the eyes)
            umaData.umaRecipe.slotDataList[7] = slotLibrary.InstantiateSlot("MaleHead_Eyes", umaData.umaRecipe.slotDataList[1].GetOverlayList());

            //Slot 9 is the mouth
            umaData.umaRecipe.slotDataList[9] = slotLibrary.InstantiateSlot("MaleHead_Mouth", umaData.umaRecipe.slotDataList[1].GetOverlayList());

             //Slot 10 is the nose  
            umaData.umaRecipe.slotDataList[10] = slotLibrary.InstantiateSlot("MaleHead_Nose", umaData.umaRecipe.slotDataList[1].GetOverlayList());
                
            //Slot 8 is the Ears
            umaData.umaRecipe.slotDataList[8] = slotLibrary.InstantiateSlot("MaleHead_Ears", umaData.umaRecipe.slotDataList[1].GetOverlayList());
              
            //We have 3 hair choices, including bald
            if (hair == 1)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleHair01", hairColor));
            }
            else if (hair == 2)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleHair02", hairColor));
            }
            else if (hair == 3)
            {

            }

            //We have 4 beard choices, including no beard
            if (beard == 1)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard01", hairColor ));
            }
            else if (beard == 2)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard02", hairColor));
            }
            else if (beard == 3)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard03", hairColor));
            }
            else
            {

            }

            //Extra beard composition (I think this just makes the beards look fuller)
            
            if (beard == 1)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard01", hairColor));
            }
            else if (beard == 2)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard02", hairColor));
            }
            else if (beard == 3)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard03", hairColor));
            }
            else
            {

            }

            //We have 2 eyebrow choices
            if (eyebrow == 1)
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleEyebrow01", hairColor));
            }
           else
            {
                umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleEyebrow02", hairColor));
            }

            //Slot 2 is the Torso
            umaData.umaRecipe.slotDataList[2] = slotLibrary.InstantiateSlot("MaleTorso");

            //We have 3 choices for bodies
            if (body == 1)
            {
                umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBody01", skinColor));
            }
            else if (body == 2)
            {
               umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBody02", skinColor));
            }

            else if (body == 3)
            {
                umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("FR_DB", skinColor));
            }

            //We have one shirt right now
            umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("MaleShirt01", shirtColor));
            
            //Slot 3 is the hands
            umaData.umaRecipe.slotDataList[3] = slotLibrary.InstantiateSlot("MaleHands", umaData.umaRecipe.slotDataList[2].GetOverlayList());

            //Slot 4 is the inner mouth
            umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot("MaleInnerMouth");
            //Inner mouth overlay
            umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay("InnerMouth"));

            //Slot 5 is the pants
            umaData.umaRecipe.slotDataList[5] = slotLibrary.InstantiateSlot("MaleJeans01");
            //We only have one jeans overlay
            umaData.umaRecipe.slotDataList[5].AddOverlay(overlayLibrary.InstantiateOverlay("MaleJeans01", pantsColor));
            
            //Slot six is the feet
            umaData.umaRecipe.slotDataList[6] = slotLibrary.InstantiateSlot("MaleFeet", umaData.umaRecipe.slotDataList[2].GetOverlayList());
        }



        //This is the slot data for a Human Female
        else if (umaData.umaRecipe.raceData.raceName == "HumanFemale")
        {
            int randomResult = 0;
            //Female Avatar

            //Example of dynamic list
            List<SlotData> tempSlotList = new List<SlotData>();

            tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleEyes"));
            tempSlotList[tempSlotList.Count - 1].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlay"));
            tempSlotList[tempSlotList.Count - 1].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlayAdjust", eyeColor));

            int headIndex = 0;

            randomResult = Random.Range(0, 2);
            if (head == 1)
            {

                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleFace"));
                headIndex = tempSlotList.Count - 1;
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleHead01", skinColor));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleEyebrow01", hairColor));

                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLipstick01", lipsColor));
                
            }
            else if (head == 2)
            {
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Head"));
                headIndex = tempSlotList.Count - 1;
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleHead01", skinColor));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleEyebrow01", hairColor));

                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Eyes", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Mouth", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Nose", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Ears", tempSlotList[headIndex].GetOverlayList()));
                
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLipstick01", lipsColor));
                
            }
            if (head == 3)
            {

                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleFace"));
                headIndex = tempSlotList.Count - 1;
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FR_AH", skinColor));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleEyebrow01", hairColor));

                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLipstick01", lipsColor));

            }
            else if (head == 4)
            {
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Head"));
                headIndex = tempSlotList.Count - 1;
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FR_AH", skinColor));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleEyebrow01", hairColor));

                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Eyes", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Mouth", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Nose", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHead_Ears", tempSlotList[headIndex].GetOverlayList()));

                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLipstick01", lipsColor));

            }


            tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleEyelash"));
            tempSlotList[tempSlotList.Count - 1].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleEyelash", Color.black));

            tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleTorso"));
            int bodyIndex = tempSlotList.Count - 1;
            
            if (body == 1)
            {
                tempSlotList[bodyIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleBody01", skinColor));
            } if (body == 2)
            {
                tempSlotList[bodyIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleBody02", skinColor));
            }
            if (body == 3)
            {
                tempSlotList[bodyIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FR_AB", skinColor));
            }

            tempSlotList[bodyIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleUnderwear01", Color.black));

            randomResult = Random.Range(0, 4);
            if (shirt == 1)
            {
                tempSlotList[bodyIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleShirt01", shirtColor));
            }
            else if (shirt == 2)
            {
                tempSlotList[bodyIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleShirt02", shirtColor));
            }
            else if (shirt == 3)
            {
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleTshirt01"));
                tempSlotList[tempSlotList.Count - 1].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleTshirt01", shirtColor));
            }
            else
            {

            }

            tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleHands", tempSlotList[bodyIndex].GetOverlayList()));

            tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleInnerMouth"));
            tempSlotList[tempSlotList.Count - 1].AddOverlay(overlayLibrary.InstantiateOverlay("InnerMouth"));

            tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleFeet", tempSlotList[bodyIndex].GetOverlayList()));


           
            tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleLegs", tempSlotList[bodyIndex].GetOverlayList()));
            tempSlotList[bodyIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleJeans01", pantsColor));
            

            
            if (hair == 1)
            {
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleShortHair01", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleShortHair01", hairColor));
            }
            else if (hair == 2)
            {
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleLongHair01", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLongHair01", hairColor));
            }
            else if (hair == 3)
            {
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleLongHair01", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLongHair01", hairColor));

                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleLongHair01_Module"));
                tempSlotList[tempSlotList.Count - 1].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLongHair01_Module", hairColor));
            }
            else if (hair == 4)
            {
                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleShortHair01", tempSlotList[headIndex].GetOverlayList()));
                tempSlotList[headIndex].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleShortHair01", hairColor));

                tempSlotList.Add(slotLibrary.InstantiateSlot("FemaleLongHair01_Module"));
                tempSlotList[tempSlotList.Count - 1].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLongHair01_Module", hairColor));
            }



            umaData.SetSlots(tempSlotList.ToArray());
        }
        
    }

    void SetUMAData()
    {
        umaData.atlasResolutionScale = atlasResolutionScale;
        umaData.OnCharacterUpdated += myColliderUpdateMethod;
        umaData.Dirty(true, true, true);
    }

    //Fits a collider to the generated avatar
    void myColliderUpdateMethod(UMAData umaData)
    {
        CapsuleCollider tempCollider = umaData.umaRoot.gameObject.GetComponent("CapsuleCollider") as CapsuleCollider;
        if (tempCollider)
        {
            UMADnaHumanoid umaDna = umaData.umaRecipe.GetDna<UMADnaHumanoid>();
            tempCollider.height = (umaDna.height + 0.5f) * 2 + 0.1f;
            tempCollider.center = new Vector3(0, tempCollider.height * 0.5f - 0.04f, 0);
        }
    }

    //Define the initial values for our base character
    void GenerateUMAShapes()
    {
        UMADnaHumanoid umaDna = new UMADnaHumanoid();
        umaData.umaRecipe.AddDna(umaDna);

        if (randomDna)
        {

            umaDna.height = Random.Range(0.3f, 0.5f);
            umaDna.headSize = Random.Range(0.485f, 0.515f);
            umaDna.headWidth = Random.Range(0.4f, 0.6f);

            umaDna.neckThickness = Random.Range(0.495f, 0.51f);

            if (umaData.umaRecipe.raceData.raceName == "HumanMale")
            {
                umaDna.handsSize = Random.Range(0.485f, 0.515f);
                umaDna.feetSize = Random.Range(0.485f, 0.515f);
                umaDna.legSeparation = Random.Range(0.4f, 0.6f);
                umaDna.waist = 0.5f;
            }
            else
            {
                umaDna.handsSize = Random.Range(0.485f, 0.515f);
                umaDna.feetSize = Random.Range(0.485f, 0.515f);
                umaDna.legSeparation = Random.Range(0.485f, 0.515f);
                umaDna.waist = Random.Range(0.3f, 0.8f);
            }

            umaDna.armLength = Random.Range(0.485f, 0.515f);
            umaDna.forearmLength = Random.Range(0.485f, 0.515f);
            umaDna.armWidth = Random.Range(0.3f, 0.8f);
            umaDna.forearmWidth = Random.Range(0.3f, 0.8f);

            umaDna.upperMuscle = Random.Range(0.0f, 1.0f);
            umaDna.upperWeight = Random.Range(-0.2f, 0.2f) + umaDna.upperMuscle;
            if (umaDna.upperWeight > 1.0) { umaDna.upperWeight = 1.0f; }
            if (umaDna.upperWeight < 0.0) { umaDna.upperWeight = 0.0f; }

            umaDna.lowerMuscle = Random.Range(-0.2f, 0.2f) + umaDna.upperMuscle;
            if (umaDna.lowerMuscle > 1.0) { umaDna.lowerMuscle = 1.0f; }
            if (umaDna.lowerMuscle < 0.0) { umaDna.lowerMuscle = 0.0f; }

            umaDna.lowerWeight = Random.Range(-0.1f, 0.1f) + umaDna.upperWeight;
            if (umaDna.lowerWeight > 1.0) { umaDna.lowerWeight = 1.0f; }
            if (umaDna.lowerWeight < 0.0) { umaDna.lowerWeight = 0.0f; }

            umaDna.belly = umaDna.upperWeight;
            umaDna.legsSize = Random.Range(0.4f, 0.6f);
            umaDna.gluteusSize = Random.Range(0.4f, 0.6f);

            umaDna.earsSize = Random.Range(0.3f, 0.8f);
            umaDna.earsPosition = Random.Range(0.3f, 0.8f);
            umaDna.earsRotation = Random.Range(0.3f, 0.8f);

            umaDna.noseSize = Random.Range(0.3f, 0.8f);

            umaDna.noseCurve = Random.Range(0.3f, 0.8f);
            umaDna.noseWidth = Random.Range(0.3f, 0.8f);
            umaDna.noseInclination = Random.Range(0.3f, 0.8f);
            umaDna.nosePosition = Random.Range(0.3f, 0.8f);
            umaDna.nosePronounced = Random.Range(0.3f, 0.8f);
            umaDna.noseFlatten = Random.Range(0.3f, 0.8f);

            umaDna.chinSize = Random.Range(0.3f, 0.8f);
            umaDna.chinPronounced = Random.Range(0.3f, 0.8f);
            umaDna.chinPosition = Random.Range(0.3f, 0.8f);

            umaDna.mandibleSize = Random.Range(0.45f, 0.52f);
            umaDna.jawsSize = Random.Range(0.3f, 0.8f);
            umaDna.jawsPosition = Random.Range(0.3f, 0.8f);

            umaDna.cheekSize = Random.Range(0.3f, 0.8f);
            umaDna.cheekPosition = Random.Range(0.3f, 0.8f);
            umaDna.lowCheekPronounced = Random.Range(0.3f, 0.8f);
            umaDna.lowCheekPosition = Random.Range(0.3f, 0.8f);

            umaDna.foreheadSize = Random.Range(0.3f, 0.8f);
            umaDna.foreheadPosition = Random.Range(0.15f, 0.65f);

            umaDna.lipsSize = Random.Range(0.3f, 0.8f);
            umaDna.mouthSize = Random.Range(0.3f, 0.8f);
            umaDna.eyeRotation = Random.Range(0.3f, 0.8f);
            umaDna.eyeSize = Random.Range(0.3f, 0.8f);
            umaDna.breastSize = Random.Range(0.3f, 0.8f);


        }
    }

    //This is the Method to generate a UMA Character
    void GenerateOneUMA()
    {
        var newGO = new GameObject("Generated Character");                  //Create the game object
        newGO.transform.parent = transform;                                 //Parent the game object to this transform
        var umaDynamicAvatar = newGO.AddComponent<UMADynamicAvatar>();      //Create the UMADynamicAvatar
        umaDynamicAvatar.Initialize();                                      //Initialize the UMADynamicAvatar
        umaData = umaDynamicAvatar.umaData;                                 //Reference the umaData from the UMADynamicAvatar
        umaDynamicAvatar.umaGenerator = generator;                          //Assign the UMADynamicAvatar generator
        umaData.umaGenerator = generator;                                   //Assign the umaData generator
        var umaRecipe = umaDynamicAvatar.umaData.umaRecipe;                 //Create the recipe

        UMACrowdRandomSet.CrowdRaceData race = null;                        //Clear the race

        //I added this so we can decide if want to create a Male or Female from inside our CreateParty script
        if (createParty.UMARace == "Male")
        {
            umaRecipe.SetRace(raceLibrary.GetRace("HumanMale"));
        }
        if (createParty.UMARace == "Female")
        {
            umaRecipe.SetRace(raceLibrary.GetRace("HumanFemale"));
        }

        //Call the SetUMAData() method
        SetUMAData();

        //Call the GenerateUMAShapes() Method.  This defines the avatar we use as a base before our createParty script modifies it.
        GenerateUMAShapes();

        //Call the methods to define the slots
        if (race != null && race.slotElements.Length > 0)
        {
            DefineSlots(race);
        }
        else
        {
            DefineSlots();
        }

        //Assign an animation controller if we don't already have one
        if (animationController != null)
        {
            umaDynamicAvatar.animationController = animationController;
        }

        umaDynamicAvatar.UpdateNewRace();                           
        umaDynamicAvatar.umaData.myRenderer.enabled = false;
        tempUMA = newGO.transform;

        if (zeroPoint)
        {
            tempUMA.position = new Vector3(zeroPoint.position.x, zeroPoint.position.y, zeroPoint.position.z);
        }
        else
        {
            tempUMA.position = new Vector3(0, 0, 0);
        }
    }
}
