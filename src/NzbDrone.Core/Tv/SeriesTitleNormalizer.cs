﻿using System.Collections.Generic;

namespace NzbDrone.Core.Tv
{
    public static class SeriesTitleNormalizer
    {
        private readonly static Dictionary<int, string> PreComputedTitles = new Dictionary<int, string>
                                                                     {
                                                                         { 281588, "a to z" },
                                                                         { 289260, "ad bible continues"},
                                                                         { 328534, "ap bio"}
                                                                     };

        public static string Normalize(string title, int tvdbId)
        {
            if (PreComputedTitles.ContainsKey(tvdbId))
            {
                return PreComputedTitles[tvdbId];
            }

            return Parser.Parser.NormalizeTitle(title).ToLower();
        }
    }
}
