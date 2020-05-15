using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public abstract class UserSettingBase<TSettings> : UserSettingBase
    {
        // Can be used to hide settings in inherited UserSettingsCollection classes
        public bool Hidden { get; set; } = false;

        protected UserSettingBase(string id,
            Func<string> nameF,
            Func<string> descriptionF = null,
            UserSettingGroup group = null) : base(id, nameF, descriptionF, group)
        {
        }

        public override void LoadFromRaw(object settings)
        {
            LoadFromRaw((TSettings)settings);
        }

        public override void ApplyToRaw(object settings)
        {
            ApplyToRaw((TSettings)settings);
        }

        public override object GetFromRaw(object settings)
        {
            return GetFromRaw((TSettings)settings);
        }

        public override void SetToRaw(object settings, object value)
        {
            SetToRaw((TSettings)settings, value);
        }

        public abstract void LoadFromRaw(TSettings settings);

        public abstract void ApplyToRaw(TSettings settings);

        public abstract object GetFromRaw(TSettings settings);

        public abstract void SetToRaw(TSettings settings, object value);
    }
}
