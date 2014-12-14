using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Ccoretest {
	public interface Interface : CObject {
		string Attribute { get; set; }
		
		void Operation();
	}

} // UnityCMF.ccoretest
