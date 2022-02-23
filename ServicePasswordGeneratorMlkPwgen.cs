﻿/* ------------------------------------------------------------------------- *
thZero.NetCore.Library.Services.PasswordGenerator.MlkPwgen
Copyright (C) 2016-2022 thZero.com

<development [at] thzero [dot] com>

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 * ------------------------------------------------------------------------- */

using System;

using MlkPwgen;

namespace thZero.Services
{
	public sealed class ServicePasswordGeneratorMlkPwgen : IServicePasswordGenerator
	{
		#region Public Methods
		public string Generate(int length, string allowed)
        {
            return PasswordGenerator.Generate(length, allowed);
		}

        public string GenerateAntiForgery(string name, int length = 15)
        {
            return string.Concat(name, Seperator, PasswordGenerator.Generate(length));
        }
        #endregion

        #region Constants
        private const string Seperator = ".";
        #endregion
    }
}