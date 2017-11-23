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

public class BlackConstantVol : BlackVolTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BlackConstantVol(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.BlackConstantVol_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BlackConstantVol obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlackConstantVol() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_BlackConstantVol(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BlackConstantVol(Date referenceDate, Calendar c, double volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_BlackConstantVol__SWIG_0(Date.getCPtr(referenceDate), Calendar.getCPtr(c), volatility, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlackConstantVol(Date referenceDate, Calendar c, QuoteHandle volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_BlackConstantVol__SWIG_1(Date.getCPtr(referenceDate), Calendar.getCPtr(c), QuoteHandle.getCPtr(volatility), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlackConstantVol(uint settlementDays, Calendar calendar, double volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_BlackConstantVol__SWIG_2(settlementDays, Calendar.getCPtr(calendar), volatility, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlackConstantVol(uint settlementDays, Calendar calendar, QuoteHandle volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_BlackConstantVol__SWIG_3(settlementDays, Calendar.getCPtr(calendar), QuoteHandle.getCPtr(volatility), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
