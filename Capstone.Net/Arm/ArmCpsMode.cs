﻿using System.Diagnostics.CodeAnalysis;

namespace Capstone.Net.Arm {
    /// <summary>
    ///     ARM CPS Mode.
    /// </summary>
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum ArmCpsMode {
        /// <summary>
        ///     Indicates an invalid, or an uninitialized, CPS mode.
        /// </summary>
        Invalid = 0,
        ARM_CPSMODE_IE = 2,
        ARM_CPSMODE_ID = 3
    }
}