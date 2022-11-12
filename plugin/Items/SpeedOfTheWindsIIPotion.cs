using SideLoader;

namespace SpeedOfTheWinds.Items
{
    public class SpeedOfTheWindsIIPotion : SL_Item
    {
        public SpeedOfTheWindsIIPotion()
        {
            Target_ItemID = 4300130;
            New_ItemID = -12001;
            Name = "Speed of the Winds II";
            Description = $"Drinking this potion will gradually increase your movement speed up to x{Constants.SPEED_OF_WINDS_II_SPEED_MULTIPLIER_MAX} faster than your normal movement speed for 20 minutes. Engaging in combat will disable this effect and pause the effect's countdown. Does not increase stamina consumption while running.";
            StatsHolder = new SL_ItemStats
            {
                BaseValue = 25,
                RawWeight = 0.4f
            };
            EffectBehaviour = EditBehaviours.Destroy;
            EffectTransforms = new SL_EffectTransform[] {
                new SL_EffectTransform {
                    TransformName = "Effects",
                    Effects = new SL_Effect[] {
                        new SL_AddStatusEffect {
                            StatusEffect = Constants.SPEED_OF_WINDS_II_IDENTIFIER
                        }
                    }
                }
            };
        }
    }
}