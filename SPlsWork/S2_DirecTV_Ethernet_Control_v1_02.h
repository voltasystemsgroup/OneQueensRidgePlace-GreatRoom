#ifndef __S2_DIRECTV_ETHERNET_CONTROL_V1_02_H__
#define __S2_DIRECTV_ETHERNET_CONTROL_V1_02_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_DirecTV_Ethernet_Control_v1_02_POWER_DIG_INPUT 0
#define __S2_DirecTV_Ethernet_Control_v1_02_POWER_ON_DIG_INPUT 1
#define __S2_DirecTV_Ethernet_Control_v1_02_POWER_OFF_DIG_INPUT 2
#define __S2_DirecTV_Ethernet_Control_v1_02_FORMAT_DIG_INPUT 3
#define __S2_DirecTV_Ethernet_Control_v1_02_PAUSE_DIG_INPUT 4
#define __S2_DirecTV_Ethernet_Control_v1_02_REW_DIG_INPUT 5
#define __S2_DirecTV_Ethernet_Control_v1_02_REPLAY_DIG_INPUT 6
#define __S2_DirecTV_Ethernet_Control_v1_02_STOP_DIG_INPUT 7
#define __S2_DirecTV_Ethernet_Control_v1_02_ADVANCE_DIG_INPUT 8
#define __S2_DirecTV_Ethernet_Control_v1_02_FFWD_DIG_INPUT 9
#define __S2_DirecTV_Ethernet_Control_v1_02_REC_DIG_INPUT 10
#define __S2_DirecTV_Ethernet_Control_v1_02_PLAY_DIG_INPUT 11
#define __S2_DirecTV_Ethernet_Control_v1_02_GUIDE_DIG_INPUT 12
#define __S2_DirecTV_Ethernet_Control_v1_02_ACTIVE_DIG_INPUT 13
#define __S2_DirecTV_Ethernet_Control_v1_02_LIST_DIG_INPUT 14
#define __S2_DirecTV_Ethernet_Control_v1_02_EXIT_DIG_INPUT 15
#define __S2_DirecTV_Ethernet_Control_v1_02_BACK_DIG_INPUT 16
#define __S2_DirecTV_Ethernet_Control_v1_02_MENU_DIG_INPUT 17
#define __S2_DirecTV_Ethernet_Control_v1_02_INFO_DIG_INPUT 18
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_UP_DIG_INPUT 19
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_DOWN_DIG_INPUT 20
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_LEFT_DIG_INPUT 21
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_RIGHT_DIG_INPUT 22
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_UP_HELD_DIG_INPUT 23
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_DOWN_HELD_DIG_INPUT 24
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_LEFT_HELD_DIG_INPUT 25
#define __S2_DirecTV_Ethernet_Control_v1_02_NAV_RIGHT_HELD_DIG_INPUT 26
#define __S2_DirecTV_Ethernet_Control_v1_02_SELECT_DIG_INPUT 27
#define __S2_DirecTV_Ethernet_Control_v1_02_RED_DIG_INPUT 28
#define __S2_DirecTV_Ethernet_Control_v1_02_GREEN_DIG_INPUT 29
#define __S2_DirecTV_Ethernet_Control_v1_02_YELLOW_DIG_INPUT 30
#define __S2_DirecTV_Ethernet_Control_v1_02_BLUE_DIG_INPUT 31
#define __S2_DirecTV_Ethernet_Control_v1_02_CH_UP_DIG_INPUT 32
#define __S2_DirecTV_Ethernet_Control_v1_02_CH_DOWN_DIG_INPUT 33
#define __S2_DirecTV_Ethernet_Control_v1_02_CH_UP_HELD_DIG_INPUT 34
#define __S2_DirecTV_Ethernet_Control_v1_02_CH_DOWN_HELD_DIG_INPUT 35
#define __S2_DirecTV_Ethernet_Control_v1_02_PREV_DIG_INPUT 36
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_0_DIG_INPUT 37
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_1_DIG_INPUT 38
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_2_DIG_INPUT 39
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_3_DIG_INPUT 40
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_4_DIG_INPUT 41
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_5_DIG_INPUT 42
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_6_DIG_INPUT 43
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_7_DIG_INPUT 44
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_8_DIG_INPUT 45
#define __S2_DirecTV_Ethernet_Control_v1_02_DIGIT_9_DIG_INPUT 46
#define __S2_DirecTV_Ethernet_Control_v1_02_DASH_DIG_INPUT 47
#define __S2_DirecTV_Ethernet_Control_v1_02_ENTER_DIG_INPUT 48


/*
* ANALOG_INPUT
*/
#define __S2_DirecTV_Ethernet_Control_v1_02_CHANNEL_ANALOG_INPUT 0




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/



/*
* Direct Socket Variables
*/

#define __S2_DirecTV_Ethernet_Control_v1_02_DTV_COMMAND_TCPCLIENT_SOCKET 2
#define __S2_DirecTV_Ethernet_Control_v1_02_DTV_COMMAND_TCPCLIENT_STRING_MAX_LEN 8192
START_SOCKET_DEFINITION( S2_DirecTV_Ethernet_Control_v1_02, __DTV_COMMAND_TCPCLIENT )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_DirecTV_Ethernet_Control_v1_02, SocketRxBuf, __S2_DirecTV_Ethernet_Control_v1_02_DTV_COMMAND_TCPCLIENT_STRING_MAX_LEN );
};



/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/
#define __S2_DirecTV_Ethernet_Control_v1_02_IPA_STRING_PARAMETER 10
#define __S2_DirecTV_Ethernet_Control_v1_02_IPA_PARAM_MAX_LEN 16
CREATE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_02, __IPA, __S2_DirecTV_Ethernet_Control_v1_02_IPA_PARAM_MAX_LEN );


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_DirecTV_Ethernet_Control_v1_02_GSCOMMAND_STRING_MAX_LEN 32
CREATE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_02, __GSCOMMAND, __S2_DirecTV_Ethernet_Control_v1_02_GSCOMMAND_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_DirecTV_Ethernet_Control_v1_02 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_02, __GSCOMMAND );
   DECLARE_SOCKET( S2_DirecTV_Ethernet_Control_v1_02, __DTV_COMMAND_TCPCLIENT );
   DECLARE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_02, __IPA );
};

START_NVRAM_VAR_STRUCT( S2_DirecTV_Ethernet_Control_v1_02 )
{
};



#endif //__S2_DIRECTV_ETHERNET_CONTROL_V1_02_H__

