#ifndef __S2_MANAGED_POWER___INPUT_V1_00_H__
#define __S2_MANAGED_POWER___INPUT_V1_00_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Managed_Power___Input_v1_00_POWER_ON_DIG_INPUT 0
#define __S2_Managed_Power___Input_v1_00_POWER_OFF_DIG_INPUT 1
#define __S2_Managed_Power___Input_v1_00_POWER_ON_FB_DIG_INPUT 2
#define __S2_Managed_Power___Input_v1_00_POWER_OFF_FB_DIG_INPUT 3
#define __S2_Managed_Power___Input_v1_00_POWER_ON_DELAY_FB_DIG_INPUT 4
#define __S2_Managed_Power___Input_v1_00_POWER_OFF_DELAY_FB_DIG_INPUT 5
#define __S2_Managed_Power___Input_v1_00_SWITCH_DELAY_FB_DIG_INPUT 6
#define __S2_Managed_Power___Input_v1_00_SMART_POWER_DIG_INPUT 7
#define __S2_Managed_Power___Input_v1_00_SMART_SWITCHER_DIG_INPUT 8
#define __S2_Managed_Power___Input_v1_00_SMART_POWER_OFF_DELAY_DIG_INPUT 9
#define __S2_Managed_Power___Input_v1_00_PRE_POWER_ON_INPUT_SWITCHER_DIG_INPUT 10

#define __S2_Managed_Power___Input_v1_00_INPUT_DIG_INPUT 11
#define __S2_Managed_Power___Input_v1_00_INPUT_ARRAY_LENGTH 16
#define __S2_Managed_Power___Input_v1_00_INPUT_FB_DIG_INPUT 27
#define __S2_Managed_Power___Input_v1_00_INPUT_FB_ARRAY_LENGTH 16

/*
* ANALOG_INPUT
*/
#define __S2_Managed_Power___Input_v1_00_PULSE_TIME_ANALOG_INPUT 0




/*
* DIGITAL_OUTPUT
*/
#define __S2_Managed_Power___Input_v1_00_POWER_ON_TRIG_DIG_OUTPUT 0
#define __S2_Managed_Power___Input_v1_00_POWER_OFF_TRIG_DIG_OUTPUT 1
#define __S2_Managed_Power___Input_v1_00_POWER_ON_DELAY_DIG_OUTPUT 2
#define __S2_Managed_Power___Input_v1_00_POWER_OFF_DELAY_DIG_OUTPUT 3
#define __S2_Managed_Power___Input_v1_00_SWITCH_DELAY_DIG_OUTPUT 4
#define __S2_Managed_Power___Input_v1_00_POWER_ON_DELAY_WARNING_DIG_OUTPUT 5
#define __S2_Managed_Power___Input_v1_00_POWER_OFF_DELAY_WARNING_DIG_OUTPUT 6
#define __S2_Managed_Power___Input_v1_00_SWITCH_DELAY_WARNING_DIG_OUTPUT 7

#define __S2_Managed_Power___Input_v1_00_INPUT_TRIG_DIG_OUTPUT 8
#define __S2_Managed_Power___Input_v1_00_INPUT_TRIG_ARRAY_LENGTH 16

/*
* ANALOG_OUTPUT
*/



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

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Managed_Power___Input_v1_00 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __INPUT );
   DECLARE_IO_ARRAY( __INPUT_FB );
   DECLARE_IO_ARRAY( __INPUT_TRIG );
   unsigned short __GNINPUT;
   unsigned short __GNDOPOWERON;
   unsigned short __GNDOPOWEROFF;
   unsigned short __GNDOSWITCH;
};

START_NVRAM_VAR_STRUCT( S2_Managed_Power___Input_v1_00 )
{
};



#endif //__S2_MANAGED_POWER___INPUT_V1_00_H__

