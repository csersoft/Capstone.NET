using System.Runtime.InteropServices;

namespace Capstone.Net.Arm {
    /// <summary>
    ///     Native ARM Operand Shift.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativeArmOperandShift {
        /// <summary>
        ///     Shift Operation.
        /// </summary>
        public ArmShiftOperation Operation;

        /// <summary>
        ///     Shift Value.
        /// </summary>
        public int Value;
    }
}