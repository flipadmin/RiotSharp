﻿using Newtonsoft.Json;
using RiotSharp.Misc.Converters;

namespace RiotSharp.Misc
{
    /// <summary>
    /// Platform for the API.
    /// </summary>
    [JsonConverter(typeof(PlatformConverter))]
    public enum Platform
    {
        /// <summary>
        /// North America.
        /// </summary>
        NA1,

        /// <summary>
        /// Brasil.
        /// </summary>
        BR1,

        /// <summary>
        /// Latin America North.
        /// </summary>
        LA1,

        /// <summary>
        /// Latin America South.
        /// </summary>
        LA2,

        /// <summary>
        /// Oceania.
        /// </summary>
        OC1,

        /// <summary>
        /// North-eastern Europe.
        /// </summary>
        EUN1,

        /// <summary>
        /// Turkey.
        /// </summary>
        TR1,

        /// <summary>
        /// Russia.
        /// </summary>
        RU,

        /// <summary>
        /// Western Europe.
        /// </summary>
        EUW1,

        /// <summary>
        /// Korea.
        /// </summary>
        KR,

        /// <summary>
        /// Japan.
        /// </summary>
        JP1,

        /// <summary>
        /// The Philippines
        /// </summary>
        PH2,

        /// <summary>
        /// Singapore, Malaysia, & Indonesia
        /// </summary>
        SG2,

        /// <summary>
        /// Thailand
        /// </summary>
        TH2,

        /// <summary>
        /// Taiwan, Hong Kong, and Macao
        /// </summary>
        TW2,

        /// <summary>
        /// Vietnam
        /// </summary>
        VN2,

        /// <summary>
        /// Middle east
        /// </summary>
        ME1,

        /// <summary>
        /// No Platform (e.g. platformId of bot players).
        /// </summary>
        NoPlatform
    }
}
