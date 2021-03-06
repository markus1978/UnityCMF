using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.CCore {
	public enum Direction { none, left, top, right, bottom, start }
	
	public sealed class CCoreMeta {
		public static CCoreMeta cINSTANCE = new CCoreMeta();
		private CCorePackageImpl _package = new CCorePackageImpl();
		private CCoreFactoryImpl _factory = new CCoreFactoryImpl();
		public CCorePackage Package { 
			get {
				_package.init();
				return _package;
			}
		}
		public CCoreFactory Factory { 
			get {
				return _factory;
			} 
		}
	}
	public interface CCorePackage : CPackage {
		EClass C2DFieldElement { get; }
		EAttribute C2DFieldElement_X { get; }
		EAttribute C2DFieldElement_Y { get; }
		EDataType Direction { get; }
		EDataType CAction { get; }
		EDataType CPackage { get; }
		EDataType CFactory { get; }
		EDataType CUnsingedInt { get; }
	}
	public class CCorePackageImpl : CCorePackage {
		public CFactory FactoryInstance {
			get {
				return CCoreMeta.cINSTANCE.Factory;
			}	
		}
		
		private bool _isInited = false;
		
		public void init() {
			if (_isInited) return;
			_isInited = true;				
			C2DFieldElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			C2DFieldElement.Name = "C2DFieldElement";
			C2DFieldElement.CPackage = this;
			Direction = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			Direction.Name = "Direction";
			Direction.CPackage = this;
			CAction = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			CAction.Name = "CAction";
			CAction.CPackage = this;
			CPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			CPackage.Name = "CPackage";
			CPackage.CPackage = this;
			CFactory = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			CFactory.Name = "CFactory";
			CFactory.CPackage = this;
			CUnsingedInt = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			CUnsingedInt.Name = "CUnsingedInt";
			CUnsingedInt.CPackage = this;
			C2DFieldElement_X = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			C2DFieldElement_X.Name = "x";
			C2DFieldElement_X.LowerBound = 0;
			C2DFieldElement_X.UpperBound = 1;
			C2DFieldElement_X.Derived = false;
			C2DFieldElement_X.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			C2DFieldElement.EStructuralFeatures.Add(C2DFieldElement_X);
			C2DFieldElement_Y = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			C2DFieldElement_Y.Name = "y";
			C2DFieldElement_Y.LowerBound = 0;
			C2DFieldElement_Y.UpperBound = 1;
			C2DFieldElement_Y.Derived = false;
			C2DFieldElement_Y.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			C2DFieldElement.EStructuralFeatures.Add(C2DFieldElement_Y);
		}
		
		public EClass C2DFieldElement { get; private set;}
		public EAttribute C2DFieldElement_X  { get; private set;}
		public EAttribute C2DFieldElement_Y  { get; private set;}
		public EDataType Direction { get; private set;}		
		public EDataType CAction { get; private set;}		
		public EDataType CPackage { get; private set;}		
		public EDataType CFactory { get; private set;}		
		public EDataType CUnsingedInt { get; private set;}		
		
		public EClassifier getClassifier(string name) {
			switch(name) {
				case "C2DFieldElement": return CCoreMeta.cINSTANCE.Package.C2DFieldElement;
				case "Direction": return CCoreMeta.cINSTANCE.Package.Direction;
				case "CAction": return CCoreMeta.cINSTANCE.Package.CAction;
				case "CPackage": return CCoreMeta.cINSTANCE.Package.CPackage;
				case "CFactory": return CCoreMeta.cINSTANCE.Package.CFactory;
				case "CUnsingedInt": return CCoreMeta.cINSTANCE.Package.CUnsingedInt;
				default: return null;	
			}	
		}
	}
	public interface CCoreFactory : CFactory {
	}
	public class CCoreFactoryImpl : CCoreFactory {
		public CPackage PackageInstance {
			get {
				return CCoreMeta.cINSTANCE.Package;
			}	
		}
		
		
		public CObject create(EClass eClass) {
			switch(eClass.Name) {
				default: return null;	
			}	
		}
	}
	
} // UnityCMF.CCore
