#ifndef __S2_DYNAMIC_ZERO_DELAY__V1_00_H__
#define __S2_DYNAMIC_ZERO_DELAY__V1_00_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_Dynamic_Zero_Delay__v1_00_I_ANALOG_INPUT 0
#define __S2_Dynamic_Zero_Delay__v1_00_DELAY_TIME_ANALOG_INPUT 1




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Dynamic_Zero_Delay__v1_00_O_ANALOG_OUTPUT 0



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

START_GLOBAL_VAR_STRUCT( S2_Dynamic_Zero_Delay__v1_00 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

};

START_NVRAM_VAR_STRUCT( S2_Dynamic_Zero_Delay__v1_00 )
{
};

DEFINE_WAITEVENT( S2_Dynamic_Zero_Delay__v1_00, DELAYEDOUTPUT );


#endif //__S2_DYNAMIC_ZERO_DELAY__V1_00_H__

