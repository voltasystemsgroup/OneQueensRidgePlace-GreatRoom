#ifndef __S2_MANAGED_POWER_V1_00_H__
#define __S2_MANAGED_POWER_V1_00_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Managed_Power_v1_00_POWER_ON_DIG_INPUT 0
#define __S2_Managed_Power_v1_00_POWER_OFF_DIG_INPUT 1
#define __S2_Managed_Power_v1_00_POWER_ON_FB_DIG_INPUT 2
#define __S2_Managed_Power_v1_00_POWER_OFF_FB_DIG_INPUT 3
#define __S2_Managed_Power_v1_00_SMART_POWER_DIG_INPUT 4
#define __S2_Managed_Power_v1_00_AUTO_POWER_DIG_INPUT 5


/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/
#define __S2_Managed_Power_v1_00_POWER_ON_TRIG_DIG_OUTPUT 0
#define __S2_Managed_Power_v1_00_POWER_OFF_TRIG_DIG_OUTPUT 1


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

START_GLOBAL_VAR_STRUCT( S2_Managed_Power_v1_00 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

};

START_NVRAM_VAR_STRUCT( S2_Managed_Power_v1_00 )
{
};



#endif //__S2_MANAGED_POWER_V1_00_H__

