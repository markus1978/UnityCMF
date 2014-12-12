using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EEnum : EModelElement,ENamedElement,EClassifier,EDataType {
		CList<EEnumLiteral> ELiterals { get; }
		
	}
	public class EEnumImpl : EDataTypeImpl, EEnum {
		// PROTECTED REGION ID(EEnum.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EEnumImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EEnum.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private CList<EEnumLiteral> _eLiterals;
		public CList<EEnumLiteral> ELiterals {
			get {
				if (_eLiterals == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EEnum_ELiterals;
					_eLiterals = new CList<EEnumLiteral>(this, feature);
				}
				return _eLiterals;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "eLiterals" : 
				return ELiterals;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
