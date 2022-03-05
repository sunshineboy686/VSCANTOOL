using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANTOOL.Class
{
    class Can_Frame
    {
        public UInt32 FrameId;
        public byte CurrentCanNum;
        public byte FrameLengh;
        public string GetTime;
        public byte[] Buf = new Byte[64];

        public Can_Frame()
        {
            CurrentCanNum = 0;
            FrameId = 0;
            FrameLengh = 0;
            GetTime = null;
            Buf[0] = 0;
            Buf[1] = 0;
            Buf[2] = 0;
            Buf[3] = 0;
            Buf[4] = 0;
            Buf[5] = 0;
            Buf[6] = 0;
            Buf[7] = 0;

        }
    }
