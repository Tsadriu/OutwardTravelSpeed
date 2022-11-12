using System;
using SideLoader;

namespace SpeedOfTheWinds.Effects {
	public class SpeedOfTheWindsIEffectTemplate : SL_Effect, ICustomModel {
		public Type SLTemplateModel => typeof(SpeedOfTheWindsIEffectTemplate);
		public Type GameModel => typeof(SpeedOfTheWindsIEffect);

		public override void ApplyToComponent<T>(T component) { }
		public override void SerializeEffect<T>(T effect) { }
	}
}