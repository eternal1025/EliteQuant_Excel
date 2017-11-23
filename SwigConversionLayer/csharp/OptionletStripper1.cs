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

public class OptionletStripper1 : StrippedOptionletBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal OptionletStripper1(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.OptionletStripper1_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OptionletStripper1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OptionletStripper1() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_OptionletStripper1(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index, double switchStrikes, double accuracy, uint maxIter, YieldTermStructureHandle discount, VolatilityType type, double displacement, bool dontThrow) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_0(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index), switchStrikes, accuracy, maxIter, YieldTermStructureHandle.getCPtr(discount), (int)type, displacement, dontThrow), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index, double switchStrikes, double accuracy, uint maxIter, YieldTermStructureHandle discount, VolatilityType type, double displacement) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_1(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index), switchStrikes, accuracy, maxIter, YieldTermStructureHandle.getCPtr(discount), (int)type, displacement), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index, double switchStrikes, double accuracy, uint maxIter, YieldTermStructureHandle discount, VolatilityType type) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_2(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index), switchStrikes, accuracy, maxIter, YieldTermStructureHandle.getCPtr(discount), (int)type), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index, double switchStrikes, double accuracy, uint maxIter, YieldTermStructureHandle discount) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_3(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index), switchStrikes, accuracy, maxIter, YieldTermStructureHandle.getCPtr(discount)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index, double switchStrikes, double accuracy, uint maxIter) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_4(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index), switchStrikes, accuracy, maxIter), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index, double switchStrikes, double accuracy) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_5(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index), switchStrikes, accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index, double switchStrikes) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_6(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index), switchStrikes), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OptionletStripper1(CapFloorTermVolSurface parVolSurface, IborIndex index) : this(NQuantLibcPINVOKE.new_OptionletStripper1__SWIG_7(CapFloorTermVolSurface.getCPtr(parVolSurface), IborIndex.getCPtr(index)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix capFloorPrices() {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.OptionletStripper1_capFloorPrices(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix capFloorVolatilities() {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.OptionletStripper1_capFloorVolatilities(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix optionletPrices() {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.OptionletStripper1_optionletPrices(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double switchStrike() {
    double ret = NQuantLibcPINVOKE.OptionletStripper1_switchStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
