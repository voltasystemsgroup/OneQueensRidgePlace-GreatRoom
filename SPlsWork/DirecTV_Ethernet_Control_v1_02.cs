using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_DIRECTV_ETHERNET_CONTROL_V1_02
{
    public class UserModuleClass_DIRECTV_ETHERNET_CONTROL_V1_02 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        StringParameter IPA;
        Crestron.Logos.SplusObjects.DigitalInput POWER;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput FORMAT;
        Crestron.Logos.SplusObjects.DigitalInput PAUSE;
        Crestron.Logos.SplusObjects.DigitalInput REW;
        Crestron.Logos.SplusObjects.DigitalInput REPLAY;
        Crestron.Logos.SplusObjects.DigitalInput STOP;
        Crestron.Logos.SplusObjects.DigitalInput ADVANCE;
        Crestron.Logos.SplusObjects.DigitalInput FFWD;
        Crestron.Logos.SplusObjects.DigitalInput REC;
        Crestron.Logos.SplusObjects.DigitalInput PLAY;
        Crestron.Logos.SplusObjects.DigitalInput GUIDE;
        Crestron.Logos.SplusObjects.DigitalInput ACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput LIST;
        Crestron.Logos.SplusObjects.DigitalInput EXIT;
        Crestron.Logos.SplusObjects.DigitalInput BACK;
        Crestron.Logos.SplusObjects.DigitalInput MENU;
        Crestron.Logos.SplusObjects.DigitalInput INFO;
        Crestron.Logos.SplusObjects.DigitalInput NAV_UP;
        Crestron.Logos.SplusObjects.DigitalInput NAV_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput NAV_LEFT;
        Crestron.Logos.SplusObjects.DigitalInput NAV_RIGHT;
        Crestron.Logos.SplusObjects.DigitalInput NAV_UP_HELD;
        Crestron.Logos.SplusObjects.DigitalInput NAV_DOWN_HELD;
        Crestron.Logos.SplusObjects.DigitalInput NAV_LEFT_HELD;
        Crestron.Logos.SplusObjects.DigitalInput NAV_RIGHT_HELD;
        Crestron.Logos.SplusObjects.DigitalInput SELECT;
        Crestron.Logos.SplusObjects.DigitalInput RED;
        Crestron.Logos.SplusObjects.DigitalInput GREEN;
        Crestron.Logos.SplusObjects.DigitalInput YELLOW;
        Crestron.Logos.SplusObjects.DigitalInput BLUE;
        Crestron.Logos.SplusObjects.DigitalInput CH_UP;
        Crestron.Logos.SplusObjects.DigitalInput CH_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput CH_UP_HELD;
        Crestron.Logos.SplusObjects.DigitalInput CH_DOWN_HELD;
        Crestron.Logos.SplusObjects.DigitalInput PREV;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_0;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_1;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_2;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_3;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_4;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_5;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_6;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_7;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_8;
        Crestron.Logos.SplusObjects.DigitalInput DIGIT_9;
        Crestron.Logos.SplusObjects.DigitalInput DASH;
        Crestron.Logos.SplusObjects.DigitalInput ENTER;
        Crestron.Logos.SplusObjects.AnalogInput CHANNEL;
        SplusTcpClient DTV_COMMAND_TCPCLIENT;
        CrestronString GSCOMMAND;
        private void CONNECTTOSENDCOMMAND (  SplusExecutionContext __context__ ) 
            { 
            short SIERR = 0;
            
            
            __context__.SourceCodeLine = 91;
            SIERR = (short) ( Functions.SocketConnectClient( DTV_COMMAND_TCPCLIENT , IPA  , (ushort)( 8080 ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 93;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIERR < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 95;
                Print( "{0} - SocketConnect Error = {1:d}\r\n", GetSymbolInstanceName ( ) , (short)SIERR) ; 
                } 
            
            
            }
            
        object CHANNEL_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 99;
                GSCOMMAND  .UpdateValue ( "!CHANNEL!"  ) ; 
                __context__.SourceCodeLine = 99;
                CONNECTTOSENDCOMMAND (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POWER_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 101;
            GSCOMMAND  .UpdateValue ( "power"  ) ; 
            __context__.SourceCodeLine = 101;
            CONNECTTOSENDCOMMAND (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object POWER_ON_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 102;
        GSCOMMAND  .UpdateValue ( "poweron"  ) ; 
        __context__.SourceCodeLine = 102;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_OFF_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 103;
        GSCOMMAND  .UpdateValue ( "poweroff"  ) ; 
        __context__.SourceCodeLine = 103;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FORMAT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 104;
        GSCOMMAND  .UpdateValue ( "format"  ) ; 
        __context__.SourceCodeLine = 104;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAUSE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 105;
        GSCOMMAND  .UpdateValue ( "pause"  ) ; 
        __context__.SourceCodeLine = 105;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REW_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 106;
        GSCOMMAND  .UpdateValue ( "rew"  ) ; 
        __context__.SourceCodeLine = 106;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REPLAY_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 107;
        GSCOMMAND  .UpdateValue ( "replay"  ) ; 
        __context__.SourceCodeLine = 107;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 108;
        GSCOMMAND  .UpdateValue ( "stop"  ) ; 
        __context__.SourceCodeLine = 108;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ADVANCE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 109;
        GSCOMMAND  .UpdateValue ( "advance"  ) ; 
        __context__.SourceCodeLine = 109;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FFWD_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 110;
        GSCOMMAND  .UpdateValue ( "ffwd"  ) ; 
        __context__.SourceCodeLine = 110;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REC_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 111;
        GSCOMMAND  .UpdateValue ( "record"  ) ; 
        __context__.SourceCodeLine = 111;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAY_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 112;
        GSCOMMAND  .UpdateValue ( "play"  ) ; 
        __context__.SourceCodeLine = 112;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUIDE_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 113;
        GSCOMMAND  .UpdateValue ( "guide"  ) ; 
        __context__.SourceCodeLine = 113;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ACTIVE_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 114;
        GSCOMMAND  .UpdateValue ( "active"  ) ; 
        __context__.SourceCodeLine = 114;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 115;
        GSCOMMAND  .UpdateValue ( "list"  ) ; 
        __context__.SourceCodeLine = 115;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EXIT_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 116;
        GSCOMMAND  .UpdateValue ( "exit"  ) ; 
        __context__.SourceCodeLine = 116;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BACK_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 117;
        GSCOMMAND  .UpdateValue ( "back"  ) ; 
        __context__.SourceCodeLine = 117;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MENU_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 118;
        GSCOMMAND  .UpdateValue ( "menu"  ) ; 
        __context__.SourceCodeLine = 118;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INFO_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        GSCOMMAND  .UpdateValue ( "info"  ) ; 
        __context__.SourceCodeLine = 119;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 120;
        GSCOMMAND  .UpdateValue ( "select"  ) ; 
        __context__.SourceCodeLine = 120;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RED_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 121;
        GSCOMMAND  .UpdateValue ( "red"  ) ; 
        __context__.SourceCodeLine = 121;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GREEN_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 122;
        GSCOMMAND  .UpdateValue ( "green"  ) ; 
        __context__.SourceCodeLine = 122;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object YELLOW_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 123;
        GSCOMMAND  .UpdateValue ( "yellow"  ) ; 
        __context__.SourceCodeLine = 123;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BLUE_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 124;
        GSCOMMAND  .UpdateValue ( "blue"  ) ; 
        __context__.SourceCodeLine = 124;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREV_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 125;
        GSCOMMAND  .UpdateValue ( "prev"  ) ; 
        __context__.SourceCodeLine = 125;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_0_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 126;
        GSCOMMAND  .UpdateValue ( "0"  ) ; 
        __context__.SourceCodeLine = 126;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_1_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 127;
        GSCOMMAND  .UpdateValue ( "1"  ) ; 
        __context__.SourceCodeLine = 127;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_2_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 128;
        GSCOMMAND  .UpdateValue ( "2"  ) ; 
        __context__.SourceCodeLine = 128;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_3_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        GSCOMMAND  .UpdateValue ( "3"  ) ; 
        __context__.SourceCodeLine = 129;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_4_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 130;
        GSCOMMAND  .UpdateValue ( "4"  ) ; 
        __context__.SourceCodeLine = 130;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_5_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 131;
        GSCOMMAND  .UpdateValue ( "5"  ) ; 
        __context__.SourceCodeLine = 131;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_6_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 132;
        GSCOMMAND  .UpdateValue ( "6"  ) ; 
        __context__.SourceCodeLine = 132;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_7_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 133;
        GSCOMMAND  .UpdateValue ( "7"  ) ; 
        __context__.SourceCodeLine = 133;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_8_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 134;
        GSCOMMAND  .UpdateValue ( "8"  ) ; 
        __context__.SourceCodeLine = 134;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIGIT_9_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        GSCOMMAND  .UpdateValue ( "9"  ) ; 
        __context__.SourceCodeLine = 135;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DASH_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 136;
        GSCOMMAND  .UpdateValue ( "dash"  ) ; 
        __context__.SourceCodeLine = 136;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_OnPush_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 137;
        GSCOMMAND  .UpdateValue ( "enter"  ) ; 
        __context__.SourceCodeLine = 137;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_UP_OnPush_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 139;
        GSCOMMAND  .UpdateValue ( "up"  ) ; 
        __context__.SourceCodeLine = 139;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_DOWN_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 140;
        GSCOMMAND  .UpdateValue ( "down"  ) ; 
        __context__.SourceCodeLine = 140;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_LEFT_OnPush_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 141;
        GSCOMMAND  .UpdateValue ( "left"  ) ; 
        __context__.SourceCodeLine = 141;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_RIGHT_OnPush_41 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        GSCOMMAND  .UpdateValue ( "right"  ) ; 
        __context__.SourceCodeLine = 142;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_UP_OnPush_42 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 143;
        GSCOMMAND  .UpdateValue ( "chanup"  ) ; 
        __context__.SourceCodeLine = 143;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_DOWN_OnPush_43 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 144;
        GSCOMMAND  .UpdateValue ( "chandown"  ) ; 
        __context__.SourceCodeLine = 144;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_UP_HELD_OnPush_44 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 146;
        GSCOMMAND  .UpdateValue ( "up&hold=keyDown"  ) ; 
        __context__.SourceCodeLine = 146;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_DOWN_HELD_OnPush_45 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 147;
        GSCOMMAND  .UpdateValue ( "down&hold=keyDown"  ) ; 
        __context__.SourceCodeLine = 147;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_LEFT_HELD_OnPush_46 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 148;
        GSCOMMAND  .UpdateValue ( "left&hold=keyDown"  ) ; 
        __context__.SourceCodeLine = 148;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_RIGHT_HELD_OnPush_47 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 149;
        GSCOMMAND  .UpdateValue ( "right&hold=keyDown"  ) ; 
        __context__.SourceCodeLine = 149;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_UP_HELD_OnPush_48 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        GSCOMMAND  .UpdateValue ( "chanup&hold=keyDown"  ) ; 
        __context__.SourceCodeLine = 150;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_DOWN_HELD_OnPush_49 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 151;
        GSCOMMAND  .UpdateValue ( "chandown&hold=keyDown"  ) ; 
        __context__.SourceCodeLine = 151;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_UP_HELD_OnRelease_50 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 153;
        GSCOMMAND  .UpdateValue ( "up&hold=keyUp"  ) ; 
        __context__.SourceCodeLine = 153;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_DOWN_HELD_OnRelease_51 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 154;
        GSCOMMAND  .UpdateValue ( "down&hold=keyUp"  ) ; 
        __context__.SourceCodeLine = 154;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_LEFT_HELD_OnRelease_52 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 155;
        GSCOMMAND  .UpdateValue ( "left&hold=keyUp"  ) ; 
        __context__.SourceCodeLine = 155;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAV_RIGHT_HELD_OnRelease_53 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 156;
        GSCOMMAND  .UpdateValue ( "right&hold=keyUp"  ) ; 
        __context__.SourceCodeLine = 156;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_UP_HELD_OnRelease_54 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 157;
        GSCOMMAND  .UpdateValue ( "chanup&hold=keyUp"  ) ; 
        __context__.SourceCodeLine = 157;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_DOWN_HELD_OnRelease_55 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 158;
        GSCOMMAND  .UpdateValue ( "chandown&hold=keyUp"  ) ; 
        __context__.SourceCodeLine = 158;
        CONNECTTOSENDCOMMAND (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DTV_COMMAND_TCPCLIENT_OnSocketStatus_56 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 162;
        
            {
            int __SPLS_TMPVAR__SWTCH_1__ = ((int)DTV_COMMAND_TCPCLIENT.SocketStatus);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 166;
                    Functions.SocketDisconnectClient ( DTV_COMMAND_TCPCLIENT ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    Functions.SocketDisconnectClient ( DTV_COMMAND_TCPCLIENT ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 174;
                    Functions.SocketDisconnectClient ( DTV_COMMAND_TCPCLIENT ) ; 
                    } 
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 177;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            {
            __context__.SourceCodeLine = 177;
            Print( "{0} - Socket Status = {1:d}\r\n", GetSymbolInstanceName ( ) , (short)DTV_COMMAND_TCPCLIENT.SocketStatus) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object DTV_COMMAND_TCPCLIENT_OnSocketConnect_57 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        CrestronString SGET;
        SGET  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8192, this );
        
        
        __context__.SourceCodeLine = 185;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCOMMAND == "!CHANNEL!"))  ) ) 
            {
            __context__.SourceCodeLine = 186;
            MakeString ( SGET , "GET /tv/tune?major={0:d}&minor=65535 HTTP/1.1\r\n\r\n", (short)CHANNEL  .UshortValue) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 188;
            MakeString ( SGET , "GET /remote/processKey?key={0} HTTP/1.1\r\n\r\n", GSCOMMAND ) ; 
            }
        
        __context__.SourceCodeLine = 190;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            {
            __context__.SourceCodeLine = 190;
            Print( "{0}", SGET ) ; 
            }
        
        __context__.SourceCodeLine = 192;
        Functions.SocketSend ( DTV_COMMAND_TCPCLIENT , SGET ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object DTV_COMMAND_TCPCLIENT_OnSocketReceive_58 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        CrestronString SDUMP;
        SDUMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8192, this );
        
        
        __context__.SourceCodeLine = 200;
        if ( Functions.TestForTrue  ( ( 0)  ) ) 
            { 
            __context__.SourceCodeLine = 202;
            Print( "\r\n\r\n{0}\r\n\r\n", DTV_COMMAND_TCPCLIENT .  SocketRxBuf ) ; 
            __context__.SourceCodeLine = 203;
            Functions.Delay (  (int) ( 5000 ) ) ; 
            } 
        
        __context__.SourceCodeLine = 208;
        Functions.ClearBuffer ( DTV_COMMAND_TCPCLIENT .  SocketRxBuf ) ; 
        __context__.SourceCodeLine = 210;
        Functions.SocketDisconnectClient ( DTV_COMMAND_TCPCLIENT ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    GSCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
    DTV_COMMAND_TCPCLIENT  = new SplusTcpClient ( 8192, this );
    
    POWER = new Crestron.Logos.SplusObjects.DigitalInput( POWER__DigitalInput__, this );
    m_DigitalInputList.Add( POWER__DigitalInput__, POWER );
    
    POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON__DigitalInput__, POWER_ON );
    
    POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF__DigitalInput__, POWER_OFF );
    
    FORMAT = new Crestron.Logos.SplusObjects.DigitalInput( FORMAT__DigitalInput__, this );
    m_DigitalInputList.Add( FORMAT__DigitalInput__, FORMAT );
    
    PAUSE = new Crestron.Logos.SplusObjects.DigitalInput( PAUSE__DigitalInput__, this );
    m_DigitalInputList.Add( PAUSE__DigitalInput__, PAUSE );
    
    REW = new Crestron.Logos.SplusObjects.DigitalInput( REW__DigitalInput__, this );
    m_DigitalInputList.Add( REW__DigitalInput__, REW );
    
    REPLAY = new Crestron.Logos.SplusObjects.DigitalInput( REPLAY__DigitalInput__, this );
    m_DigitalInputList.Add( REPLAY__DigitalInput__, REPLAY );
    
    STOP = new Crestron.Logos.SplusObjects.DigitalInput( STOP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP__DigitalInput__, STOP );
    
    ADVANCE = new Crestron.Logos.SplusObjects.DigitalInput( ADVANCE__DigitalInput__, this );
    m_DigitalInputList.Add( ADVANCE__DigitalInput__, ADVANCE );
    
    FFWD = new Crestron.Logos.SplusObjects.DigitalInput( FFWD__DigitalInput__, this );
    m_DigitalInputList.Add( FFWD__DigitalInput__, FFWD );
    
    REC = new Crestron.Logos.SplusObjects.DigitalInput( REC__DigitalInput__, this );
    m_DigitalInputList.Add( REC__DigitalInput__, REC );
    
    PLAY = new Crestron.Logos.SplusObjects.DigitalInput( PLAY__DigitalInput__, this );
    m_DigitalInputList.Add( PLAY__DigitalInput__, PLAY );
    
    GUIDE = new Crestron.Logos.SplusObjects.DigitalInput( GUIDE__DigitalInput__, this );
    m_DigitalInputList.Add( GUIDE__DigitalInput__, GUIDE );
    
    ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( ACTIVE__DigitalInput__, ACTIVE );
    
    LIST = new Crestron.Logos.SplusObjects.DigitalInput( LIST__DigitalInput__, this );
    m_DigitalInputList.Add( LIST__DigitalInput__, LIST );
    
    EXIT = new Crestron.Logos.SplusObjects.DigitalInput( EXIT__DigitalInput__, this );
    m_DigitalInputList.Add( EXIT__DigitalInput__, EXIT );
    
    BACK = new Crestron.Logos.SplusObjects.DigitalInput( BACK__DigitalInput__, this );
    m_DigitalInputList.Add( BACK__DigitalInput__, BACK );
    
    MENU = new Crestron.Logos.SplusObjects.DigitalInput( MENU__DigitalInput__, this );
    m_DigitalInputList.Add( MENU__DigitalInput__, MENU );
    
    INFO = new Crestron.Logos.SplusObjects.DigitalInput( INFO__DigitalInput__, this );
    m_DigitalInputList.Add( INFO__DigitalInput__, INFO );
    
    NAV_UP = new Crestron.Logos.SplusObjects.DigitalInput( NAV_UP__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_UP__DigitalInput__, NAV_UP );
    
    NAV_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( NAV_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_DOWN__DigitalInput__, NAV_DOWN );
    
    NAV_LEFT = new Crestron.Logos.SplusObjects.DigitalInput( NAV_LEFT__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_LEFT__DigitalInput__, NAV_LEFT );
    
    NAV_RIGHT = new Crestron.Logos.SplusObjects.DigitalInput( NAV_RIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_RIGHT__DigitalInput__, NAV_RIGHT );
    
    NAV_UP_HELD = new Crestron.Logos.SplusObjects.DigitalInput( NAV_UP_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_UP_HELD__DigitalInput__, NAV_UP_HELD );
    
    NAV_DOWN_HELD = new Crestron.Logos.SplusObjects.DigitalInput( NAV_DOWN_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_DOWN_HELD__DigitalInput__, NAV_DOWN_HELD );
    
    NAV_LEFT_HELD = new Crestron.Logos.SplusObjects.DigitalInput( NAV_LEFT_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_LEFT_HELD__DigitalInput__, NAV_LEFT_HELD );
    
    NAV_RIGHT_HELD = new Crestron.Logos.SplusObjects.DigitalInput( NAV_RIGHT_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( NAV_RIGHT_HELD__DigitalInput__, NAV_RIGHT_HELD );
    
    SELECT = new Crestron.Logos.SplusObjects.DigitalInput( SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT__DigitalInput__, SELECT );
    
    RED = new Crestron.Logos.SplusObjects.DigitalInput( RED__DigitalInput__, this );
    m_DigitalInputList.Add( RED__DigitalInput__, RED );
    
    GREEN = new Crestron.Logos.SplusObjects.DigitalInput( GREEN__DigitalInput__, this );
    m_DigitalInputList.Add( GREEN__DigitalInput__, GREEN );
    
    YELLOW = new Crestron.Logos.SplusObjects.DigitalInput( YELLOW__DigitalInput__, this );
    m_DigitalInputList.Add( YELLOW__DigitalInput__, YELLOW );
    
    BLUE = new Crestron.Logos.SplusObjects.DigitalInput( BLUE__DigitalInput__, this );
    m_DigitalInputList.Add( BLUE__DigitalInput__, BLUE );
    
    CH_UP = new Crestron.Logos.SplusObjects.DigitalInput( CH_UP__DigitalInput__, this );
    m_DigitalInputList.Add( CH_UP__DigitalInput__, CH_UP );
    
    CH_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( CH_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CH_DOWN__DigitalInput__, CH_DOWN );
    
    CH_UP_HELD = new Crestron.Logos.SplusObjects.DigitalInput( CH_UP_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( CH_UP_HELD__DigitalInput__, CH_UP_HELD );
    
    CH_DOWN_HELD = new Crestron.Logos.SplusObjects.DigitalInput( CH_DOWN_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( CH_DOWN_HELD__DigitalInput__, CH_DOWN_HELD );
    
    PREV = new Crestron.Logos.SplusObjects.DigitalInput( PREV__DigitalInput__, this );
    m_DigitalInputList.Add( PREV__DigitalInput__, PREV );
    
    DIGIT_0 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_0__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_0__DigitalInput__, DIGIT_0 );
    
    DIGIT_1 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_1__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_1__DigitalInput__, DIGIT_1 );
    
    DIGIT_2 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_2__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_2__DigitalInput__, DIGIT_2 );
    
    DIGIT_3 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_3__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_3__DigitalInput__, DIGIT_3 );
    
    DIGIT_4 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_4__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_4__DigitalInput__, DIGIT_4 );
    
    DIGIT_5 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_5__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_5__DigitalInput__, DIGIT_5 );
    
    DIGIT_6 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_6__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_6__DigitalInput__, DIGIT_6 );
    
    DIGIT_7 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_7__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_7__DigitalInput__, DIGIT_7 );
    
    DIGIT_8 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_8__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_8__DigitalInput__, DIGIT_8 );
    
    DIGIT_9 = new Crestron.Logos.SplusObjects.DigitalInput( DIGIT_9__DigitalInput__, this );
    m_DigitalInputList.Add( DIGIT_9__DigitalInput__, DIGIT_9 );
    
    DASH = new Crestron.Logos.SplusObjects.DigitalInput( DASH__DigitalInput__, this );
    m_DigitalInputList.Add( DASH__DigitalInput__, DASH );
    
    ENTER = new Crestron.Logos.SplusObjects.DigitalInput( ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER__DigitalInput__, ENTER );
    
    CHANNEL = new Crestron.Logos.SplusObjects.AnalogInput( CHANNEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHANNEL__AnalogSerialInput__, CHANNEL );
    
    IPA = new StringParameter( IPA__Parameter__, this );
    m_ParameterList.Add( IPA__Parameter__, IPA );
    
    
    CHANNEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( CHANNEL_OnChange_0, false ) );
    POWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OnPush_1, false ) );
    POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_OnPush_2, false ) );
    POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_OnPush_3, false ) );
    FORMAT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FORMAT_OnPush_4, false ) );
    PAUSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAUSE_OnPush_5, false ) );
    REW.OnDigitalPush.Add( new InputChangeHandlerWrapper( REW_OnPush_6, false ) );
    REPLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( REPLAY_OnPush_7, false ) );
    STOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_OnPush_8, false ) );
    ADVANCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ADVANCE_OnPush_9, false ) );
    FFWD.OnDigitalPush.Add( new InputChangeHandlerWrapper( FFWD_OnPush_10, false ) );
    REC.OnDigitalPush.Add( new InputChangeHandlerWrapper( REC_OnPush_11, false ) );
    PLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAY_OnPush_12, false ) );
    GUIDE.OnDigitalPush.Add( new InputChangeHandlerWrapper( GUIDE_OnPush_13, false ) );
    ACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ACTIVE_OnPush_14, false ) );
    LIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIST_OnPush_15, false ) );
    EXIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EXIT_OnPush_16, false ) );
    BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( BACK_OnPush_17, false ) );
    MENU.OnDigitalPush.Add( new InputChangeHandlerWrapper( MENU_OnPush_18, false ) );
    INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( INFO_OnPush_19, false ) );
    SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_OnPush_20, false ) );
    RED.OnDigitalPush.Add( new InputChangeHandlerWrapper( RED_OnPush_21, false ) );
    GREEN.OnDigitalPush.Add( new InputChangeHandlerWrapper( GREEN_OnPush_22, false ) );
    YELLOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( YELLOW_OnPush_23, false ) );
    BLUE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BLUE_OnPush_24, false ) );
    PREV.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREV_OnPush_25, false ) );
    DIGIT_0.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_0_OnPush_26, false ) );
    DIGIT_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_1_OnPush_27, false ) );
    DIGIT_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_2_OnPush_28, false ) );
    DIGIT_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_3_OnPush_29, false ) );
    DIGIT_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_4_OnPush_30, false ) );
    DIGIT_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_5_OnPush_31, false ) );
    DIGIT_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_6_OnPush_32, false ) );
    DIGIT_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_7_OnPush_33, false ) );
    DIGIT_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_8_OnPush_34, false ) );
    DIGIT_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGIT_9_OnPush_35, false ) );
    DASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( DASH_OnPush_36, false ) );
    ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_OnPush_37, false ) );
    NAV_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_UP_OnPush_38, false ) );
    NAV_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_DOWN_OnPush_39, false ) );
    NAV_LEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_LEFT_OnPush_40, false ) );
    NAV_RIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_RIGHT_OnPush_41, false ) );
    CH_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CH_UP_OnPush_42, false ) );
    CH_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CH_DOWN_OnPush_43, false ) );
    NAV_UP_HELD.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_UP_HELD_OnPush_44, false ) );
    NAV_DOWN_HELD.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_DOWN_HELD_OnPush_45, false ) );
    NAV_LEFT_HELD.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_LEFT_HELD_OnPush_46, false ) );
    NAV_RIGHT_HELD.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAV_RIGHT_HELD_OnPush_47, false ) );
    CH_UP_HELD.OnDigitalPush.Add( new InputChangeHandlerWrapper( CH_UP_HELD_OnPush_48, false ) );
    CH_DOWN_HELD.OnDigitalPush.Add( new InputChangeHandlerWrapper( CH_DOWN_HELD_OnPush_49, false ) );
    NAV_UP_HELD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( NAV_UP_HELD_OnRelease_50, false ) );
    NAV_DOWN_HELD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( NAV_DOWN_HELD_OnRelease_51, false ) );
    NAV_LEFT_HELD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( NAV_LEFT_HELD_OnRelease_52, false ) );
    NAV_RIGHT_HELD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( NAV_RIGHT_HELD_OnRelease_53, false ) );
    CH_UP_HELD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CH_UP_HELD_OnRelease_54, false ) );
    CH_DOWN_HELD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CH_DOWN_HELD_OnRelease_55, false ) );
    DTV_COMMAND_TCPCLIENT.OnSocketStatus.Add( new SocketHandlerWrapper( DTV_COMMAND_TCPCLIENT_OnSocketStatus_56, false ) );
    DTV_COMMAND_TCPCLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( DTV_COMMAND_TCPCLIENT_OnSocketConnect_57, false ) );
    DTV_COMMAND_TCPCLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( DTV_COMMAND_TCPCLIENT_OnSocketReceive_58, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DIRECTV_ETHERNET_CONTROL_V1_02 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint IPA__Parameter__ = 10;
const uint POWER__DigitalInput__ = 0;
const uint POWER_ON__DigitalInput__ = 1;
const uint POWER_OFF__DigitalInput__ = 2;
const uint FORMAT__DigitalInput__ = 3;
const uint PAUSE__DigitalInput__ = 4;
const uint REW__DigitalInput__ = 5;
const uint REPLAY__DigitalInput__ = 6;
const uint STOP__DigitalInput__ = 7;
const uint ADVANCE__DigitalInput__ = 8;
const uint FFWD__DigitalInput__ = 9;
const uint REC__DigitalInput__ = 10;
const uint PLAY__DigitalInput__ = 11;
const uint GUIDE__DigitalInput__ = 12;
const uint ACTIVE__DigitalInput__ = 13;
const uint LIST__DigitalInput__ = 14;
const uint EXIT__DigitalInput__ = 15;
const uint BACK__DigitalInput__ = 16;
const uint MENU__DigitalInput__ = 17;
const uint INFO__DigitalInput__ = 18;
const uint NAV_UP__DigitalInput__ = 19;
const uint NAV_DOWN__DigitalInput__ = 20;
const uint NAV_LEFT__DigitalInput__ = 21;
const uint NAV_RIGHT__DigitalInput__ = 22;
const uint NAV_UP_HELD__DigitalInput__ = 23;
const uint NAV_DOWN_HELD__DigitalInput__ = 24;
const uint NAV_LEFT_HELD__DigitalInput__ = 25;
const uint NAV_RIGHT_HELD__DigitalInput__ = 26;
const uint SELECT__DigitalInput__ = 27;
const uint RED__DigitalInput__ = 28;
const uint GREEN__DigitalInput__ = 29;
const uint YELLOW__DigitalInput__ = 30;
const uint BLUE__DigitalInput__ = 31;
const uint CH_UP__DigitalInput__ = 32;
const uint CH_DOWN__DigitalInput__ = 33;
const uint CH_UP_HELD__DigitalInput__ = 34;
const uint CH_DOWN_HELD__DigitalInput__ = 35;
const uint PREV__DigitalInput__ = 36;
const uint DIGIT_0__DigitalInput__ = 37;
const uint DIGIT_1__DigitalInput__ = 38;
const uint DIGIT_2__DigitalInput__ = 39;
const uint DIGIT_3__DigitalInput__ = 40;
const uint DIGIT_4__DigitalInput__ = 41;
const uint DIGIT_5__DigitalInput__ = 42;
const uint DIGIT_6__DigitalInput__ = 43;
const uint DIGIT_7__DigitalInput__ = 44;
const uint DIGIT_8__DigitalInput__ = 45;
const uint DIGIT_9__DigitalInput__ = 46;
const uint DASH__DigitalInput__ = 47;
const uint ENTER__DigitalInput__ = 48;
const uint CHANNEL__AnalogSerialInput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
