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

public class PricingPeriodExt : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PricingPeriodExt(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PricingPeriodExt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PricingPeriodExt() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_PricingPeriodExt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PricingPeriodExt(Date startDate, Date endDate, Date paymentDate, double quantity, double payCoeff, double recCoeff, double paySpread, double recSpread) : this(NQuantLibcPINVOKE.new_PricingPeriodExt__SWIG_0(Date.getCPtr(startDate), Date.getCPtr(endDate), Date.getCPtr(paymentDate), quantity, payCoeff, recCoeff, paySpread, recSpread), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PricingPeriodExt(Date startDate, Date endDate, Date paymentDate, double quantity, double payCoeff, double recCoeff, double paySpread) : this(NQuantLibcPINVOKE.new_PricingPeriodExt__SWIG_1(Date.getCPtr(startDate), Date.getCPtr(endDate), Date.getCPtr(paymentDate), quantity, payCoeff, recCoeff, paySpread), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PricingPeriodExt(Date startDate, Date endDate, Date paymentDate, double quantity, double payCoeff, double recCoeff) : this(NQuantLibcPINVOKE.new_PricingPeriodExt__SWIG_2(Date.getCPtr(startDate), Date.getCPtr(endDate), Date.getCPtr(paymentDate), quantity, payCoeff, recCoeff), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PricingPeriodExt(Date startDate, Date endDate, Date paymentDate, double quantity, double payCoeff) : this(NQuantLibcPINVOKE.new_PricingPeriodExt__SWIG_3(Date.getCPtr(startDate), Date.getCPtr(endDate), Date.getCPtr(paymentDate), quantity, payCoeff), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PricingPeriodExt(Date startDate, Date endDate, Date paymentDate, double quantity) : this(NQuantLibcPINVOKE.new_PricingPeriodExt__SWIG_4(Date.getCPtr(startDate), Date.getCPtr(endDate), Date.getCPtr(paymentDate), quantity), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Date paymentDate() {
    Date ret = new Date(NQuantLibcPINVOKE.PricingPeriodExt_paymentDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double quantity() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_quantity(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double payCoeff() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_payCoeff(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double paySpread() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_paySpread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double recCoeff() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_recCoeff(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double recSpread() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_recSpread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getuPayDelta() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_getuPayDelta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getdPayDelta() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_getdPayDelta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getuRecDelta() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_getuRecDelta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getdRecDelta() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_getdRecDelta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getFinalized() {
    double ret = NQuantLibcPINVOKE.PricingPeriodExt_getFinalized(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
