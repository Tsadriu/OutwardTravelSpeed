namespace SpeedOfTheWinds
{
    public class Constants
    {
        /// <summary>
        /// The <b>Speed of the Winds I</b> <u>identifier</u>.
        /// </summary>
        public const string SPEED_OF_WINDS_I_IDENTIFIER = "SpeedOfTheWindsI";

        /// <summary>
        /// The <b>Speed of the Winds I</b> <u>recipe name</u>.
        /// </summary>
        public const string SPEED_OF_WINDS_I_POTION_RECIPE_NAME = SpeedOfTheWinds.GUID + ".I";

        /// <summary>
        /// The <b>Speed of the Winds I</b> <u>drop table UID</u>.
        /// </summary>
        public const string SPEED_OF_WINDS_I_DROPTABLE_UID = SPEED_OF_WINDS_I_POTION_RECIPE_NAME + ".droptable";

        /// <summary>
        /// The minimum speed this potion provides.
        /// </summary>
        public const float SPEED_OF_WINDS_I_SPEED_MULTIPLIER_MIN = 1.12f;

        /// <summary>
        /// The maximum speed this potion provides.
        /// </summary>
        public const float SPEED_OF_WINDS_I_SPEED_MULTIPLIER_MAX = 2.25f;

        /// <summary>
        /// The time it takes to reach maximum speed <b>(in seconds)</b>.
        /// </summary>
        public const float SPEED_OF_WINDS_I_SPEED_TIME_TO_MAX = 75f; // In seconds

        /// <summary>
        /// The <b>Speed of the Winds II</b> <u>identifier</u>.
        /// </summary>
        public const string SPEED_OF_WINDS_II_IDENTIFIER = "SpeedOfTheWindsII";

        /// <summary>
        /// The <b>Speed of the Winds II</b> <u>recipe name</u>.
        /// </summary>
        public const string SPEED_OF_WINDS_II_POTION_RECIPE_NAME = SpeedOfTheWinds.GUID + ".II";

        /// <summary>
        /// The <b>Speed of the Winds II</b> <u>drop table UID</u>.
        /// </summary>
        public const string SPEED_OF_WINDS_II_DROPTABLE_UID = SPEED_OF_WINDS_II_POTION_RECIPE_NAME + ".droptable";

        /// <summary>
        /// The minimum speed this potion provides.
        /// </summary>
        public const float SPEED_OF_WINDS_II_SPEED_MULTIPLIER_MIN = 1.25f;

        /// <summary>
        /// The maximum speed this potion provides.
        /// </summary>
        public const float SPEED_OF_WINDS_II_SPEED_MULTIPLIER_MAX = 3.50f;

        /// <summary>
        /// The time it takes to reach maximum speed <b>(in seconds)</b>.
        /// </summary>
        public const float SPEED_OF_WINDS_II_SPEED_TIME_TO_MAX = 20f;
    }
}