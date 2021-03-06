/*
 * Copyright 2018 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://floralicense.org/license
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace SystemInfo.Model.Led
{
    /// <summary>
    /// Class that is passed with LedChanged event.
    /// </summary>
    public class LedEventArgs
    {
        #region properties

        /// <summary>
        /// Gets LED's brightness.
        /// </summary>
        public int Brightness { get; }

        #endregion

        #region methods

        /// <summary>
        /// Class constructor that allows to set LED's brightness.
        /// </summary>
        /// <param name="brightness">LED's brightness.</param>
        public LedEventArgs(int brightness)
        {
            Brightness = brightness;
        }

        #endregion
    }
}