using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANTOOL.Class
{

    public enum Direction
    {
        HEAD = 0,
        COMMAND,
        COMMAND1,
        LENGTH0,
        LENGTH1,
        DATA,
        CHECKSUM1,
        CHECKSUM2,
        END,


    };
    class USB_COM
    {
        public Direction Dirc; //= Direction.HEAD;
        public UInt16 ReciveCmd;
        public UInt16 ReciveDatalen;

        byte[] ReciveBuf;
        byte[] SendBuf;
        byte[] USBTBuf;
        UInt16 ReciveCntIndex;
        public bool CAN1InItFlag;
        public bool CAN2InItFlag;

        public UInt16 FrameInIndex;
        public UInt16 FrameOutIndex;
        public Can_Frame[] FrameBuf = new Can_Frame[1024];
        public bool COMOpenFlag;
        public object frameBufLock = new object();




        public USB_COM()
        {
            //
            Dirc = Direction.HEAD;
            ReciveCmd = 0;
            ReciveDatalen = 0;

            CAN1InItFlag = false;
            CAN2InItFlag = false;
            ReciveBuf = new byte[600];
            SendBuf = new byte[600];
            USBTBuf = new byte[256];
            FrameInIndex = 0;
            FrameOutIndex = 0;
            ReciveCntIndex = 0;
            for (int i = 0; i < 1024; i++)
            {
                FrameBuf[i] = new Can_Frame();
            }
            COMOpenFlag = false;



        }
     
        public UInt16 Send_Data_Responne(UInt16 command, UInt16 ResponeCommand, byte[] Buf, UInt16 length)
        {


            if (!ConfigForm.configForm.PortCom.IsOpen)
            {
                
                ConfigForm.configForm.DataTextBox.AppendText("请先连接设备");
                return 0;
            }
            UInt16 ProIndex = 0;
            UInt16 PackIndex = 0;
            UInt16 TLength = 0;
            byte CheckSum = 0;
            TLength = length;
            TLength += 2;
            SendBuf[ProIndex++] = 0x23;
            SendBuf[ProIndex++] = (byte)((command >> 8) & 0xff);
            SendBuf[ProIndex++] = (byte)(command & 0xff);
            SendBuf[ProIndex++] = (byte)((TLength >> 8) & 0xff);
            SendBuf[ProIndex++] = (byte)(TLength & 0xff);

            SendBuf[ProIndex] = (byte)((ResponeCommand >> 8) & 0xff);
            CheckSum += SendBuf[ProIndex];
            ProIndex++;
            SendBuf[ProIndex] = (byte)(ResponeCommand & 0xff);
            CheckSum += SendBuf[ProIndex];
            ProIndex++;

            for (PackIndex = 0; PackIndex < length; PackIndex++)
            {
                SendBuf[ProIndex] = Buf[PackIndex];
                CheckSum += SendBuf[ProIndex];
                ProIndex++;

            }
            SendBuf[ProIndex++] = CheckSum;
            SendBuf[ProIndex++] = 0x24;
            if (!UsbCANForm.configForm.PortCom.IsOpen)
            {
                return 0;
            }
            UsbCANForm.configForm.Invoke((EventHandler)delegate
            {
                try
                {
                    UsbCANForm.configForm.PortCom.Write(SendBuf, 0, ProIndex);
                }
                catch (Exception ex)
                {
                    UsbCANForm.configForm.Invoke((EventHandler)delegate
                    {

                        UsbCANForm.configForm.DataTextBox.AppendText("发送exception-" + ex.Message + "\r\n");
                    });

                }

            });

            //Usb_Send_Data(SendBuf, ProIndex);
            return 0;

        }

        public UInt16 Send_Data_Deal(UInt16 command, byte[] Buf, UInt16 length)
        {


            if (!UsbCANForm.configForm.PortCom.IsOpen)
            {
                UsbCANForm.configForm.DataTextBox.AppendText("请先连接设备");
                return 0;
            }
            UInt16 ProIndex = 0;
            UInt16 PackIndex = 0;
            byte CheckSum = 0;
            SendBuf[ProIndex++] = 0x23;
            SendBuf[ProIndex++] = (byte)((command >> 8) & 0xff);
            SendBuf[ProIndex++] = (byte)(command & 0xff);
            SendBuf[ProIndex++] = (byte)((length >> 8) & 0xff);
            SendBuf[ProIndex++] = (byte)(length & 0xff);

            for (PackIndex = 0; PackIndex < length; PackIndex++)
            {
                SendBuf[ProIndex] = Buf[PackIndex];
                CheckSum += SendBuf[ProIndex];
                ProIndex++;
            }
            SendBuf[ProIndex++] = CheckSum;
            SendBuf[ProIndex++] = 0x24;

            /*
            UsbCANForm.configForm.Invoke((EventHandler)delegate
            {
                try
                {
                    UsbCANForm.configForm.PortCom.Write(SendBuf, 0, ProIndex);
                    UsbCANForm.configForm.Invoke((EventHandler)delegate
                    {
                        UsbCANForm.configForm.DataTextBox.AppendText("发送-len:" + ProIndex + "\r\n");
                    });
                }
                catch (Exception ex)
                {
                    UsbCANForm.configForm.Invoke((EventHandler)delegate
                    {
                        UsbCANForm.configForm.DataTextBox.AppendText("发送-" + ex.Message + "\r\n");
                    });

                }

            });*/ //add by lilei-20220103

            //Usb_Send_Data(SendBuf, ProIndex);
            return 0;

        }
        public void Comand_Data_Deal(byte[] Buf, UInt16 lenth, UInt16 command)
        {

            byte[] TTBuf = new byte[256];
            byte GetResult = 0;
            string ReciveData = null;
            UInt16 GetIndex = 0;
            UInt16 ComTIndex = 0;
            UInt16 ResponeID = 0;
            byte ReciveCanFrame = 0;
            UInt32 tempFrameId = 0;
            switch (command)
            {
                case 0x0800:
                    ResponeID = (UInt16)(Buf[GetIndex++] * 0x100);
                    ResponeID += Buf[GetIndex++];

                    switch (ResponeID)
                    {
                        case 0x0100:
                            break;
                        case 0x0101:
                            /*
                            if (Buf[GetIndex] == 0)
                            {
                                UsbCANForm.FForm.Invoke((EventHandler)delegate
                                {
                                    UsbCANForm.FForm.DataTextBox.AppendText("CAN1 Init Success\r\n");
                                    CAN1InItFlag = true;
                                });
                            }
                            else
                            {
                                UsbCANForm.FForm.Invoke((EventHandler)delegate
                                {
                                    UsbCANForm.FForm.DataTextBox.AppendText("CAN1 Init fail" + GetResult.ToString() + "\r\n");
                                    CAN1InItFlag = false;
                                });

                            }*///add by lilei-20220103
                            break;
                        case 0x0102:
                            /*
                            if (Buf[GetIndex] == 0)
                            {
                                UsbCANForm.FForm.Invoke((EventHandler)delegate
                                {
                                    UsbCANForm.FForm.DataTextBox.AppendText("CAN2 Init Success\r\n");
                                    CAN2InItFlag = true;
                                });
                            }
                            else
                            {
                                UsbCANForm.FForm.Invoke((EventHandler)delegate
                                {
                                    UsbCANForm.FForm.DataTextBox.AppendText("CAN2 Init Success fail" + GetResult.ToString() + "\r\n");
                                    CAN1InItFlag = false;
                                });
                            }*///add by lilei-20220103
                            break;
                        case 0x0105:
                            if (Buf[GetIndex] == 0)
                            {

                            }
                            else
                            {

                            }
                            break;
                        case 0x0106:
                            //UsbCANForm.FForm.MyUpdateFile.UpdateParaFlag = true;

                            break;
                        case 0x0107:
                            if (Buf[GetIndex++] == 0)
                            {
                                //UsbCANForm.FForm.MyUpdateFile.ReciveBagNum = (UInt16)(Buf[GetIndex++] * 0x100);
                                //UsbCANForm.FForm.MyUpdateFile.ReciveBagNum += Buf[GetIndex++];
                            }

                            break;
                        case 0x0108:
                            if (Buf[GetIndex++] == 0)
                            {
                                //UsbCANForm.FForm.MyUpdateFile.MCUResetFlag = true;
                                //UsbCANForm.FForm.DataTextBox.AppendText("Recice Device update answer\r\n");
                            }
                            else
                            {
                                //UsbCANForm.FForm.MyUpdateFile.MCUResetFlag = false;
                                //UsbCANForm.FForm.DataTextBox.AppendText("Revcice Device update answer false\r\n");
                            }
                            break;
                        case 0x0109:
                            break;
                        default:
                            break;


                    }
                    break;
                case 0x08ff:
                    string strdata = null;
                    byte[] TempBuf = new byte[lenth];
                    for (int index = 0; index < lenth; index++)
                    {

                        TempBuf[index] = Buf[index];
                    }

                    strdata = System.Text.Encoding.Default.GetString(TempBuf);
                    /*
                    UsbCANForm.FForm.Invoke((EventHandler)delegate
                    {
                        UsbCANForm.FForm.DataTextBox.AppendText("device:" + strdata);
                    });*/   //add by lilei-20220103
                 
                    break;
                case 0x0801:
                    /***
                    ReciveData = "";
                    ReciveCanFrame = Buf[GetIndex++];
                    for (int i = 0; i < ReciveCanFrame; i++)
                    {
                        tempFrameId = 0;
                        tempFrameId = (UInt32)(Buf[GetIndex] * 0x1000000 + Buf[GetIndex + 1] * 0x10000 + Buf[GetIndex + 2] * 0x100 + Buf[GetIndex + 3]);
                        if ((tempFrameId >= UsbCANForm.FForm.MinId) && (tempFrameId <= UsbCANForm.FForm.MaxId))
                        {
                            FrameBuf[FrameInIndex].GetTime = DateTime.Now.ToString("mm:ss:fff");
                            FrameBuf[FrameInIndex].CurrentCanNum = 0;
                            FrameBuf[FrameInIndex].FrameId = (UInt32)Buf[GetIndex] * 0x1000000;
                            ReciveData += ("CAN1ID- " + String.Format("{0:X2}", Buf[GetIndex++]));

                            FrameBuf[FrameInIndex].FrameId += (UInt32)Buf[GetIndex] * 0x10000;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            FrameBuf[FrameInIndex].FrameId += (UInt32)Buf[GetIndex] * 0x100;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            FrameBuf[FrameInIndex].FrameId += (UInt32)Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += " len:";
                            FrameBuf[FrameInIndex].FrameLengh = Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += "data-";
                            for (ComTIndex = 0; ComTIndex < FrameBuf[FrameInIndex].FrameLengh; ComTIndex++)
                            {
                                //ReciveData += String.Format("{0:X2}", Buf[GetIndex]);
                                FrameBuf[FrameInIndex].Buf[ComTIndex] = Buf[GetIndex++];
                            }
                            ReciveData += "\r\n";
                            FrameInIndex++;
                            if (FrameInIndex >= 1024)
                            {
                                FrameInIndex = 0;
                            }
                        }
                        else
                        {
                            CanFrame TTCanFrame = new CanFrame();
                            TTCanFrame.GetTime = DateTime.Now.ToString("mm:ss:fff");
                            TTCanFrame.CurrentCanNum = 1;
                            TTCanFrame.FrameId = (UInt32)Buf[GetIndex] * 0x1000000;
                            ReciveData += ("CAN1ID- " + String.Format("{0:X2}", Buf[GetIndex++]));

                            TTCanFrame.FrameId += (UInt32)Buf[GetIndex] * 0x10000;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            TTCanFrame.FrameId += (UInt32)Buf[GetIndex] * 0x100;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            TTCanFrame.FrameId += (UInt32)Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += " len:";
                            TTCanFrame.FrameLengh = Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += "data-";
                            for (ComTIndex = 0; ComTIndex < TTCanFrame.FrameLengh; ComTIndex++)
                            {
                                //ReciveData += String.Format("{0:X2}", Buf[GetIndex]);
                                TTCanFrame.Buf[ComTIndex] = Buf[GetIndex++];
                            }
                            ReciveData += "\r\n";
                        }
                    }***/  //add by lilei-20220103
                    break;
                case 0x0802:
                    /****
                    ReciveData = null;
                    ReciveCanFrame = Buf[GetIndex++];
                    for (int i = 0; i < ReciveCanFrame; i++)
                    {
                        tempFrameId = 0;
                        tempFrameId = (UInt32)(Buf[GetIndex] * 0x1000000 + Buf[GetIndex + 1] * 0x10000 + Buf[GetIndex + 2] * 0x100 + Buf[GetIndex + 3]);
                        if ((tempFrameId >= UsbCANForm.FForm.MinId) && (tempFrameId <= UsbCANForm.FForm.MaxId))
                        {
                            FrameBuf[FrameInIndex].GetTime = DateTime.Now.ToString("mm:ss:fff");
                            FrameBuf[FrameInIndex].CurrentCanNum = 1;
                            FrameBuf[FrameInIndex].FrameId = (UInt32)Buf[GetIndex] * 0x1000000;
                            ReciveData += ("CAN2ID- " + String.Format("{0:X2}", Buf[GetIndex++]));

                            FrameBuf[FrameInIndex].FrameId += (UInt32)Buf[GetIndex] * 0x10000;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            FrameBuf[FrameInIndex].FrameId += (UInt32)Buf[GetIndex] * 0x100;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            FrameBuf[FrameInIndex].FrameId += (UInt32)Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += " len:";
                            FrameBuf[FrameInIndex].FrameLengh = Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += "data-";
                            for (ComTIndex = 0; ComTIndex < FrameBuf[FrameInIndex].FrameLengh; ComTIndex++)
                            {
                                //ReciveData += String.Format("{0:X2}", Buf[GetIndex]);
                                FrameBuf[FrameInIndex].Buf[ComTIndex] = Buf[GetIndex++];
                            }
                            ReciveData += "\r\n";
                            FrameInIndex++;
                            if (FrameInIndex >= 1024)
                            {
                                FrameInIndex = 0;
                            }
                        }
                        else
                        {
                            CanFrame TTCanFrame = new CanFrame();
                            TTCanFrame.GetTime = DateTime.Now.ToString("mm:ss:fff");
                            TTCanFrame.CurrentCanNum = 1;
                            TTCanFrame.FrameId = (UInt32)Buf[GetIndex] * 0x1000000;
                            ReciveData += ("CAN2ID- " + String.Format("{0:X2}", Buf[GetIndex++]));

                            TTCanFrame.FrameId += (UInt32)Buf[GetIndex] * 0x10000;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            TTCanFrame.FrameId += (UInt32)Buf[GetIndex] * 0x100;
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);

                            TTCanFrame.FrameId += (UInt32)Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += " len:";
                            TTCanFrame.FrameLengh = Buf[GetIndex];
                            ReciveData += String.Format("{0:X2}", Buf[GetIndex++]);
                            ReciveData += "data-";
                            for (ComTIndex = 0; ComTIndex < TTCanFrame.FrameLengh; ComTIndex++)
                            {
                                //ReciveData += String.Format("{0:X2}", Buf[GetIndex]);
                                TTCanFrame.Buf[ComTIndex] = Buf[GetIndex++];
                            }
                            ReciveData += "\r\n";
                        }
                    }****/
                    break;
                case 0x0803:
                    //UsbCANForm.FForm.MyUpdateFile.UpdateReqFlag = true;
                    USBTBuf[0] = 0;
                    Send_Data_Responne(0x100, command, USBTBuf, 1);
                    break;
                case 0x0804:
                    /*UsbCANForm.FForm.MyUpdateFile.GetCRCSUM = (UInt32)(Buf[GetIndex++] * 0x1000000);
                    UsbCANForm.FForm.MyUpdateFile.GetCRCSUM += (UInt32)(Buf[GetIndex++] * 0x10000);
                    UsbCANForm.FForm.MyUpdateFile.GetCRCSUM += (UInt32)(Buf[GetIndex++] * 0x100);
                    UsbCANForm.FForm.MyUpdateFile.GetCRCSUM += (UInt32)(Buf[GetIndex++]);
                    if (UsbCANForm.FForm.MyUpdateFile.GetCRCSUM == UsbCANForm.FForm.MyUpdateFile.FileCRCSUM)
                     {
                         USBTBuf[0] = 0;
                     }
                     else
                     {
                         USBTBuf[0] =1;
                     }
                    Send_Data_Responne(0x100, command, USBTBuf, 1);*/
                    break;
                default:
                    break;
            }

        }
        public void Recive_Data_Deal(byte[] Buf, int lenth)
        {

            int ReciveIndex = 0;

            byte value = 0;
            byte CheckSum = 0;

            //string hex = null;
            for (ReciveIndex = 0; ReciveIndex < lenth; ReciveIndex++)
            {
                value = (byte)Buf[ReciveIndex];
                switch (Dirc)
                {
                    case Direction.HEAD:
                        if (Buf[ReciveIndex] == 0x23)
                        {

                            Dirc = Direction.COMMAND;
                        }
                        break;
                    case Direction.COMMAND:
                        //DataTextBox.AppendText("command\r:");
                        //hex = String.Format("{0:X2} ", value);
                        //DataTextBox.AppendText(hex);
                        ReciveCmd = value;

                        Dirc = Direction.COMMAND1;
                        break;
                    case Direction.COMMAND1:
                        //DataTextBox.AppendText("command\r:");
                        //hex = String.Format("{0:X2} ", value);
                        //DataTextBox.AppendText(hex);
                        ReciveCmd = (UInt16)(ReciveCmd * 0x100 + value);

                        Dirc = Direction.LENGTH0;
                        break;
                    case Direction.LENGTH0:
                        ReciveDatalen = value;
                        Dirc = Direction.LENGTH1;

                        break;
                    case Direction.LENGTH1:
                        ReciveDatalen = (UInt16)(ReciveDatalen * 0x100 + value);
                        Dirc = Direction.DATA;
                        ReciveCntIndex = 0;
                        CheckSum = 0;
                        break;
                    case Direction.DATA:
                        CheckSum += value;
                        ReciveBuf[ReciveCntIndex++] = value;
                        if (ReciveCntIndex >= ReciveDatalen)
                        {
                            Dirc = Direction.CHECKSUM1;
                        }
                        break;
                    case Direction.CHECKSUM1:
                        if (value == CheckSum)
                        {
                            Dirc = Direction.END;
                        }
                        else
                        {

                            /***
                            UsbCANForm.FForm.Invoke((EventHandler)delegate
                            {
                                UsbCANForm.FForm.DataTextBox.AppendText("Get Device data checksum error\r\n");
                                //CAN2InItFlag = true;
                            });****/  //add by lilei-20220103
                             
                            CAN2InItFlag = true;    //add by lilei-20220103
                            Dirc = Direction.HEAD;
                        }
                        break;
                    case Direction.END:
                        if (value == 0x24)
                        {
                            Comand_Data_Deal(ReciveBuf, ReciveCntIndex, ReciveCmd);
                        }
                        Dirc = Direction.HEAD;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
