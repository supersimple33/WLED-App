using System;
using Foundation;
using Intents;

// is this necessary
//namespace WLED.iOS.Data
//{
//    public class ToggleLED : NSObject
//    {
//        public string LED { get; private set; }
//        public bool STATE { get; private set; }
//        public ToggleLED(string led, bool state)
//        {
//            LED = led;
//            STATE = state; 
//        }

//        #region Intent
//        public ToggleLEDIntent Intent
//        {
//            get
//            {
//                var toggleLEDIntent = new ToggleLEDIntent();
//                toggleLEDIntent.STATE = new NSNumber(STATE); //use nsnumber for now?
//                toggleLEDIntent.LED = new NSString(LED);

//                return toggleLEDIntent;
//            }
//        }
//    }
//}
