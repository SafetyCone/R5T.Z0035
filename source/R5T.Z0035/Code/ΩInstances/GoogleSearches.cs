using System;


namespace R5T.Z0035
{
    public class GoogleSearches : IGoogleSearches
    {
        #region Infrastructure

        public static IGoogleSearches Instance { get; } = new GoogleSearches();


        private GoogleSearches()
        {
        }

        #endregion
    }
}
