using System.Runtime.InteropServices;

namespace Capstone.Net.M68K {
    /// <summary>
    ///     Native M68K Register Pair Operand Value.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativeM68KRegisterPairOperandValue {
        /// <summary>
        ///     First Register Value.
        /// </summary>
        public M68KRegisterId Register0;

        /// <summary>
        ///     Second Register Value.
        /// </summary>
        public M68KRegisterId Register1;
    }
}