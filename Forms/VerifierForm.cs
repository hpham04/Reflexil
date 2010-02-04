﻿/*
    Reflexil .NET assembly editor.
    Copyright (C) 2007-2009 Sebastien LEBRETON

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#region " Imports "
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mono.Cecil;
using Reflexil.Editors;
using Reflexil.Handlers;
using Reflexil.Plugins;
using Reflexil.Utils;
using System.Collections;
using Reflexil.Verifier;
#endregion

namespace Reflexil.Forms
{
	public partial class VerifierForm: Form
    {

        #region " Methods "
        public VerifierForm()
		{
			InitializeComponent();
        }

        public void ShowDialog(IEnumerable<VerificationError> errors)
        {
            VerificationErrorBindingSource.DataSource = errors;
            base.ShowDialog();
        }
        #endregion

    }
}