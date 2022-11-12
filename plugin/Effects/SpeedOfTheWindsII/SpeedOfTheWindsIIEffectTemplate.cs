using System;
using SideLoader;

namespace SpeedOfTheWinds.Effects
{
	public class SpeedOfTheWindsIIEffectTemplate : SL_Effect, ICustomModel
	{
		public Type SLTemplateModel => typeof(SpeedOfTheWindsIIEffectTemplate);
		public Type GameModel => typeof(SpeedOfTheWindsIIEffect);

		public override void ApplyToComponent<T>(T component) { }
		public override void SerializeEffect<T>(T effect) { }
	}
}