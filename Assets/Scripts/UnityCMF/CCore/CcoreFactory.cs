using UnityCMF.ECore;

namespace UnityCMF.CCore {
	public interface CcoreFactory {
		C2DFieldElement CreateC2DFieldElement();
	}

	public class CcoreFactoryImpl : CcoreFactory {
		public C2DFieldElement CreateC2DFieldElement() {
			UnityCMF.ECore.EClass eClass = CcoreMeta.cINSTANCE.Package.C2DFieldElement;
			return new C2DFieldElementImpl(eClass);
		}
	}
} // UnityCMF.ccore
