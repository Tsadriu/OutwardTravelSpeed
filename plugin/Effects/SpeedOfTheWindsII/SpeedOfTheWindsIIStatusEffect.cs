using SideLoader;

namespace SpeedOfTheWinds.Effects {
	public class SpeedOfTheWindsIIStatusEffect : SL_StatusEffect {
		public SpeedOfTheWindsIIStatusEffect() {
			TargetStatusIdentifier = "Speed Up";
			NewStatusID = -12000;
			StatusIdentifier = Constants.SPEED_OF_WINDS_II_IDENTIFIER;
			Name = "Speed of the Winds II";
			Description = "Greately increases your movement speed while you're not in combat.";
			Purgeable = true;
			DisplayedInHUD = true;
			IsMalusEffect = false;
			Lifespan = 1200;
			RefreshRate = 1f;
			AmplifiedStatusIdentifier = string.Empty;
			FamilyMode = StatusEffect.FamilyModes.Bind;
			EffectBehaviour = EditBehaviours.Destroy;
			Effects = new SL_EffectTransform[] {
				new SL_EffectTransform {
					TransformName = "Effects",
					Effects = new SL_Effect[] {
						new SpeedOfTheWindsIEffectTemplate()
					}
				}
			};
		}
	}
}