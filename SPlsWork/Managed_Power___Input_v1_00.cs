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

namespace UserModule_MANAGED_POWER___INPUT_V1_00
{
    public class UserModuleClass_MANAGED_POWER___INPUT_V1_00 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON_FB;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON_DELAY_FB;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF_DELAY_FB;
        Crestron.Logos.SplusObjects.DigitalInput SWITCH_DELAY_FB;
        Crestron.Logos.SplusObjects.DigitalInput SMART_POWER;
        Crestron.Logos.SplusObjects.DigitalInput SMART_SWITCHER;
        Crestron.Logos.SplusObjects.DigitalInput SMART_POWER_OFF_DELAY;
        Crestron.Logos.SplusObjects.DigitalInput PRE_POWER_ON_INPUT_SWITCHER;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> INPUT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> INPUT_FB;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_ON_TRIG;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_OFF_TRIG;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_ON_DELAY;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_OFF_DELAY;
        Crestron.Logos.SplusObjects.DigitalOutput SWITCH_DELAY;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_ON_DELAY_WARNING;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_OFF_DELAY_WARNING;
        Crestron.Logos.SplusObjects.DigitalOutput SWITCH_DELAY_WARNING;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> INPUT_TRIG;
        Crestron.Logos.SplusObjects.AnalogInput PULSE_TIME;
        ushort GNINPUT = 0;
        ushort GNDOPOWERON = 0;
        ushort GNDOPOWEROFF = 0;
        ushort GNDOSWITCH = 0;
        private void INPUTSWITCH (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 26;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( GNINPUT > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( GNINPUT <= 16 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 28;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( INPUT_FB[ GNINPUT ] .Value ) ) || Functions.TestForTrue ( Functions.Not( SMART_SWITCHER  .Value ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 30;
                    Functions.Pulse ( PULSE_TIME  .UshortValue, INPUT_TRIG [ GNINPUT] ) ; 
                    __context__.SourceCodeLine = 31;
                    Functions.Pulse ( 1, SWITCH_DELAY ) ; 
                    } 
                
                } 
            
            
            }
            
        private ushort POWERON (  SplusExecutionContext __context__ ) 
            { 
            ushort NRETURN = 0;
            
            
            __context__.SourceCodeLine = 40;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( POWER_ON_FB  .Value ) ) || Functions.TestForTrue ( Functions.Not( SMART_POWER  .Value ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 42;
                Functions.Pulse ( PULSE_TIME  .UshortValue, POWER_ON_TRIG ) ; 
                __context__.SourceCodeLine = 43;
                Functions.Pulse ( 1, POWER_ON_DELAY ) ; 
                __context__.SourceCodeLine = 45;
                NRETURN = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 49;
                NRETURN = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 52;
            return (ushort)( NRETURN) ; 
            
            }
            
        private ushort POWEROFF (  SplusExecutionContext __context__ ) 
            { 
            ushort NRETURN = 0;
            
            
            __context__.SourceCodeLine = 59;
            Functions.Pulse ( PULSE_TIME  .UshortValue, POWER_OFF_TRIG ) ; 
            __context__.SourceCodeLine = 61;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( POWER_OFF_FB  .Value ) ) || Functions.TestForTrue ( Functions.Not( SMART_POWER  .Value ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 63;
                Functions.Pulse ( 1, POWER_OFF_DELAY ) ; 
                __context__.SourceCodeLine = 65;
                NRETURN = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 69;
                NRETURN = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 72;
            return (ushort)( NRETURN) ; 
            
            }
            
        object POWER_ON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 77;
                if ( Functions.TestForTrue  ( ( POWER_OFF_DELAY_FB  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 79;
                    Functions.Pulse ( 1, POWER_OFF_DELAY_WARNING ) ; 
                    __context__.SourceCodeLine = 80;
                    if ( Functions.TestForTrue  ( ( SMART_POWER_OFF_DELAY  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 82;
                        GNDOPOWERON = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 83;
                        GNDOPOWEROFF = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 86;
                    if ( Functions.TestForTrue  ( ( POWER_ON_DELAY_FB  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 88;
                        Functions.Pulse ( 1, POWER_ON_DELAY_WARNING ) ; 
                        __context__.SourceCodeLine = 89;
                        GNDOPOWEROFF = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 93;
                        POWERON (  __context__  ) ; 
                        } 
                    
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POWER_OFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 99;
            POWEROFF (  __context__  ) ; 
            __context__.SourceCodeLine = 100;
            if ( Functions.TestForTrue  ( ( POWER_ON_DELAY_FB  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 102;
                Functions.Pulse ( 1, POWER_ON_DELAY_WARNING ) ; 
                __context__.SourceCodeLine = 103;
                GNDOPOWEROFF = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 104;
                GNDOPOWERON = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 105;
                GNDOSWITCH = (ushort) ( 0 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 107;
                if ( Functions.TestForTrue  ( ( POWER_OFF_DELAY_FB  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 109;
                    Functions.Pulse ( 1, POWER_OFF_DELAY_WARNING ) ; 
                    __context__.SourceCodeLine = 110;
                    GNDOPOWERON = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 111;
                    GNDOSWITCH = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 115;
                    GNDOSWITCH = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 116;
                    POWEROFF (  __context__  ) ; 
                    } 
                
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object INPUT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 122;
        GNINPUT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 124;
        if ( Functions.TestForTrue  ( ( POWER_OFF_DELAY_FB  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 126;
            Functions.Pulse ( 1, POWER_OFF_DELAY_WARNING ) ; 
            __context__.SourceCodeLine = 127;
            if ( Functions.TestForTrue  ( ( SMART_POWER_OFF_DELAY  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 129;
                GNDOSWITCH = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 132;
            if ( Functions.TestForTrue  ( ( POWER_ON_DELAY_FB  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 134;
                Functions.Pulse ( 1, POWER_ON_DELAY_WARNING ) ; 
                __context__.SourceCodeLine = 135;
                GNDOPOWEROFF = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 136;
                GNDOSWITCH = (ushort) ( 1 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 138;
                if ( Functions.TestForTrue  ( ( SWITCH_DELAY_FB  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 140;
                    Functions.Pulse ( 1, SWITCH_DELAY_WARNING ) ; 
                    __context__.SourceCodeLine = 141;
                    GNDOSWITCH = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 145;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( PRE_POWER_ON_INPUT_SWITCHER  .Value ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( POWER_ON_FB  .Value ) ) || Functions.TestForTrue ( Functions.Not( SMART_POWER  .Value ) )) ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 147;
                        GNDOSWITCH = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 148;
                        INPUTSWITCH (  __context__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 152;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POWERON( __context__ ) == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 154;
                            GNDOPOWEROFF = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 155;
                            GNDOSWITCH = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 159;
                            INPUTSWITCH (  __context__  ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_ON_DELAY_FB_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 167;
        if ( Functions.TestForTrue  ( ( GNDOSWITCH)  ) ) 
            { 
            __context__.SourceCodeLine = 169;
            GNDOSWITCH = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 170;
            INPUTSWITCH (  __context__  ) ; 
            } 
        
        __context__.SourceCodeLine = 173;
        if ( Functions.TestForTrue  ( ( GNDOPOWEROFF)  ) ) 
            { 
            __context__.SourceCodeLine = 175;
            GNDOPOWEROFF = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 176;
            POWEROFF (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_OFF_DELAY_FB_OnRelease_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 182;
        if ( Functions.TestForTrue  ( ( GNDOSWITCH)  ) ) 
            { 
            __context__.SourceCodeLine = 184;
            GNDOSWITCH = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 185;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( PRE_POWER_ON_INPUT_SWITCHER  .Value ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( POWER_ON_FB  .Value ) ) || Functions.TestForTrue ( Functions.Not( SMART_POWER  .Value ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 187;
                GNDOSWITCH = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 188;
                INPUTSWITCH (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 192;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POWERON( __context__ ) == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 194;
                    GNDOSWITCH = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 198;
                    INPUTSWITCH (  __context__  ) ; 
                    } 
                
                } 
            
            } 
        
        __context__.SourceCodeLine = 203;
        if ( Functions.TestForTrue  ( ( GNDOPOWERON)  ) ) 
            { 
            __context__.SourceCodeLine = 205;
            GNDOPOWERON = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 206;
            POWERON (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_DELAY_FB_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 212;
        if ( Functions.TestForTrue  ( ( GNDOSWITCH)  ) ) 
            { 
            __context__.SourceCodeLine = 214;
            GNDOSWITCH = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 215;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POWERON( __context__ ) == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 217;
                GNDOSWITCH = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 221;
                INPUTSWITCH (  __context__  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 228;
        GNDOPOWERON = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 229;
        GNDOPOWEROFF = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 230;
        GNDOSWITCH = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON__DigitalInput__, POWER_ON );
    
    POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF__DigitalInput__, POWER_OFF );
    
    POWER_ON_FB = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON_FB__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON_FB__DigitalInput__, POWER_ON_FB );
    
    POWER_OFF_FB = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF_FB__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF_FB__DigitalInput__, POWER_OFF_FB );
    
    POWER_ON_DELAY_FB = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON_DELAY_FB__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON_DELAY_FB__DigitalInput__, POWER_ON_DELAY_FB );
    
    POWER_OFF_DELAY_FB = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF_DELAY_FB__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF_DELAY_FB__DigitalInput__, POWER_OFF_DELAY_FB );
    
    SWITCH_DELAY_FB = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_DELAY_FB__DigitalInput__, this );
    m_DigitalInputList.Add( SWITCH_DELAY_FB__DigitalInput__, SWITCH_DELAY_FB );
    
    SMART_POWER = new Crestron.Logos.SplusObjects.DigitalInput( SMART_POWER__DigitalInput__, this );
    m_DigitalInputList.Add( SMART_POWER__DigitalInput__, SMART_POWER );
    
    SMART_SWITCHER = new Crestron.Logos.SplusObjects.DigitalInput( SMART_SWITCHER__DigitalInput__, this );
    m_DigitalInputList.Add( SMART_SWITCHER__DigitalInput__, SMART_SWITCHER );
    
    SMART_POWER_OFF_DELAY = new Crestron.Logos.SplusObjects.DigitalInput( SMART_POWER_OFF_DELAY__DigitalInput__, this );
    m_DigitalInputList.Add( SMART_POWER_OFF_DELAY__DigitalInput__, SMART_POWER_OFF_DELAY );
    
    PRE_POWER_ON_INPUT_SWITCHER = new Crestron.Logos.SplusObjects.DigitalInput( PRE_POWER_ON_INPUT_SWITCHER__DigitalInput__, this );
    m_DigitalInputList.Add( PRE_POWER_ON_INPUT_SWITCHER__DigitalInput__, PRE_POWER_ON_INPUT_SWITCHER );
    
    INPUT = new InOutArray<DigitalInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        INPUT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( INPUT__DigitalInput__ + i, INPUT__DigitalInput__, this );
        m_DigitalInputList.Add( INPUT__DigitalInput__ + i, INPUT[i+1] );
    }
    
    INPUT_FB = new InOutArray<DigitalInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        INPUT_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_FB__DigitalInput__ + i, INPUT_FB__DigitalInput__, this );
        m_DigitalInputList.Add( INPUT_FB__DigitalInput__ + i, INPUT_FB[i+1] );
    }
    
    POWER_ON_TRIG = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_ON_TRIG__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_ON_TRIG__DigitalOutput__, POWER_ON_TRIG );
    
    POWER_OFF_TRIG = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_OFF_TRIG__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_OFF_TRIG__DigitalOutput__, POWER_OFF_TRIG );
    
    POWER_ON_DELAY = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_ON_DELAY__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_ON_DELAY__DigitalOutput__, POWER_ON_DELAY );
    
    POWER_OFF_DELAY = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_OFF_DELAY__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_OFF_DELAY__DigitalOutput__, POWER_OFF_DELAY );
    
    SWITCH_DELAY = new Crestron.Logos.SplusObjects.DigitalOutput( SWITCH_DELAY__DigitalOutput__, this );
    m_DigitalOutputList.Add( SWITCH_DELAY__DigitalOutput__, SWITCH_DELAY );
    
    POWER_ON_DELAY_WARNING = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_ON_DELAY_WARNING__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_ON_DELAY_WARNING__DigitalOutput__, POWER_ON_DELAY_WARNING );
    
    POWER_OFF_DELAY_WARNING = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_OFF_DELAY_WARNING__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_OFF_DELAY_WARNING__DigitalOutput__, POWER_OFF_DELAY_WARNING );
    
    SWITCH_DELAY_WARNING = new Crestron.Logos.SplusObjects.DigitalOutput( SWITCH_DELAY_WARNING__DigitalOutput__, this );
    m_DigitalOutputList.Add( SWITCH_DELAY_WARNING__DigitalOutput__, SWITCH_DELAY_WARNING );
    
    INPUT_TRIG = new InOutArray<DigitalOutput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        INPUT_TRIG[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( INPUT_TRIG__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( INPUT_TRIG__DigitalOutput__ + i, INPUT_TRIG[i+1] );
    }
    
    PULSE_TIME = new Crestron.Logos.SplusObjects.AnalogInput( PULSE_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PULSE_TIME__AnalogSerialInput__, PULSE_TIME );
    
    
    POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_OnPush_0, false ) );
    POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_OnPush_1, false ) );
    for( uint i = 0; i < 16; i++ )
        INPUT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_OnPush_2, false ) );
        
    POWER_ON_DELAY_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( POWER_ON_DELAY_FB_OnRelease_3, false ) );
    POWER_OFF_DELAY_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( POWER_OFF_DELAY_FB_OnRelease_4, false ) );
    SWITCH_DELAY_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SWITCH_DELAY_FB_OnRelease_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_MANAGED_POWER___INPUT_V1_00 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POWER_ON__DigitalInput__ = 0;
const uint POWER_OFF__DigitalInput__ = 1;
const uint POWER_ON_FB__DigitalInput__ = 2;
const uint POWER_OFF_FB__DigitalInput__ = 3;
const uint POWER_ON_DELAY_FB__DigitalInput__ = 4;
const uint POWER_OFF_DELAY_FB__DigitalInput__ = 5;
const uint SWITCH_DELAY_FB__DigitalInput__ = 6;
const uint SMART_POWER__DigitalInput__ = 7;
const uint SMART_SWITCHER__DigitalInput__ = 8;
const uint SMART_POWER_OFF_DELAY__DigitalInput__ = 9;
const uint PRE_POWER_ON_INPUT_SWITCHER__DigitalInput__ = 10;
const uint INPUT__DigitalInput__ = 11;
const uint INPUT_FB__DigitalInput__ = 27;
const uint POWER_ON_TRIG__DigitalOutput__ = 0;
const uint POWER_OFF_TRIG__DigitalOutput__ = 1;
const uint POWER_ON_DELAY__DigitalOutput__ = 2;
const uint POWER_OFF_DELAY__DigitalOutput__ = 3;
const uint SWITCH_DELAY__DigitalOutput__ = 4;
const uint POWER_ON_DELAY_WARNING__DigitalOutput__ = 5;
const uint POWER_OFF_DELAY_WARNING__DigitalOutput__ = 6;
const uint SWITCH_DELAY_WARNING__DigitalOutput__ = 7;
const uint INPUT_TRIG__DigitalOutput__ = 8;
const uint PULSE_TIME__AnalogSerialInput__ = 0;

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
