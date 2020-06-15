using System.Runtime.InteropServices;

namespace Capstone.Net.PowerPc {
    /// <summary>
    ///     Native PowerPC Operand.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativePowerPcOperand {
        /// <summary>
        ///     Operand's Type.
        /// </summary>
        public PowerPcOperandType Type;

        /// <summary>
        ///     Operand's Value.
        /// </summary>
        public NativePowerPcOperandValue Value;
    }
}