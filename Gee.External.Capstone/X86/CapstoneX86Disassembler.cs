﻿namespace Gee.External.Capstone.X86 {
    /// <summary>
    ///     Capstone X86 Disassembler.
    /// </summary>
    public sealed class CapstoneX86Disassembler : CapstoneDisassembler<X86DisassembleMode, X86Instruction, X86InstructionDetail, X86InstructionGroup, X86InstructionGroupId, X86InstructionId, X86Register, X86RegisterId> {
        /// <summary>
        ///     Determine if Reduce Mode is Enabled.
        /// </summary>
        /// <value>
        ///     A boolean true if reduce mode is enabled. A boolean false otherwise.
        /// </value>
        public bool IsReduceModeEnabled => CapstoneDisassembler.IsX86ReduceModeEnabled;

        /// <summary>
        ///     Create a Capstone X86 Disassembler.
        /// </summary>
        /// <param name="disassembleMode"></param>
        public CapstoneX86Disassembler(X86DisassembleMode disassembleMode) : base(DisassembleArchitecture.X86, disassembleMode) { }

        /// <summary>
        ///     Create an Instruction.
        /// </summary>
        /// <param name="hInstruction">
        ///     An instruction handle.
        /// </param>
        /// <returns>
        ///     An X86 instruction.
        /// </returns>
        private protected override X86Instruction CreateInstruction(NativeInstructionHandle hInstruction) {
            // ...
            //
            // Throws an exception if the operation fails.
            var instruction = X86Instruction.Create(this, hInstruction);
            return instruction;
        }
    }
}