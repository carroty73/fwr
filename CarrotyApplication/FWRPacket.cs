using System;
using System.Collections.Generic;
using System.Text;

namespace CarrotyApplication {
    class FWRPacket
    {
        private byte stx;
        public const byte DEV_ID = 0x01;
        //public const byte ID = 0x0010;
        //private byte id;
        private byte cmd;
        private byte data;
        //private int crc;
        private byte etx;
        public byte[] buffer = new byte[32];
/*
        public void setId(byte id) { 
            this.id= id;
            buffer[0] = id;
        }
        public byte getId() { return this.id; }
*/
        public void setCmd(byte cmd) { this.cmd = cmd; this.buffer[1] = cmd; }
        public byte getCmd() { return this.cmd; }
        public void setData(byte data) { this.data = data; this.buffer[2] = data; }
        public byte getData() { return this.data; }
        public byte[] getBuffer() { return this.buffer; }
        public void setSTX(byte stx) { this.stx = stx; this.buffer[0] = stx; }
        public void setETX(byte etx) { this.etx = etx; this.buffer[3] = etx; }

        public FWRPacket(byte cmd) {
            //setSTX(FWRProtocol.STX);
            //setCmd(cmd);
            //setETX(FWRProtocol.ETX);
            buffer[0] = FWRProtocol.STX;
            buffer[1] = cmd;
            buffer[2] = FWRProtocol.ETX;
        }

        public FWRPacket(byte cmd, byte[] data, int dataCount) {
            //setSTX(FWRProtocol.STX);
            //setCmd(cmd);
            //setData(data);
            //setETX(FWRProtocol.ETX);
            buffer[0] = FWRProtocol.STX;
            buffer[1] = cmd;
            for (int i = 0; i < dataCount; i++) {
                buffer[i+2] = data[i];
            }
            buffer[dataCount+2] = FWRProtocol.ETX;
        }
    }
}
