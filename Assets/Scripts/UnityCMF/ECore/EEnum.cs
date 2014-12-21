using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EEnum.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EEnum : EModelElement,ENamedElement,EClassifier,EDataType {
		CList<EEnumLiteral> ELiterals { get; }
		
	}
	public class EEnumImpl : EDataTypeImpl, EEnum {
	
		public EEnumImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EEnum.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EEnum.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private CList<EEnumLiteral> _eLiterals;
		public CList<EEnumLiteral> ELiterals {
			get {
				if (_eLiterals == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EEnum_ELiterals;
					_eLiterals = new CList<EEnumLiteral>(false, this, feature);
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
