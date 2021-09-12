// <copyright file="CloudIDs.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CloudOnce
{
#if (UNITY_ANDROID || UNITY_IOS || UNITY_TVOS) && !UNITY_EDITOR
    using Internal;
    using UnityEngine;
#endif
    /// <summary>
    /// Provides access to achievement- and leaderboard IDs registered via the CloudOnce Editor.
    /// This file was automatically generated by CloudOnce. Do not edit.
    /// </summary>
    public static class CloudIDs
    {
        /// <summary>
        /// Contains properties that retrieves achievement IDs for the current platform.
        /// </summary>
        public static class AchievementIDs
        {
        }

        /// <summary>
        /// Contains properties that retrieves leaderboard IDs for the current platform.
        /// </summary>
        public static class LeaderboardIDs
        {
            public static string AscendBallHighScore
            {
                get
                {
#if UNITY_ANDROID && !UNITY_EDITOR
#if CLOUDONCE_GOOGLE
                    return "CgkIh5TAsZEREAIQAA";
#else
                    return string.Empty;
#endif
#elif (UNITY_IOS || UNITY_TVOS) && !UNITY_EDITOR
                    return "com.ascendball.leaderboard";
#elif UNITY_EDITOR
                    return "AscendBallHighScore";
#else
                    return string.Empty;
#endif
                }
            }

            public static string ColorShiftHighScore
            {
                get
                {
#if UNITY_ANDROID && !UNITY_EDITOR
#if CLOUDONCE_GOOGLE
                    return "CgkIh5TAsZEREAIQAQ";
#else
                    return string.Empty;
#endif
#elif (UNITY_IOS || UNITY_TVOS) && !UNITY_EDITOR
                    return "com.colorshift.leaderboard";
#elif UNITY_EDITOR
                    return "ColorShiftHighScore";
#else
                    return string.Empty;
#endif
                }
            }

            public static string DropBallHighScore
            {
                get
                {
#if UNITY_ANDROID && !UNITY_EDITOR
#if CLOUDONCE_GOOGLE
                    return "CgkIh5TAsZEREAIQAg";
#else
                    return string.Empty;
#endif
#elif (UNITY_IOS || UNITY_TVOS) && !UNITY_EDITOR
                    return "com.dropball.leaderboard";
#elif UNITY_EDITOR
                    return "DropBallHighScore";
#else
                    return string.Empty;
#endif
                }
            }
        }
    }
}