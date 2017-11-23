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

public class SwaptionVolatilityStructure : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SwaptionVolatilityStructure(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SwaptionVolatilityStructure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SwaptionVolatilityStructure() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SwaptionVolatilityStructure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_SwaptionVolatilityStructure __deref__() {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.SwaptionVolatilityStructure___deref__(swigCPtr);
    SWIGTYPE_p_SwaptionVolatilityStructure ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_SwaptionVolatilityStructure(cPtr, false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNull() {
    bool ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_isNull(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.SwaptionVolatilityStructure_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SwaptionVolatilityStructure() : this(NQuantLibcPINVOKE.new_SwaptionVolatilityStructure(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Date referenceDate() {
    Date ret = new Date(NQuantLibcPINVOKE.SwaptionVolatilityStructure_referenceDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter dayCounter() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.SwaptionVolatilityStructure_dayCounter(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Calendar calendar() {
    Calendar ret = new Calendar(NQuantLibcPINVOKE.SwaptionVolatilityStructure_calendar(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Period maxSwapTenor() {
    Period ret = new Period(NQuantLibcPINVOKE.SwaptionVolatilityStructure_maxSwapTenor(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxSwapLength() {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_maxSwapLength(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double minStrike() {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_minStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxStrike() {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_maxStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double volatility(Date start, Period length, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_volatility__SWIG_0(swigCPtr, Date.getCPtr(start), Period.getCPtr(length), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double volatility(Date start, Period length, double strike) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_volatility__SWIG_1(swigCPtr, Date.getCPtr(start), Period.getCPtr(length), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double volatility(double start, double length, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_volatility__SWIG_2(swigCPtr, start, length, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double volatility(double start, double length, double strike) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_volatility__SWIG_3(swigCPtr, start, length, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(Date start, Period length, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_blackVariance__SWIG_0(swigCPtr, Date.getCPtr(start), Period.getCPtr(length), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(Date start, Period length, double strike) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_blackVariance__SWIG_1(swigCPtr, Date.getCPtr(start), Period.getCPtr(length), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(double start, double length, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_blackVariance__SWIG_2(swigCPtr, start, length, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(double start, double length, double strike) {
    double ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_blackVariance__SWIG_3(swigCPtr, start, length, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableExtrapolation() {
    NQuantLibcPINVOKE.SwaptionVolatilityStructure_enableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void disableExtrapolation() {
    NQuantLibcPINVOKE.SwaptionVolatilityStructure_disableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool allowsExtrapolation() {
    bool ret = NQuantLibcPINVOKE.SwaptionVolatilityStructure_allowsExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
