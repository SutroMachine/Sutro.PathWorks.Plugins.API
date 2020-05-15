using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public abstract class UserSettingBase
    {
        private readonly Func<string> nameF;
        private readonly Func<string> descriptionF;

        public string Name => nameF();
        public string Id { get; }
        public string Description => descriptionF();

        public UserSettingGroup Group { get; }

        public abstract void LoadFromRaw(object settings);

        public abstract void ApplyToRaw(object settings);

        public abstract object GetFromRaw(object settings);

        public abstract void SetToRaw(object settings, object value);

        public abstract ValidationResult Validation { get; }

        public abstract ValidationResult Validate(object value);

        protected UserSettingBase(string id, Func<string> nameF, Func<string> descriptionF = null, UserSettingGroup group = null)
        {
            this.nameF = nameF;
            this.descriptionF = descriptionF;
            Group = group;
            Id = id;
        }
    }

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

    public class UserSetting<TSettings, TValue> : UserSettingBase<TSettings>
    {
        public TValue Value { get; set; }

        private readonly Func<TValue, ValidationResult> validateF;
        private readonly Func<TSettings, TValue> loadF;
        private readonly Action<TSettings, TValue> applyF;

        public UserSetting(
            string id,
            Func<string> nameF,
            Func<string> descriptionF,
            UserSettingGroup group,
            Func<TSettings, TValue> loadF,
            Action<TSettings, TValue> applyF,
            Func<TValue, ValidationResult> validateF = null) : base(id, nameF, descriptionF, group)
        {
            this.validateF = validateF;
            this.applyF = applyF;
            this.loadF = loadF;
        }

        public override void LoadFromRaw(TSettings settings)
        {
            Value = loadF(settings);
        }

        public override void ApplyToRaw(TSettings settings)
        {
            applyF(settings, Value);
        }

        public override object GetFromRaw(TSettings settings)
        {
            return loadF(settings);
        }

        public override void SetToRaw(TSettings settings, object value)
        {
            TValue tValue;
            try
            {
                tValue = (TValue)Convert.ChangeType(value, typeof(TValue));
            }
            catch (Exception e)
            {
                throw new InvalidCastException($"Setting {Name}: Function SetToRaw received an object of type {value.GetType()}, expected {typeof(TValue)}.", e);
            }
            applyF(settings, tValue);
        }

        public override ValidationResult Validation
        {
            get
            {
                if (validateF != null)
                    return validateF(Value);
                return new ValidationResult();
            }
        }

        public override ValidationResult Validate(object value)
        {
            if (value is TValue tValue)
            {
                if (validateF != null)
                    return validateF(tValue);
                return new ValidationResult();
            }
            return new ValidationResult(ValidationResultLevel.Error, "Invalid cast");
        }
    }
}