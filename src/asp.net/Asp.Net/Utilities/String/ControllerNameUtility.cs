namespace NCommons.Asp.Net.Utilities.String
{
    public static class ControllerNameUtility
    {
        public const string CONTROLLER_NAME_POSTFIX = "Controller";

        public static string GetControllerPath(string name)
        {
            var nameEndsWithControllerNamePostfix = name.EndsWith(CONTROLLER_NAME_POSTFIX);

            string result = name;

            if (nameEndsWithControllerNamePostfix)
            {
                var lengthWithoutControllerNamePostfix = name.Length - CONTROLLER_NAME_POSTFIX.Length;

                result = name.Substring(0, lengthWithoutControllerNamePostfix);
            }

            return result;
        }
    }
}