using UnityCMF.ECore;

namespace UnityCMF.CCore {
public enum Direction { none, left, top, right, bottom }
	 
	public sealed class CcoreMeta {
		public static CcoreMeta cINSTANCE = new CcoreMeta();
		public CcorePackage Package { get; private set; }
		public CcoreFactory Factory { get; private set; }
		public CcoreMeta() {
			Package = new CcorePackageImpl();
			Factory = new CcoreFactoryImpl();
		}
	}
	
	public interface CcorePackage {
		EClass C2DFieldElement { get; }
		EStructuralFeature C2DFieldElement_x { get; }
		EStructuralFeature C2DFieldElement_y { get; }
		EDataType Direction { get; }
		EDataType CAction { get; }
	}
	
	public class CcorePackageImpl : CcorePackage {
		public CcorePackageImpl() {
			C2DFieldElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			C2DFieldElement.Name = "C2DFieldElement";
			C2DFieldElement_x = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			C2DFieldElement_x.Name = "x";
			C2DFieldElement_x.LowerBound = 0;
			C2DFieldElement_x.UpperBound = 1;
			C2DFieldElement_x.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			C2DFieldElement.EStructuralFeatures.Add(C2DFieldElement_x);
			C2DFieldElement_y = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			C2DFieldElement_y.Name = "y";
			C2DFieldElement_y.LowerBound = 0;
			C2DFieldElement_y.UpperBound = 1;
			C2DFieldElement_y.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			C2DFieldElement.EStructuralFeatures.Add(C2DFieldElement_y);
					
			Direction = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			Direction.Name = "Direction";
			CAction = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			CAction.Name = "CAction";
		}
		
		public EClass C2DFieldElement { get; private set;}
		public EStructuralFeature C2DFieldElement_x  { get; private set;}
		public EStructuralFeature C2DFieldElement_y  { get; private set;}
		public EDataType Direction { get; private set;}		
		public EDataType CAction { get; private set;}		
	}
} // UnityCMF.ccore
