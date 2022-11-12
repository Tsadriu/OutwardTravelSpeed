using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using SideLoader;
using SpeedOfTheWinds.Effects;
using SpeedOfTheWinds.Items;

namespace SpeedOfTheWinds
{
    [BepInDependency(SL.GUID, BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(GUID, NAME, VERSION)]
    public class SpeedOfTheWinds : BaseUnityPlugin
    {
        public const string GUID = "tsadriu.speedofthewinds";
        public const string NAME = "SpeedOfTheWinds";
        public const string VERSION = "0.1.2";

        internal static ManualLogSource Log;

        internal void Awake()
        {
            Log = this.Logger;
            Log.LogMessage($"Starting {NAME} - {VERSION} - MADE BY: TSADRIU");
            InitializeSL();
            new Harmony(GUID).PatchAll();
        }

        private void InitializeSL()
        {
            SL.BeforePacksLoaded += SL_BeforePacksLoaded;
        }

        private void SL_BeforePacksLoaded()
        {
            #region SpeedOfTheWindsI
            SpeedOfTheWindsIStatusEffect speedOfTheWindsIEffect = new SpeedOfTheWindsIStatusEffect();
            speedOfTheWindsIEffect.ApplyTemplate();

            SpeedOfTheWindsIPotion speedOfTheWindsIPotion = new SpeedOfTheWindsIPotion();
            speedOfTheWindsIPotion.ApplyTemplate();

            SL_Recipe speedOfTheWindsIRecipe = new SL_Recipe
            {
                UID = Constants.SPEED_OF_WINDS_I_POTION_RECIPE_NAME,
                StationType = Recipe.CraftingType.Alchemy,
                Ingredients = {
                    new SL_Recipe.Ingredient {
                        Type = RecipeIngredient.ActionTypes.AddGenericIngredient,
                        SelectorValue = "Water"
                    },
                    new SL_Recipe.Ingredient {
                        Type = RecipeIngredient.ActionTypes.AddSpecificIngredient,
                        SelectorValue = "6400130" // Mana stone
					}
                },
                Results = {
                    new SL_Recipe.ItemQty {
                        ItemID = speedOfTheWindsIPotion.New_ItemID,
                        Quantity = 2
                    }
                }
            };
            speedOfTheWindsIRecipe.ApplyTemplate();

            SL_RecipeItem speedOfTheWindsIRecipeItem = new SL_RecipeItem
            {
                RecipeUID = Constants.SPEED_OF_WINDS_I_POTION_RECIPE_NAME,
                Target_ItemID = 5700110, // Life Potion
                New_ItemID = -12500,
                Name = "Alchemy: Speed of The Winds I"
            };
            speedOfTheWindsIRecipeItem.ApplyTemplate();

            SL_DropTable SpeedOfTheWindsIPotionAndRecipeDropTable = new SL_DropTable
            {
                UID = Constants.SPEED_OF_WINDS_I_DROPTABLE_UID,
                RandomTables = {new SL_RandomDropGenerator {
                    MinNumberOfDrops = 1,
                    MaxNumberOfDrops = 5,
                    NoDrop_DiceValue = 3,
                    Drops = {
                        new SL_ItemDropChance {
                            DiceValue = 9,
                            MinQty = 1,
                            MaxQty = 3,
                            DroppedItemID = speedOfTheWindsIPotion.New_ItemID
                        },
                        new SL_ItemDropChance {
                            DiceValue = 5,
                            MinQty = 1,
                            MaxQty = 5,
                            DroppedItemID = speedOfTheWindsIRecipeItem.New_ItemID
                        }
                    }
                }}
            };
            SpeedOfTheWindsIPotionAndRecipeDropTable.ApplyTemplate();
            #endregion

            #region SpeedOfTheWindsII
            SpeedOfTheWindsIIStatusEffect speedOfTheWindsIIEffect = new SpeedOfTheWindsIIStatusEffect();
            speedOfTheWindsIIEffect.ApplyTemplate();

            SpeedOfTheWindsIIPotion speedOfTheWindsIIPotion = new SpeedOfTheWindsIIPotion();
            speedOfTheWindsIIPotion.ApplyTemplate();

            SL_Recipe speedOfTheWindsIIRecipe = new SL_Recipe
            {
                UID = Constants.SPEED_OF_WINDS_II_POTION_RECIPE_NAME,
                StationType = Recipe.CraftingType.Alchemy,
                Ingredients = {
                    new SL_Recipe.Ingredient {
                        Type = RecipeIngredient.ActionTypes.AddGenericIngredient,
                        SelectorValue = "Water"
                    },
                    new SL_Recipe.Ingredient {
                        Type = RecipeIngredient.ActionTypes.AddSpecificIngredient,
                        SelectorValue = "4000010" // Gaberries ID
					},
                    new SL_Recipe.Ingredient {
                        Type = RecipeIngredient.ActionTypes.AddSpecificIngredient,
                        SelectorValue = "6400130" // Mana stone
					}
                },
                Results = {
                    new SL_Recipe.ItemQty {
                        ItemID = speedOfTheWindsIIPotion.New_ItemID,
                        Quantity = 4
                    }
                }
            };
            speedOfTheWindsIIRecipe.ApplyTemplate();

            SL_RecipeItem speedOfTheWindsIIRecipeItem = new SL_RecipeItem
            {
                RecipeUID = Constants.SPEED_OF_WINDS_II_POTION_RECIPE_NAME,
                Target_ItemID = 5700110, // Life Potion
                New_ItemID = -12501,
                Name = "Alchemy: Speed of The Winds II"
            };
            speedOfTheWindsIIRecipeItem.ApplyTemplate();

            SL_DropTable SpeedOfTheWindsIIPotionAndRecipeDropTable = new SL_DropTable
            {
                UID = Constants.SPEED_OF_WINDS_II_DROPTABLE_UID,
                RandomTables = {new SL_RandomDropGenerator {
                    MinNumberOfDrops = 1,
                    MaxNumberOfDrops = 5,
                    NoDrop_DiceValue = 3,
                    Drops = {
                        new SL_ItemDropChance {
                            DiceValue = 9,
                            MinQty = 1,
                            MaxQty = 3,
                            DroppedItemID = speedOfTheWindsIIPotion.New_ItemID
                        },
                        new SL_ItemDropChance {
                            DiceValue = 5,
                            MinQty = 1,
                            MaxQty = 5,
                            DroppedItemID = speedOfTheWindsIIRecipeItem.New_ItemID
                        }
                    }
                }}
            };
            SpeedOfTheWindsIIPotionAndRecipeDropTable.ApplyTemplate();
            #endregion

            SL_DropTableAddition potionAndRecipeForMerchants = new SL_DropTableAddition
            {
                SelectorTargets = { "-MSrkT502k63y3CV2j98TQ", "G_GyAVjRWkq8e2L8WP4TgA" }, // Soroborean Caravanner
                DropTableUIDsToAdd = { SpeedOfTheWindsIPotionAndRecipeDropTable.UID, SpeedOfTheWindsIIPotionAndRecipeDropTable.UID }
            };
            potionAndRecipeForMerchants.ApplyTemplate();
        }

    }

}