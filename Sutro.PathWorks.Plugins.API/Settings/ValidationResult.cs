using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public readonly struct ValidationResult
    {
        public ValidationResult(ValidationResultLevel severity, string message, string settingName = null)
        {
            Severity = severity;
            Message = message;
            SettingName = settingName;
        }

        public ValidationResultLevel Severity { get; }
        public string SettingName { get; }
        public string Message { get; }

        public override bool Equals(object obj)
        {
            return obj is ValidationResult result &&
                   Severity == result.Severity &&
                   SettingName == result.SettingName &&
                   Message == result.Message;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Severity, SettingName, Message);
        }
    }
}