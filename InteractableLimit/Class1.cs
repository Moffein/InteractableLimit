using BepInEx;
using RoR2;
using UnityEngine.AddressableAssets;

namespace InteractableLimit
{
    [BepInPlugin("com.Moffein.InteractableLimit", "Interactable Limit", "1.0.0")]
    public class Class1 : BaseUnityPlugin
    {
        public static int bloodLimit = -1;
        public static int woodsLimit = -1;
        public static int mountainLimit = -1;
        public static int combatLimit = -1;
        public static int barrelLimit = -1;
        public static int goldShrineLimit = -1;
        public static int seedLimit = 3;

        public void Awake()
        {
            barrelLimit = Config.Bind("General", "Barrel", -1, "How many can spawn on the map. -1 for no limit.").Value;
            bloodLimit = Config.Bind("General", "Shrine of Blood", -1, "How many can spawn on the map. -1 for no limit.").Value;
            woodsLimit = Config.Bind("General", "Shrine of the Woods", -1, "How many can spawn on the map. -1 for no limit.").Value;
            mountainLimit = Config.Bind("General", "Shrine of the Mountain", -1, "How many can spawn on the map. -1 for no limit.").Value;
            combatLimit = Config.Bind("General", "Shrine of Combat", -1, "How many can spawn on the map. -1 for no limit.").Value;
            goldShrineLimit = Config.Bind("General", "Altar of Gold", -1, "How many of this can spawn on the map. -1 for no limit.").Value;
            mountainLimit = Config.Bind("General", "Void Seed", 3, "How many of this can spawn on the map. -1 for no limit.").Value;

            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/Barrel1/iscBarrel1.asset").WaitForCompletion().maxSpawnsPerStage = barrelLimit;

            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineBoss/iscShrineBoss.asset").WaitForCompletion().maxSpawnsPerStage = mountainLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineBoss/iscShrineBossSnowy.asset").WaitForCompletion().maxSpawnsPerStage = mountainLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineBoss/iscShrineBossSandy.asset").WaitForCompletion().maxSpawnsPerStage = mountainLimit;

            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineCombat/iscShrineCombat.asset").WaitForCompletion().maxSpawnsPerStage = combatLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineCombat/iscShrineCombatSnowy.asset").WaitForCompletion().maxSpawnsPerStage = combatLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineCombat/iscShrineCombatSandy.asset").WaitForCompletion().maxSpawnsPerStage = combatLimit;

            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineBlood/iscShrineBlood.asset").WaitForCompletion().maxSpawnsPerStage = bloodLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineBlood/iscShrineBloodSnowy.asset").WaitForCompletion().maxSpawnsPerStage = bloodLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineBlood/iscShrineBloodSandy.asset").WaitForCompletion().maxSpawnsPerStage = bloodLimit;

            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineHealing/iscShrineHealing.asset").WaitForCompletion().maxSpawnsPerStage = woodsLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/Base/ShrineGoldshoresAccess/iscShrineGoldshoresAccess.asset").WaitForCompletion().maxSpawnsPerStage = goldShrineLimit;
            Addressables.LoadAssetAsync<InteractableSpawnCard>("RoR2/DLC1/VoidCamp/iscVoidCamp.asset").WaitForCompletion().maxSpawnsPerStage = seedLimit;
        }
    }
}
