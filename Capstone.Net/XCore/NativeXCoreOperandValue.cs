using System.Runtime.InteropServices;

namespace Capstone.Net.XCore {
    /// <summary>
    ///     Native XCore Operand Value.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal struct NativeXCoreOperandValue {
        /// <summary>
        ///     Register Value.
        /// </summary>
        [FieldOffset(0)]
        public XCoreRegisterId Register;

        /// <summary>
        ///     Immediate Value.
        /// </summary>
        [FieldOffset(0)]
        public int Immediate;

        /// <summary>
        ///     Memory Value.
        /// </summary>
        [FieldOffset(0)]
        public NativeXCoreMemoryOperandValue Memory;
    }
}