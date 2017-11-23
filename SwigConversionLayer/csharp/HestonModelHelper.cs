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

public class HestonModelHelper : CalibrationHelper {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal HestonModelHelper(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.HestonModelHelper_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HestonModelHelper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HestonModelHelper() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_HestonModelHelper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HestonModelHelper(Period maturity, Calendar calendar, double s0, double strikePrice, QuoteHandle volatility, YieldTermStructureHandle riskFreeRate, YieldTermStructureHandle dividendYield, _CalibrationHelper.CalibrationErrorType errorType) : this(NQuantLibcPINVOKE.new_HestonModelHelper__SWIG_0(Period.getCPtr(maturity), Calendar.getCPtr(calendar), s0, strikePrice, QuoteHandle.getCPtr(volatility), YieldTermStructureHandle.getCPtr(riskFreeRate), YieldTermStructureHandle.getCPtr(dividendYield), (int)errorType), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public HestonModelHelper(Period maturity, Calendar calendar, double s0, double strikePrice, QuoteHandle volatility, YieldTermStructureHandle riskFreeRate, YieldTermStructureHandle dividendYield) : this(NQuantLibcPINVOKE.new_HestonModelHelper__SWIG_1(Period.getCPtr(maturity), Calendar.getCPtr(calendar), s0, strikePrice, QuoteHandle.getCPtr(volatility), YieldTermStructureHandle.getCPtr(riskFreeRate), YieldTermStructureHandle.getCPtr(dividendYield)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
