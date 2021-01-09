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

namespace UserModule_MANAGED_POWER___INPUT_F_X__V1_02
{
    public class UserModuleClass_MANAGED_POWER___INPUT_F_X__V1_02 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput Y_0;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> Y;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> X;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUTPUT;
        ushort GNINITCOMPLETE = 0;
        object X_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort NLMAI = 0;
                
                
                __context__.SourceCodeLine = 18;
                if ( Functions.TestForTrue  ( ( GNINITCOMPLETE)  ) ) 
                    { 
                    __context__.SourceCodeLine = 20;
                    NLMAI = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                    __context__.SourceCodeLine = 22;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (X[ NLMAI ] .UshortValue == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 24;
                        OUTPUT [ NLMAI]  .Value = (ushort) ( Y_0  .UshortValue ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 26;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X[ NLMAI ] .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( X[ NLMAI ] .UshortValue <= 48 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 28;
                            if ( Functions.TestForTrue  ( ( Y[ X[ NLMAI ] .UshortValue ] .UshortValue)  ) ) 
                                { 
                                __context__.SourceCodeLine = 30;
                                OUTPUT [ NLMAI]  .Value = (ushort) ( Y[ X[ NLMAI ] .UshortValue ] .UshortValue ) ; 
                                } 
                            
                            } 
                        
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
            
            __context__.SourceCodeLine = 38;
            GNINITCOMPLETE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 39;
            GNINITCOMPLETE = (ushort) ( Functions.Not( WaitForInitializationComplete() ) ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        Y_0 = new Crestron.Logos.SplusObjects.AnalogInput( Y_0__AnalogSerialInput__, this );
        m_AnalogInputList.Add( Y_0__AnalogSerialInput__, Y_0 );
        
        Y = new InOutArray<AnalogInput>( 48, this );
        for( uint i = 0; i < 48; i++ )
        {
            Y[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( Y__AnalogSerialInput__ + i, Y__AnalogSerialInput__, this );
            m_AnalogInputList.Add( Y__AnalogSerialInput__ + i, Y[i+1] );
        }
        
        X = new InOutArray<AnalogInput>( 1, this );
        for( uint i = 0; i < 1; i++ )
        {
            X[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( X__AnalogSerialInput__ + i, X__AnalogSerialInput__, this );
            m_AnalogInputList.Add( X__AnalogSerialInput__ + i, X[i+1] );
        }
        
        OUTPUT = new InOutArray<AnalogOutput>( 1, this );
        for( uint i = 0; i < 1; i++ )
        {
            OUTPUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT__AnalogSerialOutput__ + i, this );
            m_AnalogOutputList.Add( OUTPUT__AnalogSerialOutput__ + i, OUTPUT[i+1] );
        }
        
        
        for( uint i = 0; i < 1; i++ )
            X[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( X_OnChange_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_MANAGED_POWER___INPUT_F_X__V1_02 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint Y_0__AnalogSerialInput__ = 0;
    const uint Y__AnalogSerialInput__ = 1;
    const uint X__AnalogSerialInput__ = 49;
    const uint OUTPUT__AnalogSerialOutput__ = 0;
    
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
