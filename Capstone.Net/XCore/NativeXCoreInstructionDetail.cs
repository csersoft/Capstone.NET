using System.Runtime.InteropServices;

namespace Capstone.Net.XCore {
    /// <summary>
    ///     Native XCore Instruction Detail.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativeXCoreInstructionDetail {
        /// <summary>
        ///     Instruction's Operands' Count.
        /// </summary>
        public byte OperandCount;

        /// <summary>
        ///     Instruction's Operands.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public NativeXCoreOperand[] Operands;
    }
}