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

public class DiscreteAveragingAsianOption : Instrument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DiscreteAveragingAsianOption(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.DiscreteAveragingAsianOption_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DiscreteAveragingAsianOption obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DiscreteAveragingAsianOption() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_DiscreteAveragingAsianOption(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DiscreteAveragingAsianOption(Average.Type averageType, double runningAccumulator, uint pastFixings, DateVector fixingDates, Payoff payoff, Exercise exercise) : this(NQuantLibcPINVOKE.new_DiscreteAveragingAsianOption((int)averageType, runningAccumulator, pastFixings, DateVector.getCPtr(fixingDates), Payoff.getCPtr(payoff), Exercise.getCPtr(exercise)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double delta() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_delta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gamma() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_gamma(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double theta() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_theta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double thetaPerDay() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_thetaPerDay(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double vega() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_vega(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double rho() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_rho(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double dividendRho() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_dividendRho(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double strikeSensitivity() {
    double ret = NQuantLibcPINVOKE.DiscreteAveragingAsianOption_strikeSensitivity(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
