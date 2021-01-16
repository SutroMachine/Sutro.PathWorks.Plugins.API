using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sutro.PathWorks.Plugins.API
{
    public class Result
    {
        /// <summary>
        /// Description of why the result failed; only populated if result is unsuccessful
        /// </summary>
        public string Error { get; }

        public bool IsFailure => !IsSuccessful;
        public bool IsSuccessful { get; }

        /// <summary>
        /// List of non-critical warnings; only populated if result is successful
        /// </summary>
        public IReadOnlyCollection<string> Warnings { get; }

        protected Result(IEnumerable<string> warnings = null)
        {
            IsSuccessful = true;
            Warnings = new ReadOnlyCollection<string>(warnings?.ToList() ?? new List<string>());
            Error = string.Empty;
        }

        protected Result(string error)
        {
            IsSuccessful = false;
            Warnings = new ReadOnlyCollection<string>(new List<string>());
            Error = error;
        }

        public static Result Fail(string error)
        {
            return new Result(error);
        }

        public static Result Ok(IEnumerable<string> warnings = null)
        {
            return new Result(warnings);
        }
    }

    public class Result<T> : Result
    {
        /// <summary>
        /// Value of the result; only populated if result is successful
        /// </summary>

        public T Value { get; }

        private Result(T value, IEnumerable<string> warnings = null) : base(warnings)
        {
            Value = value;
        }

        private Result(string error) : base(error)
        {
        }

        new public static Result<T> Fail(string error)
        {
            return new Result<T>(error);
        }

        public static Result<T> Ok(T value, IEnumerable<string> warnings = null)
        {
            return new Result<T>(value, warnings);
        }
    }
}