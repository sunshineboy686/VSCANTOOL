using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANTOOL
{
    class SendCANInfo
    {
        public UInt32 canID;
        public byte canCH;
        public byte frameType;                      //0-标准帧  1-扩展帧
        public byte frameFormat;                    //0-数据帧  1-远程帧
        public byte sendLen;                        //发送数据长度
        public byte[] dataBuf;                      //发送的数据内容
        public int sendCnt;                         //发送的次数
        public int cntInterTime;                    //发送的间隔时间


        public SendCANInfo()
        {
            canID = 0;
            frameType = 0;
            frameFormat = 0;
            sendLen = 0;
            dataBuf = new byte[256];
            sendCnt = 0;
            cntInterTime = 0;
            canCH = 0;
        }

    }
}
