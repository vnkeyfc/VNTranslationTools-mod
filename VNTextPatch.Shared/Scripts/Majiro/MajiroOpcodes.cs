﻿using System.Collections.Generic;

namespace VNTextPatch.Shared.Scripts.Majiro
{
    internal static class MajiroOpcodes
    {
        public static readonly Dictionary<short, string> OperandTemplates =
            new Dictionary<short, string>
            {
                { 0x0100, "" },    // mul.i
                { 0x0101, "" },    // mul.r
                { 0x0108, "" },    // div.i
                { 0x0109, "" },    // div.r
                { 0x0110, "" },    // rem
                { 0x0118, "" },    // add.i
                { 0x0119, "" },    // add.r
                { 0x011A, "" },    // add.s
                { 0x0120, "" },    // sub.i
                { 0x0121, "" },    // sub.r
                { 0x0128, "" },    // shr
                { 0x0130, "" },    // shl
                { 0x0138, "" },    // cle.i
                { 0x0139, "" },    // cle.r
                { 0x013A, "" },    // cle.s
                { 0x0140, "" },    // clt.i
                { 0x0141, "" },    // clt.r
                { 0x0142, "" },    // clt.s
                { 0x0148, "" },    // cge.i
                { 0x0149, "" },    // cge.r
                { 0x014A, "" },    // cge.s
                { 0x0150, "" },    // cgt.i
                { 0x0151, "" },    // cgt.r
                { 0x0152, "" },    // cgt.s
                { 0x0158, "" },    // ceq.i
                { 0x0159, "" },    // ceq.r
                { 0x015A, "" },    // ceq.s
                { 0x015B, "" },    // ceq.iarr
                { 0x015C, "" },    // ceq.rarr
                { 0x015D, "" },    // ceq.sarr
                { 0x0160, "" },    // cne.i
                { 0x0161, "" },    // cne.r
                { 0x0162, "" },    // cne.s
                { 0x0163, "" },    // cne.iarr
                { 0x0164, "" },    // cne.rarr
                { 0x0165, "" },    // cne.sarr
                { 0x0168, "" },    // xor
                { 0x0170, "" },    // andl
                { 0x0178, "" },    // orl
                { 0x0180, "" },    // and
                { 0x0188, "" },    // or
                { 0x0190, "" },    // notl
                { 0x0191, "" },    // nop.191
                { 0x0198, "" },    // not
                { 0x01A0, "" },    // neg.i
                { 0x01A1, "" },    // neg.r
                { 0x01A8, "" },    // nop.1a8
                { 0x01A9, "" },    // nop.1a9
                { 0x01B0, "fho" },      // st.i
                { 0x01B1, "fho" },      // st.r
                { 0x01B2, "fho" },      // st.s
                { 0x01B3, "fho" },      // st.iarr
                { 0x01B4, "fho" },      // st.rarr
                { 0x01B5, "fho" },      // st.sarr
                { 0x01B8, "fho" },      // st.mul.i
                { 0x01B9, "fho" },      // st.mul.r
                { 0x01C0, "fho" },      // st.div.i
                { 0x01C1, "fho" },      // st.div.r
                { 0x01C8, "fho" },      // st.rem
                { 0x01D0, "fho" },      // st.add.i
                { 0x01D1, "fho" },      // st.add.r
                { 0x01D2, "fho" },      // st.add.s
                { 0x01D8, "fho" },      // st.sub.i
                { 0x01D9, "fho" },      // st.sub.r
                { 0x01E0, "fho" },      // st.shl
                { 0x01E8, "fho" },      // st.shr
                { 0x01F0, "fho" },      // st.and
                { 0x01F8, "fho" },      // st.xor
                { 0x0200, "fho" },      // st.or
                { 0x0210, "fho" },      // stp.i
                { 0x0211, "fho" },      // stp.r
                { 0x0212, "fho" },      // stp.s
                { 0x0213, "fho" },      // stp.iarr
                { 0x0214, "fho" },      // stp.rarr
                { 0x0215, "fho" },      // stp.sarr
                { 0x0218, "fho" },      // stp.mul.i
                { 0x0219, "fho" },      // stp.mul.r
                { 0x0220, "fho" },      // stp.div.i
                { 0x0221, "fho" },      // stp.div.r
                { 0x0228, "fho" },      // stp.rem
                { 0x0230, "fho" },      // stp.add.i
                { 0x0231, "fho" },      // stp.add.r
                { 0x0232, "fho" },      // stp.add.s
                { 0x0238, "fho" },      // stp.sub.i
                { 0x0239, "fho" },      // stp.sub.r
                { 0x0240, "fho" },      // stp.shl
                { 0x0248, "fho" },      // stp.shr
                { 0x0250, "fho" },      // stp.and
                { 0x0258, "fho" },      // stp.xor
                { 0x0260, "fho" },      // stp.or
                { 0x0270, "fho" },      // stelem.i
                { 0x0271, "fho" },      // stelem.r
                { 0x0272, "fho" },      // stelem.s
                { 0x0278, "fho" },      // stelem.mul.i
                { 0x0279, "fho" },      // stelem.mul.r
                { 0x0280, "fho" },      // stelem.div.i
                { 0x0281, "fho" },      // stelem.div.r
                { 0x0288, "fho" },      // stelem.rem
                { 0x0290, "fho" },      // stelem.add.i
                { 0x0291, "fho" },      // stelem.add.r
                { 0x0292, "fho" },      // stelem.add.s
                { 0x0298, "fho" },      // stelem.sub.i
                { 0x0299, "fho" },      // stelem.sub.r
                { 0x02A0, "fho" },      // stelem.shl
                { 0x02A8, "fho" },      // stelem.shr
                { 0x02B0, "fho" },      // stelem.and
                { 0x02B8, "fho" },      // stelem.xor
                { 0x02C0, "fho" },      // stelem.or
                { 0x02D0, "fho" },      // stelemp.i
                { 0x02D1, "fho" },      // stelemp.r
                { 0x02D2, "fho" },      // stelemp.s
                { 0x02D8, "fho" },      // stelemp.mul.i
                { 0x02D9, "fho" },      // stelemp.mul.r
                { 0x02E0, "fho" },      // stelemp.div.i
                { 0x02E1, "fho" },      // stelemp.div.r
                { 0x02E8, "fho" },      // stelemp.rem
                { 0x02F0, "fho" },      // stelemp.add.i
                { 0x02F1, "fho" },      // stelemp.add.r
                { 0x02F2, "fho" },      // stelemp.add.s
                { 0x02F8, "fho" },      // stelemp.sub.i
                { 0x02F9, "fho" },      // stelemp.sub.r
                { 0x0300, "fho" },      // stelemp.shl
                { 0x0308, "fho" },      // stelemp.shr
                { 0x0310, "fho" },      // stelemp.and
                { 0x0318, "fho" },      // stelemp.xor
                { 0x0320, "fho" },      // stelemp.or
                { 0x0800, "i" },        // ldc.i
                { 0x0801, "s" },        // ldstr
                { 0x0802, "fho" },      // ld
                { 0x0803, "r" },        // ldc.r
                { 0x080F, "h0a" },      // call
                { 0x0810, "h0a" },      // callp
                { 0x0829, "t" },        // alloca
                { 0x082B, "" },         // ret
                { 0x082C, "j" },        // br
                { 0x082D, "j" },        // brtrue
                { 0x082E, "j" },        // brfalse
                { 0x082F, "" },         // pop
                { 0x0830, "j" },        // br.case
                { 0x0831, "j" },        // bne.case
                { 0x0832, "j" },        // bge.case
                { 0x0833, "j" },        // ble.case
                { 0x0834, "ha" },       // syscall
                { 0x0835, "ha" },       // syscallp
                { 0x0836, "t" },        // argcheck
                { 0x0837, "fho" },      // ldelem
                { 0x0838, "j" },        // blt.case
                { 0x0839, "j" },        // bgt.case
                { 0x083A, "l" },        // line
                { 0x083B, "j" },        // bsel.1
                { 0x083C, "j" },        // bsel.3
                { 0x083D, "j" },        // bsel.2
                { 0x083E, "" },         // conv.i
                { 0x083F, "" },         // conv.r
                { 0x0840, "s" },        // text
                { 0x0841, "" },         // proc
                { 0x0842, "s" },        // ctrl
                { 0x0843, "j" },        // bsel.x
                { 0x0844, "" },         // bsel.clr
                { 0x0845, "j" },        // bsel.4
                { 0x0846, "" },         // bsel.jmp.4
                { 0x0847, "j" },        // bsel.5
                { 0x0850, "c" }         // switch
            };

        public const int Text = 0x0840;
        public const int Proc = 0x0841;
        public const int Ctrl = 0x0842;
        public const int Line = 0x083A;
        public const int LdcI = 0x0800;
        public const int Ldstr = 0x0801;
        public const int Call = 0x080F;
        public const int Callp = 0x0810;
        public const int Ret = 0x082B;
    }
}
