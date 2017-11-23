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

public class CapFloor : Instrument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CapFloor(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CapFloor_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CapFloor obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CapFloor() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CapFloor(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public double impliedVolatility(double price, YieldTermStructureHandle curve, double guess, double accuracy, uint maxEvaluations, double minVol, double maxVol) {
    double ret = NQuantLibcPINVOKE.CapFloor_impliedVolatility__SWIG_0(swigCPtr, price, YieldTermStructureHandle.getCPtr(curve), guess, accuracy, maxEvaluations, minVol, maxVol);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double price, YieldTermStructureHandle curve, double guess, double accuracy, uint maxEvaluations, double minVol) {
    double ret = NQuantLibcPINVOKE.CapFloor_impliedVolatility__SWIG_1(swigCPtr, price, YieldTermStructureHandle.getCPtr(curve), guess, accuracy, maxEvaluations, minVol);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double price, YieldTermStructureHandle curve, double guess, double accuracy, uint maxEvaluations) {
    double ret = NQuantLibcPINVOKE.CapFloor_impliedVolatility__SWIG_2(swigCPtr, price, YieldTermStructureHandle.getCPtr(curve), guess, accuracy, maxEvaluations);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double price, YieldTermStructureHandle curve, double guess, double accuracy) {
    double ret = NQuantLibcPINVOKE.CapFloor_impliedVolatility__SWIG_3(swigCPtr, price, YieldTermStructureHandle.getCPtr(curve), guess, accuracy);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double price, YieldTermStructureHandle curve, double guess) {
    double ret = NQuantLibcPINVOKE.CapFloor_impliedVolatility__SWIG_4(swigCPtr, price, YieldTermStructureHandle.getCPtr(curve), guess);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CapFloor() : this(NQuantLibcPINVOKE.new_CapFloor(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
