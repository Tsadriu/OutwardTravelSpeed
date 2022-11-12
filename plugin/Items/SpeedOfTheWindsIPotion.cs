using SideLoader;

namespace SpeedOfTheWinds.Items
{
    public class SpeedOfTheWindsIPotion : SL_Item
    {
        public SpeedOfTheWindsIPotion()
        {
            Target_ItemID = 4300130;
            New_ItemID = -12000;
            Name = "Speed of the Winds I";
            Description = $"Drinking this potion will gradually increase your movement speed up to x{Constants.SPEED_OF_WINDS_I_SPEED_MULTIPLIER_MAX} faster than your normal movement speed for 10 minutes. Engaging in combat will disable this effect and pause the effect's countdown. Gradually consumes more stamina the faster you are.";
            StatsHolder = new SL_ItemStats
            {
                BaseValue = 10,
                RawWeight = 0.2f
            };
            EffectBehaviour = EditBehaviours.Destroy;
            EffectTransforms = new SL_EffectTransform[] {
                new SL_EffectTransform {
                    TransformName = "Effects",
                    Effects = new SL_Effect[] {
                        new SL_AddStatusEffect {
                            StatusEffect = Constants.SPEED_OF_WINDS_I_IDENTIFIER
                        }
                    }
                }
            };
        }
    }
}