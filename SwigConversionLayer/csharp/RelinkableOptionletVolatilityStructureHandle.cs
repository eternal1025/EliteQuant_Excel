//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace EliteQuant {

public class RelinkableOptionletVolatilityStructureHandle : OptionletVolatilityStructureHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RelinkableOptionletVolatilityStructureHandle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.RelinkableOptionletVolatilityStructureHandle_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RelinkableOptionletVolatilityStructureHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RelinkableOptionletVolatilityStructureHandle() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_RelinkableOptionletVolatilityStructureHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RelinkableOptionletVolatilityStructureHandle(OptionletVolatilityStructure arg0) : this(NQuantLibcPINVOKE.new_RelinkableOptionletVolatilityStructureHandle__SWIG_0(OptionletVolatilityStructure.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableOptionletVolatilityStructureHandle() : this(NQuantLibcPINVOKE.new_RelinkableOptionletVolatilityStructureHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void linkTo(OptionletVolatilityStructure arg0) {
    NQuantLibcPINVOKE.RelinkableOptionletVolatilityStructureHandle_linkTo(swigCPtr, OptionletVolatilityStructure.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
