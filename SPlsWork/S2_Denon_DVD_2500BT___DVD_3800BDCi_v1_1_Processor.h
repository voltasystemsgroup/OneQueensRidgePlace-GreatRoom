#ifndef __S2_DENON_DVD_2500BT___DVD_3800BDCI_V1_1_PROCESSOR_H__
#define __S2_DENON_DVD_2500BT___DVD_3800BDCI_V1_1_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_COMMANDSENT_DIG_INPUT 0
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_ACKED_DIG_INPUT 1


/*
* ANALOG_INPUT
*/


#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_FROMDEVICE$_BUFFER_INPUT 0
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_FROMDEVICE$_BUFFER_MAX_LEN 255
CREATE_STRING_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, __FROMDEVICE$, __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_FROMDEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_TIMEDOUT_DIG_OUTPUT 0
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_PLEASEWAIT_DIG_OUTPUT 1
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_ACKIN_DIG_OUTPUT 2


/*
* ANALOG_OUTPUT
*/
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_TIMEOUT_ANALOG_OUTPUT 0
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_DISC_TYPE_CODE_ANALOG_OUTPUT 1
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_AUDIO_FORMAT_CODE_ANALOG_OUTPUT 2
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_AUDIO_CHANNEL_CODE_ANALOG_OUTPUT 3
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_DIALOG_CODE_ANALOG_OUTPUT 4
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_SUBTITLE_CODE_ANALOG_OUTPUT 5
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_ANGLE_CODE_ANALOG_OUTPUT 6
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_STATUS_CODE_ANALOG_OUTPUT 7
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_PLAY_MODE_CODE_ANALOG_OUTPUT 8
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_TIME_MODE_ANALOG_OUTPUT 9
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_GROUP_TITLE_ANALOG_OUTPUT 10
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_TRACK_CHAPTER_ANALOG_OUTPUT 11



/*
* Direct Socket Variables
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
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_TEMPSTRING$_STRING_MAX_LEN 70
CREATE_STRING_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, __TEMPSTRING$, __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_TEMPSTRING$_STRING_MAX_LEN );
#define __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_STEMP2$_STRING_MAX_LEN 70
CREATE_STRING_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, __STEMP2$, __S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor_STEMP2$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, __FROMDEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor )
{
   DECLARE_STRING_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, __TEMPSTRING$ );
   DECLARE_STRING_STRUCT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, __STEMP2$ );
   unsigned short __SEMAPHORE;
   unsigned short __HOUR;
   unsigned short __MINUTE;
   unsigned short __SECOND;
   unsigned short __MARKER;
   unsigned short __STATUS_BYTE_4;
   unsigned short __STATUS_BYTE_5;
   unsigned short __STATUS_BYTE_6;
   unsigned short __STATUS_BYTE_7;
   unsigned short __STATUS_BYTE_8;
   unsigned short __STATUS_BYTE_9;
   unsigned short __STATUS_BYTE_10;
   unsigned short __STATUS_BYTE_11;
   unsigned short __STATUS_BYTE_12;
   unsigned short __STATUS_BYTE_13;
   unsigned short __STATUS_BYTE_14;
   unsigned short __STATUS_BYTE_15;
   unsigned short __STATUS_BYTE_16;
   unsigned short __STATUS_BYTE_17;
   unsigned short __STATUS_BYTE_18;
   unsigned short __STATUS_BYTE_19;
   unsigned short __STATUS_BYTE_20;
   unsigned short __STATUS_BYTE_21;
   unsigned short __STATUS_BYTE_22;
   unsigned short __STATUS_BYTE_23;
   unsigned short __STATUS_BYTE_24;
   unsigned short __STATUS_BYTE_25;
};

DEFINE_WAITEVENT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, COMMANDWAIT1 );
DEFINE_WAITEVENT( S2_Denon_DVD_2500BT___DVD_3800BDCi_v1_1_Processor, COMMANDWAIT2 );


#endif //__S2_DENON_DVD_2500BT___DVD_3800BDCI_V1_1_PROCESSOR_H__

