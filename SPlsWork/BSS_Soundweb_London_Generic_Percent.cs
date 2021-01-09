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

namespace UserModule_BSS_SOUNDWEB_LONDON_GENERIC_PERCENT
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_GENERIC_PERCENT : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput OBJECTID__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput STATEVARIABLE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput SUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput UNSUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput VALUE_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        private CrestronString ITOVOLUMEPERCENT (  SplusExecutionContext __context__, ushort INT ) 
            { 
            
            __context__.SourceCodeLine = 111;
            _SplusNVRAM.VOLUME = (ushort) ( ((INT * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 112;
            _SplusNVRAM.RETURNSTRING  .UpdateValue ( "\u0000" + Functions.Chr (  (int) ( _SplusNVRAM.VOLUME ) ) + "\u0000\u0000"  ) ; 
            __context__.SourceCodeLine = 113;
            return ( _SplusNVRAM.RETURNSTRING ) ; 
            
            }
            
        private ushort VOLUMEPERCENTTOI (  SplusExecutionContext __context__, CrestronString STR ) 
            { 
            ushort FRACTION = 0;
            
            
            __context__.SourceCodeLine = 120;
            FRACTION = (ushort) ( ((Byte( STR , (int)( 3 ) ) * 256) + Byte( STR , (int)( 4 ) )) ) ; 
            __context__.SourceCodeLine = 121;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRACTION > 32767 ))  ) ) 
                { 
                __context__.SourceCodeLine = 122;
                _SplusNVRAM.VOLUME = (ushort) ( (((Byte( STR , (int)( 2 ) ) + 1) * 65535) / 100) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 125;
                _SplusNVRAM.VOLUME = (ushort) ( ((Byte( STR , (int)( 2 ) ) * 65535) / 100) ) ; 
                } 
            
            __context__.SourceCodeLine = 127;
            _SplusNVRAM.RETURNI = (ushort) ( _SplusNVRAM.VOLUME ) ; 
            __context__.SourceCodeLine = 129;
            return (ushort)( _SplusNVRAM.RETURNI) ; 
            
            }
            
        object STATEVARIABLE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 138;
                _SplusNVRAM.STATEVARIABLE  .UpdateValue ( Functions.Chr (  (int) ( Functions.High( (ushort) STATEVARIABLE__DOLLAR__  .UshortValue ) ) ) + Functions.Chr (  (int) ( Functions.Low( (ushort) STATEVARIABLE__DOLLAR__  .UshortValue ) ) )  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VALUE__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 144;
            MakeString ( TX__DOLLAR__ , "\u008D\u0000\u0000\u0003{0}{1}{2}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , _SplusNVRAM.STATEVARIABLE , ITOVOLUMEPERCENT (  __context__ , (ushort)( VALUE__DOLLAR__  .UshortValue )) ) ; 
            __context__.SourceCodeLine = 145;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.VOLUMEINPUT != VALUE__DOLLAR__  .UshortValue))  ) ) 
                { 
                __context__.SourceCodeLine = 147;
                if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOKGAIN)  ) ) 
                    { 
                    __context__.SourceCodeLine = 149;
                    _SplusNVRAM.XOKGAIN = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 150;
                    _SplusNVRAM.VOLUMEINPUT = (ushort) ( VALUE__DOLLAR__  .UshortValue ) ; 
                    __context__.SourceCodeLine = 151;
                    VALUE_FB__DOLLAR__  .Value = (ushort) ( VALUE__DOLLAR__  .UshortValue ) ; 
                    __context__.SourceCodeLine = 152;
                    MakeString ( TX__DOLLAR__ , "\u008D\u0000\u0000\u0003{0}{1}{2}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , _SplusNVRAM.STATEVARIABLE , ITOVOLUMEPERCENT (  __context__ , (ushort)( VALUE__DOLLAR__  .UshortValue )) ) ; 
                    __context__.SourceCodeLine = 153;
                    _SplusNVRAM.XOKGAIN = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SUBSCRIBE__DOLLAR___OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 174;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_2__" , 20 , __SPLS_TMPVAR__WAITLABEL_2___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_2___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 176;
            if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOKSUBSCRIBE)  ) ) 
                { 
                __context__.SourceCodeLine = 178;
                _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 179;
                MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}{1}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , _SplusNVRAM.STATEVARIABLE ) ; 
                __context__.SourceCodeLine = 180;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 181;
                _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 1 ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object UNSUBSCRIBE__DOLLAR___OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 189;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOKSUBSCRIBE)  ) ) 
            { 
            __context__.SourceCodeLine = 191;
            _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 192;
            MakeString ( TX__DOLLAR__ , "\u008F\u0000\u0000\u0003{0}{1}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , _SplusNVRAM.STATEVARIABLE ) ; 
            __context__.SourceCodeLine = 193;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 194;
            _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 209;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOK)  ) ) 
            { 
            __context__.SourceCodeLine = 211;
            _SplusNVRAM.XOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 212;
            while ( Functions.TestForTrue  ( ( Functions.Length( RX__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 214;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 216;
                    _SplusNVRAM.TEMPSTRING  .UpdateValue ( Functions.Remove ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 217;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == OBJECTID__DOLLAR__) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 219;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( _SplusNVRAM.TEMPSTRING , (int)( 9 ) ) == Byte( _SplusNVRAM.STATEVARIABLE , (int)( 1 ) )) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _SplusNVRAM.TEMPSTRING , (int)( 10 ) ) == Byte( _SplusNVRAM.STATEVARIABLE , (int)( 2 ) )) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 221;
                            VALUE_FB__DOLLAR__  .Value = (ushort) ( VOLUMEPERCENTTOI( __context__ , Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 11 ) , (int)( 4 ) ) ) ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 224;
                    Functions.ClearBuffer ( _SplusNVRAM.TEMPSTRING ) ; 
                    } 
                
                __context__.SourceCodeLine = 212;
                } 
            
            __context__.SourceCodeLine = 227;
            _SplusNVRAM.XOK = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 247;
        _SplusNVRAM.XOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 248;
        _SplusNVRAM.XOKSUBSCRIBE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 249;
        _SplusNVRAM.XOKGAIN = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.RETURNSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _SplusNVRAM.TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    _SplusNVRAM.STATEVARIABLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    
    SUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( SUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( SUBSCRIBE__DOLLAR____DigitalInput__, SUBSCRIBE__DOLLAR__ );
    
    UNSUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( UNSUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( UNSUBSCRIBE__DOLLAR____DigitalInput__, UNSUBSCRIBE__DOLLAR__ );
    
    VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( VALUE__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( VALUE__DOLLAR____AnalogSerialInput__, VALUE__DOLLAR__ );
    
    STATEVARIABLE__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( STATEVARIABLE__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( STATEVARIABLE__DOLLAR____AnalogSerialInput__, STATEVARIABLE__DOLLAR__ );
    
    VALUE_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogOutput( VALUE_FB__DOLLAR____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VALUE_FB__DOLLAR____AnalogSerialOutput__, VALUE_FB__DOLLAR__ );
    
    OBJECTID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( OBJECTID__DOLLAR____AnalogSerialInput__, 3, this );
    m_StringInputList.Add( OBJECTID__DOLLAR____AnalogSerialInput__, OBJECTID__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 400, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_2___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_2___CallbackFn );
    
    STATEVARIABLE__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( STATEVARIABLE__DOLLAR___OnChange_0, false ) );
    VALUE__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( VALUE__DOLLAR___OnChange_1, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnPush_2, false ) );
    UNSUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNSUBSCRIBE__DOLLAR___OnPush_3, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_GENERIC_PERCENT ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_2___Callback;


const uint VALUE__DOLLAR____AnalogSerialInput__ = 0;
const uint OBJECTID__DOLLAR____AnalogSerialInput__ = 1;
const uint STATEVARIABLE__DOLLAR____AnalogSerialInput__ = 2;
const uint SUBSCRIBE__DOLLAR____DigitalInput__ = 0;
const uint UNSUBSCRIBE__DOLLAR____DigitalInput__ = 1;
const uint RX__DOLLAR____AnalogSerialInput__ = 3;
const uint VALUE_FB__DOLLAR____AnalogSerialOutput__ = 0;
const uint TX__DOLLAR____AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort I = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort VOLUME = 0;
            [SplusStructAttribute(2, false, true)]
            public CrestronString RETURNSTRING;
            [SplusStructAttribute(3, false, true)]
            public ushort RETURNI = 0;
            [SplusStructAttribute(4, false, true)]
            public ushort XOK = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort XOKSUBSCRIBE = 0;
            [SplusStructAttribute(6, false, true)]
            public ushort VOLUMEINPUT = 0;
            [SplusStructAttribute(7, false, true)]
            public ushort XOKGAIN = 0;
            [SplusStructAttribute(8, false, true)]
            public CrestronString TEMPSTRING;
            [SplusStructAttribute(9, false, true)]
            public CrestronString STATEVARIABLE;
            
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
