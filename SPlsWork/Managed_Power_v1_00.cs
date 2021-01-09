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

namespace UserModule_MANAGED_POWER_V1_00
{
    public class UserModuleClass_MANAGED_POWER_V1_00 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON_FB;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalInput SMART_POWER;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_POWER;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_ON_TRIG;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_OFF_TRIG;
        private void POWER (  SplusExecutionContext __context__, ushort NSTATE ) 
            { 
            
            __context__.SourceCodeLine = 14;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)NSTATE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 18;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( POWER_ON_FB  .Value ) ) || Functions.TestForTrue ( Functions.Not( SMART_POWER  .Value ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 20;
                            Functions.Pulse ( 1, POWER_ON_TRIG ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 25;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( POWER_OFF_FB  .Value ) ) || Functions.TestForTrue ( Functions.Not( SMART_POWER  .Value ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 27;
                            Functions.Pulse ( 1, POWER_OFF_TRIG ) ; 
                            } 
                        
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        object POWER_ON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 35;
                POWER (  __context__ , (ushort)( 1 )) ; 
                
                
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
            
            __context__.SourceCodeLine = 40;
            if ( Functions.TestForTrue  ( ( Functions.Not( AUTO_POWER  .Value ))  ) ) 
                {
                __context__.SourceCodeLine = 41;
                POWER (  __context__ , (ushort)( 0 )) ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object AUTO_POWER_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 46;
        POWER (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_ON_FB_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 51;
        if ( Functions.TestForTrue  ( ( AUTO_POWER  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 52;
            POWER (  __context__ , (ushort)( 1 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
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
    
    SMART_POWER = new Crestron.Logos.SplusObjects.DigitalInput( SMART_POWER__DigitalInput__, this );
    m_DigitalInputList.Add( SMART_POWER__DigitalInput__, SMART_POWER );
    
    AUTO_POWER = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_POWER__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_POWER__DigitalInput__, AUTO_POWER );
    
    POWER_ON_TRIG = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_ON_TRIG__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_ON_TRIG__DigitalOutput__, POWER_ON_TRIG );
    
    POWER_OFF_TRIG = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_OFF_TRIG__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_OFF_TRIG__DigitalOutput__, POWER_OFF_TRIG );
    
    
    POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_OnPush_0, false ) );
    POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_OnPush_1, false ) );
    AUTO_POWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_POWER_OnPush_2, false ) );
    POWER_ON_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( POWER_ON_FB_OnRelease_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_MANAGED_POWER_V1_00 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POWER_ON__DigitalInput__ = 0;
const uint POWER_OFF__DigitalInput__ = 1;
const uint POWER_ON_FB__DigitalInput__ = 2;
const uint POWER_OFF_FB__DigitalInput__ = 3;
const uint SMART_POWER__DigitalInput__ = 4;
const uint AUTO_POWER__DigitalInput__ = 5;
const uint POWER_ON_TRIG__DigitalOutput__ = 0;
const uint POWER_OFF_TRIG__DigitalOutput__ = 1;

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
