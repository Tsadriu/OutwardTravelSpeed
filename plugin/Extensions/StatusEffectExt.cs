namespace SpeedOfTheWinds.Extensions
{
    public class StatusEffectExt
    {
        private bool isTimerSuspended = false;

        public bool TimerSuspended
        {
            get => isTimerSuspended;
            set => isTimerSuspended = value;
        }
    }
}