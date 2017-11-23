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

public class BlackCalculator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BlackCalculator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BlackCalculator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlackCalculator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_BlackCalculator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BlackCalculator(Payoff payoff, double forward, double stdDev, double discount) : this(NQuantLibcPINVOKE.new_BlackCalculator__SWIG_0(Payoff.getCPtr(payoff), forward, stdDev, discount), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlackCalculator(Payoff payoff, double forward, double stdDev) : this(NQuantLibcPINVOKE.new_BlackCalculator__SWIG_1(Payoff.getCPtr(payoff), forward, stdDev), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double value() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_value(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double deltaForward() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_deltaForward(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double delta(double spot) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_delta(swigCPtr, spot);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double elasticityForward() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_elasticityForward(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double elasticity(double spot) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_elasticity(swigCPtr, spot);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gammaForward() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_gammaForward(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gamma(double spot) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_gamma(swigCPtr, spot);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double theta(double spot, double maturity) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_theta(swigCPtr, spot, maturity);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double thetaPerDay(double spot, double maturity) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_thetaPerDay(swigCPtr, spot, maturity);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double vega(double maturity) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_vega(swigCPtr, maturity);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double rho(double maturity) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_rho(swigCPtr, maturity);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double dividendRho(double maturity) {
    double ret = NQuantLibcPINVOKE.BlackCalculator_dividendRho(swigCPtr, maturity);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double itmCashProbability() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_itmCashProbability(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double itmAssetProbability() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_itmAssetProbability(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double strikeSensitivity() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_strikeSensitivity(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double alpha() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_alpha(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double beta() {
    double ret = NQuantLibcPINVOKE.BlackCalculator_beta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
