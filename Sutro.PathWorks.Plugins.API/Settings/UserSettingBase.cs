using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public abstract class UserSettingBase
    {
        private readonly Func<string> nameF;
        private readonly Func<string> descriptionF;
        private readonly Func<string> unitsF;

        public string Name => nameF();
        public string Id { get; }
        public string Description => descriptionF();

        public string Units => unitsF();

        public virtual string Range { get; } = null;

        public UserSettingGroup Group { get; }

        public abstract void LoadFromRaw(object settings);

        public abstract void ApplyToRaw(object settings);

        public abstract object GetFromRaw(object settings);

        public abstract void SetToRaw(object settings, object value);

        public abstract ValidationResult Validation { get; }
        // Can be used to hide settings in inherited UserSettingsCollection classes
        public bool Hidden { get; set; } = false;

        public abstract ValidationResult Validate(object value);

        protected UserSettingBase(string id, Func<string> nameF, 
            Func<string> descriptionF = null, 
            UserSettingGroup group = null,
            Func<string> unitsF = null)
        {
            this.nameF = nameF;
            this.descriptionF = descriptionF;
            this.unitsF = unitsF;
            Group = group;
            Id = id;
        }
    }
}