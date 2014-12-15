using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(Interface.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.Ccoretest {
	public interface Interface : CObject {
		string Attribute { get; set; }
		
		void Operation();
	}

} // UnityCMF.ccoretest
