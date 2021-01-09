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

namespace UserModule_DIGITAL_EDGE_DETECTION_V1_00
{
    public class UserModuleClass_DIGITAL_EDGE_DETECTION_V1_00 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput IN;
        Crestron.Logos.SplusObjects.DigitalOutput RISING_EDGE;
        Crestron.Logos.SplusObjects.DigitalOutput FALLING_EDGE;
        object IN_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 11;
                Functions.Pulse ( 1, RISING_EDGE ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object IN_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 16;
            Functions.Pulse ( 1, FALLING_EDGE ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    IN = new Crestron.Logos.SplusObjects.DigitalInput( IN__DigitalInput__, this );
    m_DigitalInputList.Add( IN__DigitalInput__, IN );
    
    RISING_EDGE = new Crestron.Logos.SplusObjects.DigitalOutput( RISING_EDGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( RISING_EDGE__DigitalOutput__, RISING_EDGE );
    
    FALLING_EDGE = new Crestron.Logos.SplusObjects.DigitalOutput( FALLING_EDGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FALLING_EDGE__DigitalOutput__, FALLING_EDGE );
    
    
    IN.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_OnPush_0, false ) );
    IN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( IN_OnRelease_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DIGITAL_EDGE_DETECTION_V1_00 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint IN__DigitalInput__ = 0;
const uint RISING_EDGE__DigitalOutput__ = 0;
const uint FALLING_EDGE__DigitalOutput__ = 1;

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
