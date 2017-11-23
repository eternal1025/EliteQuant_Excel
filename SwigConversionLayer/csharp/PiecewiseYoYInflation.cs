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

public class PiecewiseYoYInflation : YoYInflationTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PiecewiseYoYInflation(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.PiecewiseYoYInflation_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PiecewiseYoYInflation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PiecewiseYoYInflation() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_PiecewiseYoYInflation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PiecewiseYoYInflation(Date referenceDate, Calendar calendar, DayCounter dayCounter, Period lag, Frequency frequency, bool indexIsInterpolated, double baseRate, YieldTermStructureHandle nominalTS, YoYHelperVector instruments, double accuracy, Linear i) : this(NQuantLibcPINVOKE.new_PiecewiseYoYInflation__SWIG_0(Date.getCPtr(referenceDate), Calendar.getCPtr(calendar), DayCounter.getCPtr(dayCounter), Period.getCPtr(lag), (int)frequency, indexIsInterpolated, baseRate, YieldTermStructureHandle.getCPtr(nominalTS), YoYHelperVector.getCPtr(instruments), accuracy, Linear.getCPtr(i)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseYoYInflation(Date referenceDate, Calendar calendar, DayCounter dayCounter, Period lag, Frequency frequency, bool indexIsInterpolated, double baseRate, YieldTermStructureHandle nominalTS, YoYHelperVector instruments, double accuracy) : this(NQuantLibcPINVOKE.new_PiecewiseYoYInflation__SWIG_1(Date.getCPtr(referenceDate), Calendar.getCPtr(calendar), DayCounter.getCPtr(dayCounter), Period.getCPtr(lag), (int)frequency, indexIsInterpolated, baseRate, YieldTermStructureHandle.getCPtr(nominalTS), YoYHelperVector.getCPtr(instruments), accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseYoYInflation(Date referenceDate, Calendar calendar, DayCounter dayCounter, Period lag, Frequency frequency, bool indexIsInterpolated, double baseRate, YieldTermStructureHandle nominalTS, YoYHelperVector instruments) : this(NQuantLibcPINVOKE.new_PiecewiseYoYInflation__SWIG_2(Date.getCPtr(referenceDate), Calendar.getCPtr(calendar), DayCounter.getCPtr(dayCounter), Period.getCPtr(lag), (int)frequency, indexIsInterpolated, baseRate, YieldTermStructureHandle.getCPtr(nominalTS), YoYHelperVector.getCPtr(instruments)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DateVector dates() {
    DateVector ret = new DateVector(NQuantLibcPINVOKE.PiecewiseYoYInflation_dates(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector times() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.PiecewiseYoYInflation_times(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NodeVector nodes() {
    NodeVector ret = new NodeVector(NQuantLibcPINVOKE.PiecewiseYoYInflation_nodes(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
