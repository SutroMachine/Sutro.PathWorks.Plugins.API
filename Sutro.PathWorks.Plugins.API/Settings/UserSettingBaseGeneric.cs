using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public abstract class UserSettingBase<TProfile> : UserSettingBase
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
            LoadFromRaw((TProfile)settings);
        }

        public override void ApplyToRaw(object settings)
        {
            ApplyToRaw((TProfile)settings);
        }

        public override object GetFromRaw(object settings)
        {
            return GetFromRaw((TProfile)settings);
        }

        public override void SetToRaw(object settings, object value)
        {
            SetToRaw((TProfile)settings, value);
        }

        public abstract void LoadFromRaw(TProfile settings);

        public abstract void ApplyToRaw(TProfile settings);

        public abstract object GetFromRaw(TProfile settings);

        public abstract void SetToRaw(TProfile settings, object value);
    }
}