using System;
using System.Linq;
using SideLoader;
using SpeedOfTheWinds.Extensions;
using UnityEngine;

namespace SpeedOfTheWinds.Effects
{
    public class SpeedOfTheWindsIIEffect : Effect, ICustomModel
    {
        private const float DefaultSpeed = 4.0f;
        private float lastCombatTime = Time.time;

        public Type SLTemplateModel => typeof(SpeedOfTheWindsIIEffectTemplate);
        public Type GameModel => typeof(SpeedOfTheWindsIIEffect);

        private void ResetStatus(Character character)
        {
            lastCombatTime = Time.time;
            character.Speed = DefaultSpeed;
        }

        private float GetActualSpeedMultiplier()
        {
            float timeRatio = Mathf.Clamp((Time.time - lastCombatTime) / Constants.SPEED_OF_WINDS_II_SPEED_TIME_TO_MAX, 0.0f, 1.0f);
            return Constants.SPEED_OF_WINDS_II_SPEED_MULTIPLIER_MIN + timeRatio * (Constants.SPEED_OF_WINDS_II_SPEED_MULTIPLIER_MAX - Constants.SPEED_OF_WINDS_II_SPEED_MULTIPLIER_MIN);
        }

        private void SetStaminaBurnMultiplier(Character character, float value)
        {
            character.Stats.GetStat(CharacterStats.StatType.StaminaBurn).AddMultiplierStack(Constants.SPEED_OF_WINDS_II_IDENTIFIER, value);
        }

        private void RemoveStaminaBurnMultiplier(Character character)
        {
            character.Stats.GetStat(CharacterStats.StatType.StaminaBurn).RemoveMultiplierStack(Constants.SPEED_OF_WINDS_II_IDENTIFIER);
        }

        public override void ActivateLocally(Character _affectedCharacter, object[] _infos)
        {
            if (_affectedCharacter.EngagedCharacters.Any(it => it))
            {
                ResetStatus(_affectedCharacter);
                m_parentStatusEffect.SetTimerSuspended(true);
            }
            else
            {
                float speedMultiplier = GetActualSpeedMultiplier();
                _affectedCharacter.Speed = DefaultSpeed * speedMultiplier;
                SetStaminaBurnMultiplier(_affectedCharacter, speedMultiplier);
                m_parentStatusEffect.SetTimerSuspended(false);
            }
        }

        public override void StopAffectLocally(Character _affectedCharacter)
        {
            ResetStatus(_affectedCharacter);
            m_parentStatusEffect.SetTimerSuspended(false);
        }
    }
}