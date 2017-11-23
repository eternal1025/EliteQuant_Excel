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

public class IMM : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IMM(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IMM obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IMM() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_IMM(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static bool isIMMdate(Date d, bool mainCycle) {
    bool ret = NQuantLibcPINVOKE.IMM_isIMMdate__SWIG_0(Date.getCPtr(d), mainCycle);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isIMMdate(Date d) {
    bool ret = NQuantLibcPINVOKE.IMM_isIMMdate__SWIG_1(Date.getCPtr(d));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isIMMcode(string code, bool mainCycle) {
    bool ret = NQuantLibcPINVOKE.IMM_isIMMcode__SWIG_0(code, mainCycle);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isIMMcode(string code) {
    bool ret = NQuantLibcPINVOKE.IMM_isIMMcode__SWIG_1(code);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string code(Date immDate) {
    string ret = NQuantLibcPINVOKE.IMM_code(Date.getCPtr(immDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date date(string immCode, Date referenceDate) {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_date__SWIG_0(immCode, Date.getCPtr(referenceDate)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date date(string immCode) {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_date__SWIG_1(immCode), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextDate(Date d, bool mainCycle) {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_nextDate__SWIG_0(Date.getCPtr(d), mainCycle), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextDate(Date d) {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_nextDate__SWIG_1(Date.getCPtr(d)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextDate() {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_nextDate__SWIG_2(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextDate(string immCode, bool mainCycle, Date referenceDate) {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_nextDate__SWIG_3(immCode, mainCycle, Date.getCPtr(referenceDate)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextDate(string immCode, bool mainCycle) {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_nextDate__SWIG_4(immCode, mainCycle), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextDate(string immCode) {
    Date ret = new Date(NQuantLibcPINVOKE.IMM_nextDate__SWIG_5(immCode), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string nextCode(Date d, bool mainCycle) {
    string ret = NQuantLibcPINVOKE.IMM_nextCode__SWIG_0(Date.getCPtr(d), mainCycle);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string nextCode(Date d) {
    string ret = NQuantLibcPINVOKE.IMM_nextCode__SWIG_1(Date.getCPtr(d));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string nextCode() {
    string ret = NQuantLibcPINVOKE.IMM_nextCode__SWIG_2();
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string nextCode(string immCode, bool mainCycle, Date referenceDate) {
    string ret = NQuantLibcPINVOKE.IMM_nextCode__SWIG_3(immCode, mainCycle, Date.getCPtr(referenceDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string nextCode(string immCode, bool mainCycle) {
    string ret = NQuantLibcPINVOKE.IMM_nextCode__SWIG_4(immCode, mainCycle);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string nextCode(string immCode) {
    string ret = NQuantLibcPINVOKE.IMM_nextCode__SWIG_5(immCode);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IMM() : this(NQuantLibcPINVOKE.new_IMM(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum Month {
    F = 1,
    G = 2,
    H = 3,
    J = 4,
    K = 5,
    M = 6,
    N = 7,
    Q = 8,
    U = 9,
    V = 10,
    X = 11,
    Z = 12
  }

}

}
