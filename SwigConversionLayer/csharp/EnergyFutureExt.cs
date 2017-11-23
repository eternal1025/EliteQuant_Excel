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

public class EnergyFutureExt : EnergyCommodityExt {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal EnergyFutureExt(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.EnergyFutureExt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EnergyFutureExt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EnergyFutureExt() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_EnergyFutureExt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public EnergyFutureExt(int buySell, PricingPeriodExt PricingPeriodExt, double tradePrice, CommodityIndexExt index, string commodityName, YieldTermStructureHandle discountTermStructure) : this(NQuantLibcPINVOKE.new_EnergyFutureExt(buySell, PricingPeriodExt.getCPtr(PricingPeriodExt), tradePrice, CommodityIndexExt.getCPtr(index), commodityName, YieldTermStructureHandle.getCPtr(discountTermStructure)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PricingPeriodExt pricingPeriod() {
    PricingPeriodExt ret = new PricingPeriodExt(NQuantLibcPINVOKE.EnergyFutureExt_pricingPeriod(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double tradePrice() {
    double ret = NQuantLibcPINVOKE.EnergyFutureExt_tradePrice(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double quantity() {
    double ret = NQuantLibcPINVOKE.EnergyFutureExt_quantity(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CommodityIndexExt index() {
    CommodityIndexExt ret = new CommodityIndexExt(NQuantLibcPINVOKE.EnergyFutureExt_index(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
