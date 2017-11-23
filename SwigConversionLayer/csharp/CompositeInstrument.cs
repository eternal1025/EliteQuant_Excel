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

public class CompositeInstrument : Instrument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CompositeInstrument(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CompositeInstrument_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CompositeInstrument obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CompositeInstrument() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CompositeInstrument(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CompositeInstrument() : this(NQuantLibcPINVOKE.new_CompositeInstrument(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add(Instrument instrument, double multiplier) {
    NQuantLibcPINVOKE.CompositeInstrument_add__SWIG_0(swigCPtr, Instrument.getCPtr(instrument), multiplier);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add(Instrument instrument) {
    NQuantLibcPINVOKE.CompositeInstrument_add__SWIG_1(swigCPtr, Instrument.getCPtr(instrument));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void subtract(Instrument instrument, double multiplier) {
    NQuantLibcPINVOKE.CompositeInstrument_subtract__SWIG_0(swigCPtr, Instrument.getCPtr(instrument), multiplier);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void subtract(Instrument instrument) {
    NQuantLibcPINVOKE.CompositeInstrument_subtract__SWIG_1(swigCPtr, Instrument.getCPtr(instrument));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
