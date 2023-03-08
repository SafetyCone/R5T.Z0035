using System;

using R5T.R0008.Extensions;
using R5T.R0008.T000;
using R5T.T0131;


namespace R5T.Z0035
{
    [ValuesMarker]
    public partial interface IGoogleSearches : IValuesMarker
    {
        /// <summary>
        /// <see href="https://www.google.com/search?q=create+an+empty+service+provider"/>
        /// </summary>
        public Link CreateAnEmptyServiceProvider => "https://www.google.com/search?q=create+an+empty+service+provider".ToLink();
    }
}
