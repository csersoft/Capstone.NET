using System.Runtime.InteropServices;

namespace Capstone.Net.PowerPc {
    /// <summary>
    ///     Native PowerPC Memory Operand Value.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativePowerPcMemoryOperandValue {
        /// <summary>
        ///     Base Register.
        /// </summary>
        public PowerPcRegisterId Base;

        /// <summary>
        ///     Displacement Value.
        /// </summary>
        public int Displacement;
    }
}