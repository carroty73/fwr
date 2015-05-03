using System;
using System.Collections.Generic;
using System.Text;

namespace CarrotyApplication {

    class FWRProtocol
    {
        public const byte STX = 0x02;
        public const byte ETX = 0x03;
        public const byte ACK = 0x06;

        public const byte STOP = 0x53;
        public const byte RUN = 0x47;
        public const byte RESTART = 0x52;

        public const byte ONLY_GRIND = 0x61; // 분쇄만
        public const byte ONLY_DRY = 0x62; // 건조만
        public const byte ONLY_FLUSH = 0x63; // 배출만

        public const byte GRIND = 0x41; // 분쇄
        public const byte DRY = 0x42; // 건조
        public const byte FLUSH = 0x43; // 배출

        public const byte PAUSE = 0x00; // PAUSE
        public const byte END = 0xFF; // 동작끗

        public const byte SELECT_SOL_1 = 0x1E; // 솔밸브1 선택
        public const byte SELECT_SOL_2 = 0xB4; // 솔밸브2 선택

        public const byte MAIN_MOTOR_REPEAT_COUNT = 0xA0;
        public const byte MAIN_MOTOR_CW_TIME = 0xA1;
        public const byte MAIN_MOTOR_CCW_TIME = 0xA2;
        public const byte MAIN_MOTOR_LAST_CW_TIME = 0xA3;
        public const byte MAIN_MOTOR_LAST_CCW_TIME = 0xA4;

        public const byte IMP_MOTOR_REPEAT_COUNT = 0xB0;
        public const byte IMP_MOTOR_CW_TIME = 0xB1;
        public const byte IMP_MOTOR_CCW_TIME = 0xB2;
        public const byte IMP_MOTOR_LAST_CW_TIME = 0xB3;
        public const byte IMP_MOTOR_LAST_CCW_TIME = 0xB4;

        public const byte BROWER_FAN_APPEND_TIMEE = 0xC0;

        public const byte HEATER_ACTIVE_TIME = 0XD0;
        public const byte HEATER_STOP_TEMP_TIME = 0XD1;
        public const byte HEATER_CONDITION_STATUS = 0XD2;
        public const byte HEATER_STOP_HUMI_TIME = 0XD3;

        public const byte SOL1_REPEAT_COUNT = 0XE0;
        public const byte SOL1_SPRAY_TIME = 0XE1;
        public const byte SOL1_SPRAY_INTERVAL_TIME = 0XE2;

        public const byte SOL2_REPEAT_COUNT = 0XF0;
        public const byte SOL2_SPRAY_TIME = 0XF1;
        public const byte SOL2_SPRAY_INTERVAL_TIME = 0XF2;
    }
}
