namespace Crestron.MediaPlayerValidator;
        // class declarations
         class MediaPlayerValidator;
         class IPInfo;
         class DirectConnectInfo;
     class MediaPlayerValidator 
    {
        // class delegates
        delegate FUNCTION DelegateSimplSharpString ( SIMPLSHARPSTRING value );

        // class events

        // class functions
        STRING_FUNCTION GenerateDirectConnectMessage ( STRING version , STRING tag , STRING source , STRING ip );
        FUNCTION GenerateDirectConnectMessageAndSend ( STRING version , STRING tag , STRING source , STRING ip );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateSimplSharpString MessageCallback;
    };

     class IPInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING ip[][];

        // class properties
    };

     class DirectConnectInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING ver[];
        STRING tag[];
        STRING src[];
        STRING ip[][];

        // class properties
    };

