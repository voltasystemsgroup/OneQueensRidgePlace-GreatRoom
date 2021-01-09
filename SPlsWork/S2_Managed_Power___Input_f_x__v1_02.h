#ifndef __S2_MANAGED_POWER___INPUT_F_X__V1_02_H__
#define __S2_MANAGED_POWER___INPUT_F_X__V1_02_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_Managed_Power___Input_f_x__v1_02_Y_0_ANALOG_INPUT 0



#define __S2_Managed_Power___Input_f_x__v1_02_Y_ANALOG_INPUT 1
#define __S2_Managed_Power___Input_f_x__v1_02_Y_ARRAY_LENGTH 48
#define __S2_Managed_Power___Input_f_x__v1_02_X_ANALOG_INPUT 49
#define __S2_Managed_Power___Input_f_x__v1_02_X_ARRAY_LENGTH 1

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/


#define __S2_Managed_Power___Input_f_x__v1_02_OUTPUT_ANALOG_OUTPUT 0
#define __S2_Managed_Power___Input_f_x__v1_02_OUTPUT_ARRAY_LENGTH 1

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

START_GLOBAL_VAR_STRUCT( S2_Managed_Power___Input_f_x__v1_02 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __Y );
   DECLARE_IO_ARRAY( __X );
   DECLARE_IO_ARRAY( __OUTPUT );
   unsigned short __GNINITCOMPLETE;
};

START_NVRAM_VAR_STRUCT( S2_Managed_Power___Input_f_x__v1_02 )
{
};



#endif //__S2_MANAGED_POWER___INPUT_F_X__V1_02_H__

