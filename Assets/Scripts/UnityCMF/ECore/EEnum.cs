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
		public  CList<EEnumLiteral> ELiterals {
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
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "eLiterals" : 
					return ELiterals;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eLiterals" :
					_eLiterals.RemoveAt(_eLiterals.IndexOf(value)); 
					break;
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
