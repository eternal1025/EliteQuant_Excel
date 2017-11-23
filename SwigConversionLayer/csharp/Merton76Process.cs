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

public class Merton76Process : StochasticProcess1D {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Merton76Process(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.Merton76Process_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Merton76Process obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Merton76Process() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_Merton76Process(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Merton76Process(QuoteHandle stateVariable, YieldTermStructureHandle dividendTS, YieldTermStructureHandle riskFreeTS, BlackVolTermStructureHandle volTS, QuoteHandle jumpIntensity, QuoteHandle meanLogJump, QuoteHandle jumpVolatility) : this(NQuantLibcPINVOKE.new_Merton76Process(QuoteHandle.getCPtr(stateVariable), YieldTermStructureHandle.getCPtr(dividendTS), YieldTermStructureHandle.getCPtr(riskFreeTS), BlackVolTermStructureHandle.getCPtr(volTS), QuoteHandle.getCPtr(jumpIntensity), QuoteHandle.getCPtr(meanLogJump), QuoteHandle.getCPtr(jumpVolatility)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
