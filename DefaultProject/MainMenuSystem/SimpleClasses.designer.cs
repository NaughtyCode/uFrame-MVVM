// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;


public class RequestMainMenuScreenCommandBase : object {
    
    private Type _ScreenType;
    
    public Type ScreenType {
        get {
            return _ScreenType;
        }
        set {
            _ScreenType = value;
        }
    }
    
    public virtual string Serialize() {
        var jsonObject = new JSONClass();
        return jsonObject.ToString();
    }
    
    public virtual void Deserialize(string json) {
        var node = JSON.Parse(json);
    }
}
