using SideLoader;

namespace SpeedOfTheWinds.Effects {
	public class SpeedOfTheWindsIStatusEffect : SL_StatusEffect {
		public SpeedOfTheWindsIStatusEffect() {
			TargetStatusIdentifier = "Speed Up";
			NewStatusID = -12000;
			StatusIdentifier = Constants.SPEED_OF_WINDS_I_IDENTIFIER;
			Name = "Speed of the Winds I";
			Description = "Increases your movement speed while you're not in combat. Burns more stamina the faster you are.";
			Purgeable = true;
			DisplayedInHUD = true;
			IsMalusEffect = false;
			Lifespan = 600;
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